using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            this.usuario = "sevati";
            this.password = "2609";
        }

        public MySqlConnection crearConexion()
        {
            MySqlConnection conexion = new MySqlConnection();

            try
            {
                conexion.ConnectionString = "Database= " + basedeDatos + ";Data Source= " + servidor +
                    "; User Id= " + usuario + " ;" + "Password=" + password + ";";
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                // Manejo de errores específicos
                switch (ex.Number)
                {
                    case 1045: // Código de error MySQL: Usuario/contraseña incorrectos
                        MessageBox.Show("Error: Usuario o contraseña incorrectos. No se pudo conectar a la base de datos.",
                                        "Error de autenticación",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        break;

                    case 1049: // Código de error MySQL: Base de datos no existe
                        MessageBox.Show("Error: La base de datos especificada no existe. Verifique el nombre de la base de datos.",
                                        "Error de base de datos",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        break;

                    case 0: // Código de error MySQL: Servidor no accesible
                        MessageBox.Show("Error: No se pudo conectar al servidor. Verifique que el servidor esté activo y accesible.",
                                        "Error de conexión",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        break;

                    default: // Otros errores
                        MessageBox.Show($"Error inesperado al conectar con la base de datos: {ex.Message}",
                                        "Error desconocido",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        break;
                }
                conexion = null; // Asegurarte de devolver `null` si falla
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
