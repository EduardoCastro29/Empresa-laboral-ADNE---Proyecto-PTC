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
    internal class DTOInformacionEncargado : Conexion
    {
        //Getters y setters
        private string documentoPresentado;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int edad;
        private string telefono;
        private string correoElectronico;
        private string domicilio;
        private string documentoPresentadoP;
        private int relacionEncargadoId;

        public string DocumentoPresentado { get => documentoPresentado; set => documentoPresentado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string DocumentoPresentadoP { get => documentoPresentadoP; set => documentoPresentadoP = value; }
        public int RelacionEncargadoId { get => relacionEncargadoId; set => relacionEncargadoId = value; }
    }
}