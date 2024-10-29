using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
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
    public partial class CitasForm : Form
    {
        public CitasForm()
        {
            InitializeComponent();
            leerIni();
            CTRLExpedientes objCitas = new CTRLExpedientes(this);
        }

        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(28, 104, 108);

                this.pnlForms.GradientTopLeft = Color.FromArgb(18, 93, 99);
                this.pnlForms.GradientTopRight = Color.FromArgb(18, 93, 99);
                this.pnlForms.GradientBottomLeft = Color.FromArgb(34, 120, 128);
                this.pnlForms.GradientBottomRight = Color.FromArgb(34, 120, 128);

                this.txtBuscarCita.FillColor = Color.FromArgb(220, 236, 242);
                this.txtBuscarCita.PlaceholderForeColor = Color.DimGray;

            }
        }
    }
}
