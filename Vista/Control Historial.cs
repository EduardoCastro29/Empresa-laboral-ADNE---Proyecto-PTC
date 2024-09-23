using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
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
    public partial class ControlHistorialUC : UserControl
    {
        internal ControlHistorialUC(DAOActividades DAOVerHistorial)
        {
            InitializeComponent();
            leerIni();
            try
            {
                lblNombrePaciente.Text = DAOVerHistorial.Nombre2;
                lblHoraInicio.Text = DAOVerHistorial.HoraInicio2.ToString();
                lblHoraFinal.Text = DAOVerHistorial.HoraFin.ToString();
                lblDui.Text = DAOVerHistorial.DocumentoPresentado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(38, 102, 119);

                this.lblNombrePaciente.ForeColor = Color.White;
                this.lblPaciente.ForeColor = Color.White;
                this.lblHoraInicio.ForeColor = Color.White;
                this.lblHoraFinal.ForeColor = Color.White;
                this.lblFinal.ForeColor = Color.White;
                this.lblDui.ForeColor = Color.White;
                this.bunifuLabel1.ForeColor = Color.White;

                this.btnExpediente.IdleFillColor = Color.DarkCyan;
            }
        }
    }
}