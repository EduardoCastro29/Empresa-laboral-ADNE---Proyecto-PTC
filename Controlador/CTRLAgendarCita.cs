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
        }
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

            ObjAgendarCitaForm.txtfecha.Text = CTRLCalendario.static_year + "-" + CTRLCalendario.static_month + "-" + CTRLUCDias.static_day; 
        }
        private void AgregarNuevaCita(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtProfesionalID.Text) ||
                    string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtPacienteID.Text) ||
                    string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtHoraInicio.Text) ||
                    string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtHoraFinal.Text) ||
                    string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtMotivoConsulta.Text))
                {
                    MessageBox.Show("Existen campos vacíos, verifique si existe algún campo faltante", "Agendar Cita", MessageBoxButtons.OK, MessageBoxIcon.Error);                }
                else
                {
                    //Instanciamos a la clase DAOAgendarCita para acceder a los métodos del Getter y Setter
                    DAOAgendarCita ObjDAOAgendarCita = new DAOAgendarCita();

                    //Declaramos cada Getter y Setter de la clase DAOAgendarCita a cada control del formulario
                    ObjDAOAgendarCita.PacienteId = int.Parse(ObjAgendarCitaForm.txtPacienteID.Text.Trim());
                    ObjDAOAgendarCita.ProfesionalId = int.Parse(ObjAgendarCitaForm.txtProfesionalID.Text.Trim());
                    ObjDAOAgendarCita.HoraInicio = TimeSpan.Parse(ObjAgendarCitaForm.txtHoraInicio.Text.Trim());
                    ObjDAOAgendarCita.HoraFinal = TimeSpan.Parse(ObjAgendarCitaForm.txtHoraFinal.Text.Trim());
                    ObjDAOAgendarCita.Fecha = DateTime.Parse(ObjAgendarCitaForm.txtfecha.Text.Trim());
                    ObjDAOAgendarCita.LugarId = int.Parse(ObjAgendarCitaForm.cmbLugar.SelectedValue.ToString());
                    ObjDAOAgendarCita.EstadoId = int.Parse(ObjAgendarCitaForm.cmbEstado.SelectedValue.ToString());
                    ObjDAOAgendarCita.Descripcion = ObjAgendarCitaForm.txtMotivoConsulta.Text.Trim();

                    if (ObjDAOAgendarCita.RegistrarCitaConsulta() == false)
                    {
                        MessageBox.Show("Uno de los apartados no ha sido ingresado correctamente", "Agendar Cita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Los datos han sido ingresados correctamente", "Agendar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObjAgendarCitaForm.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ModificarCita(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtProfesionalID.Text) ||
                    string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtPacienteID.Text) ||
                    string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtHoraInicio.Text) ||
                    string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtHoraFinal.Text) ||
                    string.IsNullOrWhiteSpace(ObjAgendarCitaForm.txtMotivoConsulta.Text))
                {
                    MessageBox.Show("Existen campos vacíos, verifique si existe algún campo faltante", "Agendar Cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Instanciamos a la clase DAOAgendarCita para acceder a los métodos del Getter y Setter
                    DAOAgendarCita ObjDAOActualizarCita = new DAOAgendarCita();

                    //Declaramos cada Getter y Setter de la clase DAOAgendarCita a cada control del formulario
                    ObjDAOActualizarCita.CitaId = int.Parse(ObjAgendarCitaForm.txtIDCita.Text.Trim());
                    ObjDAOActualizarCita.ConsultaId = int.Parse(ObjAgendarCitaForm.txtIDConsulta.Text.Trim());
                    ObjDAOActualizarCita.PacienteId = int.Parse(ObjAgendarCitaForm.txtPacienteID.Text.Trim());
                    ObjDAOActualizarCita.ProfesionalId = int.Parse(ObjAgendarCitaForm.txtProfesionalID.Text.Trim());
                    ObjDAOActualizarCita.HoraInicio = TimeSpan.Parse(ObjAgendarCitaForm.txtHoraInicio.Text.Trim());
                    ObjDAOActualizarCita.HoraFinal = TimeSpan.Parse(ObjAgendarCitaForm.txtHoraFinal.Text.Trim());
                    ObjDAOActualizarCita.Fecha = DateTime.Parse(ObjAgendarCitaForm.txtfecha.Text.Trim());
                    ObjDAOActualizarCita.LugarId = int.Parse(ObjAgendarCitaForm.cmbLugar.SelectedValue.ToString());
                    ObjDAOActualizarCita.EstadoId = int.Parse(ObjAgendarCitaForm.cmbEstado.SelectedValue.ToString());
                    ObjDAOActualizarCita.Descripcion = ObjAgendarCitaForm.txtMotivoConsulta.Text.Trim();

                    if (ObjDAOActualizarCita.ActualizarCitaYConsulta() == false)
                    {
                        MessageBox.Show("Uno de los apartados no ha sido ingresado correctamente", "Agendar Cita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Los datos fueron actualizados correctamente", "Actualizar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObjAgendarCitaForm.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}