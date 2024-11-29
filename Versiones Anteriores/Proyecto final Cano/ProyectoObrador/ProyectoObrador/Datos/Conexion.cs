using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProyectoObrador.Datos
{
    internal class Conexion
    { 
        private string basedeDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string password;
        private static Conexion con = null;

        public Conexion()
        {
            this.basedeDatos = "bd_obrador";
            this.servidor = "127.0.0.1";
            this.puerto = "3306";
            this.usuario = "nazareno";
            this.password = "naza";
        }

        public MySqlConnection crearConexion()
        {
            MySqlConnection conexion = new MySqlConnection();

            try
            {
                conexion.ConnectionString = "Database= "+basedeDatos+";Data Source= "+servidor +
                    "; User Id= "+usuario+" ;" + "Password="+password+";";
                conexion.Open();

            }
            catch (MySqlException)
            {
                conexion = null;
            }
            return conexion;        
        }

        public static Conexion GetConexion()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }

    }
}
