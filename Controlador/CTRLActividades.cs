using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLActividades
    {
        readonly ActividadesForm ObjActividadesForm;

        public CTRLActividades(ActividadesForm Vista)
        {
            ObjActividadesForm = Vista;
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
            ObjActividadesForm.dtFechaInicio.Value = DateTime.Today;

            //ObjActividadesForm.dtFechaInicio.Value = DateTime.Today.AddDays(-7);
            ObjActividadesForm.dtFechaFinal.Value = DateTime.Now;
            ObjActividadesForm.btnVer7Dias.Select();
            CargarIntervaloCitas();
        }

        private void CargarIntervaloCitas()
        {
            try
            {
                DAOActividades ObjCargarIntervaloCitas = new DAOActividades();

                // Cargamos el intervalo de citas según lo que tenga la base de datos en la consulta
                var refrescarData = ObjCargarIntervaloCitas.CargarDatos(ObjActividadesForm.dtFechaInicio.Value, ObjActividadesForm.dtFechaFinal.Value);

                if (refrescarData)
                {
                    ObjCargarIntervaloCitas.CitasAtendidas = ObjCargarIntervaloCitas.ContarIntervaloCitasAtendidas();
                    ObjActividadesForm.lblCitasAtendidas.Text = ObjCargarIntervaloCitas.CitasAtendidas.ToString();

                    ObjCargarIntervaloCitas.CitasPedientes = ObjCargarIntervaloCitas.ContarIntervaloCitasPendiente();
                    ObjActividadesForm.lblCitasPendientes.Text = ObjCargarIntervaloCitas.CitasPedientes.ToString();

                    ObjCargarIntervaloCitas.CitasPerdidas = ObjCargarIntervaloCitas.ContarIntervaloCitasPerdida();
                    ObjActividadesForm.lblCitasPerdidas.Text = ObjCargarIntervaloCitas.CitasPerdidas.ToString();

                    // Verificar si la lista de datos del gráfico no está vacía
                    if (ObjCargarIntervaloCitas.GraficoCitas != null && ObjCargarIntervaloCitas.GraficoCitas.Count > 0)
                    {
                        // Configurar los datos del gráfico
                        ObjActividadesForm.GraficoCitas.DataSource = ObjCargarIntervaloCitas.GraficoCitas;
                        ObjActividadesForm.GraficoCitas.Series[0].XValueMember = "Date";
                        ObjActividadesForm.GraficoCitas.Series[0].YValueMembers = "TotalCitas";

                        ObjActividadesForm.GraficoCitas.DataBind();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para mostrar en el gráfico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}