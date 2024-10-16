﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador.Controlador_UC_Calendario;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Drawing;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLVerCitas
    {
        readonly VerCitasForm ObjVerCitasForm;
        public CTRLVerCitas(VerCitasForm Vista)
        {
            ObjVerCitasForm = Vista;

            CargarDGVCitas();
            ObjVerCitasForm.cmsVerCita.Click += new EventHandler(VerCitaDetallada);
            ObjVerCitasForm.cmsActualizar.Click += new EventHandler(ActualizarCita);
            ObjVerCitasForm.cmsEliminarCita.Click += new EventHandler(EliminarCita);
            ObjVerCitasForm.btnBuscar.Click += new EventHandler(BuscarCita);
            ObjVerCitasForm.btnPendientes.Click += new EventHandler(MostrarCitasPendientes);
            ObjVerCitasForm.btnAtendidas.Click += new EventHandler(MostrarCitasAtendidas);
            ObjVerCitasForm.btnTodas.Click += new EventHandler(MostrarCitas);
        }
        #region Eventos Iniciales al cargar el Formulario
        private void CargarDGVCitas()
        {
            DAOVerCitas ObjDAOLlenarDGVCitas = new DAOVerCitas();
            DataTable ObjVerDGVCits = ObjDAOLlenarDGVCitas.CargarDataGridVerCitas();
            try
            {
                //Indicamos que el DGV no posee datos
                ObjVerCitasForm.dgvCitasAgendadas.DataSource = null;

                //Cargamos los datos
                ObjVerCitasForm.dgvCitasAgendadas.DataSource = ObjVerDGVCits;

                //Indicamos que columnas no queremos que se muestren a simple vista
                ObjVerCitasForm.dgvCitasAgendadas.Columns[0].Visible = false;
                ObjVerCitasForm.dgvCitasAgendadas.Columns[1].Visible = false;
                ObjVerCitasForm.dgvCitasAgendadas.Columns[2].Visible = false;
                ObjVerCitasForm.dgvCitasAgendadas.Columns[3].Visible = false;
                ObjVerCitasForm.dgvCitasAgendadas.Columns[8].Visible = false;
                ObjVerCitasForm.dgvCitasAgendadas.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Ver la Cita de forma solo Lectura (READ)
        private void VerCitaDetallada(object sender, EventArgs e)
        {
            int PosicionFila = ObjVerCitasForm.dgvCitasAgendadas.CurrentRow.Index;

            int CitaID = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[0, PosicionFila].Value.ToString());
            int ConsultaID = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[1, PosicionFila].Value.ToString());
            DateTime FechaCita = DateTime.Parse(ObjVerCitasForm.dgvCitasAgendadas[4, PosicionFila].Value.ToString());
            TimeSpan HoraInicioCita = TimeSpan.Parse(ObjVerCitasForm.dgvCitasAgendadas[5, PosicionFila].Value.ToString());
            TimeSpan FechaFinalCita = TimeSpan.Parse(ObjVerCitasForm.dgvCitasAgendadas[6, PosicionFila].Value.ToString());
            string EstadoCita = ObjVerCitasForm.dgvCitasAgendadas[7, PosicionFila].Value.ToString();
            string DescripcionCita = ObjVerCitasForm.dgvCitasAgendadas[8, PosicionFila].Value.ToString();
            string NombrePaciente = ObjVerCitasForm.dgvCitasAgendadas[9, PosicionFila].Value.ToString();
            string NombreProfesional = ObjVerCitasForm.dgvCitasAgendadas[11, PosicionFila].Value.ToString();
            string LugarCita = ObjVerCitasForm.dgvCitasAgendadas[11, PosicionFila].Value.ToString();

            AgendarCitaForm ObjVerCitasDetalladas = new AgendarCitaForm();

            ObjVerCitasDetalladas.txtIDCita.Text = CitaID.ToString();
            ObjVerCitasDetalladas.txtIDConsulta.Text = ConsultaID.ToString();
            ObjVerCitasDetalladas.dtFecha.Value = FechaCita.Date;
            ObjVerCitasDetalladas.dtHoraInicio.Text = HoraInicioCita.ToString(); //Nuevo dt en lugar del textbox
            ObjVerCitasDetalladas.dtHoraFinal.Text = FechaFinalCita.ToString(); //Nuevo dt en lugar del textbox
            ObjVerCitasDetalladas.cmbEstado.SelectedValue = EstadoCita;
            ObjVerCitasDetalladas.txtMotivoConsulta.Text = DescripcionCita;
            ObjVerCitasDetalladas.txtDUIPaciente.Text = NombrePaciente;
            ObjVerCitasDetalladas.txtDUIProfesional.Text = NombreProfesional;
            ObjVerCitasDetalladas.cmbLugar.ValueMember = LugarCita;

            //Especificamos qué apartados no deben de mostrarse a la hora de la vista
            ObjVerCitasDetalladas.dtFecha.Enabled = false;
            ObjVerCitasDetalladas.dtHoraInicio.Enabled = false; //Nuevo dt en lugar del textbox
            ObjVerCitasDetalladas.dtHoraFinal.Enabled = false; //Nuevo dt en lugar del textbox
            ObjVerCitasDetalladas.cmbEstado.Enabled = false;
            ObjVerCitasDetalladas.txtMotivoConsulta.Enabled = false;
            ObjVerCitasDetalladas.cmbLugar.Enabled = false;
            ObjVerCitasDetalladas.btnModificar.Enabled = false;
            ObjVerCitasDetalladas.btnGuardar.Enabled = false;
            ObjVerCitasDetalladas.txtDUIPaciente.Enabled = false;
            ObjVerCitasDetalladas.txtDUIProfesional.Enabled = false;

            ObjVerCitasDetalladas.ShowDialog();

            //Una vez cerrado el formulario de citas, se procede a recargar el DataGridView
            CargarDGVCitas();
        }
        #endregion
        #region Actualización en el Formulario de Citas (UPDATE)
        private void ActualizarCita(object sender, EventArgs e)
        {
            int PosicionFila = ObjVerCitasForm.dgvCitasAgendadas.CurrentRow.Index;

            int CitaID = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[0, PosicionFila].Value.ToString());
            int ConsultaID = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[1, PosicionFila].Value.ToString());
            string PacienteDUI = ObjVerCitasForm.dgvCitasAgendadas[2, PosicionFila].Value.ToString();
            DateTime FechaCita = DateTime.Parse(ObjVerCitasForm.dgvCitasAgendadas[4, PosicionFila].Value.ToString());
            TimeSpan HoraInicioCita = TimeSpan.Parse(ObjVerCitasForm.dgvCitasAgendadas[5, PosicionFila].Value.ToString());
            TimeSpan FechaFinalCita = TimeSpan.Parse(ObjVerCitasForm.dgvCitasAgendadas[6, PosicionFila].Value.ToString());
            string EstadoCita = ObjVerCitasForm.dgvCitasAgendadas[7, PosicionFila].Value.ToString();
            string DescripcionCita = ObjVerCitasForm.dgvCitasAgendadas[8, PosicionFila].Value.ToString();
            string LugarCita = ObjVerCitasForm.dgvCitasAgendadas[12, PosicionFila].Value.ToString();

            AgendarCitaForm ObjActualizarCita = new AgendarCitaForm();

            ObjActualizarCita.txtIDCita.Text = CitaID.ToString();
            ObjActualizarCita.txtIDConsulta.Text = ConsultaID.ToString();
            ObjActualizarCita.dtFecha.Value = FechaCita.Date;
            ObjActualizarCita.dtHoraInicio.Text = HoraInicioCita.ToString(); //Nuevo dt en lugar del textbox
            ObjActualizarCita.dtHoraFinal.Text = FechaFinalCita.ToString(); // Nuevo dt en lugar del textbox
            ObjActualizarCita.cmbEstado.ValueMember = EstadoCita;
            ObjActualizarCita.txtMotivoConsulta.Text = DescripcionCita;
            ObjActualizarCita.txtDUIPaciente.Text = PacienteDUI;
            ObjActualizarCita.txtDUIProfesional.Text = InicioSesion.Dui;
            ObjActualizarCita.cmbLugar.ValueMember = LugarCita;

            //Especificamos qué apartados no deben de modificarse a la hora de la actualización
            ObjActualizarCita.btnGuardar.Enabled = false;
            ObjActualizarCita.txtDUIProfesional.Enabled = false;

            ObjActualizarCita.ShowDialog();

            //Una vez cerrado el formulario de citas, se procede a recargar el DataGridView
            CargarDGVCitas();
        }
        #endregion
        #region Eliminación del Formulario de Citas (DELETE)
        private void EliminarCita(object sender, EventArgs e)
        {
            //Primero, indicamos en qué fila nos encontramos dentro del DataGridView
            int PosicionFila = ObjVerCitasForm.dgvCitasAgendadas.CurrentRow.Index;

            //Enviamos un mensaje de pregunta si realmente deseamos eliminar la Cita que, en caso de ser verdad, procedemos a eliminarla
            if (MessageBox.Show("Seguro de que desea eliminar la Cita seleccionada?" +
                                "Al ser eliminada, también se borrará el registro de la consulta ingresada", "Eliminar Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Instanciamos a la clase DAOVerCitas para obtener los valores
                DAOVerCitas ObjDAOEliminarCita = new DAOVerCitas();

                //Indicamos que el valor de la clase DAOAgendarCita respectivo al DTO, se encuentra en la posición 0
                ObjDAOEliminarCita.CitaId = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[0, PosicionFila].Value.ToString());

                if (ObjDAOEliminarCita.EliminarCitaYConsulta() == true)
                {
                    MessageBox.Show("La Cita ha sido eliminada correctamente", "Eliminar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDGVCitas();
                }
                else
                {
                    MessageBox.Show("La Cita no pudo ser eliminada, verifique si la cita ha sido seleccionada", "Eliminar Cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Buscar una cita por sus denominaciones relevantes (SEARCH)
        private void BuscarCita(object sender, EventArgs e)
        {
            DAOVerCitas ObjDAOBuscarCitas = new DAOVerCitas();
            DataTable ObjBuscar = ObjDAOBuscarCitas.BuscarCitaC(ObjVerCitasForm.txtBuscar.Text);
            ObjVerCitasForm.dgvCitasAgendadas.DataSource = ObjBuscar;
        }
        #endregion
        private void MostrarCitasPendientes(object sender, EventArgs e)
        {
            DAOVerCitas ObjDAO = new DAOVerCitas();
            DataTable CitasPendientes = ObjDAO.CargarDataGridCitasPendientes();
            ObjVerCitasForm.dgvCitasAgendadas.DataSource = CitasPendientes;
        }
        private void MostrarCitasAtendidas(object sender, EventArgs e)
        {
            DAOVerCitas ObjDAO = new DAOVerCitas();
            DataTable CitasAtendidas = ObjDAO.CargarDataGridCitasAtendidas();
            ObjVerCitasForm.dgvCitasAgendadas.DataSource = CitasAtendidas;
        }
        private void MostrarCitas(object sender, EventArgs e)
        {
            CargarDGVCitas();
        }
    }
}