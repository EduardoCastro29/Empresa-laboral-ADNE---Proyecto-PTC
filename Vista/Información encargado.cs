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
    public partial class InformaciónEncargadoForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public InformaciónEncargadoForm()
        {
            InitializeComponent();
            leerIni();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            CTRLInformacionEncargado ObjControladorInformacionENC = new CTRLInformacionEncargado(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(28, 104, 108);

                this.lblTituloForm.ForeColor = Color.White;

                this.pnlGradienteFondo.GradientTopLeft = Color.FromArgb(40, 68, 94);
                this.pnlGradienteFondo.GradientTopRight = Color.FromArgb(40, 68, 94);
                this.pnlGradienteFondo.GradientBottomLeft = Color.FromArgb(53, 56, 87);
                this.pnlGradienteFondo.GradientBottomRight = Color.FromArgb(69, 57, 89);

                this.lblDocumentoEncargado.ForeColor = Color.White;
                this.lblNombresEncargado.ForeColor = Color.White;
                this.lblFechaNacimiento.ForeColor = Color.White;
                this.lblTelefono.ForeColor = Color.White;
                this.lblEmail.ForeColor = Color.White;
                this.lblDomicilio.ForeColor = Color.White;
                this.bunifuLabel1.ForeColor = Color.White;
                this.lblEdad.ForeColor = Color.White;
                this.lblApellidosEncargado.ForeColor = Color.White;
                this.lblDUI.ForeColor = Color.White;
                this.lblPasaporte.ForeColor = Color.White;

                this.txtDocumentoEncargado.FillColor = Color.FromArgb(53, 98, 120);
                this.txtDocumentoEncargado.BorderColorIdle = Color.Transparent;
                this.txtDocumentoEncargado.ForeColor = Color.WhiteSmoke;
                this.txtDocumentoEncargado.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtNombresEncargado.FillColor = Color.FromArgb(53, 98, 120);
                this.txtNombresEncargado.BorderColorIdle = Color.Transparent;
                this.txtNombresEncargado.ForeColor = Color.WhiteSmoke;
                this.txtNombresEncargado.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtApellidosEncargado.FillColor = Color.FromArgb(53, 98, 120);
                this.txtApellidosEncargado.BorderColorIdle = Color.Transparent;
                this.txtApellidosEncargado.ForeColor = Color.WhiteSmoke;
                this.txtApellidosEncargado.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtEdadEncargado.FillColor = Color.FromArgb(53, 98, 120);
                this.txtEdadEncargado.BorderColorIdle = Color.Transparent;
                this.txtEdadEncargado.ForeColor = Color.WhiteSmoke;
                this.txtEdadEncargado.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtTelefono.FillColor = Color.FromArgb(53, 98, 120);
                this.txtTelefono.BorderColorIdle = Color.Transparent;
                this.txtTelefono.ForeColor = Color.WhiteSmoke;
                this.txtTelefono.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtCorreoEncargado.FillColor = Color.FromArgb(53, 98, 120);
                this.txtCorreoEncargado.BorderColorIdle = Color.Transparent;
                this.txtCorreoEncargado.ForeColor = Color.WhiteSmoke;
                this.txtCorreoEncargado.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtDomicilio.FillColor = Color.FromArgb(50, 89, 108);
                this.txtDomicilio.BorderColorIdle = Color.Transparent;
                this.txtDomicilio.ForeColor = Color.WhiteSmoke;
                this.txtDomicilio.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtDocumentoEncargado.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtDocumentoEncargado.OnDisabledState.FillColor = Color.FromArgb(45, 76, 92);
                this.txtDocumentoEncargado.OnDisabledState.BorderColor = Color.Transparent;
                this.txtDocumentoEncargado.BorderColorDisabled = Color.Transparent;

                this.txtNombresEncargado.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtNombresEncargado.OnDisabledState.FillColor = Color.FromArgb(45, 76, 92);
                this.txtNombresEncargado.OnDisabledState.BorderColor = Color.Transparent;
                this.txtNombresEncargado.BorderColorDisabled = Color.Transparent;

                this.txtApellidosEncargado.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtApellidosEncargado.OnDisabledState.FillColor = Color.FromArgb(45, 76, 92);
                this.txtApellidosEncargado.OnDisabledState.BorderColor = Color.Transparent;
                this.txtApellidosEncargado.BorderColorDisabled = Color.Transparent;

                this.txtEdadEncargado.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtEdadEncargado.OnDisabledState.FillColor = Color.FromArgb(45, 76, 92);
                this.txtEdadEncargado.OnDisabledState.BorderColor = Color.Transparent;
                this.txtEdadEncargado.BorderColorDisabled = Color.Transparent;

                this.txtTelefono.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtTelefono.OnDisabledState.FillColor = Color.FromArgb(45, 76, 92);
                this.txtTelefono.OnDisabledState.BorderColor = Color.Transparent;
                this.txtTelefono.BorderColorDisabled = Color.Transparent;

                this.txtCorreoEncargado.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtCorreoEncargado.OnDisabledState.FillColor = Color.FromArgb(45, 76, 92);
                this.txtCorreoEncargado.OnDisabledState.BorderColor = Color.Transparent;
                this.txtCorreoEncargado.BorderColorDisabled = Color.Transparent;

                this.txtDomicilio.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtDomicilio.OnDisabledState.FillColor = Color.FromArgb(45, 76, 92);
                this.txtDomicilio.OnDisabledState.BorderColor = Color.Transparent;
                this.txtDomicilio.BorderColorDisabled = Color.Transparent;

                this.cmbRelacionPaciente.ItemHighLightColor = Color.FromArgb(22, 121, 130);
                this.cmbRelacionPaciente.ItemBackColor = Color.FromArgb(21, 48, 54);
                this.cmbRelacionPaciente.ItemForeColor = Color.WhiteSmoke;
                this.cmbRelacionPaciente.ForeColor = Color.WhiteSmoke;
                this.cmbRelacionPaciente.BackgroundColor = Color.FromArgb(50, 89, 108);
                this.cmbRelacionPaciente.BorderColor = Color.Transparent;
                this.cmbRelacionPaciente.IndicatorColor = Color.FromArgb(6, 153, 141);

                this.cmbRelacionPaciente.DisabledBackColor = Color.FromArgb(41, 67, 79);
                this.cmbRelacionPaciente.DisabledIndicatorColor = Color.FromArgb(38, 113, 130);
                this.cmbRelacionPaciente.DisabledBorderColor = Color.Transparent;
                this.cmbRelacionPaciente.DisabledForeColor = Color.WhiteSmoke;

                this.btnRegistrarEncargado.onHoverState.BorderColor = Color.Teal;
                this.btnRegistrarEncargado.onHoverState.FillColor = Color.Teal;
                this.btnRegistrarEncargado.IdleBorderColor = Color.Transparent;
                this.btnRegistrarEncargado.IdleFillColor = Color.FromArgb(0, 110, 110);
                this.btnRegistrarEncargado.OnPressedState.BorderColor = Color.Transparent;
                this.btnRegistrarEncargado.OnPressedState.FillColor = Color.FromArgb(0, 90, 90);
                this.btnRegistrarEncargado.OnDisabledState.BorderColor = Color.Transparent;
                this.btnRegistrarEncargado.OnDisabledState.FillColor = Color.FromArgb(61, 87, 87);

                this.btnActualizarEncargado.onHoverState.BorderColor = Color.Teal;
                this.btnActualizarEncargado.onHoverState.FillColor = Color.Teal;
                this.btnActualizarEncargado.IdleBorderColor = Color.Transparent;
                this.btnActualizarEncargado.IdleFillColor = Color.FromArgb(0, 110, 110);
                this.btnActualizarEncargado.OnPressedState.BorderColor = Color.Transparent;
                this.btnActualizarEncargado.OnPressedState.FillColor = Color.FromArgb(0, 90, 90);
                this.btnActualizarEncargado.OnDisabledState.BorderColor = Color.Transparent;
                this.btnActualizarEncargado.OnDisabledState.FillColor = Color.FromArgb(52, 64, 74);

                this.btnEliminarEncargado.onHoverState.BorderColor = Color.Teal;
                this.btnEliminarEncargado.onHoverState.FillColor = Color.Teal;
                this.btnEliminarEncargado.IdleBorderColor = Color.Transparent;
                this.btnEliminarEncargado.IdleFillColor = Color.FromArgb(0, 110, 110);
                this.btnEliminarEncargado.OnPressedState.BorderColor = Color.Transparent;
                this.btnEliminarEncargado.OnPressedState.FillColor = Color.FromArgb(0, 90, 90);
                this.btnEliminarEncargado.OnDisabledState.BorderColor = Color.Transparent;
                this.btnEliminarEncargado.OnDisabledState.FillColor = Color.FromArgb(52, 64, 74);

                this.rbDUI.OutlineColorUnchecked = Color.Gainsboro;
                this.rbDUI.RadioColor = Color.FromArgb(70, 199, 188);
                this.rbDUI.OutlineColor = Color.FromArgb(70, 199, 188);
                this.rbDUI.OutlineColorTabFocused = Color.FromArgb(65, 117, 113);
                this.rbDUI.RadioColorTabFocused = Color.FromArgb(65, 117, 113);

                this.rbPasaporte.OutlineColorUnchecked = Color.Gainsboro;
                this.rbPasaporte.RadioColor = Color.FromArgb(70, 199, 188);
                this.rbPasaporte.OutlineColor = Color.FromArgb(70, 199, 188);
                this.rbPasaporte.OutlineColorTabFocused = Color.FromArgb(65, 117, 113);
                this.rbPasaporte.RadioColorTabFocused = Color.FromArgb(65, 117, 113);

                this.dtFechaNacimiento.BackColor = Color.FromArgb(50, 89, 108);
                this.dtFechaNacimiento.ForeColor = Color.WhiteSmoke;
                this.dtFechaNacimiento.IconColor = Color.FromArgb(6, 153, 141);
                this.dtFechaNacimiento.BorderColor = Color.FromArgb(50, 89, 108);

                this.dtFechaNacimiento.DisabledColor = Color.DarkGray;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
