using Empresa_laboral_ADNE___Proyecto_PTC.Controlador.Controlador_UC_Calendario;
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
    public partial class UCDias : UserControl
    {
        public UCDias()
        {
            InitializeComponent();
            CTRLUCDias ObjUCControladorDias = new CTRLUCDias(this);
        }
    }
}
