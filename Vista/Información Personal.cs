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
        readonly ConfiguraciónForm objConfigForm = new ConfiguraciónForm();
        public InformaciónPersonalForm()
        {
            InitializeComponent();
            leerIni();

            // Aca hacemos referencia al controlador de paciente de user control con los parametros de InformaciónPersonalForm vista
            if (string.IsNullOrWhiteSpace(CTRLPacienteUC.VerificarTextBox))
            {
                CTRLInformacionPersonal ObjControladorInformacionPersonal = new CTRLInformacionPersonal(this);
            }
            else
            {
                CTRLPacienteUC ObjControladorInformacionPersonalUC = new CTRLPacienteUC(this);
            }
        }

        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                // Modo oscuro (Labels)
                objConfigForm.switchModo.Checked = true;
                this.BackColor = Color.FromArgb(30, 92, 98);
                this.lblNombres.ForeColor = Color.White;
                this.lblApellidos.ForeColor = Color.White;
                this.lblNacionalidad.ForeColor = Color.White;
                this.lblDocumento.ForeColor = Color.White;
                this.lblGenero.ForeColor = Color.White;
                this.lblProfesion.ForeColor = Color.White;
                this.lblTelefono.ForeColor = Color.White;
                this.lblCorreo.ForeColor = Color.White;
                this.lblNacimiento.ForeColor = Color.White;
                this.lblEdad.ForeColor = Color.White;
                this.lblDomicilio.ForeColor = Color.White;
                this.lblComposicion.ForeColor = Color.White;
                this.lblMotivo.ForeColor = Color.White;
                this.lblAntecedentes.ForeColor = Color.White;
                this.lblDescripcion.ForeColor = Color.White;
                this.lblAspectos.ForeColor = Color.White;

                // Modo oscuro (cmbBox)
                this.cmbGeneroId.BackgroundColor = Color.FromArgb(42, 86, 100);
                this.cmbGeneroId.ForeColor = Color.White;

                // Modo oscuro (DatePicker)
                this.dtFechaNacimiento.BackColor = Color.FromArgb(42, 86, 100);
                this.dtFechaNacimiento.ForeColor = Color.White;

                // Modo oscuro (txtBox)
                this.txtNombrePaciente.FillColor = Color.FromArgb(19, 63, 76);
                this.txtNombrePaciente.ForeColor = Color.White;
                this.txtApellidoPaciente.FillColor = Color.FromArgb(19, 63, 76);
                this.txtApellidoPaciente.ForeColor = Color.White;
                this.txtNacionalidad.FillColor = Color.FromArgb(19, 63, 76);
                this.txtNacionalidad.ForeColor = Color.White;
                this.txtDocumentoPresentado.FillColor = Color.FromArgb(19, 63, 76);
                this.txtDocumentoPresentado.ForeColor = Color.White;
                this.txtProfesion.FillColor = Color.FromArgb(19, 63, 76);
                this.txtProfesion.ForeColor = Color.White;
                this.txtTelefono1.FillColor = Color.FromArgb(19, 63, 76);
                this.txtTelefono1.ForeColor = Color.White;
                this.txtCorreoElectronico.FillColor = Color.FromArgb(19, 63, 76);
                this.txtCorreoElectronico.ForeColor = Color.White;
                this.txtEdad.FillColor = Color.FromArgb(19, 63, 76);
                this.txtEdad.ForeColor = Color.White;
                this.txtEdad.PlaceholderForeColor = Color.White;
                this.txtEdad.OnDisabledState.FillColor = Color.FromArgb(19, 63, 76);
                this.txtEdad.OnDisabledState.ForeColor = Color.White;
                this.txtDomicilio.FillColor = Color.FromArgb(19, 63, 76);
                this.txtDomicilio.ForeColor = Color.White;
                this.txtComposicionFamiliar.FillColor = Color.FromArgb(19, 63, 76);
                this.txtComposicionFamiliar.ForeColor = Color.White;
                this.txtMotivoIntervencion.FillColor = Color.FromArgb(19, 63, 76);
                this.txtMotivoIntervencion.ForeColor = Color.White;
                this.txtAntecedentes.FillColor = Color.FromArgb(19, 63, 76);
                this.txtAntecedentes.ForeColor = Color.White;
                this.txtDescripcion.FillColor = Color.FromArgb(19, 63, 76);
                this.txtDescripcion.ForeColor = Color.White;
                this.txtAspectosPreocupantes.FillColor = Color.FromArgb(19, 63, 76);
                this.txtAspectosPreocupantes.ForeColor = Color.White;
            }
        }
    }
}
