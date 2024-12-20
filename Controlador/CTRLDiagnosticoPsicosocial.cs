﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using System.Runtime.Remoting;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLDiagnosticoPsicosocial
    {
        NuevoPacienteForm objNuevoPaciente = new NuevoPacienteForm();
        readonly ExpedienteMédicoForm ObjExpediente;
        //Empezamos la encapsulación de la clase Controlador Expediente
        //Esta tendrá como parámetros el formulario Expediente Médico haciendo referencia a la carpeta Vista

        //Primer controlador de la Vista de ExpedienteMedicoForms
        public CTRLDiagnosticoPsicosocial(ExpedienteMédicoForm Vista)
        {
            //Enlazando el objeto con la Vista dentro del constructor
            ObjExpediente = Vista;

            //Creando el evento EventHandler con el botón Guardar con parametros AccederLogin, que posteriormente ejecutará un método
            ObjExpediente.btnGuardar.Click += new EventHandler(ExpedienteDataInsert);
            ObjExpediente.btnModificar.Click += new EventHandler(ExpedienteDataUpdate);
            ObjExpediente.Load += new EventHandler(CargarExpediente);

            //Validaciones de Campos
            ObjExpediente.txtAproximacionDiag.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtAtencionBrindada.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtCognicion.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtEstadoAnimo.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtEstadoConductual.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtObservacion.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtPauta.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtRedSocial.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtRiesgoValorado.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtSomatizacion.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtVidaInterpersonal.KeyPress += new KeyPressEventHandler(ValidarCampoTextBox);
            ObjExpediente.txtDocumentoPaciente.KeyPress += new KeyPressEventHandler(ValidarCampoDocumento);
            //ObjExpediente.txtDocumentoPaciente.KeyPress += new KeyPressEventHandler(EnmascararCampoDocumento);
        }
        #region Validaciones de Campos
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

            //Declaramos lo valores que únicamente permitirá el textbox
            if ((ch >= '0' && ch <= '9') ||
                (ch >= 'A' && ch <= 'Z') ||
                (ch == '-'))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        //private void EnmascararCampoDocumento(object sender, EventArgs e)
        //{
        //    //Obtenemos la longitud actual del textbox para evaluar si es necesario el remplazo por guión (en este caso el DUI) o número
        //    string EnmascararDUI = ObjExpediente.txtDocumentoPaciente.Text.Replace("-", "");

        //    //Limitamos el textbox para que solo obtenga 9 caracteres
        //    if (EnmascararDUI.Length > 9)
        //    {
        //        EnmascararDUI = EnmascararDUI.Substring(0, 9);
        //    }

        //    //Una vez llegada a la longitud deseada, en este caso 8 pone un guión automáticamente para enmascarar el DUI
        //    if (EnmascararDUI.Length > 8)
        //    {
        //        //Indicamos en qué posición se pondrá el guión y que símbolo tomará
        //        ObjExpediente.txtDocumentoPaciente.Text = EnmascararDUI.Insert(8, "-");
        //    }
        //    else
        //    {
        //        //Caso contrario, no realizamos ningun cambio (no se inserta el guión)
        //        ObjExpediente.txtDocumentoPaciente.Text = EnmascararDUI;
        //    }

        //    //Indicamos que la posición inicial del cursor, será al inicio del textbox
        //    ObjExpediente.txtDocumentoPaciente.SelectionStart = ObjExpediente.txtDocumentoPaciente.Text.Length;
        //}
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
                e.KeyChar == '.' ||
                e.KeyChar == '"' ||
                (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                //Retornamos los valores e.KeyChar
                return;
            }
            //Indicamos que se creará el evento e.Char con todos los valores antes proporcionados, como un EventHandler
            e.Handled = true;
        }
        #endregion
        #region Eventos Iniciales al cargar el Formulario
        //ABRIR EXPEDIENTE
        private void CargarExpediente(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ObjExpediente.txtObservacion.Text))
            {
                ObjExpediente.btnModificar.Enabled = false;
            }
        }
        #endregion
        #region Inserción en el Formulario de Expediente (INSERT)
        //INSERT
        private void ExpedienteDataInsert(object sender, EventArgs e)
        {
            try
            {
                //Dado el objeto del DAOExpedienteMédico, evaluamos si los datos fueron ingresados correctamente dados sus métodos
                if (ObjExpediente.txtDocumentoPaciente.Text.Length < 8 ||
                    ObjExpediente.txtEstadoAnimo.Text.Length < 5 ||
                    ObjExpediente.txtEstadoConductual.Text.Length < 5 ||
                    ObjExpediente.txtSomatizacion.Text.Length < 5 ||
                    ObjExpediente.txtVidaInterpersonal.Text.Length < 5 ||
                    ObjExpediente.txtCognicion.Text.Length < 5 ||
                    ObjExpediente.txtRedSocial.Text.Length < 5 ||
                    ObjExpediente.txtPauta.Text.Length < 5 ||
                    ObjExpediente.txtRiesgoValorado.Text.Length < 5 ||
                    ObjExpediente.txtObservacion.Text.Length < 5 ||
                    ObjExpediente.txtAproximacionDiag.Text.Length < 5 ||
                    ObjExpediente.txtAtencionBrindada.Text.Length < 5)
                {
                    //Si los datos no fueron ingresados correctamente, mostramos un mensaje de error
                    objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Error al guardar, verifique si todos los datos han sido ingresados correctamente o cumple con la cantidad mínima de caracteres", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    //MessageBox.Show("Error al guardar, verifique si todos los datos han sido ingresados correctamente o cumple con la cantidad mínima de caracteres", "Expediente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //En caso contrario, realizamos el proceso de inserción de los datos a la DB
                    //Realizamos el proceso para capturar los datos ingresados por el usuario dado el DAORegistro
                    DAODiagnosticoPsicosocial ObjDAOExpediente = new DAODiagnosticoPsicosocial();

                    //Obtenemos datos del objeto ObjDAOExpediente
                    ObjDAOExpediente.DocumentoPresentado = ObjExpediente.txtDocumentoPaciente.Text.Trim();
                    ObjDAOExpediente.EstadoAnimo = ObjExpediente.txtEstadoAnimo.Text.Trim();
                    ObjDAOExpediente.EstadoConductual = ObjExpediente.txtEstadoConductual.Text.Trim();
                    ObjDAOExpediente.Somatizacion = ObjExpediente.txtSomatizacion.Text.Trim();
                    ObjDAOExpediente.VidaInterpersonal = ObjExpediente.txtVidaInterpersonal.Text.Trim();
                    ObjDAOExpediente.Cognicion = ObjExpediente.txtCognicion.Text.Trim();
                    ObjDAOExpediente.RedSocial = ObjExpediente.txtRedSocial.Text.Trim();
                    ObjDAOExpediente.Pauta = ObjExpediente.txtPauta.Text.Trim();
                    ObjDAOExpediente.RiesgoValorado = ObjExpediente.txtRiesgoValorado.Text.Trim();
                    ObjDAOExpediente.Observacion = ObjExpediente.txtObservacion.Text.Trim();
                    ObjDAOExpediente.AproximacionDiag = ObjExpediente.txtAproximacionDiag.Text.Trim();
                    ObjDAOExpediente.AtencionBrindada = ObjExpediente.txtAtencionBrindada.Text.Trim();

                    //Se ejecuta el proceso para insertar datos mediante la invocación del método del DAOExpediente
                    bool comprobar = ObjDAOExpediente.ExpedienteInsertarDatos();

                    if (comprobar == true)
                    {
                        //MessageBox.Show("Los datos han sido insertado exitosamente",
                        //           "Proceso completado",
                        //           MessageBoxButtons.OK,
                        //           MessageBoxIcon.Information);
                        objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Los datos han sido insertado exitosamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        LimpiarCampos();
                    }
                    else
                    {
                        //MessageBox.Show("Los datos no pudieron ser insertados",
                        //            "Proceso interrumpido",
                        //            MessageBoxButtons.OK,
                        //            MessageBoxIcon.Error);
                        objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Los datos no pudieron ser insertados. El proceso ha sido interrumpido", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Actualización en el Formulario de Expediente (UPDATE)
        //UPDATE
        private void ExpedienteDataUpdate(object sender, EventArgs e)
        {
            try
            {
                //Dado el objeto del DAOExpedienteMédico, evaluamos si los datos fueron ingresados correctamente dados sus métodos
                if (ObjExpediente.txtDocumentoPaciente.Text.Length < 8 ||
                    ObjExpediente.txtEstadoAnimo.Text.Length < 5 ||
                    ObjExpediente.txtEstadoConductual.Text.Length < 5 ||
                    ObjExpediente.txtSomatizacion.Text.Length < 5 ||
                    ObjExpediente.txtVidaInterpersonal.Text.Length < 5 ||
                    ObjExpediente.txtCognicion.Text.Length < 5 ||
                    ObjExpediente.txtRedSocial.Text.Length < 5 ||
                    ObjExpediente.txtPauta.Text.Length < 5 ||
                    ObjExpediente.txtRiesgoValorado.Text.Length < 5 ||
                    ObjExpediente.txtObservacion.Text.Length < 5 ||
                    ObjExpediente.txtAproximacionDiag.Text.Length < 5 ||
                    ObjExpediente.txtAtencionBrindada.Text.Length < 5)
                {
                    //Si los datos no fueron ingresados correctamente, mostramos un mensaje de error
                    //MessageBox.Show("Error al guardar, verifique si todos los datos han sido ingresados correctamente o cumple con la cantidad mínima de caracteres", "Expediente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Error al guardar, verifique si todos los datos han sido ingresados correctamente o cumple con la cantidad mínima de caracteres", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                }
                else
                {
                    //En caso contrario, realizamos el proceso de inserción de los datos a la DB
                    //Realizamos el proceso para capturar los datos ingresados por el usuario dado el DAORegistro
                    DAODiagnosticoPsicosocial ObjDAOExpediente = new DAODiagnosticoPsicosocial();

                    //Obtenemos datos del objeto ObjDAOExpediente
                    ObjDAOExpediente.DocumentoPresentado = ObjExpediente.txtDocumentoPaciente.Text.Trim();
                    ObjDAOExpediente.EstadoAnimo = ObjExpediente.txtEstadoAnimo.Text.Trim();
                    ObjDAOExpediente.EstadoConductual = ObjExpediente.txtEstadoConductual.Text.Trim();
                    ObjDAOExpediente.Somatizacion = ObjExpediente.txtSomatizacion.Text.Trim();
                    ObjDAOExpediente.VidaInterpersonal = ObjExpediente.txtVidaInterpersonal.Text.Trim();
                    ObjDAOExpediente.Cognicion = ObjExpediente.txtCognicion.Text.Trim();
                    ObjDAOExpediente.RedSocial = ObjExpediente.txtRedSocial.Text.Trim();
                    ObjDAOExpediente.Pauta = ObjExpediente.txtPauta.Text.Trim();
                    ObjDAOExpediente.RiesgoValorado = ObjExpediente.txtRiesgoValorado.Text.Trim();
                    ObjDAOExpediente.Observacion = ObjExpediente.txtObservacion.Text.Trim();
                    ObjDAOExpediente.AproximacionDiag = ObjExpediente.txtAproximacionDiag.Text.Trim();
                    ObjDAOExpediente.AtencionBrindada = ObjExpediente.txtAtencionBrindada.Text.Trim();

                    //Se ejecuta el proceso para actualizar datos mediante la invocación del método del DAOExpediente
                    bool comprobar = ObjDAOExpediente.ExpedienteActualizarDatos();
                    if (comprobar == true)
                    {
                        //MessageBox.Show("Los datos han sido actualizados exitosamente",
                        //           "Proceso completado",
                        //           MessageBoxButtons.OK,
                        //           MessageBoxIcon.Information);
                        objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Los datos han sido actualizados exitosamente", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        LimpiarCampos();
                    }
                    else
                    {
                        //MessageBox.Show("Los datos no pudieron ser actualizados",
                        //           "Proceso interrumpido",
                        //           MessageBoxButtons.OK,
                        //           MessageBoxIcon.Error);
                        objNuevoPaciente.NotificacionNuevoPaciente.Show(objNuevoPaciente, "Los datos no pudieron ser actualizados", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Limpiar Campos (después de cada acción)
        private void LimpiarCampos()
        {
            ObjExpediente.txtEstadoAnimo.Clear();
            ObjExpediente.txtEstadoConductual.Clear();
            ObjExpediente.txtSomatizacion.Clear();
            ObjExpediente.txtVidaInterpersonal.Clear();
            ObjExpediente.txtCognicion.Clear();
            ObjExpediente.txtRedSocial.Clear();
            ObjExpediente.txtPauta.Clear();
            ObjExpediente.txtRiesgoValorado.Clear();
            ObjExpediente.txtObservacion.Clear();
            ObjExpediente.txtAproximacionDiag.Clear();
            ObjExpediente.txtAtencionBrindada.Clear();

            ObjExpediente.txtDocumentoPaciente.Clear();
        }
        #endregion
    }
}