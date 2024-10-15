using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class RegistroForm : Form
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
        public RegistroForm()
        {
            DAOLogin ObjVerificarEmpleadosUsuario = new DAOLogin();

            InitializeComponent();
            leerIni();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //Si no hay empleados ni usuarios registrados, se acciona el controlador de primer uso
            if (ObjVerificarEmpleadosUsuario.VerificarUsuario() == false)
            {
                CTRLRegistro ObjRegistroControlador = new CTRLRegistro(this);
            }
            else
            {
                //Caso contrario, se acciona el controlador del administrador
                CTRLAdministrador ObjRegistroControlador = new CTRLAdministrador(this);
            }
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
                this.lblDesempeno1.ForeColor = Color.White;

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

                this.cmbDesempeno.ItemHighLightColor = Color.FromArgb(22, 121, 130);
                this.cmbDesempeno.ItemBackColor = Color.FromArgb(21, 48, 54);
                this.cmbDesempeno.ItemForeColor = Color.WhiteSmoke;
                this.cmbDesempeno.ForeColor = Color.WhiteSmoke;
                this.cmbDesempeno.BackgroundColor = Color.FromArgb(50, 89, 108);
                this.cmbDesempeno.BorderColor = Color.Transparent;
                this.cmbDesempeno.IndicatorColor = Color.FromArgb(6, 153, 141);

                this.cmbDesempeno.DisabledBackColor = Color.FromArgb(41, 67, 79);
                this.cmbDesempeno.DisabledIndicatorColor = Color.FromArgb(38, 113, 130);
                this.cmbDesempeno.DisabledBorderColor = Color.Transparent;
                this.cmbDesempeno.DisabledForeColor = Color.WhiteSmoke;

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

                this.btnRegistrar.onHoverState.BorderColor = Color.FromArgb(24, 136, 143);
                this.btnRegistrar.onHoverState.FillColor = Color.FromArgb(24, 136, 143);
                this.btnRegistrar.IdleFillColor = Color.FromArgb(42, 125, 130);
                this.btnRegistrar.IdleBorderColor = Color.FromArgb(42, 125, 130);
                this.btnRegistrar.OnPressedState.BorderColor = Color.FromArgb(29, 86, 89);
                this.btnRegistrar.OnPressedState.FillColor = Color.FromArgb(29, 86, 89);
                this.btnRegistrar.OnDisabledState.BorderColor = Color.FromArgb(63, 76, 77);
                this.btnRegistrar.OnDisabledState.FillColor = Color.FromArgb(63, 76, 77);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DAOLogin ObjVerificarEmpleadosUsuario = new DAOLogin();
            if (ObjVerificarEmpleadosUsuario.VerificarUsuario() == false)
            {
                //Si no hay empleados dentro del formuarlio de registro, la X funcionará para cerrar la ventana y el programa
                Environment.Exit(0);
            }
            else
            {
                //Caso contrario, solo se cerrará, dando a entender que ya hay un administrador ingresado
                this.Close();
            }
        }
    }
}
