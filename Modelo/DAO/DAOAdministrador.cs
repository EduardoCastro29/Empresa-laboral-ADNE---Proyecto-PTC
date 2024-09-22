using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOAdministrador : DTOAdministrador
    {
        //Inicializamos la conexión
        readonly SqlCommand Conexion = new SqlCommand();

        //Este es el método común para agregar empleado y usuario asociado
        public bool AgregarEmpleadoUsuario()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                string consultaSQLUsuario = "INSERT INTO Usuario (nombreUsuario, contraseña, correoElectronico)\r\nOUTPUT INSERTED.usuarioId VALUES \r\n(@nombreUsuario, @contraseña, @correoElectronico)";

                SqlCommand ObjComandoSQLServerUsuario = new SqlCommand(consultaSQLUsuario, Conexion.Connection);

                ObjComandoSQLServerUsuario.Parameters.AddWithValue("@nombreUsuario", Usuario);
                ObjComandoSQLServerUsuario.Parameters.AddWithValue("@contraseña", Contraseña);
                ObjComandoSQLServerUsuario.Parameters.AddWithValue("@correoElectronico", Correo);

                int UsuarioID = (int)ObjComandoSQLServerUsuario.ExecuteScalar();

                //Si el UsuarioID insertado fue mayor a 0, es decir, hay un usuario insertado con el ID encontrado
                //Ingresamos los datos del empleado
                if (UsuarioID > 0)
                {
                    //Si todo salio bien, insertamos lo datos del empleado
                    try
                    {
                        //Creamos el query
                        string consultaSQLProfesional = "INSERT INTO Profesional(DUI, telefono, nombre, apellido, correoElectronico, foto, desempenoId, usuarioId)\r\nVALUES \r\n(@DUI, @telefono, @nombre, @apellido, @correoElectronico, @foto, @desempenoId, @usuarioId)";

                        //Le mandamos la consulta a SQL por medio de un comando
                        SqlCommand ObjComandoSQLServer = new SqlCommand(consultaSQLProfesional, Conexion.Connection);

                        //Añadimos los valores
                        ObjComandoSQLServer.Parameters.AddWithValue("@DUI", Dui);
                        ObjComandoSQLServer.Parameters.AddWithValue("@telefono", Telefono);
                        ObjComandoSQLServer.Parameters.AddWithValue("@nombre", Nombres);
                        ObjComandoSQLServer.Parameters.AddWithValue("@apellido", Apellidos);
                        ObjComandoSQLServer.Parameters.AddWithValue("@correoElectronico", Correo);
                        ObjComandoSQLServer.Parameters.AddWithValue("@foto", Imagen);
                        ObjComandoSQLServer.Parameters.AddWithValue("@desempenoId", DesempenoId);
                        //Insertamos el ID del usuario antes creado
                        ObjComandoSQLServer.Parameters.AddWithValue("@usuarioId", UsuarioID);

                        //Si el número de filas afectadas fueron existosas, retornamos verdadero
                        if (ObjComandoSQLServer.ExecuteNonQuery() > 0)
                            return true;
                        //En caso contrario, retornamos falso
                        else return false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error, ERR-001-1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-001-1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        //Este es el método común para actualizar los datos del usuario asociado Y EMPLEADO
        public bool ActualizarRestablecerContra()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Inicializamos la consulta
                string consultaSQLUsuario = "UPDATE Usuario SET contraseña = @contraseña WHERE usuarioId = @usuarioId";

                SqlCommand ObjComandoSQLServerUsuario = new SqlCommand(consultaSQLUsuario, Conexion.Connection);

                ObjComandoSQLServerUsuario.Parameters.AddWithValue("@contraseña", Contraseña);
                ObjComandoSQLServerUsuario.Parameters.AddWithValue("@usuarioId", UsuarioId);

                if (ObjComandoSQLServerUsuario.ExecuteNonQuery() > 0)
                    return true;
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-003-2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        //Este es el método común para eliminar los datos del usuario asociado Y EMPLEADO
        //Es importante saber que, si se elimina el usuario, se elimina el empleado asociado
        //Para eso, usaremos una propiedad llamada ON DELETE CASCADE, la cuál nos permitirá eliminar el usuario y empleado relacionados
        public bool EliminarUsuarioEmpleado()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Inicializamos el query
                string consultaSQLEliminarUsuario = "DELETE FROM Usuario WHERE usuarioId = @usuarioId";

                SqlCommand ObjComandoSQLServerEliminarU = new SqlCommand(consultaSQLEliminarUsuario, Conexion.Connection);

                ObjComandoSQLServerEliminarU.Parameters.AddWithValue("@usuarioId", UsuarioId);

                //Si la consulta fue existosa, retornamos verdadero
                if (ObjComandoSQLServerEliminarU.ExecuteNonQuery() > 0)
                    return true;
                //Caso contrario, retornamos falso
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-004-1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        //Este es el método común para cargar datos en un DataGridView
        public DataTable CargarDataGrid()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Iniciamos el tipo de comando
                string consultaSQLLLenarDGV = "SELECT * FROM vistaProfesionalDGV";

                //Llenamos el comando
                SqlCommand ObjComandoSQLServerDGV = new SqlCommand(consultaSQLLLenarDGV, Conexion.Connection);

                //Creamos las variables necesarias para el nuevo SqlDataAdapter
                SqlDataAdapter ObjLlenarAdaptador = new SqlDataAdapter(ObjComandoSQLServerDGV);
                //Creamos una instancia del nuevo DataTable
                DataTable ObjCargarData = new DataTable();

                //Llenamos el DataTable
                ObjLlenarAdaptador.Fill(ObjCargarData);

                //Retornamos el DataTable
                return ObjCargarData;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-011-1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        //Este es el método común para buscar datos dentro de un cuadro TextBox (De formar parametrizada)
        //De esta forma, se evitan casos como la injección SQLServer, donde en algunos casos, puede ser eliminada la base de datos
        public DataTable BuscarProfesionalP(string BuscarProfesional)
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Declaramos la consulta
                string consultaSQL = "SELECT * FROM vistaProfesionalDGV WHERE Nombres LIKE @nombres OR Apellidos LIKE @apellidos OR DUI LIKE @DUI OR [Nombre del Usuario] LIKE @nombreUsuario";

                //Ejecutamos el comando
                SqlCommand ObjCommandSQL = new SqlCommand(consultaSQL, Conexion.Connection);

                ObjCommandSQL.Parameters.AddWithValue("@nombres", "%" + BuscarProfesional + "%");
                ObjCommandSQL.Parameters.AddWithValue("@apellidos", "%" + BuscarProfesional + "%");
                ObjCommandSQL.Parameters.AddWithValue("@DUI", "%" + BuscarProfesional + "%");
                ObjCommandSQL.Parameters.AddWithValue("@nombreUsuario", "%" + BuscarProfesional + "%");

                //Declaramos el adaptador SQL
                SqlDataAdapter ObjAdaptador = new SqlDataAdapter(ObjCommandSQL);
                //Declaramos el DataTable
                DataTable ObjDT = new DataTable();
                //Llenamos el DataTable
                ObjAdaptador.Fill(ObjDT);
                //Retornamos el DT
                return ObjDT;
            }
            catch (Exception)
            {
                //Imprimimos un mensaje de error junto con el retorno nulo
                MessageBox.Show("Ha ocurrido un error, ERR-005-1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                //Cerramos la conexión
                Conexion.Connection.Close();
            }
        }
    }
}