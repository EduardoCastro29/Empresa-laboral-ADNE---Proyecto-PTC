using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOSistemaSoporte : DAOEnviarMails
    {
        public DAOSistemaSoporte()
        {
            //Declaramos los valores del Getter y Setter a los del correo remitente (de dónde se enviará el correo electrónico)
            EnviarMail = "adnekids2024@gmail.com";
            Contraseña = "icfa dxgm kzsx xksw";
            ServidorHost = "smtp.gmail.com";
            Puerto = 587;
            SistemSSL = true;
            InicializarSmtpClient();
        }
        //public string ObtenerCorreoRemitente()
        //{
        //    return "adnekids2024@gmail.com";
        //}
    }
}