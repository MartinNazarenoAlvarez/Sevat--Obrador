using ProyectoObrador.Datos;
using ProyectoObrador.Interfaz;
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
    public partial class HerramientasAsignadas : Form
    {
        private int idEmpleado;
        private Form formularioPadre;
        private Asignacion herramientaSeleccionada;

        public HerramientasAsignadas(Form parentForm, int idEmpleado)
        {
            InitializeComponent();
            dgvHerramientas.CellClick += new DataGridViewCellEventHandler(dgvHerramientas_CellClick);
            formularioPadre = parentForm;
            this.idEmpleado = idEmpleado;
        }



        private void dgvHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHerramientas.Rows[e.RowIndex];
                int idHerramienta = (int)row.Cells["id_herramienta"].Value;


                herramientaSeleccionada = new Asignacion
                {
                    idAsignacion = (int)row.Cells["idAsignacion"].Value,
                    id_herramienta = idHerramienta,
                    id_empleado = (int)row.Cells["id_empleado"].Value,
                    fechaAsignacion = (DateTime)row.Cells["fechaAsignacion"].Value,
                    fechaDevolucion = (DateTime)row.Cells["fechaDevolucion"].Value,
                    activo = Convert.ToBoolean(row.Cells["activo"].Value)
                };
            }
        }

        private void btnBorrarBusquedaHerramienta_Click(object sender, EventArgs e)
        {
            
        }
        private void cargarDatagrid()
        {
            DatosAsignaciones datos = new DatosAsignaciones();
            List<Asignacion> herramientas = datos.listarHerramientasPrestamoInactivo(this.idEmpleado);

            dgvHerramientas.DataSource = herramientas;
            dgvHerramientas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvHerramientas.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in dgvHerramientas.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            // Hacer que las celdas no sean editables
            dgvHerramientas.ReadOnly = true;
            dgvHerramientas.AllowUserToResizeRows = false;
            dgvHerramientas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvHerramientas.Columns.Contains("estado"))
            {
                dgvHerramientas.Columns["estado"].Width = 140;
            }
            if (herramientas.Count == 0)
            {
                lbHerraTodaPrestada.Visible = true;
                lbHerraTodaPrestada.Text = "Este empleado ya tiene todas sus herramientas con prestamo.";
                lbHerraTodaPrestada.ForeColor = Color.Red;
            }
        }

        private void btnBuscarHerramienta_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void HerramientasAsignadas_Load(object sender, EventArgs e)
        {
            cargarDatagrid();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvHerramientas.SelectedRows.Count > 0)
            {
                int idHerramienta = (int)dgvHerramientas.SelectedRows[0].Cells["id_herramienta"].Value;
                DatosHerramientas herra = new DatosHerramientas();
                Herramienta herramienta = herra.buscarXid(idHerramienta, false);

                if (herramienta != null)
                {
                    string serialSeleccionado = herramienta.numero_serie;
                    string modeloSeleccionado = herramienta.modelo;

                    if (formularioPadre is Asignaciones asignacionesForm)
                    {
                        asignacionesForm.ActualizarCeldasHerramienta(idHerramienta, serialSeleccionado, modeloSeleccionado);
                    }
                    else if (formularioPadre is Prestamos prestamosForm)
                    {
                        prestamosForm.ActualizarCeldasHerramienta(idHerramienta, serialSeleccionado, modeloSeleccionado);
                    }
                    
                    Prestamos prestamosVenta = new Prestamos();
                    prestamosVenta.ActualizarVariable(1);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Herramienta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBorrarBusquedaHerramienta_Click_1(object sender, EventArgs e)
        {
            cargarDatagrid();
            txtBusquedaHerramienta.Text = "";
        }

        private void btnBuscarHerramienta_Click_1(object sender, EventArgs e)
        {
            DatosHerramientas datos = new DatosHerramientas();
            DatosAsignaciones datosAsign = new DatosAsignaciones();

            if (cmbBusquedaHerramienta.SelectedIndex == -1 || string.IsNullOrEmpty(txtBusquedaHerramienta.Text))
            {
                MessageBox.Show("Debe rellenar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string criterio = cmbBusquedaHerramienta.SelectedItem.ToString();
            string terminoBusqueda = txtBusquedaHerramienta.Text.Trim();

            if (string.IsNullOrEmpty(terminoBusqueda))
            {
                dgvHerramientas.DataSource = datos.listarHerramientas();
                return;
            }

            Herramienta herramienta = null;
            List<Asignacion> asigna = null;
            List<Herramienta> herramientas = null;

            switch (criterio)
            {
                case "IDHerramienta":
                    if (int.TryParse(terminoBusqueda, out int id))
                    {
                        herramienta = datos.buscarXid(id, false);
                    }
                    else
                    {
                        MessageBox.Show("El ID debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "IDAsignacion":
                    if (int.TryParse(terminoBusqueda, out int idAsignacion))
                    {
                        asigna = datosAsign.buscarAsignacionPorId(idAsignacion);
                        if (asigna == null || asigna.Count == 0)
                        {
                            MessageBox.Show("No se encontraron asignaciones para el ID proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        dgvHerramientas.DataSource = asigna;
                    }
                    else
                    {
                        MessageBox.Show("El ID debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Marca":
                    herramientas = datos.buscarXMarca(terminoBusqueda, false);
                    if (herramientas != null && herramientas.Count > 0)
                    {
                        dgvHerramientas.DataSource = herramientas;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron herramientas con esa marca.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                default:
                    MessageBox.Show("Selecciona un criterio de busqueda valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (herramienta != null)
            {
                dgvHerramientas.DataSource = new List<Herramienta> { herramienta };
            }
            else
            {
                MessageBox.Show("Ninguna herramienta coincide con el criterio de busqueda.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHerramientas.DataSource = datos.listarHerramientasDisponibles();
            }
        }


        private void dgvHerramientas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
