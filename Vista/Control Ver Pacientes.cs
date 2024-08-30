using Empresa_laboral_ADNE___Proyecto_PTC.Controlador.ControladorUserControlPaciente;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class ControlVerPacientesUC : UserControl
    {
        internal ControlVerPacientesUC(DAOVerPacientes DaoVerPaciente)
        {
            InitializeComponent();

            // Aca hacemos referencia al controlador de paciente de user control con los parametros de ControlVerPacientesUC vista
            CTRLPacienteUC ObjVerInforme = new CTRLPacienteUC(this);
            try
            {
                lblNombrePaciente.Text = DaoVerPaciente.NombreApellido;
                lblPacienteId.Text = DaoVerPaciente.DocumentoPresentado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
