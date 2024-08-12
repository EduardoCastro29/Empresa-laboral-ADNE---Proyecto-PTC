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
    internal class DTOEquipoTrabajo : Conexion
    {
        private int profesionalId;
        private string correo;
        private string nombresApellidos;
        private string especialidad;
        private string especialidadAlt;

        public int ProfesionalId { get => profesionalId; set => profesionalId = value; }
        public string Correo { get => correo; set => correo = value; }
        public string NombresApellidos { get => nombresApellidos; set => nombresApellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string EspecialidadAlt { get => especialidadAlt; set => especialidadAlt = value; }
    }
}