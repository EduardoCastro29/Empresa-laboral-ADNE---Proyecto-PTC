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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            leerIni();
            CTRLDashboard ObjDashboardControlador = new CTRLDashboard(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.bunifuGradientPanel1.GradientBottomLeft = Color.FromArgb(20, 131, 130);
                this.bunifuGradientPanel1.GradientTopLeft = Color.FromArgb(28, 104, 108);
                this.bunifuGradientPanel1.GradientTopRight = Color.FromArgb(28, 104, 108);
                this.bunifuGradientPanel1.GradientBottomRight = Color.FromArgb(20, 131, 130);

            }
        }
    }
}
 