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
    public partial class Prestamos : Form
    {
        int idEmpleado;
        int cantidadHerramientas = 0;
        private DateTime fechaAsignacion;
        public Prestamos()
        {
            InitializeComponent();
            ConfiguracionEmpleadoSeleccionadoDataTable();
            ConfiguracionHerramientaSeleccionadoDataTable();
        }

        public void ActualizarLabelHerramienta(string texto)
        {
            lbHerraAsign.Text = texto;
        }


        private void ConfiguracionEmpleadoSeleccionadoDataTable()
        {
            dvDatosEmpleadoSel.Columns["Nombre"].Width = 160;
            dvDatosEmpleadoSel.RowHeadersVisible = false;
            dvDatosEmpleadoSel.AllowUserToResizeRows = false;
            foreach (DataGridViewColumn column in dvDatosEmpleadoSel.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
        }

        private void ConfiguracionHerramientaSeleccionadoDataTable()
        {
            dvHerramientaSel.Columns["Modelo"].Width = 160;
            dvHerramientaSel.RowHeadersVisible = false;
            dvHerramientaSel.AllowUserToResizeRows = false;
            foreach (DataGridViewColumn column in dvHerramientaSel.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
        }

        private void cargarGridPrestamo()
        {
            DatosPrestamos datos = new DatosPrestamos();
            List<Prestamo> prestamos = datos.listarPrestamo();

            dgvPrestamo.DataSource = prestamos;
            dgvPrestamo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPrestamo.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in dgvPrestamo.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            // Hacer que las celdas no sean editables
            dgvPrestamo.ReadOnly = true;
            dgvPrestamo.AllowUserToResizeRows = false;
            dgvPrestamo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            VerificarHerramientasDisponibles(lbNoHerraDisponibl);
            cargarGridPrestamo();
        }

        public void ActualizarCantidadHerramientas(int cantidad)
        {
            int cantidad_herramientas_sel = cantidad;
        }

        private void cargarDatagrid()
        {
            DatosAsignaciones datos = new DatosAsignaciones();
            List<Asignacion> herramientas = datos.buscarAsignacionPorId(this.idEmpleado);

            dgHerraAsi.DataSource = herramientas;
            dgHerraAsi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgHerraAsi.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in dgHerraAsi.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            // Hacer que las celdas no sean editables
            dgHerraAsi.ReadOnly = true;
            dgHerraAsi.AllowUserToResizeRows = false;
            dgHerraAsi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgHerraAsi.Columns.Contains("estado"))
            {
                dgHerraAsi.Columns["estado"].Width = 140;
            }
        }

        private bool guardarIdEmpleado(out int idEmpleado)
        {
            idEmpleado = 0;
            if (dvDatosEmpleadoSel.Rows.Count > 0)
            {
                DataGridViewRow fila = dvDatosEmpleadoSel.Rows[0];
                if (fila.Cells["IdEmpleado"].Value != null)
                {
                    idEmpleado = (int)fila.Cells["IdEmpleado"].Value; // Asignar el ID de empleado
                    return true; // Retornar true si se ha encontrado un cabrito valido
                }
                else
                {
                    MessageBox.Show("La columna 'IdEmpleado' esta vacia.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            return false; // Retornar false si no hay filas o el id es nulo zzzz
        }

        private void guardarIdHerrameinta(out int idHerramienta)
        {
            idHerramienta = 0;
            if (dvHerramientaSel.Rows.Count > 0)
            {
                DataGridViewRow fila = dvHerramientaSel.Rows[0];
                if (fila.Cells["IdHerramienta"].Value != null)
                {
                    idHerramienta = (int)fila.Cells["IdHerramienta"].Value;
                }
                else
                {
                    MessageBox.Show("La columna 'IdHerramienta' está vacía.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La tabla no contiene ninguna fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VerificarHerramientasDisponibles(Label lblEstado)
        {
            guardarIdEmpleado(out idEmpleado);
            DatosAsignaciones datosHerramienta = new DatosAsignaciones();
            List<Asignacion> herramientasDisponibles = datosHerramienta.buscarAsignacionPorId(idEmpleado);

            if (herramientasDisponibles == null || herramientasDisponibles.Count == 0)
            {
                lblEstado.Text = "No hay herramientas disponibles para este empleado.";
                lblEstado.ForeColor = Color.Red;
                button4.Enabled = false;
            }
            else
            {
                lblEstado.Text = "";
                button4.Enabled = true;
            }
        }

        private void cargarTabla()
        {

        }

        public void ActualizarCeldas(int idEmpleado, string dni, string nombre)
        {
            dvDatosEmpleadoSel.Rows.Clear();
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dvDatosEmpleadoSel);
            newRow.Cells[dvDatosEmpleadoSel.Columns["IdEmpleado"].Index].Value = idEmpleado;
            newRow.Cells[dvDatosEmpleadoSel.Columns["dni"].Index].Value = dni;
            newRow.Cells[dvDatosEmpleadoSel.Columns["nombre"].Index].Value = nombre;



            /*if (chbNombreEmpleBusc.Checked)
            {
                lbNombreEmplSel.Text = nombre;
                lbNombreEmplSel.Visible = true;
            }
            */
            dvDatosEmpleadoSel.Rows.Add(newRow);
        }

        public void ActualizarCeldasHerramienta(int idHerramienta, string serial, string modelo)
        {
            dvHerramientaSel.Rows.Clear();
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dvHerramientaSel);
            newRow.Cells[dvHerramientaSel.Columns["IdHerramienta"].Index].Value = idHerramienta;
            newRow.Cells[dvHerramientaSel.Columns["Serial"].Index].Value = serial;
            newRow.Cells[dvHerramientaSel.Columns["Modelo"].Index].Value = modelo;
            dvHerramientaSel.Rows.Add(newRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funciones.AbrirVentanaEmergente(new Empleados(this));
            VerificarHerramientasDisponibles(lbNoHerraDisponibl);
            cargarDatagrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guardarIdEmpleado(out idEmpleado);
            Funciones.AbrirVentanaEmergente(new HerramientasAsignadas(this, idEmpleado));
        }



        private bool verificacionDatosHerraEmplea()
        {
            if (dvDatosEmpleadoSel.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado antes de agregar una asignacion.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dvHerramientaSel.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una herramienta antes de agregar una asignacion.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool fechasAsignaciones()
        {
            fechaAsignacion = fechaPrestamo.Value;

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!verificacionDatosHerraEmplea())
            {
                return;
            }

            if (!fechasAsignaciones())
            {
                return;
            }

            DatosPrestamos datos = new DatosPrestamos();
            int idHerramienta;

            guardarIdEmpleado(out idEmpleado);
            guardarIdHerrameinta(out idHerramienta);

            if (idEmpleado == 0 || idHerramienta == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado y una herramienta validos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // aca se verifica si el prestamo que se esta por agregar
            // es con una idHerramienta que ya existe
            foreach (DataGridViewRow row in dgvPrestamo.Rows)
            {
                if (Convert.ToInt32(row.Cells["id_herramienta"].Value) == idHerramienta)
                {
                    MessageBox.Show("Ya existe un prestamo con esta herramienta.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            if (cbMovimiento.SelectedItem != null)
            {
                Prestamo nuevoPrestamo = new Prestamo()
                {
                    id_herramienta = idHerramienta,
                    id_empleado = idEmpleado,
                    fecha = fechaAsignacion,
                    tipo_movimiento = cbMovimiento.SelectedItem.ToString(),
                    cantidad = 1,
                };
                if (datos.agregarPrestamos(nuevoPrestamo) == "OK")
                {
                    MessageBox.Show("Prestamo agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Prestamo NO agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un movimiento.");
            }

            dvHerramientaSel.Rows.Clear();
        }

        public void ActualizarVariable(int valor)
        {
            cantidadHerramientas += valor; 
        }

        private void dvHerramientaSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgHerraAsi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            cargarDatagrid();
        }
    }
}
