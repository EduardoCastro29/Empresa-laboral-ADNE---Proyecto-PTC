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
    public partial class Control_Profesional : UserControl
    {
        internal Control_Profesional(DAOEquipoTrabajo DAOProfesional)
        {
            InitializeComponent();
            try
            {
                lblIdProfesional.Text = DAOProfesional.DUI;
                lblNombreProfesional.Text = DAOProfesional.NombresApellidos;
                lblEmail.Text = DAOProfesional.Correo;
                lblEspecialidad.Text = DAOProfesional.Especialidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
