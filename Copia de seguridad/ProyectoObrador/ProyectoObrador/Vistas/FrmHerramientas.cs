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

namespace ProyectoObrador.Vistas
{
    public partial class FrmHerramientas : Form
    {
        private Herramienta herramientaSeleccionada;
        private bool herramientasInactivosVisibles = false;
        public FrmHerramientas()
        {
            InitializeComponent();

            dgvHerramientas.CellClick += new DataGridViewCellEventHandler(dgvHerramientas_CellClick);
            txtNombreH.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtDescripcionH.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtMarcaH.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtModeloH.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtNSerieH.KeyDown += new KeyEventHandler(OnKeyDownHandler);

            cmbEstadoH.DropDownStyle = ComboBoxStyle.DropDownList;

            txtDescripcionH.TextChanged += new EventHandler(txtDescripcionH_TextChanged);
            lblCaracteresRestantes.Text = "0/150";
        }

        private void btnSalirH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreH.Text) ||
               string.IsNullOrEmpty(txtNSerieH.Text) ||
               string.IsNullOrEmpty(txtMarcaH.Text) ||
               string.IsNullOrEmpty(txtModeloH.Text) ||
               cmbEstadoH.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos marcados con '*' son obligatorios.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatosHerramientas datos = new DatosHerramientas();
            Herramienta herramientaExistente = datos.buscarXSerial(txtNSerieH.Text.Trim(), herramientasInactivosVisibles);
            if (herramientaExistente != null)
            {
                MessageBox.Show("Una herramienta con ese serial ya existe.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNSerieH.Focus();
                return;
            }

            string descripcion = string.IsNullOrEmpty(txtDescripcionH.Text)
                ? "No posee una descripcion." : txtDescripcionH.Text;

            Herramienta nuevaHerramienta = new Herramienta()
            {
                numero_serie = txtNSerieH.Text,
                nombre = txtNombreH.Text,
                marca = txtMarcaH.Text,
                modelo = txtModeloH.Text,
                estado = cmbEstadoH.SelectedItem.ToString(),
                descripcion = descripcion,
                disponible = true,
                activo = true
            };

            if (datos.agregarHerramienta(nuevaHerramienta) == "OK")
            {
                MessageBox.Show("Herramienta agregada", "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                dgvHerramientas.DataSource = datos.listarHerramientas();
            }
            else
            {
                Funciones.Logs("btnGuardarH_Click", "Error: Herramienta NO agregada.");
                MessageBox.Show("Herramienta NO agregada", "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEditEmpleado_Click(object sender, EventArgs e)
        {
            lbActivoHerra.Enabled = true;
            chbActivoHerra.Enabled = true;
            lbActivoHerra.Visible = true;
            chbActivoHerra.Visible = true;

            actualizarTotalHerramientas();
            if (herramientaSeleccionada != null)
            {
                int index = herramientaSeleccionada.estado.IndexOf(herramientaSeleccionada.estado);

                if (index != -1)
                {
                    cmbEstadoH.SelectedIndex = index;
                }
                else
                {
                    MessageBox.Show("Estado de la herramienta no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtNombreH.Text = herramientaSeleccionada.nombre;
                txtMarcaH.Text = herramientaSeleccionada.marca;
                txtModeloH.Text = herramientaSeleccionada.modelo;
                // aca estabuscando el estado de la herramienta 
                for (int i = 0; i < cmbEstadoH.Items.Count; i++)
                {
                    if (cmbEstadoH.Items[i].ToString() == herramientaSeleccionada.estado)
                    {
                        cmbEstadoH.SelectedIndex = i;
                        break;
                    }
                }
                if (cmbEstadoH.SelectedIndex == -1)
                {
                    MessageBox.Show("Estado de la herramienta no valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //
                txtDescripcionH.Text = herramientaSeleccionada.descripcion;
                txtNSerieH.Text = herramientaSeleccionada.numero_serie;
                chbActivoHerra.Checked = herramientaSeleccionada.activo;

                btnConfirmarEditHerra.Enabled = true;
                btnCancelarHerra.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay una herramienta seleccionada.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmarEditHerra_Click(object sender, EventArgs e)
        {
            lbActivoHerra.Enabled = false;
            chbActivoHerra.Enabled = false;
            lbActivoHerra.Visible = false;
            chbActivoHerra.Visible = false;

            actualizarTotalHerramientas();
            if (herramientaSeleccionada != null && herramientasInactivosVisibles == false)
            {
                string serialOriginal = herramientaSeleccionada.numero_serie;
                string serialNuevo = txtNSerieH.Text.Trim();
                if (string.IsNullOrEmpty(serialNuevo))
                {
                    MessageBox.Show("El serial no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (serialNuevo != serialOriginal)
                {
                    herramientaSeleccionada.numero_serie = serialNuevo;
                }

                herramientaSeleccionada.numero_serie = serialNuevo;
                herramientaSeleccionada.nombre = txtNombreH.Text;
                herramientaSeleccionada.descripcion = txtDescripcionH.Text;
                herramientaSeleccionada.marca = txtMarcaH.Text;
                herramientaSeleccionada.modelo = txtModeloH.Text;
                herramientaSeleccionada.estado = cmbEstadoH.Text;
                herramientaSeleccionada.activo = chbActivoHerra.Checked;

                MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
                try
                {
                    if (SQLdatos.State == ConnectionState.Closed)
                    {
                        SQLdatos.Open();
                        Funciones.Logs("btnConfirmarEdit_Click", "Conexion abierta");
                    }

                    MySqlCommand comando = new MySqlCommand("asp_actualizarHerramienta", SQLdatos);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("_numeroS_original", serialOriginal);
                    comando.Parameters.AddWithValue("_serial", serialNuevo);
                    comando.Parameters.AddWithValue("_nombre", herramientaSeleccionada.nombre);
                    comando.Parameters.AddWithValue("_descripcion", herramientaSeleccionada.descripcion);
                    comando.Parameters.AddWithValue("_marca", herramientaSeleccionada.marca);
                    comando.Parameters.AddWithValue("_modelo", herramientaSeleccionada.modelo);
                    comando.Parameters.AddWithValue("_estado", herramientaSeleccionada.estado);
                    comando.Parameters.AddWithValue("_activo", herramientaSeleccionada.activo);


                    int rowsAffected = comando.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("herramienta actualizada", "Informacion", MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        dgvHerramientas.DataSource = new DatosHerramientas().listarHerramientas();
                        actualizarTotalHerramientas();
                        btnConfirmarEditHerra.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la herramienta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    Funciones.Logs("actualizarHerramienta", ex.ToString());
                    MessageBox.Show("Error al actualizar la herramienta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (SQLdatos.State == ConnectionState.Open)
                    {
                        SQLdatos.Close();
                    }
                }
            }
        }

        private void btnCancelarHerra_Click(object sender, EventArgs e)
        {
            txtNombreH.Text = "";
            txtMarcaH.Text = "";
            txtModeloH.Text = "";
            cmbEstadoH.SelectedIndex = -1;
            txtDescripcionH.Text = "";
            txtNSerieH.Text = "";
            chbActivoHerra.Checked = false;
        }

        private void btnBorrarBusquedaHerramienta_Click(object sender, EventArgs e)
        {
            if (herramientasInactivosVisibles)
            {
                tablaHerramientaInactivosCargar();
            }
            else
            {
                cargarDatagrid();
            }
            txtBusquedaHerramienta.Text = "";
        }

        private void btnBuscarHerramienta_Click(object sender, EventArgs e)
        {
            actualizarTotalHerramientas();
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
                        herramienta = datos.buscarXid(id, herramientasInactivosVisibles);
                    }
                    else
                    {
                        MessageBox.Show("El ID debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Numero de serie":
                    herramienta = datos.buscarXSerial(terminoBusqueda, herramientasInactivosVisibles);
                    break;
                case "Marca":
                    herramientas = datos.buscarXMarca(terminoBusqueda, herramientasInactivosVisibles);
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
                dgvHerramientas.DataSource = herramientasInactivosVisibles ? datos.listarHerramientasInactivas() : datos.listarHerramientas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            actualizarTotalHerramientas();

            if (!chbEliminar.Checked)
            {
                MessageBox.Show("Debe seleccionar el checkbox 'Eliminar' para confirmar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvHerramientas.SelectedRows)
            {
                string serial = row.Cells["numero_serie"].Value.ToString();
                eliminarHerramienta(serial);
            }

            MessageBox.Show("Herramienta(s) eliminada(s)", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            chbEliminar.Checked = false;

            if (herramientasInactivosVisibles)
            {
                dgvHerramientas.DataSource = new DatosHerramientas().listarHerramientasInactivas();
            }
            else
            {
                dgvHerramientas.DataSource = new DatosHerramientas().listarHerramientasActivas();
            }

            actualizarTotalHerramientas();
        }

        //funciones
        //
        //
        private void cargarDatagrid()
        {
            DatosHerramientas datos = new DatosHerramientas();
            List<Herramienta> herramientas = datos.listarHerramientas();

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

            dgvDescripcion.BackgroundColor = Color.FromArgb(32, 32, 39);
            dgvDescripcion.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvDescripcion.DefaultCellStyle.ForeColor = Color.LightGray;
            dgvDescripcion.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dgvDescripcion.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvDescripcion.EnableHeadersVisualStyles = false; // deshabilita el estilo predeterminado de Windows
            dgvDescripcion.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvDescripcion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDescripcion.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);

            dgvHerramientas.BackgroundColor = Color.FromArgb(32, 32, 39);
            dgvHerramientas.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dgvHerramientas.DefaultCellStyle.ForeColor = Color.LightGray;
            dgvHerramientas.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dgvHerramientas.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvHerramientas.EnableHeadersVisualStyles = false; // deshabilita el estilo predeterminado de Windows
            dgvHerramientas.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvHerramientas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHerramientas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
        }
        private void eliminarHerramienta(string serial)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }

                MySqlCommand comando = new MySqlCommand("asp_eliminarHerramienta", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_serial", serial);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la herramienta: " + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
        }
        private void actualizarTotalHerramientas()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            int totalActivas = 0;
            int totalInactivas = 0;

            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }

                MySqlCommand comando = new MySqlCommand("asp_totalHerramientas", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        totalActivas = reader.GetInt32(reader.GetOrdinal("TotalActivos"));
                        totalInactivas = reader.GetInt32(reader.GetOrdinal("TotalInactivos"));
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_ContarHerramientas", ex.ToString());
            }
            finally
            {
                Funciones.CerrarConexion(SQLdatos);
            }

            lbTotalHerramienta.Text += $" {totalActivas + totalInactivas}";
            lbActivoHerramienta.Text = $"Activos: {totalActivas}";
            lbInactivoHerramienta.Text = $"Inactivos: {totalInactivas}";
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardarH_Click(sender, e);
            }
        }

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            //actualizarTotalHerramientas(); falta hacer
            cargarDatagrid();
            actualizarTotalHerramientas();
            activarDescativarTxtBusqueda();

            //importante esto para el buen diseño de la aplicacion,
            //dejo registrado lo que hace cada uno para recordar y no olvidarlo, ya que lo necesito
            //para los demas
            dgvHerramientas.AllowUserToAddRows = false; // no permitir agregar filas
            dgvHerramientas.AllowUserToDeleteRows = false; // no permitir eliminar filas
            dgvHerramientas.EditMode = DataGridViewEditMode.EditProgrammatically; // desactivar edicion directa
            dgvHerramientas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // seleccion de fila completa
            dgvHerramientas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void tablaHerramientaInactivosCargar()
        {
            DatosHerramientas datos = new DatosHerramientas();
            dgvHerramientas.DataSource = datos.listarHerramientasInactivas();
            dgvHerramientas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dgvHerramientas.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            // esto importantisimo hace que las celdas no sean editables
            dgvHerramientas.ReadOnly = true;
            dgvHerramientas.AllowUserToResizeRows = false;
            dgvHerramientas.RowHeadersVisible = false;

            herramientasInactivosVisibles = true;
        }

        private void txtDescripcionH_TextChanged(object sender, EventArgs e)
        {
            int caracteresMaximos = 150;
            int caracteresUsados = txtDescripcionH.Text.Length;
            lblCaracteresRestantes.Text = $"{caracteresUsados}/{caracteresMaximos}";

            // esto funca para que no se pase de los caracteres maximos
            if (caracteresUsados > caracteresMaximos)
            {
                txtDescripcionH.Text = txtDescripcionH.Text.Substring(0, caracteresMaximos);
                txtDescripcionH.SelectionStart = caracteresMaximos; // esto te pone el cursor alf inal si se pasa
            }
        }

        private void chbHerraInact_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHerraInact.Checked)
            {
                DatosHerramientas herramienta = new DatosHerramientas();
                dgvHerramientas.DataSource = herramienta.listarHerramientasInactivas();
                dgvHerramientas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (DataGridViewColumn column in dgvHerramientas.Columns)
                {
                    column.Resizable = DataGridViewTriState.False;
                }

                // esto importantisimo hace que las celdas no sean editables
                dgvHerramientas.ReadOnly = true;
                dgvHerramientas.AllowUserToResizeRows = false;
                dgvHerramientas.RowHeadersVisible = false;

                herramientasInactivosVisibles = true;
            }
            else
            {
                cargarDatagrid();
                herramientasInactivosVisibles = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosHerramientas herramienta = new DatosHerramientas();

            if (herramientasInactivosVisibles == false)
            {
                dgvHerramientas.DataSource = herramienta.listarHerramientasActivas();
            }
            else if (herramientasInactivosVisibles)
            {
                dgvHerramientas.DataSource = herramienta.listarHerramientasInactivas();
            }
            else
            {
                MessageBox.Show("Ocurrio un error.", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmbBusquedaHerramienta.SelectedIndex = -1;
            txtBusquedaHerramienta.Text = "";
        }

        private void cmbBusquedaHerramienta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBusquedaHerramienta.SelectedIndex == 0) txtBusquedaHerramienta.Text = "";
            if (cmbBusquedaHerramienta.SelectedIndex == 1) txtBusquedaHerramienta.Text = "";
            if (cmbBusquedaHerramienta.SelectedIndex == 2) txtBusquedaHerramienta.Text = "";

            activarDescativarTxtBusqueda();
        }

        private void activarDescativarTxtBusqueda()
        {
            if (cmbBusquedaHerramienta.SelectedIndex == -1)
            {
                txtBusquedaHerramienta.Enabled = false;
            }
            else
            {
                txtBusquedaHerramienta.Enabled = true;
            }
        }
        private void txtBusquedaHerramienta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
