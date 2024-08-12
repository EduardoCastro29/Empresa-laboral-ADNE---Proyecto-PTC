using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
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
    public partial class ControlPacientePlanillaUC : UserControl
    {
        internal ControlPacientePlanillaUC(DAOCitas objDAOCitas)
        {
            InitializeComponent();
            CTRLCitas objUCCitas = new CTRLCitas(this);
            try
            {
                lblCitaId.Text = objDAOCitas.CitaId.ToString();
                lblExpedienteId.Text = objDAOCitas.N_expediente.ToString();
                lblPacienteId.Text = objDAOCitas.PacienteId.ToString();

                lblNombrePaciente.Text = objDAOCitas.Nombre;
                lblFecha.Text = objDAOCitas.Fecha.Date.ToString("dd/MM/yyyy");
                lblHora.Text = objDAOCitas.HoraInicio.ToString();
                lblEstado.Text = objDAOCitas.EstadoId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
