using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Drawing.Printing;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLLogin
    {
        // Creando un objeto del formulario login
        readonly LoginForm ObjLogin;

        // Constructor de la clase CTRLLogin
        // Esta tendrá como parámetro el formulario Login haciendo referencia a la carpeta Vista
        public CTRLLogin(LoginForm Vista)
        {
            // Enlazando el objeto con la Vista dentro del constructor
            ObjLogin = Vista;

            // Creando el evento EventHandler con el botón Ingresar, y los eventos KeyDown y Click
            ObjLogin.Load += new EventHandler(CargarLogIn);
            ObjLogin.btnIniciarSesion.Click += new EventHandler(AccederLogin);
            ObjLogin.btnOlvidarContrasena.Click += new EventHandler(OlvidarContrasena);
        }
        private void CargarLogIn(object sender, EventArgs e)
        {
            ObjLogin.txtUsuario.Text = Properties.Settings.Default.Usuario;
            ObjLogin.txtContraseña.Text = Properties.Settings.Default.Contrasena;
        }
        // Creando un método llamado AccederLogin que tomará como proceso los valores dentro de la clase DAO y del DTO
        private void AccederLogin(object sender, EventArgs e)
        {
            // Realizamos el proceso para capturar los datos del usuario y contraseña en la vista login
            DAOLogin ObjDAOUsuario = new DAOLogin();
            CommonMethods ObjMetodosComunes = new CommonMethods();
            ObjDAOUsuario.Usuario = ObjLogin.txtUsuario.Text.Trim();
            ObjDAOUsuario.Contrasena = ObjMetodosComunes.MetodoEncriptacionAES(ObjLogin.txtContraseña.Text.Trim());

            string contrasenaPredeterminada = ObjLogin.txtUsuario.Text + "ADNE2024";

            bool ValidarLoginUsuario = ObjDAOUsuario.Login();
            bool ValidarLoginEmpleado = ObjDAOUsuario.LoginEmpleado();

            try
            {
                if (ObjMetodosComunes.MetodoEncriptacionAES(contrasenaPredeterminada) == ObjDAOUsuario.Contrasena)
                {
                    MessageBox.Show($"Bienvenido {InicioSesion.Usuario}, por motivos de seguridad, se le redireccionará automáticamente a un nuevo formulario para que pueda actualizar su contraseña", "Ventana Emergente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DirecciónGmailForm ObjRedireccionarUsuarioSolicitante = new DirecciónGmailForm();
                    ObjLogin.Hide();
                    ObjRedireccionarUsuarioSolicitante.Show();
                }
                else
                {
                    if (ValidarLoginUsuario == true && ValidarLoginEmpleado == true)
                    {
                        MessageBox.Show($"Bienvenido, {InicioSesion.Usuario}", "Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DashboardForm ObjMostrarDashboard = new DashboardForm();
                        ObjLogin.Hide();
                        ObjMostrarDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraseña son incorrectos", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (ObjLogin.cbRecuerdame.Checked == true)
                    {
                        string usuario = ObjDAOUsuario.Usuario;
                        Properties.Settings.Default.Usuario = ObjLogin.txtUsuario.Text;
                        Properties.Settings.Default.Contrasena = ObjLogin.txtContraseña.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        string usuario = ObjDAOUsuario.Usuario;
                        Properties.Settings.Default.Usuario = "";
                        Properties.Settings.Default.Contrasena = "";
                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OlvidarContrasena(object sender, EventArgs e)
        {
            RecuperarContraseñaOPCForm ObjRecuperarContrasenaOPC = new RecuperarContraseñaOPCForm();
            ObjLogin.Hide();
            ObjRecuperarContrasenaOPC.Show();
        }

       
    }
}
