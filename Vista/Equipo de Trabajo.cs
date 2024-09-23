using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class EquipodeTrabajoForm : Form
    {

        public EquipodeTrabajoForm()
        {
            InitializeComponent();
            leerIni();
            CTRLEquipoTrabajo ObjEquipoControlador = new CTRLEquipoTrabajo(this);
            this.flpEmpleadosControl.HorizontalScroll.Enabled = false;
            this.flpEmpleadosControl.HorizontalScroll.Visible = false;
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(28, 104, 108);

                this.pnlForms.GradientTopLeft = Color.FromArgb(34, 120, 128);
                this.pnlForms.GradientTopRight = Color.FromArgb(34, 120, 128);
                this.pnlForms.GradientBottomLeft = Color.FromArgb(45, 137, 145);
                this.pnlForms.GradientBottomRight = Color.FromArgb(45, 137, 145);

                this.pnlTituloGradiente.GradientTopLeft = Color.FromArgb(35, 120, 118);
                this.pnlTituloGradiente.GradientBottomLeft = Color.FromArgb(35, 120, 118);
                this.pnlTituloGradiente.GradientTopRight = Color.FromArgb(42, 132, 123);
                this.pnlTituloGradiente.GradientBottomRight = Color.FromArgb(42, 132, 123);

                this.lblTItulo.ForeColor = Color.FromArgb(235, 235, 235);

                this.bunifuGradientPanel3.GradientTopLeft = Color.FromArgb(69, 104, 117);
                this.bunifuGradientPanel3.GradientTopRight = Color.FromArgb(39, 102, 119);
                this.bunifuGradientPanel3.GradientBottomLeft = Color.FromArgb(46, 102, 110);
                this.bunifuGradientPanel3.GradientBottomRight = Color.FromArgb(38, 102, 119);

                this.bunifuPictureBox1.Image = Resources.Equipo_de_Trabajo;
                this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;

                this.btnAdministrarEmpleado.IdleFillColor = Color.FromArgb(33, 150, 137);
                this.btnAdministrarEmpleado.IdleBorderColor = Color.FromArgb(33, 150, 137);
                this.btnAdministrarEmpleado.onHoverState.BorderColor = Color.FromArgb(31, 161, 147);
                this.btnAdministrarEmpleado.onHoverState.FillColor = Color.FromArgb(31, 161, 147);
                this.btnAdministrarEmpleado.OnPressedState.BorderColor = Color.FromArgb(27, 125, 114);
                this.btnAdministrarEmpleado.OnPressedState.FillColor = Color.FromArgb(27, 125, 114);
            }
        }
    }
}
