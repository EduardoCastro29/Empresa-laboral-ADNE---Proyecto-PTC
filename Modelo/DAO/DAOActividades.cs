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
                string queryIntervaloCitasA = "SELECT COUNT (citaId) FROM Cita WHERE estadoId = 1";
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

                string queryIntervaloCitaPN = "SELECT COUNT (citaId) FROM Cita WHERE estadoId = 2";
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

                string queryIntervaloCitasPR = "SELECT COUNT (citaId) FROM Cita WHERE estadoId = 3";
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
    }
}