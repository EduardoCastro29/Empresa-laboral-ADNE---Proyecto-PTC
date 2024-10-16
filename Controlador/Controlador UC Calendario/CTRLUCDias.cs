using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador.Controlador_UC_Calendario
{
    internal class CTRLUCDias
    {
        readonly UCDias ObjUCDIAS;
        public CTRLUCDias(UCDias Vista)
        {
            ObjUCDIAS = Vista;

            ObjUCDIAS.btnCalendar.MouseHover += new EventHandler(HoverUC);
            ObjUCDIAS.btnCalendar.MouseLeave += new EventHandler(Normal);
        }
        public void days(int numDia)
        {
            ObjUCDIAS.lblDias.Text = numDia + "";
        }
        public void HoverUC(object sender, EventArgs e)
        {
            ObjUCDIAS.lblDias.BackColor = Color.FromArgb(176, 255, 242);
            ObjUCDIAS.btnCalendar.BackColor = Color.FromArgb(135, 224, 210);
        }
        public void Normal(object sender, EventArgs e)
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                ObjUCDIAS.lblDias.BackColor = Color.FromArgb(2, 135, 135);
            }
            else
            {
                ObjUCDIAS.lblDias.BackColor = Color.White;
                ObjUCDIAS.btnCalendar.BackColor = Color.White;
            }
        }
    }
}