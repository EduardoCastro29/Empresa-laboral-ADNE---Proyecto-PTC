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
        internal ControlPacientePlanillaUC(DAODiagnosticos objDAOCitas)
        {
            InitializeComponent();
            leerIni();
            this.ParentChanged += new EventHandler(OnParentChanged);
            CTRLExpedientes objUCCitas = new CTRLExpedientes(this);
            try
            {
                lblCitaId.Text = objDAOCitas.CitaId.ToString();
                lblExpedienteId.Text = objDAOCitas.N_expediente.ToString();
                lblDUI.Text = objDAOCitas.DocumentoPaciente;

                lblNombrePaciente.Text = objDAOCitas.Nombre;
                lblDUI.Text = objDAOCitas.DocumentoPaciente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OnParentChanged(this, EventArgs.Empty);
        }
        //private void OnParentChanged(object sender, EventArgs e)
        //{
        //    if (this.Parent != null && this.Parent is FlowLayoutPanel)
        //    {
        //        FlowLayoutPanel flpEmpleadosControl = this.Parent as FlowLayoutPanel;
        //        flpEmpleadosControl.Resize += new EventHandler(DResponsive);
        //    }
        //}
        //private void DResponsive(object sender, EventArgs e)
        //{
        //    FlowLayoutPanel flp = sender as FlowLayoutPanel;

        //    if (flp != null)
        //    {
        //        int anchoflp = flp.Width;
        //        this.Size = new Size(anchoflp, this.Height); // Ajusta solo el ancho

        //        flp.PerformLayout(); // Asegura que el layout se actualice
        //        flp.Invalidate();    // Fuerza un redibujado
        //        flp.Update();
        //    }
        //}

        private void OnParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null && this.Parent is FlowLayoutPanel)
            {
                FlowLayoutPanel flpEmpleadosControl = this.Parent as FlowLayoutPanel;
                flpEmpleadosControl.Resize += new EventHandler(DResponsive); // Subscribirse al evento Resize

                // Llama a DResponsive para asegurar ajuste inicial
                DResponsive(flpEmpleadosControl, EventArgs.Empty);
            }
        }

        private void DResponsive(object sender, EventArgs e)
        {
            if (sender is FlowLayoutPanel flp)
            {
                int anchoflp = flp.ClientSize.Width;
                this.Width = anchoflp - flp.Margin.Horizontal; // Ajusta solo el ancho

                flp.PerformLayout(); // Asegura que el layout se actualice
                flp.Invalidate();    // Fuerza un redibujado
                flp.Update();
            }
        }

        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();
            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.pnlFondoUC.BackgroundColor = Color.FromArgb(26, 102, 122);
                this.SeparadorPnl.BackgroundColor = Color.WhiteSmoke;

                this.lblNombrePaciente.ForeColor = Color.White;
                this.lblDUI.ForeColor = Color.White;

                this.btnDescargar.onHoverState.FillColor = Color.FromArgb(33, 184, 177);
                this.btnDescargar.IdleFillColor = Color.FromArgb(28, 148, 143);
                this.btnDescargar.OnPressedState.ForeColor = Color.WhiteSmoke;
                this.btnDescargar.OnPressedState.FillColor = Color.FromArgb(22, 117, 113);
            }
        }
    }
}