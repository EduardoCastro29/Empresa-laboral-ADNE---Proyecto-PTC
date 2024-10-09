using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAODiagnosticos : DTOExpedientes
    {
        readonly SqlCommand Conexion = new SqlCommand();

        public DataTable Cargar()
        {
            try
            {
                Conexion.Connection = Conectar();

                string consulta = "SELECT * FROM vistaCita";

                SqlCommand objComando = new SqlCommand(consulta, Conexion.Connection);
                SqlDataAdapter objAdaptador = new SqlDataAdapter(objComando);

                DataTable dt = new DataTable();

                objAdaptador.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-011-2 - Error al cargar los registros de pacientes que poseen un expediente. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public DataSet BuscarCita(string BuscarDiagnostico)
        {
            try
            {
                Conexion.Connection = Conectar();

                string consulta = "SELECT * FROM vistaCita WHERE [Nombre del Paciente] LIKE @NombrePaciente";

                SqlCommand objComando = new SqlCommand(consulta, Conexion.Connection);

                objComando.Parameters.AddWithValue("@NombrePaciente", "%" + BuscarDiagnostico + "%");

                objComando.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(objComando);
                DataSet dt = new DataSet();

                adapter.Fill(dt, "vistaCita");
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-005-2 - Error al buscar pacientes por su identificador de nombre. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public bool Obtener_expediente_Informacion()
        {
            try
            {
                Conexion.Connection = Conectar();

                string info = "SELECT * FROM vistaObtenerInformacionYExpediente WHERE [Documento Presentado] = @documentoPresentado " +
                              "AND [ID del Expediente] = @expedienteId AND [ID de la Cita] = @citaId";
                SqlCommand objComando = new SqlCommand(info, Conexion.Connection);

                objComando.Parameters.AddWithValue("@documentoPresentado", DocumentoPaciente);
                objComando.Parameters.AddWithValue("@expedienteId", N_expediente);
                objComando.Parameters.AddWithValue("@citaId", CitaId);

                SqlDataReader lectura = objComando.ExecuteReader();
                while (lectura.Read())
                {
                    //Obtengo los valores de la tabla
                    N_expediente = lectura.GetInt32(0);
                    //Empezando por 0 porque ahí inicia la tabla
                    Nombre_apellido_paciente = lectura.GetString(1);
                    Domicilio = lectura.GetString(2);
                    Nacionalidad = lectura.GetString(3);
                    Doc_presentado = lectura.GetString(4);
                    Tel = lectura.GetString(5);
                    Edad = lectura.GetInt32(6);
                    Genero = lectura.GetString(7);
                    Profesion = lectura.GetString(8);
                    Com_familiar = lectura.GetString(9);
                    Motivo = lectura.GetString(10);
                    Antecedentes = lectura.GetString(11);
                    Desc_situacion = lectura.GetString(12);
                    Aspectos = lectura.GetString(13);
                    Afectividad = lectura.GetString(14);
                    Estado_conducta = lectura.GetString(15);
                    Somatizaciones = lectura.GetString(16);
                    VidaInterpersonal = lectura.GetString(17);
                    Cognicion = lectura.GetString(18);
                    Red_social = lectura.GetString(19);
                    Pautas = lectura.GetString(20);
                    RiesgoValorado = lectura.GetString(21);
                    Observacion = lectura.GetString(22);
                    AproximacionDiag = lectura.GetString(23);
                    AtencionBrindada = lectura.GetString(24);
                    Fecha_Cita = (DateTime)lectura.GetValue(25);
                    Lugar = lectura.GetString(26);
                    Desc_Cita = lectura.GetString(27);
                }
                return lectura.HasRows;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-002-1 - Error al cargar el documento PDF con los datos el expediente del paciente. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public bool ObtenerDatosSistema()
        {
            try
            {
                Conexion.Connection = Conectar();

                string queryVerificarEmpresa = "SELECT * FROM DatosDelSistema";

                SqlCommand ObjComandoVerificarEmpresa = new SqlCommand(queryVerificarEmpresa, Conexion.Connection);

                SqlDataReader lectura = ObjComandoVerificarEmpresa.ExecuteReader();
                while (lectura.Read())
                {
                    //Obtengo los valores de la tabla
                    NombreEmpresa = lectura.GetString(0);
                    DireccionEmpresa = lectura.GetString(1);
                    CorreoElectronicoE = lectura.GetString(2);
                    NumeroTelefono = lectura.GetString(3);
                    NumeroPBX = lectura.GetString(4);
                    Fecha = (DateTime)lectura.GetValue(5);
                    FotoEmpresa = (byte[])lectura.GetSqlBinary(6);
                }
                return lectura.HasRows;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-002-1 - Error al cargar el documento PDF con los datos el expediente del paciente. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}