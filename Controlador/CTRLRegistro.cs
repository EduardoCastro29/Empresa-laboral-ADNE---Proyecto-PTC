﻿using System;
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
            // Validaciones en los textbox 
            ObjRegistro.txtNombre.KeyPress += new KeyPressEventHandler(ValidarCampoLetra);
            ObjRegistro.txtApellido.KeyPress += new KeyPressEventHandler(ValidarCampoLetra);

            ObjRegistro.txtDui.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjRegistro.txtTelefono.KeyPress += new KeyPressEventHandler(ValidarCampoNumero);
            ObjRegistro.txtUsuario.KeyPress += new KeyPressEventHandler(ValidarCampoUsuario);
            ObjRegistro.txtCorreo.KeyPress += new KeyPressEventHandler(ValidarCampoCorreo);
        }
        #region Validaciones de Campos
        private void ValidarCampoCorreo(object sender, KeyPressEventArgs e )
        {
            // Permite caracteres de control como el retroceso(Backspace) 
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            // Se declara la variable ch de tipo char que se igualara = e.keyChar(Referencia al evento de ingreso de caracteres) 
            char ch = e.KeyChar;   

            // Solo estos caracteres permitira el text box
            if ((ch >= '0' && ch <= '9') ||
                 (ch >= 'A' && ch <= 'Z') ||
                (ch >= 'a' && ch <= 'z') ||
                 ch == '.' ||
                 ch == '@'||
                 ch == '_')
            {
                return;
            }
                // e.Handled en true, indicas que has manejado el evento y que el sistema no debe hacer nada más con él. 
                e.Handled = true;
        }
        private void ValidarCampoUsuario(object sender, KeyPressEventArgs e )
        {
            // Permite caracteres de control como el retroceso(Backspace) 
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            char ch = e.KeyChar;

            if ((ch >= '0' && ch <= '9') ||
                (ch >= 'A' && ch <= 'Z') ||
                (ch >= 'a' && ch <= 'z'))
            {
                return;
            }
            // e.Handled en true, indicas que has manejado el evento y que el sistema no debe hacer nada más con él. 
            e.Handled = true;

        }
        private void ValidarCampoLetra(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar El evento que detecta el ingreso de cualquier caracter.
            // Permite caracteres de control como el retroceso(Backspace) 
            if (char.IsControl(e.KeyChar))
            {
                return  ;
            }

            // Permitir letras (incluyendo letras acentuadas) y espacios
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
            {
                return;
            }
                // e.Handled en true, indicas que has manejado el evento y que el sistema no debe hacer nada más con él. 
                 e.Handled = true;
        }
        private void ValidarCampoNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit (e.KeyChar))
            {
                return;
            }


            e.Handled = true;

        }
        #endregion
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
        private void AccederLoginPrimerUso(object sender, EventArgs e)
        {
            try
            {
                //Dado el objeto del DAORegistro, evaluamos si los datos fueron ingresados correctamente dados sus métodos
                if (string.IsNullOrWhiteSpace(ObjRegistro.txtUsuario.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistro.txtNombre.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistro.txtContrasena.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistro.txtCorreo.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistro.txtApellido.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistro.txtDui.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(ObjRegistro.txtTelefono.Text.Trim()) ||
                    ObjRegistro.picProfesional.Image == null)
                {
                    //Si los datos no fueron ingresados correctamente, mostramos un mensaje de error
                    MessageBox.Show("Error al registrarse, verifique si todos los datos han sido ingresados correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    //Mandamos a llamar al método pinAcceso para que nos genere un ping aleatorio
                    //Que posteriormente nos servirá para la recuperación de contraseña
                    ObjDAORegistro.Correo = ObjRegistro.txtCorreo.Text.Trim();

                    //Obtenemos los datos del Profesional
                    ObjDAORegistro.Dui = ObjRegistro.txtDui.Text;
                    ObjDAORegistro.Nombres = ObjRegistro.txtNombre.Text.Trim();
                    ObjDAORegistro.Apellidos = ObjRegistro.txtApellido.Text.Trim();
                    ObjDAORegistro.Telefono = ObjRegistro.txtTelefono.Text;
                    ObjDAORegistro.DesempenoId = 1;
                    //ObjDAORegistro.Especialidad = int.Parse(ObjRegistro.cmbEspecialidad1.SelectedValue.ToString());
                    //ObjDAORegistro.EspecialidadAlt = int.Parse(ObjRegistro.cmbEspecialidad2.SelectedValue.ToString());

                    //Guardar imagen
                    if (ObjRegistro.picProfesional.Image != null)
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
                        ObjDAORegistro.Imagen = ""; //Terminamos de guardar imagen
                    }

                    //Llamamos a los métodos para verificar si la inserción se hizo correctamente 
                    if (ObjDAORegistro.RegistroInsertarUsuarioProfesional() == false)
                    {
                        MessageBox.Show("Oops!, Algo salió mal, verifique si todas las credenciales han sido ingresadas correctamente", "Primer Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Excelente", "Primer Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RegistroEspecialidadesForm ObjAbrirRegistroEspecialidad = new RegistroEspecialidadesForm();
                        ObjRegistro.Hide();

                        //Guardamos las variables de registro que se han hecho durante la inserción de la tabla profesional
                        ObjAbrirRegistroEspecialidad.txtDUIProfesional.Text = ObjRegistro.txtDui.Text;
                        ObjAbrirRegistroEspecialidad.picProfesional.Image = Image.FromFile(ObjDAORegistro.Imagen);
                        ObjAbrirRegistroEspecialidad.lblNombreProfesional.Text = ObjDAORegistro.Nombres + " " + ObjDAORegistro.Apellidos;

                        ObjAbrirRegistroEspecialidad.ShowDialog();

                        //Ocultamos el formulario de registro y le daremos la bienvenida al Login
                        LoginForm ObjMostrarLogin = new LoginForm();
                        ObjMostrarLogin.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarImagen(object sender, EventArgs e)
        {
            ObjRegistro.ofdImagen.Filter = "Archivos De Imagen | *.jpg; *.png; *.jpeg;";

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
    }
}