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
    public partial class PacientesForm : Form
    {
        public PacientesForm()
        {
            InitializeComponent();
            CTRLPacientes ObjPacientesControlador = new CTRLPacientes(this);
        }
    }
}
