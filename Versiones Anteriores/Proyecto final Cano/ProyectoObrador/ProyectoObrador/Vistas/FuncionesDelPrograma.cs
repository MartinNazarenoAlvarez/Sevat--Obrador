using MySql.Data.MySqlClient;
using ProyectoObrador.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoObrador.Vistas
{
    public partial class FuncionesDelPrograma : Form
    {
        public FuncionesDelPrograma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funciones.Logs("Prueba", "Esta es una prueba de logs.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conBase = Conexion.GetConexion().crearConexion();
                if (conBase == null)
                {
                    MessageBox.Show("Error: No se pudo establecer la conexión a la base de datos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (conBase.State == ConnectionState.Closed)
                {
                    conBase.Open();
                }

                MessageBox.Show("Conexión exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir la conexión: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
