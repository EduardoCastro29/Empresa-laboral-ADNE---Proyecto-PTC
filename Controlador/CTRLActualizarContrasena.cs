using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLActualizarContrasena
    {
        readonly ActualizarContraseñaForm ObjActualizarForm;
        public CTRLActualizarContrasena(ActualizarContraseñaForm Vista)
        {
            ObjActualizarForm = Vista;

            ObjActualizarForm.btnActualizarContrasena.Click += new EventHandler(ActualizarContrasena);
        }
        #region Actualización de contraseña como método de recuperación hacia el profesional (UPDATE)
        private void ActualizarContrasena(object sender, EventArgs e)
        {
            try
            {
                DAOActualizarContrasena ObjDAOActualizarContrasena = new DAOActualizarContrasena();
                CommonMethods ObjMetodosComunes = new CommonMethods();

                if (ObjActualizarForm.txtNuevaContrasena.Text.Length < 13 ||
                    ObjActualizarForm.txtConfirmarContrasena.Text.Length < 13)
                {
                    MessageBox.Show("Debe de registrar una contraseña válida, verifique si la contraseña cumple con la condición de mínimo 13 caracteres", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ObjActualizarForm.txtNuevaContrasena.Text != ObjActualizarForm.txtConfirmarContrasena.Text)
                {
                    MessageBox.Show("Las credenciales no coinciden", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ObjDAOActualizarContrasena.Contrasena = ObjMetodosComunes.MetodoEncriptacionAES(ObjActualizarForm.txtConfirmarContrasena.Text.Trim());

                    if (ObjDAOActualizarContrasena.ActualizarContrasenaCorreo() == false)
                    {
                        MessageBox.Show("Las contraseña no pudo ser actualizada, contacte con el soporte técnico o comuniquese con su administrador", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La aplicación se reiniciará confirmando la actualización de contraseña", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoginForm ObjMostrarLogin = new LoginForm();
                        ObjActualizarForm.Hide();
                        ObjMostrarLogin.Show();
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