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
using System.IO;
using System.Windows.Media.TextFormatting;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLConfiguracion
    {
        readonly ConfiguraciónForm ObjConfiguracionForm;
        public CTRLConfiguracion(ConfiguraciónForm Vista)
        {
            ObjConfiguracionForm = Vista;

            ObjConfiguracionForm.Load += new EventHandler(CargarDatosUsuario);

            ObjConfiguracionForm.btnActualizarPerfil.Click += new EventHandler(AbrirActualizarUsuario);
            ObjConfiguracionForm.btnCerrarSesion.Click += new EventHandler(CerrarSesionConfig);
            ObjConfiguracionForm.btnAgregarConfiguracion.Click += new EventHandler(AbrirConfiguracionServidor);
            ObjConfiguracionForm.switchModo.CheckedChanged += new EventHandler(modoOscuro);
        }
        #region Eventos iniciales al cargar el Formulario
        private void CargarDatosUsuario(object sender, EventArgs e)
        {
            //Indicamos dado la variable de Inicio de Sesión qué botones son los que se accionarán dado el nivel de Usuario
            switch (InicioSesion.DesempenoId)
            {
                case "Administrador":
                    break;
                case "Empleado":
                    ObjConfiguracionForm.btnAgregarConfiguracion.Enabled = false;
                    break;
                default:
                    break;
            }

            ObjConfiguracionForm.lblRolUsuario.Text = InicioSesion.Especialidad;
            ObjConfiguracionForm.lblNomprePersona.Text = InicioSesion.Nombres + " " + InicioSesion.Apellidos;
            ObjConfiguracionForm.lblCorreo.Text = InicioSesion.Correo;
            ObjConfiguracionForm.lblUsuario.Text = InicioSesion.Usuario;
            ObjConfiguracionForm.lblDUI.Text = InicioSesion.Dui;

            //Convertimos la Imagen en un archivo de memoria
            MemoryStream ObjArchivoMemoriaIMG = new MemoryStream(InicioSesion.Imagen);
            ObjConfiguracionForm.picUsuario.Image = Image.FromStream(ObjArchivoMemoriaIMG);
        }
        #endregion
        #region Abrir el formulario de Actualizar Perfil dentro del Formulario de configuración (UPDATE)
        private void AbrirActualizarUsuario(object sender, EventArgs e)
        {
            //Abrimos el formulario de Actualización del usuario
            ConfiguraciónDeUsuarioForm ObjAbrirFormularioAC = new ConfiguraciónDeUsuarioForm();
            ObjAbrirFormularioAC.ShowDialog();
        }
        #endregion
        #region Abrir el formulario de conexión de servidor dentro de Configuración (SQL Server)
        //Este es el método común cargando todas las variables de conexión dentro del fomulario de agregar conexión
        private void AbrirConfiguracionServidor(object sender, EventArgs e)
        {
            //Instanciamos a al formulario de conexión
            AgregarConexionForm ObjAbrirFMRConexion = new AgregarConexionForm();
            ObjAbrirFMRConexion.txtServidorURL.Text = DTOAgregarConexion.Server;
            ObjAbrirFMRConexion.txtBaseDeDatos.Text = DTOAgregarConexion.Database;
            ObjAbrirFMRConexion.txtAutenticacion.Text = DTOAgregarConexion.User;
            ObjAbrirFMRConexion.txtContrasena.Text = DTOAgregarConexion.Password;

            //Abrimos el formulario
            ObjAbrirFMRConexion.ShowDialog();
        }
        #endregion
        #region Método para cerrar sesión accionando el botón dentro de configuración
        private void CerrarSesionConfig(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión automáticamente? Considere que al accionase, el programa cerrará consecuentemente", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        #endregion
        //Creamos el método para instanciar la lectura del archivo ini desde la clase Config.cs
        private void modoOscuro(object sender, EventArgs e)
        {
            Config objConfig = new Config();
            if (ObjConfiguracionForm.switchModo.Checked == true)
            {
                objConfig.EscribirIni("SECTION", "key", "dark");
                ObjConfiguracionForm.BackColor = Color.FromArgb(30, 92, 98);
            }
            else
            {
                objConfig.EscribirIni("SECTION", "key", "light");
                ObjConfiguracionForm.BackColor = Color.FromArgb(14, 143, 156);
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