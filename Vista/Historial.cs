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
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
            leerIni();
            CTRLHistorial ObjControladorHistorial = new CTRLHistorial(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(32, 84, 89);
                this.bunifuPanel1.BackgroundColor = Color.Teal;
                this.lblHistorial.ForeColor = Color.FromArgb(220, 236, 242);
            }
        }
    }
}
