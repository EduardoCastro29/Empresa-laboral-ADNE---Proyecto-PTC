using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class ActividadesForm : Form
    {
        public ActividadesForm()
        {
            InitializeComponent();
            leerIni();
            CTRLActividades ObjCTRLActividades = new CTRLActividades(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                //PANEL FONDO:
                this.BackColor = Color.FromArgb(30, 92, 98);
                this.pnlFondoDashboard.GradientBottomLeft = Color.FromArgb(39, 154, 161);
                this.pnlFondoDashboard.GradientTopLeft = Color.FromArgb(39, 154, 161);
                this.pnlFondoDashboard.GradientBottomRight = Color.FromArgb(30, 115, 120);
                this.pnlFondoDashboard.GradientTopRight = Color.FromArgb(30, 115, 120);
                this.pnlFondoDashboard.Refresh();

                //PANELES:
                this.pnlBienvenida.GradientBottomLeft = Color.FromArgb(17, 98, 122);
                this.pnlBienvenida.GradientTopLeft = Color.FromArgb(17, 98, 122);
                this.pnlBienvenida.GradientTopRight = Color.FromArgb(40, 87, 101);
                this.pnlBienvenida.GradientBottomRight = Color.FromArgb(40, 87, 101);

                this.pnlHistorial.BackgroundColor = Color.FromArgb(18, 97, 121);
                this.pnlHistorial.BorderColor = Color.Transparent;

                this.pnlSiguientePaciente.BackgroundColor = Color.FromArgb(30, 115, 120);

                this.pnlCitas.BackgroundColor = Color.FromArgb(30, 115, 120);
                this.pnlCitas.BorderColor = Color.Transparent;

                this.pnlGrafico.BackgroundColor = Color.FromArgb(30, 115, 120);
                this.GraficoCitas.Legends[0].ForeColor = Color.White;
                this.GraficoCitas.Legends[0].BackColor = Color.Transparent;
                this.GraficoCitas.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                this.GraficoCitas.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

                this.pnlSombraCitas.ShadowColor = Color.FromArgb(60, 0, 0, 0);
                this.pnlSeparador1.BackgroundColor = Color.LightSeaGreen;
                this.pnlSeparador2.BackgroundColor = Color.LightSeaGreen;

                this.pnlBienvenida.Refresh();
                this.pnlHistorial.Refresh();

                //LABELS:
                this.lblHistorial.ForeColor = Color.White;
                this.lblSiguiente.ForeColor = Color.White;
                this.lblHoraCita.ForeColor = Color.White;
                this.lblHora.ForeColor = Color.White;
                this.lblDiaCita.ForeColor = Color.White;
                this.lblDia.ForeColor = Color.White;
                this.lblLugarCita.ForeColor = Color.White;
                this.lblLugar.ForeColor = Color.White;
                this.lblAtendidos.ForeColor = Color.White;
                this.lblCitasAtendidas.ForeColor = Color.White;
                this.lblPendientes.ForeColor = Color.White;
                this.lblCitasPendientes.ForeColor = Color.White;
                this.lblPerdidas.ForeColor = Color.White;
                this.lblCitasPerdidas.ForeColor = Color.White;
                this.bunifuLabel1.ForeColor = Color.White;
                this.bunifuLabel2.ForeColor = Color.White;

                this.dtFechaInicio.BackColor = Color.FromArgb(50, 89, 108);
                this.dtFechaInicio.ForeColor = Color.White;
                this.dtFechaInicio.IconColor = Color.FromArgb(6, 153, 141);

                this.dtFechaInicio.DisabledColor = Color.DarkGray;

                this.dtFechaFinal.BackColor = Color.FromArgb(50, 89, 108);
                this.dtFechaFinal.ForeColor = Color.White;
                this.dtFechaFinal.IconColor = Color.FromArgb(6, 153, 141);

                this.dtFechaFinal.DisabledColor = Color.DarkGray;

                this.btnVerPersonalizadoDia.onHoverState.FillColor = Color.FromArgb(2, 168, 168);
                this.btnVerPersonalizadoDia.onHoverState.BorderColor = Color.Transparent;
                this.btnVerPersonalizadoDia.IdleFillColor = Color.FromArgb(2, 168, 168);
                this.btnVerPersonalizadoDia.IdleBorderColor = Color.Transparent;
                this.btnVerPersonalizadoDia.OnPressedState.FillColor = Color.Teal;
                this.btnVerPersonalizadoDia.OnPressedState.BorderColor = Color.Transparent;

                this.btnVerEsteMes.onHoverState.FillColor = Color.FromArgb(2, 168, 168);
                this.btnVerEsteMes.onHoverState.BorderColor = Color.Transparent;
                this.btnVerEsteMes.IdleFillColor = Color.FromArgb(2, 168, 168);
                this.btnVerEsteMes.IdleBorderColor = Color.Transparent;
                this.btnVerEsteMes.OnPressedState.FillColor = Color.Teal;
                this.btnVerEsteMes.OnPressedState.BorderColor = Color.Transparent;

                this.btnVer30Dias.onHoverState.FillColor = Color.FromArgb(2, 168, 168);
                this.btnVer30Dias.onHoverState.BorderColor = Color.Transparent;
                this.btnVer30Dias.IdleFillColor = Color.FromArgb(2, 168, 168);
                this.btnVer30Dias.IdleBorderColor = Color.Transparent;
                this.btnVer30Dias.OnPressedState.FillColor = Color.Teal;
                this.btnVer30Dias.OnPressedState.BorderColor = Color.Transparent;

                this.btnVer7Dias.onHoverState.FillColor = Color.FromArgb(2, 168, 168);
                this.btnVer7Dias.onHoverState.BorderColor = Color.Transparent;
                this.btnVer7Dias.IdleFillColor = Color.FromArgb(2, 168, 168);
                this.btnVer7Dias.IdleBorderColor = Color.Transparent;
                this.btnVer7Dias.OnPressedState.FillColor = Color.Teal;
                this.btnVer7Dias.OnPressedState.BorderColor = Color.Transparent;

                this.btnVerEsteDia.onHoverState.FillColor = Color.FromArgb(2, 168, 168);
                this.btnVerEsteDia.onHoverState.BorderColor = Color.Transparent;
                this.btnVerEsteDia.IdleFillColor = Color.FromArgb(2, 168, 168);
                this.btnVerEsteDia.IdleBorderColor = Color.Transparent;
                this.btnVerEsteDia.OnPressedState.FillColor = Color.Teal;
                this.btnVerEsteDia.OnPressedState.BorderColor = Color.Transparent;

                this.btnHistorial.onHoverState.FillColor = Color.FromArgb(2, 168, 168);
                this.btnHistorial.onHoverState.BorderColor = Color.Transparent;
                this.btnHistorial.IdleFillColor = Color.Teal;
                this.btnHistorial.IdleBorderColor = Color.Transparent;
                this.btnHistorial.OnPressedState.FillColor = Color.FromArgb(1, 94, 94);
                this.btnHistorial.OnPressedState.BorderColor = Color.Transparent;

                this.btnOk.onHoverState.FillColor = Color.DarkTurquoise;
                this.btnOk.onHoverState.BorderColor = Color.Transparent;
                this.btnOk.IdleFillColor = Color.FromArgb(4, 181, 184);
                this.btnOk.IdleBorderColor = Color.Transparent;
                this.btnOk.OnPressedState.FillColor = Color.FromArgb(1, 145, 148);
                this.btnOk.OnPressedState.BorderColor = Color.Transparent;
            }
        }
    }
}
