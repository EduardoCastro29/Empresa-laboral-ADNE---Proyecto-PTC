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

                string consultaSQLUsuario = "INSERT INTO Usuario (nombreUsuario, contraseña, pinAcceso, correoElectronico)\r\nOUTPUT INSERTED.usuarioId VALUES \r\n(@nombreUsuario, @contraseña, @pinAcceso, @correoElectronico)";

                SqlCommand ObjComandoSQLServerUsuario = new SqlCommand(consultaSQLUsuario, Conexion.Connection);

                ObjComandoSQLServerUsuario.Parameters.AddWithValue("@nombreUsuario", Usuario);
                ObjComandoSQLServerUsuario.Parameters.AddWithValue("@contraseña", Contraseña);
                ObjComandoSQLServerUsuario.Parameters.AddWithValue("@pinAcceso", PinAcceso);
                ObjComandoSQLServerUsuario.Parameters.AddWithValue("@correoElectronico", Correo);

                int UsuarioId = (int)ObjComandoSQLServerUsuario.ExecuteScalar();

                //Si el UsuarioID insertado fue mayor a 0, es decir, hay un usuario insertado con el ID encontrado
                //Ingresamos los datos del empleado
                if (UsuarioId > 0)
                {
                    try
                    {
                        //Inicializamos la consulta
                        string consultaSQLProfesional = "INSERT INTO Profesional(DUI, telefono, nombre, apellido, correoElectronico, foto, desempenoId, usuarioId, especialidadId, especialidadAltId)\r\nOUTPUT INSERTED.profesionalId VALUES \r\n(@DUI, @telefono, @nombre, @apellido, @correoElectronico, @foto, @desempenoId, @usuarioId, @especialidadId, @especialidadAltId)";

                        //Inicializamos el comando
                        SqlCommand ObjComandoSQLServerProfesional = new SqlCommand(consultaSQLProfesional, Conexion.Connection);

                        //Añadimos los valores
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@DUI", Dui);
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@telefono", Telefono);
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@nombre", Nombres);
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@apellido", Apellidos);
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@correoElectronico", Correo);
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@foto", Imagen);
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@desempenoId", DesempenoId);
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@usuarioId", UsuarioId);
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@especialidadId", Especialidad);
                        ObjComandoSQLServerProfesional.Parameters.AddWithValue("@especialidadAltId", EspecialidadAlt);

                        if (ObjComandoSQLServerProfesional.ExecuteNonQuery() > 0)
                            return true;
                        else return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
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
        //Este es el método común para actualizar los datos del usuario asociado Y EMPLEADO
        public bool ActualizarUsuarioEmpleado()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Inicializamos la consulta
                string consultaSQLProfesional = "UPDATE Profesional SET " +
                                                "DUI				= @DUI, " +
                                                "telefono			= @telefono, " +
                                                "nombre				= @nombre, " +
                                                "apellido			= @apellido, " +
                                                "foto				= @foto, " +
                                                "desempenoId		= @desempenoId, " +
                                                "especialidadId		= @especialidadId, " +
                                                "especialidadAltId	= @especialidadAltId " +

                                                "WHERE " +
                                                "profesionalId = @profesionalId ";
                //Inicializamos el comando
                SqlCommand ObjComandoSQLServerProfesional = new SqlCommand(consultaSQLProfesional, Conexion.Connection);

                //Añadimos los valores
                ObjComandoSQLServerProfesional.Parameters.AddWithValue("@DUI", Dui);
                ObjComandoSQLServerProfesional.Parameters.AddWithValue("@telefono", Telefono);
                ObjComandoSQLServerProfesional.Parameters.AddWithValue("@nombre", Nombres);
                ObjComandoSQLServerProfesional.Parameters.AddWithValue("@apellido", Apellidos);
                ObjComandoSQLServerProfesional.Parameters.AddWithValue("@foto", Imagen);
                ObjComandoSQLServerProfesional.Parameters.AddWithValue("@desempenoId", DesempenoId);
                ObjComandoSQLServerProfesional.Parameters.AddWithValue("@especialidadId", Especialidad);
                ObjComandoSQLServerProfesional.Parameters.AddWithValue("@especialidadAltId", EspecialidadAlt);
                ObjComandoSQLServerProfesional.Parameters.AddWithValue("@profesionalId", ProfesionalId);

                if (ObjComandoSQLServerProfesional.ExecuteNonQuery() > 0)
                {
                    try
                    {
                        string consultaSQLUsuario = "UPDATE Usuario SET nombreUsuario = @nombreUsuario, contraseña = @contraseña, correoElectronico = @correoElectronico WHERE usuarioId = @usuarioId";

                        SqlCommand ObjComandoSQLServerUsuario = new SqlCommand(consultaSQLUsuario, Conexion.Connection);

                        ObjComandoSQLServerUsuario.Parameters.AddWithValue("@nombreUsuario", Usuario);
                        ObjComandoSQLServerUsuario.Parameters.AddWithValue("@contraseña", Contraseña);
                        ObjComandoSQLServerUsuario.Parameters.AddWithValue("@correoElectronico", Correo);
                        ObjComandoSQLServerUsuario.Parameters.AddWithValue("@usuarioId", UsuarioId);

                        if (ObjComandoSQLServerUsuario.ExecuteNonQuery() > 0)
                            return true;
                        else return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
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
