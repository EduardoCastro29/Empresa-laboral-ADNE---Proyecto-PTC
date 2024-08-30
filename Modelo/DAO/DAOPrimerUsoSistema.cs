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
    internal class DAOPrimerUsoSistema : DTOPrimerUsoSistema
    {
        readonly SqlCommand Conexion = new SqlCommand();
        public bool RegistrarEmpresa()
        {
            try
            {
                Conexion.Connection = Conectar();

                string queryInsertarEmpresa = "";

                SqlCommand ObjComandoInsertarEmpresa = new SqlCommand(queryInsertarEmpresa, Conexion.Connection);

                //ObjComandoInsertarEmpresa.Parameters.AddWithValue("", );
                //ObjComandoInsertarEmpresa.Parameters.AddWithValue("", );
                //ObjComandoInsertarEmpresa.Parameters.AddWithValue("", );
                //ObjComandoInsertarEmpresa.Parameters.AddWithValue("", );
                //ObjComandoInsertarEmpresa.Parameters.AddWithValue("", );
                //ObjComandoInsertarEmpresa.Parameters.AddWithValue("", );
                //ObjComandoInsertarEmpresa.Parameters.AddWithValue("", );

                if (ObjComandoInsertarEmpresa.ExecuteNonQuery() > 0)
                    return true;
                else return false;
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
        public bool VerificarEmpresa()
        {
            try
            {
                Conexion.Connection = Conectar();

                string queryVerificarEmpresa = "";

                SqlCommand ObjComandoVerificarEmpresa = new SqlCommand(queryVerificarEmpresa, Conexion.Connection);

                if (ObjComandoVerificarEmpresa.ExecuteNonQuery() > 0)
                    return true;
                else return false;
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
    }
}