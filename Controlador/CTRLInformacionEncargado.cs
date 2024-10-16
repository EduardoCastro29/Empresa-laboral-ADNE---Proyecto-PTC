//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;
//using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
//using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
//using Bunifu.UI.WinForms.BunifuAnimatorNS;
//using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
//using Aspose.Email;
//using System.Net.Sockets;
//using System.Net;
//using System.Text.RegularExpressions;

//namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
//{
//    internal class CTRLInformacionEncargado
//    {
//        readonly InformaciónEncargadoForm ObjInformacionENCForm;
//        public CTRLInformacionEncargado(InformaciónEncargadoForm Vista)
//        {
//            ObjInformacionENCForm = Vista;

//            //Indicamos que, cuando se cargue el formulario, la fecha predeterminada sea a la de 18 años
//            ObjInformacionENCForm.dtFechaNacimiento.Value = DateTime.Today.AddYears(-18);

//            ObjInformacionENCForm.Load += new EventHandler(CargarCMBRelaciones);
//            ObjInformacionENCForm.btnRegistrarEncargado.Click += new EventHandler(RegistrarEncargadoPA);

//            //Validaciones de campos
//            ObjInformacionENCForm.rbDUI.CheckedChanged += new EventHandler(ValidarRBDui);
//            ObjInformacionENCForm.rbPasaporte.CheckedChanged += new EventHandler(ValidarRBPasaporte);
//            ObjInformacionENCForm.txtNombresEncargado.KeyPress += new KeyPressEventHandler(ValidarCampoNombres);
//            ObjInformacionENCForm.txtApellidosEncargado.KeyPress += new KeyPressEventHandler(ValidarCampoNombres);
//            ObjInformacionENCForm.dtFechaNacimiento.ValueChanged += new EventHandler(ComprobarFechaActual);
//            ObjInformacionENCForm.txtTelefono.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
//            ObjInformacionENCForm.txtCorreoEncargado.KeyPress += new KeyPressEventHandler(ValidarCampoCorreo);
//            ObjInformacionENCForm.txtDomicilio.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
//        }
//        #region Eventos iniciales al cargar el Formulario
//        private void CargarCMBRelaciones(object sender, EventArgs e)
//        {
//            //Cargamos el combobox de Encargado del paciente
//            DAOInformacionEncargado ObjCargarCMBENC = new DAOInformacionEncargado();

//            ObjInformacionENCForm.cmbRelacionPaciente.DataSource = ObjCargarCMBENC.AgregarCMBEncargado();
//            ObjInformacionENCForm.cmbRelacionPaciente.ValueMember = "relacionEncargadoId";
//            ObjInformacionENCForm.cmbRelacionPaciente.DisplayMember = "relacionEncargado";

//            ObjInformacionENCForm.txtEdadEncargado.Enabled = false;

//            if (string.IsNullOrWhiteSpace(ObjInformacionENCForm.txtDocumentoEncargado.Text))
//            {
//                ObjInformacionENCForm.btnActualizarEncargado.Enabled = false;
//                ObjInformacionENCForm.btnEliminarEncargado.Enabled = false;
//            }
//            else
//            {
//                ObjInformacionENCForm.btnRegistrarEncargado.Enabled = false;
//            }
//        }
//        #endregion
//        #region Validaciones de campos
//        private void ComprobarFechaActual(object sender, EventArgs e)
//        {
//            //Verificamos si la fecha seleccionada es mayor que la fecha de hoy
//            if (ObjInformacionENCForm.dtFechaNacimiento.Value.Date > DateTime.Today)
//            {
//                //En caso de error, mostramos un mensaje de error
//                ObjInformacionENCForm.NotificacionNuevoEncargado.Show(ObjInformacionENCForm, "La fecha de nacimiento no puede ser una fecha futura.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);

//                //Restablecemos la fecha al valor anterior o a la fecha actual
//                ObjInformacionENCForm.dtFechaNacimiento.Value = DateTime.Today;
//            }
//            else
//            {
//                //Calculamos la edad de la persona, en este caso para el textbox
//                int CalcularEdad = DateTime.Today.Year - ObjInformacionENCForm.dtFechaNacimiento.Value.Year;

//                //En una sentencia if, ajustamos la edad si la fecha de nacimiento aún no ha ocurrido este año
//                if (DateTime.Today.DayOfYear < ObjInformacionENCForm.dtFechaNacimiento.Value.DayOfYear)
//                {
//                    //Calculamos la edad según los años recorridos
//                    CalcularEdad--;
//                }

//                //Actualizamos la edad según la fecha actual del DateTimePicker
//                ObjInformacionENCForm.txtEdadEncargado.Text = CalcularEdad.ToString();

//                //Verificamos si la edad es menor a 18 años
//                if (CalcularEdad < 18)
//                {
//                    //En caso de mostrarnos un error, mandamos un mensaje de error validando el ingreso correcto de la fecha propuesta
//                    MessageBox.Show("La edad mínima para registrar encargado es de 18 años", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

//                    //Restablecemos la fecha al valor anterior o a una fecha válida (hace 18 años)
//                    ObjInformacionENCForm.dtFechaNacimiento.Value = DateTime.Today.AddYears(-18);
//                }
//                //Verificamos si la edad es mayor a 120 años, por políticas de seguridad, la persona registrada no puede ser mayor a 120 años
//                else if (CalcularEdad > 120)
//                {
//                    //En caso de mostrarnos un error, mandamos un mensaje de error validando el ingreso correcto de la fecha propuesta
//                    MessageBox.Show("La edad máxima permitida es de 120 años", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

//                    //Restablecemos la fecha al valor máximo permitido (120 años)
//                    ObjInformacionENCForm.dtFechaNacimiento.Value = DateTime.Today.AddYears(-120);
//                }
//                else
//                {
//                    //Actualizamos el campo de la edad según la edad calculada
//                    ObjInformacionENCForm.txtEdadEncargado.Text = CalcularEdad.ToString();
//                }
//            }
//        }
//        private void ValidarCampoNombres(object sender, KeyPressEventArgs e)
//        {
//            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
//            if (char.IsControl(e.KeyChar))
//            {
//                //Retornamos los valores e.KeyChar
//                return;
//            }
//            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
//            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
//            {
//                //Retornamos los valores e.KeyChar
//                return;
//            }
//            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
//            e.Handled = true;
//        }
//        private void ValidarCampoTextBox(object sender, KeyPressEventArgs e)
//        {
//            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
//            if (char.IsControl(e.KeyChar))
//            {
//                //Retornamos los valores e.KeyChar
//                return;
//            }
//            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
//            if (char.IsLetter(e.KeyChar) ||
//                e.KeyChar == ' ' ||
//                e.KeyChar == ',' ||
//                e.KeyChar == '.')
//            {
//                //Retornamos los valores e.KeyChar
//                return;
//            }
//            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
//            e.Handled = true;
//        }
//        private void ValidarCampoCorreo(object sender, KeyPressEventArgs e)
//        {
//            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
//            if (char.IsControl(e.KeyChar))
//            {
//                //Retornamos los valores e.KeyChar
//                return;
//            }
//            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
//            char ch = e.KeyChar;

//            //Declaramos lo valores que únicamente permitirá el textbox
//            if ((ch >= '0' && ch <= '9') ||
//                (ch >= 'A' && ch <= 'Z') ||
//                (ch >= 'a' && ch <= 'z') ||
//                 ch == '.' ||
//                 ch == '@' ||
//                 ch == '_')
//            {
//                //Retornamos los valores e.KeyChar
//                return;
//            }
//            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
//            e.Handled = true;
//        }
//        private void ValidarCampoDocumento(object sender, KeyPressEventArgs e)
//        {
//            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
//            if (char.IsControl(e.KeyChar))
//            {
//                //Retornamos los valores e.KeyChar
//                return;
//            }
//            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
//            char ch = e.KeyChar;

//            if ((ch >= '0' && ch <= '9'))
//            {
//                return;
//            }
//            e.Handled = true;
//        }
//        private void ValidarCampoPasaporte(object sender, KeyPressEventArgs e)
//        {
//            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
//            if (char.IsControl(e.KeyChar))
//            {
//                //Retornamos los valores e.KeyChar
//                return;
//            }
//            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
//            char ch = e.KeyChar;

//            if ((ch >= '0' && ch <= '9') ||
//                (ch >= 'A' && ch <= 'Z'))
//            {
//                return;
//            }
//            e.Handled = true;
//        }
//        private void EnmascararCampoDocumento(object sender, EventArgs e)
//        {
//            //Obtenemos la longitud actual del textbox para evaluar si es necesario el remplazo por guión (en este caso el DUI) o número
//            string EnmascararDUI = ObjInformacionENCForm.txtDocumentoEncargado.Text.Replace("-", "");

//            //Limitamos el textbox para que solo obtenga 9 caracteres
//            if (EnmascararDUI.Length > 9)
//            {
//                EnmascararDUI = EnmascararDUI.Substring(0, 9);
//            }

//            //Una vez llegada a la longitud deseada, en este caso 8 pone un guión automáticamente para enmascarar el DUI
//            if (EnmascararDUI.Length > 8)
//            {
//                //Indicamos en qué posición se pondrá el guión y que símbolo tomará
//                ObjInformacionENCForm.txtDocumentoEncargado.Text = EnmascararDUI.Insert(8, "-");
//            }
//            else
//            {
//                //Caso contrario, no realizamos ningun cambio (no se inserta el guión)
//                ObjInformacionENCForm.txtDocumentoEncargado.Text = EnmascararDUI;
//            }

//            //Indicamos que la posición inicial del cursor, será al inicio del textbox
//            ObjInformacionENCForm.txtDocumentoEncargado.SelectionStart = ObjInformacionENCForm.txtDocumentoEncargado.Text.Length;
//        }
//        private void ValidarRBDui(object sender, EventArgs e)
//        {
//            if (ObjInformacionENCForm.rbDUI.Checked)
//            {
//                //Si el RadioButton de DUI se selecciona por preferencia, validamos el campo respectivo
//                ObjInformacionENCForm.txtDocumentoEncargado.KeyPress += new KeyPressEventHandler(ValidarCampoDocumento);
//                ObjInformacionENCForm.txtDocumentoEncargado.TextChange += new EventHandler(EnmascararCampoDocumento);
//            }
//        }
//        private void ValidarRBPasaporte(object sender, EventArgs e)
//        {
//            if (ObjInformacionENCForm.rbPasaporte.Checked)
//            {
//                //Si el RadioButton de Pasaporte se selecciona por preferencia, validamos el campo respectivo
//                ObjInformacionENCForm.txtDocumentoEncargado.KeyPress += new KeyPressEventHandler(ValidarCampoPasaporte);
//            }
//        }
//        private void ValidarCampoNumero(object sender, KeyPressEventArgs e)
//        {
//            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
//            if (char.IsControl(e.KeyChar))
//            {
//                //Retornamos los valores e.KeyChar
//                return;
//            }

//            //Si el textbox está vacío, permitimos solo los caracteres 6, 7 o 2
//            if (ObjInformacionENCForm.txtTelefono.Text.Length == 0)
//            {
//                if (e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '2')
//                {
//                    e.Handled = true;
//                }
//            }
//            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
//            char ch = e.KeyChar;
//            if ((ch >= '0' && ch <= '9') ||
//                (ch == '-'))
//            {
//                return;
//            }
//            e.Handled = true;
//        }
//        #endregion
//        #region Inserción en el Formulario de Información del Encargado (INSERT)
//        private void RegistrarEncargadoPA(object sender, EventArgs e)
//        {
//            if (ObjInformacionENCForm.txtDocumentoEncargado.Text.Length < 9 ||
//                ObjInformacionENCForm.txtNombresEncargado.Text.Length < 2 ||
//                ObjInformacionENCForm.txtApellidosEncargado.Text.Length < 2 ||
//                ObjInformacionENCForm.dtFechaNacimiento.Value.Date > DateTime.Today ||
//                string.IsNullOrWhiteSpace(ObjInformacionENCForm.txtEdadEncargado.Text) ||
//                ObjInformacionENCForm.txtTelefono.Text.Length < 9 ||
//                ObjInformacionENCForm.txtCorreoEncargado.Text.Length < 10 ||
//                ObjInformacionENCForm.txtDomicilio.Text.Length < 5)
//            {
//                ObjInformacionENCForm.NotificacionNuevoEncargado.Show(ObjInformacionENCForm, "Verifique si existe algún campo faltante o los datos no han sido proporcionados correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
//            }
//            else
//            {
//                //Inicializamos los comandos
//                DAOInformacionEncargado ObjRegistrarEncargado = new DAOInformacionEncargado();

//                ObjRegistrarEncargado.DocumentoPresentado = ObjInformacionENCForm.txtDocumentoEncargado.Text.Trim();
//                ObjRegistrarEncargado.Nombre = ObjInformacionENCForm.txtNombresEncargado.Text.Trim();
//                ObjRegistrarEncargado.Apellido = ObjInformacionENCForm.txtApellidosEncargado.Text.Trim();
//                ObjRegistrarEncargado.FechaNacimiento = ObjInformacionENCForm.dtFechaNacimiento.Value;
//                ObjRegistrarEncargado.Edad = int.Parse(ObjInformacionENCForm.txtEdadEncargado.Text.Trim());
//                ObjRegistrarEncargado.Telefono = ObjInformacionENCForm.txtTelefono.Text.Trim();
//                ObjRegistrarEncargado.Domicilio = ObjInformacionENCForm.txtDomicilio.Text.Trim();
//                ObjRegistrarEncargado.DocumentoPresentadoP = ObjInformacionENCForm.txtDocumentoPaciente.Text.Trim();
//                ObjRegistrarEncargado.RelacionEncargadoId = int.Parse(ObjInformacionENCForm.cmbRelacionPaciente.SelectedValue.ToString());

//                if (VerificarCorreoUsuario(ObjInformacionENCForm.txtCorreoEncargado.Text.Trim()) == true)
//                {
//                    ObjRegistrarEncargado.CorreoElectronico = ObjInformacionENCForm.txtCorreoEncargado.Text.Trim();

//                    //Llamamos al método para registrar el encargado
//                    if (ObjRegistrarEncargado.RegistrarEncargado() == true)
//                    {
//                        ObjInformacionENCForm.NotificacionNuevoEncargado.Show(ObjInformacionENCForm, "Los datos han sido registrados exitosamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
//                        ObjInformacionENCForm.Hide();
//                    }
//                    else
//                    {
//                        ObjInformacionENCForm.NotificacionNuevoEncargado.Show(ObjInformacionENCForm, "Los datos no pudieron ser registrados, verifique si existe algún campo faltante o los datos no han sido proporcionados correctamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
//                    }
//                }
//                else
//                {
//                    ObjInformacionENCForm.NotificacionNuevoEncargado.Show(ObjInformacionENCForm, "El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
//                }
//            }
//        }
//        #endregion
//        #region Validar el campo de Correo Electrónico
//        //Creamos un método de tipo booleano, de esta forma nos permitirá retornar un valor (ya sea verdadero o falso)
//        //Y de esta forma, poderse igualar en una condición if
//        //Si el método fuera de tipo void, solo se podría llamar al método, las condiciones no estaría permitidas
//        private bool VerificarCorreoUsuario(string TextBoxEMAILRegistro)
//        {
//            try
//            {
//                //Indicamos el formato EMAIL que contendrá nuestra variable string
//                //Este es el formato de EMAIL común para cualquier tipo de dominio
//                bool VerificarFormato = Regex.IsMatch(TextBoxEMAILRegistro, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

//                //Si el formato de correo no es correcto, retornamos falso
//                if (VerificarFormato != true)
//                    return false;

//                //Creamos un bloque TryCatch que nos retornará si el dominio ingresado tiene una dirección válida dentro de la librería de correos
//                try
//                {
//                    //Ahora, procedemos a evaluar si el dominio ingresado, existe dentro de los formatos EMAIL
//                    //La variable denominada "var" es utilizada para declarar variables que no se definen como tal (bool, string, int)
//                    //Sin embargo, se les puede dar uso posteriormente, en este caso igualandola a una variable de tipo string
//                    var DominioCorreo = new MailAddress(TextBoxEMAILRegistro);

//                    //Ahora, procedemos a verificar la existencia actual del dominio para ese mismo campo de Correo Electrónico
//                    //Primero, declaramos que el dominio lo almacenaremos en una variable de tipo string
//                    string DominioHost = DominioCorreo.Host;

//                    //Ahora, comprobamos la existencia del dominio y registro MX
//                    bool ComprobarMXDominio = Dns.GetHostAddresses(DominioHost).Any(IPAddress => IPAddress.AddressFamily == AddressFamily.InterNetwork);
//                    if (ComprobarMXDominio != true)
//                        return false;

//                    //Ahora, indicamos la dirección de la IP de entrada del Host
//                    //De esta forma, nos permitirá entrar al DNS respectivo del dominio del correo
//                    try
//                    {
//                        IPHostEntry ObjIPEntrada = Dns.GetHostEntry(DominioHost);
//                    }
//                    catch (SocketException SocketEx)
//                    {
//                        //En caso de error, mostranos el mensaje con su retorno falso
//                        MessageBox.Show(SocketEx.Message);
//                        return false;
//                    }
//                }
//                catch (FormatException FormatEx)
//                {
//                    MessageBox.Show(FormatEx.Message);
//                    return false;
//                }
//            }
//            catch (AsposeException AsposeEx)
//            {
//                //En caso de error, mostramos el mensaje con su retorno falso
//                MessageBox.Show(AsposeEx.Message);
//                return false;
//            }

//            //Si todo salio bien, retornamos verdadero
//            return true;
//        }
//        #endregion
//    }
//}