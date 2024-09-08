using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLAgregarConexion : DTOAgregarConexion
    {

        readonly AgregarConexion ObjAgregarConexion;

        public CTRLAgregarConexion(AgregarConexion vista)
        {
            ObjAgregarConexion = vista;
            ObjAgregarConexion.rbDesabilitar.CheckedChanged += new EventHandler(DesabilitarOpcion);
            ObjAgregarConexion.rbHabilitar.CheckedChanged += new EventHandler(HabilitarOpcion);
            ObjAgregarConexion.btnGuardar.Click += new EventHandler(GuardarRegistro);
        }



        private void DesabilitarOpcion(object Sender, EventArgs e)
        {
            if(ObjAgregarConexion.rbDesabilitar.Checked == true)
            {
                ObjAgregarConexion.bunifuPanel3.Enabled = true;
            }
        }


        private void HabilitarOpcion(object Sender, EventArgs e)
        {
            if (ObjAgregarConexion.rbHabilitar.Checked == true)
            {
                ObjAgregarConexion.bunifuPanel3.Enabled = false;
                ObjAgregarConexion.txtAutenticacion.Clear();
                ObjAgregarConexion.txtContrasena.Clear();
            }
        }

        private void GuardarRegistro(object Sender, EventArgs e)
        {
            GuardarConfiguracionXML();
        }

        public void GuardarConfiguracionXML()
        {
            CommonMethods ObjCommonMethods = new CommonMethods();
            try
            {
                XmlDocument doc = new XmlDocument();

                //Crear declaración XML
                XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(decl);

                //Crear elemento raíz
                XmlElement root = doc.CreateElement("Conn");
                doc.AppendChild(root);

                //Crear los elementos hijos y agregarlos al elemento raíz
                XmlElement servidor = doc.CreateElement("Server");
                string servidorCode = ObjCommonMethods.MetodoEncriptacionAES(ObjAgregarConexion.txtServidorURL.Text.Trim());

                servidor.InnerText = servidorCode;
                root.AppendChild(servidor);

                XmlElement Database = doc.CreateElement("Database");
                string DatabaseCode = ObjCommonMethods.MetodoEncriptacionAES(ObjAgregarConexion.txtBaseDeDatos.Text.Trim());

                Database.InnerText = DatabaseCode;
                root.AppendChild(Database);

                if (ObjAgregarConexion.rbDesabilitar.Checked == true)
                {
                    XmlElement SqlAuth = doc.CreateElement("SqlAuth");
                    string sqlAuthCode = ObjCommonMethods.MetodoEncriptacionAES(ObjAgregarConexion.txtAutenticacion.Text.Trim());
                    SqlAuth.InnerText = sqlAuthCode;
                    root.AppendChild(SqlAuth);

                    XmlElement SqlPass = doc.CreateElement("SqlPass");
                    string SqlPassCode = ObjCommonMethods.MetodoEncriptacionAES(ObjAgregarConexion.txtContrasena.Text.Trim());
                    SqlPass.InnerText = SqlPassCode;
                    root.AppendChild(SqlPass);
                }
                else
                {
                    XmlElement SqlAuth = doc.CreateElement("SqlAuth");
                    SqlAuth.InnerText = string.Empty;
                    root.AppendChild(SqlAuth);

                    XmlElement SqlPass = doc.CreateElement("SqlPass");
                    SqlPass.InnerText = string.Empty;
                    root.AppendChild(SqlPass);
                }
                SqlConnection con = Conexion.testConnection(ObjAgregarConexion.txtServidorURL.Text.Trim(), ObjAgregarConexion.txtBaseDeDatos.Text.Trim(), ObjAgregarConexion.txtAutenticacion.Text.Trim(), ObjAgregarConexion.txtContrasena.Text.Trim());
                if (con != null)
                {
                    doc.Save("config_server.xml");
                    DTOAgregarConexion.Server = ObjAgregarConexion.txtServidorURL.Text.Trim();
                    DTOAgregarConexion.Database = ObjAgregarConexion.txtBaseDeDatos.Text.Trim();
                    DTOAgregarConexion.User = ObjAgregarConexion.txtAutenticacion.Text.Trim();
                    DTOAgregarConexion.Password = ObjAgregarConexion.txtContrasena.Text.Trim();
                    MessageBox.Show($"El archivo fue creado exitosamente.", "Archivo de configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjAgregarConexion.Dispose();
                }

            }
            catch (XmlException ex)
            {
                MessageBox.Show($"{ex.Message}, no se pudo crear el archivo de configuración.", "Consulte el manual técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
