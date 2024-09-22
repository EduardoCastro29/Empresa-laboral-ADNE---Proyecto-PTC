using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO
{
    internal class DTOConfiguracionUsuario : Conexion
    {
        //Getters y setters
        private string dUI;
        private string nombres;
        private string apellidos;
        private string usuario;
        private string telefono;
        private string correo;
        private byte[] imagen;

        public string DUI { get => dUI; set => dUI = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
    }
}