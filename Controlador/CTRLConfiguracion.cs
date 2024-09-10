using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using System.Drawing;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLConfiguracion
    {
        readonly ConfiguraciónForm ObjConfiguracionForm;

        public CTRLConfiguracion(ConfiguraciónForm Vista)
        {
            ObjConfiguracionForm = Vista;

            ObjConfiguracionForm.Load += new EventHandler(CargarDatosUsuario);
            ObjConfiguracionForm.btnCerrarSesion.Click += new EventHandler(CerrarSesionConfig);
        }
        private void CargarDatosUsuario(object sender, EventArgs e)
        {
            ObjConfiguracionForm.lblRolUsuario.Text = InicioSesion.Especialidad;
            ObjConfiguracionForm.lblNomprePersona.Text = InicioSesion.NombresApellidos;
            ObjConfiguracionForm.lblCorreo.Text = InicioSesion.Correo;
            ObjConfiguracionForm.lblUsuario.Text = InicioSesion.Usuario;
            ObjConfiguracionForm.lblDUI.Text = InicioSesion.Dui;
            ObjConfiguracionForm.picUsuario.Image = Image.FromFile(InicioSesion.Imagen);
        }
        private void CerrarSesionConfig(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión automáticamente? Considere que al accionase, el programa cerrará consecuentemente", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //private void LimpiarVariablesInicioSesion()
        //{
        //    InicioSesion.UsuarioId = 0;
        //    InicioSesion.Usuario = string.Empty;
        //    InicioSesion.Contraseña = string.Empty;
        //    InicioSesion.Correo = string.Empty;
        //    InicioSesion.Dui = string.Empty;
        //    InicioSesion.NombresApellidos = string.Empty;
        //    InicioSesion.Telefono = string.Empty;
        //    InicioSesion.Imagen = string.Empty;
        //    InicioSesion.Especialidad = string.Empty;
        //    InicioSesion.DesempenoId = string.Empty;
        //}
    }
}