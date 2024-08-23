using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
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
        private void btnSalir_Click(object sender, EventArgs e)
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
