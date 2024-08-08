using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLPacientes
    {
        readonly PacientesForm ObjPacientesForm;
        NuevoPacienteForm ObjNuevoPacienteForm = null;
        VerPacientesForm ObjVerPacientesForm = null;

        public CTRLPacientes(PacientesForm Vista)
        {
            ObjPacientesForm = Vista;

            ObjPacientesForm.btnNuevoPaciente.Click += new EventHandler(AbrirFormularioNuevoPaciente);
            ObjPacientesForm.btnVerPaciente.Click += new EventHandler(AbrirFormularioVerPaciente);
        }
        //Aca su crudo



        private void AbrirFormularioNuevoPaciente(object sender, EventArgs e)
        {
            if (ObjNuevoPacienteForm == null || ObjNuevoPacienteForm.IsDisposed)
            {
                ObjNuevoPacienteForm = new NuevoPacienteForm();
                ObjNuevoPacienteForm.Show();
            }
            else
            {
                ObjNuevoPacienteForm.BringToFront();
            }
        }
        private void AbrirFormularioVerPaciente(object sender, EventArgs e)
        {
            if (ObjVerPacientesForm == null || ObjVerPacientesForm.IsDisposed)
            {
                ObjVerPacientesForm = new VerPacientesForm();
                ObjVerPacientesForm.Show();
            }
            else
            {
                ObjVerPacientesForm.BringToFront();
            }
        }
    }
}