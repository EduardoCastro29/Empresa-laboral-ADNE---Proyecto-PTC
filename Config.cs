using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_laboral_ADNE___Proyecto_PTC
{
    internal class Config
    {
        //Mediante esta clase, se configuran get set del DTO, las funciones de lectura y escritura de datos.
        //Se recurre a la utilización de librerias (Kernel32) y archivos externos .ini que permiten almacenar los valores de cambio de tema en la memoria.

        //Se define la ruta del archivo, instanciando la importación del Kernel32 para guardar los datos en la memoria del núcleo de Windows
        public string iniRuta = Application.StartupPath + @"\config.ini";
        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        
        //Se declara la variable de tipo entero para la lectura del archivo, en la sección de clave
        //Como parametros, elementos dentro del archivo como la sección y el nombre de la clave, el valor predeterminado, el tamaño, nombre del archivo.
        //Luego, se devuelve el valor de la clave dentro de la sección y se guarda en el StringBuilder stringRetornado, permitiendo modificar el string en la memoria
        private static extern int GetPrivateProfileString(string nombreSeccion, string nombreClave, string valorPred, StringBuilder stringRetornado, int Tamano, string nombreArchivo);
        [DllImport("Kernel32")]

        //Sucede lo mismo con el método de lectura, ser instancian la sección en que se ubica la clave, el valor de la clave y la ruta del archivo
        //La varable nos permitirá reescribir el valor de la clave
        private static extern long WritePrivateProfileString(string Seccion, string NombreClave, string valor, string ruta);

        public StringBuilder sbTema;

        public DTOConfiguracion objDTOConfig = new DTOConfiguracion();
            
        

        public void LeerIni()
        {
            int resultado;
            sbTema = new StringBuilder(10);
            resultado = GetPrivateProfileString("SECTION", "key", "", sbTema, sbTema.Capacity, iniRuta);

            objDTOConfig.ModoOscuro = sbTema.ToString();
        }

        public void EscribirIni(string seccion, string clave, string value)
        {
            WritePrivateProfileString(seccion, clave, value, iniRuta);
        }
    }
}
