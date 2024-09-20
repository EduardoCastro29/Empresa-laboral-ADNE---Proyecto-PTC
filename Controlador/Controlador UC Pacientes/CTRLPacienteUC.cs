using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Aspose.Email;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Linq;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador.ControladorUserControlPaciente
{
    internal class CTRLPacienteUC
    {
        readonly ControlVerPacientesUC ObjVerPacienteUS;
        readonly InformaciónPersonalForm ObjInformacionPersonal;
        NuevoPacienteForm ObjVerDatosPaciente = null;
        Form FormActual;

        // Primer Controlador de la vista del user control
        public CTRLPacienteUC(ControlVerPacientesUC vista) // Controlador de la vista del User control
        {
            ObjVerPacienteUS = vista;
            // Metodo para cargar la Informacion del Paciente
            ObjVerPacienteUS.btnVerInformacion.Click += new EventHandler(CargarInformacionPersonal);
            ObjVerPacienteUS.btnVerExpediente.Click += new EventHandler(CargarExpediente);
        }
        #region Método para cargar el Formulario (Lleno con los datos) de la Información Personal de la persona
        // Metodo para cargar la Informacion del Paciente
        private void CargarInformacionPersonal(object sender, EventArgs e)
        {
            if (ObjVerDatosPaciente == null || ObjVerDatosPaciente.IsDisposed)
            {
                ObjVerDatosPaciente = new NuevoPacienteForm();
                ObjVerDatosPaciente.btnExpediente.Enabled = false;
                try
                {
                    DAOInformacionPersonal ObjDaoInformacionPersonal = new DAOInformacionPersonal();
                    ObjDaoInformacionPersonal.DocumentoPresentado = ObjVerPacienteUS.lblPacienteId.Text; // Asigna el ID del paciente que deseas cargar

                    bool Comprobar = ObjDaoInformacionPersonal.ObtenerInformacionPaciente();
                    if (Comprobar)
                    {
                        InformaciónPersonalForm ObjVerInformacion = new InformaciónPersonalForm();

                        // Pasar datos al formulario
                        ObjVerInformacion.dtFechaNacimiento.Value = ObjDaoInformacionPersonal.FechaNacimiento;
                        ObjVerInformacion.txtNombrePaciente.Text = ObjDaoInformacionPersonal.Nombre;
                        ObjVerInformacion.txtApellidoPaciente.Text = ObjDaoInformacionPersonal.Apellido;
                        ObjVerInformacion.txtDomicilio.Text = ObjDaoInformacionPersonal.Domicilio;
                        ObjVerInformacion.txtNacionalidad.Text = ObjDaoInformacionPersonal.Nacionalidad;
                        ObjVerInformacion.txtDocumentoPresentado.Text = ObjDaoInformacionPersonal.DocumentoPresentado;
                        ObjVerInformacion.txtCorreoElectronico.Text = ObjDaoInformacionPersonal.CorreoElectronico;
                        ObjVerInformacion.txtTelefono1.Text = ObjDaoInformacionPersonal.Telefono;
                        ObjVerInformacion.txtProfesion.Text = ObjDaoInformacionPersonal.Profesion;
                        ObjVerInformacion.txtEdad.Text = ObjDaoInformacionPersonal.Edad.ToString();
                        ObjVerInformacion.txtComposicionFamiliar.Text = ObjDaoInformacionPersonal.ComposicionFamiliar;
                        ObjVerInformacion.txtMotivoIntervencion.Text = ObjDaoInformacionPersonal.Motivo;
                        ObjVerInformacion.txtAntecedentes.Text = ObjDaoInformacionPersonal.Antecedente;
                        ObjVerInformacion.txtDescripcion.Text = ObjDaoInformacionPersonal.Descripcion;
                        ObjVerInformacion.txtAspectosPreocupantes.Text = ObjDaoInformacionPersonal.AspectosPreocupantes;
                        ObjVerInformacion.cmbGeneroId.SelectedValue = ObjDaoInformacionPersonal.GeneroId1;

                        AbrirFormulario(ObjVerInformacion);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para el paciente seleccionado.",
                                       "Proceso interrumpido",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ObjVerDatosPaciente.Show();
            }
            else
            {
                ObjVerDatosPaciente.BringToFront();
            }
        }
        #endregion
        #region Método para cargar el Formulario (Lleno con los datos) del Expediente de la persona
        //Método para cargar los datos de expediente
        private void CargarExpediente(object sender, EventArgs e)
        {
            if (ObjVerDatosPaciente == null || ObjVerDatosPaciente.IsDisposed)
            {
                ObjVerDatosPaciente = new NuevoPacienteForm();
                ObjVerDatosPaciente.btnDatosIdentificacion.Enabled = false;

                try
                {
                    DAODiagnosticoPsicosocial objDAOExpedienteMedico = new DAODiagnosticoPsicosocial();
                    objDAOExpedienteMedico.DocumentoPresentado = ObjVerPacienteUS.lblPacienteId.Text;

                    //Se asigna el ID del expediente que se desea cargar
                    bool Comprobar = objDAOExpedienteMedico.ObtenerExpedientePaciente();
                    ExpedienteMédicoForm objExpedienteMedico = new ExpedienteMédicoForm();
                    if (Comprobar == true)
                    {

                        objExpedienteMedico.txtEstadoAnimo.Text = objDAOExpedienteMedico.EstadoAnimo;
                        objExpedienteMedico.txtEstadoConductual.Text = objDAOExpedienteMedico.EstadoConductual;
                        objExpedienteMedico.txtSomatizacion.Text = objDAOExpedienteMedico.Somatizacion;
                        objExpedienteMedico.txtVidaInterpersonal.Text = objDAOExpedienteMedico.VidaInterpersonal;
                        objExpedienteMedico.txtCognicion.Text = objDAOExpedienteMedico.Cognicion;
                        objExpedienteMedico.txtRedSocial.Text = objDAOExpedienteMedico.RedSocial;
                        objExpedienteMedico.txtPauta.Text = objDAOExpedienteMedico.Pauta;
                        objExpedienteMedico.txtRiesgoValorado.Text = objDAOExpedienteMedico.RiesgoValorado;
                        objExpedienteMedico.txtObservacion.Text = objDAOExpedienteMedico.Observacion;
                        objExpedienteMedico.txtAproximacionDiag.Text = objDAOExpedienteMedico.AproximacionDiag;
                        objExpedienteMedico.txtAtencionBrindada.Text = objDAOExpedienteMedico.AtencionBrindada;
                        objExpedienteMedico.txtDocumentoPaciente.Text = objDAOExpedienteMedico.DocumentoPresentado;

                        objExpedienteMedico.btnGuardar.Enabled = false;
                        objExpedienteMedico.btnModificar.Enabled = true;
                        objExpedienteMedico.txtDocumentoPaciente.Enabled = false;

                        AbrirFormulario(objExpedienteMedico);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para el expediente seleccionado.",
                                        "Proceso interrumpido",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        objExpedienteMedico.txtDocumentoPaciente.Text  = objDAOExpedienteMedico.DocumentoPresentado;
                        objExpedienteMedico.txtDocumentoPaciente.Enabled = false;
                        AbrirFormulario(objExpedienteMedico);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ObjVerDatosPaciente.Show();
            }
            else
            {
                ObjVerDatosPaciente.BringToFront();
            }
        }
        #endregion
        #region Método para cargar un formulario dentro del formulario padre (al que queremos llamar)
        private void AbrirFormulario(Form Formulario)
        {
            //Creamos un objeto de tipo Forms que heredara el nuevo Formulario
            Form nuevoFormulario;
            //Se guardan los datos en el panelGeneralVistas que hereda el objeto nuevoFormulario que abrira el Formulario
            nuevoFormulario = ObjVerDatosPaciente.panelElement.Controls.OfType<Form>().FirstOrDefault(ParametroFormulario => ParametroFormulario.GetType() == Formulario.GetType());
            //Si el objeto nuevoFormulario no llegase a existir, se crea uno nuevo
            if (nuevoFormulario == null)
            {
                //Se declara un uevo formulario que tendra como instancia <Formulario>
                nuevoFormulario = Formulario;
                //Especificamos que el formulario deberá abrirse como ventana
                //Evitando los marcos de WindowsForms
                nuevoFormulario.TopLevel = false;
                //Se eliminan los bordes del formulario
                nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
                //Declaramos que utilizará todo el espacio del Panel
                nuevoFormulario.Dock = DockStyle.Fill;
                //Evaluamos si el FormularioActual es nulo, en caso de serlo, se ejecuta el siguiente código
                if (FormActual != null)
                {
                    //Se cierra el formulario actual para mostrar el nuevo formulario
                    FormActual.Close();
                    //Se eliminan todos los controles del FormularioActual dentro del panel
                    ObjVerDatosPaciente.panelElement.Controls.Remove(FormActual);
                }
                //Establecemos que el FormularioActual es igual al nuevo formulario creado
                FormActual = nuevoFormulario;
                //Se agregan los controles que fueron previamente puestos en el nuevoFormulario dentro del Panel
                ObjVerDatosPaciente.panelElement.Controls.Add(nuevoFormulario);
                ObjVerDatosPaciente.panelElement.Tag = nuevoFormulario;
                //Se muestra el objeto nuevoFormulario creado
                nuevoFormulario.Show();
                //Se muestra al frente
                nuevoFormulario.BringToFront();
            }
            else
            {
                //En caso de no haberse ejecutado el código, se trae al frente un formulario nulo
                nuevoFormulario.BringToFront();
            }
        }
        #endregion
        //  Segundo Controlador de la vista de Informacion Personal Forms 
        public CTRLPacienteUC(InformaciónPersonalForm vista) // Controlador de la vista del Informacion Personal
        {
            ObjInformacionPersonal = vista;
            // Metodo para desactivar boton de agregar paciente automaticamente  con el evento Load
            ObjInformacionPersonal.Load += new EventHandler(DesactivarAgregarPaciente);
            // Metodo para actualizar la Informacion del Paciente presionando el boton de Modificar 
            ObjInformacionPersonal.btnModificarPaciente.Click += new EventHandler(ActualizarInformacionPaciente);
            ObjInformacionPersonal.Load += new EventHandler(CargarCMB);

            //Validaciones de Campos
            ObjInformacionPersonal.dtFechaNacimiento.ValueChanged += new EventHandler(ComprobarFechaActual);
            ObjInformacionPersonal.txtNacionalidad.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtProfesion.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtNombrePaciente.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtApellidoPaciente.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtComposicionFamiliar.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtMotivoIntervencion.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtAntecedentes.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtDescripcion.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtAspectosPreocupantes.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjInformacionPersonal.txtDocumentoPresentado.KeyPress += new KeyPressEventHandler(ValidarCampoDocumentoPresentado);
            ObjInformacionPersonal.txtTelefono1.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjInformacionPersonal.txtCorreoElectronico.KeyPress += new KeyPressEventHandler(ValidarCampoCorreo);
        }
        #region Validaciones de Campos
        private void ComprobarFechaActual(object sender, EventArgs e)
        {
            // Verificar si la fecha seleccionada es mayor que la fecha de hoy
            if (ObjInformacionPersonal.dtFechaNacimiento.Value.Date > DateTime.Today)
            {
                // Mostrar un mensaje de advertencia
                MessageBox.Show("La fecha de nacimiento no puede ser una fecha futura.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Restablecer la fecha al valor anterior o a la fecha actual
                ObjInformacionPersonal.dtFechaNacimiento.Value = DateTime.Today;
            }
            else
            {
                // Calcular la edad
                int edad = DateTime.Today.Year - ObjInformacionPersonal.dtFechaNacimiento.Value.Year;

                // Ajustar la edad si la fecha de nacimiento aún no ha ocurrido este año
                if (DateTime.Today.DayOfYear < ObjInformacionPersonal.dtFechaNacimiento.Value.DayOfYear)
                {
                    edad--;
                }

                // Actualizar el campo de texto con la edad calculada
                ObjInformacionPersonal.txtEdad.Text = edad.ToString();
            }
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

        private void ValidarCampoDocumentoPresentado(object sender, KeyPressEventArgs e)
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
                 ch == '-')
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
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
        #endregion
        #region Eventos Iniciales a la hora de cargar el Formulario
        private void CargarCMB(object sender, EventArgs e)
        {
            DAOInformacionPersonal ObjDaoCargarCMB = new DAOInformacionPersonal();
            ObjInformacionPersonal.cmbGeneroId.DataSource = ObjDaoCargarCMB.AgregarCMBGenero();
            ObjInformacionPersonal.cmbGeneroId.ValueMember = "generoId";
            ObjInformacionPersonal.cmbGeneroId.DisplayMember = "genero";
        }
        // Instrucciones que se haran en el metodo DesactivarAgregarPaciente para desactivar el boton de agregar Paciente 
        private void DesactivarAgregarPaciente(object sender, EventArgs e)  // Todo el proceso para desactivar el boton de Guardar Paciente
        {
            ObjInformacionPersonal.btnModificarPaciente.Enabled = true;
            ObjInformacionPersonal.btnGuardarPaciente.Enabled = false;
        }
        #endregion
        #region Actualización en el Formulario de Información Personal
        // Metodo para Actualizar la Informacion del Paciente
        private void ActualizarInformacionPaciente(object sender, EventArgs e)
        {
            try
            {
                if (ObjInformacionPersonal.txtNacionalidad.Text.Length < 5 ||
                    ObjInformacionPersonal.txtDocumentoPresentado.Text.Length < 9 ||
                    string.IsNullOrEmpty(ObjInformacionPersonal.txtEdad.Text) ||
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
                    MessageBox.Show("Error al modificar datos de  paciente, verifique si todos los datos han sido ingresados correctamente o cumple con la cantidad mínima de caracteres", "Actualizar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //En caso contrario, realizamos el proceso de inserción de los datos

                    //Realizamos el proceso para capturar los datos ingresados por el usuario dado el DaoInformacionPersonal
                    DAOInformacionPersonal ObjDAOActualizarInformacionPersonal = new DAOInformacionPersonal();
                    ObjDAOActualizarInformacionPersonal.FechaNacimiento = ObjInformacionPersonal.dtFechaNacimiento.Value.Date;

                    ObjDAOActualizarInformacionPersonal.Nacionalidad = ObjInformacionPersonal.txtNacionalidad.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.DocumentoPresentado = ObjInformacionPersonal.txtDocumentoPresentado.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Edad = int.Parse(ObjInformacionPersonal.txtEdad.Text.Trim());
                    ObjDAOActualizarInformacionPersonal.Telefono = (ObjInformacionPersonal.txtTelefono1.Text.Trim());
                    ObjDAOActualizarInformacionPersonal.Profesion = ObjInformacionPersonal.txtProfesion.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Nombre = ObjInformacionPersonal.txtNombrePaciente.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Apellido = ObjInformacionPersonal.txtApellidoPaciente.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Domicilio = ObjInformacionPersonal.txtDomicilio.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.ComposicionFamiliar = ObjInformacionPersonal.txtComposicionFamiliar.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Motivo = ObjInformacionPersonal.txtMotivoIntervencion.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Antecedente = ObjInformacionPersonal.txtAntecedentes.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.Descripcion = ObjInformacionPersonal.txtDescripcion.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.AspectosPreocupantes = ObjInformacionPersonal.txtAspectosPreocupantes.Text.Trim();
                    ObjDAOActualizarInformacionPersonal.GeneroId1 = int.Parse(ObjInformacionPersonal.cmbGeneroId.SelectedValue.ToString());

                    if (VerificarCorreoUsuario(ObjInformacionPersonal.txtCorreoElectronico.Text) == true)
                    {
                        ObjDAOActualizarInformacionPersonal.CorreoElectronico = ObjInformacionPersonal.txtCorreoElectronico.Text.Trim();
                        bool comprobar = ObjDAOActualizarInformacionPersonal.ActualizarInformacionPaciente();
                        if (comprobar == true)
                        {
                            MessageBox.Show("Los datos han sido actualizados exitosamente",
                                       "Proceso completado",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Los datos no pudieron ser actualizados",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", "Primer Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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