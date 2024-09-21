using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class NuevoPacienteForm : Form
    {
        public NuevoPacienteForm()
        {
            InitializeComponent();
            leerIni();
            CTRLNuevoPaciente ObjNuevoPacienteControlador = new CTRLNuevoPaciente(this);
        }
            
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(30, 92, 98);
                this.bunifuPictureBox1.Image = Properties.Resources.Frame_9;
                this.lblRegistroPaciente.ForeColor = Color.White;
                this.bunifuGradientPanel1.GradientTopLeft = Color.FromArgb(16, 98, 124);
                this.bunifuGradientPanel1.GradientBottomLeft = Color.FromArgb(16, 98, 124);
                this.bunifuGradientPanel1.GradientBottomRight = Color.FromArgb(41, 88, 101);
                this.bunifuGradientPanel1.GradientTopRight = Color.FromArgb(41, 88, 101);
                this.BarraSeparadora.GradientBottomLeft = Color.FromArgb(42, 86, 100);
                this.BarraSeparadora.GradientTopLeft = Color.FromArgb(42, 86, 100);
                this.BarraSeparadora.GradientBottomRight = Color.FromArgb(42, 86, 100);
                this.BarraSeparadora.GradientTopRight = Color.FromArgb(42, 86, 100);
            }
        }


    }
}
