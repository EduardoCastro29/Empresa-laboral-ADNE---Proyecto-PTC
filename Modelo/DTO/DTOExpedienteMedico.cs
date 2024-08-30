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
    internal class DTOExpedienteMedico : Conexion
    {
        // Atributos para expediente 
        private int expedienteId;
        private string documentoPresentado;
        private string estadoAnimo;
        private string estadoConductual;
        private string somatizacion;
        private string vidaInterpersonal;
        private string cognicion;
        private string redSocial;
        private string pauta;
        private string riesgoValorado;
        private string observacion;
        private string aproximacionDiag;
        private string atencionBrindada;

        //Getters Setters
        public int ExpedienteId { get => expedienteId; set => expedienteId = value; }
        public string EstadoAnimo { get => estadoAnimo; set => estadoAnimo = value; }
        public string EstadoConductual { get => estadoConductual; set => estadoConductual = value; }
        public string Somatizacion { get => somatizacion; set => somatizacion = value; }
        public string VidaInterpersonal { get => vidaInterpersonal; set => vidaInterpersonal = value; }
        public string Cognicion { get => cognicion; set => cognicion = value; }
        public string RedSocial { get => redSocial; set => redSocial = value; }
        public string Pauta { get => pauta; set => pauta = value; }
        public string RiesgoValorado { get => riesgoValorado; set => riesgoValorado = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string AproximacionDiag { get => aproximacionDiag; set => aproximacionDiag = value; }
        public string AtencionBrindada { get => atencionBrindada; set => atencionBrindada = value; }
        public string DocumentoPresentado { get => documentoPresentado; set => documentoPresentado = value; }
    }
}