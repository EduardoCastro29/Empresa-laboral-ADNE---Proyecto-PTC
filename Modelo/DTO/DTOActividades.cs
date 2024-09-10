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

        //Datos encapsulados para la Siguiente Cita
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public string DUI1 { get => DUI; set => DUI = value; }
        public TimeSpan HoraInicio1 { get => HoraInicio; set => HoraInicio = value; }
        public TimeSpan HoraFinal1 { get => HoraFinal; set => HoraFinal = value; }
        public string EstadoCita1 { get => EstadoCita; set => EstadoCita = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Lugar1 { get => Lugar; set => Lugar = value; }

        //public int TotalCitas { get => totalCitas; set => totalCitas = value; }

        //DTO de UC Siguiente cita
        private DateTime Fecha;
        private string DUI;
        private TimeSpan HoraInicio;
        private TimeSpan HoraFinal;
        private string EstadoCita;
        private string Nombre;
        private string Apellido;
        private string Lugar;
    }
}