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
        private int desempenoId;
        private byte[] imagen;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dui { get => dui; set => dui = value; }
        public int UsuarioId { get => usuarioId; set => usuarioId = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Correo { get => correo; set => correo = value; }
        public int DesempenoId { get => desempenoId; set => desempenoId = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
    }
}