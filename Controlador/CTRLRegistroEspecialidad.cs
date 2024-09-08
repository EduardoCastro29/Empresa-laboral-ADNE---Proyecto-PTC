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
    internal class CTRLRegistroEspecialidad
    {
        readonly RegistroEspecialidadesForm ObjRegistroEspecialidad;

        public CTRLRegistroEspecialidad(RegistroEspecialidadesForm Vista)
        {
            ObjRegistroEspecialidad = Vista;

            ObjRegistroEspecialidad.Load += new EventHandler(CargarEspecialidadesYGRID);
            ObjRegistroEspecialidad.btnAnadirEspecialidad.Click += new EventHandler(AgregarEspecialidad);
            ObjRegistroEspecialidad.btnEliminarEspecialidad.Click += new EventHandler(EliminarEspecialidadP);
            ObjRegistroEspecialidad.btnSiguiente.Click += new EventHandler(IngresarLogin);
        }
        #region Eventos Iniciales al cargar el Formulario
        private void CargarDGVEspecialidades()
        {
            DAORegistroEspecialidad ObjCargarGridYDUI = new DAORegistroEspecialidad();

            ObjCargarGridYDUI.DUIEmpleado1 = ObjRegistroEspecialidad.txtDUIProfesional.Text;
            ObjRegistroEspecialidad.dgvEspecialidades.DataSource = null;
            ObjRegistroEspecialidad.dgvEspecialidades.DataSource = ObjCargarGridYDUI.CargarDGVEspecialidadesN();
            //Indicamos que columnas no queremos que se muestren a simple vista
            ObjRegistroEspecialidad.dgvEspecialidades.Columns[0].Visible = false;
            ObjRegistroEspecialidad.dgvEspecialidades.Columns[1].Visible = false;
        }
        private void CargarEspecialidadesYGRID(object sender, EventArgs e)
        {
            DAORegistroEspecialidad ObjDAOCargarEspecialidadYGrid = new DAORegistroEspecialidad();
            ObjDAOCargarEspecialidadYGrid.DUIEmpleado1 = ObjRegistroEspecialidad.txtDUIProfesional.Text;
            //Combobox Especialidad 
            ObjRegistroEspecialidad.cmbEspecialidades.DataSource = ObjDAOCargarEspecialidadYGrid.AgregarCMBEspecialidad();
            ObjRegistroEspecialidad.cmbEspecialidades.ValueMember = "especialidadId"; //Agregamos los atributos que estan en la tabla Especialidad
            ObjRegistroEspecialidad.cmbEspecialidades.DisplayMember = "nombreEspecialidad";

            ObjRegistroEspecialidad.dgvEspecialidades.DataSource = null;
            ObjRegistroEspecialidad.dgvEspecialidades.DataSource = ObjDAOCargarEspecialidadYGrid.CargarDGVEspecialidadesN();
            //Indicamos que columnas no queremos que se muestren a simple vista
            ObjRegistroEspecialidad.dgvEspecialidades.Columns[0].Visible = false;
            ObjRegistroEspecialidad.dgvEspecialidades.Columns[1].Visible = false;
        }
        #endregion
        #region Agregar una nueva especialidad al empleado seleccionado (CREATE), relación de muchos a muchos
        private void AgregarEspecialidad(object sender, EventArgs e)
        {
            try
            {
                DAORegistroEspecialidad ObjInsertarEspecialidad = new DAORegistroEspecialidad();

                ObjInsertarEspecialidad.DUIEmpleado1 = ObjRegistroEspecialidad.txtDUIProfesional.Text.Trim();
                ObjInsertarEspecialidad.IdEspecialidadNombre = int.Parse(ObjRegistroEspecialidad.cmbEspecialidades.SelectedValue.ToString());

                if (ObjInsertarEspecialidad.RegistrarEspecialidadProfesional() == true)
                {
                    ObjRegistroEspecialidad.NotificacionEspecialidad.Show(ObjRegistroEspecialidad, "La especialidad se ha agregado correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    CargarDGVEspecialidades();
                }
                else
                {
                    ObjRegistroEspecialidad.NotificacionEspecialidad.Show(ObjRegistroEspecialidad, "La especialidad no se ha podido agregar, verifique si la especialidad se repite o consulte al soporte técnico", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Eliminar una especialidad al empleado seleccionado (DELETE), relación de muchos a muchos
        private void EliminarEspecialidadP(object sender, EventArgs e)
        {
            //Indicamos en que posición nos encontramos dentro del DataGridView
            int PosicionFila = ObjRegistroEspecialidad.dgvEspecialidades.CurrentRow.Index;

            if (MessageBox.Show("Bienvenido administrador, está seguro que desea eliminar la especialidad seleccionada en relación al profesional? La acción puede revertirse", "Eliminar Especialidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Instanciamos a la clase DAOAdministrador para obtener los valores
                DAORegistroEspecialidad ObjDAOEliminarEspecialidad = new DAORegistroEspecialidad();

                ObjDAOEliminarEspecialidad.IdEspecialidad = int.Parse(ObjRegistroEspecialidad.dgvEspecialidades[1, PosicionFila].Value.ToString());

                if (ObjDAOEliminarEspecialidad.EliminarEspecialidadProfesional() == true)
                {
                    MessageBox.Show("La especialidad se ha removido correctamente", "Eliminar Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDGVEspecialidades();
                }
            }
        }
        #endregion
        #region Validación de Login después que el profesional haya registrado una especialidad
        private void IngresarLogin(object sender, EventArgs e)
        {
            try
            {
                DAORegistroEspecialidad ObjVerificarEspecialidades = new DAORegistroEspecialidad();
                ObjVerificarEspecialidades.DUIEmpleado1 = ObjRegistroEspecialidad.txtDUIProfesional.Text;

                if (ObjVerificarEspecialidades.VerificarEspecialidad() == false)
                {
                    ObjRegistroEspecialidad.NotificacionEspecialidad.Show(ObjRegistroEspecialidad, "Debe de registrar al menos 1 especialidad", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                }
                else
                {
                    ObjRegistroEspecialidad.NotificacionEspecialidad.Show(ObjRegistroEspecialidad, "Ingreso exitoso", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

                    ObjRegistroEspecialidad.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}