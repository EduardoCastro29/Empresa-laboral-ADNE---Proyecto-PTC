using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador.ControladorUserControlPaciente
{
    internal class CTRLPacienteUC
    {
        readonly ControlVerPacientesUC ObjVerPacienteUS;
        readonly InformaciónPersonalForm ObjInformacionPersonal;

        // Primer Controlador de la vista del user control
        public CTRLPacienteUC(ControlVerPacientesUC vista) // Controlador de la vista del User control
        {
            ObjVerPacienteUS = vista;
            // Metodo para cargar la Informacion del Paciente
            ObjVerPacienteUS.btnVerInformacion.Click += new EventHandler(CargarInformacionPersonal);
            ObjVerPacienteUS.btnVerExpediente.Click += new EventHandler(CargarExpediente);
        }

        //Método para cargar los datos de expediente
        private void CargarExpediente(object sender, EventArgs e)
        {
            try
            {
                DAOExpediente objDAOExpedienteMedico = new DAOExpediente();
                objDAOExpedienteMedico.DocumentoPresentado = ObjVerPacienteUS.lblPacienteId.Text;

                //Se asigna el ID del expediente que se desea cargar
                bool Comprobar = objDAOExpedienteMedico.ObtenerExpedientePaciente();
                if (Comprobar)
                {
                    ExpedienteMédicoForm objExpedienteMedico = new ExpedienteMédicoForm();
                   
                    objExpedienteMedico.txtEstadoAnimo.Text = objDAOExpedienteMedico.EstadoAnimo;
                    objExpedienteMedico.txtEstadoConductual.Text = objDAOExpedienteMedico.EstadoConductual;
                    objExpedienteMedico.txtSomatizacion.Text = objDAOExpedienteMedico.Somatizacion;
                    objExpedienteMedico.txtVidaInterpersonal.Text = objDAOExpedienteMedico.VidaInterpersonal;
                    objExpedienteMedico.txtCognicion.Text = objDAOExpedienteMedico.Cognicion;
                    objExpedienteMedico.txtRedSocial.Text = objDAOExpedienteMedico.RedSocial;
                    objExpedienteMedico.txtPauta.Text = objDAOExpedienteMedico.Pauta;
                    objExpedienteMedico.txtRiesgoValorado.Text = objDAOExpedienteMedico.RiesgoValorado;
                    objExpedienteMedico.txtObservacion.Text = objDAOExpedienteMedico.Observacion;
                    objExpedienteMedico.txtAproximacionDiag.Text = objDAOExpedienteMedico.AproximacionDiag;
                    objExpedienteMedico.txtAtencionBrindada.Text = objDAOExpedienteMedico.AtencionBrindada;
                    objExpedienteMedico.txtPacienteId.Text = objDAOExpedienteMedico.DocumentoPresentado;

                    objExpedienteMedico.btnGuardar.Enabled = false;
                    objExpedienteMedico.btnModificar.Enabled = true;

                    objExpedienteMedico.Show();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el expediente seleccionado.",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Metodo para cargar la Informacion del Paciente
        private void CargarInformacionPersonal(object sender, EventArgs e)
        {
            try
            {
                DAOInformacionPersonal ObjDaoInformacionPersonal = new DAOInformacionPersonal();
                ObjDaoInformacionPersonal.DocumentoPresentado = ObjVerPacienteUS.lblPacienteId.Text; // Asigna el ID del paciente que deseas cargar

                bool Comprobar = ObjDaoInformacionPersonal.ObtenerInformacionPaciente();
                if (Comprobar)
                {
                    InformaciónPersonalForm ObjVerInformacion = new InformaciónPersonalForm();

                    // Pasar datos al formulario
                    ObjVerInformacion.dtFechaNacimiento.Value = ObjDaoInformacionPersonal.FechaNacimiento;
                    ObjVerInformacion.txtNombrePaciente.Text = ObjDaoInformacionPersonal.Nombre;
                    ObjVerInformacion.txtApellidoPaciente.Text = ObjDaoInformacionPersonal.Apellido;
                    ObjVerInformacion.txtDomicilio.Text = ObjDaoInformacionPersonal.Domicilio;
                    ObjVerInformacion.txtNacionalidad.Text = ObjDaoInformacionPersonal.Nacionalidad;
                    ObjVerInformacion.txtDocumentoPresentado.Text = ObjDaoInformacionPersonal.DocumentoPresentado;
                    ObjVerInformacion.txtCorreoElectronico.Text = ObjDaoInformacionPersonal.CorreoElectronico;
                    ObjVerInformacion.txtTelefono1.Text = ObjDaoInformacionPersonal.Telefono;
                    ObjVerInformacion.txtProfesion.Text = ObjDaoInformacionPersonal.Profesion;
                    ObjVerInformacion.txtEdad.Text = ObjDaoInformacionPersonal.Edad.ToString();
                    ObjVerInformacion.txtComposicionFamiliar.Text = ObjDaoInformacionPersonal.ComposicionFamiliar;
                    ObjVerInformacion.txtMotivoIntervencion.Text = ObjDaoInformacionPersonal.Motivo;
                    ObjVerInformacion.txtAntecedentes.Text = ObjDaoInformacionPersonal.Antecedente;
                    ObjVerInformacion.txtDescripcion.Text = ObjDaoInformacionPersonal.Descripcion;
                    ObjVerInformacion.txtAspectosPreocupantes.Text = ObjDaoInformacionPersonal.AspectosPreocupantes;
                    ObjVerInformacion.cmbGeneroId.SelectedValue = ObjDaoInformacionPersonal.GeneroId1;

                    ObjVerInformacion.Show();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el paciente seleccionado.",
                                   "Proceso interrumpido",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  Segundo Controlador de la vista de Informacion Personal Forms 
        public CTRLPacienteUC(InformaciónPersonalForm vista) // Controlador de la vista del Informacion Personal
        {
            ObjInformacionPersonal = vista;
            // Metodo para desactivar boton de agregar paciente automaticamente  con el evento Load
            ObjInformacionPersonal.Load += new EventHandler(DesactivarAgregarPaciente);
            // Metodo para actualizar la Informacion del Paciente presionando el boton de Modificar 
            ObjInformacionPersonal.btnModificarPaciente.Click += new EventHandler(ActualizarInformacionPaciente);
            ObjInformacionPersonal.Load += new EventHandler(CargarCMB);
        }

        private void CargarCMB(object sender, EventArgs e)
        {
            DAOInformacionPersonal ObjDaoCargarCMB = new DAOInformacionPersonal();
            ObjInformacionPersonal.cmbGeneroId.DataSource = ObjDaoCargarCMB.AgregarCMBGenero();
            ObjInformacionPersonal.cmbGeneroId.ValueMember = "generoId";
            ObjInformacionPersonal.cmbGeneroId.DisplayMember = "genero";
        }

        // Instrucciones que se haran en el metodo DesactivarAgregarPaciente para desactivar el boton de agregar Paciente 
        private void DesactivarAgregarPaciente(object sender, EventArgs e)  // Todo el proceso para desactivar el boton de Guardar Paciente
        {
            ObjInformacionPersonal.btnModificarPaciente.Enabled = true;
            ObjInformacionPersonal.btnGuardarPaciente.Enabled = false;
        }

        // Metodo para Actualizar la Informacion del Paciente
        private void ActualizarInformacionPaciente(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtNacionalidad.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtDocumentoPresentado.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtEdad.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtTelefono1.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtProfesion.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtNombrePaciente.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtApellidoPaciente.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtDomicilio.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtCorreoElectronico.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtComposicionFamiliar.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtMotivoIntervencion.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtAntecedentes.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtDescripcion.Text.Trim()) ||
                   string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtAspectosPreocupantes.Text.Trim()))
                {
                    //Si los datos no fueron ingresados correctamente, mostramos un mensaje de error
                    MessageBox.Show("Error al modificar datos de  paciente, verifique si todos los datos han sido ingresados correctamente", "Actualizar paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //En caso contrario, realizamos el proceso de inserción de los datos

                    //Realizamos el proceso para capturar los datos ingresados por el usuario dado el DaoInformacionPersonal
                    DAOInformacionPersonal ObjDAOActualizarInformacionPersonal = new DAOInformacionPersonal();
                    ObjDAOActualizarInformacionPersonal.FechaNacimiento = ObjInformacionPersonal.dtFechaNacimiento.Value.Date;
                    
                    ObjDAOActualizarInformacionPersonal.Nacionalidad = ObjInformacionPersonal.txtNacionalidad.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.DocumentoPresentado = ObjInformacionPersonal.txtDocumentoPresentado.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Edad = int.Parse(ObjInformacionPersonal.txtEdad.Text.Trim());
                    ObjDAOActualizarInformacionPersonal.Telefono = (ObjInformacionPersonal.txtTelefono1.Text.Trim());
                    ObjDAOActualizarInformacionPersonal.Profesion = ObjInformacionPersonal.txtProfesion.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Nombre = ObjInformacionPersonal.txtNombrePaciente.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Apellido = ObjInformacionPersonal.txtApellidoPaciente.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Domicilio = ObjInformacionPersonal.txtDomicilio.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.CorreoElectronico = ObjInformacionPersonal.txtCorreoElectronico.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.ComposicionFamiliar = ObjInformacionPersonal.txtComposicionFamiliar.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Motivo = ObjInformacionPersonal.txtMotivoIntervencion.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Antecedente = ObjInformacionPersonal.txtAntecedentes.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Descripcion = ObjInformacionPersonal.txtDescripcion.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.AspectosPreocupantes = ObjInformacionPersonal.txtAspectosPreocupantes.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.GeneroId1 = (int)ObjInformacionPersonal.cmbGeneroId.SelectedValue;

                    bool comprobar = ObjDAOActualizarInformacionPersonal.ActualizarInformacionPaciente();
                    if (comprobar == true)
                    {
                        MessageBox.Show("Los datos han sido actualizados exitosamente",
                                   "Proceso completado",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Los datos no pudieron ser actualizados",
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
    }
}