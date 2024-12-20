﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO
{
    internal class DTORegistroEspecialidad : Conexion
    {
        //Getters y setters
        private int idEspecialidad;
        private string DUIEmpleado;
        private int idEspecialidadNombre;

        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string DUIEmpleado1 { get => DUIEmpleado; set => DUIEmpleado = value; }
        public int IdEspecialidadNombre { get => idEspecialidadNombre; set => idEspecialidadNombre = value; }
    }
}