using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Runtime.InteropServices.ComTypes;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Text.RegularExpressions;
using Aspose.Email;
using System.Net.Sockets;
using System.Net;
using System.Drawing.Imaging;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLConfiguracionUsuario
    {
        readonly ConfiguraciónDeUsuarioForm ObjConfiguracionUsuario;
        public CTRLConfiguracionUsuario(ConfiguraciónDeUsuarioForm Vista)
        {
            ObjConfiguracionUsuario = Vista;

            ObjConfiguracionUsuario.Load += new EventHandler(AccionesIniciales);

            ObjConfiguracionUsuario.btnCargarImagen.Click += new EventHandler(CargarImagenProfesional);
            ObjConfiguracionUsuario.btnEliminar.Click += new EventHandler(EliminarFotoProfesional);
            ObjConfiguracionUsuario.btnGuardar.Click += new EventHandler(ActualizarProfesionalUsuario);

            //Validaciones de Campos
            ObjConfiguracionUsuario.txtDui.KeyPress += new KeyPressEventHandler(ValidarCampoDocumento);
            ObjConfiguracionUsuario.txtDui.TextChange += new EventHandler(EnmascararCampoDocumento);
            ObjConfiguracionUsuario.txtNombre.KeyPress += new KeyPressEventHandler(ValidarCampoLetra);
            ObjConfiguracionUsuario.txtApellido.KeyPress += new KeyPressEventHandler(ValidarCampoLetra);
            ObjConfiguracionUsuario.txtTelefono.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjConfiguracionUsuario.txtUsuario.KeyPress += new KeyPressEventHandler(ValidarCampoUsuario);
            ObjConfiguracionUsuario.txtCorreo.KeyPress += new KeyPressEventHandler(ValidarCampoCorreo);
        }
        #region Validaciones de Campos
        //Validaciones de campos
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
        private void ValidarCampoUsuario(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar//Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
                return;
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            char ch = e.KeyChar;

            //Declaramos lo valores que únicamente permitirá el textbox
            if ((ch >= '0' && ch <= '9') ||
                (ch >= 'A' && ch <= 'Z') ||
                (ch >= 'a' && ch <= 'z'))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        private void ValidarCampoLetra(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        private void ValidarCampoDocumento(object sender, KeyPressEventArgs e)
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
                (ch == ' ') ||
                (ch == '-'))
            {
                return;
            }
            e.Handled = true;
        }
        private void EnmascararCampoDocumento(object sender, EventArgs e)
        {
            //Obtenemos la longitud actual del textbox para evaluar si es necesario el remplazo por guión (en este caso el DUI) o número
            string EnmascararDUI = ObjConfiguracionUsuario.txtDui.Text.Replace("-", "");

            //Limitamos el textbox para que solo obtenga 9 caracteres
            if (EnmascararDUI.Length > 9)
            {
                EnmascararDUI = EnmascararDUI.Substring(0, 9);
            }

            //Una vez llegada a la longitud deseada, en este caso 8 pone un guión automáticamente para enmascarar el DUI
            if (EnmascararDUI.Length > 8)
            {
                //Indicamos en qué posición se pondrá el guión y que símbolo tomará
                ObjConfiguracionUsuario.txtDui.Text = EnmascararDUI.Insert(8, "-");
            }
            else
            {
                //Caso contrario, no realizamos ningun cambio (no se inserta el guión)
                ObjConfiguracionUsuario.txtDui.Text = EnmascararDUI;
            }

            //Indicamos que la posición inicial del cursor, será al inicio del textbox
            ObjConfiguracionUsuario.txtDui.SelectionStart = ObjConfiguracionUsuario.txtDui.Text.Length;
        }
        private void ValidarCampoNumero(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }

            //Si el textbox está vacío, permitimos solo los caracteres 6, 7 o 2
            if (ObjConfiguracionUsuario.txtTelefono.Text.Length == 0)
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
        #endregion
        #region Eventos Iniciales al cargar el Formulario
        private void AccionesIniciales(object sender, EventArgs e)
        {
            //Estos son los eventos iniciales al cargar el formulario
            //Cargamos todas las variables de inicio de sesión en los textbox respectivos (variables de inicio de sesión)
            ObjConfiguracionUsuario.txtDui.Text = InicioSesion.Dui;
            ObjConfiguracionUsuario.txtNombre.Text = InicioSesion.Nombres;
            ObjConfiguracionUsuario.txtApellido.Text = InicioSesion.Apellidos;
            ObjConfiguracionUsuario.txtTelefono.Text = InicioSesion.Telefono;
            ObjConfiguracionUsuario.txtUsuario.Text = InicioSesion.Usuario;
            ObjConfiguracionUsuario.txtCorreo.Text = InicioSesion.Correo;

            MemoryStream ObjArchivoMemoriaIMG = new MemoryStream(InicioSesion.Imagen);
            ObjConfiguracionUsuario.picProfesional.Image = Image.FromStream(ObjArchivoMemoriaIMG);
        }
        #endregion
        #region Actualización dentro del apartado de Configuración (UPDATE)
        private void ActualizarProfesionalUsuario(object sender, EventArgs e)
        {
            //Empezamos el bloque de código con un try catch, esto para verificar si hubo algún error, identificar la línea respectiva
            try
            {
                //Evaluamos si existen campos vacios dentro del formulario
                if (ObjConfiguracionUsuario.txtUsuario.Text.Length < 2 ||
                    ObjConfiguracionUsuario.txtNombre.Text.Length < 2 ||
                    ObjConfiguracionUsuario.txtCorreo.Text.Length < 10 ||
                    ObjConfiguracionUsuario.txtApellido.Text.Length < 2 ||
                    ObjConfiguracionUsuario.txtDui.Text.Length < 10 ||
                    ObjConfiguracionUsuario.txtTelefono.Text.Length < 9 ||
                    ObjConfiguracionUsuario.picProfesional.Image == Properties.Resources.ProfesionalPic)
                {
                    ObjConfiguracionUsuario.Notificacion1.Show(ObjConfiguracionUsuario, "Error al registrarse, verifique si todos los datos han sido ingresados correctamente o si los datos han sido rellenados con éxito", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    //MessageBox.Show("Error al registrarse, verifique si todos los datos han sido ingresados correctamente o si los datos han sido rellenados con éxito", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Creamos las clases que usaremos para la actualización del PROFESIONAL y USUARIO
                    DAOConfiguracionUsuario ObjDAOActualizarProfesional = new DAOConfiguracionUsuario();

                    ObjDAOActualizarProfesional.Usuario = ObjConfiguracionUsuario.txtUsuario.Text.Trim();
                    ObjDAOActualizarProfesional.DUI = ObjConfiguracionUsuario.txtDui.Text;
                    ObjDAOActualizarProfesional.Nombres = ObjConfiguracionUsuario.txtNombre.Text.Trim();
                    ObjDAOActualizarProfesional.Apellidos = ObjConfiguracionUsuario.txtApellido.Text.Trim();
                    ObjDAOActualizarProfesional.Telefono = ObjConfiguracionUsuario.txtTelefono.Text;

                    if (ObjConfiguracionUsuario.ofdImagen.ShowDialog() == DialogResult.OK)
                    {
                        //Declaramos un objeto del tipo Imagen
                        Image ObjImagenProfesional = ObjConfiguracionUsuario.picProfesional.Image;
                        //Declaramos un arreglo de bytes
                        byte[] ImagenProfesional;
                        //Creamos un archivo de memoria que nos servirá para guardar la Imagen en bytes
                        MemoryStream ObjArchivoMemoria = new MemoryStream();
                        //Indicamos en qué formato en específico se requiere la Imagen a la hora de mostrarla
                        ObjImagenProfesional.Save(ObjArchivoMemoria, ImageFormat.Bmp);
                        //Convertimos la imagen en archivo de bytes
                        ImagenProfesional = ObjArchivoMemoria.ToArray();
                        //Guardamos la imagen correspondiente
                        ObjDAOActualizarProfesional.Imagen = ImagenProfesional;
                    }
                    else
                    {
                        MemoryStream ObjArchivoMemoria = new MemoryStream(InicioSesion.Imagen);
                        ObjDAOActualizarProfesional.Imagen = ObjArchivoMemoria.ToArray();
                    }

                    if (VerificarCorreoUsuario(ObjConfiguracionUsuario.txtCorreo.Text.Trim()) == true)
                    {
                        ObjDAOActualizarProfesional.Correo = ObjConfiguracionUsuario.txtCorreo.Text.Trim();
                        //Finalmente, evaluamos si la actualización se hizo correctamente
                        if (ObjDAOActualizarProfesional.ActualizarUsuarioConfig() == false)
                        {
                            ObjConfiguracionUsuario.Notificacion1.Show(ObjConfiguracionUsuario, "Error al actualizar el profesional, verifique si todos los datos han sido ingresados correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                            //MessageBox.Show("Error al actualizar el profesional, verifique si todos los datos han sido ingresados correctamente", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("El profesional ha sido actualizado correctamente, le recomendamos que reinicie la aplicación para cargar los nuevos datos del usuario", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Reiniciamos la aplicación
                            ObjConfiguracionUsuario.Hide();
                        }
                    }
                    else
                    {
                        ObjConfiguracionUsuario.Notificacion1.Show(ObjConfiguracionUsuario, "El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        //MessageBox.Show("El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                ObjConfiguracionUsuario.Notificacion1.Show(ObjConfiguracionUsuario, "Error al actualizar el profesional, verifique si todos los datos han sido ingresados correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        #endregion
        #region Métodos para cargar, mostrar y eliminar la imagen en el PictureBox
        private void CargarImagenProfesional(object sender, EventArgs e)
        {
            ObjConfiguracionUsuario.ofdImagen.Filter = "Archivos De Imagen | *.jpg; *.png; *.jpeg;";

            try
            {
                if (ObjConfiguracionUsuario.ofdImagen.ShowDialog() == DialogResult.OK)
                {
                    string ruta = ObjConfiguracionUsuario.ofdImagen.FileName;
                    ObjConfiguracionUsuario.picProfesional.Image = Image.FromFile(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EliminarFotoProfesional(object sender, EventArgs e)
        {
            ObjConfiguracionUsuario.picProfesional.Image = null;
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
                    catch (SocketException)
                    {
                        //En caso de error, mostranos el mensaje con su retorno falso
                        ObjConfiguracionUsuario.Notificacion1.Show(ObjConfiguracionUsuario, "El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        return false;
                    }
                }
                catch (FormatException)
                {
                    ObjConfiguracionUsuario.Notificacion1.Show(ObjConfiguracionUsuario, "El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    return false;
                }
            }
            catch (AsposeException)
            {
                //En caso de error, mostramos el mensaje con su retorno falso
                ObjConfiguracionUsuario.Notificacion1.Show(ObjConfiguracionUsuario, "El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return false;
            }

            //Si todo salio bien, retornamos verdadero
            return true;
        }
        #endregion
    }
}