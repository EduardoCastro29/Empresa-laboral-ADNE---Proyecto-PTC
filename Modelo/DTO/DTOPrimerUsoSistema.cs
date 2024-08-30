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
    internal class DTOPrimerUsoSistema : Conexion
    {
        //Getters y setters
        private string nombreEmpresa;
        private string direccionEmpresa;
        private string correoElectronicoE;
        private string numeroTelefono;
        private string numeroPBX;
        private DateTime feghaCreacionE;
        private string fotoEmpresa;

        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string DireccionEmpresa { get => direccionEmpresa; set => direccionEmpresa = value; }
        public string CorreoElectronicoE { get => correoElectronicoE; set => correoElectronicoE = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public string NumeroPBX { get => numeroPBX; set => numeroPBX = value; }
        public DateTime FeghaCreacionE { get => feghaCreacionE; set => feghaCreacionE = value; }
        public string FotoEmpresa { get => fotoEmpresa; set => fotoEmpresa = value; }
    }
}