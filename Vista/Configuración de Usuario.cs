using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Properties;
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
    public partial class ConfiguraciónDeUsuarioForm : Form
    {
        public ConfiguraciónDeUsuarioForm()
        {
            InitializeComponent();
            leerIni();
            CTRLConfiguracionUsuario ObjControladorUsuarioACT = new CTRLConfiguracionUsuario(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(28, 104, 108);

                this.bunifuGradientPanel3.GradientTopLeft = Color.FromArgb(41, 118, 131);
                this.bunifuGradientPanel3.GradientBottomLeft = Color.FromArgb(40, 120, 129);
                this.bunifuGradientPanel3.GradientTopRight = Color.FromArgb(43, 122, 133);
                this.bunifuGradientPanel3.GradientBottomRight = Color.FromArgb(45, 124, 133);

                this.Titulo_Registrar.ForeColor = Color.FromArgb(28, 71, 84);

                this.bunifuGradientPanel1.GradientTopLeft = Color.FromArgb(30, 58, 69);
                this.bunifuGradientPanel1.GradientTopRight = Color.FromArgb(22, 57, 66);
                this.bunifuGradientPanel1.GradientBottomLeft = Color.FromArgb(29, 57, 61);
                this.bunifuGradientPanel1.GradientBottomRight = Color.FromArgb(21, 53, 61);

                this.picProfesional.Image = Resources.Registro_Modo_Oscuro;

                this.lblNombres.ForeColor = Color.White;
                this.lblApellidos.ForeColor = Color.White;
                this.lblDocumento.ForeColor = Color.White;
                this.lblUsuario.ForeColor = Color.White;
                this.lblTelefono.ForeColor = Color.White;
                this.lblCorreo.ForeColor = Color.White;

                this.txtNombre.FillColor = Color.FromArgb(50, 89, 108);
                this.txtNombre.ForeColor = Color.WhiteSmoke;
                this.txtNombre.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtApellido.FillColor = Color.FromArgb(50, 89, 108);
                this.txtApellido.ForeColor = Color.WhiteSmoke;
                this.txtApellido.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtDui.FillColor = Color.FromArgb(50, 89, 108);
                this.txtDui.ForeColor = Color.WhiteSmoke;
                this.txtDui.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtUsuario.FillColor = Color.FromArgb(50, 89, 108);
                this.txtUsuario.ForeColor = Color.WhiteSmoke;
                this.txtUsuario.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtTelefono.FillColor = Color.FromArgb(50, 89, 108);
                this.txtTelefono.ForeColor = Color.WhiteSmoke;
                this.txtTelefono.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtCorreo.FillColor = Color.FromArgb(50, 89, 108);
                this.txtCorreo.ForeColor = Color.WhiteSmoke;
                this.txtCorreo.PlaceholderForeColor = Color.WhiteSmoke;

                this.txtNombre.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtNombre.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtNombre.OnDisabledState.BorderColor = Color.Transparent;
                this.txtNombre.BorderColorDisabled = Color.Transparent;

                this.txtApellido.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtApellido.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtApellido.OnDisabledState.BorderColor = Color.Transparent;
                this.txtApellido.BorderColorDisabled = Color.Transparent;

                this.txtDui.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtDui.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtDui.OnDisabledState.BorderColor = Color.Transparent;
                this.txtDui.BorderColorDisabled = Color.Transparent;

                this.txtUsuario.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtUsuario.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtUsuario.OnDisabledState.BorderColor = Color.Transparent;
                this.txtUsuario.BorderColorDisabled = Color.Transparent;

                this.txtTelefono.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtTelefono.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtTelefono.OnDisabledState.BorderColor = Color.Transparent;
                this.txtTelefono.BorderColorDisabled = Color.Transparent;

                this.txtCorreo.OnDisabledState.ForeColor = Color.Gainsboro;
                this.txtCorreo.OnDisabledState.FillColor = Color.FromArgb(41, 67, 79);
                this.txtCorreo.OnDisabledState.BorderColor = Color.Transparent;
                this.txtCorreo.BorderColorDisabled = Color.Transparent;

                this.btnCargarImagen.onHoverState.BorderColor = Color.Teal;
                this.btnCargarImagen.onHoverState.FillColor = Color.Teal;
                this.btnCargarImagen.IdleBorderColor = Color.FromArgb(0, 110, 110);
                this.btnCargarImagen.IdleFillColor = Color.FromArgb(0, 110, 110);
                this.btnCargarImagen.OnPressedState.BorderColor = Color.FromArgb(0, 90, 90);
                this.btnCargarImagen.OnPressedState.FillColor = Color.FromArgb(0, 90, 90);
                this.btnCargarImagen.OnDisabledState.BorderColor = Color.FromArgb(61, 87, 87);
                this.btnCargarImagen.OnDisabledState.FillColor = Color.FromArgb(61, 87, 87);

                this.btnEliminar.onHoverState.BorderColor = Color.Teal;
                this.btnEliminar.onHoverState.FillColor = Color.Teal;
                this.btnEliminar.IdleBorderColor = Color.FromArgb(0, 110, 110);
                this.btnEliminar.IdleFillColor = Color.FromArgb(0, 110, 110);
                this.btnEliminar.OnPressedState.BorderColor = Color.FromArgb(0, 90, 90);
                this.btnEliminar.OnPressedState.FillColor = Color.FromArgb(0, 90, 90);
                this.btnEliminar.OnDisabledState.BorderColor = Color.FromArgb(61, 87, 87);
                this.btnEliminar.OnDisabledState.FillColor = Color.FromArgb(61, 87, 87);

                this.btnGuardar.onHoverState.BorderColor = Color.Teal;
                this.btnGuardar.onHoverState.FillColor = Color.Teal;
                this.btnGuardar.IdleBorderColor = Color.FromArgb(0, 110, 110);
                this.btnGuardar.IdleFillColor = Color.FromArgb(0, 110, 110);
                this.btnGuardar.OnPressedState.BorderColor = Color.FromArgb(0, 90, 90);
                this.btnGuardar.OnPressedState.FillColor = Color.FromArgb(0, 90, 90);
                this.btnGuardar.OnDisabledState.BorderColor = Color.FromArgb(61, 87, 87);
                this.btnGuardar.OnDisabledState.FillColor = Color.FromArgb(61, 87, 87);

                this.bunifuPanel1.BorderColor = Color.FromArgb(79, 106, 117);
            }
        }
    }
}
