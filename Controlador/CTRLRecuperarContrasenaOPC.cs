using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLRecuperarContrasenaOPC
    {
        readonly RecuperarContraseñaOPCForm ObjRecuperarContrasenaForm;

        public CTRLRecuperarContrasenaOPC(RecuperarContraseñaOPCForm Vista)
        {
            ObjRecuperarContrasenaForm = Vista;

            ObjRecuperarContrasenaForm.btnCorreoElectronico.Click += new EventHandler(MetodoCorreo);
            ObjRecuperarContrasenaForm.btnPreguntasAutenticacion.Click += new EventHandler(MetodoPreguntasAutenticacion);
        }
        private void MetodoCorreo(object sender, EventArgs e)
        {
            DirecciónGmailForm ObjDireccionMetodo = new DirecciónGmailForm();
            ObjRecuperarContrasenaForm.Hide();
            ObjDireccionMetodo.Show();
        }
        private void MetodoPreguntasAutenticacion(object sender, EventArgs e)
        {
            PreguntasdeSeguridadForm ObjPreguntasSMetodo = new PreguntasdeSeguridadForm();
            ObjRecuperarContrasenaForm.Hide();
            ObjPreguntasSMetodo.Show();
        }
    }
}