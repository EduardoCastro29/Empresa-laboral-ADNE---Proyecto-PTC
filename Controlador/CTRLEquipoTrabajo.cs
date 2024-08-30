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
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLEquipoTrabajo
    {
        readonly EquipodeTrabajoForm ObjEquipoTrabajoForm;
        AdministradorForm ObjAdministrarUsuarios = null;

        public CTRLEquipoTrabajo(EquipodeTrabajoForm Vista)
        {
            ObjEquipoTrabajoForm = Vista;

            ObjEquipoTrabajoForm.Load += new EventHandler(CargarUCYNivelUsuario);
            ObjEquipoTrabajoForm.btnAdministrarEmpleado.Click += new EventHandler(AdministrarUsuarios);
        }
        private void CargarUCYNivelUsuario(object sender, EventArgs e)
        {
            //Indicamos dado la variable de Inicio de Sesión qué botones son los que se accionarán dado el nivel de Usuario
            switch (InicioSesion.DesempenoId)
            {
                case "Administrador":
                    break;
                case "Empleado":
                    ObjEquipoTrabajoForm.btnAdministrarEmpleado.Enabled = false;
                    break;
                default:
                    break;
            }

            //Creamos una instancia de la clase DAO
            DAOEquipoTrabajo ObjDAOEquipo = new DAOEquipoTrabajo();
            //Creamos una instancia de un DataTable
            DataTable ObjCargarUC = ObjDAOEquipo.CargarControlEmpleados();

            //Creamos un bucle foreach
            foreach (DataRow DataRow in ObjCargarUC.Rows)
            {
                ObjDAOEquipo.DUI = (string)DataRow[0];
                ObjDAOEquipo.NombresApellidos = (string)DataRow[1];
                ObjDAOEquipo.Correo = (string)DataRow[2];
                ObjDAOEquipo.Especialidad = (string)DataRow[3];
                ObjDAOEquipo.EspecialidadAlt = (string)DataRow[4];

                //Instanciamos a la clase UCEmpleado que necesitamos recrear
                Control_Profesional ObjControlProfesional = new Control_Profesional(ObjDAOEquipo);
                //Añadimos los valores
                ObjEquipoTrabajoForm.flpEmpleadosControl.Controls.Add(ObjControlProfesional);
            }
        }
        private void AdministrarUsuarios(object sender, EventArgs e)
        {
            if (ObjAdministrarUsuarios == null || ObjAdministrarUsuarios.IsDisposed)
            {
                ObjAdministrarUsuarios = new AdministradorForm();
                ObjAdministrarUsuarios.Show();
            }
            else
            {
                ObjAdministrarUsuarios.BringToFront();
            }
        }
    }
}