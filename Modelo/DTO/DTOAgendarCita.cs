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
    internal class DTOAgendarCita : Conexion
    {
        private int consultaId;
        private string descripcion;
        private int citaId;
        private DateTime fecha;
        private TimeSpan horaInicio;
        private TimeSpan horaFinal;
        private int estadoId;
        private int pacienteId;
        private int profesionalId;
        private int lugarId;

        public int ConsultaId { get => consultaId; set => consultaId = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CitaId { get => citaId; set => citaId = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFinal { get => horaFinal; set => horaFinal = value; }
        public int EstadoId { get => estadoId; set => estadoId = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
        public int ProfesionalId { get => profesionalId; set => profesionalId = value; }
        public int LugarId { get => lugarId; set => lugarId = value; }
    }
}