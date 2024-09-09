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
    internal class DTOPreguntasSeguridad : Conexion
    {
        //Getters y setters de las Preguntas de Seguridad, NOT IN
        private int preguntaNotIn1;
        private int preguntaNotIn2;
        private int preguntaNotIn3;

        public int PreguntaNotIn1 { get => preguntaNotIn1; set => preguntaNotIn1 = value; }
        public int PreguntaNotIn2 { get => preguntaNotIn2; set => preguntaNotIn2 = value; }
        public int PreguntaNotIn3 { get => preguntaNotIn3; set => preguntaNotIn3 = value; }

        //Getters y setters, Inserción en preguntas de seguridad y Selects
        private string dUIProfesional;
        private string usuarioSolicitante;
        private int pregunta1CMB;
        private int pregunta2CMB;
        private int pregunta3CMB;
        private int pregunta4CMB;
        private string respuestaPregunta1;
        private string respuestaPregunta2;
        private string respuestaPregunta3;
        private string respuestaPregunta4;

        public string DUIProfesional { get => dUIProfesional; set => dUIProfesional = value; }
        public string UsuarioSolicitante { get => usuarioSolicitante; set => usuarioSolicitante = value; }
        public int Pregunta1CMB { get => pregunta1CMB; set => pregunta1CMB = value; }
        public int Pregunta2CMB { get => pregunta2CMB; set => pregunta2CMB = value; }
        public int Pregunta3CMB { get => pregunta3CMB; set => pregunta3CMB = value; }
        public int Pregunta4CMB { get => pregunta4CMB; set => pregunta4CMB = value; }
        public string RespuestaPregunta1 { get => respuestaPregunta1; set => respuestaPregunta1 = value; }
        public string RespuestaPregunta2 { get => respuestaPregunta2; set => respuestaPregunta2 = value; }
        public string RespuestaPregunta3 { get => respuestaPregunta3; set => respuestaPregunta3 = value; }
        public string RespuestaPregunta4 { get => respuestaPregunta4; set => respuestaPregunta4 = value; }
    }
}