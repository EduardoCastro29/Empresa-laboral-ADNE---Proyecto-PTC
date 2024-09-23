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

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class AgendarCitaForm : Form
    {
        public AgendarCitaForm()
        {
            InitializeComponent();
            leerIni();
            CTRLAgendarCita ObjAgendarCitaControlador = new CTRLAgendarCita(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(30, 58, 69);

                this.pnlEncabezado.BackColor = Color.FromArgb(37, 102, 110);

                this.lblProfesional.ForeColor = Color.White;
                this.lblPaciente.ForeColor = Color.White;
                this.lblHoraInicio.ForeColor = Color.White;
                this.lblHoraFinal.ForeColor = Color.White;
                this.lblFecha.ForeColor = Color.White;
                this.lblLugar.ForeColor = Color.White;
                this.lblConsulta.ForeColor = Color.White;
                this.lblEstado.ForeColor = Color.White;

                this.txtDUIPaciente.FillColor = Color.FromArgb(50, 89, 108);
                this.txtDUIPaciente.ForeColor = Color.WhiteSmoke;
                this.txtDUIPaciente.PlaceholderForeColor = Color.WhiteSmoke;
                this.txtDUIPaciente.BorderColorIdle = Color.Transparent;

                this.txtDUIProfesional.FillColor = Color.FromArgb(50, 89, 108);
                this.txtDUIProfesional.ForeColor = Color.WhiteSmoke;
                this.txtDUIProfesional.PlaceholderForeColor = Color.WhiteSmoke;
                this.txtDUIProfesional.BorderColorIdle = Color.Transparent;

                this.txtMotivoConsulta.FillColor = Color.FromArgb(50, 89, 108);
                this.txtMotivoConsulta.ForeColor = Color.WhiteSmoke;
                this.txtMotivoConsulta.PlaceholderForeColor = Color.WhiteSmoke;
                this.txtMotivoConsulta.BorderColorIdle = Color.Transparent;

                this.txtDUIPaciente.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtDUIPaciente.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtDUIPaciente.OnDisabledState.BorderColor = Color.Transparent;
                this.txtDUIPaciente.BorderColorDisabled = Color.Transparent;

                this.txtDUIProfesional.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtDUIProfesional.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtDUIProfesional.OnDisabledState.BorderColor = Color.Transparent;
                this.txtDUIProfesional.BorderColorDisabled = Color.Transparent;

                this.txtMotivoConsulta.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtMotivoConsulta.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtMotivoConsulta.OnDisabledState.BorderColor = Color.Transparent;
                this.txtMotivoConsulta.BorderColorDisabled = Color.Transparent;

                this.cmbEstado.ItemHighLightColor = Color.FromArgb(22, 121, 130);
                this.cmbEstado.ItemBackColor = Color.FromArgb(21, 48, 54);
                this.cmbEstado.ItemForeColor = Color.WhiteSmoke;
                this.cmbEstado.ForeColor = Color.WhiteSmoke;
                this.cmbEstado.BackgroundColor = Color.FromArgb(50, 89, 108);
                this.cmbEstado.BorderColor = Color.Transparent;
                this.cmbEstado.IndicatorColor = Color.FromArgb(6, 153, 141);

                this.cmbEstado.DisabledBackColor = Color.FromArgb(41, 67, 79);
                this.cmbEstado.DisabledIndicatorColor = Color.FromArgb(38, 113, 130);
                this.cmbEstado.DisabledBorderColor = Color.Transparent;
                this.cmbEstado.DisabledForeColor = Color.WhiteSmoke;

                this.cmbLugar.ItemHighLightColor = Color.FromArgb(22, 121, 130);
                this.cmbLugar.ItemBackColor = Color.FromArgb(21, 48, 54);
                this.cmbLugar.ItemForeColor = Color.WhiteSmoke;
                this.cmbLugar.ForeColor = Color.WhiteSmoke;
                this.cmbLugar.BackgroundColor = Color.FromArgb(50, 89, 108);
                this.cmbLugar.BorderColor = Color.Transparent;
                this.cmbLugar.IndicatorColor = Color.FromArgb(6, 153, 141);

                this.dtFecha.BackColor = Color.FromArgb(50, 89, 108);
                this.dtFecha.ForeColor = Color.WhiteSmoke;
                this.dtFecha.IconColor = Color.FromArgb(6, 153, 141);

                this.dtFecha.DisabledColor = Color.DarkGray;
            }
        }
    }
}
