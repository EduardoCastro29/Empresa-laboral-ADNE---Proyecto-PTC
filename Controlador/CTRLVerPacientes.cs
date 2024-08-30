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
        public CTRLVerPacientes(VerPacientesForm vista)
        {
            ObjVerPaciente = vista;
            ObjVerPaciente.Load += new EventHandler(CargarPacientes);
            ObjVerPaciente.txtBuscarPaciente.KeyPress += new KeyPressEventHandler(BuscarNombrePaciente);
            ObjVerPaciente.btnAbrirDocumentos.Click += new EventHandler(AbrirDocumento);
        }

        private void AbrirDocumento(object sender, EventArgs e)
        {
            CitasForm ObjMostrarCitas = new CitasForm();
            ObjVerPaciente.Hide();
            ObjMostrarCitas.Show();
        }

        private void CargarPacientes(object sender, EventArgs e)
        {
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

        private void BuscarNombrePaciente(object sender, KeyPressEventArgs e)
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