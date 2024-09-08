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
using System.Runtime.ConstrainedExecution;

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

                string queryInsertarEmpresa = "INSERT INTO DatosDelSistema (nombreEmpresa, direccionEmpresa, correoElectronicoE, numeroTelefono, numeroPBX, fechaCreacionE, fotoEmpresa)\r\nVALUES\r\n(@nombreEmpresa, @direccionEmpresa, @correoElectronicoE, @numeroTelefono, @numeroPBX, @fechaCreacionE, @fotoEmpresa)";

                SqlCommand ObjComandoInsertarEmpresa = new SqlCommand(queryInsertarEmpresa, Conexion.Connection);

                ObjComandoInsertarEmpresa.Parameters.AddWithValue("@nombreEmpresa", NombreEmpresa);
                ObjComandoInsertarEmpresa.Parameters.AddWithValue("@direccionEmpresa", DireccionEmpresa);
                ObjComandoInsertarEmpresa.Parameters.AddWithValue("@correoElectronicoE", CorreoElectronicoE);
                ObjComandoInsertarEmpresa.Parameters.AddWithValue("@numeroTelefono", NumeroTelefono);
                ObjComandoInsertarEmpresa.Parameters.AddWithValue("@numeroPBX", NumeroPBX);
                ObjComandoInsertarEmpresa.Parameters.AddWithValue("@fechaCreacionE", FeghaCreacionE);
                ObjComandoInsertarEmpresa.Parameters.AddWithValue("@fotoEmpresa", FotoEmpresa);

                if (ObjComandoInsertarEmpresa.ExecuteNonQuery() > 0)
                    return true;
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-001-5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
        //Este método es común para verificar si ya existe una empresa ingresada dentro del Sistema
        public bool VerificarEmpresa()
        {
            try
            {
                Conexion.Connection = Conectar();

                string queryVerificarEmpresa = "SELECT * FROM DatosDelSistema";

                SqlCommand ObjComandoVerificarEmpresa = new SqlCommand(queryVerificarEmpresa, Conexion.Connection);

                SqlDataReader ObjFilasEncontradas = ObjComandoVerificarEmpresa.ExecuteReader();

                if (ObjFilasEncontradas.Read() == true)
                    return true;
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, ERR-002-8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }
    }
}