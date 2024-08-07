using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO
{
    internal class DTOEnviarMails : Conexion
    {
        //Getters y setters de envío EMAIL
        private string enviarMail;
        private string contraseña;
        private string servidorHost;
        private int puerto;
        private bool sistemSSL;
        public string EnviarMail { get => enviarMail; set => enviarMail = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string ServidorHost { get => servidorHost; set => servidorHost = value; }
        public int Puerto { get => puerto; set => puerto = value; }
        public bool SistemSSL { get => sistemSSL; set => sistemSSL = value; }
    }
}