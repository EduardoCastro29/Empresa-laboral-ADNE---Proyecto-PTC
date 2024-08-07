using System;
using System.Collections.Generic;
using System.Linq;
//Estos using son para el envío y recuperación de contraseñas, por medio de un EMAIL
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Bunifu.UI.WinForms.BunifuSnackbar;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOEnviarMails : DTOEnviarMails
    {
        //Creamos un objeto de SmtpClient que nos permitira enviar correos por transferencia de protocolo
        public SmtpClient ObjSMTPClient = new SmtpClient();

        //Inicializamos las propiedades de SmtpClient
        protected void InicializarSmtpClient()
        {
            //Enviamos los valores de SmtpClient
            ObjSMTPClient.Credentials = new NetworkCredential(EnviarMail, Contraseña);
            ObjSMTPClient.Host = ServidorHost;
            ObjSMTPClient.Port = Puerto;
            ObjSMTPClient.EnableSsl = SistemSSL;
        }
        //Este método es común para enviar correos electrónicos
        //Declaramos como parámetros el tema del correo, el cuerpo y la dirección
        //La dirección de correo es declarada como lista, de esta forma si se desea enviar múltiples correos registrados en la app
        //Se enviarán de forma automática
        public void EnviarCorreo(string TemaMail, string CuerpoMail, List<string> DirrecionesMail)
        {
            //Creamos una instancia de MailMessage para enviar correos electrónicos
            MailMessage ObjMensajeMail = new MailMessage();
            try
            {
                //Enviamos los parámetros de ObjMensajeMail para una dirección de correo electrónico
                ObjMensajeMail.From = new MailAddress(EnviarMail);

                //El siguiente código podría leerse de la siguiente manera
                //Por cada dirección de correo encontrada, envía un mail a la dirección ingresada
                foreach (string Mail in DirrecionesMail)
                {
                    ObjMensajeMail.To.Add(Mail);
                }

                //Declarando las partes del correo (Tema de correo y el contenido)
                ObjMensajeMail.Subject = TemaMail;
                ObjMensajeMail.Body = CuerpoMail;
                //Declaramos como prioridad normal, de esta forma se envía a recibidos
                ObjMensajeMail.Priority = MailPriority.Normal;
                //Enviando el correo
                ObjSMTPClient.Send(ObjMensajeMail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Finalmente, enviamos el correo con los datos antes ingresadose
                ObjMensajeMail.Dispose();
                ObjSMTPClient.Dispose();
            }
        }
    }
}