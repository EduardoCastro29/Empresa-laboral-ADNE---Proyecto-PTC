using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                string queryCita = "SELECT TOP 1 *  FROM vistaCitasAgendadas WHERE [Fecha de la Cita] >= CONVERT(date, GETDATE()) ORDER BY [Fecha de la Cita] ASC, [Hora de Inicio] ASC";
                SqlCommand objSiguienteCita = new SqlCommand(queryCita, Conexion.Connection);

                SqlDataAdapter adp = new SqlDataAdapter(objSiguienteCita);
                DataTable dt = new DataTable();

                adp.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, Error pendiente ERR-0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error, ERR-006-1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error, ERR-006-2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error, ERR-006-3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error, ERR-006-4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                RellenarGraficoCitas();  // Asegúrate de llamar a este método aquí para llenar los datos
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

                // Suponiendo que tienes una consulta SQL que devuelve la fecha y el total de citas por fecha
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
                MessageBox.Show("Ha ocurrido un error, no se encontraron datos para cargar el gráfico, ERR-007", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string consultaSQLCargarHistorial = "SELECT * FROM vistaHistorial";

                //Inicializamos el comando
                SqlCommand ObjComandoSQLServerUC = new SqlCommand(consultaSQLCargarHistorial, Conexion.Connection);

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
                MessageBox.Show("Ha ocurrido un error, ERR-002-2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }

    }
}