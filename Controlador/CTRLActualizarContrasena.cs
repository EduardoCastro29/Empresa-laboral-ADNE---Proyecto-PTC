using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
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
        private void ActualizarContrasena(object sender, EventArgs e)
        {
            try
            {
                DAOActualizarContrasena ObjDAOActualizarContrasena = new DAOActualizarContrasena();
                CommonMethods ObjMetodosComunes = new CommonMethods();

                if (string.IsNullOrWhiteSpace(ObjActualizarForm.txtNuevaContrasena.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjActualizarForm.txtConfirmarContrasena.Text.Trim()))
                {
                    MessageBox.Show("Uno o varios de los campos están vacios, debe de ingresar una contraseña válida", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ObjActualizarForm.txtNuevaContrasena.Text != ObjActualizarForm.txtConfirmarContrasena.Text)
                {
                    MessageBox.Show("Las credenciales no coinciden", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ObjDAOActualizarContrasena.Contrasena = ObjMetodosComunes.MetodoEncriptacionAES(ObjActualizarForm.txtConfirmarContrasena.Text.Trim());
                    ObjDAOActualizarContrasena.UsuarioID = int.Parse(ObjActualizarForm.txtId.Text.Trim());

                    if (ObjDAOActualizarContrasena.ActualizarContrasena() == false)
                    {
                        MessageBox.Show("Las contraseña no pudo ser actualizada, contacte con el soporte técnico o comuniquese con su administrador", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("La aplicación se reiniciará confirmando la actualización de contraseña", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm ObjMostrarLogin = new LoginForm();
                    ObjActualizarForm.Hide();
                    ObjMostrarLogin.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}