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
    public partial class Control_Profesional : UserControl
    {
        internal Control_Profesional(DAOEquipoTrabajo DAOProfesional)
        {
            InitializeComponent();
            this.ParentChanged += new EventHandler(OnParentChanged);
            try
            {
                lblIdProfesional.Text = DAOProfesional.DUI;
                lblNombreProfesional.Text = DAOProfesional.NombresApellidos;
                lblEmail.Text = DAOProfesional.Correo;
                lblEspecialidad.Text = DAOProfesional.Especialidad;
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