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
    internal class DTOInformacionPersonal : Conexion
    {
        //Atributos del paciente
        private DateTime fechaNacimiento;
        private string nombre;
        private string apellido;
        private string domicilio;
        private string nacionalidad;
        private string documentoPresentado;
        private string correoElectronico;
        private string telefono;
        private string profesion;
        private int edad;
        private string composicionFamiliar;
        private string motivo;
        private string antecedente;
        private string descripcion;
        private string aspectosPreocupantes;
        private int generoId;
        private int expedienteId;

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string DocumentoPresentado { get => documentoPresentado; set => documentoPresentado = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string ComposicionFamiliar { get => composicionFamiliar; set => composicionFamiliar = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Antecedente { get => antecedente; set => antecedente = value; }
        public int ExpedienteId { get => expedienteId; set => expedienteId = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string AspectosPreocupantes { get => aspectosPreocupantes; set => aspectosPreocupantes = value; }
        public int GeneroId1 { get => generoId; set => generoId = value; }
    }
}