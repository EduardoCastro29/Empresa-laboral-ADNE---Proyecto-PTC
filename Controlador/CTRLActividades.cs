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

            // Al presionar el boton Ver este dia Se carga el metodo asignado
            ObjActividadesForm.btnVerEsteDia.Click += new EventHandler(CargarGraficoEsteDia);
            ObjActividadesForm.btnVer7Dias.Click += new EventHandler(CargarGraficoUltimos7Dias);
            ObjActividadesForm.btnVer30Dias.Click += new EventHandler(CargarGraficoUltimos30Dias);
            ObjActividadesForm.btnVerEsteMes.Click += new EventHandler(CargarGraficoEsteMes);
            ObjActividadesForm.btnVerPersonalizadoDia.Click += new EventHandler(CargarGraficoPersonalizado);
            ObjActividadesForm.btnOk.Click += new EventHandler(CargarGraficoPersonalizadoOK);
        }
        #region GraficoChart 
        private void CargarGraficoEsteDia(object Sender, EventArgs e)
        {
            ObjActividadesForm.dtFechaInicio.Value = DateTime.Today;
            ObjActividadesForm.dtFechaFinal.Value = DateTime.Now;
            CargarIntervaloCitas();
            DesabilitarBotones();
        }

        private void CargarGraficoUltimos7Dias(object Sender, EventArgs e)
        {
            ObjActividadesForm.dtFechaInicio.Value = DateTime.Today.AddDays(-7);
            ObjActividadesForm.dtFechaFinal.Value = DateTime.Now;
            CargarIntervaloCitas();
            DesabilitarBotones();
        }

        private void CargarGraficoUltimos30Dias(object Sender, EventArgs e)
        {
            ObjActividadesForm.dtFechaInicio.Value = DateTime.Today.AddDays(-30);
            ObjActividadesForm.dtFechaFinal.Value = DateTime.Now;
            CargarIntervaloCitas();
            DesabilitarBotones();
        }

        private void CargarGraficoEsteMes(object Sender, EventArgs e)
        {
            ObjActividadesForm.dtFechaInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            ObjActividadesForm.dtFechaFinal.Value = DateTime.Now;
            CargarIntervaloCitas();
            DesabilitarBotones();
        }

        private void CargarGraficoPersonalizado(object Sender, EventArgs e)
        {
            ObjActividadesForm.dtFechaInicio.Enabled = true;
            ObjActividadesForm.dtFechaFinal.Enabled = true;
            ObjActividadesForm.btnOk.Visible = true;
        }

        private void CargarGraficoPersonalizadoOK(object Sender, EventArgs e)
        {
            CargarIntervaloCitas();

        }

        private void DesabilitarBotones()
        {
            ObjActividadesForm.dtFechaInicio.Enabled = false;
            ObjActividadesForm.dtFechaFinal.Enabled = false;
            ObjActividadesForm.btnOk.Visible = false;
        }
        #endregion
        #region Cargar Formulario
        private void CargarInfo(object Sender, EventArgs e)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Formatear el nombre del día y el día del mes
            string diaYFecha = fechaActual.ToString("dd/MM/yyyy");
            ObjActividadesForm.lblFecha.Text = diaYFecha;
            // Chart
            ObjActividadesForm.dtFechaInicio.Value = DateTime.Today.AddDays(-7);
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
                        // Agregar valores default
                        //MessageBox.Show("No se encontraron datos para mostrar en el gráfico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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