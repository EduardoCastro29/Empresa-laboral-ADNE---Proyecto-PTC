using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Data;
using System.Windows.Forms;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;
using Microsoft.VisualBasic;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOVerCitas : DTOVerCitas
    {
        readonly SqlCommand Conexion = new SqlCommand();
        
        //Este es el método común para cargar datos en un DataGridView
        public DataTable CargarDataGridVerCitas()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Iniciamos el tipo de comando
                string consultaSQLLLenarDGVCitas = "SELECT * FROM vistaCitasAgendadas WHERE [ID del Profesional] = @DUI ORDER BY [Fecha de la Cita] ASC";

                //Llenamos el comando
                SqlCommand ObjComandoSQLServerDGVCitas = new SqlCommand(consultaSQLLLenarDGVCitas, Conexion.Connection);

                ObjComandoSQLServerDGVCitas.Parameters.AddWithValue("@DUI", InicioSesion.Dui);

                //Creamos las variables necesarias para el nuevo SqlDataAdapter
                SqlDataAdapter ObjLlenarAdaptador = new SqlDataAdapter(ObjComandoSQLServerDGVCitas);
                //Creamos una instancia del nuevo DataTable
                DataTable ObjCargarData = new DataTable();

                //Llenamos el DataTable
                ObjLlenarAdaptador.Fill(ObjCargarData);

                //Retornamos el DataTable
                return ObjCargarData;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-011-6 - Error al mostrar los datos de las citas, verifique si tiene citas registradas. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public DataTable CargarDataGridCitasPendientes()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Iniciamos el tipo de comando donde agregamos el estado pendiente
                string consultaSQLLLenarDGVCitas = "SELECT * FROM vistaCitasAgendadas WHERE [ID del Profesional] = @DUI AND EstadoId = '2' ORDER BY [Fecha de la Cita] ASC";

                //Llenamos el comando
                SqlCommand ObjComandoSQLServerDGVCitas = new SqlCommand(consultaSQLLLenarDGVCitas, Conexion.Connection);

                ObjComandoSQLServerDGVCitas.Parameters.AddWithValue("@DUI", InicioSesion.Dui);

                //Creamos las variables necesarias para el nuevo SqlDataAdapter
                SqlDataAdapter ObjLlenarAdaptador = new SqlDataAdapter(ObjComandoSQLServerDGVCitas);
                //Creamos una instancia del nuevo DataTable
                DataTable ObjCargarData = new DataTable();

                //Llenamos el DataTable
                ObjLlenarAdaptador.Fill(ObjCargarData);

                //Retornamos el DataTable
                return ObjCargarData;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-011-6 - Error al mostrar los datos de las citas, verifique si tiene citas registradas. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public DataTable CargarDataGridCitasAtendidas()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Iniciamos el tipo de comando donde agregamos el estado pendiente
                string consultaSQLLLenarDGVCitas = "SELECT * FROM vistaCitasAgendadas WHERE [ID del Profesional] = @DUI AND EstadoId = '1' ORDER BY [Fecha de la Cita] ASC";

                //Llenamos el comando
                SqlCommand ObjComandoSQLServerDGVCitas = new SqlCommand(consultaSQLLLenarDGVCitas, Conexion.Connection);

                ObjComandoSQLServerDGVCitas.Parameters.AddWithValue("@DUI", InicioSesion.Dui);

                //Creamos las variables necesarias para el nuevo SqlDataAdapter
                SqlDataAdapter ObjLlenarAdaptador = new SqlDataAdapter(ObjComandoSQLServerDGVCitas);
                //Creamos una instancia del nuevo DataTable
                DataTable ObjCargarData = new DataTable();

                //Llenamos el DataTable
                ObjLlenarAdaptador.Fill(ObjCargarData);

                //Retornamos el DataTable
                return ObjCargarData;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-011-6 - Error al mostrar los datos de las citas, verifique si tiene citas registradas. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public DataTable BuscarCitaC(string BuscarCita)
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Declaramos la consulta
                string consultaSQL = "SELECT * FROM vistaCitasAgendadas WHERE [Fecha de la Cita] LIKE @FechaCita OR [Nombre del Paciente] LIKE @NombrePaciente OR [Apellido del Paciente] LIKE @ApellidoPaciente AND [ID del Profesional] = @DUIProfesional";

                //Ejecutamos el comando
                SqlCommand ObjCommandSQL = new SqlCommand(consultaSQL, Conexion.Connection);

                ObjCommandSQL.Parameters.AddWithValue("@FechaCita", "%" + BuscarCita + "%");
                ObjCommandSQL.Parameters.AddWithValue("@NombrePaciente", "%" + BuscarCita + "%");
                ObjCommandSQL.Parameters.AddWithValue("@ApellidoPaciente", "%" + BuscarCita + "%");
                ObjCommandSQL.Parameters.AddWithValue("@DUIProfesional", InicioSesion.Dui);

                //Declaramos el adaptador SQL
                SqlDataAdapter ObjAdaptador = new SqlDataAdapter(ObjCommandSQL);
                //Declaramos el DataTable
                DataTable ObjDT = new DataTable();
                //Llenamos el DataTable
                ObjAdaptador.Fill(ObjDT);
                //Retornamos el DT
                return ObjDT;
            }
            catch (Exception)
            {
                //Imprimimos un mensaje de error junto con el retorno nulo
                MessageBox.Show("Ha ocurrido un error, ERR-005-3 - Error al buscar citas por su identificador (nombre del paciente, apellido o fecha). [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                //Cerramos la conexión
                Conexion.Connection.Close();
            }
        }
        //Este es el método que se utilizara para eliminar una Cita y CONSULTA asociada
        //Es importante saber que, si se elimina una cita, se eliminará la consulta para mantener un orden estático
        //Para eso, usaremos una propiedad llamada ON DELETE CASCADE, la cuál nos permitirá eliminar la cita y la consulta asociada
        public bool EliminarCitaYConsulta()
        {
            try
            {
                Conexion.Connection = Conectar();

                string consultaSQLEliminarUsuario = "DELETE FROM Cita WHERE citaId = @citaId";

                SqlCommand ObjComandoSQLServerEliminarU = new SqlCommand(consultaSQLEliminarUsuario, Conexion.Connection);

                ObjComandoSQLServerEliminarU.Parameters.AddWithValue("@citaId", CitaId);

                if (ObjComandoSQLServerEliminarU.ExecuteNonQuery() > 0)
                    return true;
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-004-3 - Error al eliminar la cita asociada con el paciente. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}