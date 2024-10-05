using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
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
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            ConfiguraciónForm objConfiguraciónForm = new ConfiguraciónForm();
            DashboardForm objDashboardForm = new DashboardForm();
            LeerIni(objConfiguraciónForm);
            //Creamos las instancias de las clases respectivas para la verificación de formularios
            DAOLogin ObjVerificarUsuarios = new DAOLogin();
            DAOPrimerUsoSistema ObjVerificarEmpresa = new DAOPrimerUsoSistema();
            CommonMethods ObjVerificarDocumentoXML = new CommonMethods();

            if (ObjVerificarDocumentoXML.LeerArchivoXMLConexion() == false)
            {
                Application.Run(new AgregarConexionForm());
            }
            //Indicamos que formularios se abriran según la consulta SQL
            else if (ObjVerificarEmpresa.VerificarEmpresa() == false)
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
        static void LeerIni(ConfiguraciónForm ObjConfiguracionForm)
        {
            Config objConfig = new Config();
            objConfig.LeerIni();
            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                ObjConfiguracionForm.switchModo.Checked = true;
                ObjConfiguracionForm.BackColor = Color.FromArgb(30, 92, 98);
            }
            else
            {
                ObjConfiguracionForm.switchModo.Checked = false;
                ObjConfiguracionForm.BackColor = Color.FromArgb(14, 143, 156);
            }
        }
    }
}