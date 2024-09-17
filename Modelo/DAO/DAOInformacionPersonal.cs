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
        readonly SqlCommand Conexion = new SqlCommand();
        public bool InsertarInformacionPaciente()
        {
            try
            {
                //Abrimos la Conexion 
                Conexion.Connection = Conectar();
                // Se crea el query 
                string consultaSqlPaciente = "INSERT INTO Paciente(documentoPresentado, fechaNacimiento, nombre, apellido, domicilio, nacionalidad, correoElectronico, telefono, profesion, edad, composicionFamiliar, motivo, antecedente, descripcionSituacion, aspectosPreocupantes, generoId)\r\nVALUES\r\n(@documentoPresentado, @fechaNacimiento, @nombre, @apellido, @domicilio, @nacionalidad, @correoElectronico, @telefono, @profesion, @edad, @composicionFamiliar, @motivo, @antecedente, @descripcionSituacion, @aspectosPreocupantes, @generoId)";
                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand objConsultaSql = new SqlCommand(consultaSqlPaciente, Conexion.Connection);

                // Se añaden los valores
                objConsultaSql.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);
                objConsultaSql.Parameters.AddWithValue("@fechaNacimiento", FechaNacimiento);
                objConsultaSql.Parameters.AddWithValue("@nombre", Nombre);
                objConsultaSql.Parameters.AddWithValue("@apellido", Apellido);
                objConsultaSql.Parameters.AddWithValue("@domicilio", Domicilio);
                objConsultaSql.Parameters.AddWithValue("@nacionalidad", Nacionalidad); ;
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

                //Si el número de filas afectadas fueron existosas, insertamos los valores para que el profesional pueda ver sus propios pacientes
                if (objConsultaSql.ExecuteNonQuery() > 0)
                {
                    try
                    {
                        //Inicializamos el comando
                        string consultaSQLPacientePR = "INSERT INTO PacienteProfesionalENC (documentoPresentado, DUI) VALUES (@documentoPresentado, @DUI)";

                        //Declaramos el comando
                        SqlCommand ObjConsultaSQL = new SqlCommand(consultaSQLPacientePR, Conexion.Connection);

                        //Insertamos los valores
                        ObjConsultaSQL.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);
                        ObjConsultaSQL.Parameters.AddWithValue("@DUI", InicioSesion.Dui);

                        if (ObjConsultaSQL.ExecuteNonQuery() > 0)
                            return true;
                        else return false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error, ERR-001-4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error, ERR-001-4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                Conexion.Connection.Close();
            }
        }
        public bool ActualizarInformacionPaciente()
        {
            try
            {
                //Abrimos la conexion 
                Conexion.Connection = Conectar();
                // Se crea el query
                string consultaSqlActualizarPaciente = "UPDATE Paciente SET " +
                                                       "fechaNacimiento         = @fechaNacimiento, " +
                                                       "nombre                  = @nombre, " +
                                                       "apellido                = @apellido, " +
                                                       "domicilio               = @domicilio, " +
                                                       "nacionalidad            = @nacionalidad, " +
                                                       "correoElectronico       = @correoElectronico, " +
                                                       "telefono                = @telefono, " +
                                                       "profesion               = @profesion, " +
                                                       "edad                    = @edad, " +
                                                       "composicionFamiliar     = @composicionFamiliar, " +
                                                       "motivo                  = @motivo, " +
                                                       "antecedente             = @antecedente, " +
                                                       "descripcionSituacion    = @descripcionSituacion, " +
                                                       "aspectosPreocupantes    = @aspectosPreocupantes, " +
                                                       "generoId                = @generoId " +

                                                       "WHERE " +
                                                       "documentoPresentado = @documentoPresentado";

                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand objConsultaActualizar = new SqlCommand(consultaSqlActualizarPaciente, Conexion.Connection);

                // Se añaden los valores 
                objConsultaActualizar.Parameters.AddWithValue("@fechaNacimiento", FechaNacimiento);
                objConsultaActualizar.Parameters.AddWithValue("@nombre", Nombre);
                objConsultaActualizar.Parameters.AddWithValue("@apellido", Apellido);
                objConsultaActualizar.Parameters.AddWithValue("@domicilio", Domicilio);
                objConsultaActualizar.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
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
                objConsultaActualizar.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);

                //Si el número de filas afectadas fueron existosas, retornamos verdadero
                if (objConsultaActualizar.ExecuteNonQuery() > 0)
                {
                    return true;
                    //try
                    //{
                    //    //Inicializamos el comando
                    //    string consultaSQLPacientePR = "UPDATE PacienteProfesionalENC SET " +
                    //                                   "documentoPresentado     = @documentoPresentado, " +
                    //                                   "DUI                     = @DUI " +

                    //                                   "WHERE " +
                    //                                   "profesionalPAId = @profesion alPAId";

                    //    //Declaramos el comando
                    //    SqlCommand ObjConsultaSQL = new SqlCommand(consultaSQLPacientePR, Conexion.Connection);

                    //    //Insertamos los valores
                    //    ObjConsultaSQL.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);
                    //    ObjConsultaSQL.Parameters.AddWithValue("@DUI", InicioSesion.Dui);

                    //    if (ObjConsultaSQL.ExecuteNonQuery() > 0)
                    //        return true;
                    //    else return false;
                    //}
                    //catch (Exception)
                    //{
                    //    MessageBox.Show("Ha ocurrido un error, ERR-003-5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return false;
                    //}
                }
                else
                {
                    //En caso contrario, retornamos falso
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-003-5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                Conexion.Connection.Close();
            }
        }
        public bool ObtenerInformacionPaciente()
        {
            try
            {
                //Abrimos la conexion 
                Conexion.Connection = Conectar();
                // Se crea el query
                string consultaSqlActualizarPaciente = "SELECT * FROM Paciente WHERE documentoPresentado = @documentoPresentado";

                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand objConsultaActualizar = new SqlCommand(consultaSqlActualizarPaciente, Conexion.Connection);

                //Se añaden los valores 
                objConsultaActualizar.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);

                //SQL lee los datos y los ejecuta
                SqlDataReader ObjFilasEncontradas = objConsultaActualizar.ExecuteReader();
                while (ObjFilasEncontradas.Read())
                {
                    DocumentoPresentado = ObjFilasEncontradas.GetString(0);
                    FechaNacimiento = ObjFilasEncontradas.GetDateTime(1);
                    Nombre = ObjFilasEncontradas.GetString(2);
                    Apellido = ObjFilasEncontradas.GetString(3);
                    Domicilio = ObjFilasEncontradas.GetString(4);
                    Nacionalidad = ObjFilasEncontradas.GetString(5);
                    CorreoElectronico = ObjFilasEncontradas.GetString(6);
                    Telefono = ObjFilasEncontradas.GetString(7);
                    Profesion = ObjFilasEncontradas.GetString(8);
                    Edad = ObjFilasEncontradas.GetInt32(9);
                    ComposicionFamiliar = ObjFilasEncontradas.GetString(10);
                    Motivo = ObjFilasEncontradas.GetString(11);
                    Antecedente = ObjFilasEncontradas.GetString(12);
                    Descripcion = ObjFilasEncontradas.GetString(13);
                    AspectosPreocupantes = ObjFilasEncontradas.GetString(14);
                    GeneroId1 = ObjFilasEncontradas.GetInt32(15);
                }
                return ObjFilasEncontradas.HasRows;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-002-5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                Conexion.Connection.Close();
            }
        }
        public DataTable AgregarCMBGenero()
        {
            try
            {
                Conexion.Connection = Conectar();
                string consultaSQL = "SELECT * FROM Genero";
                SqlDataAdapter ObjLlenarCombobox = new SqlDataAdapter(consultaSQL, Conexion.Connection);
                DataTable ObjllenarDT = new DataTable();
                ObjLlenarCombobox.Fill(ObjllenarDT);
                return ObjllenarDT;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-008-3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}