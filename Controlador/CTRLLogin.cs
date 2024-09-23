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
            ObjLogin.Load += new EventHandler(CargarLogin);
            ObjLogin.btnIniciarSesion.Click += new EventHandler(AccederLogin);
            ObjLogin.btnOlvidarContrasena.Click += new EventHandler(OlvidarContrasena);
        }
        #region Carga Inicial dentro del Formulario
        private void CargarLogin(object sender, EventArgs e)
        {
            ObjLogin.txtUsuario.Text = Properties.Settings.Default.Usuario;
            ObjLogin.txtContraseña.Text = Properties.Settings.Default.Contrasena;
            ObjLogin.cbRecuerdame.Checked = false;
        }
        #endregion
        #region Acceder al Login
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
                if (ValidarLoginUsuario == true && ValidarLoginEmpleado == true)
                {
                    if (ObjMetodosComunes.MetodoEncriptacionAES(contrasenaPredeterminada) == ObjDAOUsuario.Contrasena)
                    {
                        MessageBox.Show($"Bienvenido {InicioSesion.Usuario}, por motivos de seguridad, se le redireccionará automáticamente a un nuevo formulario para que pueda completar los pasos de nuevo usuario", "Ventana Emergente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Instanciamos a los formularios que deseamos abrir según la acción a realizar
                        DirecciónGmailForm ObjRedireccionarUsuarioSolicitante = new DirecciónGmailForm();
                        PreguntasdeSeguridadForm ObjRedireccionarPreguntasSeguridad = new PreguntasdeSeguridadForm();

                        //Si el usuario ya posee preguntas
                        //Se procede a actualizar solo la contraseña del mismo
                        if (ObjDAOUsuario.VerificarPreguntas() == true)
                        {
                            ObjLogin.Hide();
                            ObjRedireccionarUsuarioSolicitante.Show();
                        }
                        else
                        {
                            //Caso contrario, el usuario es nuevo en la aplicación
                            //Insertamos sus preguntas y restablecemos la contraseña
                            ObjRedireccionarPreguntasSeguridad.txtDUIProfesional.Text = InicioSesion.Dui;
                            ObjRedireccionarPreguntasSeguridad.btnVerificarPregunta.Enabled = false;
                            ObjRedireccionarPreguntasSeguridad.lblIngreseCredenciales.Visible = false;
                            ObjRedireccionarPreguntasSeguridad.txtUsuario.Visible = false;
                            ObjRedireccionarPreguntasSeguridad.txtDocumento.Visible = false;
                            ObjRedireccionarPreguntasSeguridad.pnlLineaDivisora.Visible = false;
                            ObjRedireccionarPreguntasSeguridad.ShowDialog();

                            ObjLogin.Hide();
                            ObjRedireccionarUsuarioSolicitante.Show();
                        }
                    }
                    else
                    {
                        if (ValidarLoginUsuario == true && ValidarLoginEmpleado == true)
                        {
                            if (ObjLogin.cbRecuerdame.Checked == true)
                            {
                                //string usuario = ObjDAOUsuario.Usuario;
                                Properties.Settings.Default.Usuario = ObjLogin.txtUsuario.Text;
                                Properties.Settings.Default.Contrasena = ObjLogin.txtContraseña.Text;
                                Properties.Settings.Default.Save();
                            }
                            else
                            {
                                //string usuario = ObjDAOUsuario.Usuario;
                                Properties.Settings.Default.Usuario = "";
                                Properties.Settings.Default.Contrasena = "";
                                Properties.Settings.Default.Save();
                            }

                            DashboardForm ObjMostrarDashboard = new DashboardForm();
                            ObjLogin.Hide();
                            ObjMostrarDashboard.Show();
                        }
                        else
                        {
                            ObjLogin.NotificacionLogin.Show(ObjLogin, "El usuario o contraseña son incorrectos", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        }
                    }
                }
                else
                {
                    ObjLogin.NotificacionLogin.Show(ObjLogin, "El usuario o contraseña son incorrectos", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void OlvidarContrasena(object sender, EventArgs e)
        {
            RecuperarContraseñaOPCForm ObjRecuperarContrasenaOPC = new RecuperarContraseñaOPCForm();
            ObjLogin.Hide();
            ObjRecuperarContrasenaOPC.Show();
        }
    }
}