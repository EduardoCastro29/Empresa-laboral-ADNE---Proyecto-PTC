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

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLAdministrador
    {
        //El formulario Registro pooserá 2 constructores
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
        }
        #region Llenado de DataGridView (Empleados)
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
        private void AbrirAgregarProfesional(object sender, EventArgs e)
        {
            //Procedemos a abrir el formulario de agregar nuevo profesional
            RegistroForm ObjAgregarRegistroProfesional = new RegistroForm();
            ObjAgregarRegistroProfesional.ShowDialog();

            //Refrescamos el DataGridView cuando el formulario se cierre por completo
            RecargarDGVEmpleados();
        }
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
            string Especialidad = ObjAdministradorForm.dgvAdministrarProfesional[9, PosicionFila].Value.ToString();
            string EspecialidadAlt = ObjAdministradorForm.dgvAdministrarProfesional[10, PosicionFila].Value.ToString();

            //Ahora, procedemos a usar la instancia antes establecida para mostrar los valores de las filas encontradas            
            ObjActualizarProfesional.txtIDUsuario.Text = IDUsuario.ToString();
            ObjActualizarProfesional.txtDui.Text = DUIProfesional;
            ObjActualizarProfesional.txtTelefono.Text = TelefonoProfesional;
            ObjActualizarProfesional.txtNombre.Text = NombreProfesional;
            ObjActualizarProfesional.txtApellido.Text = ApellidosProfesional;
            ObjActualizarProfesional.txtCorreo.Text = CorreoProfesional;
            ObjActualizarProfesional.picProfesional.Image = Image.FromFile(ImagenProfesional);
            ObjActualizarProfesional.cmbDesempeno.SelectedValue = DesempenoProfesional;
            ObjActualizarProfesional.txtUsuario.Text = NombreUsuario;
            ObjActualizarProfesional.cmbEspecialidad1.SelectedValue = Especialidad;
            ObjActualizarProfesional.cmbEspecialidad2.SelectedValue = EspecialidadAlt;

            //Especificamos qué apartados no deben de mostrarse a la hora del Update
            ObjActualizarProfesional.btnRegistrar.Visible = false;
            ObjActualizarProfesional.bpRegistrar.Visible = false;
            //Mostramos el Formulario
            ObjActualizarProfesional.ShowDialog();

            //Refrescamos el DataGridView cuando el formulario se cierre por completo
            RecargarDGVEmpleados();
        }
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

                    ObjDAOEliminarUsuario.UsuarioId = int.Parse(ObjAdministradorForm.dgvAdministrarProfesional[1, PosicionFila].Value.ToString());

                    if (ObjDAOEliminarUsuario.EliminarUsuarioEmpleado() == true)
                    {
                        MessageBox.Show("El Profesional se ha eliminado correctamente", "Eliminar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
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

            //Combobox Especialidad 
            ObjRegistroForm.cmbEspecialidad1.DataSource = ObjDAOCargarCMB.AgregarCMBEspecialidad();
            ObjRegistroForm.cmbEspecialidad1.ValueMember = "especialidadId";
            ObjRegistroForm.cmbEspecialidad1.DisplayMember = "nombreEspecialidad";

            //Combobox Especialidad Alternativa 
            ObjRegistroForm.cmbEspecialidad2.DataSource = ObjDAOCargarCMB.AgregarCMBEspecialidadAlt();
            ObjRegistroForm.cmbEspecialidad2.ValueMember = "especialidadAltId";
            ObjRegistroForm.cmbEspecialidad2.DisplayMember = "nombreEspecialidadAlt";
        }
        private void GuardarRegistroProfesional(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ObjRegistroForm.txtUsuario.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtNombre.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtCorreo.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtApellido.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtDui.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtTelefono.Text.Trim()) ||
                    ObjRegistroForm.picProfesional.Image == null)
                {
                    MessageBox.Show("Error al registrarse, verifique si todos los datos han sido ingresados correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    //Mandamos a llamar al método pinAcceso para que nos genere un ping aleatorio
                    //Que posteriormente nos servirá para la recuperación de contraseña
                    ObjDAORegistrarProfesional.Correo = ObjRegistroForm.txtCorreo.Text.Trim();

                    //Obtenemos los datos del Profesional
                    ObjDAORegistrarProfesional.Dui = ObjRegistroForm.txtDui.Text;
                    ObjDAORegistrarProfesional.Nombres = ObjRegistroForm.txtNombre.Text.Trim();
                    ObjDAORegistrarProfesional.Apellidos = ObjRegistroForm.txtApellido.Text.Trim();
                    ObjDAORegistrarProfesional.Telefono = ObjRegistroForm.txtTelefono.Text;
                    ObjDAORegistrarProfesional.DesempenoId = int.Parse(ObjRegistroForm.cmbDesempeno.SelectedValue.ToString());
                    ObjDAORegistrarProfesional.Especialidad = int.Parse(ObjRegistroForm.cmbEspecialidad1.SelectedValue.ToString());
                    ObjDAORegistrarProfesional.EspecialidadAlt = int.Parse(ObjRegistroForm.cmbEspecialidad2.SelectedValue.ToString());

                    if (ObjRegistroForm.picProfesional.Image != null)
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
                        ObjDAORegistrarProfesional.Imagen = "";
                    }

                    //Evaluamos si la inserción se hizo correctamente
                    if (ObjDAORegistrarProfesional.AgregarEmpleadoUsuario() == false)
                    {
                        MessageBox.Show("El Usuario no pudo ser registrado, verifique que los datos han sido ingresados correctamente", "Registrar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Ocultamos el formulario de Registro
                        ObjRegistroForm.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ActualizarRegistroProfesional(object sender, EventArgs e)
        {
            //Empezamos el bloque de código con un try catch, esto para verificar si hubo algún error, identificar la línea respectiva
            try
            {
                //Evaluamos si existen campos vacios dentro del formulario
                if (string.IsNullOrWhiteSpace(ObjRegistroForm.txtUsuario.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtNombre.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtCorreo.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtApellido.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtDui.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistroForm.txtTelefono.Text.Trim()) ||
                    ObjRegistroForm.picProfesional.Image == null)
                {
                    MessageBox.Show("Error al registrarse, verifique si todos los datos han sido ingresados correctamente", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    ObjDAOActualizarProfesional.Correo = ObjRegistroForm.txtCorreo.Text.Trim();
                    ObjDAOActualizarProfesional.Dui = ObjRegistroForm.txtDui.Text;
                    ObjDAOActualizarProfesional.Nombres = ObjRegistroForm.txtNombre.Text.Trim();
                    ObjDAOActualizarProfesional.Apellidos = ObjRegistroForm.txtApellido.Text.Trim();
                    ObjDAOActualizarProfesional.Telefono = ObjRegistroForm.txtTelefono.Text;
                    ObjDAOActualizarProfesional.DesempenoId = int.Parse(ObjRegistroForm.cmbDesempeno.SelectedValue.ToString());
                    ObjDAOActualizarProfesional.Especialidad = int.Parse(ObjRegistroForm.cmbEspecialidad1.SelectedValue.ToString());
                    ObjDAOActualizarProfesional.EspecialidadAlt = int.Parse(ObjRegistroForm.cmbEspecialidad2.SelectedValue.ToString());

                    //Llamamos al método para registrar la imagen del Usuario
                    if (ObjRegistroForm.picProfesional.Image != null)
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
                    else
                    {
                        ObjDAOActualizarProfesional.Imagen = "";
                    }

                    //Finalmente, evaluamos si la actualización se hizo correctamente
                    if (ObjDAOActualizarProfesional.ActualizarUsuarioEmpleado() == false)
                    {
                        MessageBox.Show("Error al actualizar el profesional, verifique si todos los datos han sido ingresados correctamente", "Actualizar Profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Ocultamos el formulario de Registro
                        ObjRegistroForm.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
    }
}