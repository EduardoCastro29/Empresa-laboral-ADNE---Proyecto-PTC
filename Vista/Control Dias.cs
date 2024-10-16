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
        readonly CalendarioForm objCalendario = new CalendarioForm();
        public static int static_day;
        public UCDias()
        {
            InitializeComponent();
            leerIni();
            CTRLUCDias ObjUCControladorDias = new CTRLUCDias(this);
        }
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
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            static_day = int.Parse(this.lblDias.Text);
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
    }
}