using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
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
    public partial class ExpedienteMédicoForm : Form
    {
        public ExpedienteMédicoForm()
        {
            InitializeComponent();
            leerIni();
            CTRLDiagnosticoPsicosocial ObjControladorExpediente = new CTRLDiagnosticoPsicosocial(this);
        }

        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(30, 92, 98);
                this.lblAfectividad.ForeColor = Color.White;
                this.lblAfectividad2.ForeColor = Color.White;
                this.lblDUI.ForeColor = Color.White;
                this.lblEstado.ForeColor = Color.White;
                this.lblSomatizacion.ForeColor = Color.White;
                this.lblSomatizacion2.ForeColor = Color.White;
                this.lblInterpersonal.ForeColor = Color.White;
                this.lblInterpersonal2.ForeColor = Color.White;
                this.lblCognicion.ForeColor = Color.White;
                this.lblCognicion2.ForeColor = Color.White;
                this.lblRedes.ForeColor = Color.White;
                this.lblPautas.ForeColor = Color.White;
                this.lblValoracion.ForeColor = Color.White;
                this.lblObservacion.ForeColor = Color.White;
                this.lblAprox.ForeColor = Color.White;
                this.lblAtencion.ForeColor = Color.White;

                this.txtDocumentoPaciente.FillColor = Color.FromArgb(19, 63, 76);
                this.txtDocumentoPaciente.ForeColor = Color.White;

                this.txtEstadoAnimo.FillColor = Color.FromArgb(19, 63, 76);
                this.txtEstadoAnimo.ForeColor = Color.White;

                this.txtEstadoConductual.FillColor = Color.FromArgb(19, 63, 76);
                this.txtEstadoConductual.ForeColor = Color.White;

                this.txtSomatizacion.FillColor = Color.FromArgb(19, 63, 76);
                this.txtSomatizacion.ForeColor = Color.White;

                this.txtVidaInterpersonal.FillColor = Color.FromArgb(19, 63, 76);
                this.txtVidaInterpersonal.ForeColor = Color.White;

                this.txtCognicion.FillColor = Color.FromArgb(19, 63, 76);
                this.txtCognicion.ForeColor = Color.White;

                this.txtRedSocial.FillColor = Color.FromArgb(19, 63, 76);
                this.txtRedSocial.ForeColor = Color.White;

                this.txtPauta.FillColor = Color.FromArgb(19, 63, 76);
                this.txtPauta.ForeColor = Color.White;

                this.txtRiesgoValorado.FillColor = Color.FromArgb(19, 63, 76);
                this.txtRiesgoValorado.ForeColor = Color.White;

                this.txtObservacion.FillColor = Color.FromArgb(19, 63, 76);
                this.txtObservacion.ForeColor = Color.White;

                this.txtAproximacionDiag.FillColor = Color.FromArgb(19, 63, 76);
                this.txtAproximacionDiag.ForeColor = Color.White;

                this.txtAtencionBrindada.FillColor = Color.FromArgb(19, 63, 76);
                this.txtAtencionBrindada.ForeColor = Color.White;


            }
        }
    }
}
