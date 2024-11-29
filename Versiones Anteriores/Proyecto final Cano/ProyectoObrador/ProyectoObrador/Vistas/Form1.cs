using MySql.Data.MySqlClient;
using ProyectoObrador.Datos;
using ProyectoObrador.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoObrador
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            customDesign();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr lwen, int wmsg, int wparam, int lparam);

        private void customDesign()
        {
            panelAdmSubMenu.Visible = false;
            panelSubMenuPrestamo.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelAdmSubMenu.Visible == true) panelAdmSubMenu.Visible = false;
            if (panelSubMenuPrestamo.Visible == true) panelSubMenuPrestamo.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado ventana = new frmEmpleado();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void testConexionConBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 250)
            {
                menuVertical.Width = 70;
            }
            else
            {
                menuVertical.Width = 250;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Funciones.AbrirFormInPanel(this, new frmEmpleado());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Funciones.AbrirFormInPanel(this, new FuncionesDelPrograma());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Funciones.AbrirFormInPanel(this, new FrmHerramientas());
        }

        private void admHE_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdmSubMenu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Funciones.Logs("Prueba", "Esta es una prueba de logs.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuPrestamo);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Funciones.AbrirFormInPanel(this, new Prestamos());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Funciones.AbrirFormInPanel(this, new Asignaciones());
        }

        private void button7_Click(object sender, EventArgs e)
        {
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

                MessageBox.Show("Conexion exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir la conexion: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
