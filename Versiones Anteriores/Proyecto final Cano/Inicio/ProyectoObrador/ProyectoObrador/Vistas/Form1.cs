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

namespace ProyectoObrador
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baseDatos = new MySqlConnection();

            baseDatos = (new Conexion().crearConexion());

            baseDatos.Open();

            MessageBox.Show(baseDatos.State.ToString());
            baseDatos.Close();

            /*
            MySqlConnection conBase = new MySqlConnection();
            conBase = (Conexion.GetConexion()).crearConexion(); 

            conBase.Open();
            MessageBox.Show(conBase.State.ToString());
            conBase.Close();    
            */
      }

        private void button2_Click(object sender, EventArgs e)
        {
            Funciones.Logs("Prueba","Esta es una prueba de logs.");
        }
    }
}
