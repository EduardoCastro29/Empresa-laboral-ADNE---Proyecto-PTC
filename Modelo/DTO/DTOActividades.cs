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

        //DTO de Historial

        private string nombre;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;
        private string documentoPresentado;

        //DTO de UC Siguiente cita
        private DateTime Fecha;
        private string DUI;
        private TimeSpan HoraInicio;
        private string Nombre;
        private string Apellido;
        private string Lugar;

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
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Lugar1 { get => Lugar; set => Lugar = value; }

        //Datos encapsulados para el historial
        public string Nombre2 { get => nombre; set => nombre = value; }
        public TimeSpan HoraInicio2 { get => horaInicio; set => horaInicio = value; }
        public TimeSpan HoraFin { get => horaFin; set => horaFin = value; }
        public string DocumentoPresentado { get => documentoPresentado; set => documentoPresentado = value; }

        //public int TotalCitas { get => totalCitas; set => totalCitas = value; }
    }
}