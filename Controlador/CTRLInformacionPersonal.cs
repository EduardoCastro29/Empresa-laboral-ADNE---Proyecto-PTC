using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;


namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLInformacionPersonal
    {
        readonly InformaciónPersonalForm ObjInformacionPersonal;
        //Empezamos la encapsulación de la clase Controlador Login
        //Esta tendrá como parámetros el formulario Informacion Personal haciendo referencia a la carpeta Vista

        public CTRLInformacionPersonal(InformaciónPersonalForm vista)
        {
            //Enlazando el objeto con la Vista dentro del constructor
            ObjInformacionPersonal = vista;
            ObjInformacionPersonal.Load += new EventHandler(DesactivarModificarPaciente);
            ObjInformacionPersonal.btnGuardarPaciente.Click += new EventHandler(GuardarInformacionPersonal);
        }
        private void GuardarInformacionPersonal(Object sender, EventArgs e)
        {
            try
            {
                //Dado el objeto del DaoInformacionPersonal, evaluamos si los datos fueron ingresados correctamente dados sus métodos

                if (string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtPacienteId.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtNacionalidad.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtDocumentoPresentado.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtEdad1.Text.Trim()) ||
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
                    MessageBox.Show("Error al registrar paciente, verifique si todos los datos han sido ingresados correctamente", "Registrar paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //En caso contrario, realizamos el proceso de inserción de los datos

                    //Realizamos el proceso para capturar los datos ingresados por el usuario dado el DaoInformacionPersonal
                    DAOInformacionPersonal ObjDAOInformacionPersonal = new DAOInformacionPersonal();
                    ObjDAOInformacionPersonal.FechaNacimiento = ObjInformacionPersonal.dtFechaNacimiento.Value.Date;

                    ObjDAOInformacionPersonal.PacienteId = int.Parse(ObjInformacionPersonal.txtPacienteId.Text.Trim());
                    ObjDAOInformacionPersonal.Nacionalidad = ObjInformacionPersonal.txtNacionalidad.Text.Trim();
                    ObjDAOInformacionPersonal.DocumentoPresentado = ObjInformacionPersonal.txtDocumentoPresentado.Text.Trim();
                    ObjDAOInformacionPersonal.GeneroId1 = int.Parse(ObjInformacionPersonal.cmbGeneroId.SelectedValue.ToString());
                    ObjDAOInformacionPersonal.Edad = int.Parse(ObjInformacionPersonal.txtEdad1.Text.Trim());
                    ObjDAOInformacionPersonal.Telefono = (ObjInformacionPersonal.txtTelefono1.Text.Trim());
                    ObjDAOInformacionPersonal.Profesion = ObjInformacionPersonal.txtProfesion.Text.Trim();
                    ObjDAOInformacionPersonal.Nombre = ObjInformacionPersonal.txtNombrePaciente.Text.Trim();
                    ObjDAOInformacionPersonal.Apellido = ObjInformacionPersonal.txtApellidoPaciente.Text.Trim();
                    ObjDAOInformacionPersonal.Domicilio = ObjInformacionPersonal.txtDomicilio.Text.Trim();
                    ObjDAOInformacionPersonal.CorreoElectronico = ObjInformacionPersonal.txtCorreoElectronico.Text.Trim();
                    ObjDAOInformacionPersonal.ComposicionFamiliar = ObjInformacionPersonal.txtComposicionFamiliar.Text.Trim();
                    ObjDAOInformacionPersonal.Motivo = ObjInformacionPersonal.txtMotivoIntervencion.Text.Trim();
                    ObjDAOInformacionPersonal.Antecedente = ObjInformacionPersonal.txtAntecedentes.Text.Trim();
                    ObjDAOInformacionPersonal.Descripcion = ObjInformacionPersonal.txtDescripcion.Text.Trim();
                    ObjDAOInformacionPersonal.AspectosPreocupantes = ObjInformacionPersonal.txtAspectosPreocupantes.Text.Trim();

                    //Llamamos a los métodos para verificar si la inserción se hizo correctamente

                    bool Comprobar = ObjDAOInformacionPersonal.InsertarInformacionPaciente();
                    if (Comprobar == true)
                    {
                        MessageBox.Show("Los datos han sido registrados exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Los datos no pudieron ser registrados",
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
        private void LimpiarCampos()
        {
            ObjInformacionPersonal.dtFechaNacimiento.Value = DateTime.Now;
            ObjInformacionPersonal.txtPacienteId.Clear();
            ObjInformacionPersonal.txtNacionalidad.Clear();
            ObjInformacionPersonal.txtDocumentoPresentado.Clear();
            ObjInformacionPersonal.cmbGeneroId.SelectedIndex = -1;
            ObjInformacionPersonal.txtEdad1.Clear();
            ObjInformacionPersonal.txtTelefono1.Clear();
            ObjInformacionPersonal.txtProfesion.Clear();
            ObjInformacionPersonal.txtNombrePaciente.Clear();
            ObjInformacionPersonal.txtApellidoPaciente.Clear();
            ObjInformacionPersonal.txtDomicilio.Clear();
            ObjInformacionPersonal.txtCorreoElectronico.Clear();
            ObjInformacionPersonal.txtComposicionFamiliar.Clear();
            ObjInformacionPersonal.txtMotivoIntervencion.Clear();
            ObjInformacionPersonal.txtAntecedentes.Clear();
            ObjInformacionPersonal.txtDescripcion.Clear();
            ObjInformacionPersonal.txtAspectosPreocupantes.Clear();
        }
        private void DesactivarModificarPaciente(object sender, EventArgs e)
        {
            ObjInformacionPersonal.btnGuardarPaciente.Enabled = true;

        }
    }
}