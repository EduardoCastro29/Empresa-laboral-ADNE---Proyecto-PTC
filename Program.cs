using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;

namespace Empresa_laboral_ADNE___Proyecto_PTC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new CitasForm()); //Borrar
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Creamos un objeto de la clase DAOLogin
            DAOLogin verificarUsuarios = new DAOLogin();

            //Si hay usuarios registrados en la base de datos, abrimos el formulario de Login
            if (verificarUsuarios.VerificarUsuario() == true)
            {
                Application.Run(new LoginForm());
            }
            else
            {
                //Caso contrario, se abrira el formulario de Registro
                Application.Run(new RegistroForm());
            }
        }
    }
}