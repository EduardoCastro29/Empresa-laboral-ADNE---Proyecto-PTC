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
    internal class DAOEquipoTrabajo : DTOEquipoTrabajo
    {
        //Inicializamos la conexión
        readonly SqlCommand Conexion = new SqlCommand();

        //Este método es común para cargar datos (en este caso datos específicos)
        //En controles de usuario
        public DataTable CargarControlEmpleados()
        {
            try
            {
                Conexion.Connection = Conectar();

                //Inicializamos la cadena
                string consultaSQLCargarProfesional = "SELECT * FROM vistaDataTable";

                //Inicializamos el comando
                SqlCommand ObjComandoSQLServerUC = new SqlCommand(consultaSQLCargarProfesional, Conexion.Connection);

                //Creamos un SqlDataAdapter
                SqlDataAdapter ObjAdaptador = new SqlDataAdapter(ObjComandoSQLServerUC);
                //Instanciamos a la clase DataTable
                DataTable ObjLlenarUC = new DataTable();

                //Llenamos el DataTable
                ObjAdaptador.Fill(ObjLlenarUC);
                //Retornamos el DataTable
                return ObjLlenarUC;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-002-2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}