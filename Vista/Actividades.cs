using Empresa_laboral_ADNE___Proyecto_PTC.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class ActividadesForm : Form
    {
        public ActividadesForm()
        {
            InitializeComponent();
            CTRLActividades ObjCTRLActividades = new CTRLActividades(this);
        }
    }
}
