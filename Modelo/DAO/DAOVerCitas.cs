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
        //Este es el método que se utilizara para eliminar una Cita y CONSULTA asociada
        //Es importante saber que, si se elimina una cita, se eliminará la cunsulta para mantener un orden estático
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        //Este es el método común para cargar datos en un DataGridView
        public DataTable CargarDataGridVerCitas()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Iniciamos el tipo de comando
                string consultaSQLLLenarDGVCitas = "SELECT * FROM vistaCitasAgendadas";

                //Llenamos el comando
                SqlCommand ObjComandoSQLServerDGVCitas = new SqlCommand(consultaSQLLLenarDGVCitas, Conexion.Connection);

                //Creamos las variables necesarias para el nuevo SqlDataAdapter
                SqlDataAdapter ObjLlenarAdaptador = new SqlDataAdapter(ObjComandoSQLServerDGVCitas);
                //Creamos una instancia del nuevo DataTable
                DataTable ObjCargarData = new DataTable();

                //Llenamos el DataTable
                ObjLlenarAdaptador.Fill(ObjCargarData);

                //Retornamos el DataTable
                return ObjCargarData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}