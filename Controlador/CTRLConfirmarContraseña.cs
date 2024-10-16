using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLConfirmarContraseña
    {
        readonly ConfirmarContraseñaForm ObjConfirmarContrasenaForm;
        public CTRLConfirmarContraseña(ConfirmarContraseñaForm Vista)
        {
            ObjConfirmarContrasenaForm = Vista;
            ObjConfirmarContrasenaForm.btnConfirmar.Click += new EventHandler(ConfirmarContra);
            ObjConfirmarContrasenaForm.btnConfirmarRestablecer.Click += new EventHandler(ConfirmarContraseña);
        }
        public void ConfirmarContra(object sender, EventArgs e)
        {
            switch (InicioSesion.DesempenoId)
            {
                case "Administrador":
                    //Instanciamos la clase CommonMethos
                    CommonMethods ObjMetodosComunes = new CommonMethods();
                    string ConfirmarContraseña = ObjMetodosComunes.MetodoEncriptacionAES(ObjConfirmarContrasenaForm.txtConfirmarContra.Text);

                    if (InicioSesion.Contraseña != ConfirmarContraseña)
                    {
                        MessageBox.Show("La contraseña no coincide, intentelo denuevo", "Confirmar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Instanciamos a al formulario de conexión
                        AgregarConexionForm ObjAbrirFMRConexion = new AgregarConexionForm();
                        ObjAbrirFMRConexion.txtServidorURL.Text = DTOAgregarConexion.Server;
                        ObjAbrirFMRConexion.txtBaseDeDatos.Text = DTOAgregarConexion.Database;
                        ObjAbrirFMRConexion.txtAutenticacion.Text = DTOAgregarConexion.User;
                        ObjAbrirFMRConexion.txtContrasena.Text = DTOAgregarConexion.Password;

                        ObjAbrirFMRConexion.txtServidorURL.Enabled = false;
                        ObjAbrirFMRConexion.txtBaseDeDatos.Enabled = false;
                        ObjAbrirFMRConexion.txtAutenticacion.Enabled = false;
                        ObjAbrirFMRConexion.txtContrasena.Enabled = false;

                        ObjAbrirFMRConexion.rbHabilitar.Enabled = false;
                        ObjAbrirFMRConexion.rbDesabilitar.Enabled = false;
                        ObjAbrirFMRConexion.btnGuardar.Enabled = false;

                        //Abrimos el formulario
                        ObjAbrirFMRConexion.ShowDialog();
                        ObjConfirmarContrasenaForm.Hide();
                    }
                    break;
                case "Empleado":
                    MessageBox.Show("El registro del usuario pertenece a un rol de acceso denegado", "Confirmar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }

        public void ConfirmarContraseña(object sender, EventArgs e )
        {
            CommonMethods ObjMetodosComunes = new CommonMethods();
            string ConfirmarContraseña = ObjMetodosComunes.MetodoEncriptacionAES(ObjConfirmarContrasenaForm.txtConfirmarContra.Text);

            if (InicioSesion.Contraseña != ConfirmarContraseña)
            {
                MessageBox.Show("La contraseña no coincide, intentelo denuevo", "Confirmar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Instanciamos a al formulario de cambiar contraseña
                ActualizarContraseñaForm ObjActualizarContraseña = new ActualizarContraseñaForm();
                //Abrimos el formulario
                ObjActualizarContraseña.ShowDialog();
                ObjConfirmarContrasenaForm.Hide();
            }
        }
    }
}