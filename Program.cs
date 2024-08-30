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
            //Application.Run(new CitasForm()); //Borrar
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Creamos un objeto de la clase DAOLogin
            DAOLogin ObjVerificarUsuarios = new DAOLogin();
            DAOPrimerUsoSistema ObjVerificarEmpresa = new DAOPrimerUsoSistema();

            //Indicamos que formularios se abriran según la consulta SQL
            if (ObjVerificarEmpresa.VerificarEmpresa() == false)
            {
                Application.Run(new PrimerUsoSistemaForm());
            }
            else if (ObjVerificarUsuarios.VerificarUsuario() == false)
            {
                Application.Run(new RegistroForm());
            }
            else
            {
                //Caso contrario, se abrira el formulario de Login (Ya existe una empresa registrada y el primer empleado registrado)
                Application.Run(new LoginForm());
            }
        }
    }
}