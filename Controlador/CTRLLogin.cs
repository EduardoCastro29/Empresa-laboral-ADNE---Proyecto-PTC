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
        //Creando un objeto del formulario login
        readonly LoginForm ObjLogin;

        //Empezamos la encapsulación de la clase Controlador Login
        //Esta tendrá como parámetros el formulario Login haciendo referencia a la carpeta Vista
        public CTRLLogin(LoginForm Vista)
        {
            //Enlazando el objeto con la Vista dentro del constructor
            ObjLogin = Vista;

            //Creando el evento EventHandler con el botón Ingresar con parámetros AccederLogin, que posteriormente ejecutará un método
            ObjLogin.btnIniciarSesion.Click += new EventHandler(AccederLogin);
            ObjLogin.btnOlvidarContrasena.Click += new EventHandler(OlvidarContrasena);
        }
        //Creando un méto llamado AccederLogin que tomará como proceso los valores dentro de la clase DAO y del DTO
        private void AccederLogin(object sender, EventArgs e)
        {
            //Realizamos el proceso para capturar los datos del usuario y contraseña en la vista login
            DAOLogin ObjDAOUsuario = new DAOLogin();
            CommonMethods ObjMetodosComunes = new CommonMethods();
            ObjDAOUsuario.Usuario = ObjLogin.txtUsuario.Text.Trim();
            //Llamamos al objeto ObjObtenerMetodoAES para evaluar si la contraseña ingresada en el Login
            //Coincide con la encriptada en la base de datos
            ObjDAOUsuario.Contrasena = ObjMetodosComunes.MetodoEncriptacionAES(ObjLogin.txtContraseña.Text.Trim());

            //Creamos dos variables de tipo booleano que nos devolverá si el inicio de sesión del profesional y el usuario
            //Son correctos dados los métodos y la clase
            bool ValidarLoginUsuario = ObjDAOUsuario.Login();
            bool ValidarLoginEmpleado = ObjDAOUsuario.LoginEmpleado();

            try
            {
                //Dado las variables del Login del usuario y el empleado
                //Evaluamos si coinciden con los métodos creados en el DAO
                if (ValidarLoginUsuario == true && ValidarLoginEmpleado == true)
                {
                    MessageBox.Show($"Bienvenido {InicioSesion.Usuario} Que pedales", "Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DashboardForm ObjMostrarDashboard = new DashboardForm();
                    ObjLogin.Hide();
                    ObjMostrarDashboard.Show();
                }
                else
                {
                    //Si el usuario no existe, mostramos un mensaje de error
                    MessageBox.Show("El usuario o contraseña son incorrectos", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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