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
    }
}