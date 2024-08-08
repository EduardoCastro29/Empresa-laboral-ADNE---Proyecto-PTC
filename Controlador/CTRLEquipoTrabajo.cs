using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLEquipoTrabajo
    {
        readonly EquipodeTrabajoForm ObjEquipoTrabajoForm;
        AdministradorForm ObjAdministrarUsuarios = null;

        public CTRLEquipoTrabajo (EquipodeTrabajoForm Vista)
        {
            ObjEquipoTrabajoForm = Vista;

            ObjEquipoTrabajoForm.btnAdministrarEmpleado.Click += new EventHandler(AdministrarUsuarios);
        }
        //Mi crudo





        private void AdministrarUsuarios(object sender, EventArgs e)
        {
            if (ObjAdministrarUsuarios == null || ObjAdministrarUsuarios.IsDisposed)
            {
                ObjAdministrarUsuarios = new AdministradorForm();
                ObjAdministrarUsuarios.Show();
            }
            else
            {
                ObjAdministrarUsuarios.BringToFront();
            }
        }
    }
}