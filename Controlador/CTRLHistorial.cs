using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Data;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLHistorial
    {
        readonly HistorialForm ObjHistorial;

        public CTRLHistorial(HistorialForm Vista)
        {
            ObjHistorial = Vista;

            ObjHistorial.Load += new EventHandler(CargarHistorialUC);
        }
        private void CargarHistorialUC(object sender, EventArgs e)
        {
            //Creamos una instancia de la clase DAO
            DAOActividades ObjDAOActividades = new DAOActividades();
            //Creamos una instancia de un DataTable
            DataTable ObjCargarUC = ObjDAOActividades.CargarControlHistorial();

            //Creamos un bucle foreach
            foreach (DataRow DataRow in ObjCargarUC.Rows)
            {
                ObjDAOActividades.Nombre2 = (string)DataRow[0];
                ObjDAOActividades.HoraInicio2 = (TimeSpan)DataRow[1];
                ObjDAOActividades.HoraFin = (TimeSpan)DataRow[2];
                ObjDAOActividades.DocumentoPresentado = (string)DataRow[3];

                //Instanciamos a la clase UCEmpleado que necesitamos recrear
                ControlHistorialUC ObjControlHistorial = new ControlHistorialUC(ObjDAOActividades);
                //Añadimos los valores
                ObjHistorial.flpHistorial.Controls.Add(ObjControlHistorial);
            }
        }
    }
}