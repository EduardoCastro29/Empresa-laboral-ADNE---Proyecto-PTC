using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Windows.Forms;
using System.Data;
using Microsoft.VisualBasic;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOAgendarCita : DTOAgendarCita
    {
        readonly SqlCommand Conexion = new SqlCommand();

        //Creamos una variable de tipo booleana, de esta forma nos devolvera un valor "true o false"
        //Dependiendo si las acciones se han echo correctamente
        public bool RegistrarCitaConsulta()
        {
            try
            {
                //Creamos un bloque try catch para verificar en qué línea hubo algún error y solventarla
                //Inicializamos la conexión
                Conexion.Connection = Conectar();

                //Declaramos la consulta que deseamos en una variable de tipo string
                string consultaSQLInsertarCita = "INSERT INTO Cita (fecha, horaInicio, horaFinal, estadoId, documentoPresentado, DUI, lugarId) OUTPUT INSERTED.citaId VALUES (@fecha, @horaInicio, @horaFinal, @estadoId, @documentoPresentado, @DUI, @lugarId)";

                SqlCommand ObjComandoSQLInsertarCita = new SqlCommand(consultaSQLInsertarCita, Conexion.Connection);

                //Agreamos los valores de la cita
                ObjComandoSQLInsertarCita.Parameters.AddWithValue("@fecha", Fecha);
                ObjComandoSQLInsertarCita.Parameters.AddWithValue("@horaInicio", HoraInicio);
                ObjComandoSQLInsertarCita.Parameters.AddWithValue("@horaFinal", HoraFinal);
                ObjComandoSQLInsertarCita.Parameters.AddWithValue("@estadoId", EstadoId);
                ObjComandoSQLInsertarCita.Parameters.AddWithValue("@documentoPresentado",  DocumentoPresentado);
                ObjComandoSQLInsertarCita.Parameters.AddWithValue("@DUI", DuiProfesional);
                ObjComandoSQLInsertarCita.Parameters.AddWithValue("@lugarId", LugarId);

                //Creamos una variable que nos capturará el ID de la Cita creada, que posteriormente se insertará dentro de la consulta
                //La variable usada (int) es para indicarle que es de tipo entero, y que nos retornará el ID creado
                int citaIdGenerada = (int)ObjComandoSQLInsertarCita.ExecuteScalar();

                if (citaIdGenerada > 0)
                {
                    try
                    {
                        string consultaSQLInsertarConsulta = "INSERT INTO Consulta (descripcion, citaId) VALUES (@descripcion, @citaId)";

                        //Creamos el comando SQLServer para ejecutarlo dentro de la base
                        SqlCommand ObjComandoSQLInsertaConsulta = new SqlCommand(consultaSQLInsertarConsulta, Conexion.Connection);

                        ObjComandoSQLInsertaConsulta.Parameters.AddWithValue("@descripcion", Descripcion);
                        ObjComandoSQLInsertaConsulta.Parameters.AddWithValue("@citaId", citaIdGenerada);

                        //Si el ID de la Cita es mayor a 0, es decir, el ID se insertó correctamente
                        //Procedemos a insertar los valores de la Consulta
                        if (ObjComandoSQLInsertaConsulta.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
                else
                {
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
        public bool ActualizarCitaYConsulta()
        {
            try
            {
                Conexion.Connection = Conectar();

                string consultaSQLActualizarCita = "UPDATE Cita SET " +
                                                   "fecha                = @fecha, " +
                                                   "horaInicio           = @horaInicio, " +
                                                   "horaFinal            = @horaFinal, " +
                                                   "estadoId             = @estadoId, " +
                                                   "documentoPresentado  = @documentoPresentado, " +
                                                   "DUI                  = @DUI, " +
                                                   "lugarId              = @lugarId " +

                                                   "WHERE " +
                                                   "citaId = @citaId ";

                SqlCommand ObjComandoSQLServerActuCita = new SqlCommand(consultaSQLActualizarCita, Conexion.Connection);

                ObjComandoSQLServerActuCita.Parameters.AddWithValue("@fecha", Fecha);
                ObjComandoSQLServerActuCita.Parameters.AddWithValue("@horaInicio", HoraInicio);
                ObjComandoSQLServerActuCita.Parameters.AddWithValue("@horaFinal", HoraFinal);
                ObjComandoSQLServerActuCita.Parameters.AddWithValue("@estadoId", EstadoId);
                ObjComandoSQLServerActuCita.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);
                ObjComandoSQLServerActuCita.Parameters.AddWithValue("@DUI", DuiProfesional);
                ObjComandoSQLServerActuCita.Parameters.AddWithValue("@lugarId", LugarId);
                ObjComandoSQLServerActuCita.Parameters.AddWithValue("@citaId", CitaId);

                if (ObjComandoSQLServerActuCita.ExecuteNonQuery() > 0)
                {
                    try
                    {
                        string consultaSQLConsulta = "UPDATE Consulta SET descripcion = @descripcion, citaId = @citaId WHERE consultaId = @consultaId";

                        SqlCommand ObjComandoSQLServerACTConsulta = new SqlCommand(consultaSQLConsulta, Conexion.Connection);

                        ObjComandoSQLServerACTConsulta.Parameters.AddWithValue("@descripcion", Descripcion);
                        ObjComandoSQLServerACTConsulta.Parameters.AddWithValue("@citaId", CitaId);
                        ObjComandoSQLServerACTConsulta.Parameters.AddWithValue("@consultaId", ConsultaId);

                        if (ObjComandoSQLServerACTConsulta.ExecuteNonQuery() > 0)
                            return true;
                        else return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
                else
                {
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
        //Este que se utilizará para eliminar una Cita y consecuentemente la consulta registrada

        //Cargamos el DataTable del Lugar de la Cita
        public DataTable AgregarCMBLugar()
        {
            try
            {
                //Abrimos la conexión a SQL Server
                Conexion.Connection = Conectar();
                //Creamos la consulta SQL Server que nos permitira ver los valores dentro de la tabla
                string consultaSQL = "SELECT * FROM Lugar";
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
        //Cargamos el DataTable del Estado de la Cita
        public DataTable AgregarCMBEstado()
        {
            try
            {
                Conexion.Connection = Conectar();
                string consultaSQL = "SELECT * FROM Estado";
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