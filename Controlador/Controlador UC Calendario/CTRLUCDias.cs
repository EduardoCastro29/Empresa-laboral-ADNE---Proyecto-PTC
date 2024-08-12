using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
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

            ObjUCDIAS.Click += new EventHandler(AgregarCita);
        }
        private void AgregarCita(object sender, EventArgs e)
        {
            static_day = ObjUCDIAS.lblDias.Text;
            AgendarCitaForm ObjAgendarCita = new AgendarCitaForm();
            ObjAgendarCita.btnModificar.Enabled = false;
            ObjAgendarCita.txtfecha.Enabled = false;
            ObjAgendarCita.Show();
        }
        public void days(int numDia)
        {
            ObjUCDIAS.lblDias.Text = numDia + "";
        }
    }
}