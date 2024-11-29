using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoObrador.Datos;
using ProyectoObrador.Interfaz;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoObrador.Vistas
{
    public partial class Asignaciones : Form
    {
        private DateTime fechaAsignacion;
        private DateTime fechaDevolucion;
        private DateTime fechaPredeterminada;
        private Asignacion asignacionElegida;
        int idEmpleado;
        bool asignacionesInactivas = false;

        public Asignaciones()
        {
            InitializeComponent();
            ConfiguracionEmpleadoSeleccionadoDataTable();
            ConfiguracionHerramientaSeleccionadoDataTable();
            chbNombreEmpleBusc.CheckedChanged += new EventHandler(chbNombreEmpleBusc_CheckedChanged);
            chbBuscarFechas.CheckedChanged += new EventHandler(chbBuscarFechas_CheckedChanged);

            fechaPredeterminada = fechaInicio.Value.Date;
        }


        private void chbNombreEmpleBusc_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNombreEmpleBusc.Checked)
            {
                btBuscarNombre.Enabled = true;
            }
            else
            {
                btBuscarNombre.Enabled = false;
                lbNombreEmplSel.Text = "";
            }
        }

        private void chbBuscarFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBuscarFechas.Checked)
            {
                fechaInicio.Enabled = true;
                fechaFinal.Enabled = true;
            }
            else
            {
                fechaInicio.Enabled = false;
                fechaFinal.Enabled = false; 
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
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

            if (chbNombreEmpleBusc.Checked)
            {
                lbNombreEmplSel.Text = nombre;
                lbNombreEmplSel.Visible = true; 
            }
            
            dvDatosEmpleadoSel.Rows.Add(newRow);
        }

        private void limpiarTablaDatos(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funciones.AbrirVentanaEmergente(new Empleados(this));
        }

        public void ActualizarAsignacionHerramienta(string texto)
        {
            lbAsignacionHerramientaA.Text = $"Herramientas Asignadas a: {texto}";
        }

        public void ActualizarDataGrid(DataTable datos)
        {
            dvDatosEmpleadoSel.DataSource = datos;
            dvDatosEmpleadoSel.RowHeadersVisible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Funciones.AbrirVentanaEmergente(new Herramientas(this));
        }

        public void ActualizarCeldasHerramienta(int idHerramienta, string serial, string modelo)
        {
            //dvHerramientaSel.Rows.Clear();
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dvHerramientaSel);
            newRow.Cells[dvHerramientaSel.Columns["IdHerramienta"].Index].Value = idHerramienta;
            newRow.Cells[dvHerramientaSel.Columns["Serial"].Index].Value = serial;
            newRow.Cells[dvHerramientaSel.Columns["Modelo"].Index].Value = modelo;

            dvHerramientaSel.Rows.Add(newRow);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnEditEmpleado_Click(object sender, EventArgs e)
        {
            DateTime fechaMinima = DateTime.Parse("01/01/1753");
            chbActivo.Enabled = true;
            chbActivo.Visible = true;   

            if (dvAsignacionesMostrar.SelectedRows.Count > 0)
            {
                //aca se obtiene la fila seleccionada como un DataRowView
                // DataRowView proporciona una vista de un DataRow
                // permitiendo acceder a las columnas mediante el nombres de las columnas
                Asignacion asignacionSeleccionada = (Asignacion)dvAsignacionesMostrar.SelectedRows[0].DataBoundItem;

                bool acti = asignacionSeleccionada.activo;
                Funciones.Logs("editarvalorActivo", $"{acti}");

                asignacionSeleccionada = new Asignacion
                {
                    id_herramienta = asignacionSeleccionada.id_herramienta,
                    id_empleado = asignacionSeleccionada.id_empleado,
                    fechaAsignacion = asignacionSeleccionada.fechaAsignacion,
                    fechaDevolucion = asignacionSeleccionada.fechaDevolucion,
                    activo = acti
                };
                chbActivo.Checked = acti;

                dvDatosEmpleadoSel.Rows.Clear();
               // dvHerramientaSel.Rows.Clear();

                if (asignacionSeleccionada.id_herramienta != 0)
                {
                    DatosHerramientas datosHerramientas = new DatosHerramientas();
                    Herramienta herramienta = datosHerramientas.buscarXid(asignacionSeleccionada.id_herramienta, false);
                    if (herramienta != null)
                    {
                        dvHerramientaSel.Rows.Add(
                            herramienta.idHerramienta,
                            herramienta.numero_serie,
                            herramienta.modelo
                        );
                    }
                }

                if (asignacionSeleccionada.id_empleado != 0)
                {
                    DatosEmpleados datosEmpleados = new DatosEmpleados();
                    Empleado empleado = datosEmpleados.buscarXid(asignacionSeleccionada.id_empleado, false);
                    if (empleado != null)
                    {
                        dvDatosEmpleadoSel.Rows.Add(
                            empleado.idEmpleado,
                            empleado.dni,
                            empleado.nombre
                        );
                    }
                }

                if (asignacionSeleccionada.fechaAsignacion < fechaMinima ||
                    asignacionSeleccionada.fechaDevolucion < fechaMinima)
                {
                    DateTime fechaActual = DateTime.Now;
                    MessageBox.Show("Fecha invalida, se preeligio la fecha actual.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtfechaAsignacion.Value = fechaActual;
                    dtfechaDevolucion.Value = fechaActual;
                }
                else
                {
                    dtfechaAsignacion.Value = asignacionSeleccionada.fechaAsignacion;
                    dtfechaDevolucion.Value = asignacionSeleccionada.fechaDevolucion;
                }
                btnConfirmarEdit.Enabled = true;
                btnCancelarEdit.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay una asignacion seleccionada.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        private bool fechasAsignaciones()
        {
            fechaAsignacion = dtfechaAsignacion.Value;
            DateTime fechaPropuestaDevolucion = dtfechaDevolucion.Value;

            if (fechaPropuestaDevolucion > fechaAsignacion)
            {
                fechaDevolucion = fechaPropuestaDevolucion;
                return true;
            }
            else
            {
                MessageBox.Show("La fecha de devolucion debe ser posterior a la fecha de asignacion.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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

        private void cargarDatagird()
        {
            DatosAsignaciones asignacion = new DatosAsignaciones();
            dvAsignacionesMostrar.DataSource = asignacion.listarAsignaciones();
            dvAsignacionesMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dvAsignacionesMostrar.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
            dvAsignacionesMostrar.ReadOnly = true;
            dvAsignacionesMostrar.AllowUserToResizeRows = false;
            dvAsignacionesMostrar.RowHeadersVisible = false;
            dvAsignacionesMostrar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dvAsignacionesMostrar.Rows.Count > 0)
            {
                dvAsignacionesMostrar.ClearSelection();
                dvAsignacionesMostrar.CurrentCell = null;
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
                    MessageBox.Show("La columna 'IdEmpleado' está vacía.", "Error", MessageBoxButtons.OK,
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

        private void btnAgregarAsignacio_Click(object sender, EventArgs e)
        {
            if (!verificacionDatosHerraEmplea())
            {
                return;
            }

            if (!fechasAsignaciones())
            {
                return;
            }

            DatosAsignaciones datos = new DatosAsignaciones();
            int idHerramienta;

            guardarIdEmpleado(out idEmpleado);
            guardarIdHerrameinta(out idHerramienta);

            if (idEmpleado == 0 || idHerramienta == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado y una herramienta validos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // aca se verifica si la asignacion que se esta por agregar
            // es con una idHerramienta que ya existe
            foreach (DataGridViewRow row in dvAsignacionesMostrar.Rows)
            {
                if (Convert.ToInt32(row.Cells["id_herramienta"].Value) == idHerramienta)
                {
                    MessageBox.Show("Ya existe una asignacion con esta herramienta.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            Asignacion nuevaAsignacion = new Asignacion()
            {
                id_herramienta = idHerramienta,
                id_empleado = idEmpleado,
                fechaAsignacion = fechaAsignacion,
                fechaDevolucion = fechaDevolucion,
                activo = true
            };

            if (datos.agregarAsignacion(nuevaAsignacion) == "OK")
            {
                MessageBox.Show("Asignacion agregada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dvAsignacionesMostrar.DataSource = datos.listarAsignaciones();
                limpiarTablaDatos(dvDatosEmpleadoSel);
                limpiarTablaDatos(dvHerramientaSel);
            }
            else
            {
                MessageBox.Show("Asignacion NO agregada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VerificarHerramientasDisponibles(lbNoHerraDisponibl);
        }


        private void Asignaciones_Load(object sender, EventArgs e)
        {
            cargarDatagird();
            VerificarHerramientasDisponibles(lbNoHerraDisponibl);
        }

        public void VerificarHerramientasDisponibles(Label lblEstado)
        {
            DatosHerramientas datosHerramienta = new DatosHerramientas();
            List<Herramienta> herramientasDisponibles = datosHerramienta.listarHerramientasDisponibles();

            if (herramientasDisponibles == null || herramientasDisponibles.Count == 0)
            {
                lblEstado.Text = "No hay herramientas disponibles.";
                lblEstado.ForeColor = Color.Red;
                button4.Enabled = false;
            }
            else
            {
                lblEstado.Text = ""; 
                button4.Enabled = true; 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Funciones.AbrirVentanaEmergente(new Empleados(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatosAsignaciones datosAsignaciones = new DatosAsignaciones();

            bool buscarPorEmpleado = chbNombreEmpleBusc.Checked;
            bool buscarPorFechas = chbBuscarFechas.Checked;

            int idEmpleado = 0;
            DateTime fechaDesde = fechaInicio.Value.Date;
            DateTime fechaHasta = fechaFinal.Value.Date;


            if (buscarPorEmpleado)
            {
                if (!guardarIdEmpleado(out idEmpleado))
                {
                    MessageBox.Show("Por favor, seleccione un empleado antes de buscar.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            List<Asignacion> asignaciones = new List<Asignacion>();

            if (buscarPorEmpleado && buscarPorFechas)
            {
                asignaciones = datosAsignaciones.buscarAsignacionPorIdYFechas(idEmpleado, fechaDesde, fechaHasta);
            }
            else if (buscarPorEmpleado)
            {
                asignaciones = datosAsignaciones.buscarAsignacionPorId(idEmpleado);
            }
            else if (buscarPorFechas)
            {
                asignaciones = datosAsignaciones.buscarAsignacionPorFechas(fechaDesde, fechaHasta);
            }
            else
            {
                MessageBox.Show("Seleccione al menos un criterio de busqueda (empleado o fechas).", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (asignaciones.Count > 0)
            {
                dvAsignacionesMostrar.DataSource = asignaciones;
            }
            else
            {
                MessageBox.Show("No se encontraron asignaciones según los criterios seleccionados.",
                                "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dvAsignacionesMostrar.DataSource = null;
                if (!asignacionesInactivas) { cargarDatagird(); }
                else { ActualizarInterfazInactivos(); }
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            if (!asignacionesInactivas) { cargarDatagird(); }
            else { ActualizarInterfazInactivos(); }
            chbNombreEmpleBusc.Checked = false;
            fechaInicio.Value = fechaPredeterminada;
            fechaFinal.Value = fechaPredeterminada;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            if (!asignacionesInactivas) { cargarDatagird(); }
            else { ActualizarInterfazInactivos(); }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de que desea cancelar la edicion?",
                "Confirmar Cancelacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                dvDatosEmpleadoSel.Rows.Clear();
                dvHerramientaSel.Rows.Clear();
            }
        }

        private void btnConfirmarEdit_Click(object sender, EventArgs e)
        {
            if (dvAsignacionesMostrar.SelectedRows.Count > 0)
            {
                Asignacion asignacionSeleccionada = (Asignacion)dvAsignacionesMostrar.SelectedRows[0].DataBoundItem;
                int idAsignac = asignacionSeleccionada.idAsignacion;

                Asignacion asignacionActualizada = new Asignacion
                {
                    idAsignacion = idAsignac,
                    id_herramienta = (int)dvHerramientaSel.Rows[0].Cells["idHerramienta"].Value,
                    id_empleado = (int)dvDatosEmpleadoSel.Rows[0].Cells["idEmpleado"].Value,
                    fechaAsignacion = dtfechaAsignacion.Value,
                    fechaDevolucion = dtfechaDevolucion.Value,
                    activo = chbActivo.Checked
                };

                DialogResult resultadoDialogo = MessageBox.Show("¿Desea confirmar la edicion de la asignacion?",
                         "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoDialogo == DialogResult.Yes)
                {

                    DatosAsignaciones datosAsignaciones = new DatosAsignaciones();
                    string resultado = datosAsignaciones.actualizarAsignacion(asignacionActualizada, this, asignacionesInactivas);

                    if (resultado != "Actualizacion exitosa")
                    {
                        MessageBox.Show("Ocurrio un error al actualizar la asignacion.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay una asignacion seleccionada.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            confirmarLimpiarDatos();
        }

        private void confirmarLimpiarDatos()
        {
            dvDatosEmpleadoSel.Rows.Clear();
            dvHerramientaSel.Rows.Clear();
            chbActivo.Visible = false;

            dtfechaAsignacion.Value = fechaPredeterminada;
            dtfechaDevolucion.Value = fechaPredeterminada;
        }

        public void ActualizarInterfaz()
        {
            dvAsignacionesMostrar.DataSource = new DatosAsignaciones().listarAsignaciones();
            btnConfirmarEdit.Enabled = false;
        }

        public void ActualizarInterfazInactivos()
        {
            dvAsignacionesMostrar.DataSource = new DatosAsignaciones().listarAsignacionesInactivas();
            btnConfirmarEdit.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dvDatosEmpleadoSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvHerramientaSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtfechaDevolucion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtfechaAsignacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbNoHerraDisponibl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dvAsignacionesMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvAsignacionesMostrar.Rows[e.RowIndex];

                asignacionElegida = new Asignacion
                {
                    idAsignacion = (int)row.Cells["idAsignacion"].Value,
                    id_herramienta = (int)row.Cells["id_herramienta"].Value,
                    id_empleado = (int)row.Cells["id_empleado"].Value,
                    fechaAsignacion = (DateTime)row.Cells["fechaAsignacion"].Value,
                    fechaDevolucion = (DateTime)row.Cells["fechaDevolucion"].Value,
                    activo = Convert.ToBoolean(row.Cells["activo"].Value)
                };
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (!chEliminar.Checked)
            {
                MessageBox.Show("Debe seleccionar el CheckBox 'Eliminar' para confirmar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach(DataGridViewRow row in dvAsignacionesMostrar.SelectedRows)
            {
                int id = (int)row.Cells["idAsignacion"].Value;
                int id_herramienta = (int)row.Cells["id_herramienta"].Value;
                eliminarAsignacion(id, id_herramienta);
            }
        }

        private void eliminarAsignacion(int id, int id_herramienta)
        {
            MySqlConnection SQLDatos = Conexion.GetConexion().crearConexion();
            try
            {
                if(SQLDatos.State == ConnectionState.Closed)
                {
                    SQLDatos.Open();
                }

                MySqlCommand cmd = new MySqlCommand("asp_eliminar_asignacion", SQLDatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("_idAsignacion", id);
                cmd.Parameters.AddWithValue("_id_herramienta", id_herramienta);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Funciones.Logs("eliminarAsignacion", ex.ToString());
                MessageBox.Show("Error al eliminar la asignacion: " + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if(SQLDatos.State == ConnectionState.Open)
                {
                    SQLDatos.Close();
                }
            }
        }

        private void chInactivoMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chInactivoMostrar.Checked)
            {
                tablaAsignacionesInactivas();
            }
            else
            {
                cargarDatagird();
                asignacionesInactivas = false;
            }
        }

        private void tablaAsignacionesInactivas()
        {
            DatosAsignaciones datos = new DatosAsignaciones();
            dvAsignacionesMostrar.DataSource = datos.listarAsignacionesInactivas();

            dvAsignacionesMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dvAsignacionesMostrar.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            // esto importantisimo hace que las celdas no sean editables
            dvAsignacionesMostrar.ReadOnly = true;
            dvAsignacionesMostrar.AllowUserToResizeRows = false;
            dvAsignacionesMostrar.RowHeadersVisible = false;

            asignacionesInactivas = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
