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

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOVerPacientes : DTOVerPacientes
    {
        readonly SqlCommand Conexion = new SqlCommand();
        public DataTable VerPacientes()
        {
            try
            {
                Conexion.Connection = Conectar();
                string ConsultaSqlVerPaciente = "SELECT * FROM vistaPaciente WHERE DUI = @DUI";
                SqlCommand ObjConsultaSql = new SqlCommand(ConsultaSqlVerPaciente, Conexion.Connection);
                ObjConsultaSql.Parameters.AddWithValue("@DUI", InicioSesion.Dui);
                SqlDataAdapter ad = new SqlDataAdapter(ObjConsultaSql);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-011-7 - Error al mostrar los datos del paciente (nombre, botones de informacion y expediente). [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        //Este es el método común para ver pacientes que como tal, no tienen un profesional asignado por ser elimnado dentro del sistema
        public DataTable VerPacientesSinProfesional()
        {
            try
            {
                Conexion.Connection = Conectar();
                string ConsultaSqlVerPacienteSinPR = "SELECT * FROM vistaPaciente WHERE DUI IS NULL";
                SqlCommand ObjConsultaSql = new SqlCommand(ConsultaSqlVerPacienteSinPR, Conexion.Connection);
                SqlDataAdapter ad = new SqlDataAdapter(ObjConsultaSql);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-011-8 - Error al mostrar los datos que no poseen un profesional asignado. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public DataSet BuscarPaciente(string BuscarPacienteP)
        {
            try
            {
                Conexion.Connection = Conectar();

                string consulta = "SELECT * FROM vistaPaciente WHERE [Nombre de Paciente] LIKE @nombrePaciente";

                SqlCommand objComando = new SqlCommand(consulta, Conexion.Connection);

                objComando.Parameters.AddWithValue("@nombrePaciente", "%" + BuscarPacienteP + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(objComando);
                DataSet dt = new DataSet();

                adapter.Fill(dt, "vistaPaciente");
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-005-4 - Error al buscar un paciente por su identificador (nombre). [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}