using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAODireccionGmail : Conexion
    {
        readonly SqlCommand Conexion = new SqlCommand();

        //Creamos una variable que nos capturará el pin creado por la libreria Random
        public static string GuardarCodigoRandom;

        //Este método se utilizará para la recuperación de contraseñas dentro de la empresa
        public string RecuperaContraseña(string solicitudUsuario)
        {
            try
            {
                Conexion.Connection = Conectar();

                string consultaSQL = "SELECT * FROM Usuario WHERE nombreUsuario = @nombreUsuario OR correoElectronico = @correoElectronico";

                SqlCommand ObjComandoSQLServer = new SqlCommand(consultaSQL, Conexion.Connection);

                ObjComandoSQLServer.Parameters.AddWithValue("@nombreUsuario", solicitudUsuario);
                ObjComandoSQLServer.Parameters.AddWithValue("@correoElectronico", solicitudUsuario);

                SqlDataReader ObjFilasEncontradas = ObjComandoSQLServer.ExecuteReader();

                if (ObjFilasEncontradas.Read() == true)
                {
                    //Creamos una variable de tipo random que nos generará un código aleatorio
                    //Al ser enviado por vía correo, mas nó siendo enviado a la base de datos, este código es único y no puede ser descifrado
                    Random ObjNumeroAleatorioPin = new Random();
                    GuardarCodigoRandom = (ObjNumeroAleatorioPin.Next(99999999).ToString());

                    string nombreUsuario = ObjFilasEncontradas.GetString(1);

                    int pinAcceso = int.Parse(GuardarCodigoRandom);

                    string correoUsuario = ObjFilasEncontradas.GetString(3);

                    DAOSistemaSoporte ObjSistemaSoporte = new DAOSistemaSoporte();

                    ObjSistemaSoporte.EnviarCorreo(
                    TemaMail: ("SISTEMA ADNE: Solicitud de recuperación de contraseña"),
                    CuerpoMail: ("Hola, " + nombreUsuario +
                    "\n" + "Haz solicitado recuperar tu contraseña." +
                    "\n" + "Por favor, ingresa el pin de acceso proporcionado por temas de seguridad. " +
                    "\n" + "Tu pin de acceso es: " + pinAcceso +
                    "\n" + "Una vez haya sido ingresado, podrás actualizar tu contraseña." +
                    "\n" + "Esperamos tengas un excelente día." +
                    "\n" + "\n" + "\n" + "ADNE Dev Team"),
                    DirrecionesMail: (new List<string> { correoUsuario })
                    );
                    return ("Hola, " + nombreUsuario +
                           "\n" + "Haz solicitado recuperar tu contraseña" +
                           "\n" + "Revisa tu dirección Gmail correspondiente " +
                           "\n" + "Una vez ingresado el pin de acceso" +
                           "\n" + "Podrás actualizar tu contraseña de forma segura");
                }
                else
                {
                    return ("Lo sentimos. Error al buscar un correo o usuario asociado" +
                           "\n" + "Verifica si tu correo o usuario están escritos correctamente" +
                           "\n" + "Si tienes alguna falla, contacta con tu administrador");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Conectar().Close();
            }
        }
        public string UsuarioSolicitante(string UsuarioSolicitante)
        {
            DAODireccionGmail ObjRecuperarContrasena = new DAODireccionGmail();
            return ObjRecuperarContrasena.RecuperaContraseña(UsuarioSolicitante);
        }
        //Este es el método común para verificar si el usuario o correo existen dentro de la base de datos
        //Antes de pasar a la verificación de ping
        public DAODireccionGmail VerificarCorreoUsuario(string VerificarUsuarioSolicitante)
        {
            try
            {
                Conexion.Connection = Conectar();

                string consultaSQL = "SELECT * FROM Usuario WHERE nombreUsuario = @nombreUsuario OR correoElectronico = @correoElectronico";

                SqlCommand ObjComandoSQLServer = new SqlCommand(consultaSQL, Conexion.Connection);

                ObjComandoSQLServer.Parameters.AddWithValue("@nombreUsuario", VerificarUsuarioSolicitante);
                ObjComandoSQLServer.Parameters.AddWithValue("@correoElectronico", VerificarUsuarioSolicitante);

                ObjComandoSQLServer.CommandType = CommandType.Text;

                SqlDataReader ObjFilasEncontradas = ObjComandoSQLServer.ExecuteReader();

                if (ObjFilasEncontradas.Read() == true)
                {
                    DAODireccionGmail ObjVerificarUsuarioSolicitante = new DAODireccionGmail();
                    return ObjVerificarUsuarioSolicitante;
                }
                else
                {
                    return null;
                }
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