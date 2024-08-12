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
                string ConsultaSqlVerPaciente = "SELECT*FROM vistaPaciente";
                SqlCommand ObjConsultaSql = new SqlCommand(ConsultaSqlVerPaciente, Conexion.Connection);

                SqlDataAdapter ad = new SqlDataAdapter(ObjConsultaSql);
                DataTable dt = new DataTable();

                ad.Fill(dt);
                return dt;
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

        public DataSet BuscarPaciente(string valor)
        {
            try
            {
                Conexion.Connection = Conectar();

                string consulta = $"SELECT * FROM VistaPaciente WHERE [Nombre de Paciente] LIKE '%{valor}%'";

                SqlCommand objComando = new SqlCommand(consulta, Conexion.Connection);

                objComando.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(objComando);
                DataSet dt = new DataSet();

                adapter.Fill(dt, "VistaPaciente");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}