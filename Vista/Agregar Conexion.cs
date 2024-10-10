using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
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
    public partial class AgregarConexionForm : Form
    {
        public AgregarConexionForm()
        {
            InitializeComponent();
            leerIni();
            CTRLAgregarConexion ObjCTRLConexion = new CTRLAgregarConexion(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(28, 104, 108);

                this.pnlAutenticacion.BackgroundColor = Color.FromArgb(150, 34, 120, 128);
                this.bunifuPanel1.BackgroundColor = Color.FromArgb(150, 34, 120, 128);
                this.bunifuPanel2.BackgroundColor = Color.FromArgb(150, 34, 120, 128);
                //this.pnlForms.GradientTopRight = Color.FromArgb(34, 120, 128);
                //this.pnlForms.GradientBottomLeft = Color.FromArgb(45, 137, 145);

                this.lblBaseDeDatos.ForeColor = Color.White;
                this.lblServidorURL.ForeColor = Color.White;
                this.bunifuLabel1.ForeColor = Color.White;
                this.bunifuLabel2.ForeColor = Color.White;
                this.bunifuLabel3.ForeColor = Color.White;
                this.bunifuLabel4.ForeColor = Color.White;
                this.bunifuLabel5.ForeColor = Color.White;
                this.bunifuLabel6.ForeColor = Color.White;

                this.txtServidorURL.FillColor = Color.FromArgb(50, 89, 108);
                this.txtServidorURL.ForeColor = Color.WhiteSmoke;
                this.txtServidorURL.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtBaseDeDatos.FillColor = Color.FromArgb(50, 89, 108);
                this.txtBaseDeDatos.ForeColor = Color.WhiteSmoke;
                this.txtBaseDeDatos.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtAutenticacion.FillColor = Color.FromArgb(50, 89, 108);
                this.txtAutenticacion.ForeColor = Color.WhiteSmoke;
                this.txtAutenticacion.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtContrasena.FillColor = Color.FromArgb(50, 89, 108);
                this.txtContrasena.ForeColor = Color.WhiteSmoke;
                this.txtContrasena.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtServidorURL.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtServidorURL.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtServidorURL.OnDisabledState.BorderColor = Color.Transparent;
                this.txtServidorURL.BorderColorDisabled = Color.Transparent;

                this.txtBaseDeDatos.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtBaseDeDatos.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtBaseDeDatos.OnDisabledState.BorderColor = Color.Transparent;
                this.txtBaseDeDatos.BorderColorDisabled = Color.Transparent;

                this.txtAutenticacion.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtAutenticacion.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtAutenticacion.OnDisabledState.BorderColor = Color.Transparent;
                this.txtAutenticacion.BorderColorDisabled = Color.Transparent;

                this.txtContrasena.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtContrasena.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtContrasena.OnDisabledState.BorderColor = Color.Transparent;
                this.txtContrasena.BorderColorDisabled = Color.Transparent;

                this.rbDesabilitar.OutlineColorUnchecked = Color.Gainsboro;
                this.rbDesabilitar.RadioColor = Color.FromArgb(70, 199, 188);
                this.rbDesabilitar.OutlineColor = Color.FromArgb(70, 199, 188);
                this.rbDesabilitar.OutlineColorTabFocused = Color.FromArgb(65, 117, 113);
                this.rbDesabilitar.RadioColorTabFocused = Color.FromArgb(65, 117, 113);

                this.rbHabilitar.OutlineColorUnchecked = Color.Gainsboro;
                this.rbHabilitar.RadioColor = Color.FromArgb(70, 199, 188);
                this.rbHabilitar.OutlineColor = Color.FromArgb(70, 199, 188);
                this.rbHabilitar.OutlineColorTabFocused = Color.FromArgb(65, 117, 113);
                this.rbHabilitar.RadioColorTabFocused = Color.FromArgb(65, 117, 113);

                this.btnGuardar.onHoverState.BorderColor = Color.FromArgb(2, 166, 166);
                this.btnGuardar.onHoverState.FillColor = Color.FromArgb(2, 166, 166);
                this.btnGuardar.IdleBorderColor = Color.Teal;
                this.btnGuardar.IdleFillColor = Color.Teal;
                this.btnGuardar.OnPressedState.BorderColor = Color.FromArgb(1, 82, 82);
                this.btnGuardar.OnPressedState.FillColor = Color.FromArgb(1, 82, 82);
                this.btnGuardar.OnDisabledState.BorderColor = Color.FromArgb(61, 87, 87);
                this.btnGuardar.OnDisabledState.FillColor = Color.FromArgb(61, 87, 87);
            }
        }
    }
}
