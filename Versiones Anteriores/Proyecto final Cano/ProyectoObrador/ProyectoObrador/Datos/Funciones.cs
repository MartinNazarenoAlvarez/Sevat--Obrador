using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoObrador.Datos
{
    class Funciones
    {
        public static void Logs(string nombre_archivo, string detalle)
        {
            string directorio = AppDomain.CurrentDomain.BaseDirectory + "log/" +
                DateTime.Now.Year.ToString() + "/" +
                DateTime.Now.Month.ToString() + "/" +
                DateTime.Now.Day.ToString() + "/";

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            StreamWriter mi_archivo = new StreamWriter(directorio + "/" + nombre_archivo + ".txt", true);
            string descripcion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " --> " + detalle;

            mi_archivo.WriteLine(descripcion);
            mi_archivo.Close();
        }

        public static void ConfirmarCierreVentana(Form ventana)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro de que deseas cerrar esta ventana?",
                                          "Confirmar cierre",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ventana.Close();
            }
        }

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            if (SQLdatos.State == ConnectionState.Closed)
            {
                SQLdatos.Open();
            }
            return SQLdatos;
        }

        public static void CerrarConexion(MySqlConnection conexion)
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public static void AbrirFormInPanel(Form parentForm, object formHijo)
        {
            Panel panelContenedor = (Panel)parentForm.Controls["panelContenedor"];
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            if (fh != null)
            {
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(fh);
                panelContenedor.Tag = fh;
                fh.Show();
            }
        }

        public static void AbrirVentanaEmergente(object formHijo)
        {
            Form fh = formHijo as Form;
            if (fh != null)
            {
                fh.StartPosition = FormStartPosition.CenterParent;
                fh.ShowDialog();
            }
        }
    }
}
