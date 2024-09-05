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
            this.ParentChanged += new EventHandler(OnParentChanged);

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
