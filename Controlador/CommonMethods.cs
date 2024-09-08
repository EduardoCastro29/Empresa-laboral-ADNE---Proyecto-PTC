using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CommonMethods
    {
        //La propiedad readonly especifica que solo será de uso de tipo lectura
        //Declaramos la variable string claveSecreta, que es la que contendrá la contraseña introducida por el usuario
        //Es como una caja secreta, será en dónde la guardará
        private readonly string claveSecreta = "Clave-Secreta-De-Encriptación-@123_______";
        //Declaramos la variable string claveSal, que luego será la sal necesitada para el hasheo
        private readonly string claveSal = "Clave-Hash-De-Encriptación-#123_______";

        //Se crea el algoritmo de encriptación AES y como parámetro el texto a encriptar
        //Que posteriormente se utilizará para el texto introducido por el usuario, encriptando la contraseña
        public string MetodoEncriptacionAES(string textoEncriptar)
        {
            //Creamos una variable de tipo string para el texto a encriptar
            string textoEncriptado;

            //Mandamos a llamar al algoritmo Rijndael antes creado con los datos de seguridad específicos
            //Que servirá para el encriptado de la contraseña
            RijndaelManaged ObjAlgoritmoRijndael = AlgoritmoRijndael();

            try
            {
                //Creamos el objeto de la libreria MemoryStream para la memoria de encriptación AES
                MemoryStream ObjMemoriaEncriptar = new MemoryStream();

                //Creamos el constructor de CryptoStream que recibirá como parámetros el motor de memoria
                //Y el objeto de la librería Rijndael antes creada, de esta forma se creará el encriptado   
                CryptoStream ObjCryptoStreamEncriptar = new CryptoStream(ObjMemoriaEncriptar, ObjAlgoritmoRijndael.CreateEncryptor(), CryptoStreamMode.Write);

                //Guardamos los bytes encriptados por la propiedad de arreglos
                //Posteriormente se obtienen los bytes encriptados a texto Unicode (todo tipo de texto)
                byte[] bytesEncriptar = Encoding.Unicode.GetBytes(textoEncriptar);

                //Encriptamos el texto en base a la longitud de los bytes (variable declarada como arreglo del texto a encriptar)
                //El CryptoStream se encargará de encriptar el texto introducido por el usuario (variable declarada como parámetro en el método)
                ObjCryptoStreamEncriptar.Write(bytesEncriptar, 0, bytesEncriptar.Length);
                ObjCryptoStreamEncriptar.FlushFinalBlock();

                //Convertimos los bytes encriptados en arreglos del Memory stream
                byte[] bytesEncriptados = ObjMemoriaEncriptar.ToArray();

                //Convertimos el texto encriptado en una cadena de caracteres, en base a los bytes encriptados
                //El cuál pasó por el encriptado de memoria
                textoEncriptado = Convert.ToBase64String(bytesEncriptados);

                //Retornamos el texto encriptado
                return textoEncriptado;
            }
            catch (Exception)
            {
                //En caso de error, se retornará null (inexistente)
                return null;
            }
        }
        //Este método no lo descomentemos aún XD, es para desencriptar el pin de acceso del Usuario de la base
        //Se enviará desencriptado bv

        public string MetodoDesencriptacionAES(string textoEncriptado)
        {
            //Creamos una variable de tipo string para el texto a desencriptar
            string textoDesencriptado;

            //Mandamos a llamar al algoritmo Rijndael antes creado con los datos de seguridad específicos
            //Que servirá para el desencriptado de algo en específico
            RijndaelManaged ObjAlgoritmoRijndael = AlgoritmoRijndael();

            try
            {
                //Creamos una variable de tipo byte que se guardará como propiedad de arreglo
                //La variable byte creada convertirá a bytes el texto encriptado
                byte[] bytesEncriptados = Convert.FromBase64String(textoEncriptado);

                //Definimos una variable para los bytes desencriptados que tomará la longitud de los bytes encriptados
                byte[] bytesDesencriptados = new byte[bytesEncriptados.Length];

                //Creamos el objeto de la libreria MemoryStream para la memoria de desencriptación AES
                MemoryStream ObjMemoriaDesencriptar = new MemoryStream(bytesEncriptados);

                //Creamos el constructor de CryptoStream que recibirá como parámetros el motor de memoria
                //Y el objeto de la librería Rijndael antes creada
                //De esta forma se creará el método de desencriptación con los parámetros recibidos
                CryptoStream ObjCryptoStreamDesencriptar = new CryptoStream(ObjMemoriaDesencriptar, ObjAlgoritmoRijndael.CreateDecryptor(), CryptoStreamMode.Read);

                //El CryptoStream se encargará de desencriptar el texto introducido por el usuario
                //Se obtienen la longitud de los bytes desencriptados por el objeto de memoria de desencriptación (ObjCryptoStreamDesencriptar)
                ObjCryptoStreamDesencriptar.Read(bytesDesencriptados, 0, bytesDesencriptados.Length);

                //Desencriptamos el texto en base a la longitud de los bytes (variable declarada como parámetro en el método)
                //Luego lo convertiremos a texto Unicode, permitiendo leer el texto desencriptado
                textoDesencriptado = Encoding.Unicode.GetString(bytesDesencriptados);

                //Remplazamos el texto desencriptado limpiando las cadenas
                //Es una sentencia que se tiene que definir por defecto, especificando el tipo de valor a retornar
                textoDesencriptado = textoDesencriptado.Replace("\0", "");

                //Retornamos el texto desencriptado
                return textoDesencriptado;
            }
            catch (Exception)
            {
                //En caso de error, se retornará null (inexistente)
                return null;
            }
        }
        private RijndaelManaged AlgoritmoRijndael()
        {
            //Creamos una instancia de Rfc2898 para la creación de la llave constructora
            //Se convierte en bytes el string claveSal, que luego se combinará con la contraseña para derivar la clave segura
            //Que será la responsable mantener la integridad de la contraseña
            Rfc2898DeriveBytes ObjLlaveConstructora = new Rfc2898DeriveBytes(claveSecreta, Encoding.Unicode.GetBytes(claveSal));
            //Creamos un objeto de la librería RijndaelManaged que nos permitirá especificar los datos del encriptado
            //Este algoritmo será utilizado para el método de encriptación
            RijndaelManaged ObjAlgoritmoRijndael = new RijndaelManaged();

            try
            {
                //Se especifica el tamaño que contendra la clave dentro de la base (encriptada)
                ObjAlgoritmoRijndael.KeySize = 256;

                //Definimos el vector de inicialización (IV, Initialization Vector) que será la que represente la claveSal
                ObjAlgoritmoRijndael.IV = ObjLlaveConstructora.GetBytes(Convert.ToInt32(ObjAlgoritmoRijndael.BlockSize / (double)8));

                //Definimos la clave secreta que será la que represente la claveSecreta dentro de la llave constructora
                ObjAlgoritmoRijndael.Key = ObjLlaveConstructora.GetBytes(Convert.ToInt32(ObjAlgoritmoRijndael.KeySize / (double)8));

                //Se define el modo de relleno que tendrá el algoritmo Rijndael, es una sentencia que se tiene por sintaxis
                ObjAlgoritmoRijndael.Padding = PaddingMode.PKCS7;

                //Retornamos el algoritmo Rijndael con los datos epecificados para el encriptado
                return ObjAlgoritmoRijndael;
            }
            catch (Exception)
            {
                //En caso de error, se retornará null (inexistente)
                return null;
            }
        }

        //Estos son los métodos comúnes para verificar si la contraseña ingresada por el usuario
        //Indicamos que, cada método retornará algo en específico, en este caso validar cada campo según sea su necesidad
        //Indicamos que, en primera instancia la contraseña debe poseer al menos 13 carácteres
        public bool Contiene12Caracteres(string Contrasena12Caracteres)
        {
            //Si la contraseña accedida por el usuario, posee más de 12 carácteres, retornamos verdadero
            if (Contrasena12Caracteres.Length >= 12 == true)
                return true;
            //Caso contrario, retornamos falso
            else return false;
        }
        public bool ContieneUnNumero(string ContrasenaUnNumero)
        {
            //Si la contraseña accedida por el usuario, contiene al menos 1 número, retornamos verdadero
            if (ContrasenaUnNumero.Any(char.IsDigit) == true)
                return true;
            //Caso contrario, retornamos falso
            else return false;
        }
        public bool ContieneUnaMayuscula(string ContrasenaUnaMayuscula)
        {
            //Si la contraseña accedida por el usuario, contiene al menos 1 letra mayúscula, retornamos verdadero
            if (ContrasenaUnaMayuscula.Any(char.IsUpper) == true)
                return true;
            //Caso contrario, retornamos falso
            else return false;
        }
        public bool ContieneUnaMinuscula(string ContrasenaUnaMinuscula)
        {
            //Si la contraseña accedida por el usuario, contiene al menos 1 letra minúscula, retornamos verdadero
            if (ContrasenaUnaMinuscula.Any(char.IsLower) == true)
                return true;
            //Caso contrario, retornamos falso
            else return false;
        }
        public bool ContieneUnSimbolo(string ContrasenaUnSimbolo)
        {
            //Si la contraseña accedida por el usuario, contiene al menos 1 símbolo proporcionado, retornamos verdadero
            string SimbolosPermitidos = "@$#_";
            if (ContrasenaUnSimbolo.Any(ParametroSimbolo => SimbolosPermitidos.Contains(ParametroSimbolo)) == true)
                return true;
            //Caso contrario, retornamos falso
            else return false;
        }
        //Ahora, procedemos a validar todas las acciones hechas por el usuario
        public bool ValidarContrasena(string ContrasenaValida)
        {
            //Declaramos en una estructura if para validar si todos los campos han sido ingresados correctamente
            if (Contiene12Caracteres(ContrasenaValida) &&
                ContieneUnNumero(ContrasenaValida) &&
                ContieneUnaMayuscula(ContrasenaValida) &&
                ContieneUnaMinuscula(ContrasenaValida) &&
                ContieneUnSimbolo(ContrasenaValida) == true)
                //Si todos los datos ingresados por el usuario, resultan ser correctos, retornamos verdadero
                return true;
            //Caso contrario, retornamos falso
            else return false;
        }

        //Creamos un metodo de lectura para verificar si existe el archivo de conexión hacia la DB
        public bool LeerArchivoXMLConexion()
        {
            string VerificarDirectorio = Path.Combine(Directory.GetCurrentDirectory().ToString(), "Configuracion_Servidor.xml");

            if (File.Exists(VerificarDirectorio))
            {
                XmlDocument ObjDocumentoXML = new XmlDocument();
                ObjDocumentoXML.Load(VerificarDirectorio);

                XmlNode ObjROOTEtiquetaPrincipal = ObjDocumentoXML.DocumentElement;
                XmlNode ObjNODOServidor = ObjROOTEtiquetaPrincipal.SelectSingleNode("ServidorSQL/text()");
                XmlNode ObjNODOBaseDatos = ObjROOTEtiquetaPrincipal.SelectSingleNode("BaseDatosSQL/text()");
                XmlNode ObjNODOAutenticacion = ObjROOTEtiquetaPrincipal.SelectSingleNode("AutenticacionSQL/text()");
                XmlNode ObjNODOContrasena = ObjROOTEtiquetaPrincipal.SelectSingleNode("ContraseñaSQL/text()");

                string CodigoServidor = ObjNODOServidor.Value;
                string CodigoBaseDatos = ObjNODOBaseDatos.Value;
                string CodigoAutenticacion = ObjNODOAutenticacion.Value;
                string CodigoContrasena = ObjNODOContrasena.Value;

                DTOAgregarConexion.Server = MetodoDesencriptacionAES(CodigoServidor);
                DTOAgregarConexion.Database = MetodoDesencriptacionAES(CodigoBaseDatos);
                DTOAgregarConexion.User = MetodoDesencriptacionAES(CodigoAutenticacion);
                DTOAgregarConexion.Password = MetodoDesencriptacionAES(CodigoContrasena);

                return true;
            }
            else return false;
        }

        //public string EncriptarContraseña (string contraseñaEncriptar)
        //{
        //    //Se crea la instancia de la libreria SHA256 que posteriormente creará una cadena hexadecimal para el encriptado de contraseñas
        //    SHA256 ObjEncriptacionSHA256 = SHA256.Create();

        //    //Se convierte la variable contraseñaEncriptar en un arreglo de bytes de encriptacionSHA256
        //    byte[] bytes = ObjEncriptacionSHA256.ComputeHash(Encoding.UTF8.GetBytes(contraseñaEncriptar));

        //    //Se instancia la libreria stringbuilder para convertir la cadena a hexadecimal
        //    StringBuilder ObjConstructor = new StringBuilder();

        //    //Se recorre cada byte en el arreglo para que de esta forma construya la cadena de encriptación
        //    for (int i = 0; i < bytes.Length; i++)
        //    {
        //        //Llamamos al constructor que posteriormente se convertira en una cadena hexadecimal en base 2 "x2"
        //        //De esta manera, la cadena será mas grande y segura
        //        ObjConstructor.Append(bytes[i].ToString("x2"));
        //    }
        //    //Retornamos el constructor como tipo string, de esta forma se devuelven los bytes encriptados en caracteres
        //    return ObjConstructor.ToString();
        //}
    }
}