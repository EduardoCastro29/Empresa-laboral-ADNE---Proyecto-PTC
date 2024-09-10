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
        CalendarioForm objCalendario = new CalendarioForm();
        readonly UCDias ObjUCDIAS;
        public static int static_day;
        public CTRLUCDias(UCDias Vista)
        {
            ObjUCDIAS = Vista;

            ObjUCDIAS.btnCalendar.Click += new EventHandler(AgregarCita);
        }
        private void AgregarCita(object sender, EventArgs e)
        {
            static_day = int.Parse(ObjUCDIAS.lblDias.Text);
            if (static_day < DateTime.Now.Day)
            {
                objCalendario.NotificacionCalendario.Show(objCalendario, "No se puede elegir una fecha pasada a la fecha actual al agendar una cita", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            else
            {
                AgendarCitaForm ObjAgendarCita = new AgendarCitaForm();
                ObjAgendarCita.btnModificar.Enabled = false;
                ObjAgendarCita.dtFecha.Enabled = false;
                ObjAgendarCita.Show();
                //Dejamos un valor por defecto en el combobox
                ObjAgendarCita.cmbEstado.SelectedIndex = 1;
                ObjAgendarCita.cmbEstado.Enabled = false;
            }
        }
        public void days(int numDia)
        {
            ObjUCDIAS.lblDias.Text = numDia + "";
        }
        //Cambio de color cuando el cursor se encuentra sobre el User control
        public void HoverUC(object sender, EventArgs e)
        {
            ObjUCDIAS.btnCalendar.BackColor = Color.PaleTurquoise;
        }
        //Este método hace que el UC vuelva a la normalidad
        //public void NormalUC(object sender, EventArgs e)
        //{
        //    int diaActual = DateTime.Now.Day;
        //    int mesActual = DateTime.Now.Month;
        //    int añoActual = DateTime.Now.Year;

        //    // Si es el día actual, mantenemos el color LightBlue
        //    if (ObjUCDIAS.lblDias.Text == diaActual.ToString() &&
        //        CTRLCalendario.static_month == mesActual &&
        //        CTRLCalendario.static_year == añoActual)
        //    {
        //        ObjUCDIAS.btnCalendar.BackColor = Color.FromArgb(176, 255, 242); // Mantener color para el día actual

        //    }
        //    else
        //    {
        //        ObjUCDIAS.btnCalendar.BackColor = Color.White;
        //    }
        //}
    }
}