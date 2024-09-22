//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;
//using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
//using Empresa_laboral_ADNE___Proyecto_PTC.Modelo;
//using Empresa_laboral_ADNE___Proyecto_PTC.Vista;

//namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
//{
//    internal class CTRLConexion
//    {
//        //Creando un objeto del formulario login
//        readonly LoginForm ObjConexion;
//        public CTRLConexion(LoginForm Vista)
//        {
//            //Enlazando el objeto con la Vista dentro del constructor
//            ObjConexion = Vista;

//            //Creando el evento EventHandler con el boton ProbarConexion con parametros de Conectar
//            //Que sería el método utilizado en la clase Conexion
//            ObjConexion.btnProbarConexion.Click += new EventHandler(Conectar);
//        }
//        public void Conectar(object sender, EventArgs e)
//        {
//            //Evaluando si la lase Conexion con el método Conectar sea diferente de null, mostramos el siguiente mensaje
//            if (Conexion.Conectar() != null)
//            {
//                MessageBox.Show("La conexión a la base de datos se ha ejecutado correctamente", "Conexión a la base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//            else
//            {
//                MessageBox.Show("La conexión a la base de datos no ha podido ejecutarse", "Conexión a la base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}