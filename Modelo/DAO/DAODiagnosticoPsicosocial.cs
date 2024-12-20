﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Security.Cryptography;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;
using Org.BouncyCastle.Utilities.Collections;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO
{
    internal class DAODiagnosticoPsicosocial : DTODiagnosticoPsicosocial
    {
        readonly SqlCommand Conexion = new SqlCommand();
        public bool ExpedienteInsertarDatos()
        {
            try
            {
                //Abrimos la conexión
                Conexion.Connection = Conectar();
                //Creamos el query
                string consultaSQLExpediente = "INSERT INTO DiagnosticoPsicosocial (estadoAnimo, estadoConductual, somatizacion, vidaInterpersonal, cognicion, redSocial, pauta, riesgoValorado, observacion, aproximacionDiag, atencionBrindada, documentoPresentado) " +
                                               "VALUES " +
                                               "(@estadoAnimo, @estadoConductual, @somatizacion, @vidaInterpersonal, @cognicion, @redSocial, @pauta, @riesgoValorado, @observacion, @aproximacionDiag, @atencionBrindada, @documentoPresentado)";

                //Le mandamos la consulta a SQL por medio de un comando. Como parametros: Consulta, Conexión
                SqlCommand ObjQuerySQL = new SqlCommand(consultaSQLExpediente, Conexion.Connection);

                //Añadimos los valores
                ObjQuerySQL.Parameters.AddWithValue("@estadoAnimo", EstadoAnimo);
                ObjQuerySQL.Parameters.AddWithValue("@estadoConductual", EstadoConductual);
                ObjQuerySQL.Parameters.AddWithValue("@somatizacion", Somatizacion);
                ObjQuerySQL.Parameters.AddWithValue("@vidaInterpersonal", VidaInterpersonal);
                ObjQuerySQL.Parameters.AddWithValue("@cognicion", Cognicion);
                ObjQuerySQL.Parameters.AddWithValue("@redSocial", RedSocial);
                ObjQuerySQL.Parameters.AddWithValue("@pauta", Pauta);
                ObjQuerySQL.Parameters.AddWithValue("@riesgoValorado", RiesgoValorado);
                ObjQuerySQL.Parameters.AddWithValue("@observacion", Observacion);
                ObjQuerySQL.Parameters.AddWithValue("@aproximacionDiag", AproximacionDiag);
                ObjQuerySQL.Parameters.AddWithValue("@atencionBrindada", AtencionBrindada);
                //Aquí se usa el Documento Presentado del paciente para ser insertado y guardado en foránea expedienteId
                ObjQuerySQL.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);

                //Si el número de filas afectadas fueron existosas, retornamos verdadero
                if (ObjQuerySQL.ExecuteNonQuery() > 0)
                    return true;
                //En caso contrario, retornamos falso
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-001-3 - Error al registrar el paciente y diagnóstico psicosocial, verifique si el paciente ya posee un diagnóstico. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        public bool ExpedienteActualizarDatos()
        {
            try
            {
                //Abrimos la conexión
                Conexion.Connection = Conectar();
                //Creamos el query
                string consultaSQLExpediente = "UPDATE DiagnosticoPsicosocial SET " +
                                               "estadoAnimo             = @estadoAnimo, " +
                                               "estadoConductual        = @estadoConductual, " +
                                               "somatizacion            = @somatizacion, " +
                                               "vidaInterpersonal       = @vidaInterpersonal, " +
                                               "cognicion               = @cognicion, " +
                                               "redSocial               = @redSocial, " +
                                               "pauta                   = @pauta, " +
                                               "riesgoValorado          = @riesgoValorado, " +
                                               "observacion             = @observacion, " +
                                               "aproximacionDiag        = @aproximacionDiag, " +
                                               "atencionBrindada        = @atencionBrindada " +

                                               "WHERE " +
                                               "documentopresentado = @documentoPresentado ";

                //Le mandamos la consulta a SQL por medio de un comando. Como parametros: Consulta, Conexión
                SqlCommand ObjQuerySQL = new SqlCommand(consultaSQLExpediente, Conexion.Connection);

                //Añadimos los valores            
                ObjQuerySQL.Parameters.AddWithValue("@estadoAnimo", EstadoAnimo);
                ObjQuerySQL.Parameters.AddWithValue("@estadoConductual", EstadoConductual);
                ObjQuerySQL.Parameters.AddWithValue("@somatizacion", Somatizacion);
                ObjQuerySQL.Parameters.AddWithValue("@vidaInterpersonal", VidaInterpersonal);
                ObjQuerySQL.Parameters.AddWithValue("@cognicion", Cognicion);
                ObjQuerySQL.Parameters.AddWithValue("@redSocial", RedSocial);
                ObjQuerySQL.Parameters.AddWithValue("@pauta", Pauta);
                ObjQuerySQL.Parameters.AddWithValue("@riesgoValorado", RiesgoValorado);
                ObjQuerySQL.Parameters.AddWithValue("@observacion", Observacion);
                ObjQuerySQL.Parameters.AddWithValue("@aproximacionDiag", AproximacionDiag);
                ObjQuerySQL.Parameters.AddWithValue("@atencionBrindada", AtencionBrindada);
                ObjQuerySQL.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);

                //Si el número de filas afectadas fueron existosas, retornamos verdadero
                if (ObjQuerySQL.ExecuteNonQuery() > 0)
                    return true;
                //En caso contrario, retornamos falso
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-003-4 - Error al actualizar el diagnóstico psicosocial del paciente. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }

        }
        public bool ObtenerExpedientePaciente()
        {
            try
            {
                //Abrimos la conexion 
                Conexion.Connection = Conectar();
                // Se crea el query
                string consultaSqlActualizarPaciente = "SELECT * FROM DiagnosticoPsicosocial WHERE documentoPresentado = @documentoPresentado";

                //Le mandamos la consulta a SQL por medio de un comando
                SqlCommand objConsultaActualizar = new SqlCommand(consultaSqlActualizarPaciente, Conexion.Connection);

                // Se añaden los valores 
                objConsultaActualizar.Parameters.AddWithValue("@documentoPresentado", DocumentoPresentado);

                //Si el número de filas afectadas fueron existosas, retornamos verdadero
                objConsultaActualizar.CommandType = CommandType.Text;

                //SQL lee los datos y los ejecuta
                SqlDataReader ObjFilasEncontradas = objConsultaActualizar.ExecuteReader();
                while (ObjFilasEncontradas.Read())
                {
                    ExpedienteId = ObjFilasEncontradas.GetInt32(0);
                    EstadoAnimo = ObjFilasEncontradas.GetString(1);
                    EstadoConductual = ObjFilasEncontradas.GetString(2);
                    Somatizacion = ObjFilasEncontradas.GetString(3);
                    VidaInterpersonal = ObjFilasEncontradas.GetString(4);
                    Cognicion = ObjFilasEncontradas.GetString(5);
                    RedSocial = ObjFilasEncontradas.GetString(6);
                    Pauta = ObjFilasEncontradas.GetString(7);
                    RiesgoValorado = ObjFilasEncontradas.GetString(8);
                    Observacion = ObjFilasEncontradas.GetString(9);
                    AproximacionDiag = ObjFilasEncontradas.GetString(10);
                    AtencionBrindada = ObjFilasEncontradas.GetString(11);
                    DocumentoPresentado = ObjFilasEncontradas.GetString(12);
                }
                return ObjFilasEncontradas.HasRows;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-002-4 - Error al cargar los valores con el registro del paciente sobre el diagnóstico. [Consulte el Manual Técnico]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                Conexion.Connection.Close();
            }
        }
    }
}