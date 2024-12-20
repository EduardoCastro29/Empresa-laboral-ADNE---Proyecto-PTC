﻿using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
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
    public partial class VerCitasForm : Form
    {
        public VerCitasForm()
        {
            InitializeComponent();
            leerIni();
            CTRLVerCitas ObjControladorVerCitas = new CTRLVerCitas(this);
        }
        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.BackColor = Color.FromArgb(28, 104, 108);

                //this.pnlForms.GradientTopLeft = Color.FromArgb(34, 120, 128);

                this.txtBuscar.FillColor = Color.FromArgb(220, 236, 242);

            }
        }
    }
}
