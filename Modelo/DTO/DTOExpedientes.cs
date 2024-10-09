using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO
{
    internal class DTOExpedientes : Conexion
    {
        //Atributos para los UC
        private string nombre;
        private int citaId;
        private DateTime fecha;
        private TimeSpan horaInicio;
        private string estadoId;
        private int pacienteId;
        private string documentoPaciente;

        //Atributos para el expediente
        private int n_expediente;
        private string nombre_apellido_paciente;
        private string domicilio;
        private string nacionalidad;
        private string doc_presentado;
        private string tel;
        private int edad;
        private string genero;
        private string profesion;
        private string com_familiar;
        private string motivo;
        private string antecedentes;
        private string desc_situacion;
        private string aspectos;
        private string afectividad;
        private string estado_conducta;
        private string somatizaciones;
        private string vidaInterpersonal;
        private string cognicion;
        private string red_social;
        private string pautas;
        private string riesgoValorado;
        private string observacion;
        private string aproximacionDiag;
        private string atencionBrindada;
        private DateTime fecha_Cita;
        private string lugar;
        private string desc_Cita;

        //Atributos de los datos de la empresa
        private string nombreEmpresa;
        private string direccionEmpresa;
        private string correoElectronicoE;
        private string numeroTelefono;
        private string numeroPBX;
        private DateTime feghaCreacionE;
        private byte[] fotoEmpresa;

        public string Nombre { get => nombre; set => nombre = value; }
        public int CitaId { get => citaId; set => citaId = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string EstadoId { get => estadoId; set => estadoId = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
        //Métodos para el expediente :)
        public int N_expediente { get => n_expediente; set => n_expediente = value; }
        public string Nombre_apellido_paciente { get => nombre_apellido_paciente; set => nombre_apellido_paciente = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Doc_presentado { get => doc_presentado; set => doc_presentado = value; }
        public string Tel { get => tel; set => tel = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public string Com_familiar { get => com_familiar; set => com_familiar = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Antecedentes { get => antecedentes; set => antecedentes = value; }
        public string Desc_situacion { get => desc_situacion; set => desc_situacion = value; }
        public string Aspectos { get => aspectos; set => aspectos = value; }
        public string Afectividad { get => afectividad; set => afectividad = value; }
        public string Estado_conducta { get => estado_conducta; set => estado_conducta = value; }
        public string Somatizaciones { get => somatizaciones; set => somatizaciones = value; }
        public string VidaInterpersonal { get => vidaInterpersonal; set => vidaInterpersonal = value; }
        public string Cognicion { get => cognicion; set => cognicion = value; }
        public string Red_social { get => red_social; set => red_social = value; }
        public string Pautas { get => pautas; set => pautas = value; }
        public string RiesgoValorado { get => riesgoValorado; set => riesgoValorado = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string AproximacionDiag { get => aproximacionDiag; set => aproximacionDiag = value; }
        public string AtencionBrindada { get => atencionBrindada; set => atencionBrindada = value; }
        public DateTime Fecha_Cita { get => fecha_Cita; set => fecha_Cita = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public string Desc_Cita { get => desc_Cita; set => desc_Cita = value; }
        public string DocumentoPaciente { get => documentoPaciente; set => documentoPaciente = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string DireccionEmpresa { get => direccionEmpresa; set => direccionEmpresa = value; }
        public string CorreoElectronicoE { get => correoElectronicoE; set => correoElectronicoE = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public string NumeroPBX { get => numeroPBX; set => numeroPBX = value; }
        public DateTime FeghaCreacionE { get => feghaCreacionE; set => feghaCreacionE = value; }
        public byte[] FotoEmpresa { get => fotoEmpresa; set => fotoEmpresa = value; }
    }
}