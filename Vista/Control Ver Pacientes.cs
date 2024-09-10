using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
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

        internal ControlVerPacientesUC(DAOActividades daoActividades)
        {
            InitializeComponent();
            this.ParentChanged += new EventHandler(ParentChangedActividades);
            CTRLPacienteUC ObjVerInforme = new CTRLPacienteUC(this);

            try
            {
                // Aquí puedes asignar los datos del objeto DAOActividades a los controles
                lblNombrePaciente.Text = daoActividades.Nombre1 + " " + daoActividades.Apellido1;
                lblPacienteId.Text = daoActividades.DUI1; // Asegúrate de tener esta propiedad en DAOActividades
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ParentChangedActividades(object sender, EventArgs e)
        {
            if (this.Parent != null && this.Parent is Panel)
            {
                Panel flpEmpleadosControl = this.Parent as Panel;
                flpEmpleadosControl.Resize += new EventHandler(PnlResponsive);
            }
        }
        private void PnlResponsive(object sender, EventArgs e)
        {
            Panel p = sender as Panel;

            if (p != null)
            {
                int anchop = p.Width;
                this.Size = new Size(anchop, this.Height); // Ajusta solo el ancho

                p.PerformLayout(); // Asegura que el layout se actualice
                p.Invalidate();    // Fuerza un redibujado
                p.Update();
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
