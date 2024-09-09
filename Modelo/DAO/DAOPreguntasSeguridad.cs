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
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOPreguntasSeguridad : DTOPreguntasSeguridad
    {
        readonly SqlCommand Conexion = new SqlCommand();

        public bool RegistrarPreguntasSeguridad()
        {
            try
            {
                //Abrimos la conexión
                Conexion.Connection = Conectar();
                //Creamos el query
                string consultaSQLPreguntas1 = "INSERT INTO PreguntasSeguridadProfesionales (preguntasId, DUI, respuestaPreguntas) VALUES (@preguntasId, @DUI, @respuestaPreguntas)";
                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand ObjConsultaSQL1 = new SqlCommand(consultaSQLPreguntas1, Conexion.Connection);

                //Añadimos los valores
                ObjConsultaSQL1.Parameters.AddWithValue("@preguntasId", Pregunta1CMB);
                ObjConsultaSQL1.Parameters.AddWithValue("@DUI", DUIProfesional);
                ObjConsultaSQL1.Parameters.AddWithValue("@respuestaPreguntas", RespuestaPregunta1);

                if (ObjConsultaSQL1.ExecuteNonQuery() > 0)
                {
                    //Si todo salio bien, insertamos los demás datos de las preguntas
                    try
                    {
                        //Creamos el query
                        string consultaSQLPreguntas2 = "INSERT INTO PreguntasSeguridadProfesionales (preguntasId, DUI, respuestaPreguntas) VALUES (@preguntasId, @DUI, @respuestaPreguntas)";
                        //Le mandamos la consulta a SQL por medio de un comando
                        SqlCommand ObjConsultaSQL2 = new SqlCommand(consultaSQLPreguntas2, Conexion.Connection);

                        //Añadimos los valores
                        ObjConsultaSQL2.Parameters.AddWithValue("@preguntasId", Pregunta2CMB);
                        ObjConsultaSQL2.Parameters.AddWithValue("@DUI", DUIProfesional);
                        ObjConsultaSQL2.Parameters.AddWithValue("@respuestaPreguntas", RespuestaPregunta2);

                        if (ObjConsultaSQL2.ExecuteNonQuery() > 0)
                        {
                            //Si todo salio bien, insertamos los demás datos de las preguntas
                            try
                            {
                                //Creamos el query
                                string consultaSQLPreguntas3 = "INSERT INTO PreguntasSeguridadProfesionales (preguntasId, DUI, respuestaPreguntas) VALUES (@preguntasId, @DUI, @respuestaPreguntas)";
                                //Le mandamos la consulta a SQL por medio de un comando
                                SqlCommand ObjConsultaSQL3 = new SqlCommand(consultaSQLPreguntas3, Conexion.Connection);

                                //Añadimos los valores
                                ObjConsultaSQL3.Parameters.AddWithValue("@preguntasId", Pregunta3CMB);
                                ObjConsultaSQL3.Parameters.AddWithValue("@DUI", DUIProfesional);
                                ObjConsultaSQL3.Parameters.AddWithValue("@respuestaPreguntas", RespuestaPregunta3);

                                if (ObjConsultaSQL3.ExecuteNonQuery() > 0)
                                {
                                    //Si todo salio bien, insertamos los demás datos de las preguntas
                                    try
                                    {
                                        //Creamos el query
                                        string consultaSQLPreguntas4 = "INSERT INTO PreguntasSeguridadProfesionales (preguntasId, DUI, respuestaPreguntas) VALUES (@preguntasId, @DUI, @respuestaPreguntas)";
                                        //Le mandamos la consulta a SQL por medio de un comando
                                        SqlCommand ObjConsultaSQL4 = new SqlCommand(consultaSQLPreguntas4, Conexion.Connection);

                                        //Añadimos los valores
                                        ObjConsultaSQL4.Parameters.AddWithValue("@preguntasId", Pregunta4CMB);
                                        ObjConsultaSQL4.Parameters.AddWithValue("@DUI", DUIProfesional);
                                        ObjConsultaSQL4.Parameters.AddWithValue("@respuestaPreguntas", RespuestaPregunta4);

                                        //Si todo salió bien, retornamos verdadero
                                        if (ObjConsultaSQL4.ExecuteNonQuery() > 0)
                                            return true;
                                        else return false;
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Ha ocurrido un error, ERR-001-8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                MessageBox.Show("Ha ocurrido un error, ERR-001-8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Ha ocurrido un error, ERR-001-8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error, ERR-001-8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public bool VerificarPreguntasSeguridad()
        {
            try
            {
                //Abrimos la conexión
                Conexion.Connection = Conectar();
                //Creamos el query
                string consultaSQLPreguntas1 = "SELECT * FROM PreguntasSeguridadProfesionales WHERE preguntasId = @preguntasId AND DUI = @DUI AND respuestaPreguntas = @respuestaPreguntas";
                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand ObjConsultaSQL1 = new SqlCommand(consultaSQLPreguntas1, Conexion.Connection);

                //Añadimos los valores
                ObjConsultaSQL1.Parameters.AddWithValue("@preguntasId", Pregunta1CMB);
                ObjConsultaSQL1.Parameters.AddWithValue("@DUI", DUIProfesional);
                ObjConsultaSQL1.Parameters.AddWithValue("@respuestaPreguntas", RespuestaPregunta1);

                SqlDataReader ObjFilasEncontradas1 = ObjConsultaSQL1.ExecuteReader();
                if (ObjFilasEncontradas1.Read() == true)
                {
                    //Cerramos el lector
                    ObjFilasEncontradas1.Close();
                    //Si todo salio bien, consultamos los datos de las demás preguntas
                    try
                    {
                        //Creamos el query
                        string consultaSQLPreguntas2 = "SELECT * FROM PreguntasSeguridadProfesionales WHERE preguntasId = @preguntasId AND DUI = @DUI AND respuestaPreguntas = @respuestaPreguntas";
                        //Le mandamos la consulta a SQL por medio de un comando
                        SqlCommand ObjConsultaSQL2 = new SqlCommand(consultaSQLPreguntas2, Conexion.Connection);

                        //Añadimos los valores
                        ObjConsultaSQL2.Parameters.AddWithValue("@preguntasId", Pregunta2CMB);
                        ObjConsultaSQL2.Parameters.AddWithValue("@DUI", DUIProfesional);
                        ObjConsultaSQL2.Parameters.AddWithValue("@respuestaPreguntas", RespuestaPregunta2);

                        SqlDataReader ObjFilasEncontradas2 = ObjConsultaSQL2.ExecuteReader();
                        if (ObjFilasEncontradas2.Read() == true)
                        {
                            //Cerramos el lector
                            ObjFilasEncontradas2.Close();
                            //Si todo salio bien, consultamos los datos de las demás preguntas
                            try
                            {
                                //Creamos el query
                                string consultaSQLPreguntas3 = "SELECT * FROM PreguntasSeguridadProfesionales WHERE preguntasId = @preguntasId AND DUI = @DUI AND respuestaPreguntas = @respuestaPreguntas";
                                //Le mandamos la consulta a SQL por medio de un comando
                                SqlCommand ObjConsultaSQL3 = new SqlCommand(consultaSQLPreguntas3, Conexion.Connection);

                                //Añadimos los valores
                                ObjConsultaSQL3.Parameters.AddWithValue("@preguntasId", Pregunta3CMB);
                                ObjConsultaSQL3.Parameters.AddWithValue("@DUI", DUIProfesional);
                                ObjConsultaSQL3.Parameters.AddWithValue("@respuestaPreguntas", RespuestaPregunta3);

                                SqlDataReader ObjFilasEncontradas3 = ObjConsultaSQL3.ExecuteReader();
                                if (ObjFilasEncontradas3.Read() == true)
                                {
                                    //Cerramos el lector
                                    ObjFilasEncontradas3.Close();
                                    //Si todo salio bien, consultamos los datos de las demás preguntas
                                    try
                                    {
                                        //Creamos el query
                                        string consultaSQLPreguntas4 = "SELECT * FROM PreguntasSeguridadProfesionales WHERE preguntasId = @preguntasId AND DUI = @DUI AND respuestaPreguntas = @respuestaPreguntas";
                                        //Le mandamos la consulta a SQL por medio de un comando
                                        SqlCommand ObjConsultaSQL4 = new SqlCommand(consultaSQLPreguntas4, Conexion.Connection);

                                        //Añadimos los valores
                                        ObjConsultaSQL4.Parameters.AddWithValue("@preguntasId", Pregunta4CMB);
                                        ObjConsultaSQL4.Parameters.AddWithValue("@DUI", DUIProfesional);
                                        ObjConsultaSQL4.Parameters.AddWithValue("@respuestaPreguntas", RespuestaPregunta4);

                                        SqlDataReader ObjFilasEncontradas4 = ObjConsultaSQL4.ExecuteReader();
                                        if (ObjFilasEncontradas4.Read() == true)
                                        {
                                            //Cerramos el lector
                                            ObjFilasEncontradas4.Close();
                                            //Si todo salio bien, consultamos los datos del usuario
                                            try
                                            {
                                                //Creamos el query
                                                string consultaSQLUsuario = "SELECT * FROM vistaPreguntasSeguridadP WHERE DUI = @DUI AND nombreUsuario = @nombreUsuario";
                                                //Le mandamos la consulta a SQL por medio de un comando
                                                SqlCommand ObjConsultaSQLUsuario = new SqlCommand(consultaSQLUsuario, Conexion.Connection);

                                                //Añadimos los valores
                                                ObjConsultaSQLUsuario.Parameters.AddWithValue("@DUI", DUIProfesional);
                                                ObjConsultaSQLUsuario.Parameters.AddWithValue("@nombreUsuario", UsuarioSolicitante);

                                                SqlDataReader ObjFilasEncontradas5 = ObjConsultaSQLUsuario.ExecuteReader();
                                                //Si todo salió bien, retornamos verdadero
                                                if (ObjFilasEncontradas5.Read() == true)
                                                    return true;
                                                else return false;
                                            }
                                            catch (Exception)
                                            {
                                                MessageBox.Show("Ha ocurrido un error, ERR-002-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                        MessageBox.Show("Ha ocurrido un error, ERR-002-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                MessageBox.Show("Ha ocurrido un error, ERR-002-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Ha ocurrido un error, ERR-002-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error, ERR-002-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public DataTable CargarPregunta1()
        {
            try
            {
                Conexion.Connection = Conectar();

                string ConsultaCargarCMB1 = "SELECT * FROM PreguntasSeguridad";

                SqlCommand ObjComandoSQL = new SqlCommand(ConsultaCargarCMB1, Conexion.Connection);
                SqlDataAdapter ObjAdaptadorSQL = new SqlDataAdapter(ObjComandoSQL);
                DataTable ObjDTCargarCMB = new DataTable();
                ObjAdaptadorSQL.Fill(ObjDTCargarCMB);
                return ObjDTCargarCMB;
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
        public DataTable CargarPregunta2()
        {
            try
            {
                Conexion.Connection = Conectar();

                string ConsultaCargarCMB1 = "SELECT * FROM PreguntasSeguridad WHERE preguntasId NOT IN (@preguntasNotInId1)";

                SqlCommand ObjComandoSQL = new SqlCommand(ConsultaCargarCMB1, Conexion.Connection);

                ObjComandoSQL.Parameters.AddWithValue("@preguntasNotInId1", PreguntaNotIn1);

                SqlDataAdapter ObjAdaptadorSQL = new SqlDataAdapter(ObjComandoSQL);
                DataTable ObjDTCargarCMB = new DataTable();
                ObjAdaptadorSQL.Fill(ObjDTCargarCMB);
                return ObjDTCargarCMB;
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
        public DataTable CargarPregunta3()
        {
            try
            {
                Conexion.Connection = Conectar();

                string ConsultaCargarCMB1 = "SELECT * FROM PreguntasSeguridad WHERE preguntasId NOT IN (@preguntasNotInId1) AND preguntasId NOT IN (@preguntaNotInId2)";

                SqlCommand ObjComandoSQL = new SqlCommand(ConsultaCargarCMB1, Conexion.Connection);

                ObjComandoSQL.Parameters.AddWithValue("@preguntasNotInId1", PreguntaNotIn1);
                ObjComandoSQL.Parameters.AddWithValue("@preguntaNotInId2", PreguntaNotIn2);

                SqlDataAdapter ObjAdaptadorSQL = new SqlDataAdapter(ObjComandoSQL);
                DataTable ObjDTCargarCMB = new DataTable();
                ObjAdaptadorSQL.Fill(ObjDTCargarCMB);
                return ObjDTCargarCMB;
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
        public DataTable CargarPregunta4()
        {
            try
            {
                Conexion.Connection = Conectar();

                string ConsultaCargarCMB1 = "SELECT * FROM PreguntasSeguridad WHERE preguntasId NOT IN (@preguntasNotInId1) AND preguntasId NOT IN (@preguntaNotInId2) AND preguntasId NOT IN (@preguntaNotInId3)";

                SqlCommand ObjComandoSQL = new SqlCommand(ConsultaCargarCMB1, Conexion.Connection);

                ObjComandoSQL.Parameters.AddWithValue("@preguntasNotInId1", PreguntaNotIn1);
                ObjComandoSQL.Parameters.AddWithValue("@preguntaNotInId2", PreguntaNotIn2);
                ObjComandoSQL.Parameters.AddWithValue("@preguntaNotInId3", PreguntaNotIn3);

                SqlDataAdapter ObjAdaptadorSQL = new SqlDataAdapter(ObjComandoSQL);
                DataTable ObjDTCargarCMB = new DataTable();
                ObjAdaptadorSQL.Fill(ObjDTCargarCMB);
                return ObjDTCargarCMB;
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