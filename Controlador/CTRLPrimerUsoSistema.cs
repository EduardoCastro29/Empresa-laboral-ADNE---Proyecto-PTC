using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System.Drawing.Printing;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLPrimerUsoSistema
    {
        readonly PrimerUsoSistemaForm ObjPrimerUsoSistema;

        public CTRLPrimerUsoSistema(PrimerUsoSistemaForm Vista)
        {
            ObjPrimerUsoSistema = Vista;

            ObjPrimerUsoSistema.btnRegistrar.Click += new EventHandler(RegistrarEmpresa);
        }
        private void RegistrarEmpresa(object sender, EventArgs e)
        {
            try
            {
                DAOPrimerUsoSistema ObjRegistrarEmpresa = new DAOPrimerUsoSistema();

                //Insertamos los valores correspondientes del DTO (no hay)
                //ObjRegistrarEmpresa.
                //ObjRegistrarEmpresa.
                //ObjRegistrarEmpresa.
                //ObjRegistrarEmpresa.
                //ObjRegistrarEmpresa.
                //ObjRegistrarEmpresa.
                //ObjRegistrarEmpresa.

                if (ObjRegistrarEmpresa.RegistrarEmpresa() == true)
                {
                    MessageBox.Show("El registro de la empresa ha sido existoso", "Regtistro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la empresa, verifique si todos los campos han sido ingresados correctamente", "Regtistro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}