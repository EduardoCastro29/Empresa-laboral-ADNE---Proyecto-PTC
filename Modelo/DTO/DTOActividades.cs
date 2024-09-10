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

    public struct revenueByDate
    {
        private string date;
        private int totalCitas;

        public string Date { get => date; set => date = value; }
        public int TotalCitas { get => totalCitas; set => totalCitas = value; }
    }
    internal class DTOActividades : Conexion
    {
        private DateTime FechaInicio;
        private DateTime FechaFinal;
        private int numeroDias;
        private int citasAtendidas;
        private int citasPedientes;
        private int citasPerdidas;

        private int numeroCitas;
        //private int totalCitas;

        public DateTime FechaInicio1 { get => FechaInicio; set => FechaInicio = value; }
        public DateTime FechaFinal1 { get => FechaFinal; set => FechaFinal = value; }
        public int CitasAtendidas { get => citasAtendidas; set => citasAtendidas = value; }
        public int CitasPedientes { get => citasPedientes; set => citasPedientes = value; }
        public int CitasPerdidas { get => citasPerdidas; set => citasPerdidas = value; }
        public int NumeroDias { get => numeroDias; set => numeroDias = value; }
        public List<revenueByDate> GraficoCitas { get; protected set; }
        public int NumeroCitas { get => numeroCitas; set => numeroCitas = value; }

        //public int TotalCitas { get => totalCitas; set => totalCitas = value; }

        //Getter Setter Historial
        public string Nombre { get => nombre; set => nombre = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFin { get => horaFin; set => horaFin = value; }
        public string DocumentoPresentado { get => documentoPresentado; set => documentoPresentado = value; }

        //public int TotalCitas { get => totalCitas; set => totalCitas = value; }


        //DTO de Historial

        private string nombre;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;
        private string documentoPresentado;
    }
}