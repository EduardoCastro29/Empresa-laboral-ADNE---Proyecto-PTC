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
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAORegistro : DTORegistro
    {
        readonly SqlCommand Conexion = new SqlCommand();
        public bool RegistroInsertarUsuarioProfesional()
        {
            try
            {
                //Abrimos la conexión
                Conexion.Connection = Conectar();
                //Creamos el query
                string consultaSQLUsuario = "INSERT INTO Usuario (nombreUsuario, contraseña, pinAcceso, correoElectronico)\r\nOUTPUT INSERTED.usuarioId VALUES\r\n(@nombreUsuario, @contraseña, @pinAcceso, @correoElectronico)";
                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand ObjConsultaSQL = new SqlCommand(consultaSQLUsuario, Conexion.Connection);

                //Añadimos los valores
                ObjConsultaSQL.Parameters.AddWithValue("@nombreUsuario", Usuario);
                ObjConsultaSQL.Parameters.AddWithValue("@contraseña", Contraseña);
                ObjConsultaSQL.Parameters.AddWithValue("@pinAcceso", PinAcceso);
                ObjConsultaSQL.Parameters.AddWithValue("@correoElectronico", Correo);

                try
                {
                    //Creamos una variable que nos capturará el ID del usuario creado, que posteriormente se insertará dentro del profesional
                    //La variable usada (int) es para indicarle que es de tipo entero, y que nos retornará el ID creado
                    int UsuarioID = (int)ObjConsultaSQL.ExecuteScalar();

                    //Creamos el query
                    string consultaSQLProfesional = "INSERT INTO Profesional(DUI, telefono, nombre, apellido, foto, desempenoId, usuarioId, especialidadId, especialidadAltId)\r\nVALUES \r\n(@DUI, @telefono, @nombre, @apellido, @foto, @desempenoId, @usuarioId, @especialidadId, @especialidadAltId)";
                    //Le mandamos la consulta a SQL por medio de un comando
                    SqlCommand ObjComandoSQLServer = new SqlCommand(consultaSQLProfesional, Conexion.Connection);

                    //Añadimos los valores
                    ObjComandoSQLServer.Parameters.AddWithValue("@DUI", Dui);
                    ObjComandoSQLServer.Parameters.AddWithValue("@telefono", Telefono);
                    ObjComandoSQLServer.Parameters.AddWithValue("@nombre", Nombres);
                    ObjComandoSQLServer.Parameters.AddWithValue("@apellido", Apellidos);
                    ObjComandoSQLServer.Parameters.AddWithValue("@foto", Imagen);
                    ObjComandoSQLServer.Parameters.AddWithValue("@desempenoId", DesempenoId);
                    //Insertamos el ID del usuario antes creado
                    ObjComandoSQLServer.Parameters.AddWithValue("@usuarioId", UsuarioID);
                    ObjComandoSQLServer.Parameters.AddWithValue("@especialidadId", Especialidad);
                    ObjComandoSQLServer.Parameters.AddWithValue("@especialidadAltId", EspecialidadAlt);

                    //Si el número de filas afectadas fueron existosas, retornamos verdadero
                    if (ObjComandoSQLServer.ExecuteNonQuery() > 0)
                        return true;
                    //En caso contrario, retornamos falso
                    else return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
        //Estos métodos son comunes para cargar combobox
        public DataTable AgregarCMBDesempeno()
        {
            try
            {
                //Abrimos la conexión a SQL Server
                Conexion.Connection = Conectar();
                //Creamos la consulta SQL Server que nos permitira ver los valores dentro de la tabla
                string consultaSQL = "SELECT * FROM Desempeno";
                //Llamamos a SqlDataAdapter pasándole la conexión a la DB y la consulta SQL para el llenado del combobox
                SqlDataAdapter ObjLlenarCombobox = new SqlDataAdapter(consultaSQL, Conexion.Connection);
                //Creamos el datatable que posteriormente recibira la consulta de SqlDataAdapter
                DataTable ObjllenarDT = new DataTable();
                //Llenamos el datatable con los valores encontrados
                ObjLlenarCombobox.Fill(ObjllenarDT);
                //Retornamos los valores dentro del DT
                return ObjllenarDT;
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
        public DataTable AgregarCMBEspecialidad()
        {
            try
            {
                Conexion.Connection = Conectar();
                string consultaSQL = "SELECT * FROM Especialidad";
                SqlDataAdapter ObjLlenarCombobox = new SqlDataAdapter(consultaSQL, Conexion.Connection);
                DataTable ObjllenarDT = new DataTable();
                ObjLlenarCombobox.Fill(ObjllenarDT);
                return ObjllenarDT;
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
        public DataTable AgregarCMBEspecialidadAlt()
        {
            try
            {
                Conexion.Connection = Conectar();
                string consultaSQL = "SELECT * FROM EspecialidadAlt";
                SqlDataAdapter ObjLlenarCombobox = new SqlDataAdapter(consultaSQL, Conexion.Connection);
                DataTable ObjllenarDT = new DataTable();
                ObjLlenarCombobox.Fill(ObjllenarDT);
                return ObjllenarDT;
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