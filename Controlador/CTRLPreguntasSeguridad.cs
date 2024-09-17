using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLPreguntasSeguridad
    {
        readonly PreguntasdeSeguridadForm ObjPreguntasSForm;
        public CTRLPreguntasSeguridad(PreguntasdeSeguridadForm Vista)
        {
            ObjPreguntasSForm = Vista;

            ObjPreguntasSForm.Load += new EventHandler(CargarCombosPreguntasYBTN); 
            ObjPreguntasSForm.txtPrimeraPregunta.Leave += new EventHandler(PreguntaDos); 
            ObjPreguntasSForm.txtSegundaPregunta.Leave += new EventHandler(PreguntaTres);
            ObjPreguntasSForm.txtTerceraPregunta.Leave += new EventHandler(PreguntaCuatro);
            ObjPreguntasSForm.btnRegistrar.Click += new EventHandler(RegistrarPreguntasS);
            ObjPreguntasSForm.btnVerificarPregunta.Click += new EventHandler(VerificarPreguntasS);
        }
        #region Eventos Iniciales al cargar el Formulario
        private void CargarCombosPreguntasYBTN(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ObjPreguntasSForm.txtDUIProfesional.Text.Trim()))
            {
                ObjPreguntasSForm.btnRegistrar.Enabled = false;
            }

            DAOPreguntasSeguridad ObjDAOCargarCMB = new DAOPreguntasSeguridad();
            // Cargar el primer ComboBox
            ObjPreguntasSForm.cmbPrimeraPregunta.DataSource = ObjDAOCargarCMB.CargarPregunta1();
            ObjPreguntasSForm.cmbPrimeraPregunta.ValueMember = "preguntasId";
            ObjPreguntasSForm.cmbPrimeraPregunta.DisplayMember = "nombrePreguntas";
        }
        private void PreguntaDos(object sender, EventArgs e)
        {
            DAOPreguntasSeguridad ObjDAOCargarCMB = new DAOPreguntasSeguridad();

            if (ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue != null)
            {
                if (int.TryParse(ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue.ToString(), out _))
                {
                    ObjDAOCargarCMB.PreguntaNotIn1 = int.Parse(ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue.ToString());
                    ObjPreguntasSForm.cmbSegundaPregunta.DataSource = ObjDAOCargarCMB.CargarPregunta2();
                    ObjPreguntasSForm.cmbSegundaPregunta.ValueMember = "preguntasId";
                    ObjPreguntasSForm.cmbSegundaPregunta.DisplayMember = "nombrePreguntas";
                }
            }

            //Estos son los eventos que, al cambiar de valor cualquier combobox, cambiaran su valor consecuentemente
            ObjPreguntasSForm.cmbPrimeraPregunta.SelectedIndexChanged += (cmbSender, cmbEvent) =>
            {
                if (ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue != null)
                {
                    if (int.TryParse(ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue.ToString(), out _))
                    {
                        ObjDAOCargarCMB.PreguntaNotIn1 = int.Parse(ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue.ToString());
                        ObjPreguntasSForm.cmbSegundaPregunta.DataSource = ObjDAOCargarCMB.CargarPregunta2();
                        ObjPreguntasSForm.cmbSegundaPregunta.ValueMember = "preguntasId";
                        ObjPreguntasSForm.cmbSegundaPregunta.DisplayMember = "nombrePreguntas";
                    }
                }
            };
        }
        private void PreguntaTres(object sender, EventArgs e)
        {
            DAOPreguntasSeguridad ObjDAOCargarCMB = new DAOPreguntasSeguridad();

            if (ObjPreguntasSForm.cmbSegundaPregunta.SelectedValue != null)
            {
                if (int.TryParse(ObjPreguntasSForm.cmbSegundaPregunta.SelectedValue.ToString(), out _))
                {
                    ObjDAOCargarCMB.PreguntaNotIn1 = int.Parse(ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue.ToString());
                    ObjDAOCargarCMB.PreguntaNotIn2 = int.Parse(ObjPreguntasSForm.cmbSegundaPregunta.SelectedValue.ToString());
                    ObjPreguntasSForm.cmbTerceraPregunta.DataSource = ObjDAOCargarCMB.CargarPregunta3();
                    ObjPreguntasSForm.cmbTerceraPregunta.ValueMember = "preguntasId";
                    ObjPreguntasSForm.cmbTerceraPregunta.DisplayMember = "nombrePreguntas";
                }
            }

            ObjPreguntasSForm.cmbSegundaPregunta.SelectedIndexChanged += (cmbSender, cmbEvent) =>
            {
                if (ObjPreguntasSForm.cmbSegundaPregunta.SelectedValue != null)
                {
                    if (int.TryParse(ObjPreguntasSForm.cmbSegundaPregunta.SelectedValue.ToString(), out _))
                    {
                        ObjDAOCargarCMB.PreguntaNotIn2 = int.Parse(ObjPreguntasSForm.cmbSegundaPregunta.SelectedValue.ToString());
                        ObjPreguntasSForm.cmbTerceraPregunta.DataSource = ObjDAOCargarCMB.CargarPregunta3();
                        ObjPreguntasSForm.cmbTerceraPregunta.ValueMember = "preguntasId";
                        ObjPreguntasSForm.cmbTerceraPregunta.DisplayMember = "nombrePreguntas";
                    }
                }
            };
        }
        private void PreguntaCuatro(object sender, EventArgs e)
        {
            DAOPreguntasSeguridad ObjDAOCargarCMB = new DAOPreguntasSeguridad();

            if (ObjPreguntasSForm.cmbTerceraPregunta.SelectedValue != null)
            {
                if (int.TryParse(ObjPreguntasSForm.cmbTerceraPregunta.SelectedValue.ToString(), out _))
                {
                    ObjDAOCargarCMB.PreguntaNotIn1 = int.Parse(ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue.ToString());
                    ObjDAOCargarCMB.PreguntaNotIn2 = int.Parse(ObjPreguntasSForm.cmbSegundaPregunta.SelectedValue.ToString());
                    ObjDAOCargarCMB.PreguntaNotIn3 = int.Parse(ObjPreguntasSForm.cmbTerceraPregunta.SelectedValue.ToString());
                    ObjPreguntasSForm.cmbCuartaPregunta.DataSource = ObjDAOCargarCMB.CargarPregunta4();
                    ObjPreguntasSForm.cmbCuartaPregunta.ValueMember = "preguntasId";
                    ObjPreguntasSForm.cmbCuartaPregunta.DisplayMember = "nombrePreguntas";
                }
            }

            ObjPreguntasSForm.cmbTerceraPregunta.SelectedIndexChanged += (cmbSender, cmbEvent) =>
            {
                if (ObjPreguntasSForm.cmbTerceraPregunta.SelectedValue != null)
                {
                    if (int.TryParse(ObjPreguntasSForm.cmbTerceraPregunta.SelectedValue.ToString(), out _))
                    {
                        ObjDAOCargarCMB.PreguntaNotIn3 = int.Parse(ObjPreguntasSForm.cmbTerceraPregunta.SelectedValue.ToString());
                        ObjPreguntasSForm.cmbCuartaPregunta.DataSource = ObjDAOCargarCMB.CargarPregunta4();
                        ObjPreguntasSForm.cmbCuartaPregunta.ValueMember = "preguntasId";
                        ObjPreguntasSForm.cmbCuartaPregunta.DisplayMember = "nombrePreguntas";
                    }
                }
            };
        }
        #endregion
        #region Inserción de preguntas de Seguridad (INSERT)
        private void RegistrarPreguntasS(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(ObjPreguntasSForm.txtPrimeraPregunta.Text) ||
                string.IsNullOrWhiteSpace(ObjPreguntasSForm.txtSegundaPregunta.Text) ||
                string.IsNullOrWhiteSpace(ObjPreguntasSForm.txtTerceraPregunta.Text) ||
                string.IsNullOrWhiteSpace(ObjPreguntasSForm.txtCuartaPregunta.Text))
            {
                ObjPreguntasSForm.NotificacionPreguntas.Show(ObjPreguntasSForm, "Debe de ingresar todas las respuestas de preguntas correspondientes", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                //MessageBox.Show("Debe de ingresar todas las respuestas de preguntas correspondientes", "Preguntas de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Instanciamos a la clase DAOPreguntas
                DAOPreguntasSeguridad ObjRegistrarPreguntasS = new DAOPreguntasSeguridad();
                CommonMethods ObjMetodosComunes = new CommonMethods();

                //Guardamos los valores de los combobox correspondientes
                ObjRegistrarPreguntasS.Pregunta1CMB = int.Parse(ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue.ToString());
                ObjRegistrarPreguntasS.Pregunta2CMB = int.Parse(ObjPreguntasSForm.cmbSegundaPregunta.SelectedValue.ToString());
                ObjRegistrarPreguntasS.Pregunta3CMB = int.Parse(ObjPreguntasSForm.cmbTerceraPregunta.SelectedValue.ToString());
                ObjRegistrarPreguntasS.Pregunta4CMB = int.Parse(ObjPreguntasSForm.cmbCuartaPregunta.SelectedValue.ToString());

                //Guardamos los valores de los textbox correspondientes
                ObjRegistrarPreguntasS.RespuestaPregunta1 = ObjMetodosComunes.MetodoEncriptacionAES(ObjPreguntasSForm.txtPrimeraPregunta.Text.ToUpper());
                ObjRegistrarPreguntasS.RespuestaPregunta2 = ObjMetodosComunes.MetodoEncriptacionAES(ObjPreguntasSForm.txtSegundaPregunta.Text.ToUpper());
                ObjRegistrarPreguntasS.RespuestaPregunta3 = ObjMetodosComunes.MetodoEncriptacionAES(ObjPreguntasSForm.txtTerceraPregunta.Text.ToUpper());
                ObjRegistrarPreguntasS.RespuestaPregunta4 = ObjMetodosComunes.MetodoEncriptacionAES(ObjPreguntasSForm.txtCuartaPregunta.Text.ToUpper());
                ObjRegistrarPreguntasS.DUIProfesional = ObjPreguntasSForm.txtDUIProfesional.Text;

                if (ObjRegistrarPreguntasS.RegistrarPreguntasSeguridad() == false)
                {
                    ObjPreguntasSForm.NotificacionPreguntas.Show(ObjPreguntasSForm, "Las preguntas no se han podido ingresar, verifique si existe algún dato faltante", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    //MessageBox.Show("Las preguntas no se han podido ingresar, verifique si existe algún dato faltante", "Preguntas de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjPreguntasSForm.NotificacionPreguntas.Show(ObjPreguntasSForm, "Las preguntas han sido ingresadas con éxito", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    //MessageBox.Show("Las preguntas han sido ingresadas con éxito", "Preguntas de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjPreguntasSForm.Hide();
                }
            }
        }
        #endregion
        #region Verificar Preguntas de Seguridad (READ)
        private void VerificarPreguntasS(object sender, EventArgs e)
        {
            //Verificamos si las preguntas del usuario han sido correctamente ingresadas
            DAOPreguntasSeguridad ObjVerificarPreguntas = new DAOPreguntasSeguridad();
            CommonMethods ObjMetodosComunes = new CommonMethods();

            //Añadimos los valores
            ObjVerificarPreguntas.Pregunta1CMB = int.Parse(ObjPreguntasSForm.cmbPrimeraPregunta.SelectedValue.ToString());
            ObjVerificarPreguntas.Pregunta2CMB = int.Parse(ObjPreguntasSForm.cmbSegundaPregunta.SelectedValue.ToString());
            ObjVerificarPreguntas.Pregunta3CMB = int.Parse(ObjPreguntasSForm.cmbTerceraPregunta.SelectedValue.ToString());
            ObjVerificarPreguntas.Pregunta4CMB = int.Parse(ObjPreguntasSForm.cmbCuartaPregunta.SelectedValue.ToString());

            //Guardamos los valores de los textbox correspondientes
            ObjVerificarPreguntas.RespuestaPregunta1 = ObjMetodosComunes.MetodoEncriptacionAES(ObjPreguntasSForm.txtPrimeraPregunta.Text.ToUpper());
            ObjVerificarPreguntas.RespuestaPregunta2 = ObjMetodosComunes.MetodoEncriptacionAES(ObjPreguntasSForm.txtSegundaPregunta.Text.ToUpper());
            ObjVerificarPreguntas.RespuestaPregunta3 = ObjMetodosComunes.MetodoEncriptacionAES(ObjPreguntasSForm.txtTerceraPregunta.Text.ToUpper());
            ObjVerificarPreguntas.RespuestaPregunta4 = ObjMetodosComunes.MetodoEncriptacionAES(ObjPreguntasSForm.txtCuartaPregunta.Text.ToUpper());
            ObjVerificarPreguntas.DUIProfesional = ObjPreguntasSForm.txtDocumento.Text;
            ObjVerificarPreguntas.UsuarioSolicitante = ObjPreguntasSForm.txtUsuario.Text;

            if (ObjVerificarPreguntas.VerificarPreguntasSeguridad() == false)
            {
                ObjPreguntasSForm.NotificacionPreguntas.Show(ObjPreguntasSForm, "Verifique si las preguntas seleccionadas con las respuestas han sido proporcionadas por el profesional correspondiente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                //MessageBox.Show("Verifique si las preguntas seleccionadas con las respuestas han sido proporcionadas por el profesional correspondiente", "Preguntas de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ObjPreguntasSForm.NotificacionPreguntas.Show(ObjPreguntasSForm, "Las respuestas han sido verificadas exitosamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                //MessageBox.Show("Las respuestas han sido verificadas exitosamente", "Preguntas de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarContraseñaForm ObjAbrirFormularioAC = new ActualizarContraseñaForm();
                ObjAbrirFormularioAC.txtUsuarioID.Text = ObjPreguntasSForm.txtUsuario.Text;
                ObjPreguntasSForm.Hide();
                ObjAbrirFormularioAC.Show();
            }
        }
        #endregion
    }
}