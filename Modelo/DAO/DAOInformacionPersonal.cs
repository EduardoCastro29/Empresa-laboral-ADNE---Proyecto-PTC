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
    internal class DAOInformacionPersonal : DTOInformacionPersonal
    {
        readonly SqlCommand conexion = new SqlCommand();
        public bool InsertarInformacionPaciente()
        {
            try
            {
                //Abrimos la conexion 
                conexion.Connection = Conectar();
                // Se crea el query 
                string consultaSqlPaciente = "INSERT INTO Paciente(pacienteId, fechaNacimiento, nombre, apellido, domicilio, nacionalidad, documentoPresentado, correoElectronico, telefono, profesion, edad, composicionFamiliar, motivo, antecedente,descripcionSituacion,aspectosPreocupantes, generoId)\r\nVALUES\r\n(@pacienteId, @fechaNacimiento, @nombre, @apellido, @domicilio, @nacionalidad, @documentoPresentado, @correoElectronico, @telefono, @profesion, @edad, @composicionFamiliar, @motivo, @antecedente, @descripcionSituacion, @aspectosPreocupantes,@generoId)";
                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand objConsultaSql = new SqlCommand(consultaSqlPaciente, conexion.Connection);

                // Se añaden los valores 
                objConsultaSql.Parameters.AddWithValue("pacienteId", PacienteId);
                objConsultaSql.Parameters.AddWithValue("@fechaNacimiento", FechaNacimiento);
                objConsultaSql.Parameters.AddWithValue("@nombre", Nombre);
                objConsultaSql.Parameters.AddWithValue("@apellido", Apellido);
                objConsultaSql.Parameters.AddWithValue("@domicilio", Domicilio);
                objConsultaSql.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                objConsultaSql.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);
                objConsultaSql.Parameters.AddWithValue("@correoElectronico", CorreoElectronico);
                objConsultaSql.Parameters.AddWithValue("@telefono", Telefono);
                objConsultaSql.Parameters.AddWithValue("@profesion", Profesion);
                objConsultaSql.Parameters.AddWithValue("@edad", Edad);
                objConsultaSql.Parameters.AddWithValue("@composicionFamiliar", ComposicionFamiliar);
                objConsultaSql.Parameters.AddWithValue("@motivo", Motivo);
                objConsultaSql.Parameters.AddWithValue("@antecedente", Antecedente);
                objConsultaSql.Parameters.AddWithValue("@descripcionSituacion", Descripcion);
                objConsultaSql.Parameters.AddWithValue("@aspectosPreocupantes", AspectosPreocupantes);
                objConsultaSql.Parameters.AddWithValue("@generoId", GeneroId1);
                objConsultaSql.Parameters.AddWithValue("@expedienteId", ExpedienteId);

                //Si el número de filas afectadas fueron existosas, retornamos verdadero
                if (objConsultaSql.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    //En caso contrario, retornamos falso
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
                //Independientemente se haga o no el proceso cerramos la conexión

                conexion.Connection.Close();
            }
        }
        public bool ObtenerInformacionPaciente()
        {
            try
            {
                //Abrimos la conexion 
                conexion.Connection = Conectar();
                // Se crea el query
                string consultaSqlActualizarPaciente = "SELECT * FROM Paciente WHERE pacienteId = @pacienteId";

                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand objConsultaActualizar = new SqlCommand(consultaSqlActualizarPaciente, conexion.Connection);

                // Se añaden los valores 

                objConsultaActualizar.Parameters.AddWithValue("@pacienteId", PacienteId);

                //Si el número de filas afectadas fueron existosas, retornamos verdadero
                objConsultaActualizar.CommandType = CommandType.Text;

                //SQL lee los datos y los ejecuta
                SqlDataReader ObjFilasEncontradas = objConsultaActualizar.ExecuteReader();
                while (ObjFilasEncontradas.Read())
                {
                    PacienteId = ObjFilasEncontradas.GetInt32(0);
                    FechaNacimiento = ObjFilasEncontradas.GetDateTime(1);
                    Nombre = ObjFilasEncontradas.GetString(2);
                    Apellido = ObjFilasEncontradas.GetString(3);
                    Domicilio = ObjFilasEncontradas.GetString(4);
                    Nacionalidad = ObjFilasEncontradas.GetString(5);
                    DocumentoPresentado = ObjFilasEncontradas.GetString(6);
                    CorreoElectronico = ObjFilasEncontradas.GetString(7);
                    Telefono = ObjFilasEncontradas.GetString(8);
                    Profesion = ObjFilasEncontradas.GetString(9);
                    Edad = ObjFilasEncontradas.GetInt32(10);
                    ComposicionFamiliar = ObjFilasEncontradas.GetString(11);
                    Motivo = ObjFilasEncontradas.GetString(12);
                    Antecedente = ObjFilasEncontradas.GetString(13);
                    Descripcion = ObjFilasEncontradas.GetString(14);
                    AspectosPreocupantes = ObjFilasEncontradas.GetString(15);
                    GeneroId1 = ObjFilasEncontradas.GetInt32(16);
                }
                return ObjFilasEncontradas.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                conexion.Connection.Close();
            }
        }
        public bool ActualizarInformacionPaciente()
        {
            try
            {
                //Abrimos la conexion 
                conexion.Connection = Conectar();
                // Se crea el query
                string consultaSqlActualizarPaciente = "UPDATE Paciente SET\r\nfechaNacimiento\t\t= @fechaNacimiento,\r\nnombre\t\t\t\t= @nombre,\r\napellido\t\t\t= @apellido,\r\ndomicilio\t\t\t= @domicilio,\r\nnacionalidad\t\t= @nacionalidad,\r\ndocumentoPresentado\t= @documentoPresentado,\r\ncorreoElectronico\t= @correoElectronico,\r\ntelefono\t\t\t= @telefono,\r\nprofesion\t\t\t= @profesion,\r\nedad\t\t\t\t= @edad,\r\ncomposicionFamiliar\t= @composicionFamiliar,\r\nmotivo\t\t\t\t= @motivo,\r\nantecedente\t\t\t= @antecedente,\r\ndescripcionSituacion\t=@descripcionSituacion,\r\naspectosPreocupantes = @aspectosPreocupantes,\r\ngeneroId\t\t\t= @generoId\r\n\r\nWHERE\r\npacienteId = @pacienteId";
                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand objConsultaActualizar = new SqlCommand(consultaSqlActualizarPaciente, conexion.Connection);

                // Se añaden los valores 

                objConsultaActualizar.Parameters.AddWithValue("@fechaNacimiento", FechaNacimiento);
                objConsultaActualizar.Parameters.AddWithValue("@nombre", Nombre);
                objConsultaActualizar.Parameters.AddWithValue("@apellido", Apellido);
                objConsultaActualizar.Parameters.AddWithValue("@domicilio", Domicilio);
                objConsultaActualizar.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                objConsultaActualizar.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);
                objConsultaActualizar.Parameters.AddWithValue("@correoElectronico", CorreoElectronico);
                objConsultaActualizar.Parameters.AddWithValue("@telefono", Telefono);
                objConsultaActualizar.Parameters.AddWithValue("@profesion", Profesion);
                objConsultaActualizar.Parameters.AddWithValue("@edad", Edad);
                objConsultaActualizar.Parameters.AddWithValue("@composicionFamiliar", ComposicionFamiliar);
                objConsultaActualizar.Parameters.AddWithValue("@motivo", Motivo);
                objConsultaActualizar.Parameters.AddWithValue("@antecedente", Antecedente);
                objConsultaActualizar.Parameters.AddWithValue("@descripcionSituacion", Descripcion);
                objConsultaActualizar.Parameters.AddWithValue("@aspectosPreocupantes", AspectosPreocupantes);
                objConsultaActualizar.Parameters.AddWithValue("@generoId", GeneroId1);
                objConsultaActualizar.Parameters.AddWithValue("@pacienteId", PacienteId);

                //Si el número de filas afectadas fueron existosas, retornamos verdadero
                if (objConsultaActualizar.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    //En caso contrario, retornamos falso
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
                //Independientemente se haga o no el proceso cerramos la conexión
                conexion.Connection.Close();
            }
        }
        public DataTable AgregarCMBGenero()
        {
            try
            {
                conexion.Connection = Conectar();
                string consultaSQL = "SELECT * FROM Genero";
                SqlDataAdapter ObjLlenarCombobox = new SqlDataAdapter(consultaSQL, conexion.Connection);
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
                conexion.Connection.Close();
            }
        }

        //public bool EliminarInformacionPaciente()
        //{
        //    try
        //    {
        //        // Se abre la conexion 
        //        conexion.Connection = Conectar();
        //        // Se crea el query
        //        string consultaSqlEliminarPaciente = "DELETE FROM Paciente WHERE pacienteId = @pacienteId";
        //        //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
        //        SqlCommand objConsultaEliminar = new SqlCommand(consultaSqlEliminarPaciente, conexion.Connection);

        //        // Se añaden los valores 
        //        objConsultaEliminar.Parameters.AddWithValue("@pacienteId", PacienteId);

        //        //Si el número de filas afectadas fueron existosas, retornamos verdadero
        //        if (objConsultaEliminar.ExecuteNonQuery() > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            //En caso contrario, retornamos falso
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        //Independientemente se haga o no el proceso cerramos la conexión

        //        conexion.Connection.Close();
        //    }

        //}
    }
}