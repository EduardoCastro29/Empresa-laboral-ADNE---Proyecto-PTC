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

            //Validaciones de campos
            ObjActualizarForm.txtNuevaContrasena.KeyPress += new KeyPressEventHandler(ValidarCampoContrasena);
            ObjActualizarForm.txtConfirmarContrasena.KeyPress += new KeyPressEventHandler(ValidarCampoContrasena);
        }
        #region Validaciones de Campos
        private void ValidarCampoContrasena(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras y números registrados por las variables e.KeyChar creadas anteriormente
            if (char.IsLetter(e.KeyChar) ||
                char.IsDigit(e.KeyChar) ||
                e.KeyChar == '@' ||
                e.KeyChar == '$' ||
                e.KeyChar == '#' ||
                e.KeyChar == '_')
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        #endregion
        #region Actualización de contraseña como método de recuperación hacia el profesional (UPDATE)
        private void ActualizarContrasena(object sender, EventArgs e)
        {
            try
            {
                DAOActualizarContrasena ObjDAOActualizarContrasena = new DAOActualizarContrasena();
                CommonMethods ObjMetodosComunes = new CommonMethods();

                if (ObjActualizarForm.txtNuevaContrasena.Text != ObjActualizarForm.txtConfirmarContrasena.Text)
                {
                    MessageBox.Show("Las credenciales no coinciden", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ObjMetodosComunes.ValidarContrasena(ObjActualizarForm.txtConfirmarContrasena.Text) == false)
                {
                    MessageBox.Show("La contraseña ingresada no cumple con los requisitos de seguridad", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjDAOActualizarContrasena.Contrasena = ObjMetodosComunes.MetodoEncriptacionAES(ObjActualizarForm.txtConfirmarContrasena.Text.Trim());
                    ObjDAOActualizarContrasena.UsuarioSolicitantePS = ObjActualizarForm.txtUsuarioID.Text.Trim();

                    if (ObjDAOActualizarContrasena.ActualizarContrasenaCorreo() == false)
                    {
                        MessageBox.Show("Las contraseña no pudo ser actualizada, contacte con el soporte técnico o comuniquese con su administrador", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La aplicación se reiniciará confirmando la actualización de contraseña", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Reinciamos la aplicación limpiando todas las variables de Inicio de Sesión y variables estáticas
                        Application.Restart();
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