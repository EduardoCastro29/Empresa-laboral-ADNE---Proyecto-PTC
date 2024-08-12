﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class Conexion
    {
        //Creando el método llamado Conectar como método de encapsulación público
        //De esta forma, puede acceder a otras clases externas para poderse utilizar como herencia de SqlConnection para la conexión de la DB
        public static SqlConnection Conectar()
        {
            try
            {
                //Definiendo las variables de conexión
                string servidor = "DESKTOP-FSK1K0V\\SQLEXPRESS"; //Pongan su dirección de SQL Server, en mi caso es esa bv
                string DBnombre = "ADNE2024"; //Queda igual, ya que es el nombre de la DB

                //Creando objeto ObjConexion de tipo SqlConnection con los datos de la conexión hacia la base de datos
                SqlConnection ObjConexion = new SqlConnection($"Server = {servidor}; Database = {DBnombre}; Integrated Security = true");
                //Abrimos la conexión
                ObjConexion.Open();

                //Retornamos la conexión
                return ObjConexion;
            }
            catch (Exception)
            {
                //En caso de que exista el error se retorna una conexión nula
                return null;
            }
        }
    }
}