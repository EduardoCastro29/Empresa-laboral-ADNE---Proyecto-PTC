using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLActividades
    {
        readonly ActividadesForm ObjActividadesForm;
        HistorialForm ObjVerHistorial = null;
        public CTRLActividades(ActividadesForm Vista)
        {
            ObjActividadesForm = Vista;

            ObjActividadesForm.Load += new EventHandler(CargarInfo);
        }
        private void CargarInfo(object sender, EventArgs e)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Formatear el nombre del día y el día del mes
            string diaYFecha = fechaActual.ToString("dd/MM/yyyy");
            ObjActividadesForm.lblFecha.Text = diaYFecha;
        }
    }
}