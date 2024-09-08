using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;

namespace Empresa_laboral_ADNE___Proyecto_PTC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Creamos las instancias de las clases respectivas para la verificación de formularios
            DAOLogin ObjVerificarUsuarios = new DAOLogin();
            DAOPrimerUsoSistema ObjVerificarEmpresa = new DAOPrimerUsoSistema();
            /*CommonMethods ObjVerificarDocumentoXML = new CommonMethods();

            if (ObjVerificarDocumentoXML.LeerArchivoXMLConexion() == false)
            {
                Application.Run(new AgregarConexion());
            }
            //Indicamos que formularios se abriran según la consulta SQL
            else */if (ObjVerificarEmpresa.VerificarEmpresa() == false)
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