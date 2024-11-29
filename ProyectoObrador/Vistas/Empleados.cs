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
    public partial class Empleados : Form
    {
        private Form formularioPadre;
        public Empleados(Form parentForm)
        {
            InitializeComponent();
            formularioPadre = parentForm;
        }



        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            DatosEmpleados datos = new DatosEmpleados();

            if (cmbBusqueda.SelectedIndex == -1 || string.IsNullOrEmpty(txtBusqueda.Text))
            {
                MessageBox.Show("Debe rellenar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string criterio = cmbBusqueda.SelectedItem.ToString();
            string terminoBusqueda = txtBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(terminoBusqueda))
            {
                dvgEmpleados.DataSource = datos.listarEmpleados();
                return;
            }

            Empleado empleado = null;
            List<Empleado> empleados = null;

            switch (criterio)
            {
                case "DNI":
                    empleado = datos.buscarXdni(terminoBusqueda, false);
                    break;

                case "ID":
                    if (int.TryParse(terminoBusqueda, out int id))
                    {
                        empleado = datos.buscarXid(id, false);
                    }
                    else
                    {
                        MessageBox.Show("El ID debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;

                case "Apellido":
                    empleados = datos.listadoXApellido(terminoBusqueda, false);
                    if (empleados != null && empleados.Count > 0)
                    {
                        dvgEmpleados.DataSource = empleados;
                        dvgEmpleados.Refresh();
                        return;
                    }
                    break;

                default:
                    MessageBox.Show("Selecciona un criterio de búsqueda válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (empleado != null)
            {
                dvgEmpleados.DataSource = new List<Empleado> { empleado };
            }
            else
            {
                MessageBox.Show("Ningún empleado coincide con el criterio de búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dvgEmpleados.DataSource = datos.listarEmpleados();
            }
        }

        public void cargarDatagrid()
        {
            DatosEmpleados datos = new DatosEmpleados();
            dvgEmpleados.DataSource = datos.listarEmpleados();

            dvgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dvgEmpleados.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            dvgEmpleados.ReadOnly = true;
            dvgEmpleados.AllowUserToResizeRows = false;
            dvgEmpleados.RowHeadersVisible = false;

            dvgEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dvgEmpleados.Rows.Count > 0)
            {
                dvgEmpleados.ClearSelection();
                dvgEmpleados.CurrentCell = null;
            }

            dvgEmpleados.BackgroundColor = Color.FromArgb(32, 32, 39);
            dvgEmpleados.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dvgEmpleados.DefaultCellStyle.ForeColor = Color.LightGray;
            dvgEmpleados.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dvgEmpleados.DefaultCellStyle.SelectionForeColor = Color.White;
            dvgEmpleados.EnableHeadersVisualStyles = false; // deshabilita el estilo predeterminado de Windows
            dvgEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dvgEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (dvgEmpleados.SelectedRows.Count > 0)
            {
                int idSeleccionado = (int)dvgEmpleados.SelectedRows[0].Cells["IdEmpleado"].Value;
                string dniSeleccionado = dvgEmpleados.SelectedRows[0].Cells["dni"].Value.ToString();
                string nombreSeleccionado = dvgEmpleados.SelectedRows[0].Cells["nombre"].Value.ToString();
                

                if (formularioPadre is Asignaciones asignacionesForm)
                {
                    asignacionesForm.ActualizarCeldas(idSeleccionado, dniSeleccionado, nombreSeleccionado);
                }
                else if (formularioPadre is Prestamos prestamosForm)
                {
                    prestamosForm.ActualizarCeldas(idSeleccionado, dniSeleccionado, nombreSeleccionado);
                    prestamosForm.ActualizarLabelHerramienta(nombreSeleccionado);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            cargarDatagrid();
            txtBusqueda.Text = "";
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            cargarDatagrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
