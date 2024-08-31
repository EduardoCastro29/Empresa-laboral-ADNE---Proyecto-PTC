using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO
{
    internal class InicioSesion : Conexion
    {
        //Variables de inicio de sesión para el usuario
        private static int usuarioId = 0;
        private static string usuario = string.Empty;
        private static string contraseña = string.Empty;
        private static string correo = string.Empty;
        //Variables de inicio de sesión para el profesional
        private static string dui = string.Empty;
        private static string nombresApellidos = string.Empty;
        private static string telefono = string.Empty;
        private static string imagen = string.Empty;
        private static string especialidad = string.Empty;
        private static string desempenoId = string.Empty;

        public static int UsuarioId { get => usuarioId; set => usuarioId = value; }
        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Contraseña { get => contraseña; set => contraseña = value; }
        public static string Correo { get => correo; set => correo = value; }
        public static string Dui { get => dui; set => dui = value; }
        public static string NombresApellidos { get => nombresApellidos; set => nombresApellidos = value; }
        public static string Telefono { get => telefono; set => telefono = value; }
        public static string Imagen { get => imagen; set => imagen = value; }
        public static string Especialidad { get => especialidad; set => especialidad = value; }
        public static string DesempenoId { get => desempenoId; set => desempenoId = value; }
    }
}