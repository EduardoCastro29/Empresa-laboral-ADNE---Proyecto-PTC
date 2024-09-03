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

        //Creamos una variable de tipo estática, que nos capturará el Usuario o Correo solicitante
        //Cuando el usuario ingrese las credenciales correspondientes al recuperar la contraseña
        public static string CorreoUsuarioSLC;

        //Creamos el constructor del controlador
        public CTRLDireccionGmail(DirecciónGmailForm Vista)
        {
            //Enlazamos el objeto del formulario con la vista
            ObjDireccionGmailForm = Vista;

            //Declaramos el evento Click al boton de AceptarGmail
            //Este botón sera el que nos indique si el envío de Gmail fue existoso o erroneo
            //Que posteriormente, ejecutará un método
            ObjDireccionGmailForm.btnAceptarGmail.Click += new EventHandler(SolicitudRecuperarContrasena);
            ObjDireccionGmailForm.btnSiguiente.Click += new EventHandler(VerificacionCorreoUsuario);
            ObjDireccionGmailForm.btnCancelar.Click += new EventHandler(RegresarLoginForm);

            //Validaciones de campos
            ObjDireccionGmailForm.txtIngresarEmail.KeyPress += new KeyPressEventHandler(ValidarCampoCorreo);
        }
        #region Validaciones de Campos
        private void ValidarCampoCorreo(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            char ch = e.KeyChar;

            //Declaramos lo valores que únicamente permitirá el textbox
            if ((ch >= '0' && ch <= '9') ||
                (ch >= 'A' && ch <= 'Z') ||
                (ch >= 'a' && ch <= 'z') ||
                 ch == '.' ||
                 ch == '@' ||
                 ch == '_')
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        #endregion
        #region Solicitud de recuperación de contraseña
        private void SolicitudRecuperarContrasena(object sender, EventArgs e)
        {
            //Creamos una instancia de la clase DAOLogin donde se alojará la respuesta al Usuario Solicitante
            DAODireccionGmail ObjMensajeRecuperarContrasena = new DAODireccionGmail();

            //Declaramos una variable de tipo string que tomará todos los datos del método UsuarioSolicitante de la clase DAOLogin
            //Y como parámetros el textbox donde el usuario ingresará el correo electrónico o usuario para el método de recuperarción
            //De la misma manera, envíamos la variable estática y la igualamos hacia el textbox el cuál envía el Ping de Acceso
            string respuestaUsuarioSolicitante = ObjMensajeRecuperarContrasena.UsuarioSolicitante(CorreoUsuarioSLC = ObjDireccionGmailForm.txtIngresarEmail.Text.Trim());
            //Evaluamos la respuesta del correo solicitante en un texto label, el cuál proporcionara una respuesta directa al usuario
            //Dentro del formulario, de esta forma se podrá saber con mayor certeza si realmente se ha enviado el correo o no
            ObjDireccionGmailForm.lblConfirmacion.Text = respuestaUsuarioSolicitante;
        }
        #endregion
        #region Verificación del correo del Usuario (Método de verificación SMTP)
        private void VerificacionCorreoUsuario(object sender, EventArgs e)
        {
            DAODireccionGmail ObjVerificarCorreoUsuario = new DAODireccionGmail();

            if (ObjDireccionGmailForm.txtIngresarEmail.Text.Length < 10 ||
                ObjVerificarCorreoUsuario.VerificarCorreoUsuario(ObjDireccionGmailForm.txtIngresarEmail.Text.Trim()) == null)
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario/dirección de correo válida antes de seguir.", "Recuperación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Si no se desea enviar otro correo al usuario
                //Igualamos la variable estática hacia el textbox para establecer 
                CorreoUsuarioSLC = ObjDireccionGmailForm.txtIngresarEmail.Text;
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
        #endregion
    }
}