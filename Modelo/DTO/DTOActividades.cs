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
    internal class DTOActividades : Conexion
    {
        private DateTime FechaInicio;
        private DateTime FechaFinal;
        private int citasAtendidas;
        private int citasPedientes;
        private int citasPerdidas;

        public DateTime FechaInicio1 { get => FechaInicio; set => FechaInicio = value; }
        public DateTime FechaFinal1 { get => FechaFinal; set => FechaFinal = value; }
        public int CitasAtendidas { get => citasAtendidas; set => citasAtendidas = value; }
        public int CitasPedientes { get => citasPedientes; set => citasPedientes = value; }
        public int CitasPerdidas { get => citasPerdidas; set => citasPerdidas = value; }
    }
}