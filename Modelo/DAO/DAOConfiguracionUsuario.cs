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
    internal class DAOConfiguracionUsuario
    {
        readonly SqlCommand Conexion = new SqlCommand();
        //Este es el método común dentro del apartado de configuración del usuario
        public bool ActualizarUsuarioConfig()
        {
            try
            {
                //Inicializamos la conexión
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-003-6", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}