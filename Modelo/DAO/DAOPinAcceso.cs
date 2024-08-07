using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOPinAcceso : DTOPinAcceso
    {
        readonly SqlCommand Conexion = new SqlCommand();
        public DAOPinAcceso VerificarPinAcceso()
        {
            try
            {
                //Abrimos la conexión
                Conexion.Connection = Conectar();

                string consultaSQLPinAcceso = "SELECT * FROM Usuario WHERE pinAcceso = @pinAcceso";

                SqlCommand ObjComandoSQLServer = new SqlCommand(consultaSQLPinAcceso, Conexion.Connection);

                ObjComandoSQLServer.Parameters.AddWithValue("@pinAcceso", PinAcceso);

                ObjComandoSQLServer.CommandType = CommandType.Text;

                SqlDataReader ObjFilasEncontradas = ObjComandoSQLServer.ExecuteReader();

                if (ObjFilasEncontradas.Read() == true)
                {
                    DAOPinAcceso ObjDAOPinAcceso = new DAOPinAcceso();
                    return ObjDAOPinAcceso;
                }
                else
                {
                    return null;
                }
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