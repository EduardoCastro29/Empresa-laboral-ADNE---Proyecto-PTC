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

            CargarDGVEspecialidades();
            ObjRegistroEspecialidad.Load += new EventHandler(CargarEspecialidades);
            ObjRegistroEspecialidad.btnAnadirEspecialidad.Click += new EventHandler(AgregarEspecialidad);
            ObjRegistroEspecialidad.btnSiguiente.Click += new EventHandler(IngresarLogin);
        }
        private void CargarDGVEspecialidades()
        {
            DAORegistroEspecialidad ObjCargarGrid = new DAORegistroEspecialidad();

            ObjRegistroEspecialidad.dgvEspecialidades.DataSource = null;
            ObjRegistroEspecialidad.dgvEspecialidades.DataSource = ObjCargarGrid.CargarDGVEspecialidadesN();
            //Indicamos que columnas no queremos que se muestren a simple vista
            ObjRegistroEspecialidad.dgvEspecialidades.Columns[0].Visible = false;
        }
        private void CargarEspecialidades(object sender, EventArgs e)
        {
            DAORegistroEspecialidad ObjDAOCargarEspecialidad = new DAORegistroEspecialidad();

            //Combobox Especialidad 
            ObjRegistroEspecialidad.cmbEspecialidades.DataSource = ObjDAOCargarEspecialidad.AgregarCMBEspecialidad();
            ObjRegistroEspecialidad.cmbEspecialidades.ValueMember = "especialidadId"; //Agregamos los atributos que estan en la tabla Especialidad
            ObjRegistroEspecialidad.cmbEspecialidades.DisplayMember = "nombreEspecialidad";
        }
        private void AgregarEspecialidad(object sender, EventArgs e)
        {
            try
            {
                DAORegistroEspecialidad ObjInsertarEspecialidad = new DAORegistroEspecialidad();

                ObjInsertarEspecialidad.DUIEmpleado1 = ObjRegistroEspecialidad.txtDUIProfesional.Text.Trim();
                ObjInsertarEspecialidad.IdEspecialidadNombre = int.Parse(ObjRegistroEspecialidad.cmbEspecialidades.SelectedValue.ToString());

                if (ObjInsertarEspecialidad.RegistrarEspecialidadEmpleado() == true)
                {
                    MessageBox.Show("La especialidad se ha agregado correctamente", "Especialidad del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDGVEspecialidades();
                }
                else
                {
                    MessageBox.Show("La especialidad no se ha podido agregar, consulte a su soporte ténico", "Especialidad del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void IngresarLogin(object sender, EventArgs e)
        {
            try
            {
                DAORegistroEspecialidad ObjVerificarEspecialidades = new DAORegistroEspecialidad();
                ObjVerificarEspecialidades.DUIEmpleado1 = ObjRegistroEspecialidad.txtDUIProfesional.Text;

                if (ObjVerificarEspecialidades.VerificarEspecialidad() == false)
                {
                    MessageBox.Show("Debe de registrar al menos 1 especialidad", "Registro de Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ingreso exitoso", "Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjRegistroEspecialidad.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}