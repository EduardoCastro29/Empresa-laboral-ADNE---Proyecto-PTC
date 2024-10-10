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
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOActualizarContrasena : DTOActualizarContrasena
    {
        readonly SqlCommand Conexion = new SqlCommand();

        //Declaramos la variable estática para idenfiticar a que usuario se refiere al momento de actualizar la contraseña
        //Por medio del correo electrónico
        readonly string UsuarioCorreoSolicitud = CTRLDireccionGmail.CorreoUsuarioSLC;
        public bool ActualizarContrasenaCorreo()
        {
            if (string.IsNullOrWhiteSpace(UsuarioCorreoSolicitud))
            {
                try
                {
                    Conexion.Connection = Conectar();

                    string comandoSQL = "UPDATE Usuario SET contraseña = @contraseña WHERE nombreUsuario = @nombreUsuario";

                    SqlCommand ObjComandoSQLServer = new SqlCommand(comandoSQL, Conexion.Connection);

                    ObjComandoSQLServer.Parameters.AddWithValue("@contraseña", Contrasena);
                    ObjComandoSQLServer.Parameters.AddWithValue("@nombreUsuario", UsuarioSolicitantePS);

                    ObjComandoSQLServer.ExecuteNonQuery();

                    if (ObjComandoSQLServer.ExecuteNonQuery() > 0)
                        return true;
                    else return false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error, ERR-003-1 - Error al actualizar la contraseña. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    Conexion.Connection.Close();
                }
            }
            else
            {
                try
                {
                    Conexion.Connection = Conectar();

                    string comandoSQL = "UPDATE Usuario SET contraseña = @contraseña WHERE nombreUsuario = @nombreUsuario OR correoElectronico = @correoElectronico";

                    SqlCommand ObjComandoSQLServer = new SqlCommand(comandoSQL, Conexion.Connection);

                    ObjComandoSQLServer.Parameters.AddWithValue("@contraseña", Contrasena);
                    ObjComandoSQLServer.Parameters.AddWithValue("@nombreUsuario", UsuarioCorreoSolicitud);
                    ObjComandoSQLServer.Parameters.AddWithValue("@correoElectronico", UsuarioCorreoSolicitud);

                    ObjComandoSQLServer.ExecuteNonQuery();

                    if (ObjComandoSQLServer.ExecuteNonQuery() > 0)
                        return true;
                    else return false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error, ERR-003-1 - Error al actualizar la contraseña. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    Conexion.Connection.Close();
                }
            }
        }
    }
}