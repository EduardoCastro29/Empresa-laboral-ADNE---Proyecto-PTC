using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Drawing.Printing;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLPrimerUsoSistema
    {
        readonly PrimerUsoSistemaForm ObjPrimerUsoSistema;

        public CTRLPrimerUsoSistema(PrimerUsoSistemaForm Vista)
        {
            ObjPrimerUsoSistema = Vista;


        }
    }
}