using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Drawing.Printing;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.IO;
using System.Drawing;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLPrimerUsoSistema
    {
        readonly PrimerUsoSistemaForm ObjPrimerUsoSistema;

        public CTRLPrimerUsoSistema(PrimerUsoSistemaForm Vista)
        {
            ObjPrimerUsoSistema = Vista;

            ObjPrimerUsoSistema.btnRegistrar.Click += new EventHandler(RegistrarEmpresa);
            ObjPrimerUsoSistema.btnAgregarLogo.Click += new EventHandler(MostrarLogoEmpresa);
        }
        private void RegistrarEmpresa(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(ObjPrimerUsoSistema.txtNombreEmpresa.Text) ||
                    string.IsNullOrWhiteSpace(ObjPrimerUsoSistema.txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(ObjPrimerUsoSistema.txtCorreoElectronico.Text) ||
                    string.IsNullOrWhiteSpace(ObjPrimerUsoSistema.txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(ObjPrimerUsoSistema.txtPBX.Text))
                {
                    MessageBox.Show("Verifique si tiene campos vacios, la empresa no puede ser registrada sin datos faltantes", "Regtistro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DAOPrimerUsoSistema ObjRegistrarEmpresa = new DAOPrimerUsoSistema();

                    //Insertamos los valores que conllevan al registro de la Primera Empresa
                    ObjRegistrarEmpresa.NombreEmpresa = ObjPrimerUsoSistema.txtNombreEmpresa.Text.Trim();
                    ObjRegistrarEmpresa.DireccionEmpresa = ObjPrimerUsoSistema.txtCorreoElectronico.Text.Trim();
                    ObjRegistrarEmpresa.CorreoElectronicoE = ObjPrimerUsoSistema.txtCorreoElectronico.Text.Trim();
                    ObjRegistrarEmpresa.NumeroTelefono = ObjPrimerUsoSistema.txtTelefono.Text.Trim();
                    ObjRegistrarEmpresa.NumeroPBX = ObjPrimerUsoSistema.txtPBX.Text.Trim();
                    ObjRegistrarEmpresa.FeghaCreacionE = ObjPrimerUsoSistema.dpCreacionEmpresa.Value;

                    //Guardar imagen
                    if (ObjPrimerUsoSistema.pbLogo.Image != null)
                    {
                        string rutaImagen = ObjPrimerUsoSistema.ofdImagen.FileName;
                        string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string carpetaDestino = Path.Combine(escritorio, "Imagenes");

                        Directory.CreateDirectory(carpetaDestino);

                        string imagenDestino = Path.Combine(carpetaDestino, Guid.NewGuid().ToString() + Path.GetExtension(rutaImagen));
                        File.Copy(rutaImagen, imagenDestino);
                        try
                        {
                            ObjRegistrarEmpresa.FotoEmpresa = imagenDestino; //Terminamos de guardar imagen
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        ObjRegistrarEmpresa.FotoEmpresa = ""; //Terminamos de guardar imagen
                    }

                    if (ObjRegistrarEmpresa.RegistrarEmpresa() == true)
                    {
                        MessageBox.Show("El registro de la empresa ha sido existoso, ahora procederemos a crear el primer usuario", "Regtistro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RegistroForm ObjRegistrarPrimerUsuario = new RegistroForm();
                        ObjPrimerUsoSistema.Hide();
                        ObjRegistrarPrimerUsuario.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la empresa, verifique si todos los campos han sido ingresados correctamente", "Regtistro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MostrarLogoEmpresa(object sender, EventArgs e)
        {
            ObjPrimerUsoSistema.ofdImagen.Filter = "Archivos De Imagen | *.jpg; *.png; *.jpeg;";
            try
            {
                if (ObjPrimerUsoSistema.ofdImagen.ShowDialog() == DialogResult.OK)
                {
                    string ruta = ObjPrimerUsoSistema.ofdImagen.FileName;
                    ObjPrimerUsoSistema.pbLogo.Image = Image.FromFile(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}