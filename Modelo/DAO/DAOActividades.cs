using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//Using para el envio de mails
using System.Net.Mail;
using System.Net;
using System.Linq;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOActividades : DTOActividades
    {
        readonly SqlCommand Conexion = new SqlCommand();
        public DataTable ObtenerSiguienteCita()
        {
            try
            {
                Conexion.Connection = Conectar();

                //En la consulta se ordena los datos de la vista para pedir el siguiente paciente (El que se encuentra en el TOP 1)
                string queryCita = "SELECT TOP 1 * FROM vistaCitasAgendadas WHERE [ID del Profesional] = @DUIProfesional AND estadoId = 2 AND [Fecha de la Cita] >= CONVERT(date, GETDATE()) ORDER BY [Fecha de la Cita] ASC";
                SqlCommand objSiguienteCita = new SqlCommand(queryCita, Conexion.Connection);
                objSiguienteCita.Parameters.AddWithValue("@DUIProfesional", InicioSesion.Dui);
                SqlDataAdapter adp = new SqlDataAdapter(objSiguienteCita);
                DataTable dt = new DataTable();

                adp.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-006-0 - Error al cargar la siguiente cita. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public int ContarIntervaloCitasAtendidas()
        {
            try
            {
                Conexion.Connection = Conectar();
                string queryIntervaloCitasA = "SELECT COUNT(citaId) FROM Cita WHERE estadoId = 1";
                SqlCommand ObjIntervaloCitaA = new SqlCommand(queryIntervaloCitasA, Conexion.Connection);
                CitasAtendidas = (int)ObjIntervaloCitaA.ExecuteScalar();
                return CitasAtendidas;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-006-1 - Error al cargar el intervalo de citas atentidas. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public int ContarIntervaloCitasPendiente()
        {
            try
            {
                Conexion.Connection = Conectar();
                string queryIntervaloCitaPN = "SELECT COUNT(citaId) FROM Cita WHERE estadoId = 2";
                SqlCommand ObjIntervaloCitaPN = new SqlCommand(queryIntervaloCitaPN, Conexion.Connection);
                CitasPedientes = (int)ObjIntervaloCitaPN.ExecuteScalar();
                return CitasPedientes;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-006-2 - Error al cargar el intervalo de citas pendientes. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public int ContarIntervaloCitasPerdida()
        {
            try
            {
                Conexion.Connection = Conectar();
                string queryIntervaloCitasPR = "SELECT COUNT(citaId) FROM Cita WHERE estadoId = 3";
                SqlCommand ObjIntervaloCitaPR = new SqlCommand(queryIntervaloCitasPR, Conexion.Connection);
                CitasPerdidas = (int)ObjIntervaloCitaPR.ExecuteScalar();
                return CitasPerdidas;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-006-3 - Error al cargar el intervalo de citas perdidas. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public int ObtenerDatosCitas()
        {
            try
            {
                Conexion.Connection = Conectar();
                string queryConsultarCitas = "SELECT COUNT(citaId) FROM Cita WHERE fecha BETWEEN @fechaInicio AND @fechaFinal";
                SqlCommand ObjVerCitas = new SqlCommand(queryConsultarCitas, Conexion.Connection);
                ObjVerCitas.Parameters.AddWithValue("@fechaInicio", FechaInicio1);
                ObjVerCitas.Parameters.AddWithValue("@fechaFinal", FechaFinal1);
                NumeroCitas = (int)ObjVerCitas.ExecuteScalar();
                return NumeroCitas;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-006-4 - Error al cargar el intervalo de fechas de las citas. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public bool CargarDatos(DateTime FechaInicio1, DateTime FechaFinal1)
        {
            FechaFinal1 = new DateTime(FechaFinal1.Year, FechaFinal1.Month, FechaFinal1.Day, FechaFinal1.Hour, FechaFinal1.Minute, 59);
            if (FechaInicio1 != this.FechaInicio1 || FechaFinal1 != this.FechaFinal1)
            {
                this.FechaInicio1 = FechaInicio1;
                this.FechaFinal1 = FechaFinal1;
                this.NumeroDias = (FechaFinal1 - FechaInicio1).Days;
                ObtenerDatosCitas();
                RellenarGraficoCitas();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RellenarGraficoCitas()
        {
            try
            {
                Conexion.Connection = Conectar();
                string query = "SELECT fecha, COUNT(citaId) as TotalCitas FROM Cita WHERE fecha BETWEEN @fechaInicio AND @fechaFinal GROUP BY fecha";
                SqlCommand ObjGraficoCitas = new SqlCommand(query, Conexion.Connection);
                ObjGraficoCitas.Parameters.AddWithValue("@fechaInicio", FechaInicio1);
                ObjGraficoCitas.Parameters.AddWithValue("@fechaFinal", FechaFinal1);
                SqlDataReader ObjLecturaSQL = ObjGraficoCitas.ExecuteReader();
                GraficoCitas = new List<revenueByDate>();
                while (ObjLecturaSQL.Read())
                {
                    GraficoCitas.Add(new revenueByDate
                    {
                        Date = Convert.ToDateTime(ObjLecturaSQL["fecha"]).Date.ToString("dd/MM/yyyy"),
                        TotalCitas = Convert.ToInt32(ObjLecturaSQL["TotalCitas"])
                    });
                }
                ObjLecturaSQL.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-007-1 - No se encontraron datos para cargar el gráfico. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public DataTable CargarControlHistorial()
        {
            try
            {
                Conexion.Connection = Conectar();

                //Inicializamos la cadena
                string consultaSQLCargarHistorial = "SELECT * FROM vistaHistorial WHERE DUI = @DUI AND estadoId = 2 AND CAST([Fecha de la cita] AS DATE) = CAST(GETDATE() AS DATE) ORDER BY horaInicio ASC";

                //Inicializamos el comando
                SqlCommand ObjComandoSQLServerUC = new SqlCommand(consultaSQLCargarHistorial, Conexion.Connection);

                //Añadimos los valores
                ObjComandoSQLServerUC.Parameters.AddWithValue("@DUI", InicioSesion.Dui);

                //Creamos un SqlDataAdapter
                SqlDataAdapter ObjAdaptador = new SqlDataAdapter(ObjComandoSQLServerUC);
                //Instanciamos a la clase DataTable
                DataTable ObjLlenarUC = new DataTable();

                //Llenamos el DataTable
                ObjAdaptador.Fill(ObjLlenarUC);
                //Retornamos el DataTable
                return ObjLlenarUC;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-011-3 - Error al cargar los registros dentro del historial de citas. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        // Método para obtener las direcciones de correo con citas programadas para el día de hoy
        public List<(string Correo, TimeSpan HoraCita)> ObtenerCitasHoy()
        {
            List<(string Correo, TimeSpan HoraCita)> citas = new List<(string Correo, TimeSpan HoraCita)>();
            try
            {
                Conexion.Connection = Conectar();
                string query = "SELECT * FROM vistaCitaCorreo WHERE [ID del Profesional] = @DUI AND fecha = CAST(CURRENT_TIMESTAMP AS DATE)";
                SqlCommand objComandoSQL = new SqlCommand(query, Conexion.Connection);
                objComandoSQL.Parameters.AddWithValue("@DUI", InicioSesion.Dui);
                SqlDataReader ObjCitasEncontradas = objComandoSQL.ExecuteReader();

                //Verifico si encontró filas
                while (ObjCitasEncontradas.Read())
                {
                    //Captura el correo y lo convierte a string
                    string correo = (string)ObjCitasEncontradas[3];
                    TimeSpan Hora = (TimeSpan)ObjCitasEncontradas[5];

                    //Agrega el correo encontrado a la lista de correos
                    citas.Add((correo, Hora));
                }

                return citas;
            }
            catch (Exception)
            {
                return new List<(string, TimeSpan)>();
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public bool EnviarRecordatoriosCitasHoy()
        {
            List<(string Correo, TimeSpan HoraCita)> citas = ObtenerCitasHoy(); // Obtiene los correos de las citas de hoy
            try
            {
                if (citas.Any()) // Verifica que haya correos para enviar
                {
                    foreach (var cita in citas)
                    {
                        string correo = cita.Correo;
                        TimeSpan hora = cita.HoraCita;
                        string Hora = hora.ToString(@"hh\:mm"); //Formato a la hora
                        //Cuerpo del correo
                        string asunto = "Tienes una cita!";
                        string cuerpo = "Buen día! 🌞" +
                        "\n" + "Te saludamos desde ADNE (Atención a la Diversidad y Necesidades Específicas). " +
                        "\n\n" + "Queremos recordarte que hoy tienes una cita programada con nosotros. Aquí están los detalles: " +
                        "\n" + "Hora de la Cita: " + Hora +
                        "\n\n" + "Esperamos tengas un excelente día." +
                        "\n" + "Atentamente, ADNE";

                        DAOSistemaSoporte ObjDAOSM = new DAOSistemaSoporte();
                        // Envía el correo a todos los destinatarios
                        ObjDAOSM.EnviarCorreo(asunto, cuerpo, new List<string> { correo });
                    }
                    MessageBox.Show("Recordatorios enviados éxitosamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("No hay citas programadas para hoy.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-002-2 - Error al buscar un correo electrónico correspondiente, verifique si su correo electrónico posee una dirección de correo válida. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public int ActualizarCitasPerdidas()
        {
            try
            {
                Conexion.Connection = Conectar();

                //En esta sentencia todas aquellas citas que no fueron atendidas pasan a perdidas
                string queryCita = "UPDATE Cita SET estadoId = '3' WHERE estadoId = '2' AND CAST(fecha AS DATE) < CAST(GETDATE() AS DATE);"; 

                SqlCommand objCitasPerdidas = new SqlCommand(queryCita, Conexion.Connection);

                int filasAfectadas = objCitasPerdidas.ExecuteNonQuery();
                return filasAfectadas;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-00- - Error al cargar la siguiente cita. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}