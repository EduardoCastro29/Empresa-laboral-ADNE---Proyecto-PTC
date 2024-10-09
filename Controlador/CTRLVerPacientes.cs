using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Data;
using System.Runtime.Remoting.Channels;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLVerPacientes
    {
        readonly VerPacientesForm ObjVerPaciente;
        public CTRLVerPacientes(VerPacientesForm Vista)
        {
            ObjVerPaciente = Vista;

            ObjVerPaciente.Load += new EventHandler(CargarPacientesYPermisoUsuario);
            ObjVerPaciente.btnVerPacientesSinProfesional.Click += new EventHandler(CargarPacientesSinProfesional);
            ObjVerPaciente.btnBuscar.Click += new EventHandler(BuscarNombrePaciente);
        }
        private void CargarPacientesYPermisoUsuario(object sender, EventArgs e)
        {
            //Indicamos dado la variable de Inicio de Sesión qué botones son los que se accionarán dado el nivel de Usuario
            switch (InicioSesion.DesempenoId)
            {
                case "Administrador":
                    break;
                case "Empleado":
                    ObjVerPaciente.btnVerPacientesSinProfesional.Visible = false;
                    break;
                default:
                    break;
            }

            DAOVerPacientes ObjDaoPacientes = new DAOVerPacientes();
            DataTable dt = ObjDaoPacientes.VerPacientes();
            foreach (DataRow dr in dt.Rows)
            {
                ObjDaoPacientes.NombreApellido = (string)dr[0];
                ObjDaoPacientes.DocumentoPresentado = (string)dr[1];

                ControlVerPacientesUC ObjControlPaciente = new ControlVerPacientesUC(ObjDaoPacientes);
                ObjVerPaciente.flpVerPacientes.Controls.Add(ObjControlPaciente);
            }
        }
        private void CargarPacientesSinProfesional(object sender, EventArgs e)
        {
            //Limpiamos los controles que posee el FlowLayoutPanel para cargar los nuevos controles de usuario
            ObjVerPaciente.flpVerPacientes.Controls.Clear();
            DAOVerPacientes ObjDaoPacientes = new DAOVerPacientes();
            DataTable dt = ObjDaoPacientes.VerPacientesSinProfesional();
            foreach (DataRow dr in dt.Rows)
            {
                ObjDaoPacientes.NombreApellido = (string)dr[0];
                ObjDaoPacientes.DocumentoPresentado = (string)dr[1];

                ControlVerPacientesUC ObjControlPaciente = new ControlVerPacientesUC(ObjDaoPacientes);
                ObjVerPaciente.flpVerPacientes.Controls.Add(ObjControlPaciente);
            }
        }
        private void BuscarNombrePaciente(object sender, EventArgs e)
        {
            DAOVerPacientes ObjDaoPacientes = new DAOVerPacientes();
            DataSet ds = ObjDaoPacientes.BuscarPaciente(ObjVerPaciente.txtBuscarPaciente.Text.Trim());
            ObjVerPaciente.flpVerPacientes.Controls.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ObjDaoPacientes.NombreApellido = (string)dr[0];
                ObjDaoPacientes.DocumentoPresentado = (string)dr[1];
                ControlVerPacientesUC panelPaciente = new ControlVerPacientesUC(ObjDaoPacientes);
                ObjVerPaciente.flpVerPacientes.Controls.Add(panelPaciente);
            }
        }
    }
}