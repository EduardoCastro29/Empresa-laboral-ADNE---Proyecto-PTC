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
    public partial class CalendarioForm : Form
    {
        public CalendarioForm()
        {
            InitializeComponent();
            leerIni();
            CTRLCalendario ObjCalendarioControlador = new CTRLCalendario(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();
            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(28, 104, 108);
                this.btnVerCitas.IdleFillColor = Color.FromArgb(33, 150, 137);
                this.btnVerCitas.IdleBorderColor = Color.FromArgb(33, 150, 137);
                this.btnVerCitas.onHoverState.BorderColor = Color.FromArgb(31, 161, 147);
                this.btnVerCitas.onHoverState.FillColor = Color.FromArgb(31, 161, 147);
                this.btnVerCitas.OnPressedState.BorderColor = Color.FromArgb(27, 125, 114);
                this.btnVerCitas.OnPressedState.FillColor = Color.FromArgb(27, 125, 114);
            }
        }
    }
}
