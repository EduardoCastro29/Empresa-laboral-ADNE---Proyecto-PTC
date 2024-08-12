using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador.Controlador_UC_Calendario;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLVerCitas
    {
        readonly VerCitasForm ObjVerCitasForm;
        AgendarCitaForm ObjVerCitasDetalladas = null;

        public CTRLVerCitas(VerCitasForm Vista)
        {
            ObjVerCitasForm = Vista;

            ObjVerCitasForm.Load += new EventHandler(CargarDGVCitas);
            ObjVerCitasForm.btnVerCitas.Click += new EventHandler(VerCitaDetallada);
            ObjVerCitasForm.btnActualizar.Click += new EventHandler(ActualizarCita);
            ObjVerCitasForm.btnEliminarCita.Click += new EventHandler(EliminarCita);
        }
        private void CargarDGVCitas(object sender, EventArgs e)
        {
            DAOVerCitas ObjDAOLlenarDGVCitas = new DAOVerCitas();
            try
            {
                //Indicamos que el DGV no posee datos
                ObjVerCitasForm.dgvCitasAgendadas.DataSource = null;

                //Cargamos los datos
                ObjVerCitasForm.dgvCitasAgendadas.DataSource = ObjDAOLlenarDGVCitas.CargarDataGridVerCitas();

                //Indicamos que columnas no queremos que se muestren a simple vista
                ObjVerCitasForm.dgvCitasAgendadas.Columns[0].Visible = false;
                ObjVerCitasForm.dgvCitasAgendadas.Columns[1].Visible = false;
                ObjVerCitasForm.dgvCitasAgendadas.Columns[2].Visible = false;
                ObjVerCitasForm.dgvCitasAgendadas.Columns[3].Visible = false;
                ObjVerCitasForm.dgvCitasAgendadas.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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

            if (ObjVerCitasDetalladas == null || ObjVerCitasDetalladas.IsDisposed)
            {
                ObjVerCitasDetalladas = new AgendarCitaForm();

                ObjVerCitasDetalladas.txtIDCita.Text = CitaID.ToString();
                ObjVerCitasDetalladas.txtIDConsulta.Text = ConsultaID.ToString();
                ObjVerCitasDetalladas.txtfecha.Text = FechaCita.ToString();
                ObjVerCitasDetalladas.txtHoraInicio.Text = HoraInicioCita.ToString();
                ObjVerCitasDetalladas.txtHoraFinal.Text = FechaFinalCita.ToString();
                ObjVerCitasDetalladas.cmbEstado.SelectedValue = EstadoCita;
                ObjVerCitasDetalladas.txtMotivoConsulta.Text = DescripcionCita;
                ObjVerCitasDetalladas.txtPacienteID.Text = NombrePaciente;
                ObjVerCitasDetalladas.txtProfesionalID.Text = NombreProfesional;
                ObjVerCitasDetalladas.cmbLugar.SelectedValue = LugarCita;

                //Especificamos qué apartados no deben de mostrarse a la hora de la vista
                ObjVerCitasDetalladas.txtfecha.Enabled = false;
                ObjVerCitasDetalladas.txtHoraInicio.Enabled = false;
                ObjVerCitasDetalladas.txtHoraFinal.Enabled = false;
                ObjVerCitasDetalladas.cmbEstado.Enabled = false;
                ObjVerCitasDetalladas.txtMotivoConsulta.Enabled = false;
                ObjVerCitasDetalladas.txtPacienteID.Enabled = false;
                ObjVerCitasDetalladas.txtProfesionalID.Enabled = false;
                ObjVerCitasDetalladas.cmbLugar.Enabled = false;
                ObjVerCitasDetalladas.btnModificar.Enabled = false;
                ObjVerCitasDetalladas.btnGuardar.Enabled = false;

                ObjVerCitasDetalladas.Show();
            }
            else
            {
                ObjVerCitasDetalladas.BringToFront();
            }
        }
        private void ActualizarCita(object sender, EventArgs e)
        {
            int PosicionFila = ObjVerCitasForm.dgvCitasAgendadas.CurrentRow.Index;

            int CitaID = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[0, PosicionFila].Value.ToString());
            int ConsultaID = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[1, PosicionFila].Value.ToString());
            int PacienteID = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[2, PosicionFila].Value.ToString());
            int ProfesionalID = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[3, PosicionFila].Value.ToString());
            DateTime FechaCita = DateTime.Parse(ObjVerCitasForm.dgvCitasAgendadas[4, PosicionFila].Value.ToString());
            TimeSpan HoraInicioCita = TimeSpan.Parse(ObjVerCitasForm.dgvCitasAgendadas[5, PosicionFila].Value.ToString());
            TimeSpan FechaFinalCita = TimeSpan.Parse(ObjVerCitasForm.dgvCitasAgendadas[6, PosicionFila].Value.ToString());
            string EstadoCita = ObjVerCitasForm.dgvCitasAgendadas[7, PosicionFila].Value.ToString();
            string DescripcionCita = ObjVerCitasForm.dgvCitasAgendadas[8, PosicionFila].Value.ToString();
            string LugarCita = ObjVerCitasForm.dgvCitasAgendadas[12, PosicionFila].Value.ToString();

            if (ObjVerCitasDetalladas == null || ObjVerCitasDetalladas.IsDisposed)
            {
                ObjVerCitasDetalladas = new AgendarCitaForm();

                ObjVerCitasDetalladas.txtIDCita.Text = CitaID.ToString();
                ObjVerCitasDetalladas.txtIDConsulta.Text = ConsultaID.ToString();
                ObjVerCitasDetalladas.txtPacienteID.Text = PacienteID.ToString();
                ObjVerCitasDetalladas.txtProfesionalID.Text = ProfesionalID.ToString();
                ObjVerCitasDetalladas.txtfecha.Text = FechaCita.ToString();
                ObjVerCitasDetalladas.txtHoraInicio.Text = HoraInicioCita.ToString();
                ObjVerCitasDetalladas.txtHoraFinal.Text = FechaFinalCita.ToString();
                ObjVerCitasDetalladas.cmbEstado.SelectedValue = EstadoCita;
                ObjVerCitasDetalladas.txtMotivoConsulta.Text = DescripcionCita;
                ObjVerCitasDetalladas.cmbLugar.SelectedValue = LugarCita;

                //Especificamos qué apartados no deben de mostrarse a la hora de la vista
                ObjVerCitasDetalladas.btnGuardar.Enabled = false;

                ObjVerCitasForm.Hide();
                ObjVerCitasDetalladas.Show();
            }
            else
            {
                ObjVerCitasDetalladas.BringToFront();
            }
        }
        private void EliminarCita(object sender, EventArgs e)
        {
            //Primero, indicamos en qué fila nos encontramos dentro del DataGridView
            int PosicionFila = ObjVerCitasForm.dgvCitasAgendadas.CurrentRow.Index;

            //Enviamos un mensaje de pregunta si realmente deseamos eliminar la Cita que, en caso de ser verdad, procedemos a eliminarla
            if (MessageBox.Show("Seguro de que desea eliminar la Cita seleccionada?" +
                                "Al ser eliminada, también se borrará el registro de la consulta Ingresada", "Eliminar Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Instanciamos a la clase DAOVerCitas para obtener los valores
                DAOVerCitas ObjDAOEliminarCita = new DAOVerCitas();

                //Indicamos que el valor de la clase DAOAgendarCita respectivo al DTO, se encuentra en la posición 0
                ObjDAOEliminarCita.CitaId = int.Parse(ObjVerCitasForm.dgvCitasAgendadas[0, PosicionFila].Value.ToString());

                if (ObjDAOEliminarCita.EliminarCitaYConsulta() == true)
                {
                    MessageBox.Show("La Cita ha sido eliminada correctamente", "Eliminar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}