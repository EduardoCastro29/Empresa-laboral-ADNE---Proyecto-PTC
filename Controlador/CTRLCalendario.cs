using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Drawing;
using System.Globalization;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador.Controlador_UC_Calendario;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLCalendario
    {
        readonly CalendarioForm ObjCalendario;
        readonly DateTime FechaActual = DateTime.Now;
        int Mes;
        int Año;
        public static int static_month, static_year;

        public CTRLCalendario(CalendarioForm Vista)
        {
            ObjCalendario = Vista;

            ObjCalendario.btnVerCitas.Click += new EventHandler(VerCitasAgendadas);
            ObjCalendario.Load += new EventHandler(DesplegarDias);
            ObjCalendario.btnAnterior.Click += new EventHandler(RetrocederMes);
            ObjCalendario.btnSiguiente.Click += new EventHandler(SiguienteMes);
        }
        private void VerCitasAgendadas(object sender, EventArgs e)
        {
            VerCitasForm ObjAbrirVerCitas = new VerCitasForm();
            ObjAbrirVerCitas.ShowDialog();
        }
        private void DesplegarDias(object sender, EventArgs e)
        {
            Mes = FechaActual.Month;
            Año = FechaActual.Year;

            string mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            mesNombre = FormatoPrimeraLetraMes(mesNombre);
            ObjCalendario.lblFecha.Text = mesNombre + " " + Año;
            static_month = Mes;
            static_year = Año;

            //tener el primer día del mes.
            DateTime startofthemonth = new DateTime(Año, Mes, 1);
            //tener la cantidad de días del mes.
            int dias = DateTime.DaysInMonth(Año, Mes);
            //Convertir los días en tipo entero
            int diadelasemana = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("D")) + 1;

            //blank usercontrol
            for (int i = 1; i < diadelasemana; i++)
            {
                UCEspacio ObjEspacio = new UCEspacio();
                ObjCalendario.daycontainer.Controls.Add(ObjEspacio);
            }

            //user control de días.
            for (int i = 1; i <= dias; i++)
            {
                UCDias ObjUCDias = new UCDias();
                CTRLUCDias ObjDias = new CTRLUCDias(ObjUCDias);
                ObjDias.days(i);

                ObjCalendario.daycontainer.Controls.Add(ObjUCDias);
            }
        }
        public static string FormatoPrimeraLetraMes(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return char.ToUpper(input[0]) + input.Substring(1);
        }
        private void SiguienteMes(object sender, EventArgs e)
        {
            //Limpiamos el panel contenedor que contiene los días
            ObjCalendario.daycontainer.Controls.Clear();
            //cambia la cantidad para mes previos
            Mes++;
            //cambiar la cantidad de días del mes.
            if (Mes > 12)
            {
                Mes = 1;
                Año++;
            }
            string mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            mesNombre = FormatoPrimeraLetraMes(mesNombre);
            ObjCalendario.lblFecha.Text = mesNombre + "  " + Año;

            static_month = Mes;
            static_year = Año;

            //tener el primer día del mes.
            DateTime startofthemonth = new DateTime(Año, Mes, 1);

            //tener la cantidad de días del mes.
            int dias = DateTime.DaysInMonth(Año, Mes);

            //Convertir los días en tipo entero
            int diadelasemana = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("D")) + 1;

            //blank usercontrol
            for (int i = 1; i < diadelasemana; i++)
            {
                UCEspacio ObjEspacio = new UCEspacio();
                ObjCalendario.daycontainer.Controls.Add(ObjEspacio);
            }

            //user control de días.
            for (int i = 1; i <= dias; i++)
            {
                UCDias ObjUCDias = new UCDias();
                CTRLUCDias ObjDias = new CTRLUCDias(ObjUCDias);
                ObjDias.days(i);

                ObjCalendario.daycontainer.Controls.Add(ObjUCDias);
            }
        }
        private void RetrocederMes(object sender, EventArgs e)
        {
            //Limpiamos el panel contenedor que contiene los días
            ObjCalendario.daycontainer.Controls.Clear();

            //cambia la cantidad para mes previos
            Mes--;
            //cambiar la cantidad de días del mes.
            if (Mes < 1)
            {
                Mes = 12;
                Año--;
            }
            string mesNombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(Mes);
            mesNombre = FormatoPrimeraLetraMes(mesNombre);
            ObjCalendario.lblFecha.Text = mesNombre + "  " + Año;

            static_month = Mes;
            static_year = Año;

            //tener el primer día del mes.
            DateTime startofthemonth = new DateTime(Año, Mes, 1);

            //tener la cantidad de días del mes.
            int dias = DateTime.DaysInMonth(Año, Mes);

            //Convertir los días en tipo entero
            int diadelasemana = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("D")) + 1;

            //blank usercontrol
            for (int i = 1; i < diadelasemana; i++)
            {
                UCEspacio ObjEspacio = new UCEspacio();
                ObjCalendario.daycontainer.Controls.Add(ObjEspacio);
            }
            for (int i = 1; i <= dias; i++)
            {
                UCDias ObjUCDias = new UCDias();
                CTRLUCDias ObjDias = new CTRLUCDias(ObjUCDias);
                ObjDias.days(i);

                ObjCalendario.daycontainer.Controls.Add(ObjUCDias);
            }
        }
    }
}