﻿using System;
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
using System.Security.Cryptography;
using System.IO;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLDashboard
    {
        readonly DashboardForm ObjDashboard;

        //Creamos un objeto de un Formulario no específico, esto ya que a la hora de pasar el formulario a los paneles
        Form FormActual;
        public CTRLDashboard(DashboardForm View)
        {
            //Declaramos que el objeto Dashboard creado anteriormente será igual a la carpeta Vista para obtener los valores
            ObjDashboard = View;
            //Creamos el evento Load, el cuál indica que al momento de cargar el formulario
            //Se generara un formulario en específico dentro del panel
            ObjDashboard.Load += new EventHandler(FormularioPredeterminado);
            ObjDashboard.Load += new EventHandler(DatosUsuarioLogin);
            ObjDashboard.FormClosing += new FormClosingEventHandler(CerrarPrograma);
            ObjDashboard.btnCerrarS.Click += new EventHandler(CerrarSesion);

            ObjDashboard.btnMainPage.Click += new EventHandler(FormularioPaginaPrincipal);
            ObjDashboard.btnPacientes.Click += new EventHandler(FormularioPacientes);
            ObjDashboard.btnCitas.Click += new EventHandler(FormularioCitas);
            ObjDashboard.btnEquipo.Click += new EventHandler(FormularioEquipoTrabajo);
            ObjDashboard.btnCalendario.Click += new EventHandler(FormularioCalendario);
            ObjDashboard.btnConfig.Click += new EventHandler(FormularioConfiguracion);
        }
        private void DatosUsuarioLogin(object sender, EventArgs e)
        {
            //Indicamos los valores que se pondrán dentro del inicio de sesión del usuario
            ObjDashboard.lblUsuario.Text = InicioSesion.Usuario;
            ObjDashboard.lblIdUsuario.Text = InicioSesion.DesempenoId;

            //Convertimos la Imagen en un archivo de memoria
            MemoryStream ObjArchivoMemoriaIMG = new MemoryStream(InicioSesion.Imagen);
            ObjDashboard.picUsuario.Image = Image.FromStream(ObjArchivoMemoriaIMG);
        }
        private void CerrarPrograma(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void CerrarSesion(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarVariablesInicioSesion();
                LoginForm ObjVolverInicioLogin = new LoginForm();
                ObjVolverInicioLogin.Show();
                ObjDashboard.Dispose();
            }
        }
        void LimpiarVariablesInicioSesion()
        {
            InicioSesion.UsuarioId = 0;
            InicioSesion.Usuario = string.Empty;
            InicioSesion.Contraseña = string.Empty;
            InicioSesion.Correo = string.Empty;
            InicioSesion.Dui = string.Empty;
            InicioSesion.Nombres = string.Empty;
            InicioSesion.Apellidos = string.Empty;
            InicioSesion.Telefono = string.Empty;
            InicioSesion.Imagen = null;
            InicioSesion.Especialidad = string.Empty;
            InicioSesion.DesempenoId = string.Empty;
        }
        //Creamos la cadena de Eventos haciendo referencia a los menus que se tiene al entrar en la aplicación
        private void FormularioPredeterminado(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Actividades, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<ActividadesForm>();
        }
        private void FormularioPaginaPrincipal(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Actividades, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<ActividadesForm>();
        }
        private void FormularioPacientes(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Pacientes, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<PacientesForm>();
        }
        private void FormularioCitas(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Pacientes, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<CitasForm>();
        }
        private void FormularioEquipoTrabajo(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Equipo de Trabajo, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<EquipodeTrabajoForm>();
        }
        private void FormularioCalendario(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Calendario, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<CalendarioForm>();
        }
        private void FormularioConfiguracion(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Información Personal, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<ConfiguraciónForm>();
        }
        //Este método es común para abrir formularios dentro de los paneles
        //El método AbrirFormulario llama por su nombre Formulario donde el Formulario hereda un Forms de Windows Forms, y lo crea
        private void AbrirFormulario<Formulario>() where Formulario : Form, new()
        {
            //Creamos un objeto de tipo Forms que heredara el nuevo Formulario
            Form nuevoFormulario;
            //Se guardan los datos en el panelGeneralVistas que hereda el objeto nuevoFormulario que abrira el Formulario
            nuevoFormulario = ObjDashboard.panelGeneralVistas.Controls.OfType<Formulario>().FirstOrDefault();
            //Si el objeto nuevoFormulario no llegase a existir, se crea uno nuevo
            if (nuevoFormulario == null)
            {
                //Se declara un uevo formulario que tendra como instancia <Formulario>
                nuevoFormulario = new Formulario();
                //Especificamos que el formulario deberá abrirse como ventana
                //Evitando los marcos de WindowsForms
                nuevoFormulario.TopLevel = false;
                nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
                //Declaramos que utilizará todo el espacio del Panel
                nuevoFormulario.Dock = DockStyle.Fill;
                //Evaluamos si el FormularioActual es nulo, en caso de serlo, se ejecuta el siguiente código
                if (FormActual != null)
                {
                    //Se cierra el formulario actual para mostrar el nuevo formulario
                    FormActual.Close();
                    //Se eliminan todos los controles del FormularioActual dentro del panel
                    ObjDashboard.panelGeneralVistas.Controls.Remove(FormActual);
                }
                //Establecemos que el FormularioActual es igual al nuevo formulario creado
                FormActual = nuevoFormulario;
                //Se agregan los controles que fueron previamente puestos en el nuevoFormulario dentro del Panel
                ObjDashboard.panelGeneralVistas.Controls.Add(nuevoFormulario);
                ObjDashboard.panelGeneralVistas.Tag = nuevoFormulario;
                nuevoFormulario.Show();
                nuevoFormulario.BringToFront();
            }
            else
            {
                //En caso de no haberse ejecutado el código, se trae al frente un formulario nulo
                nuevoFormulario.BringToFront();
            }
        }
    }
}