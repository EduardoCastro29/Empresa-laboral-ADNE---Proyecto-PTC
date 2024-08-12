using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO
{
    internal class DTOAdministrador : Conexion
    {
        //Getter y setter
        private string nombres;
        private string apellidos;
        private string dui;
        private int usuarioId;
        private string usuario;
        private string telefono;
        private string contraseña;
        private string correo;
        private int especialidad;
        private int especialidadAlt;
        private int desempenoId;
        private int profesionalId;
        private int pinAcceso;
        private string imagen;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dui { get => dui; set => dui = value; }
        public int UsuarioId { get => usuarioId; set => usuarioId = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Especialidad { get => especialidad; set => especialidad = value; }
        public int EspecialidadAlt { get => especialidadAlt; set => especialidadAlt = value; }
        public int DesempenoId { get => desempenoId; set => desempenoId = value; }
        public int ProfesionalId { get => profesionalId; set => profesionalId = value; }
        public int PinAcceso { get => pinAcceso; set => pinAcceso = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}
