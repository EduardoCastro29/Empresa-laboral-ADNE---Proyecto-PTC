using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLActividades
    {
        readonly ActividadesForm ObjActividadesForm;
        public CTRLActividades(ActividadesForm Vista)
        {
            ObjActividadesForm = Vista;

            CargarIntervaloCitas();
            ObjActividadesForm.Load += new EventHandler(CargarInfo);
        }
        #region Cargar Formulario
        private void CargarInfo(object sender, EventArgs e)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Formatear el nombre del día y el día del mes
            string diaYFecha = fechaActual.ToString("dd/MM/yyyy");
            ObjActividadesForm.lblFecha.Text = diaYFecha;
        }
        private void CargarIntervaloCitas()
        {
            try
            {
                DAOActividades ObjCargarIntervaloCitas = new DAOActividades();
                //Cargamos el intervalo de citas según lo que tenga la base de datos en la consulta
                ObjCargarIntervaloCitas.CitasAtendidas = ObjCargarIntervaloCitas.ContarIntervaloCitasAtendidas();
                ObjActividadesForm.lblCitasAtendidas.Text = ObjCargarIntervaloCitas.CitasAtendidas.ToString();

                ObjCargarIntervaloCitas.CitasPedientes = ObjCargarIntervaloCitas.ContarIntervaloCitasPendiente();
                ObjActividadesForm.lblCitasPendientes.Text = ObjCargarIntervaloCitas.CitasPedientes.ToString();

                ObjCargarIntervaloCitas.CitasPerdidas = ObjCargarIntervaloCitas.ContarIntervaloCitasPerdida();
                ObjActividadesForm.lblCitasPerdidas.Text = ObjCargarIntervaloCitas.CitasPerdidas.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}