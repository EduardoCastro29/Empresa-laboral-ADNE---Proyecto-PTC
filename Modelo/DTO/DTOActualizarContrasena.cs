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
    internal class DTOActualizarContrasena : Conexion
    {
        //Getters y setters
        private string contrasena;
        private int usuarioID;

        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int UsuarioID { get => usuarioID; set => usuarioID = value; }
    }
}