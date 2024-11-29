using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoObrador.Datos;
using ProyectoObrador.Vistas;

namespace ProyectoObrador
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            customDesign();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAdministracion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
            }
            
            Funciones.AbrirFormInPanel(this, new FrmEmpleado(pictureBox2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            Funciones.AbrirFormInPanel(this, new FrmHerramientas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            showSubMenu(panelSubMenuPrestamo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            Funciones.AbrirFormInPanel(this, new Prestamos());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            Funciones.AbrirFormInPanel(this, new Asignaciones());
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void hideSubMenu()
        {
            if (panelSubMenuAdministracion.Visible == true) panelSubMenuAdministracion.Visible = false;
            if (panelSubMenuPrestamo.Visible == true) panelSubMenuPrestamo.Visible = false;
        }

        private void customDesign()
        {
            panelSubMenuAdministracion.Visible = false;
            panelSubMenuPrestamo.Visible = false;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conBase = Conexion.GetConexion().crearConexion();
                if (conBase == null)
                {
                    MessageBox.Show("Error: No se pudo establecer la conexion a la base de datos.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (conBase.State == ConnectionState.Closed)
                {
                    conBase.Open();
                }

                MessageBox.Show("Conexion exitosa con la base de datos.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir la conexion: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.GetConexion().crearConexion();
            if (conexion == null)
            {
                MessageBox.Show("No se pudo establecer conexion con la base de datos. El programa se cerrara.",
                                "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            pictureBox2.SendToBack();
        }

    }
}
