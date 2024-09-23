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
    public partial class RegistroEspecialidadesForm : Form
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
        public RegistroEspecialidadesForm()
        {
            InitializeComponent();
            leerIni();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            CTRLRegistroEspecialidad ObjControladorREspecialidad = new CTRLRegistroEspecialidad(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(31, 69, 73);

                this.bunifuGradientPanel3.GradientTopLeft = Color.FromArgb(41, 118, 131);
                this.bunifuGradientPanel3.GradientBottomLeft = Color.FromArgb(40, 120, 129);
                this.bunifuGradientPanel3.GradientTopRight = Color.FromArgb(43, 122, 133);
                this.bunifuGradientPanel3.GradientBottomRight = Color.FromArgb(45, 124, 133);

                this.Titulo_Registrar.ForeColor = Color.FromArgb(28, 71, 84);

                this.lblAnadirEspecialidad.ForeColor = Color.White;
                this.lblNombreProfesional.ForeColor = Color.White;

                this.cmbEspecialidades.ItemHighLightColor = Color.FromArgb(22, 121, 130);
                this.cmbEspecialidades.ItemBackColor = Color.FromArgb(21, 48, 54);
                this.cmbEspecialidades.ItemForeColor = Color.WhiteSmoke;
                this.cmbEspecialidades.ForeColor = Color.WhiteSmoke;
                this.cmbEspecialidades.BackgroundColor = Color.FromArgb(50, 89, 108);
                this.cmbEspecialidades.BorderColor = Color.Transparent;
                this.cmbEspecialidades.IndicatorColor = Color.FromArgb(6, 153, 141);

                this.cmbEspecialidades.DisabledBackColor = Color.FromArgb(41, 67, 79);
                this.cmbEspecialidades.DisabledIndicatorColor = Color.FromArgb(38, 113, 130);
                this.cmbEspecialidades.DisabledBorderColor = Color.Transparent;
                this.cmbEspecialidades.DisabledForeColor = Color.WhiteSmoke;

                this.btnAnadirEspecialidad.onHoverState.BorderColor = Color.FromArgb(24, 136, 143);
                this.btnAnadirEspecialidad.onHoverState.FillColor = Color.FromArgb(24, 136, 143);
                this.btnAnadirEspecialidad.IdleFillColor = Color.FromArgb(42, 125, 130);
                this.btnAnadirEspecialidad.IdleBorderColor = Color.FromArgb(42, 125, 130);
                this.btnAnadirEspecialidad.OnPressedState.BorderColor = Color.FromArgb(29, 86, 89);
                this.btnAnadirEspecialidad.OnPressedState.FillColor = Color.FromArgb(29, 86, 89);
                this.btnAnadirEspecialidad.OnDisabledState.BorderColor = Color.FromArgb(63, 76, 77);
                this.btnAnadirEspecialidad.OnDisabledState.FillColor = Color.FromArgb(63, 76, 77);

                this.btnEliminarEspecialidad.onHoverState.BorderColor = Color.Teal;
                this.btnEliminarEspecialidad.onHoverState.FillColor = Color.Teal;
                this.btnEliminarEspecialidad.IdleBorderColor = Color.FromArgb(0, 110, 110);
                this.btnEliminarEspecialidad.IdleFillColor = Color.FromArgb(0, 110, 110);
                this.btnEliminarEspecialidad.OnPressedState.BorderColor = Color.FromArgb(0, 90, 90);
                this.btnEliminarEspecialidad.OnPressedState.FillColor = Color.FromArgb(0, 90, 90);
                this.btnEliminarEspecialidad.OnDisabledState.BorderColor = Color.FromArgb(61, 87, 87);
                this.btnEliminarEspecialidad.OnDisabledState.FillColor = Color.FromArgb(61, 87, 87);

                this.btnSiguiente.onHoverState.BorderColor = Color.FromArgb(24, 136, 143);
                this.btnSiguiente.onHoverState.FillColor = Color.FromArgb(24, 136, 143);
                this.btnSiguiente.IdleFillColor = Color.FromArgb(42, 125, 130);
                this.btnSiguiente.IdleBorderColor = Color.FromArgb(42, 125, 130);
                this.btnSiguiente.OnPressedState.BorderColor = Color.FromArgb(29, 86, 89);
                this.btnSiguiente.OnPressedState.FillColor = Color.FromArgb(29, 86, 89);
                this.btnSiguiente.OnDisabledState.BorderColor = Color.FromArgb(63, 76, 77);
                this.btnSiguiente.OnDisabledState.FillColor = Color.FromArgb(63, 76, 77);
            }
        }
    }
}
