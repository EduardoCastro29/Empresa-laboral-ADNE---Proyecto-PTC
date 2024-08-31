using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Data;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAORegistroEspecialidad : DTORegistroEspecialidad
    {
        readonly SqlCommand Conexion = new SqlCommand();
        public bool RegistrarEspecialidadEmpleado()
        {
            try
            {
                Conexion.Connection = Conectar();

                string InsertarEspecialidadE = "INSERT INTO NombreEspecialidades (DUI, especialidadId)\r\nVALUES \r\n(@DUI, @especialidadId)";

                SqlCommand ObjInsertarEspecialidad = new SqlCommand(InsertarEspecialidadE, Conexion.Connection);

                ObjInsertarEspecialidad.Parameters.AddWithValue("@DUI", DUIEmpleado1);
                ObjInsertarEspecialidad.Parameters.AddWithValue("@especialidadId", IdEspecialidadNombre);

                if (ObjInsertarEspecialidad.ExecuteNonQuery() > 0)
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
        public bool VerificarEspecialidad()
        {
            try
            {
                Conexion.Connection = Conectar();

                string VerificarEspecialidades = "SELECT * FROM NombreEspecialidades WHERE DUI = @DUI";

                SqlCommand ObjComandoSQLVerificar = new SqlCommand(VerificarEspecialidades, Conexion.Connection);

                ObjComandoSQLVerificar.Parameters.AddWithValue("@DUI", DUIEmpleado1);

                SqlDataReader ObjFilasEncontradas = ObjComandoSQLVerificar.ExecuteReader();

                if (ObjFilasEncontradas.Read() == true)
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
        public DataTable CargarDGVEspecialidadesN()
        {
            try
            {
                Conexion.Connection = Conectar();
                string consultaSQL = "SELECT * FROM vistaEspecialidades";
                SqlDataAdapter ObjLlenarCombobox = new SqlDataAdapter(consultaSQL, Conexion.Connection);
                DataTable ObjllenarDT = new DataTable();
                ObjLlenarCombobox.Fill(ObjllenarDT);
                return ObjllenarDT;
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
        public DataTable AgregarCMBEspecialidad()
        {
            try
            {
                Conexion.Connection = Conectar();
                string consultaSQL = "SELECT * FROM Especialidad";
                SqlDataAdapter ObjLlenarCombobox = new SqlDataAdapter(consultaSQL, Conexion.Connection);
                DataTable ObjllenarDT = new DataTable();
                ObjLlenarCombobox.Fill(ObjllenarDT);
                return ObjllenarDT;
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