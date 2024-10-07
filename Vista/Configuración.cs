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

namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    public partial class ConfiguraciónForm : Form
    {
        public ConfiguraciónForm()
        {
            InitializeComponent();
            leerIni();

            CTRLConfiguracion ObjConfiguracionControlador = new CTRLConfiguracion(this);
        }


        private void leerIni()
        {
            Config objConfig = new Config();
            objConfig.LeerIni();

            if (objConfig.objDTOConfig.modoOscuro == "dark")
            {
                this.switchModo.Checked = true;
            }
        }
    }
}
