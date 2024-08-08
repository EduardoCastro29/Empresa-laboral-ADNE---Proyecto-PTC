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
        }
        private void CargarDatosUsuario(object sender, EventArgs e)
        {
            ObjConfiguracionForm.lblRolUsuario.Text = InicioSesion.Especialidad;
            ObjConfiguracionForm.lblNomprePersona.Text = InicioSesion.NombresApellidos;
            ObjConfiguracionForm.lblCorreoUsuario.Text = InicioSesion.Correo;
            ObjConfiguracionForm.lblUsuario.Text = InicioSesion.Usuario;
            ObjConfiguracionForm.lblDUI.Text = InicioSesion.Dui;
            ObjConfiguracionForm.picUsuario.Image = Image.FromFile(InicioSesion.Imagen);
        }
    }
}