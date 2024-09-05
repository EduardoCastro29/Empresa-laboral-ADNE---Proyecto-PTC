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
            this.ParentChanged += new EventHandler(OnParentChanged);
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
        private void OnParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null && this.Parent is FlowLayoutPanel)
            {
                FlowLayoutPanel flpEmpleadosControl = this.Parent as FlowLayoutPanel;
                flpEmpleadosControl.Resize += new EventHandler(DResponsive);
            }
        }
        private void DResponsive(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = sender as FlowLayoutPanel;

            if (flp != null)
            {
                int anchoflp = flp.Width;
                this.Size = new Size(anchoflp, this.Height); // Ajusta solo el ancho

                flp.PerformLayout(); // Asegura que el layout se actualice
                flp.Invalidate();    // Fuerza un redibujado
                flp.Update();
            }
        }
    }
}
