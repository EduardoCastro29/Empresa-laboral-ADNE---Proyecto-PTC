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
    internal class DTOVerPacientes : Conexion
    {
        private string nombreApellido;
        private int pacienteId;

        public string NombreApellido { get => nombreApellido; set => nombreApellido = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
    }
}