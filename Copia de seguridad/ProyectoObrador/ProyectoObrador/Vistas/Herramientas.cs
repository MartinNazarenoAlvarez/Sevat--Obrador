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
    public partial class Herramientas : Form
    {
        private Herramienta herramientaSeleccionada;
        private Form formularioPadre;
        public Herramientas(Form parentForm)
        {
            InitializeComponent();
            dgvHerramientas.CellClick += new DataGridViewCellEventHandler(dgvHerramientas_CellClick);
            formularioPadre = parentForm;
        }
        private void dgvHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHerramientas.Rows[e.RowIndex];
                string descripcion = row.Cells["descripcion"].Value.ToString();

                herramientaSeleccionada = new Herramienta
                {
                    nombre = row.Cells["nombre"].Value.ToString(),
                    descripcion = row.Cells["descripcion"].Value.ToString(),
                    marca = row.Cells["marca"].Value.ToString(),
                    modelo = row.Cells["modelo"].Value.ToString(),
                    estado = row.Cells["estado"].Value.ToString(),
                    numero_serie = row.Cells["numero_serie"].Value.ToString(),
                    disponible = Convert.ToBoolean(row.Cells["disponible"].Value),
                    activo = Convert.ToBoolean(row.Cells["activo"].Value)
                };

                DataTable descripcionTable = new DataTable();
                descripcionTable.Columns.Add("Descripcion");
                DataRow descripcionRow = descripcionTable.NewRow();
                descripcionRow["Descripcion"] = descripcion;
                descripcionTable.Rows.Add(descripcionRow);

                dgvDescripcion.DataSource = descripcionTable;
            }
        }

        private void btnBorrarBusquedaHerramienta_Click(object sender, EventArgs e)
        {
            cargarDatagrid();
            txtBusquedaHerramienta.Text = "";
        }

        private void cargarDatagrid()
        {
            DatosHerramientas datos = new DatosHerramientas();
            List<Herramienta> herramientas = datos.listarHerramientasDisponibles();

            dgvHerramientas.DataSource = herramientas;
            dgvHerramientas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvHerramientas.Columns["descripcion"].Visible = false;
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
            //pa mostrar la descripcion aparte del dgv del listado de herramientas
            DataTable descripciones = new DataTable();
            descripciones.Columns.Add("Descripcion");
            dgvDescripcion.DataSource = descripciones;
            dgvDescripcion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescripcion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDescripcion.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDescripcion.Columns["Descripcion"].Resizable = DataGridViewTriState.False;
            dgvDescripcion.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDescripcion.ReadOnly = true;
            dgvDescripcion.RowHeadersVisible = false;
            dgvDescripcion.AllowUserToResizeRows = false;

            dgvHerramientas.BackgroundColor = Color.FromArgb(32, 32, 39);
            dgvHerramientas.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvHerramientas.DefaultCellStyle.ForeColor = Color.LightGray;
            dgvHerramientas.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dgvHerramientas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHerramientas.EnableHeadersVisualStyles = false; // deshabilita el estilo predeterminado de Windows
            dgvHerramientas.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvHerramientas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHerramientas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);

            dgvDescripcion.BackgroundColor = Color.FromArgb(32, 32, 39);
            dgvDescripcion.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvDescripcion.DefaultCellStyle.ForeColor = Color.LightGray;
            dgvDescripcion.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dgvDescripcion.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDescripcion.EnableHeadersVisualStyles = false; // deshabilita el estilo predeterminado de Windows
            dgvDescripcion.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvDescripcion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDescripcion.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
        }

        private void btnBuscarHerramienta_Click(object sender, EventArgs e)
        {
            DatosHerramientas datos = new DatosHerramientas();

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
            List<Herramienta> herramientas = null;

            switch (criterio)
            {
                case "ID":
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
                case "Numero de serie":
                    herramienta = datos.buscarXSerial(terminoBusqueda, false);
                    break;
                case "Marca":
                    herramientas = datos.buscarXMarca(terminoBusqueda, false);
                    if (herramientas != null && herramientas.Count > 0)
                    {
                        dgvHerramientas.DataSource = herramientas;
                        dgvHerramientas.Refresh();
                        return;
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

        private void Herramientas_Load(object sender, EventArgs e)
        {
            cargarDatagrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvHerramientas.SelectedRows.Count > 0)
            {
                int idHerramienta = (int)dgvHerramientas.SelectedRows[0].Cells["idHerramienta"].Value;
                string serialSeleccionado = dgvHerramientas.SelectedRows[0].Cells["numero_serie"].Value.ToString();
                string modeloSeleccionado = dgvHerramientas.SelectedRows[0].Cells["modelo"].Value.ToString();

                if (formularioPadre is Asignaciones asignacionesForm)
                {
                    asignacionesForm.ActualizarCeldasHerramienta(idHerramienta, serialSeleccionado, modeloSeleccionado);
                }
                else if (formularioPadre is Prestamos prestamosForm)
                {
                    prestamosForm.ActualizarCeldasHerramienta(idHerramienta, serialSeleccionado, modeloSeleccionado);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
