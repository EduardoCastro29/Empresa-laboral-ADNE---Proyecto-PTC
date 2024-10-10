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
    internal class CTRLCambiarContraseña
    {

        readonly Actualizar_contraseña ObjActualizarContraseña;
        public CTRLCambiarContraseña(Actualizar_contraseña vista)
        {
            ObjActualizarContraseña = vista;
            ObjActualizarContraseña.btnGuardar.Click += new EventHandler(CambiarContraseña);
        }

        public void CambiarContraseña(object sender, EventArgs e )
        {
            try
            {
                DAOActualizarContrasena ObjDAOActualizarContrasena = new DAOActualizarContrasena();
                DAOLogin ObjLogin = new DAOLogin();
                CommonMethods ObjMetodosComunes = new CommonMethods();

                if (ObjActualizarContraseña.txtNuevaContra.Text != ObjActualizarContraseña.txtConfirmarContra.Text)
                {
                    MessageBox.Show("Las credenciales no coinciden", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ObjMetodosComunes.ValidarContrasena(ObjActualizarContraseña.txtConfirmarContra.Text) == false)
                {
                    MessageBox.Show("La contraseña ingresada no cumple con los requisitos de seguridad", "Actualización de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ObjDAOActualizarContrasena.Contrasena = ObjMetodosComunes.MetodoEncriptacionAES(ObjActualizarContraseña.txtConfirmarContra.Text.Trim());

                    ObjDAOActualizarContrasena.NombreUsuario1 = ObjLogin.Usuario;
                    ObjActualizarContraseña.txtUsuarioID.Text = ObjDAOActualizarContrasena.NombreUsuario1;
                    //ObjDAOActualizarContrasena.NombreUsuario1 = ObjActualizarContraseña.txtUsuarioID.Text.Trim();

                    if (ObjDAOActualizarContrasena.ActualizarContraseñaConfiguracion() == false)
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
    }
}
