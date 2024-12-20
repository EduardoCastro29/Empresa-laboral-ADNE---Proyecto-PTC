﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using Aspose.Email;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Automation;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLInformacionPersonal
    {
        readonly NuevoPacienteForm objNuevoPaciente = new NuevoPacienteForm();
        readonly InformaciónPersonalForm ObjInformacionPersonal;
        //Empezamos la encapsulación de la clase Controlador Login
        //Esta tendrá como parámetros el formulario Informacion Personal haciendo referencia a la carpeta Vista
        public CTRLInformacionPersonal(InformaciónPersonalForm vista)
        {
            //Enlazando el objeto con la Vista dentro del constructor
            ObjInformacionPersonal = vista;
            ObjInformacionPersonal.Load += new EventHandler(Modificar);
            ObjInformacionPersonal.btnGuardarPaciente.Click += new EventHandler(GuardarInformacionPersonal);
            ObjInformacionPersonal.rbDUI.CheckedChanged += new EventHandler(ValidarRBDui);
            ObjInformacionPersonal.rbPasaporte.CheckedChanged += new EventHandler(ValidarRBPasaporte);

            //Validaciones de Campos
            ObjInformacionPersonal.dtFechaNacimiento.ValueChanged += new EventHandler(ComprobarFechaActual);
            ObjInformacionPersonal.txtNacionalidad.KeyPress += new KeyPressEventHandler(ValidarCampoNombres);
            ObjInformacionPersonal.txtProfesion.KeyPress += new KeyPressEventHandler(ValidarCampoNombres);
            ObjInformacionPersonal.txtNombrePaciente.KeyPress += new KeyPressEventHandler(ValidarCampoNombres);
            ObjInformacionPersonal.txtApellidoPaciente.KeyPress += new KeyPressEventHandler(ValidarCampoNombres);
            ObjInformacionPersonal.txtComposicionFamiliar.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtMotivoIntervencion.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtAntecedentes.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtDescripcion.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtAspectosPreocupantes.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtDocumentoPresentado.KeyPress += new KeyPressEventHandler(ValidarCampoDocumento);
            ObjInformacionPersonal.txtPasaporte.KeyPress += new KeyPressEventHandler(ValidarCampoPasaporte);
            ObjInformacionPersonal.txtDocumentoPresentado.TextChange += new EventHandler(EnmascararCampoDocumento);
            ObjInformacionPersonal.txtTelefono1.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjInformacionPersonal.txtCorreoElectronico.KeyPress += new KeyPressEventHandler(ValidarCampoCorreo);
        }
        #region Validaciones de Campos
        private void ComprobarFechaActual(object sender, EventArgs e)
        {
            //Verificamos si la fecha seleccionada es mayor que la fecha de hoy
            if (ObjInformacionPersonal.dtFechaNacimiento.Value.DayOfYear > DateTime.Today.Year)
            {
                //En caso de error, mostramos un mensaje de error
                objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "La fecha de nacimiento no puede ser una fecha futura.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);

                //Restablecemos la fecha al valor anterior o a la fecha actual
                ObjInformacionPersonal.dtFechaNacimiento.Value = DateTime.Today;
            }
            else
            {
                //Calculamos la edad de la persona, en este caso para el textbox
                int CalcularEdad = DateTime.Today.Year - ObjInformacionPersonal.dtFechaNacimiento.Value.Year;

                //En una sentencia if, ajustamos la edad si la fecha de nacimiento aún no ha ocurrido este año
                if (DateTime.Today.DayOfYear < ObjInformacionPersonal.dtFechaNacimiento.Value.DayOfYear)
                {
                    //Calculamos la edad según los años recorridos
                    CalcularEdad--;
                }

                //Actualizamos la edad según la fecha actual del DateTimePicker
                ObjInformacionPersonal.txtEdad.Text = CalcularEdad.ToString();

                //Verificamos si la edad es menor a 2 años, por políticas de seguridad, la persona registrada no puede ser menor a 2 años
                if (CalcularEdad < 2)
                {
                    //En caso de mostrarnos un error, mandamos un mensaje de error validando el ingreso correcto de la fecha propuesta
                    MessageBox.Show("La edad mínima para registrar un paciente es de 2 años", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //Restablecemos la fecha al valor anterior o a una fecha válida (hace 2 años)
                    ObjInformacionPersonal.dtFechaNacimiento.Value = DateTime.Today.AddYears(-2);
                }

                //Aquí yacía el método del encargado, pipipi :"v

                //Verificamos si la edad es mayor a 120 años, por políticas de seguridad, la persona registrada no puede ser mayor a 120 años
                else if (CalcularEdad > 120)
                {
                    //En caso de mostrarnos un error, mandamos un mensaje de error validando el ingreso correcto de la fecha propuesta
                    MessageBox.Show("La edad máxima permitida es de 120 años", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //Restablecemos la fecha al valor máximo permitido (120 años)
                    ObjInformacionPersonal.dtFechaNacimiento.Value = DateTime.Today.AddYears(-120);
                }
                else
                {
                    //Actualizamos el campo de la edad según la edad calculada
                    ObjInformacionPersonal.txtEdad.Text = CalcularEdad.ToString();
                }
            }
        }
        private void ValidarCampoNombres(object sender, KeyPressEventArgs e)
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
        private void ValidarCampoTextBox(object sender, KeyPressEventArgs e)
        {
            //La propiedad char.IsControl permite controles como BackSpace, Inicio, Fin, etc.
            if (char.IsControl(e.KeyChar))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Declaramos la variable de tipo char que recibirá los parámetros de las letras registradas por las variables e.KeyChar creadas anteriormente
            if (char.IsLetter(e.KeyChar) ||
                e.KeyChar == ' ' ||
                e.KeyChar == ',' ||
                e.KeyChar == '.')
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
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
                (ch == '-'))
            {
                return;
            }
            e.Handled = true;
        }
        private void ValidarCampoPasaporte(object sender, KeyPressEventArgs e)
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
                (ch >= 'A' && ch <= 'Z'))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        private void EnmascararCampoDocumento(object sender, EventArgs e)
        {
            //Obtenemos la longitud actual del textbox para evaluar si es necesario el remplazo por guión (en este caso el DUI) o número
            string EnmascararDUI = ObjInformacionPersonal.txtDocumentoPresentado.Text.Replace("-", "");

            //Limitamos el textbox para que solo obtenga 9 caracteres
            if (EnmascararDUI.Length > 9)
            {
                EnmascararDUI = EnmascararDUI.Substring(0, 9);
            }

            //Una vez llegada a la longitud deseada, en este caso 8 pone un guión automáticamente para enmascarar el DUI
            if (EnmascararDUI.Length > 8)
            {
                //Indicamos en qué posición se pondrá el guión y que símbolo tomará
                ObjInformacionPersonal.txtDocumentoPresentado.Text = EnmascararDUI.Insert(8, "-");
            }
            else
            {
                //Caso contrario, no realizamos ningun cambio (no se inserta el guión)
                ObjInformacionPersonal.txtDocumentoPresentado.Text = EnmascararDUI;
            }

            //Indicamos que la posición inicial del cursor, será al inicio del textbox
            ObjInformacionPersonal.txtDocumentoPresentado.SelectionStart = ObjInformacionPersonal.txtDocumentoPresentado.Text.Length;
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
            if (ObjInformacionPersonal.txtTelefono1.Text.Length == 0)
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
        private void ValidarRBDui(object sender, EventArgs e)
        {
            if (ObjInformacionPersonal.rbDUI.Checked)
            {
                //Si el RadioButton de DUI se selecciona por preferencia, validamos el campo respectivo
                ObjInformacionPersonal.txtPasaporte.Visible = false;
                ObjInformacionPersonal.txtPasaporte.Clear();
                ObjInformacionPersonal.txtDocumentoPresentado.Visible = true;
            }
        }
        private void ValidarRBPasaporte(object sender, EventArgs e)
        {
            if (ObjInformacionPersonal.rbPasaporte.Checked)
            {
                //Si el RadioButton de Pasaporte se selecciona por preferencia, validamos el campo respectivo
                ObjInformacionPersonal.txtPasaporte.Visible = true;
                ObjInformacionPersonal.txtDocumentoPresentado.Visible = false;
                ObjInformacionPersonal.txtDocumentoPresentado.Clear();
            }
        }
        #endregion
        #region Inserción en el Formulario de Información Personal (INSERT)
        private void GuardarInformacionPersonal(object sender, EventArgs e)
        {
            try
            {
                //Dado el objeto del DaoInformacionPersonal, evaluamos si los datos fueron ingresados correctamente dados sus métodos
                if (ObjInformacionPersonal.txtNacionalidad.Text.Length < 3 ||
                    //ObjInformacionPersonal.txtDocumentoPresentado.Text.Length < 9 ||
                    string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtEdad.Text.Trim()) ||
                    ObjInformacionPersonal.txtTelefono1.Text.Length < 9 ||
                    ObjInformacionPersonal.txtProfesion.Text.Length < 3 ||
                    ObjInformacionPersonal.txtNombrePaciente.Text.Length < 2 ||
                    ObjInformacionPersonal.txtApellidoPaciente.Text.Length < 2 ||
                    ObjInformacionPersonal.txtCorreoElectronico.Text.Length < 10 ||
                    ObjInformacionPersonal.txtComposicionFamiliar.Text.Length < 3 ||
                    ObjInformacionPersonal.txtMotivoIntervencion.Text.Length < 5 ||
                    ObjInformacionPersonal.txtAntecedentes.Text.Length < 5 ||
                    ObjInformacionPersonal.txtDescripcion.Text.Length < 5 ||
                    ObjInformacionPersonal.dtFechaNacimiento.Value.Date > DateTime.Today ||
                    ObjInformacionPersonal.txtAspectosPreocupantes.Text.Length < 5)
                {
                    //Si los datos no fueron ingresados correctamente, mostramos un mensaje de error
                    objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Verifique si todos los datos han sido ingresados correctamente o cumplen con la regla mínima de carácteres", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    //MessageBox.Show("Error al registrar paciente, verifique si todos los datos han sido ingresados correctamente o cumplen con la regla mínima de carácteres", "Registrar paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //if (ObjInformacionPersonal.rbDUI.Checked == true)
                //{
                //    if (ObjInformacionPersonal.txtDocumentoPresentado.Text.Length < 9)
                //    {
                //        objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Verifique si todos los datos han sido ingresados correctamente o cumplen con la regla mínima de carácteres", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                //    }
                //}
                //else if (ObjInformacionPersonal.rbPasaporte.Checked == true)
                //{
                //    if (ObjInformacionPersonal.txtPasaporte.Text.Length < 7)
                //    {
                //        objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Verifique si todos los datos han sido ingresados correctamente o cumplen con la regla mínima de carácteres", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                //    }
                //}
                else
                {
                    //Caso contrario, realizamos el proceso de inserción de los datos

                    //Realizamos el proceso para capturar los datos ingresados por el usuario dado el DaoInformacionPersonal
                    DAOInformacionPersonal ObjDAOInformacionPersonal = new DAOInformacionPersonal();
                    ObjDAOInformacionPersonal.FechaNacimiento = ObjInformacionPersonal.dtFechaNacimiento.Value.Date;

                    ObjDAOInformacionPersonal.Nacionalidad = ObjInformacionPersonal.txtNacionalidad.Text.Trim();
                    ObjDAOInformacionPersonal.GeneroId1 = int.Parse(ObjInformacionPersonal.cmbGeneroId.SelectedValue.ToString());
                    ObjDAOInformacionPersonal.Edad = int.Parse(ObjInformacionPersonal.txtEdad.Text.Trim());
                    ObjDAOInformacionPersonal.Telefono = (ObjInformacionPersonal.txtTelefono1.Text.Trim());
                    ObjDAOInformacionPersonal.Profesion = ObjInformacionPersonal.txtProfesion.Text.Trim();
                    ObjDAOInformacionPersonal.Nombre = ObjInformacionPersonal.txtNombrePaciente.Text.Trim();
                    ObjDAOInformacionPersonal.Apellido = ObjInformacionPersonal.txtApellidoPaciente.Text.Trim();
                    ObjDAOInformacionPersonal.Domicilio = ObjInformacionPersonal.txtDomicilio.Text.Trim();
                    ObjDAOInformacionPersonal.ComposicionFamiliar = ObjInformacionPersonal.txtComposicionFamiliar.Text.Trim();
                    ObjDAOInformacionPersonal.Motivo = ObjInformacionPersonal.txtMotivoIntervencion.Text.Trim();
                    ObjDAOInformacionPersonal.Antecedente = ObjInformacionPersonal.txtAntecedentes.Text.Trim();
                    ObjDAOInformacionPersonal.Descripcion = ObjInformacionPersonal.txtDescripcion.Text.Trim();
                    ObjDAOInformacionPersonal.AspectosPreocupantes = ObjInformacionPersonal.txtAspectosPreocupantes.Text.Trim();

                    if (ObjInformacionPersonal.rbDUI.Checked == true)
                    {
                        ObjDAOInformacionPersonal.DocumentoPresentado = ObjInformacionPersonal.txtDocumentoPresentado.Text.Trim();
                    }
                    else
                    {
                        ObjDAOInformacionPersonal.DocumentoPresentado = ObjInformacionPersonal.txtPasaporte.Text.Trim();
                    }

                    if (VerificarCorreoUsuario(ObjInformacionPersonal.txtCorreoElectronico.Text) == true)
                    {
                        ObjDAOInformacionPersonal.CorreoElectronico = ObjInformacionPersonal.txtCorreoElectronico.Text.Trim();
                        //Llamamos a los métodos para verificar si la inserción se hizo correctamente
                        bool Comprobar = ObjDAOInformacionPersonal.InsertarInformacionPaciente();
                        if (Comprobar == true)
                        {
                            //MessageBox.Show("Los datos han sido registrados exitosamente",
                            //            "Proceso completado",
                            //            MessageBoxButtons.OK,
                            //            MessageBoxIcon.Information);
                            objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Los datos han sido registrados exitosamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                            LimpiarCampos();
                        }
                        else
                        {
                            //MessageBox.Show("Los datos no pudieron ser registrados",
                            //           "Proceso interrumpido",
                            //           MessageBoxButtons.OK,
                            //           MessageBoxIcon.Error);
                            objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Los datos no pudieron ser registrados", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        }
                    }
                    else
                    {
                        //MessageBox.Show("El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", "Información Personal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Limpiar campos después de cada realización en el Formulario
        private void LimpiarCampos()
        {
            ObjInformacionPersonal.dtFechaNacimiento.Value = DateTime.Today.AddYears(-18);
            //DAOInformacionEncargado.DocumentoEncargado = null;
            ObjInformacionPersonal.txtNacionalidad.Clear();
            ObjInformacionPersonal.txtDocumentoPresentado.Clear();
            ObjInformacionPersonal.txtEdad.Clear();
            ObjInformacionPersonal.txtTelefono1.Clear();
            ObjInformacionPersonal.txtProfesion.Clear();
            ObjInformacionPersonal.txtNombrePaciente.Clear();
            ObjInformacionPersonal.txtApellidoPaciente.Clear();
            ObjInformacionPersonal.txtDomicilio.Clear();
            ObjInformacionPersonal.txtCorreoElectronico.Clear();
            ObjInformacionPersonal.txtComposicionFamiliar.Clear();
            ObjInformacionPersonal.txtMotivoIntervencion.Clear();
            ObjInformacionPersonal.txtAntecedentes.Clear();
            ObjInformacionPersonal.txtDescripcion.Clear();
            ObjInformacionPersonal.txtAspectosPreocupantes.Clear();
        }
        #endregion
        private void Modificar(object sender, EventArgs e)
        {
            DAOInformacionPersonal ObjDaoCargarCMB = new DAOInformacionPersonal();
            ObjInformacionPersonal.cmbGeneroId.DataSource = ObjDaoCargarCMB.AgregarCMBGenero();
            ObjInformacionPersonal.cmbGeneroId.ValueMember = "generoId";
            ObjInformacionPersonal.cmbGeneroId.DisplayMember = "genero";
            ObjInformacionPersonal.txtEdad.Enabled = false;

            if (ObjInformacionPersonal.rbDUI.Checked == true)
            {
                ObjInformacionPersonal.txtPasaporte.Visible = false;
                ObjInformacionPersonal.txtDocumentoPresentado.Visible = true;
            }
            else
            {
                ObjInformacionPersonal.txtPasaporte.Visible = true;
                ObjInformacionPersonal.txtDocumentoPresentado.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtDocumentoPresentado.Text) && string.IsNullOrWhiteSpace(ObjInformacionPersonal.txtPasaporte.Text))
            {
                ObjInformacionPersonal.btnGuardarPaciente.Enabled = true;
                ObjInformacionPersonal.btnModificarPaciente.Enabled = false;
                ObjInformacionPersonal.btnVerEncargado.Visible = false;
            }
            else
            {
                ObjInformacionPersonal.btnModificarPaciente.Enabled = true;
                ObjInformacionPersonal.btnGuardarPaciente.Enabled = false;
            }
        }
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
        //if (CalcularEdad < 18 && DAOInformacionEncargado.DocumentoEncargado == null)
        //{
        //    //En el caso de que la persona sea menor a 18 años, mostramos un mensaje especificando si desea establecer un ecargado al paciente registrado
        //    if (MessageBox.Show("La edad de la persona ingresada es menor a 18 años, desea agregarle un encargado al paciente registrado?", "Agregar Encargado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        InformaciónEncargadoForm ObjAbrirInformacionEncargado = new InformaciónEncargadoForm();
        //        string CapturarDUIPaciente = ObjInformacionPersonal.txtDocumentoPresentado.Text.Trim();
        //        ObjAbrirInformacionEncargado.txtDocumentoPaciente.Text = CapturarDUIPaciente;
        //        ObjAbrirInformacionEncargado.ShowDialog();
        //    }
        //    else
        //    {
        //        //Si la respuesta al DialogueResult fuese que no, restablecemos la fecha a 18 años
        //        ObjInformacionPersonal.dtFechaNacimiento.Value = DateTime.Today.AddYears(-18);
        //    }
        //}
    }
}