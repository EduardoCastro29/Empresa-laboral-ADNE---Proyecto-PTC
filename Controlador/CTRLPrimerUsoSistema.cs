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
using Aspose.Email;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;

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

            //Validaciones de Campos
            ObjPrimerUsoSistema.dpCreacionEmpresa.Value = DateTime.Now;
            ObjPrimerUsoSistema.dpCreacionEmpresa.Enabled = false;
            ObjPrimerUsoSistema.dpCreacionEmpresa.ValueChanged += new EventHandler(ComprobarFechaActual);
            ObjPrimerUsoSistema.txtCorreoElectronico.KeyPress += new KeyPressEventHandler(ValidarCampoCorreo);
            ObjPrimerUsoSistema.txtDireccion.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjPrimerUsoSistema.txtNombreEmpresa.KeyPress += new KeyPressEventHandler(ValidarCampoNombre);
            ObjPrimerUsoSistema.txtTelefono.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjPrimerUsoSistema.txtPBX.KeyPress += new KeyPressEventHandler(ValidarCampoPBX);
        }
        #region Validaciones de Campos
        private void ValidarCampoNumero(object sender, KeyPressEventArgs e )
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }

            //Si el textbox está vacío, permitimos solo los caracteres 6, 7 o 2
            if (ObjPrimerUsoSistema.txtTelefono.Text.Length == 0)
            {
                if (e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '2')
                {
                    e.Handled = true;
                }
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            char ch = e.KeyChar;
            if ((ch >= '0' && ch <= '9') ||
                (ch == '-'))
            {
                return;
            }
            e.Handled = true;
        }
        private void ValidarCampoPBX(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }

            //Si el textbox está vacío, permitimos solo los caracteres 6, 7 o 2
            if (ObjPrimerUsoSistema.txtPBX.Text.Length == 0)
            {
                if (e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '2')
                {
                    e.Handled = true;
                }
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            char ch = e.KeyChar;
            if ((ch >= '0' && ch <= '9') ||
                (ch == '-'))
            {
                return;
            }
            e.Handled = true;
        }
        private void ComprobarFechaActual(object sender, EventArgs e)
        {
            // Verificar si la fecha seleccionada es mayor que la fecha de hoy
            if (ObjPrimerUsoSistema.dpCreacionEmpresa.Value.Date > DateTime.Today || ObjPrimerUsoSistema.dpCreacionEmpresa.Value.Date < DateTime.Today)
            {
                // Mostrar un mensaje de advertencia
                MessageBox.Show("La fecha de la creación de la empresa no puede ser una fecha futura o pasada", "Registro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Restablecer la fecha al valor anterior o a la fecha actual
                ObjPrimerUsoSistema.dpCreacionEmpresa.Value = DateTime.Today;
            }
        }
        private void ValidarCampoCorreo(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            char ch = e.KeyChar;

            //Declaramos lo valores que únicamente permitirá el textbox
            if ((ch >= '0' && ch <= '9') ||
                (ch >= 'A' && ch <= 'Z') ||
                (ch >= 'a' && ch <= 'z') ||
                 ch == '.' ||
                 ch == '@' ||
                 ch == '_')
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        private void ValidarCampoTextBox(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            char ch = e.KeyChar;

            if ((ch >= '0' && ch <= '9') ||
                (ch >= 'A' && ch <= 'Z') ||
                (ch >= 'a' && ch <= 'z') ||
                ch == ' ' ||
                ch == ',' ||
                ch == '.' ||
                ch == '#')
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        private void ValidarCampoNombre(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }

            if (char.IsLetter(e.KeyChar) ||
                e.KeyChar == ' ')
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        #endregion
        #region Registrar la primera empresa según el primer uso del Sistema (INSERT)
        private void RegistrarEmpresa(object sender, EventArgs e)
        {
            try
            {

                if (ObjPrimerUsoSistema.txtNombreEmpresa.Text.Length < 5 ||
                    ObjPrimerUsoSistema.txtDireccion.Text.Length < 5 ||
                    ObjPrimerUsoSistema.txtCorreoElectronico.Text.Length < 10 ||
                    ObjPrimerUsoSistema.txtTelefono.Text.Length < 9 ||
                    ObjPrimerUsoSistema.txtPBX.Text.Length < 9)
                {
                    MessageBox.Show("Verifique si tiene campos vacios, la empresa no puede ser registrada sin datos faltantes o campos requeridos mínimos", "Regtistro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DAOPrimerUsoSistema ObjRegistrarEmpresa = new DAOPrimerUsoSistema();

                    //Insertamos los valores que conllevan al registro de la Primera Empresa
                    ObjRegistrarEmpresa.NombreEmpresa = ObjPrimerUsoSistema.txtNombreEmpresa.Text.Trim();
                    ObjRegistrarEmpresa.DireccionEmpresa = ObjPrimerUsoSistema.txtCorreoElectronico.Text.Trim();
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

                    if (VerificarCorreoUsuario(ObjPrimerUsoSistema.txtCorreoElectronico.Text) == true)
                    {
                        ObjRegistrarEmpresa.CorreoElectronicoE = ObjPrimerUsoSistema.txtCorreoElectronico.Text.Trim();
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
                    else
                    {
                        MessageBox.Show("El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", "Primer Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique si tiene campos vacios, la empresa no puede ser registrada sin datos faltantes o campos requeridos mínimos", "Regtistro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region Método para insertar la imagen de la Empresa y de igual forma Mostrarla
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
        #endregion
        #region Validar el campo de Correo Electrónico
        //Creamos un método de tipo booleano, de esta forma nos permitirá retornar un valor (ya sea verdadero o falso)
        //Y de esta forma, poderse igualar en una condición if
        //Si el método fuera de tipo void, solo se podría llamar al método, las condiciones no estaría permitidas
        private bool VerificarCorreoUsuario(string TextBoxEMAILRegistro)
        {
            try
            {
                //Indicamos el formato EMAIL que contendrá nuestra variable string
                //Este es el formato de EMAIL común para cualquier tipo de dominio
                bool VerificarFormato = Regex.IsMatch(TextBoxEMAILRegistro, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                //Si el formato de correo no es correcto, retornamos falso
                if (VerificarFormato != true)
                    return false;

                //Creamos un bloque TryCatch que nos retornará si el dominio ingresado tiene una dirección válida dentro de la librería de correos
                try
                {
                    //Ahora, procedemos a evaluar si el dominio ingresado, existe dentro de los formatos EMAIL
                    //La variable denominada "var" es utilizada para declarar variables que no se definen como tal (bool, string, int)
                    //Sin embargo, se les puede dar uso posteriormente, en este caso igualandola a una variable de tipo string
                    var DominioCorreo = new MailAddress(TextBoxEMAILRegistro);

                    //Ahora, procedemos a verificar la existencia actual del dominio para ese mismo campo de Correo Electrónico
                    //Primero, declaramos que el dominio lo almacenaremos en una variable de tipo string
                    string DominioHost = DominioCorreo.Host;

                    //Ahora, comprobamos la existencia del dominio y registro MX
                    bool ComprobarMXDominio = Dns.GetHostAddresses(DominioHost).Any(IPAddress => IPAddress.AddressFamily == AddressFamily.InterNetwork);
                    if (ComprobarMXDominio != true)
                        return false;

                    //Ahora, indicamos la dirección de la IP de entrada del Host
                    //De esta forma, nos permitirá entrar al DNS respectivo del dominio del correo
                    try
                    {
                        IPHostEntry ObjIPEntrada = Dns.GetHostEntry(DominioHost);
                    }
                    catch (SocketException SocketEx)
                    {
                        //En caso de error, mostranos el mensaje con su retorno falso
                        MessageBox.Show(SocketEx.Message);
                        return false;
                    }
                }
                catch (FormatException FormatEx)
                {
                    MessageBox.Show(FormatEx.Message);
                    return false;
                }
            }
            catch (AsposeException AsposeEx)
            {
                //En caso de error, mostramos el mensaje con su retorno falso
                MessageBox.Show(AsposeEx.Message);
                return false;
            }

            //Si todo salio bien, retornamos verdadero
            return true;
        }
        #endregion
    }
}