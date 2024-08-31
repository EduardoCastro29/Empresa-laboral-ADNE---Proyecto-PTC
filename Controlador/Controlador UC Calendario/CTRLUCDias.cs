using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador.Controlador_UC_Calendario
{
    internal class CTRLUCDias
    {
        readonly UCDias ObjUCDIAS;
        public static string static_day;
        public CTRLUCDias(UCDias Vista)
        {
            ObjUCDIAS = Vista;

            ObjUCDIAS.MouseHover += new EventHandler(HoverUC);
            ObjUCDIAS.MouseLeave += new EventHandler(NormalUC);
            ObjUCDIAS.Click += new EventHandler(AgregarCita);
        }
        private void AgregarCita(object sender, EventArgs e)
        {
            static_day = ObjUCDIAS.lblDias.Text;
            AgendarCitaForm ObjAgendarCita = new AgendarCitaForm();
            ObjAgendarCita.btnModificar.Enabled = false;
            ObjAgendarCita.dtFecha.Enabled = false;
            ObjAgendarCita.Show();
            //Dejamos un valor por defecto en el combobox
            ObjAgendarCita.cmbEstado.SelectedIndex = 1;
            ObjAgendarCita.cmbEstado.Enabled = false;
        }
        public void days(int numDia)
        {
            ObjUCDIAS.lblDias.Text = numDia + "";
        }
        //Cambio de color cuando el cursor se encuentra sobre el User control
        public void HoverUC(object sender, EventArgs e)
        {
            ObjUCDIAS.BackColor = System.Drawing.Color.PaleTurquoise;
        }
        //Este método hace que el UC vuelva a la normalidad
        public void NormalUC(object sender, EventArgs e)
        {
            ObjUCDIAS.BackColor = System.Drawing.Color.White;
        }
    }
}