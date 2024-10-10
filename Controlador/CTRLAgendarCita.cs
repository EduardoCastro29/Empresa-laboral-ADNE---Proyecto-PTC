using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador.Controlador_UC_Calendario;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Drawing;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLAgendarCita
    {
        readonly AgendarCitaForm ObjAgendarCitaForm;
        public CTRLAgendarCita(AgendarCitaForm Vista)
        {
            ObjAgendarCitaForm = Vista;

            ObjAgendarCitaForm.Load += new EventHandler(CargarFechayCMB);
            ObjAgendarCitaForm.btnGuardar.Click += new EventHandler(AgregarNuevaCita);
            ObjAgendarCitaForm.btnModificar.Click += new EventHandler(ModificarCita);

            //Validaciones de campos
            ObjAgendarCitaForm.txtMotivoConsulta.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjAgendarCitaForm.txtDUIPaciente.KeyPress += new KeyPressEventHandler(ValidarCampoDocumento);
            ObjAgendarCitaForm.txtDUIPaciente.KeyPress += new KeyPressEventHandler(EnmascararCampoDocumento);
        }
        #region Validaciones de Campos
        private void ValidarCampoDocumento(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            char ch = e.KeyChar;

            if ((ch >= '0' && ch <= '9') ||
                (ch == '-'))
            {
                return;
            }
            e.Handled = true;
        }
        private void EnmascararCampoDocumento(object sender, EventArgs e)
        {
            //Obtenemos la longitud actual del textbox para evaluar si es necesario el remplazo por guión (en este caso el DUI) o número
            string EnmascararDUI = ObjAgendarCitaForm.txtDUIPaciente.Text.Replace("-", "");

            //Limitamos el textbox para que solo obtenga 9 caracteres
            if (EnmascararDUI.Length > 9)
            {
                EnmascararDUI = EnmascararDUI.Substring(0, 9);
            }

            //Una vez llegada a la longitud deseada, en este caso 8 pone un guión automáticamente para enmascarar el DUI
            if (EnmascararDUI.Length > 8)
            {
                //Indicamos en qué posición se pondrá el guión y que símbolo tomará
                ObjAgendarCitaForm.txtDUIPaciente.Text = EnmascararDUI.Insert(8, "-");
            }
            else
            {
                //Caso contrario, no realizamos ningun cambio (no se inserta el guión)
                ObjAgendarCitaForm.txtDUIPaciente.Text = EnmascararDUI;
            }

            //Indicamos que la posición inicial del cursor, será al inicio del textbox
            ObjAgendarCitaForm.txtDUIPaciente.SelectionStart = ObjAgendarCitaForm.txtDUIPaciente.Text.Length;
        }
        private void ValidarCampoTextBox(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            if (char.IsLetter(e.KeyChar) ||
                e.KeyChar == ' ' ||
                e.KeyChar == ',' ||
                e.KeyChar == '.')
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        #endregion
        #region Eventos Iniciales al cargar el Formulario
        private void CargarFechayCMB(object sender, EventArgs e)
        {
            DAOAgendarCita ObjAgregarCMB = new DAOAgendarCita();
            //Cargamos el Combobox de Lugar
            ObjAgendarCitaForm.cmbLugar.DataSource = ObjAgregarCMB.AgregarCMBLugar();
            ObjAgendarCitaForm.cmbLugar.ValueMember = "lugarId";
            ObjAgendarCitaForm.cmbLugar.DisplayMember = "lugar";
            //Cargamos el Combobox de Estado
            ObjAgendarCitaForm.cmbEstado.DataSource = ObjAgregarCMB.AgregarCMBEstado();
            ObjAgendarCitaForm.cmbEstado.ValueMember = "estadoId";
            ObjAgendarCitaForm.cmbEstado.DisplayMember = "estado";

            //Indicamos que el textbox en primeras instancias, estará desabilitado
            ObjAgendarCitaForm.txtDUIProfesional.Text = InicioSesion.Dui;
            ObjAgendarCitaForm.txtDUIProfesional.Enabled = false;

            if (string.IsNullOrEmpty(ObjAgendarCitaForm.txtMotivoConsulta.Text))
            {
                ObjAgendarCitaForm.dtFecha.Value = DateTime.Parse(CTRLCalendario.static_year + "-" + CTRLCalendario.static_month + "-" + CTRLUCDias.static_day);
            }
        }
        #endregion
        #region Inserción en el Formulario de Agendar Nueva Cita (CREATE)
        private void AgregarNuevaCita(object sender, EventArgs e)
        {
            try
            {
                TimeSpan horaInicioMinima = new TimeSpan(6, 30, 0);
                TimeSpan horaFinalMaxima = new TimeSpan(18, 0, 0);

                if (ObjAgendarCitaForm.txtDUIProfesional.Text.Length < 10   ||
                    ObjAgendarCitaForm.txtDUIPaciente.Text.Length < 10      ||
                    ObjAgendarCitaForm.dtHoraInicio.Value.TimeOfDay < horaInicioMinima || 
                    ObjAgendarCitaForm.dtHoraFinal.Value.TimeOfDay > horaFinalMaxima ||
                    ObjAgendarCitaForm.dtHoraInicio.Value.TimeOfDay >= ObjAgendarCitaForm.dtHoraFinal.Value.TimeOfDay ||
                    ObjAgendarCitaForm.txtMotivoConsulta.Text.Length < 5)
                {
                    ObjAgendarCitaForm.NotificacionCita.Show(ObjAgendarCitaForm, "Existen campos vacíos o los campos son demasiado cortos en el listado, verifique si existe algún campo faltante", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    //Instanciamos a la clase DAOAgendarCita para acceder a los métodos del Getter y Setter
                    DAOAgendarCita ObjDAOAgendarCita = new DAOAgendarCita();

                    //Declaramos cada Getter y Setter de la clase DAOAgendarCita a cada control del formulario
                    ObjDAOAgendarCita.DocumentoPresentado = ObjAgendarCitaForm.txtDUIPaciente.Text.Trim();
                    //Indicamos que el DUI del presente, será sustituido por el DUI del profesional
                    //De este modo, no podremos agendar citas a otros profesionales, sino al correspondiente
                    ObjDAOAgendarCita.DuiProfesional = ObjAgendarCitaForm.txtDUIProfesional.Text;
                    ObjDAOAgendarCita.HoraInicio = TimeSpan.Parse(ObjAgendarCitaForm.dtHoraInicio.Text.Trim());
                    ObjDAOAgendarCita.HoraFinal = TimeSpan.Parse(ObjAgendarCitaForm.dtHoraFinal.Text.Trim());
                    ObjDAOAgendarCita.Fecha = DateTime.Parse(ObjAgendarCitaForm.dtFecha.Text.Trim());
                    ObjDAOAgendarCita.LugarId = int.Parse(ObjAgendarCitaForm.cmbLugar.SelectedValue.ToString());
                    ObjDAOAgendarCita.EstadoId = int.Parse(ObjAgendarCitaForm.cmbEstado.SelectedValue.ToString());
                    ObjDAOAgendarCita.Descripcion = ObjAgendarCitaForm.txtMotivoConsulta.Text.Trim();

                    if (ObjDAOAgendarCita.RegistrarCitaConsulta() == false)
                    {
                        ObjAgendarCitaForm.NotificacionCita.Show(ObjAgendarCitaForm, "Uno de los apartados no ha sido ingresado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                    }
                    else
                    {
                        ObjAgendarCitaForm.NotificacionCita.Show(ObjAgendarCitaForm, "Los datos han sido ingresados correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        ObjAgendarCitaForm.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Modificación en el Formulario de Agendar Cita (UPDATE)
        private void ModificarCita(object sender, EventArgs e)
        {
            try
            {
                TimeSpan horaInicioMinima = new TimeSpan(6, 30, 0);
                TimeSpan horaFinalMaxima = new TimeSpan(18, 0, 0);

                if (ObjAgendarCitaForm.txtDUIProfesional.Text.Length < 10 ||
                    ObjAgendarCitaForm.txtDUIPaciente.Text.Length < 10 ||
                    ObjAgendarCitaForm.dtHoraInicio.Value.TimeOfDay < horaInicioMinima ||
                    ObjAgendarCitaForm.dtHoraFinal.Value.TimeOfDay > horaFinalMaxima ||
                    ObjAgendarCitaForm.dtHoraInicio.Value.TimeOfDay >= ObjAgendarCitaForm.dtHoraFinal.Value.TimeOfDay ||
                    ObjAgendarCitaForm.txtMotivoConsulta.Text.Length < 5)
                {
                    ObjAgendarCitaForm.NotificacionCita.Show(ObjAgendarCitaForm, "Existen campos vacíos o los campos son demasiado cortos en el listado, verifique si existe algún campo faltante", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    //Instanciamos a la clase DAOAgendarCita para acceder a los métodos del Getter y Setter
                    DAOAgendarCita ObjDAOActualizarCita = new DAOAgendarCita();

                    //Declaramos cada Getter y Setter de la clase DAOAgendarCita a cada control del formulario
                    ObjDAOActualizarCita.CitaId = int.Parse(ObjAgendarCitaForm.txtIDCita.Text.Trim());
                    ObjDAOActualizarCita.ConsultaId = int.Parse(ObjAgendarCitaForm.txtIDConsulta.Text.Trim());
                    ObjDAOActualizarCita.DocumentoPresentado = ObjAgendarCitaForm.txtDUIPaciente.Text.Trim();
                    ObjDAOActualizarCita.DuiProfesional = InicioSesion.Dui;
                    ObjDAOActualizarCita.HoraInicio = TimeSpan.Parse(ObjAgendarCitaForm.dtHoraInicio.Text.Trim());
                    ObjDAOActualizarCita.HoraFinal = TimeSpan.Parse(ObjAgendarCitaForm.dtHoraFinal.Text.Trim());
                    ObjDAOActualizarCita.Fecha = DateTime.Parse(ObjAgendarCitaForm.dtFecha.Text.Trim());
                    ObjDAOActualizarCita.LugarId = int.Parse(ObjAgendarCitaForm.cmbLugar.SelectedValue.ToString());
                    ObjDAOActualizarCita.EstadoId = int.Parse(ObjAgendarCitaForm.cmbEstado.SelectedValue.ToString());
                    ObjDAOActualizarCita.Descripcion = ObjAgendarCitaForm.txtMotivoConsulta.Text.Trim();

                    if (ObjDAOActualizarCita.ActualizarCitaYConsulta() == false)
                    {
                        ObjAgendarCitaForm.NotificacionCita.Show(ObjAgendarCitaForm, "Uno de los apartados no ha sido ingresado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                    }
                    else
                    {
                        ObjAgendarCitaForm.NotificacionCita.Show(ObjAgendarCitaForm, "Los datos fueron actualizados correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                        ObjAgendarCitaForm.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}