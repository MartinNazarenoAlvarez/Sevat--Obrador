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
    public partial class FrmEmpleado : Form
    {
        private Empleado empleadoSeleccionado;
        private bool empleadoInactivosVisibles;
        private PictureBox img;
        public FrmEmpleado(PictureBox pi)
        {
            InitializeComponent();

            dgvEmpleados.CellClick += new DataGridViewCellEventHandler(dgvEmpleados_CellClick);

            txtDNI.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtApellido.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtNombre.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtCargo.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtTelefono.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            img = pi;
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            actualizarTotalEmpleados();
            cargarDatagrid();
            activarDescativarTxtBusqueda();

            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
               string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCargo.Text) ||
               string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!EsNumero(txtDNI.Text))
            {
                MessageBox.Show("El DNI debe contener solo numeros.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDNI.Focus();
                return;
            }

            if (!EsNumero(txtTelefono.Text))
            {
                MessageBox.Show("El telefono debe contener solo numeros.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            DatosEmpleados datos = new DatosEmpleados();
            Empleado empleado = datos.buscarXdni(txtDNI.Text, false);

            if (empleado != null)
            {
                MessageBox.Show("Un empleado con ese DNI ya existe.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDNI.Focus();
                return;
            }

            empleado = new Empleado()
            {
                dni = txtDNI.Text,
                apellido = txtApellido.Text,
                nombre = txtNombre.Text,
                cargo = txtCargo.Text,
                telefono = txtTelefono.Text,
                activo = true
            };

            if (datos.agregarEmpleado(empleado) == "OK")
            {
                MessageBox.Show("Empleado agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEmpleados.DataSource = datos.listarEmpleados();
                actualizarTotalEmpleados();
            }
            else
            {
                MessageBox.Show("Empleado NO agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditEmpleado_Click(object sender, EventArgs e)
        {
            lblActivo.Enabled = true;
            chbActivo.Enabled = true;
            lblActivo.Visible = true;
            chbActivo.Visible = true;

            actualizarTotalEmpleados();
            if (empleadoSeleccionado != null)
            {
                txtDNI.Text = empleadoSeleccionado.dni;
                txtApellido.Text = empleadoSeleccionado.apellido;
                txtNombre.Text = empleadoSeleccionado.nombre;
                txtCargo.Text = empleadoSeleccionado.cargo;
                txtTelefono.Text = empleadoSeleccionado.telefono;
                chbActivo.Checked = empleadoSeleccionado.activo;

                btnConfirmarEdit.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay un empleado seleccionado.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private void btnConfirmarEdit_Click(object sender, EventArgs e)
        {
            lblActivo.Enabled = false;
            chbActivo.Enabled = false;
            lblActivo.Visible = false;
            chbActivo.Visible = false;

            actualizarTotalEmpleados();
            if (empleadoSeleccionado != null && empleadoInactivosVisibles == false)
            {
                string dniOriginal = empleadoSeleccionado.dni;
                string dniNuevo = txtDNI.Text.Trim();
                if (string.IsNullOrEmpty(dniNuevo))
                {
                    MessageBox.Show("El DNI no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dniNuevo != dniOriginal)
                {
                    empleadoSeleccionado.dni = dniNuevo;
                }

                empleadoSeleccionado.apellido = txtApellido.Text;
                empleadoSeleccionado.nombre = txtNombre.Text;
                empleadoSeleccionado.cargo = txtCargo.Text;
                empleadoSeleccionado.telefono = txtTelefono.Text;
                empleadoSeleccionado.activo = chbActivo.Checked;

                DatosEmpleados datos = new DatosEmpleados();
                string resultado = datos.actualizarEmpleado(empleadoSeleccionado, dniOriginal, dniNuevo);
                if (resultado == "Empleado actualizado")
                {
                    MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvEmpleados.DataSource = datos.listarEmpleados();
                    actualizarTotalEmpleados();
                    btnConfirmarEdit.Enabled = false;
                }
                else
                {
                    MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (empleadoSeleccionado != null && empleadoInactivosVisibles == true)
            {
                string dniOriginal = empleadoSeleccionado.dni;
                string dniNuevo = txtDNI.Text.Trim();
                if (string.IsNullOrEmpty(dniNuevo))
                {
                    MessageBox.Show("El DNI no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dniNuevo != dniOriginal)
                {
                    empleadoSeleccionado.dni = dniNuevo;
                }

                empleadoSeleccionado.apellido = txtApellido.Text;
                empleadoSeleccionado.nombre = txtNombre.Text;
                empleadoSeleccionado.cargo = txtCargo.Text;
                empleadoSeleccionado.telefono = txtTelefono.Text;
                empleadoSeleccionado.activo = chbActivo.Checked;

                DatosEmpleados datos = new DatosEmpleados();
                string resultado = datos.actualizarEmpleado(empleadoSeleccionado, dniOriginal, dniNuevo);
                if (resultado == "Empleado actualizado")
                {
                    MessageBox.Show(resultado, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvEmpleados.DataSource = datos.listarEmpleados();
                    actualizarTotalEmpleados();
                    btnConfirmarEdit.Enabled = false;
                }
                else
                {
                    MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtCargo.Text = "";
            txtTelefono.Text = "";
            chbActivo.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(img.Visible == false)
            {
                img.Visible = true; 
            }
            this.Close();
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            if (empleadoInactivosVisibles)
            {
                tablaEmpleadosInactivosCargar();
            }
            else
            {
                cargarDatagrid();
            }
            txtBusqueda.Text = "";
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            actualizarTotalEmpleados();
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
                dgvEmpleados.DataSource = datos.listarEmpleados();
                return;
            }

            Empleado empleado = null;
            List<Empleado> empleados = null;

            switch (criterio)
            {
                case "DNI":
                    empleado = datos.buscarXdni(terminoBusqueda, empleadoInactivosVisibles);
                    break;

                case "ID":
                    if (int.TryParse(terminoBusqueda, out int id))
                    {
                        empleado = datos.buscarXid(id, empleadoInactivosVisibles);
                    }
                    else
                    {
                        MessageBox.Show("El ID debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;

                case "Apellido":
                    empleados = datos.listadoXApellido(terminoBusqueda, empleadoInactivosVisibles);
                    if (empleados != null && empleados.Count > 0)
                    {
                        dgvEmpleados.DataSource = empleados;
                        dgvEmpleados.Refresh();
                        return;
                    }
                    break;

                default:
                    MessageBox.Show("Selecciona un criterio de busqueda valido.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            if (empleado != null)
            {
                dgvEmpleados.DataSource = new List<Empleado> { empleado };
            }
            else
            {
                MessageBox.Show("Ningun empleado coincide con el criterio de busqueda.", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEmpleados.DataSource = empleadoInactivosVisibles ? datos.listarEmpleadosInactivos() : datos.listarEmpleados();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosEmpleados datos = new DatosEmpleados();

            if (empleadoInactivosVisibles == false)
            {
                dgvEmpleados.DataSource = datos.listarEmpleados();
            }
            else if (empleadoInactivosVisibles)
            {
                dgvEmpleados.DataSource = datos.listarEmpleadosInactivos();
            }
            else
            {
                MessageBox.Show("Ocurrio un error.", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmbBusqueda.SelectedIndex = -1;
            txtBusqueda.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            actualizarTotalEmpleados();

            if (!chbEliminar.Checked)
            {
                MessageBox.Show("Debe seleccionar el checkbox 'Eliminar' para confirmar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatosEmpleados datos = new DatosEmpleados();

            foreach (DataGridViewRow row in dgvEmpleados.SelectedRows)
            {
                string dni = row.Cells["dni"].Value.ToString();
                string resultado = datos.eliminarEmpleado(dni);
                if (resultado != "Empleado eliminado")
                {
                    MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Empleado(s) eliminado(s)", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            chbEliminar.Checked = false;

            if (empleadoInactivosVisibles)
            {
                dgvEmpleados.DataSource = datos.listarEmpleadosInactivos();
            }
            else
            {
                dgvEmpleados.DataSource = datos.listarEmpleados();
            }

            actualizarTotalEmpleados();
        }


        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // RECORDAR: Esto verifica que se selecciono una fila valida
            {
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];

                empleadoSeleccionado = new Empleado
                {
                    dni = row.Cells["dni"].Value.ToString(),
                    apellido = row.Cells["apellido"].Value.ToString(),
                    nombre = row.Cells["nombre"].Value.ToString(),
                    cargo = row.Cells["cargo"].Value.ToString(),
                    telefono = row.Cells["telefono"].Value.ToString(),
                    activo = (bool)row.Cells["activo"].Value
                };
            }
        }

        //Funciones
        //
        //
        public void cargarDatagrid()
        {
            DatosEmpleados datos = new DatosEmpleados();
            dgvEmpleados.DataSource = datos.listarEmpleados();
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dgvEmpleados.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            // esto importantisimo hace que las celdas no sean editables
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToResizeRows = false;
            dgvEmpleados.RowHeadersVisible = false;

            dgvEmpleados.BackgroundColor = Color.FromArgb(32, 32, 39); 
            dgvEmpleados.DefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17); 
            dgvEmpleados.DefaultCellStyle.ForeColor = Color.LightGray; 
            dgvEmpleados.DefaultCellStyle.SelectionBackColor = Color.DarkBlue; 
            dgvEmpleados.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvEmpleados.EnableHeadersVisualStyles = false; // deshabilita el estilo predeterminado de Windows
            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; 
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold); 
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyValue;
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardar_Click(sender, e);
            }

            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Name == "txtDNI")
                {
                    if (!char.IsControl(keyChar) && !char.IsDigit(keyChar))
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                        lblDNILetra.Visible = true;
                    }
                    else
                    {
                        lblDNILetra.Visible = false;
                    }
                }
                else if (textBox.Name == "txtTelefono")
                {
                    if (!char.IsControl(keyChar) && !char.IsDigit(keyChar))
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                        lblTelefonoLetra.Visible = true;
                    }
                    else
                    {
                        lblTelefonoLetra.Visible = false;
                    }
                }
            }
        }

        /*
        private void actualizarTotalEmpleadosInactivos()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            int totalEmpleados = 0;

            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }

                MySqlCommand comando = new MySqlCommand("asp_totalEmpleadoInactivos", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;
                totalEmpleados = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_ContarEmpleadosInactivo", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            lblTotalEmpleado.Text = $"Total de empleados inactivos: {totalEmpleados}";
        }*/
        private void tablaEmpleadosInactivosCargar()
        {
            DatosEmpleados datos = new DatosEmpleados();
            dgvEmpleados.DataSource = datos.listarEmpleadosInactivos();
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dgvEmpleados.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            // esto importantisimo hace que las celdas no sean editables
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToResizeRows = false;
            dgvEmpleados.RowHeadersVisible = false;

            empleadoInactivosVisibles = true;
        }

        private void actualizarTotalEmpleados()
        {
            int totalActivos = 0;
            int totalInactivos = 0;
            MySqlConnection conexion = null;

            try
            {
                conexion = Funciones.ObtenerConexion();

                MySqlCommand comando = new MySqlCommand("asp_totalEmpleado", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        totalActivos = reader.GetInt32("TotalActivos");
                        totalInactivos = reader.GetInt32("TotalInactivos");
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_ContarEmpleados", ex.ToString());
            }
            finally
            {
                Funciones.CerrarConexion(conexion);
            }

            lblTotalEmpleado.Text = $"Empleados en el sistema: {totalActivos + totalInactivos}";
            lbActivoT.Text = $"Activos: {totalActivos}";
            lbInactivoT.Text = $"Inactivos: {totalInactivos}";
        }

        private bool EsNumero(string texto)
        {
            return texto.All(char.IsDigit);
        }

        private void activarDescativarTxtBusqueda()
        {
            if (cmbBusqueda.SelectedIndex == -1)
            {
                txtBusqueda.Enabled = false;
            }
            else
            {
                txtBusqueda.Enabled = true;
            }
        }

        private void chbEmpInact_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEmpInact.Checked)
            {
                tablaEmpleadosInactivosCargar();
            }
            else
            {
                cargarDatagrid();
                empleadoInactivosVisibles = false;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDNILetra_Click(object sender, EventArgs e)
        {

        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBusqueda.SelectedIndex == 0) txtBusqueda.Text = "";
            if (cmbBusqueda.SelectedIndex == 1) txtBusqueda.Text = "";
            if (cmbBusqueda.SelectedIndex == 2) txtBusqueda.Text = "";

            activarDescativarTxtBusqueda();
        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
