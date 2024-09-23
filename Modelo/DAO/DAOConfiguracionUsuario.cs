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
    internal class DAOConfiguracionUsuario : DTOConfiguracionUsuario
    {
        readonly SqlCommand Conexion = new SqlCommand();
        //Este es el método común dentro del apartado de configuración del usuario
        public bool ActualizarUsuarioConfig()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Inicializamos el query
                string consultaSQLProfesional = "UPDATE Profesional SET " +
                                                "DUI                = @DUI, " +
                                                "telefono           = @telefono, " +
                                                "nombre             = @nombre, " +
                                                "apellido           = @apellido, " +
                                                "correoElectronico  = @correoElectronico, " +
                                                "foto               = @foto " +

                                                "WHERE " +
                                                "DUI = @DUI OR correoElectronico = @correoElectronico";

                //Declaramos el comando
                SqlCommand ObjConsultaSQL = new SqlCommand(consultaSQLProfesional, Conexion.Connection);

                //Inicializamos los parámetros
                ObjConsultaSQL.Parameters.AddWithValue("@DUI", DUI);
                ObjConsultaSQL.Parameters.AddWithValue("@telefono", Telefono);
                ObjConsultaSQL.Parameters.AddWithValue("@nombre", Nombres);
                ObjConsultaSQL.Parameters.AddWithValue("@apellido", Apellidos);
                ObjConsultaSQL.Parameters.AddWithValue("@correoElectronico", Correo);
                ObjConsultaSQL.Parameters.AddWithValue("@foto", Imagen);

                //Si la consulta fue exitosa, procedemos a actualizar los datos del usuario del profesional
                if (ObjConsultaSQL.ExecuteNonQuery() > 0)
                {
                    try
                    {
                        //Consulta
                        string consultaSQLUsuario = "UPDATE Usuario SET nombreUsuario = @nombreUsuario, correoElectronico = @correoElectronico WHERE usuarioId = @usuarioId";

                        //Comando
                        SqlCommand ObjComandoSQLServerUsuario = new SqlCommand(consultaSQLUsuario, Conexion.Connection);

                        //Valores
                        ObjComandoSQLServerUsuario.Parameters.AddWithValue("@nombreUsuario", Usuario);
                        ObjComandoSQLServerUsuario.Parameters.AddWithValue("@correoElectronico", Correo);
                        ObjComandoSQLServerUsuario.Parameters.AddWithValue("@usuarioId", InicioSesion.UsuarioId);

                        if (ObjComandoSQLServerUsuario.ExecuteNonQuery() > 0)
                            return true;
                        else return false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error, ERR-003-6 - Error al actualizar la información del profesional, verifique si existen datos duplicados (Documento, Usuario o Correo). [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error, ERR-003-6 - Error al actualizar la información del profesional, verifique si existen datos duplicados (Documento, Usuario o Correo). [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}