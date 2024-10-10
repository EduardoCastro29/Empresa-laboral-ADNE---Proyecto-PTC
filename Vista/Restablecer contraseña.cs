using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class Actualizar_contraseña : Form
    {
        public Actualizar_contraseña()
        {
            InitializeComponent();
            CTRLCambiarContraseña Controller = new CTRLCambiarContraseña(this);
        }
    }
}
