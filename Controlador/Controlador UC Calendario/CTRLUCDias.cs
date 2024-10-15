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
            ObjUCDIAS.btnCalendar.MouseHover += new EventHandler(HoverUC);
            ObjUCDIAS.btnCalendar.MouseLeave += new EventHandler(Normal);
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