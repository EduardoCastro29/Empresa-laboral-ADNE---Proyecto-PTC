using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo
{
    internal class Conexion
    {
        //Creando el método llamado Conectar como método de encapsulación público
        //De esta forma, puede acceder a otras clases externas para poderse utilizar como herencia de SqlConnection para la conexión de la DB
        public static SqlConnection Conectar()
        {
            try
            {
                //Definiendo las variables de conexión, que en este caso
                //Admitirá una conexión hacia la DB de forma online, quiere decir que la base de datos se trabaja en línea
                //De esta forma, se garantiza el uso del programa de forma general sin tener que modificar sus valores en caso de ser local

                string nombreServidor = "SQL8020.site4now.net"; //Este es el nombre del servidor proporcionado por ASP.NET a la hora de crearse
                string DBNombre = "db_aacf96_adne2024"; //Este es el nombre de la base de datos proporcionado por ASP.NET (credenciales por defecto + el nombre de la base)
                string IDUsuario = "db_aacf96_adne2024_admin"; //Este es el nombre del usuario el cuál maneja todo el funcionamiento por ASP.NET (Es el propietario de la DB)
                string Contraseña = "ADNE2024C#"; //Esta es la contraseña del usuario proporcionado por la misma persona (La que creo la DB y su respectivo usuario)
                SqlConnection ObjConexionOnline = new SqlConnection($"Server = {nombreServidor}; Database = {DBNombre}; User Id = {IDUsuario}; Password = {Contraseña}");

                //Definiendo las variables de conexión
                //string nombreServidor = "Edwin\\SQLEXPRESS"; //Pongan su dirección de SQL Server, en mi caso es esa bv
                //string DBNombre = "ADNE2024"; //Queda igual, ya que es el nombre de la DB

                //Creando objeto ObjConexion de tipo SqlConnection con los datos de la conexión hacia la base de datos
                //SqlConnection ObjConexion = new SqlConnection($"Server = {nombreServidor}; Database = {DBNombre}; Integrated Security = True");

                //Abrimos la conexión
                ObjConexionOnline.Open();

                //Retornamos la conexión
                return ObjConexionOnline;
            }
            catch (Exception ex)
            {
                //En caso de que exista el error se retorna una conexión nula
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}