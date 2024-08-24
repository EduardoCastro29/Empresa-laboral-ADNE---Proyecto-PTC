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
    internal class CTRLExpedienteMedico
    {
        readonly ExpedienteMédicoForm ObjExpediente;
        //Empezamos la encapsulación de la clase Controlador Expediente
        //Esta tendrá como parámetros el formulario Expediente Médico haciendo referencia a la carpeta Vista

        //Primer controlador de la Vista de ExpedienteMedicoForms
        public CTRLExpedienteMedico(ExpedienteMédicoForm Vista)
        {
            //Enlazando el objeto con la Vista dentro del constructor
            ObjExpediente = Vista;

            //Creando el evento EventHandler con el botón Guardar con parametros AccederLogin, que posteriormente ejecutará un método
            ObjExpediente.btnGuardar.Click += new EventHandler(ExpedienteDataInsert);
            ObjExpediente.btnModificar.Click += new EventHandler(ExpedienteDataUpdate);
            ObjExpediente.Load += new EventHandler(CargarExpediente);
        }

        //ABRIR EXPEDIENTE

        private void CargarExpediente(object sender, EventArgs e)
        {
            ObjExpediente.btnModificar.Enabled = false;
        }

        //private bool VerificarTextBox()
        //{
        //    foreach (Control control in ObjExpediente.Controls)
        //    {
        //        if (control is TextBox)
        //        {
        //            TextBox textBox = control as TextBox;
        //            if (string.IsNullOrWhiteSpace(textBox.Text))
        //            {
        //                return false; // Si algún TextBox está vacío, retorna falso
        //            }
        //        }
        //    }
        //    return true; // Todos los TextBox están llenos
        //}

        //INSERT
        private void ExpedienteDataInsert(object sender, EventArgs e)
        {
            try
            {
                //Dado el objeto del DAOExpedienteMédico, evaluamos si los datos fueron ingresados correctamente dados sus métodos
                if (/*string.IsNullOrWhiteSpace(ObjExpediente.txtPacienteId.Text.Trim()) ||*/
                     string.IsNullOrWhiteSpace(ObjExpediente.txtExpedienteId.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtEstadoAnimo.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtEstadoConductual.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtSomatizacion.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtVidaInterpersonal.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtCognicion.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtRedSocial.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtPauta.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtRiesgoValorado.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtObservacion.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtAproximacionDiag.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtAtencionBrindada.Text.Trim()))
                {
                    //Si los datos no fueron ingresados correctamente, mostramos un mensaje de error
                    MessageBox.Show("Error al guardar, verifique si todos los datos han sido ingresados correctamente", "Expediente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //En caso contrario, realizamos el proceso de inserción de los datos a la DB
                    //Realizamos el proceso para capturar los datos ingresados por el usuario dado el DAORegistro
                    DAOExpedienteMedico ObjDAOExpediente = new DAOExpedienteMedico();

                    //Obtenemos datos del objeto ObjDAOExpediente
                    //ObjDAOExpediente.PacienteId = int.Parse(ObjExpediente.txtPacienteId.Text.Trim());
                    ObjDAOExpediente.ExpedienteId = int.Parse(ObjExpediente.txtExpedienteId.Text);
                    ObjDAOExpediente.EstadoAnimo = ObjExpediente.txtEstadoAnimo.Text.Trim();
                    ObjDAOExpediente.EstadoConductual = ObjExpediente.txtEstadoConductual.Text.Trim();
                    ObjDAOExpediente.Somatizacion = ObjExpediente.txtSomatizacion.Text.Trim();
                    ObjDAOExpediente.VidaInterpersonal = ObjExpediente.txtVidaInterpersonal.Text.Trim();
                    ObjDAOExpediente.Cognicion = ObjExpediente.txtCognicion.Text.Trim();
                    ObjDAOExpediente.RedSocial = ObjExpediente.txtRedSocial.Text.Trim();
                    ObjDAOExpediente.Pauta = ObjExpediente.txtPauta.Text.Trim();
                    ObjDAOExpediente.RiesgoValorado = ObjExpediente.txtRiesgoValorado.Text.Trim();
                    ObjDAOExpediente.Observacion = ObjExpediente.txtObservacion.Text.Trim();
                    ObjDAOExpediente.AproximacionDiag = ObjExpediente.txtAproximacionDiag.Text.Trim();
                    ObjDAOExpediente.AtencionBrindada = ObjExpediente.txtAtencionBrindada.Text.Trim();



                    //Se ejecuta el proceso para insertar datos mediante la invocación del método del DAOExpediente
                    bool comprobar = ObjDAOExpediente.ExpedienteInsertarDatos();

                    if (comprobar == true)
                    {
                        MessageBox.Show("Los datos han sido insertado exitosamente",
                                   "Proceso completado",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                        LimpiarCampos();
                        //XDDDDDDD dormite maje :v lol ez

                        //JUANKKKK XDDDD
                        //mira, le modifique q en el update osea el boton de modificar en el expediente medico no este habilitado 
                        //cuando no se haya ingresado / insertado el paciente mjjjj
                        //btw, para que esto funque le quite lo de la foreign key de la tabla info personal vea
                        //ademas q al final le vamos a cambiar eso por el documento presentado (DUI) tons XD
                    }
                    else
                    {
                        MessageBox.Show("Los datos no pudieron ser insertados",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //UPDATE
        private void ExpedienteDataUpdate(object sender, EventArgs e)
        {
            try
            {
                //Dado el objeto del DAOExpedienteMédico, evaluamos si los datos fueron ingresados correctamente dados sus métodos
                if (/*string.IsNullOrWhiteSpace(ObjExpediente.txtPacienteId.Text.Trim()) ||*/
                     string.IsNullOrWhiteSpace(ObjExpediente.txtExpedienteId.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtEstadoAnimo.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtEstadoConductual.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtSomatizacion.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtVidaInterpersonal.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtCognicion.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtRedSocial.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtPauta.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtRiesgoValorado.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtObservacion.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtAproximacionDiag.Text.Trim()) ||
                     string.IsNullOrWhiteSpace(ObjExpediente.txtAtencionBrindada.Text.Trim()))
                {
                    //Si los datos no fueron ingresados correctamente, mostramos un mensaje de error
                    MessageBox.Show("Error al guardar, verifique si todos los datos han sido ingresados correctamente", "Expediente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjExpediente.btnModificar.Enabled = true;
                    //En caso contrario, realizamos el proceso de inserción de los datos a la DB
                    //Realizamos el proceso para capturar los datos ingresados por el usuario dado el DAORegistro
                    DAOExpedienteMedico ObjDAOExpediente = new DAOExpedienteMedico();

                    //Obtenemos datos del objeto ObjDAOExpediente
                    //ObjDAOExpediente.PacienteId = int.Parse(ObjExpediente.txtPacienteId.Text.Trim());
                    ObjDAOExpediente.ExpedienteId = int.Parse(ObjExpediente.txtExpedienteId.Text);
                    ObjDAOExpediente.EstadoAnimo = ObjExpediente.txtEstadoAnimo.Text.Trim();
                    ObjDAOExpediente.EstadoConductual = ObjExpediente.txtEstadoConductual.Text.Trim();
                    ObjDAOExpediente.Somatizacion = ObjExpediente.txtSomatizacion.Text.Trim();
                    ObjDAOExpediente.VidaInterpersonal = ObjExpediente.txtVidaInterpersonal.Text.Trim();
                    ObjDAOExpediente.Cognicion = ObjExpediente.txtCognicion.Text.Trim();
                    ObjDAOExpediente.RedSocial = ObjExpediente.txtRedSocial.Text.Trim();
                    ObjDAOExpediente.Pauta = ObjExpediente.txtPauta.Text.Trim();
                    ObjDAOExpediente.RiesgoValorado = ObjExpediente.txtRiesgoValorado.Text.Trim();
                    ObjDAOExpediente.Observacion = ObjExpediente.txtObservacion.Text.Trim();
                    ObjDAOExpediente.AproximacionDiag = ObjExpediente.txtAproximacionDiag.Text.Trim();
                    ObjDAOExpediente.AtencionBrindada = ObjExpediente.txtAtencionBrindada.Text.Trim();

                    //Se ejecuta el proceso para actualizar datos mediante la invocación del método del DAOExpediente
                    bool comprobar = ObjDAOExpediente.ExpedienteActualizarDatos();
                    if (comprobar == true)
                    {
                        MessageBox.Show("Los datos han sido actualizados exitosamente",
                                   "Proceso completado",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                        ObjExpediente.btnModificar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Los datos no pudieron ser actualizados",
                                   "Proceso interrumpido",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                        ObjExpediente.btnModificar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            ObjExpediente.txtEstadoAnimo.Clear();
            ObjExpediente.txtEstadoConductual.Clear();
            ObjExpediente.txtSomatizacion.Clear();
            ObjExpediente.txtVidaInterpersonal.Clear();
            ObjExpediente.txtCognicion.Clear();
            ObjExpediente.txtRedSocial.Clear();
            ObjExpediente.txtPauta.Clear();
            ObjExpediente.txtRiesgoValorado.Clear();
            ObjExpediente.txtObservacion.Clear();
            ObjExpediente.txtAproximacionDiag.Clear();
            ObjExpediente.txtAtencionBrindada.Clear();
        }
    }
}