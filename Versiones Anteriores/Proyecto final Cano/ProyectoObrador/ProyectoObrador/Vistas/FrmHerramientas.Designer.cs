namespace ProyectoObrador.Vistas
{
    partial class FrmHerramientas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBorrarBusquedaHerramienta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chbHerraInact = new System.Windows.Forms.CheckBox();
            this.cmbBusquedaHerramienta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chbEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarHerramienta = new System.Windows.Forms.Button();
            this.txtBusquedaHerramienta = new System.Windows.Forms.TextBox();
            this.lbInactivoHerramienta = new System.Windows.Forms.Label();
            this.lbActivoHerramienta = new System.Windows.Forms.Label();
            this.lbTotalHerramienta = new System.Windows.Forms.Label();
            this.dgvDescripcion = new System.Windows.Forms.DataGridView();
            this.dgvHerramientas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarHerra = new System.Windows.Forms.Button();
            this.chbActivoHerra = new System.Windows.Forms.CheckBox();
            this.lbActivoHerra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCaracteresRestantes = new System.Windows.Forms.Label();
            this.btnSerie = new System.Windows.Forms.Label();
            this.txtNSerieH = new System.Windows.Forms.TextBox();
            this.cmbEstadoH = new System.Windows.Forms.ComboBox();
            this.btnConfirmarEditHerra = new System.Windows.Forms.Button();
            this.btnSalirH = new System.Windows.Forms.Button();
            this.btnEditEmpleado = new System.Windows.Forms.Button();
            this.btnEstadoH = new System.Windows.Forms.Label();
            this.btnMarcaH = new System.Windows.Forms.Label();
            this.btnGuardarH = new System.Windows.Forms.Button();
            this.btnNombreH = new System.Windows.Forms.Label();
            this.txtModeloH = new System.Windows.Forms.TextBox();
            this.btnDescripcionH = new System.Windows.Forms.Label();
            this.txtDescripcionH = new System.Windows.Forms.TextBox();
            this.btnModeloH = new System.Windows.Forms.Label();
            this.txtNombreH = new System.Windows.Forms.TextBox();
            this.txtMarcaH = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(29, 247);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(997, 358);
            this.tabControl2.TabIndex = 49;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.btnBorrarBusquedaHerramienta);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.chbHerraInact);
            this.tabPage3.Controls.Add(this.cmbBusquedaHerramienta);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.chbEliminar);
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.btnBuscarHerramienta);
            this.tabPage3.Controls.Add(this.txtBusquedaHerramienta);
            this.tabPage3.Controls.Add(this.lbInactivoHerramienta);
            this.tabPage3.Controls.Add(this.lbActivoHerramienta);
            this.tabPage3.Controls.Add(this.lbTotalHerramienta);
            this.tabPage3.Controls.Add(this.dgvDescripcion);
            this.tabPage3.Controls.Add(this.dgvHerramientas);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(989, 325);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Listado de Herramientas";
           //this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnBorrarBusquedaHerramienta
            // 
            this.btnBorrarBusquedaHerramienta.Location = new System.Drawing.Point(361, 12);
            this.btnBorrarBusquedaHerramienta.Name = "btnBorrarBusquedaHerramienta";
            this.btnBorrarBusquedaHerramienta.Size = new System.Drawing.Size(26, 29);
            this.btnBorrarBusquedaHerramienta.TabIndex = 69;
            this.btnBorrarBusquedaHerramienta.Text = "X";
            this.btnBorrarBusquedaHerramienta.UseVisualStyleBackColor = true;
            this.btnBorrarBusquedaHerramienta.Click += new System.EventHandler(this.btnBorrarBusquedaHerramienta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Herramientas inactivas";
            // 
            // chbHerraInact
            // 
            this.chbHerraInact.AutoSize = true;
            this.chbHerraInact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHerraInact.Location = new System.Drawing.Point(711, 36);
            this.chbHerraInact.Name = "chbHerraInact";
            this.chbHerraInact.Size = new System.Drawing.Size(15, 14);
            this.chbHerraInact.TabIndex = 67;
            this.chbHerraInact.UseVisualStyleBackColor = true;
            this.chbHerraInact.CheckedChanged += new System.EventHandler(this.chbHerraInact_CheckedChanged);
            // 
            // cmbBusquedaHerramienta
            // 
            this.cmbBusquedaHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusquedaHerramienta.FormattingEnabled = true;
            this.cmbBusquedaHerramienta.Items.AddRange(new object[] {
            "ID",
            "Numero de serie",
            "Marca"});
            this.cmbBusquedaHerramienta.Location = new System.Drawing.Point(11, 11);
            this.cmbBusquedaHerramienta.Name = "cmbBusquedaHerramienta";
            this.cmbBusquedaHerramienta.Size = new System.Drawing.Size(174, 32);
            this.cmbBusquedaHerramienta.TabIndex = 66;
            this.cmbBusquedaHerramienta.SelectedIndexChanged += new System.EventHandler(this.cmbBusquedaHerramienta_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(195, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 28);
            this.button1.TabIndex = 65;
            this.button1.Text = "Limpiar Busqueda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.BackColor = System.Drawing.Color.Transparent;
            this.chbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEliminar.ForeColor = System.Drawing.Color.Black;
            this.chbEliminar.Location = new System.Drawing.Point(11, 46);
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Size = new System.Drawing.Size(97, 28);
            this.chbEliminar.TabIndex = 64;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(388, 43);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 30);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscarHerramienta
            // 
            this.btnBuscarHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHerramienta.Location = new System.Drawing.Point(388, 11);
            this.btnBuscarHerramienta.Name = "btnBuscarHerramienta";
            this.btnBuscarHerramienta.Size = new System.Drawing.Size(113, 30);
            this.btnBuscarHerramienta.TabIndex = 62;
            this.btnBuscarHerramienta.Text = "Buscar";
            this.btnBuscarHerramienta.UseVisualStyleBackColor = true;
            this.btnBuscarHerramienta.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtBusquedaHerramienta
            // 
            this.txtBusquedaHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaHerramienta.Location = new System.Drawing.Point(191, 11);
            this.txtBusquedaHerramienta.Name = "txtBusquedaHerramienta";
            this.txtBusquedaHerramienta.Size = new System.Drawing.Size(164, 29);
            this.txtBusquedaHerramienta.TabIndex = 61;
            this.txtBusquedaHerramienta.TextChanged += new System.EventHandler(this.txtBusquedaHerramienta_TextChanged);
            // 
            // lbInactivoHerramienta
            // 
            this.lbInactivoHerramienta.AutoSize = true;
            this.lbInactivoHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInactivoHerramienta.Location = new System.Drawing.Point(851, 36);
            this.lbInactivoHerramienta.Name = "lbInactivoHerramienta";
            this.lbInactivoHerramienta.Size = new System.Drawing.Size(92, 24);
            this.lbInactivoHerramienta.TabIndex = 60;
            this.lbInactivoHerramienta.Text = "Inactivos: ";
            // 
            // lbActivoHerramienta
            // 
            this.lbActivoHerramienta.AutoSize = true;
            this.lbActivoHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivoHerramienta.Location = new System.Drawing.Point(751, 36);
            this.lbActivoHerramienta.Name = "lbActivoHerramienta";
            this.lbActivoHerramienta.Size = new System.Drawing.Size(75, 24);
            this.lbActivoHerramienta.TabIndex = 59;
            this.lbActivoHerramienta.Text = "Activos:";
            // 
            // lbTotalHerramienta
            // 
            this.lbTotalHerramienta.AutoSize = true;
            this.lbTotalHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalHerramienta.ForeColor = System.Drawing.Color.Black;
            this.lbTotalHerramienta.Location = new System.Drawing.Point(728, 11);
            this.lbTotalHerramienta.Name = "lbTotalHerramienta";
            this.lbTotalHerramienta.Size = new System.Drawing.Size(242, 24);
            this.lbTotalHerramienta.TabIndex = 58;
            this.lbTotalHerramienta.Text = "Herramientas en el sistema:";
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.AllowUserToAddRows = false;
            this.dgvDescripcion.AllowUserToDeleteRows = false;
            this.dgvDescripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescripcion.Location = new System.Drawing.Point(832, 84);
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            this.dgvDescripcion.Size = new System.Drawing.Size(151, 232);
            this.dgvDescripcion.TabIndex = 51;
            // 
            // dgvHerramientas
            // 
            this.dgvHerramientas.AllowUserToAddRows = false;
            this.dgvHerramientas.AllowUserToDeleteRows = false;
            this.dgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerramientas.Location = new System.Drawing.Point(6, 84);
            this.dgvHerramientas.Name = "dgvHerramientas";
            this.dgvHerramientas.ReadOnly = true;
            this.dgvHerramientas.Size = new System.Drawing.Size(820, 232);
            this.dgvHerramientas.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnCancelarHerra);
            this.groupBox1.Controls.Add(this.chbActivoHerra);
            this.groupBox1.Controls.Add(this.lbActivoHerra);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblCaracteresRestantes);
            this.groupBox1.Controls.Add(this.btnSerie);
            this.groupBox1.Controls.Add(this.txtNSerieH);
            this.groupBox1.Controls.Add(this.cmbEstadoH);
            this.groupBox1.Controls.Add(this.btnConfirmarEditHerra);
            this.groupBox1.Controls.Add(this.btnSalirH);
            this.groupBox1.Controls.Add(this.btnEditEmpleado);
            this.groupBox1.Controls.Add(this.btnEstadoH);
            this.groupBox1.Controls.Add(this.btnMarcaH);
            this.groupBox1.Controls.Add(this.btnGuardarH);
            this.groupBox1.Controls.Add(this.btnNombreH);
            this.groupBox1.Controls.Add(this.txtModeloH);
            this.groupBox1.Controls.Add(this.btnDescripcionH);
            this.groupBox1.Controls.Add(this.txtDescripcionH);
            this.groupBox1.Controls.Add(this.btnModeloH);
            this.groupBox1.Controls.Add(this.txtNombreH);
            this.groupBox1.Controls.Add(this.txtMarcaH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 211);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Herramientas";
            // 
            // btnCancelarHerra
            // 
            this.btnCancelarHerra.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarHerra.Enabled = false;
            this.btnCancelarHerra.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarHerra.Location = new System.Drawing.Point(877, 115);
            this.btnCancelarHerra.Name = "btnCancelarHerra";
            this.btnCancelarHerra.Size = new System.Drawing.Size(97, 39);
            this.btnCancelarHerra.TabIndex = 57;
            this.btnCancelarHerra.Text = "Cancelar";
            this.btnCancelarHerra.UseVisualStyleBackColor = false;
            this.btnCancelarHerra.Click += new System.EventHandler(this.btnCancelarHerra_Click);
            // 
            // chbActivoHerra
            // 
            this.chbActivoHerra.AutoSize = true;
            this.chbActivoHerra.Location = new System.Drawing.Point(642, 26);
            this.chbActivoHerra.Name = "chbActivoHerra";
            this.chbActivoHerra.Size = new System.Drawing.Size(15, 14);
            this.chbActivoHerra.TabIndex = 56;
            this.chbActivoHerra.UseVisualStyleBackColor = true;
            this.chbActivoHerra.Visible = false;
            // 
            // lbActivoHerra
            // 
            this.lbActivoHerra.AutoSize = true;
            this.lbActivoHerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivoHerra.Location = new System.Drawing.Point(586, 22);
            this.lbActivoHerra.Name = "lbActivoHerra";
            this.lbActivoHerra.Size = new System.Drawing.Size(52, 20);
            this.lbActivoHerra.TabIndex = 55;
            this.lbActivoHerra.Text = "Activo";
            this.lbActivoHerra.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoObrador.Properties.Resources.herramineta;
            this.pictureBox1.Location = new System.Drawing.Point(11, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // lblCaracteresRestantes
            // 
            this.lblCaracteresRestantes.AutoSize = true;
            this.lblCaracteresRestantes.ForeColor = System.Drawing.Color.LightGray;
            this.lblCaracteresRestantes.Location = new System.Drawing.Point(686, 22);
            this.lblCaracteresRestantes.Name = "lblCaracteresRestantes";
            this.lblCaracteresRestantes.Size = new System.Drawing.Size(51, 20);
            this.lblCaracteresRestantes.TabIndex = 53;
            this.lblCaracteresRestantes.Text = "label1";
            // 
            // btnSerie
            // 
            this.btnSerie.AutoSize = true;
            this.btnSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerie.Location = new System.Drawing.Point(477, 170);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(148, 20);
            this.btnSerie.TabIndex = 51;
            this.btnSerie.Text = "Numero de Serie (*)";
            // 
            // txtNSerieH
            // 
            this.txtNSerieH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSerieH.Location = new System.Drawing.Point(631, 167);
            this.txtNSerieH.Name = "txtNSerieH";
            this.txtNSerieH.Size = new System.Drawing.Size(117, 26);
            this.txtNSerieH.TabIndex = 52;
            // 
            // cmbEstadoH
            // 
            this.cmbEstadoH.FormattingEnabled = true;
            this.cmbEstadoH.Items.AddRange(new object[] {
            "Nuevo",
            "Casi nuevo",
            "Algo desgastado",
            "Bastante desgastado",
            "Deplorable"});
            this.cmbEstadoH.Location = new System.Drawing.Point(293, 167);
            this.cmbEstadoH.Name = "cmbEstadoH";
            this.cmbEstadoH.Size = new System.Drawing.Size(166, 28);
            this.cmbEstadoH.TabIndex = 50;
            // 
            // btnConfirmarEditHerra
            // 
            this.btnConfirmarEditHerra.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarEditHerra.Enabled = false;
            this.btnConfirmarEditHerra.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarEditHerra.Location = new System.Drawing.Point(877, 76);
            this.btnConfirmarEditHerra.Name = "btnConfirmarEditHerra";
            this.btnConfirmarEditHerra.Size = new System.Drawing.Size(97, 39);
            this.btnConfirmarEditHerra.TabIndex = 49;
            this.btnConfirmarEditHerra.Text = "Confirmar";
            this.btnConfirmarEditHerra.UseVisualStyleBackColor = false;
            this.btnConfirmarEditHerra.Click += new System.EventHandler(this.btnConfirmarEditHerra_Click);
            // 
            // btnSalirH
            // 
            this.btnSalirH.ForeColor = System.Drawing.Color.Black;
            this.btnSalirH.Location = new System.Drawing.Point(769, 160);
            this.btnSalirH.Name = "btnSalirH";
            this.btnSalirH.Size = new System.Drawing.Size(209, 39);
            this.btnSalirH.TabIndex = 47;
            this.btnSalirH.Text = "Salir";
            this.btnSalirH.UseVisualStyleBackColor = true;
            this.btnSalirH.Click += new System.EventHandler(this.btnSalirH_Click);
            // 
            // btnEditEmpleado
            // 
            this.btnEditEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnEditEmpleado.Location = new System.Drawing.Point(769, 76);
            this.btnEditEmpleado.Name = "btnEditEmpleado";
            this.btnEditEmpleado.Size = new System.Drawing.Size(102, 78);
            this.btnEditEmpleado.TabIndex = 46;
            this.btnEditEmpleado.Text = "Editar";
            this.btnEditEmpleado.UseVisualStyleBackColor = true;
            this.btnEditEmpleado.Click += new System.EventHandler(this.btnEditEmpleado_Click);
            // 
            // btnEstadoH
            // 
            this.btnEstadoH.AutoSize = true;
            this.btnEstadoH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoH.Location = new System.Drawing.Point(195, 170);
            this.btnEstadoH.Name = "btnEstadoH";
            this.btnEstadoH.Size = new System.Drawing.Size(80, 20);
            this.btnEstadoH.TabIndex = 37;
            this.btnEstadoH.Text = "Estado (*)";
            // 
            // btnMarcaH
            // 
            this.btnMarcaH.AutoSize = true;
            this.btnMarcaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcaH.Location = new System.Drawing.Point(194, 72);
            this.btnMarcaH.Name = "btnMarcaH";
            this.btnMarcaH.Size = new System.Drawing.Size(73, 20);
            this.btnMarcaH.TabIndex = 35;
            this.btnMarcaH.Text = "Marca (*)";
            // 
            // btnGuardarH
            // 
            this.btnGuardarH.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarH.Location = new System.Drawing.Point(769, 31);
            this.btnGuardarH.Name = "btnGuardarH";
            this.btnGuardarH.Size = new System.Drawing.Size(209, 39);
            this.btnGuardarH.TabIndex = 45;
            this.btnGuardarH.Text = "Agregar";
            this.btnGuardarH.UseVisualStyleBackColor = true;
            this.btnGuardarH.Click += new System.EventHandler(this.btnGuardarH_Click);
            // 
            // btnNombreH
            // 
            this.btnNombreH.AutoSize = true;
            this.btnNombreH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombreH.Location = new System.Drawing.Point(194, 28);
            this.btnNombreH.Name = "btnNombreH";
            this.btnNombreH.Size = new System.Drawing.Size(85, 20);
            this.btnNombreH.TabIndex = 36;
            this.btnNombreH.Text = "Nombre (*)";
            // 
            // txtModeloH
            // 
            this.txtModeloH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloH.Location = new System.Drawing.Point(293, 119);
            this.txtModeloH.Name = "txtModeloH";
            this.txtModeloH.Size = new System.Drawing.Size(166, 26);
            this.txtModeloH.TabIndex = 44;
            // 
            // btnDescripcionH
            // 
            this.btnDescripcionH.AutoSize = true;
            this.btnDescripcionH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescripcionH.Location = new System.Drawing.Point(477, 22);
            this.btnDescripcionH.Name = "btnDescripcionH";
            this.btnDescripcionH.Size = new System.Drawing.Size(92, 20);
            this.btnDescripcionH.TabIndex = 38;
            this.btnDescripcionH.Text = "Descripcion";
            // 
            // txtDescripcionH
            // 
            this.txtDescripcionH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionH.Location = new System.Drawing.Point(481, 45);
            this.txtDescripcionH.Multiline = true;
            this.txtDescripcionH.Name = "txtDescripcionH";
            this.txtDescripcionH.Size = new System.Drawing.Size(267, 114);
            this.txtDescripcionH.TabIndex = 43;
            // 
            // btnModeloH
            // 
            this.btnModeloH.AutoSize = true;
            this.btnModeloH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeloH.Location = new System.Drawing.Point(194, 119);
            this.btnModeloH.Name = "btnModeloH";
            this.btnModeloH.Size = new System.Drawing.Size(81, 20);
            this.btnModeloH.TabIndex = 39;
            this.btnModeloH.Text = "Modelo (*)";
            // 
            // txtNombreH
            // 
            this.txtNombreH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreH.Location = new System.Drawing.Point(293, 25);
            this.txtNombreH.Name = "txtNombreH";
            this.txtNombreH.Size = new System.Drawing.Size(166, 26);
            this.txtNombreH.TabIndex = 42;
            // 
            // txtMarcaH
            // 
            this.txtMarcaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaH.Location = new System.Drawing.Point(293, 69);
            this.txtMarcaH.Name = "txtMarcaH";
            this.txtMarcaH.Size = new System.Drawing.Size(166, 26);
            this.txtMarcaH.TabIndex = 41;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1050, 621);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHerramientas";
            this.Text = "FrmHerramientas";
            this.Load += new System.EventHandler(this.FrmHerramientas_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvHerramientas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirmarEditHerra;
        private System.Windows.Forms.Button btnSalirH;
        public System.Windows.Forms.Button btnEditEmpleado;
        private System.Windows.Forms.Label btnEstadoH;
        private System.Windows.Forms.Label btnMarcaH;
        private System.Windows.Forms.Button btnGuardarH;
        private System.Windows.Forms.Label btnNombreH;
        private System.Windows.Forms.TextBox txtModeloH;
        private System.Windows.Forms.Label btnDescripcionH;
        private System.Windows.Forms.TextBox txtDescripcionH;
        private System.Windows.Forms.Label btnModeloH;
        private System.Windows.Forms.TextBox txtNombreH;
        private System.Windows.Forms.TextBox txtMarcaH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvDescripcion;
        private System.Windows.Forms.ComboBox cmbEstadoH;
        private System.Windows.Forms.Label btnSerie;
        private System.Windows.Forms.TextBox txtNSerieH;
        private System.Windows.Forms.Label lblCaracteresRestantes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chbActivoHerra;
        private System.Windows.Forms.Label lbActivoHerra;
        private System.Windows.Forms.Button btnCancelarHerra;
        private System.Windows.Forms.Label lbInactivoHerramienta;
        private System.Windows.Forms.Label lbActivoHerramienta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbHerraInact;
        private System.Windows.Forms.ComboBox cmbBusquedaHerramienta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarHerramienta;
        private System.Windows.Forms.TextBox txtBusquedaHerramienta;
        private System.Windows.Forms.Label lbTotalHerramienta;
        private System.Windows.Forms.Button btnBorrarBusquedaHerramienta;
    }
}