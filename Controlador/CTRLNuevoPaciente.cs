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
    internal class CTRLNuevoPaciente
    {
        readonly NuevoPacienteForm ObjNuevoPacienteForm;
        Form FormActual;

        public CTRLNuevoPaciente(NuevoPacienteForm Vista)
        {
            ObjNuevoPacienteForm = Vista;

            ObjNuevoPacienteForm.Load += new EventHandler(FormularioPorDefecto);
            ObjNuevoPacienteForm.btnDatosIdentificacion.Click += new EventHandler(FormularioInformacionPersonal);
            ObjNuevoPacienteForm.btnExpediente.Click += new EventHandler(FormularioExpediente);
        }
        private void FormularioPorDefecto(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Pacientes, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<InformaciónPersonalForm>();
        }
        private void FormularioInformacionPersonal(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Pacientes, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<InformaciónPersonalForm>();
        }
        private void FormularioExpediente(object sender, EventArgs e)
        {
            //En caso de seleccionarse el formulario Pacientes, se abrirá declarandolo como un nuevo formulario después del método
            AbrirFormulario<ExpedienteMédicoForm>();
        }
        private void AbrirFormulario<Formulario>() where Formulario : Form, new()
        {
            //Creamos un objeto de tipo Forms que heredara el nuevo Formulario
            Form nuevoFormulario;
            //Se guardan los datos en el panelGeneralVistas que hereda el objeto nuevoFormulario que abrira el Formulario
            nuevoFormulario = ObjNuevoPacienteForm.panelElement.Controls.OfType<Formulario>().FirstOrDefault();
            //Si el objeto nuevoFormulario no llegase a existir, se crea uno nuevo
            if (nuevoFormulario == null)
            {
                //Se declara un uevo formulario que tendra como instancia <Formulario>
                nuevoFormulario = new Formulario();
                //Especificamos que el formulario deberá abrirse como ventana
                //Evitando los marcos de WindowsForms
                nuevoFormulario.TopLevel = false;
                //Se eliminan los bordes del formulario
                nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
                //Declaramos que utilizará todo el espacio del Panel
                nuevoFormulario.Dock = DockStyle.Fill;
                //Evaluamos si el FormularioActual es nulo, en caso de serlo, se ejecuta el siguiente código
                if (FormActual != null)
                {
                    //Se cierra el formulario actual para mostrar el nuevo formulario
                    FormActual.Close();
                    //Se eliminan todos los controles del FormularioActual dentro del panel
                    ObjNuevoPacienteForm.panelElement.Controls.Remove(FormActual);
                }
                //Establecemos que el FormularioActual es igual al nuevo formulario creado
                FormActual = nuevoFormulario;
                //Se agregan los controles que fueron previamente puestos en el nuevoFormulario dentro del Panel
                ObjNuevoPacienteForm.panelElement.Controls.Add(nuevoFormulario);
                ObjNuevoPacienteForm.panelElement.Tag = nuevoFormulario;
                //Se muestra el objeto nuevoFormulario creado
                nuevoFormulario.Show();
                //Se muestra al frente
                nuevoFormulario.BringToFront();
            }
            else
            {
                //En caso de no haberse ejecutado el código, se trae al frente un formulario nulo
                nuevoFormulario.BringToFront();
            }
        }
    }
}