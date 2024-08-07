using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Management;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOActualizarContrasena : DTOActualizarContrasena
    {
        readonly SqlCommand Conexion = new SqlCommand();
        public bool ActualizarContrasena()
        {
            try
            {
                Conexion.Connection = Conectar();

                string comandoSQL = "UPDATE Usuario SET contraseña = @contraseña WHERE usuarioId = @usuarioId";

                SqlCommand ObjComandoSQLServer = new SqlCommand(comandoSQL, Conexion.Connection);

                ObjComandoSQLServer.Parameters.AddWithValue("@contraseña", Contrasena);
                ObjComandoSQLServer.Parameters.AddWithValue("@usuarioId", UsuarioID);

                ObjComandoSQLServer.CommandType = CommandType.Text;

                ObjComandoSQLServer.ExecuteNonQuery();

                if (ObjComandoSQLServer.ExecuteNonQuery() > 0)
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
    }
}