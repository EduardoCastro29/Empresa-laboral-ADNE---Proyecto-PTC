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

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLAdministrador
    {
        //El formulario Registro poseerá 2 constructores
        //Con lo cual, es necesario saber que constructor accionara cierta acción
        //Para eso usaremos un if dentro del InitialComponent del Formulario de registro

        readonly AdministradorForm ObjAdministradorForm;
        readonly RegistroForm ObjRegistroForm;

        /**                     CONSTRUCTOR DEL FORMULARIO ADMINISTRADOR                     **/
        //Este es el constructor del DataGridView
        public CTRLAdministrador(AdministradorForm Vista)
        {
            ObjAdministradorForm = Vista;

            RecargarDGVEmpleados();

            //Creamos el evento que nos redireccionará al formulario de Agregar nuevo Profesional
            ObjAdministradorForm.btnAñadirProfesional.Click += new EventHandler(AbrirAgregarProfesional);
            ObjAdministradorForm.cmsActualizar.Click += new EventHandler(AbrirActualizarProfesional);
            ObjAdministradorForm.cmsEliminarProfesional.Click += new EventHandler(EliminarProfesional);
            ObjAdministradorForm.cmsVerEspecialidades.Click += new EventHandler(AbrirEspecialidadesProfesional);
            ObjAdministradorForm.txtBuscarEmpleado.KeyPress += new KeyPressEventHandler(BuscarProfesional);
        }
        #region Eventos Iniciales al cargar el Formulario
        private void RecargarDGVEmpleados()
        {
            DAOAdministrador ObjDAOLlenarDGV = new DAOAdministrador();
            DataTable ObjDTLlenarDGV = ObjDAOLlenarDGV.CargarDataGrid();
            try
            {
                //Indicamos que el DGV no posee datos
                ObjAdministradorForm.dgvAdministrarProfesional.DataSource = null;

                //Cargamos los datos
                ObjAdministradorForm.dgvAdministrarProfesional.DataSource = ObjDTLlenarDGV;

                //Indicamos que columnas no queremos que se muestren a simple vista
                ObjAdministradorForm.dgvAdministrarProfesional.Columns[0].Visible = false;
                ObjAdministradorForm.dgvAdministrarProfesional.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Abrir desde el DGV la inserción de un nuevo Profesional (INSERT)
        private void AbrirAgregarProfesional(object sender, EventArgs e)
        {
            //Procedemos a abrir el formulario de agregar nuevo profesional
            RegistroForm ObjAgregarRegistroProfesional = new RegistroForm();
            ObjAgregarRegistroProfesional.ShowDialog();

            //Refrescamos el DataGridView cuando el formulario se cierre por completo
            RecargarDGVEmpleados();
        }
        #endregion
        #region Abrir desde el DGV la actualización de un nuevo Profesional (UPDATE)
        private void AbrirActualizarProfesional(object sender, EventArgs e)
        {
            //Indicamos la fila específica del DataGridView que se mostrará en el formulario de registro
            //Recordemos que, como es actualizar, necesitamos mostrar los datos respectivos del DataGrid de la fila que estamos mostrando
            //Creamos una instancia del formulario registro, el cuál usaremos mas adelante
            RegistroForm ObjActualizarProfesional = new RegistroForm();

            //Capturamos las filas del DatGridView al cuál queremos mostrar los valores
            int PosicionFila = ObjAdministradorForm.dgvAdministrarProfesional.CurrentRow.Index;

            //Capturamos los datos de cada dato del DataGridView, iniciamos con el ID de la persona
            //Asignamos las respectivas variables para ser mostradas dentro del formulario de registro
            int IDUsuario = int.Parse(ObjAdministradorForm.dgvAdministrarProfesional[0, PosicionFila].Value.ToString());
            string DUIProfesional = ObjAdministradorForm.dgvAdministrarProfesional[1, PosicionFila].Value.ToString();
            string TelefonoProfesional = ObjAdministradorForm.dgvAdministrarProfesional[2, PosicionFila].Value.ToString();
            string NombreProfesional = ObjAdministradorForm.dgvAdministrarProfesional[3, PosicionFila].Value.ToString();
            string ApellidosProfesional = ObjAdministradorForm.dgvAdministrarProfesional[4, PosicionFila].Value.ToString();
            string CorreoProfesional = ObjAdministradorForm.dgvAdministrarProfesional[5, PosicionFila].Value.ToString();
            string ImagenProfesional = ObjAdministradorForm.dgvAdministrarProfesional[6, PosicionFila].Value.ToString();
            string DesempenoProfesional = ObjAdministradorForm.dgvAdministrarProfesional[7, PosicionFila].Value.ToString();
            string NombreUsuario = ObjAdministradorForm.dgvAdministrarProfesional[8, PosicionFila].Value.ToString();
            //string Especialidad = ObjAdministradorForm.dgvAdministrarProfesional[9, PosicionFila].Value.ToString();
            //string EspecialidadAlt = ObjAdministradorForm.dgvAdministrarProfesional[10, PosicionFila].Value.ToString();

            //Ahora, procedemos a usar la instancia antes establecida para mostrar los valores de las filas encontradas            
            ObjActualizarProfesional.txtIDUsuario.Text = IDUsuario.ToString();
            ObjActualizarProfesional.txtDui.Text = DUIProfesional;
            ObjActualizarProfesional.txtTelefono.Text = TelefonoProfesional;
            ObjActualizarProfesional.txtNombre.Text = NombreProfesional;
            ObjActualizarProfesional.txtApellido.Text = ApellidosProfesional;
            ObjActualizarProfesional.txtCorreo.Text = CorreoProfesional;
            //ObjActualizarProfesional.picProfesional.Image = Image.FromFile(ImagenProfesional);
            ObjActualizarProfesional.cmbDesempeno.SelectedValue = DesempenoProfesional;
            ObjActualizarProfesional.txtUsuario.Text = NombreUsuario;
            //ObjActualizarProfesional.cmbEspecialidad1.SelectedValue = Especialidad;
            //ObjActualizarProfesional.cmbEspecialidad2.SelectedValue = EspecialidadAlt;

            //Especificamos qué apartados no deben de mostrarse a la hora del Update
            ObjActualizarProfesional.btnRegistrar.Visible = false;
            ObjActualizarProfesional.bpRegistrar.Visible = false;
            //Mostramos el Formulario
            ObjActualizarProfesional.ShowDialog();

            //Refrescamos el DataGridView cuando el formulario se cierre por completo
            RecargarDGVEmpleados();
        }
        #endregion
        #region Abrir desde el DGV la vista de las especialidades de un Profesional (READ/INSERT/DELETE/UPDATE)
        private void AbrirEspecialidadesProfesional(object sender, EventArgs e)
        {
            //Indicamos la fila específica del DataGridView que se mostrará en el formulario de registro especialidades
            //Recordemos que, como es actualizar, necesitamos mostrar los datos respectivos del DataGrid de la fila que estamos mostrando
            //Creamos una instancia del formulario registro especialidades, el cuál usaremos mas adelante
            RegistroEspecialidadesForm ObjVerEspecialidadesForm = new RegistroEspecialidadesForm();

            //Capturamos las filas del DatGridView al cuál queremos mostrar los valores
            int PosicionFila = ObjAdministradorForm.dgvAdministrarProfesional.CurrentRow.Index;

            //Capturamos los datos de cada dato del DataGridView, iniciamos con el DUI de la persona
            //Asignamos las respectivas variables para ser mostradas dentro del formulario de registro especialidades
            string DUIProfesional = ObjAdministradorForm.dgvAdministrarProfesional[1, PosicionFila].Value.ToString();
            string NombreProfesional = ObjAdministradorForm.dgvAdministrarProfesional[3, PosicionFila].Value.ToString() +
                                       " " +
                                       ObjAdministradorForm.dgvAdministrarProfesional[4, PosicionFila].Value.ToString();
            string ImagenProfesional = ObjAdministradorForm.dgvAdministrarProfesional[6, PosicionFila].Value.ToString();


            //Llenamos los valores respectivos para la vista de las especialidades específicas de cada profesional
            ObjVerEspecialidadesForm.txtDUIProfesional.Text = DUIProfesional;
            ObjVerEspecialidadesForm.lblNombreProfesional.Text = NombreProfesional;
            //ObjVerEspecialidadesForm.picProfesional.Image = Image.FromFile(ImagenProfesional);

            //Procedemos a abrir el formulario de agregar nuevo profesional
            ObjVerEspecialidadesForm.ShowDialog();

            //Refrescamos el DataGridView cuando el formulario se cierre por completo
            RecargarDGVEmpleados();
        }
        #endregion
        #region Eliminar un Profesional desde el DataGridView (DELETE)
        private void EliminarProfesional(object sender, EventArgs e)
        {
            //Indicamos en que posición nos encontramos dentro del DataGridView
            int PosicionFila = ObjAdministradorForm.dgvAdministrarProfesional.CurrentRow.Index;

            //Capturamos el valor del ID que queremos eliminar
            int IDUsuario = int.Parse(ObjAdministradorForm.dgvAdministrarProfesional[0, PosicionFila].Value.ToString());

            //Si el usuario coincide con el estado activo dentro del programa, significa que no podrá ser eliminado
            if (IDUsuario == InicioSesion.UsuarioId)
            {
                MessageBox.Show("El profesional seleccionado corresponde al usuario conectado, no puede ser eliminado", "Eliminar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show($"Hola, Administrador, estas seguro de eliminar a:\n" +
                    $" {ObjAdministradorForm.dgvAdministrarProfesional[3, PosicionFila].Value} {ObjAdministradorForm.dgvAdministrarProfesional[4, PosicionFila]}\n" +
                    $", El Usuario y Profesional asociados serán eliminados de forma permanente, se eliminaran todos los datos asociados.", "Eliminar Profesional", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Instanciamos a la clase DAOAdministrador para obtener los valores
                    DAOAdministrador ObjDAOEliminarUsuario = new DAOAdministrador();

                    ObjDAOEliminarUsuario.UsuarioId = IDUsuario;

                    if (ObjDAOEliminarUsuario.EliminarUsuarioEmpleado() == true)
                    {
                        MessageBox.Show("El Profesional se ha eliminado correctamente", "Eliminar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        #endregion
        #region Buscar un profesional por sus denominaciones relevantes (SEARCH)
        private void BuscarProfesional(object sender, KeyPressEventArgs e)
        {
            DAOAdministrador ObjDAOBuscarEmpleado = new DAOAdministrador();
            DataTable ObjBuscar = ObjDAOBuscarEmpleado.BuscarProfesionalP(ObjAdministradorForm.txtBuscarEmpleado.Text);
            ObjAdministradorForm.dgvAdministrarProfesional.DataSource = ObjBuscar;
        }
        #endregion
        /**                     CONSTRUCTOR DEL FORMULARIO DE REGISTRO                     **/
        //Este es el constructor del Controlador Administrador, el cuál tendrá las acciones dentro del InitialComponent
        public CTRLAdministrador(RegistroForm Vista)
        {
            ObjRegistroForm = Vista;

            //Cargamos los combobox
            ObjRegistroForm.Load += new EventHandler(AccionesIniciales);

            //Cargamos los controles
            ObjRegistroForm.btnRegistrar.Click += new EventHandler(GuardarRegistroProfesional);
            ObjRegistroForm.btnGuardar.Click += new EventHandler(ActualizarRegistroProfesional);
            ObjRegistroForm.btnCargarImagen.Click += new EventHandler(CargarImagenProfesional);
            ObjRegistroForm.btnEliminar.Click += new EventHandler(EliminarFotoProfesional);

            //Validar los diferentes TextBox que se encuentran dentro del formulario
            ObjRegistroForm.txtNombre.KeyPress += new KeyPressEventHandler(ValidarCampoLetra);
            ObjRegistroForm.txtApellido.KeyPress += new KeyPressEventHandler(ValidarCampoLetra);
            ObjRegistroForm.txtDui.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjRegistroForm.txtTelefono.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjRegistroForm.txtUsuario.KeyPress += new KeyPressEventHandler(ValidarCampoUsuario);
            ObjRegistroForm.txtCorreo.KeyPress += new KeyPressEventHandler(ValidarCampoCorreo);
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
        private void AccionesIniciales(object sender, EventArgs e)
        {
            //Indicamos cuales son los controles principales que, al cargar el formulario, no se podrán ver a simple vista
            ObjRegistroForm.txtContrasena.Visible = false;
            ObjRegistroForm.bsContrasena.Visible = false;
            ObjRegistroForm.lblContrasena.Visible = false;

            //Podemos reutilizar esta clase para cargar los Combobox Específicos, ya que se trata de un mismo formulario
            //Lo cual, no cambia, sin embargo sí las acciones a realizar
            DAORegistro ObjDAOCargarCMB = new DAORegistro();

            //Combobox Desempeño
            ObjRegistroForm.cmbDesempeno.DataSource = ObjDAOCargarCMB.AgregarCMBDesempeno();
            ObjRegistroForm.cmbDesempeno.ValueMember = "desempenoId";
            ObjRegistroForm.cmbDesempeno.DisplayMember = "desempeno";
        }
        #endregion
        #region Inserción al Formulario de nuevo Profesional (CREATE)
        private void GuardarRegistroProfesional(object sender, EventArgs e)
        {
            try
            {
                if (ObjRegistroForm.txtUsuario.Text.Length < 2 ||
                    ObjRegistroForm.txtNombre.Text.Length < 2 ||
                    ObjRegistroForm.txtCorreo.Text.Length < 10 ||
                    ObjRegistroForm.txtApellido.Text.Length < 2 ||
                    ObjRegistroForm.txtDui.Text.Length < 10 ||
                    ObjRegistroForm.txtTelefono.Text.Length < 9 ||
                    ObjRegistroForm.picProfesional.Image == Properties.Resources.ProfesionalPic)
                {
                    MessageBox.Show("Error al registrarse, verifique si todos los datos han sido ingresados correctamente o si los datos han sido rellenados con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Llamamos a los métodos correspondientes a utilizar
                    DAOAdministrador ObjDAORegistrarProfesional = new DAOAdministrador();
                    CommonMethods ObjMetodosComunes = new CommonMethods();

                    //Obtenemos datos del objeto ObjDAORegistrarProfesional
                    ObjDAORegistrarProfesional.Usuario = ObjRegistroForm.txtUsuario.Text.Trim();
                    //Mandamos a llamar el método MetodoEncriptacionAES para encriptarla y enviarla a la base de datos
                    ObjDAORegistrarProfesional.Contraseña = ObjMetodosComunes.MetodoEncriptacionAES(ObjRegistroForm.txtUsuario.Text.Trim() + "ADNE2024");

                    //Obtenemos los datos del Profesional
                    ObjDAORegistrarProfesional.Dui = ObjRegistroForm.txtDui.Text;
                    ObjDAORegistrarProfesional.Nombres = ObjRegistroForm.txtNombre.Text.Trim();
                    ObjDAORegistrarProfesional.Apellidos = ObjRegistroForm.txtApellido.Text.Trim();
                    ObjDAORegistrarProfesional.Telefono = ObjRegistroForm.txtTelefono.Text;
                    ObjDAORegistrarProfesional.DesempenoId = int.Parse(ObjRegistroForm.cmbDesempeno.SelectedValue.ToString());

                    if (ObjRegistroForm.picProfesional.Image != Properties.Resources.ProfesionalPic)
                    {
                        string rutaImagen = ObjRegistroForm.ofdImagen.FileName;
                        string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string carpetaDestino = Path.Combine(escritorio, "Imagenes");

                        Directory.CreateDirectory(carpetaDestino);

                        string imagenDestino = Path.Combine(carpetaDestino, Guid.NewGuid().ToString() + Path.GetExtension(rutaImagen));
                        File.Copy(rutaImagen, imagenDestino);
                        try
                        {
                            ObjDAORegistrarProfesional.Imagen = imagenDestino;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        ObjDAORegistrarProfesional.Imagen = Properties.Resources.ProfesionalPic.ToString();
                    }

                    if (VerificarCorreoUsuario(ObjRegistroForm.txtCorreo.Text.Trim()) == true)
                    {
                        ObjDAORegistrarProfesional.Correo = ObjRegistroForm.txtCorreo.Text.Trim();
                        //Evaluamos si la inserción se hizo correctamente
                        if (ObjDAORegistrarProfesional.AgregarEmpleadoUsuario() == false)
                        {
                            MessageBox.Show("El Usuario no pudo ser registrado, verifique que los datos han sido ingresados correctamente", "Registrar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("El Profesional ha sido registrado exitosamente", "Registrar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RegistroEspecialidadesForm ObjAbrirRegistroEspecialidad = new RegistroEspecialidadesForm();
                            //Guardamos las variables de registro que se han hecho durante la inserción de la tabla profesional
                            ObjAbrirRegistroEspecialidad.txtDUIProfesional.Text = ObjRegistroForm.txtDui.Text.Trim();
                            ObjAbrirRegistroEspecialidad.picProfesional.Image = Image.FromFile(ObjDAORegistrarProfesional.Imagen);
                            ObjAbrirRegistroEspecialidad.lblNombreProfesional.Text = ObjDAORegistrarProfesional.Nombres + " " + ObjDAORegistrarProfesional.Apellidos;

                            ObjAbrirRegistroEspecialidad.ShowDialog();
                            //Ocultamos el formulario de Registro
                            ObjRegistroForm.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", "Registrar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Actualización al Formulario del Profesional (UPDATE)
        private void ActualizarRegistroProfesional(object sender, EventArgs e)
        {
            //Empezamos el bloque de código con un try catch, esto para verificar si hubo algún error, identificar la línea respectiva
            try
            {
                //Evaluamos si existen campos vacios dentro del formulario
                if (ObjRegistroForm.txtUsuario.Text.Length < 2 ||
                    ObjRegistroForm.txtNombre.Text.Length < 2 ||
                    ObjRegistroForm.txtCorreo.Text.Length < 10 ||
                    ObjRegistroForm.txtApellido.Text.Length < 2 ||
                    ObjRegistroForm.txtDui.Text.Length < 10 ||
                    ObjRegistroForm.txtTelefono.Text.Length < 9 ||
                    ObjRegistroForm.picProfesional.Image == Properties.Resources.ProfesionalPic)
                {
                    MessageBox.Show("Error al registrarse, verifique si todos los datos han sido ingresados correctamente o si los datos han sido rellenados con éxito", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Creamos las clases que usaremos para la actualización del PROFESIONAL y USUARIO
                    DAOAdministrador ObjDAOActualizarProfesional = new DAOAdministrador();
                    CommonMethods ObjMetodosComunes = new CommonMethods();

                    //Obtenemos datos del objeto ObjDAOActualizarProfesional
                    ObjDAOActualizarProfesional.UsuarioId = int.Parse(ObjRegistroForm.txtIDUsuario.Text.Trim());
                    ObjDAOActualizarProfesional.Usuario = ObjRegistroForm.txtUsuario.Text.Trim();
                    //Mandamos a llamar el método MetodoEncriptacionAES para encriptarla y enviarla a la base de datos
                    //De igual forma, al actualizar el Usuario del Profesional, se actualizará la contraseña del mismo
                    //De esta forma, el reseteo de contraseña vía administrador se hace presente
                    ObjDAOActualizarProfesional.Contraseña = ObjMetodosComunes.MetodoEncriptacionAES(ObjRegistroForm.txtUsuario.Text.Trim() + "ADNE2024");
                    ObjDAOActualizarProfesional.Dui = ObjRegistroForm.txtDui.Text;
                    ObjDAOActualizarProfesional.Nombres = ObjRegistroForm.txtNombre.Text.Trim();
                    ObjDAOActualizarProfesional.Apellidos = ObjRegistroForm.txtApellido.Text.Trim();
                    ObjDAOActualizarProfesional.Telefono = ObjRegistroForm.txtTelefono.Text;
                    ObjDAOActualizarProfesional.DesempenoId = int.Parse(ObjRegistroForm.cmbDesempeno.SelectedValue.ToString());

                    //Llamamos al método para registrar la imagen del Usuario
                    if (ObjRegistroForm.picProfesional.Image != Properties.Resources.ProfesionalPic)
                    {
                        string rutaImagen = ObjRegistroForm.ofdImagen.FileName;
                        string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string carpetaDestino = Path.Combine(escritorio, "Imagenes");

                        Directory.CreateDirectory(carpetaDestino);

                        string imagenDestino = Path.Combine(carpetaDestino, Guid.NewGuid().ToString() + Path.GetExtension(rutaImagen));
                        File.Copy(rutaImagen, imagenDestino);
                        try
                        {
                            ObjDAOActualizarProfesional.Imagen = imagenDestino;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    if (VerificarCorreoUsuario(ObjRegistroForm.txtCorreo.Text.Trim()) == true)
                    {
                        ObjDAOActualizarProfesional.Correo = ObjRegistroForm.txtCorreo.Text.Trim();
                        //Finalmente, evaluamos si la actualización se hizo correctamente
                        if (ObjDAOActualizarProfesional.ActualizarUsuarioEmpleado() == false)
                        {
                            MessageBox.Show("Error al actualizar el profesional, verifique si todos los datos han sido ingresados correctamente", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("El profesional ha sido actualizado correctamente", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Ocultamos el formulario de Registro                            
                            ObjRegistroForm.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El correo electrónico ingresado no posee una dirección de correo válida, verifique si contiene @ o dominio correcto", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Métodos para cargar, mostrar y eliminar la imagen en el PictureBox
        private void CargarImagenProfesional(object sender, EventArgs e)
        {
            ObjRegistroForm.ofdImagen.Filter = "Archivos De Imagen | *.jpg; *.png; *.jpeg;";

            try
            {
                if (ObjRegistroForm.ofdImagen.ShowDialog() == DialogResult.OK)
                {
                    string ruta = ObjRegistroForm.ofdImagen.FileName;
                    ObjRegistroForm.picProfesional.Image = Image.FromFile(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EliminarFotoProfesional(object sender, EventArgs e)
        {
            ObjRegistroForm.picProfesional.Image = null;
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