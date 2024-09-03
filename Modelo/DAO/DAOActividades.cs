using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAOActividades : DTOActividades
    {
        readonly SqlCommand Conexion = new SqlCommand();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                SqlDataReader reader = ObjGraficoCitas.ExecuteReader();

                GraficoCitas = new List<revenueByDate>();

                while (reader.Read())
                {
                    GraficoCitas.Add(new revenueByDate
                    {
                        Date = Convert.ToDateTime(reader["fecha"]).Date.ToString("dd/MM/yyyy"),
                        TotalCitas = Convert.ToInt32(reader["TotalCitas"])
                    });
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}