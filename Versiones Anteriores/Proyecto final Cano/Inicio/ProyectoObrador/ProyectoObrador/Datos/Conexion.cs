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
        private readonly string bd = "bd_obrador";
        private readonly string servidor = "127.0.0.1";
        private readonly string puerto = "3306";
        private readonly string usuario = "nazareno";
        private readonly string password = "naza";
        private string cadenaConexion;
        private MySqlConnection conn = null;

        public Conexion()
        {
            cadenaConexion = "Server = " + servidor + "; Database = " + bd + ";Uid = " + usuario + 
                ";Password = " + password + ";";
        }

        public MySqlConnection crearConexion()
        {
            try
            {
                if (conn == null) 
                {
                    conn = new MySqlConnection(cadenaConexion);
                }
            }
            catch (Exception error)
            {
                throw;
            }
            return conn;
        }

        /*private string basedeDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string password;
        private static Conexion con = null;

        private Conexion()
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
                conexion.ConnectionString = "Database= "+basedeDatos+";Data Source= "+servidor+"; User Id= "+usuario+" ;" +
                    "Password="+password+";";              

            }
            catch (MySqlException error)
            {
                conexion = null;
                error = null;
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
        }*/

    }
}
