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
            ObjAgregarConexion.rbDesabilitar.CheckedChanged += new EventHandler(DesabilitarAutenticacionConexion);
            ObjAgregarConexion.rbHabilitar.CheckedChanged += new EventHandler(ActivarAutenticacionConexion);
            ObjAgregarConexion.btnGuardar.Click += new EventHandler(GuardarConfiguracionDBXML);
        }
        private void DesabilitarAutenticacionConexion(object Sender, EventArgs e)
        {
            if(ObjAgregarConexion.rbDesabilitar.Checked == true)
            {
                ObjAgregarConexion.pnlAutenticacion.Enabled = true;
            }
        }
        private void ActivarAutenticacionConexion(object Sender, EventArgs e)
        {
            if (ObjAgregarConexion.rbHabilitar.Checked == true)
            {
                ObjAgregarConexion.pnlAutenticacion.Enabled = false;
                ObjAgregarConexion.txtAutenticacion.Clear();
                ObjAgregarConexion.txtContrasena.Clear();
            }
        }
        public void GuardarConfiguracionDBXML(object sender, EventArgs e)
        {
            CommonMethods ObjCommonMethods = new CommonMethods();
            try
            {
                //Creamos una instancia de XLMDocument que nos permitirá crear el archivo XML para el guardado de la conexión
                XmlDocument ObjDocumentoXML = new XmlDocument();

                //Crear declaración XML, especificando que tipo de datos admitirá el archivo
                //En este caso, la versión 1.0, UTF-8 (permite carácteres especiales), etc
                XmlDeclaration ObjDeclaracionXML = ObjDocumentoXML.CreateXmlDeclaration("1.0", "UTF-8", null);
                ObjDocumentoXML.AppendChild(ObjDeclaracionXML);

                //Creamos el elemento raíz, la etiqueta principal del archivo XML
                XmlElement ObjROOTEtiquetaPrincipal = ObjDocumentoXML.CreateElement("Conexion");
                ObjDocumentoXML.AppendChild(ObjROOTEtiquetaPrincipal);

                //Creamos el elemento hijo y los agregamos dentro de la etiqueta principal, etiqueta raíz
                XmlElement ObjROOTServidor = ObjDocumentoXML.CreateElement("ServidorSQL");
                //Declaramos el código del servidor que se encontrará dentro de la etiqueta ServidorSQL
                string CodigoServidor = ObjCommonMethods.MetodoEncriptacionAES(ObjAgregarConexion.txtServidorURL.Text.Trim());

                //Fusionamos el servidor root junto con el código servidor a la etiqueta principal, RAÍZ
                ObjROOTServidor.InnerText = CodigoServidor;
                ObjROOTEtiquetaPrincipal.AppendChild(ObjROOTServidor);

                //Creamos el elemento hijo y los agregamos dentro de la etiqueta principal, etiqueta raíz
                XmlElement ObjROOTBaseDatos = ObjDocumentoXML.CreateElement("BaseDatosSQL");
                //Declaramos el código de la base de datos que se encontrará dentro de la etiqueta BaseDatosSQL
                string CodigoBaseDatos = ObjCommonMethods.MetodoEncriptacionAES(ObjAgregarConexion.txtBaseDeDatos.Text.Trim());

                //Fusionamos el servidor root junto con el código servidor a la etiqueta principal, RAÍZ
                ObjROOTBaseDatos.InnerText = CodigoBaseDatos;
                ObjROOTEtiquetaPrincipal.AppendChild(ObjROOTBaseDatos);

                if (ObjAgregarConexion.rbDesabilitar.Checked == true)
                {
                    //Creamos el elemento hijo y los agregamos dentro de la etiqueta principal, etiqueta raíz
                    XmlElement ObjROOTAutenticacion = ObjDocumentoXML.CreateElement("AutenticacionSQL");
                    //Declaramos el código de la autenticación de SQL Server que se encontrará dentro de la etiqueta AutenticacionSQL
                    string CodigoAutenticacion = ObjCommonMethods.MetodoEncriptacionAES(ObjAgregarConexion.txtAutenticacion.Text.Trim());

                    //Fusionamos el servidor root junto con el código servidor a la etiqueta principal, RAÍZ
                    ObjROOTAutenticacion.InnerText = CodigoAutenticacion;
                    ObjROOTEtiquetaPrincipal.AppendChild(ObjROOTAutenticacion);

                    //Creamos el elemento hijo y los agregamos dentro de la etiqueta principal, etiqueta raíz
                    XmlElement ObjROOTContrasena = ObjDocumentoXML.CreateElement("ContraseñaSQL");
                    //Declaramos el código de la contraseña de SQL Server que se encontrará dentro de la etiqueta ContraseñaSQL
                    string CodigoContrasena = ObjCommonMethods.MetodoEncriptacionAES(ObjAgregarConexion.txtContrasena.Text.Trim());

                    //Fusionamos el servidor root junto con el código servidor a la etiqueta principal, RAÍZ
                    ObjROOTContrasena.InnerText = CodigoContrasena;
                    ObjROOTEtiquetaPrincipal.AppendChild(ObjROOTContrasena);
                }
                else
                {
                    XmlElement ObjROOTAutenticacion = ObjDocumentoXML.CreateElement("AutenticacionSQL");
                    ObjROOTAutenticacion.InnerText = string.Empty;
                    ObjROOTEtiquetaPrincipal.AppendChild(ObjROOTAutenticacion);

                    XmlElement ObjROOTContrasena = ObjDocumentoXML.CreateElement("ContraseñaSQL");
                    ObjROOTContrasena.InnerText = string.Empty;
                    ObjROOTEtiquetaPrincipal.AppendChild(ObjROOTContrasena);
                }

                //Creamos una instancia de SQLConnection la cuál nos permitirá probar el archivo de conexión
                SqlConnection ObjConexion = Conexion.ProbarConexionXML(ObjAgregarConexion.txtServidorURL.Text.Trim(), ObjAgregarConexion.txtBaseDeDatos.Text.Trim(),
                                                                       ObjAgregarConexion.txtAutenticacion.Text.Trim(), ObjAgregarConexion.txtContrasena.Text.Trim());

                //Si el testeo de la prueba de conexión fue inexistente (null), mandamos un mensaje de error al usuario
                if (ObjConexion == null)
                {
                    MessageBox.Show("Error al guardar la configuración del servidor, no se lograron identificar las variables de conexión", "Archivo de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Guardamos en las variables estáticas conexión generada por el archivo XML
                    ObjDocumentoXML.Save("Configuracion_Servidor.xml");
                    DTOAgregarConexion.Server = ObjAgregarConexion.txtServidorURL.Text.Trim();
                    DTOAgregarConexion.Database = ObjAgregarConexion.txtBaseDeDatos.Text.Trim();
                    DTOAgregarConexion.User = ObjAgregarConexion.txtAutenticacion.Text.Trim();
                    DTOAgregarConexion.Password = ObjAgregarConexion.txtContrasena.Text.Trim();
                    MessageBox.Show("El archivo fue creado exitosamente, le recomendamos volver abrir el programa para que los cambios surtan efecto", "Archivo de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
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