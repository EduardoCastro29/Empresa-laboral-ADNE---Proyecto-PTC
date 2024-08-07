using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    //Este es el controlador que contendrá la respuesta y acción al enviar el correo electrónico al usuario solicitante
    internal class CTRLDireccionGmail
    {
        //Creamos un objeto del formulario DireccionGmail, para poder acceder a todos los controles correspondientes del formulario
        readonly DirecciónGmailForm ObjDireccionGmailForm;

        //Creamos el constructor del controlador
        public CTRLDireccionGmail(DirecciónGmailForm Vista)
        {
            //Enlazamos el objeto del formulario con la vista
            ObjDireccionGmailForm = Vista;

            //Declaramos el evento Click al boton de AceptarGmail
            //Este botón sera el que nos indique si el envío de Gmail fue existoso o erroneo
            //Que posteriormente, ejecutará un método
            ObjDireccionGmailForm.btnAceptarGmail.Click += new EventHandler(SolicitudRecuperarContrasena);
            ObjDireccionGmailForm.btnSiguiente.Click += new EventHandler(VerificacionPingForm);
            ObjDireccionGmailForm.btnCancelar.Click += new EventHandler(RegresarLoginForm);

        }
        private void SolicitudRecuperarContrasena(object sender, EventArgs e)
        {
            //Creamos una instancia de la clase DAOLogin donde se alojará la respuesta al Usuario Solicitante
            DAODireccionGmail ObjMensajeRecuperarContrasena = new DAODireccionGmail();

            //Declaramos una variable de tipo string que tomará todos los datos del método UsuarioSolicitante de la clase DAOLogin
            //Y como parámetros el textbox donde el usuario ingresará el correo electrónico o usuario para el método de recuperarción
            string respuestaUsuarioSolicitante = ObjMensajeRecuperarContrasena.UsuarioSolicitante(ObjDireccionGmailForm.txtIngresarEmail.Text);
            //Evaluamos la respuesta del correo solicitante en un texto label, el cuál proporcionara una respuesta directa al usuario
            //Dentro del formulario, de esta forma se podrá saber con mayor certeza si realmente se ha enviado el correo o no
            ObjDireccionGmailForm.lblConfirmacion.Text = respuestaUsuarioSolicitante;
        }
        private void VerificacionPingForm(object sender, EventArgs e)
        {
            DAODireccionGmail ObjVerificarPing = new DAODireccionGmail();

            if (string.IsNullOrWhiteSpace(ObjDireccionGmailForm.txtIngresarEmail.Text) ||
                ObjVerificarPing.VerificarCorreoUsuario(ObjDireccionGmailForm.txtIngresarEmail.Text) == null)
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario/dirección de correo válida antes de seguir.", "Recuperación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PindeAccesoForm ObjFormularioPinAcceso = new PindeAccesoForm();
                ObjDireccionGmailForm.Hide();
                ObjFormularioPinAcceso.Show();
            }
        }
        private void RegresarLoginForm(object sender, EventArgs e)
        {
            LoginForm ObjMostrarLogin = new LoginForm();
            ObjDireccionGmailForm.Hide();
            ObjMostrarLogin.Show();
        }
    }
}