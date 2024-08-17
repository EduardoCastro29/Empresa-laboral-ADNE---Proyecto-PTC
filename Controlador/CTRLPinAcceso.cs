using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLPinAcceso
    {
        readonly PindeAccesoForm ObjPinAccesoForm;

        public CTRLPinAcceso(PindeAccesoForm Vista)
        {
            ObjPinAccesoForm = Vista;

            //Creación de nuevos eventos
            ObjPinAccesoForm.btnSiguiente.Click += new EventHandler(AbrirActualizarContrasena);
            ObjPinAccesoForm.btnAtras.Click += new EventHandler(VolverDireccionCorreo);
        }
        //Creación de eventos
        private void AbrirActualizarContrasena(object sender, EventArgs e)
        {            
            try
            {
                //Mandamos la variable estática GuardarCódigoRandom que posteriormente se insertará en el textbox
                if (string.IsNullOrWhiteSpace(ObjPinAccesoForm.txtIngresarPin.Text.Trim()) || DAODireccionGmail.GuardarCodigoRandom != ObjPinAccesoForm.txtIngresarPin.Text)
                {
                    MessageBox.Show("Por favor, ingrese un pin de acceso válido antes de seguir", "Pin de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ActualizarContraseñaForm ObjActualizarContrasena = new ActualizarContraseñaForm();
                    ObjPinAccesoForm.Hide();
                    ObjActualizarContrasena.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VolverDireccionCorreo(object sender, EventArgs e)
        {
            DirecciónGmailForm ObjVolverDireccionCorreo = new DirecciónGmailForm();
            ObjPinAccesoForm.Hide();
            ObjVolverDireccionCorreo.Show();
        }
    }
}