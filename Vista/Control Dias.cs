using Empresa_laboral_ADNE___Proyecto_PTC.Controlador.Controlador_UC_Calendario;
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
    public partial class UCDias : UserControl
    {
        public UCDias()
        {
            InitializeComponent();
            leerIni();
            CTRLUCDias ObjUCControladorDias = new CTRLUCDias(this);
        }
        //public void ModificarFondo(Color color)
        //{
        //    this.btnCalendar.BackColor = color;
        //}
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.btnCalendar.IdleFillColor = Color.FromArgb(2, 135, 135);
                this.btnCalendar.IdleBorderColor = Color.FromArgb(2, 135, 135);
                this.lblDias.ForeColor = Color.FromArgb(207, 227, 227);
                this.lblDias.BackColor = Color.FromArgb(2, 135, 135);
            }
        }
    }
}