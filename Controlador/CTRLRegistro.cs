using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Security.AccessControl;
using System.Globalization;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Text;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System.Text.RegularExpressions;
using Aspose.Email;
using System.Net.Sockets;
using System.Net;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLRegistro
    {
        readonly RegistroForm ObjRegistro;
        //Empezamos la encapsulación de la clase Controlador Login
        //Esta tendrá como parámetros el formulario Login haciendo referencia a la carpeta Vista
        public CTRLRegistro(RegistroForm Vista)
        {
            //Enlazando el objeto con la Vista dentro del constructor
            ObjRegistro = Vista;

            ObjRegistro.Load += new EventHandler(CargarCMB);

            //Creando el evento EventHandler con el boton Ingresar con parametros AccederLogin, que posteriormente ejecutará un método
            ObjRegistro.btnRegistrar.Click += new EventHandler(AccederLoginPrimerUso);
            ObjRegistro.btnCargarImagen.Click += new EventHandler(CargarImagen);
            ObjRegistro.btnEliminar.Click += new EventHandler(EliminarFoto);

            //Validaciones en los textbox 
            ObjRegistro.txtNombre.KeyPress += new KeyPressEventHandler(ValidarCampoLetra);
            ObjRegistro.txtApellido.KeyPress += new KeyPressEventHandler(ValidarCampoLetra);
            ObjRegistro.txtDui.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjRegistro.txtTelefono.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjRegistro.txtUsuario.KeyPress += new KeyPressEventHandler(ValidarCampoUsuario);
            ObjRegistro.txtCorreo.KeyPress += new KeyPressEventHandler(ValidarCampoCorreo);
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
        private void ValidarCampoNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        #endregion
        #region Eventos Iniciales al cargar el Formulario
        private void CargarCMB(object sender, EventArgs e)
        {
            DAORegistro ObjDAOCargarCMB = new DAORegistro();
            //Combobox Desempeño
            ObjRegistro.cmbDesempeno.DataSource = ObjDAOCargarCMB.AgregarCMBDesempeno();
            ObjRegistro.cmbDesempeno.ValueMember = "desempenoId"; //Agregamos los atributos que estan en la tabla Desempeno
            ObjRegistro.cmbDesempeno.DisplayMember = "desempeno"; //Lo que se mostrara del Value
            ObjRegistro.cmbDesempeno.Enabled = false;

            ////Combobox Especialidad 
            //ObjRegistro.cmbEspecialidad1.DataSource = ObjDAOCargarCMB.AgregarCMBEspecialidad();
            //ObjRegistro.cmbEspecialidad1.ValueMember = "especialidadId"; //Agregamos los atributos que estan en la tabla Especialidad
            //ObjRegistro.cmbEspecialidad1.DisplayMember = "nombreEspecialidad";

            ////Combobox Especialidad Alternativa 
            //ObjRegistro.cmbEspecialidad2.DataSource = ObjDAOCargarCMB.AgregarCMBEspecialidadAlt();
            //ObjRegistro.cmbEspecialidad2.ValueMember = "especialidadAltId";
            //ObjRegistro.cmbEspecialidad2.DisplayMember = "nombreEspecialidadAlt";
        }
        #endregion
        #region Inserción al primer uso del sistema y creación del primer Usuario
        private void AccederLoginPrimerUso(object sender, EventArgs e)
        {
            try
            {
                //Dado el objeto del DAORegistro, evaluamos si los datos fueron ingresados correctamente dados sus métodos
                if (ObjRegistro.txtUsuario.Text.Length < 3 ||
                    ObjRegistro.txtNombre.Text.Length < 3 ||
                    ObjRegistro.txtContrasena.Text.Length < 13 ||
                    ObjRegistro.txtCorreo.Text.Length < 10 ||
                    ObjRegistro.txtApellido.Text.Length < 3 ||
                    ObjRegistro.txtDui.Text.Length < 10 ||
                    ObjRegistro.txtTelefono.Text.Length < 9 ||
                    ObjRegistro.picProfesional.Image == Properties.Resources.ProfesionalPic)
                {
                    //Si los datos no fueron ingresados correctamente, mostramos un mensaje de error
                    MessageBox.Show("Error al registrarse, verifique si todos los datos han sido ingresados correctamente o si los datos han sido rellenados con éxito", "Primer Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //En caso contrario, realizamos el proceso de inserción de los datos

                    //Realizamos el proceso para capturar los datos ingresados por el usuario dado el DAORegistro
                    DAORegistro ObjDAORegistro = new DAORegistro();

                    //Creamos un objeto de la clase CommonMethos para acceder a los métodos comúnes
                    CommonMethods ObjMetodosComunes = new CommonMethods();

                    //Obtenemos datos del objeto ObjDAORegistro
                    ObjDAORegistro.Usuario = ObjRegistro.txtUsuario.Text.Trim();
                    //Mandamos a llamar el método MetodoEncriptacionAES para encriptarla y enviarla a la base de datos
                    ObjDAORegistro.Contraseña = ObjMetodosComunes.MetodoEncriptacionAES(ObjRegistro.txtContrasena.Text.Trim());

                    //Obtenemos los datos del Profesional
                    ObjDAORegistro.Dui = ObjRegistro.txtDui.Text;
                    ObjDAORegistro.Nombres = ObjRegistro.txtNombre.Text.Trim();
                    ObjDAORegistro.Apellidos = ObjRegistro.txtApellido.Text.Trim();
                    ObjDAORegistro.Telefono = ObjRegistro.txtTelefono.Text;
                    ObjDAORegistro.DesempenoId = 1;
                    //ObjDAORegistro.Especialidad = int.Parse(ObjRegistro.cmbEspecialidad1.SelectedValue.ToString());
                    //ObjDAORegistro.EspecialidadAlt = int.Parse(ObjRegistro.cmbEspecialidad2.SelectedValue.ToString());

                    //Guardar imagen
                    if (ObjRegistro.picProfesional.Image != Properties.Resources.ProfesionalPic)
                    {
                        string rutaImagen = ObjRegistro.ofdImagen.FileName;
                        string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string carpetaDestino = Path.Combine(escritorio, "Imagenes");

                        Directory.CreateDirectory(carpetaDestino);

                        string imagenDestino = Path.Combine(carpetaDestino, Guid.NewGuid().ToString() + Path.GetExtension(rutaImagen));
                        File.Copy(rutaImagen, imagenDestino);
                        try
                        {
                            ObjDAORegistro.Imagen = imagenDestino; //Terminamos de guardar imagen
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        ObjDAORegistro.Imagen = Properties.Resources.ProfesionalPic.ToString(); //Terminamos de guardar imagen
                    }

                    //Llamamos al método de verificación de correo electrónico
                    //De esta forma, nos aseguramos de ingresar una dirección de correo válida
                    //Caso contrario, llegase a retornar null, la inserción no se ejecuta y nos mandará un mensaje de error
                    if (VerificarCorreoUsuario(ObjRegistro.txtCorreo.Text.Trim()) == true)
                    {
                        ObjDAORegistro.Correo = ObjRegistro.txtCorreo.Text.Trim();
                        //Llamamos a los métodos para verificar si la inserción se hizo correctamente 
                        if (ObjDAORegistro.RegistroInsertarUsuarioProfesional() == false)
                        {
                            MessageBox.Show("Oops!, Algo salió mal, verifique si todas las credenciales han sido ingresadas correctamente", "Primer Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Excelente", "Primer Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RegistroEspecialidadesForm ObjAbrirRegistroEspecialidad = new RegistroEspecialidadesForm();

                            //Guardamos las variables de registro que se han hecho durante la inserción de la tabla profesional
                            ObjAbrirRegistroEspecialidad.txtDUIProfesional.Text = ObjRegistro.txtDui.Text.Trim();
                            ObjAbrirRegistroEspecialidad.picProfesional.Image = Image.FromFile(ObjDAORegistro.Imagen);
                            ObjAbrirRegistroEspecialidad.lblNombreProfesional.Text = ObjDAORegistro.Nombres + " " + ObjDAORegistro.Apellidos;

                            ObjAbrirRegistroEspecialidad.ShowDialog();
                            ObjRegistro.Hide();

                            //Ocultamos el formulario de registro y le daremos la bienvenida al Login
                            LoginForm ObjMostrarLogin = new LoginForm();
                            ObjMostrarLogin.Show();
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
                MessageBox.Show("El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", "Primer Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Métodos para cargar y mostrar la imagen en el PictureBox
        private void CargarImagen(object sender, EventArgs e)
        {
            ObjRegistro.ofdImagen.Filter = "Archivos de Imagen | *.jpg; *.png; *.jpeg;";

            try
            {
                if (ObjRegistro.ofdImagen.ShowDialog() == DialogResult.OK)
                {
                    string ruta = ObjRegistro.ofdImagen.FileName;
                    ObjRegistro.picProfesional.Image = Image.FromFile(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EliminarFoto(object sender, EventArgs e)
        {
            ObjRegistro.picProfesional.Image = null;
            ObjRegistro.picProfesional.Image = Properties.Resources.ProfesionalPic;
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