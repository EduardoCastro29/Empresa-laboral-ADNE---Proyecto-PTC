using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador.ControladorUserControlPaciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class InformaciónPersonalForm : Form
    {
        public InformaciónPersonalForm()
        {
            InitializeComponent();

            // Aca hacemos referencia al controlador de paciente de user control con los parametros de InformaciónPersonalForm vista
            CTRLPacienteUC ObjControladorInformacionPersonalUC = new CTRLPacienteUC(this);
            CTRLInformacionPersonal ObjControladorInformacionPersonal = new CTRLInformacionPersonal(this);
        }

        private void txtDui_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}
