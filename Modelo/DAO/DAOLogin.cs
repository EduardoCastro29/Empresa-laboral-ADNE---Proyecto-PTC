using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;

//Libreria para las consultas SQL
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;

//Este using se creó solo, si bien tiene relevancia pero aún no esta definido
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOLogin : DTOLogin
    {
        //Creamos una variable de SQLCommand global para capturar el método conectar de la clase conexión
        //Que posteriormente, abrira la conexión a la base de datos
        readonly SqlCommand Conexion = new SqlCommand();
        public bool Login()
        {
            try
            {
                //Empezamos el código abriendo la conexión a la base de datos con el método Conectar
                //La ejecución es válida y posible de hacer ya que el DTO hereda la clase conexión, caso contrario no se reconocería el método
                Conexion.Connection = Conectar();

                //Este comando es la consulta hecha por SQL Server usando parámetros (DECLARE)
                //El uso de parámetros es para evitar injecciones de SQLSever
                string consultaSQLUsuario = "SELECT * FROM Usuario WHERE nombreUsuario = @nombreUsuario AND contraseña = @contraseña";

                //Creamos el comando de SQLServer para ejecutarlo
                SqlCommand ObjComandoSQLServer = new SqlCommand(consultaSQLUsuario, Conexion.Connection);

                //Añadimos los datos ingresados a los parámetros dadas las sentencias del DTOLogin
                ObjComandoSQLServer.Parameters.AddWithValue("@nombreUsuario", Usuario);
                ObjComandoSQLServer.Parameters.AddWithValue("@contraseña", Contrasena);

                //Indicamos que el tipo de comando a ejecutar es de tipo texto, ya que es de tipo TransactSQL
                //Si fuera procedimiento almacenado, se especificaría el tipo de comando respectivo
                ObjComandoSQLServer.CommandType = CommandType.Text;

                //SQL lee los datos y los ejecuta
                SqlDataReader ObjFilasEncontradas = ObjComandoSQLServer.ExecuteReader();

                //Creamos una variable repetitiva que nos devolverá las variables de inicio de sesión de usuario
                //Respectivamente a la tabla que nosotros estamos haciendo referencia, en este caso la tabla Usuario
                //Mientras la lectura recibida por SQL Server sean las columnas encontradas
                //Guardaremos los valores en los campos dentro de la tabla (SQL), recordando que siempre inicia desde 0 el orden de las columnas
                while (ObjFilasEncontradas.Read())
                {
                    //El ID del USUARIO se encuentra en la posición 0
                    InicioSesion.UsuarioId = ObjFilasEncontradas.GetInt32(0);
                    //El nombre de USUARIO se encuentra en la posición 1
                    InicioSesion.Usuario = ObjFilasEncontradas.GetString(1);
                    InicioSesion.Contraseña = ObjFilasEncontradas.GetString(2);
                    InicioSesion.Correo = ObjFilasEncontradas.GetString(3);
                }

                //Retornamos si la sentencia SQLServer encontró filas, caso contrario retornará false
                return ObjFilasEncontradas.HasRows;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-002-6", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                //Cerramos la conexión independientemente se haya hecho el proceso o no
                //En cualquier sentencia de SQL Server siempre se tiene que cerrar la conexión después de una ejecución
                Conexion.Connection.Close();
            }
        }
        //Este es el método que se utilizará para los valores dentro del inicio de sesión del empleado
        public bool LoginEmpleado()
        {
            try
            {
                Conexion.Connection = Conectar();

                //Hacemos referencia a la vistaProfesional creada en la base de datos 
                string consultaSQLProfesional = "SELECT * FROM vistaProfesional WHERE [Nombre del Usuario] = @nombreUsuario";

                //Creamos el comando
                SqlCommand ObjComandoSQLServer = new SqlCommand(consultaSQLProfesional, Conexion.Connection);

                //Añadimos los valores
                ObjComandoSQLServer.Parameters.AddWithValue("@nombreUsuario", InicioSesion.Usuario);

                //Indicamos el tipo de comando
                ObjComandoSQLServer.CommandType = CommandType.Text;

                //SqlDataReader leera los datos encontrados
                SqlDataReader ObjFilasEncontradas = ObjComandoSQLServer.ExecuteReader();

                //Procedemos a guardar las variables de inicio de sesión del profesional
                while (ObjFilasEncontradas.Read())
                {
                    //El DUI se encuentra en la posición 0
                    InicioSesion.Dui = ObjFilasEncontradas.GetString(0);
                    InicioSesion.Telefono = ObjFilasEncontradas.GetString(1);
                    InicioSesion.NombresApellidos = ObjFilasEncontradas.GetString(2);
                    InicioSesion.Imagen = ObjFilasEncontradas.GetString(3);
                    InicioSesion.DesempenoId = ObjFilasEncontradas.GetString(4);
                    InicioSesion.Usuario = ObjFilasEncontradas.GetString(5);
                    InicioSesion.Especialidad = ObjFilasEncontradas.GetString(6);
                }

                //Retornamos las filas encontradas por SQLServer
                return ObjFilasEncontradas.HasRows;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-011-4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        //Creamos un método para verificar si ya hay usuarios en la base de datos
        public bool VerificarUsuario()
        {
            try
            {
                //Abrimos la conexión a la base de datos
                Conexion.Connection = Conectar();

                //Creamos la consulta a SQLServer que nos indicará si hay usuarios registrados en la base de datos
                string consultaSQLUsuario = "SELECT * FROM Usuario";

                //Creamos el comando SQL
                SqlCommand ObjComandoSQLServer = new SqlCommand(consultaSQLUsuario, Conexion.Connection);

                //Creamos el lector de SQL
                SqlDataReader ObjFilasEncontradas = ObjComandoSQLServer.ExecuteReader();

                if (ObjFilasEncontradas.Read() == true)
                {
                    //Si SQLServer encontró usuarios dentro de la base de datos, se retorna verdadero
                    return true;
                }
                else
                {
                    //En caso contrario, se retorna falso
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-002-7", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                //Independientemente se haya echo el proceso o no, cerramos la conexión
                Conexion.Connection.Close();
            }
        }
    }
}