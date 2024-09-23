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
    internal class DAOInformacionEncargado : DTOInformacionEncargado
    {
        readonly SqlCommand Conexion = new SqlCommand();
        public static string DocumentoEncargado;
        public bool RegistrarEncargado()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Inicializamos la consulta
                string consultaSQLRegistrarENC = "INSERT INTO EncargadoPaciente (documentoPresentado, nombre, apellido, fechaNacimiento, edad, telefono, correoElectronico, domicilio, relacionEncargadoId) VALUES (@documentoPresentado, @nombre, @apellido, @fechaNacimiento, @edad, @telefono, @correoElectronico, @domicilio, @relacionEncargadoId)";

                //Declaramos el comando
                SqlCommand ObjConsultaSQL = new SqlCommand(consultaSQLRegistrarENC, Conexion.Connection);

                //Inicializamos los parámetros
                ObjConsultaSQL.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);
                ObjConsultaSQL.Parameters.AddWithValue("@nombre", Nombre);
                ObjConsultaSQL.Parameters.AddWithValue("@apellido", Apellido);
                ObjConsultaSQL.Parameters.AddWithValue("@fechaNacimiento", FechaNacimiento);
                ObjConsultaSQL.Parameters.AddWithValue("@edad", Edad);
                ObjConsultaSQL.Parameters.AddWithValue("@telefono", Telefono);
                ObjConsultaSQL.Parameters.AddWithValue("@correoElectronico", CorreoElectronico);
                ObjConsultaSQL.Parameters.AddWithValue("@domicilio", Domicilio);
                //ObjConsultaSQL.Parameters.AddWithValue("@documentoPresentadoP", DocumentoPresentadoP);
                ObjConsultaSQL.Parameters.AddWithValue("@relacionEncargadoId", RelacionEncargadoId);

                //Ejecutamos el comando
                if (ObjConsultaSQL.ExecuteNonQuery() > 0)
                {
                    DocumentoEncargado = DocumentoPresentado;
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-001-8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public bool VerEncargado()
        {
            try
            {
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Inicializamos la consulta
                string consultaSQLRegistrarENC = "SELECT * FROM EncargadoPaciente WHERE documentoPresentadoP = @documentoPresentadoP";

                //Declaramos el comando
                SqlCommand ObjConsultaSQL = new SqlCommand(consultaSQLRegistrarENC, Conexion.Connection);

                ObjConsultaSQL.Parameters.AddWithValue("@documentoPresentadoP", DocumentoPresentadoP);

                //Leemos las filas
                SqlDataReader ObjLecuturaSQL = ObjConsultaSQL.ExecuteReader();

                //Ejecutamos el comando
                while (ObjLecuturaSQL.Read())
                {
                    DocumentoPresentado = ObjLecuturaSQL.GetString(0);
                    Nombre = ObjLecuturaSQL.GetString(1);
                    Apellido = ObjLecuturaSQL.GetString(2);
                    FechaNacimiento = (DateTime)ObjLecuturaSQL.GetValue(3);
                    Edad = ObjLecuturaSQL.GetInt32(4);
                    Telefono = ObjLecuturaSQL.GetString(5);
                    CorreoElectronico = ObjLecuturaSQL.GetString(6);
                    Domicilio = ObjLecuturaSQL.GetString(7);
                    RelacionEncargadoId = ObjLecuturaSQL.GetInt32(9);
                }
                return ObjLecuturaSQL.HasRows;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-003-5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        //public bool ActualizarEncargado()
        //{
        //    try
        //    {
        //        //Inicializamos la conexión
        //        Conexion.Connection = Conectar();

        //        //Inicializamos la consulta
        //        string consultaSQLRegistrarENC = "UPDATE EncargadoPaciente SET " +
        //                                         "nombre					= @nombre, " +
        //                                         "apellido				    = @apellido, " +
        //                                         "fechaNacimiento			= @fechaNacimiento, " +
        //                                         "edad					    = @edad, " +
        //                                         "telefono				    = @telefono, " +
        //                                         "correoElectronico		    = @correoElectronico, " +
        //                                         "domicilio				    = @domicilio, " +
        //                                         "documentoPresentadoP	    = @documentoPresentadoP, " +
        //                                         "relacionEncargadoId		= @relacionEncargadoId " +
 
        //                                         "WHERE " +
        //                                         "documentoPresentado = @documentoPresentado";

        //        //Declaramos el comando
        //        SqlCommand ObjConsultaSQL = new SqlCommand(consultaSQLRegistrarENC, Conexion.Connection);

        //        //Inicializamos los parámetros
        //        ObjConsultaSQL.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);
        //        ObjConsultaSQL.Parameters.AddWithValue("@nombre", Nombre);
        //        ObjConsultaSQL.Parameters.AddWithValue("@apellido", Apellido);
        //        ObjConsultaSQL.Parameters.AddWithValue("@fechaNacimiento", FechaNacimiento);
        //        ObjConsultaSQL.Parameters.AddWithValue("@edad", Edad);
        //        ObjConsultaSQL.Parameters.AddWithValue("@telefono", Telefono);
        //        ObjConsultaSQL.Parameters.AddWithValue("@correoElectronico", CorreoElectronico);
        //        ObjConsultaSQL.Parameters.AddWithValue("@domicilio", Domicilio);
        //        ObjConsultaSQL.Parameters.AddWithValue("@documentoPresentadoP", DocumentoPresentadoP);
        //        ObjConsultaSQL.Parameters.AddWithValue("@relacionEncargadoId", RelacionEncargadoId);

        //        //Ejecutamos el comando
        //        if (ObjConsultaSQL.ExecuteNonQuery() > 0)
        //            return true;
        //        else return false;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Ha ocurrido un error, ERR-003-5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    finally
        //    {
        //        Conexion.Connection.Close();
        //    }
        //}
        public DataTable AgregarCMBEncargado()
        {
            try
            {
                Conexion.Connection = Conectar();
                string consultaSQL = "SELECT * FROM RelacionEncargado";
                SqlDataAdapter ObjLlenarCombobox = new SqlDataAdapter(consultaSQL, Conexion.Connection);
                DataTable ObjllenarDT = new DataTable();
                ObjLlenarCombobox.Fill(ObjllenarDT);
                return ObjllenarDT;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-008-6", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}