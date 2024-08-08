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

        //Creamos el constructor
        public CTRLActividades(ActividadesForm Vista)
        {
            ObjActividadesForm = Vista;

            ObjActividadesForm.btnPacientes.Click += new EventHandler(VerPacientes);
        }
        //Aca su crudo



        private void VerPacientes(object sender, EventArgs e)
        {
            if (ObjVerHistorial == null || ObjVerHistorial.IsDisposed)
            {
                ObjVerHistorial = new HistorialForm();
                ObjVerHistorial.Show();
            }
            else
            {
                ObjVerHistorial.BringToFront();
            }
        }
    }
}