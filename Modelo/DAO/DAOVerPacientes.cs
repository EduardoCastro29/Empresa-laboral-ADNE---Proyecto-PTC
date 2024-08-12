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
        readonly SqlCommand conexion = new SqlCommand();
        public DataTable VerPacientes()
        {
            try
            {
                conexion.Connection = Conectar();
                string ConsultaSqlVerPaciente = "SELECT*FROM vistaPaciente";
                SqlCommand ObjConsultaSql = new SqlCommand(ConsultaSqlVerPaciente, conexion.Connection);

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
                conexion.Connection.Close();
            }
        }
    }
}