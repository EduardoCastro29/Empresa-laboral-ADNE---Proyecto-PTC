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
                MessageBox.Show("Ha ocurrido un error, ERR-011-7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error, ERR-011-7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}