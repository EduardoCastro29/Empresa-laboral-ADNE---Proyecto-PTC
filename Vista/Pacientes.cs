using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
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
    public partial class PacientesForm : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        //);
        public PacientesForm()
        {
            InitializeComponent();
            leerIni();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

            CTRLPacientes ObjPacientesControlador = new CTRLPacientes(this);
        }

        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(30, 92, 98);
                this.pnlForms.GradientTopLeft = Color.FromArgb(40, 157, 163);
                this.pnlForms.GradientTopRight = Color.FromArgb(34, 135, 140);
                this.pnlForms.GradientBottomLeft = Color.FromArgb(40, 157, 163);
                this.pnlForms.GradientBottomRight = Color.FromArgb(29, 112, 117);
                this.bunifuPanel2.BackgroundColor = Color.FromArgb(53, 109, 127);
                this.bunifuPanel3.BackgroundColor = Color.FromArgb(53, 109, 127);
                this.bunifuShadowPanel2.ShadowColor = Color.FromArgb(28, 111, 114);
                this.bunifuShadowPanel3.ShadowColor = Color.FromArgb(28, 111, 114);
                this.bunifuPictureBox1.Image = Properties.Resources.IconUSER;
                this.bunifuPictureBox2.Image = Properties.Resources.userPLUS__;
                this.bunifuPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }
    }
}
