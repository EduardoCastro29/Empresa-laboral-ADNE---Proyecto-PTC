using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Data;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLActividades
    {
        readonly ActividadesForm ObjActividadesForm;
        HistorialForm ObjHistorialForm = null;
        public CTRLActividades(ActividadesForm Vista)
        {
            ObjActividadesForm = Vista;
            ObjActividadesForm.Load += new EventHandler(CargarInfo);
            // Al presionar el boton Ver este dia Se carga el metodo asignado
            ObjActividadesForm.btnHistorial.Click += new EventHandler(AbrirHistorial);
            ObjActividadesForm.btnVerEsteDia.Click += new EventHandler(CargarGraficoEsteDia);
            ObjActividadesForm.btnVer7Dias.Click += new EventHandler(CargarGraficoUltimos7Dias);
            ObjActividadesForm.btnVer30Dias.Click += new EventHandler(CargarGraficoUltimos30Dias);
            ObjActividadesForm.btnVerEsteMes.Click += new EventHandler(CargarGraficoEsteMes);
            ObjActividadesForm.btnVerPersonalizadoDia.Click += new EventHandler(CargarGraficoPersonalizado);
            ObjActividadesForm.btnOk.Click += new EventHandler(CargarGraficoPersonalizadoOK);

            ObjActividadesForm.btnEnviarRecordatorios.Click += new EventHandler(EnviarRecordatorios);
        }
        #region Abrir Historial desde el formulario de actividades
        private void AbrirHistorial(object sender, EventArgs e)
        {
            if (ObjHistorialForm == null || ObjHistorialForm.IsDisposed)
            {
                ObjHistorialForm = new HistorialForm();
                ObjHistorialForm.Show();
            }
            else
            {
                ObjHistorialForm.BringToFront();
            }
        }
        #endregion
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
            ObjActividadesForm.GraficoCitas.ChartAreas[0].AxisY.Interval = 1;
            ObjActividadesForm.GraficoCitas.ChartAreas[0].AxisY.LabelStyle.Format = "0";
            ObjActividadesForm.GraficoCitas.ChartAreas[0].AxisY.IsStartedFromZero = true;
            // Formatear el nombre del día y el día del mes
            string diaYFecha = fechaActual.ToString("dd/MM/yyyy");
            ObjActividadesForm.lblFecha.Text = diaYFecha;
            // Chart
            ObjActividadesForm.dtFechaInicio.Value = DateTime.Today.AddDays(-7);
            ObjActividadesForm.dtFechaFinal.Value = DateTime.Now;
            ObjActividadesForm.btnVer7Dias.Select();

            CargarSiguientePaciente();

            CargarIntervaloCitas();
        }
        private void CargarSiguientePaciente()
        {
            DAOActividades objDAO = new DAOActividades();

            if (objDAO.ObtenerSiguienteCita().Rows.Count != 0)
            {
                #region config
                ObjActividadesForm.lblDiaCita.Visible = true;
                ObjActividadesForm.lblLugarCita.Visible = true;
                ObjActividadesForm.lblHoraCita.Visible = true;
                ObjActividadesForm.lblHora.Visible = true;
                ObjActividadesForm.lblDia.Visible = true;
                ObjActividadesForm.lblLugar.Visible = true;

                ObjActividadesForm.lblDefault.Visible = false;
                ObjActividadesForm.plSiguientePaciente.BackColor = System.Drawing.Color.Transparent;
                #endregion
                DataTable dt = objDAO.ObtenerSiguienteCita();
                foreach (DataRow dr in dt.Rows)
                {
                    objDAO.Nombre1 = (string)dr[9];
                    objDAO.Apellido1 = (string)dr[10];
                    objDAO.DUI1 = (string)dr[2];

                    ControlVerPacientesUC ObjControlPaciente = new ControlVerPacientesUC(objDAO);
                    ObjActividadesForm.plSiguientePaciente.Controls.Add(ObjControlPaciente);

                    objDAO.Fecha1 = (DateTime)dr[4];
                    objDAO.HoraInicio1 = (TimeSpan)dr[5];
                    objDAO.Lugar1 = (string)dr[12];

                    ObjActividadesForm.lblDia.Text = objDAO.Fecha1.ToString("yyyy-MM-dd");
                    ObjActividadesForm.lblHora.Text = objDAO.HoraInicio1.ToString(@"hh\:mm");
                    ObjActividadesForm.lblLugar.Text = objDAO.Lugar1;
                }
            }
            else
            {
                CargarDefault();
            }
        }
        private void CargarDefault()
        {
            #region Config Default
            ObjActividadesForm.lblDiaCita.Visible = false;
            ObjActividadesForm.lblLugarCita.Visible = false;
            ObjActividadesForm.lblHoraCita.Visible = false;
            ObjActividadesForm.lblHora.Visible = false;
            ObjActividadesForm.lblDia.Visible = false;
            ObjActividadesForm.lblLugar.Visible = false;

            ObjActividadesForm.lblDefault.Visible = true;
            ObjActividadesForm.plSiguientePaciente.BackColor = System.Drawing.Color.FromArgb(50, 98, 204, 192);
            #endregion
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        public void EnviarRecordatorios(object sender, EventArgs e)
        {
            DAOActividades objDAO = new DAOActividades();
            objDAO.EnviarRecordatoriosCitasHoy();
            MessageBox.Show("Proceso terminado");
        }
    }
}