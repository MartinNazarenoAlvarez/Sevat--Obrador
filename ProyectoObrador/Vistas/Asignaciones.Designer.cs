namespace ProyectoObrador.Vistas
{
    partial class Asignaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.lbNoHerraDisponibl = new System.Windows.Forms.Label();
            this.btnCancelarEdit = new System.Windows.Forms.Button();
            this.btnConfirmarEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarAsignacio = new System.Windows.Forms.Button();
            this.dvDatosEmpleadoSel = new System.Windows.Forms.DataGridView();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvHerramientaSel = new System.Windows.Forms.DataGridView();
            this.IdHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.dtfechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtfechaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chInactivoMostrar = new System.Windows.Forms.CheckBox();
            this.chEliminar = new System.Windows.Forms.CheckBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.chbNombreEmpleBusc = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNombreEmplSel = new System.Windows.Forms.Label();
            this.btBuscarNombre = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dvAsignacionesMostrar = new System.Windows.Forms.DataGridView();
            this.lbAsignacionHerramientaA = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.chbBuscarFechas = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDatosEmpleadoSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvHerramientaSel)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAsignacionesMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox1.Controls.Add(this.chbActivo);
            this.groupBox1.Controls.Add(this.lbNoHerraDisponibl);
            this.groupBox1.Controls.Add(this.btnCancelarEdit);
            this.groupBox1.Controls.Add(this.btnConfirmarEdit);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnEditEmpleado);
            this.groupBox1.Controls.Add(this.btnAgregarAsignacio);
            this.groupBox1.Controls.Add(this.dvDatosEmpleadoSel);
            this.groupBox1.Controls.Add(this.dvHerramientaSel);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.dtfechaDevolucion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtfechaAsignacion);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 597);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Enabled = false;
            this.chbActivo.Location = new System.Drawing.Point(505, 140);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(71, 24);
            this.chbActivo.TabIndex = 79;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            this.chbActivo.Visible = false;
            // 
            // lbNoHerraDisponibl
            // 
            this.lbNoHerraDisponibl.AutoSize = true;
            this.lbNoHerraDisponibl.Location = new System.Drawing.Point(501, 169);
            this.lbNoHerraDisponibl.Name = "lbNoHerraDisponibl";
            this.lbNoHerraDisponibl.Size = new System.Drawing.Size(51, 20);
            this.lbNoHerraDisponibl.TabIndex = 78;
            this.lbNoHerraDisponibl.Text = "label2";
            this.lbNoHerraDisponibl.Click += new System.EventHandler(this.lbNoHerraDisponibl_Click);
            // 
            // btnCancelarEdit
            // 
            this.btnCancelarEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancelarEdit.Enabled = false;
            this.btnCancelarEdit.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCancelarEdit.Location = new System.Drawing.Point(909, 115);
            this.btnCancelarEdit.Name = "btnCancelarEdit";
            this.btnCancelarEdit.Size = new System.Drawing.Size(97, 39);
            this.btnCancelarEdit.TabIndex = 77;
            this.btnCancelarEdit.Text = "Cancelar";
            this.btnCancelarEdit.UseVisualStyleBackColor = false;
            this.btnCancelarEdit.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnConfirmarEdit
            // 
            this.btnConfirmarEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnConfirmarEdit.Enabled = false;
            this.btnConfirmarEdit.ForeColor = System.Drawing.Color.DarkGray;
            this.btnConfirmarEdit.Location = new System.Drawing.Point(909, 72);
            this.btnConfirmarEdit.Name = "btnConfirmarEdit";
            this.btnConfirmarEdit.Size = new System.Drawing.Size(97, 39);
            this.btnConfirmarEdit.TabIndex = 76;
            this.btnConfirmarEdit.Text = "Confirmar";
            this.btnConfirmarEdit.UseVisualStyleBackColor = false;
            this.btnConfirmarEdit.Click += new System.EventHandler(this.btnConfirmarEdit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button3.ForeColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(797, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 39);
            this.button3.TabIndex = 75;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditEmpleado
            // 
            this.btnEditEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnEditEmpleado.ForeColor = System.Drawing.Color.DarkGray;
            this.btnEditEmpleado.Location = new System.Drawing.Point(797, 72);
            this.btnEditEmpleado.Name = "btnEditEmpleado";
            this.btnEditEmpleado.Size = new System.Drawing.Size(102, 79);
            this.btnEditEmpleado.TabIndex = 74;
            this.btnEditEmpleado.Text = "Editar";
            this.btnEditEmpleado.UseVisualStyleBackColor = false;
            this.btnEditEmpleado.Click += new System.EventHandler(this.btnEditEmpleado_Click);
            // 
            // btnAgregarAsignacio
            // 
            this.btnAgregarAsignacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAgregarAsignacio.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAgregarAsignacio.Location = new System.Drawing.Point(797, 27);
            this.btnAgregarAsignacio.Name = "btnAgregarAsignacio";
            this.btnAgregarAsignacio.Size = new System.Drawing.Size(209, 39);
            this.btnAgregarAsignacio.TabIndex = 73;
            this.btnAgregarAsignacio.Text = "Agregar";
            this.btnAgregarAsignacio.UseVisualStyleBackColor = false;
            this.btnAgregarAsignacio.Click += new System.EventHandler(this.btnAgregarAsignacio_Click);
            // 
            // dvDatosEmpleadoSel
            // 
            this.dvDatosEmpleadoSel.AllowUserToAddRows = false;
            this.dvDatosEmpleadoSel.AllowUserToDeleteRows = false;
            this.dvDatosEmpleadoSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDatosEmpleadoSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.DNI,
            this.Nombre});
            this.dvDatosEmpleadoSel.Location = new System.Drawing.Point(16, 50);
            this.dvDatosEmpleadoSel.Name = "dvDatosEmpleadoSel";
            this.dvDatosEmpleadoSel.ReadOnly = true;
            this.dvDatosEmpleadoSel.Size = new System.Drawing.Size(353, 69);
            this.dvDatosEmpleadoSel.TabIndex = 72;
            this.dvDatosEmpleadoSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvDatosEmpleadoSel_CellContentClick);
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "IdEmpleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // dvHerramientaSel
            // 
            this.dvHerramientaSel.AllowUserToAddRows = false;
            this.dvHerramientaSel.AllowUserToDeleteRows = false;
            this.dvHerramientaSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvHerramientaSel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHerramienta,
            this.Serial,
            this.Modelo});
            this.dvHerramientaSel.Location = new System.Drawing.Point(16, 140);
            this.dvHerramientaSel.Name = "dvHerramientaSel";
            this.dvHerramientaSel.ReadOnly = true;
            this.dvHerramientaSel.Size = new System.Drawing.Size(353, 72);
            this.dvHerramientaSel.TabIndex = 71;
            this.dvHerramientaSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvHerramientaSel_CellContentClick);
            // 
            // IdHerramienta
            // 
            this.IdHerramienta.HeaderText = "IdHerramienta";
            this.IdHerramienta.Name = "IdHerramienta";
            this.IdHerramienta.ReadOnly = true;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Serial";
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button4.Enabled = false;
            this.button4.ForeColor = System.Drawing.Color.DarkGray;
            this.button4.Location = new System.Drawing.Point(375, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 59);
            this.button4.TabIndex = 70;
            this.button4.Text = "buscar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtfechaDevolucion
            // 
            this.dtfechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaDevolucion.Location = new System.Drawing.Point(666, 97);
            this.dtfechaDevolucion.Name = "dtfechaDevolucion";
            this.dtfechaDevolucion.Size = new System.Drawing.Size(118, 26);
            this.dtfechaDevolucion.TabIndex = 63;
            this.dtfechaDevolucion.ValueChanged += new System.EventHandler(this.dtfechaDevolucion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Fecha de devolucion:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Herramienta";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtfechaAsignacion
            // 
            this.dtfechaAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaAsignacion.Location = new System.Drawing.Point(666, 46);
            this.dtfechaAsignacion.Name = "dtfechaAsignacion";
            this.dtfechaAsignacion.Size = new System.Drawing.Size(118, 26);
            this.dtfechaAsignacion.TabIndex = 57;
            this.dtfechaAsignacion.ValueChanged += new System.EventHandler(this.dtfechaAsignacion_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chInactivoMostrar);
            this.groupBox2.Controls.Add(this.chEliminar);
            this.groupBox2.Controls.Add(this.btEliminar);
            this.groupBox2.Controls.Add(this.btnMinimizar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnLimpiarBusqueda);
            this.groupBox2.Controls.Add(this.chbNombreEmpleBusc);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btBuscarNombre);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dvAsignacionesMostrar);
            this.groupBox2.Controls.Add(this.lbAsignacionHerramientaA);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.fechaInicio);
            this.groupBox2.Controls.Add(this.fechaFinal);
            this.groupBox2.Controls.Add(this.chbBuscarFechas);
            this.groupBox2.Location = new System.Drawing.Point(6, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 376);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // chInactivoMostrar
            // 
            this.chInactivoMostrar.AutoSize = true;
            this.chInactivoMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chInactivoMostrar.Location = new System.Drawing.Point(138, 76);
            this.chInactivoMostrar.Name = "chInactivoMostrar";
            this.chInactivoMostrar.Size = new System.Drawing.Size(118, 19);
            this.chInactivoMostrar.TabIndex = 84;
            this.chInactivoMostrar.Text = "Mostrar Inactivos";
            this.chInactivoMostrar.UseVisualStyleBackColor = true;
            this.chInactivoMostrar.CheckedChanged += new System.EventHandler(this.chInactivoMostrar_CheckedChanged);
            // 
            // chEliminar
            // 
            this.chEliminar.AutoSize = true;
            this.chEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chEliminar.Location = new System.Drawing.Point(275, 75);
            this.chEliminar.Name = "chEliminar";
            this.chEliminar.Size = new System.Drawing.Size(74, 20);
            this.chEliminar.TabIndex = 83;
            this.chEliminar.Text = "Eliminar";
            this.chEliminar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btEliminar.ForeColor = System.Drawing.Color.DarkGray;
            this.btEliminar.Location = new System.Drawing.Point(712, 19);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(146, 34);
            this.btEliminar.TabIndex = 82;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::ProyectoObrador.Properties.Resources.recarga;
            this.btnMinimizar.Location = new System.Drawing.Point(100, 77);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 79;
            this.label2.Text = "Recargar tabla";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(712, 57);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(146, 34);
            this.btnLimpiarBusqueda.TabIndex = 81;
            this.btnLimpiarBusqueda.Text = "Limpiar Busqueda";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // chbNombreEmpleBusc
            // 
            this.chbNombreEmpleBusc.AutoSize = true;
            this.chbNombreEmpleBusc.Location = new System.Drawing.Point(10, 19);
            this.chbNombreEmpleBusc.Name = "chbNombreEmpleBusc";
            this.chbNombreEmpleBusc.Size = new System.Drawing.Size(259, 24);
            this.chbNombreEmpleBusc.TabIndex = 80;
            this.chbNombreEmpleBusc.Text = "Buscar por nombre de empleado";
            this.chbNombreEmpleBusc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNombreEmplSel);
            this.panel1.Location = new System.Drawing.Point(205, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 24);
            this.panel1.TabIndex = 79;
            // 
            // lbNombreEmplSel
            // 
            this.lbNombreEmplSel.AutoSize = true;
            this.lbNombreEmplSel.Location = new System.Drawing.Point(3, 1);
            this.lbNombreEmplSel.Name = "lbNombreEmplSel";
            this.lbNombreEmplSel.Size = new System.Drawing.Size(101, 20);
            this.lbNombreEmplSel.TabIndex = 0;
            this.lbNombreEmplSel.Text = ".......................";
            this.lbNombreEmplSel.Visible = false;
            // 
            // btBuscarNombre
            // 
            this.btBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btBuscarNombre.Enabled = false;
            this.btBuscarNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.btBuscarNombre.Location = new System.Drawing.Point(275, 16);
            this.btBuscarNombre.Name = "btBuscarNombre";
            this.btBuscarNombre.Size = new System.Drawing.Size(88, 30);
            this.btBuscarNombre.TabIndex = 78;
            this.btBuscarNombre.Text = "buscar";
            this.btBuscarNombre.UseVisualStyleBackColor = false;
            this.btBuscarNombre.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(881, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 70);
            this.button2.TabIndex = 52;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dvAsignacionesMostrar
            // 
            this.dvAsignacionesMostrar.AllowUserToAddRows = false;
            this.dvAsignacionesMostrar.AllowUserToDeleteRows = false;
            this.dvAsignacionesMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAsignacionesMostrar.Location = new System.Drawing.Point(7, 95);
            this.dvAsignacionesMostrar.Name = "dvAsignacionesMostrar";
            this.dvAsignacionesMostrar.ReadOnly = true;
            this.dvAsignacionesMostrar.Size = new System.Drawing.Size(1001, 265);
            this.dvAsignacionesMostrar.TabIndex = 51;
            this.dvAsignacionesMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvAsignacionesMostrar_CellContentClick);
            // 
            // lbAsignacionHerramientaA
            // 
            this.lbAsignacionHerramientaA.AutoSize = true;
            this.lbAsignacionHerramientaA.ForeColor = System.Drawing.Color.DarkGray;
            this.lbAsignacionHerramientaA.Location = new System.Drawing.Point(6, 48);
            this.lbAsignacionHerramientaA.Name = "lbAsignacionHerramientaA";
            this.lbAsignacionHerramientaA.Size = new System.Drawing.Size(209, 20);
            this.lbAsignacionHerramientaA.TabIndex = 43;
            this.lbAsignacionHerramientaA.Text = "Herramientas Asignadas a:  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Entre";
            // 
            // fechaInicio
            // 
            this.fechaInicio.Enabled = false;
            this.fechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(389, 69);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(110, 24);
            this.fechaInicio.TabIndex = 48;
            // 
            // fechaFinal
            // 
            this.fechaFinal.Enabled = false;
            this.fechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinal.Location = new System.Drawing.Point(531, 69);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(109, 24);
            this.fechaFinal.TabIndex = 49;
            // 
            // chbBuscarFechas
            // 
            this.chbBuscarFechas.AutoSize = true;
            this.chbBuscarFechas.Location = new System.Drawing.Point(389, 19);
            this.chbBuscarFechas.Name = "chbBuscarFechas";
            this.chbBuscarFechas.Size = new System.Drawing.Size(157, 24);
            this.chbBuscarFechas.TabIndex = 46;
            this.chbBuscarFechas.Text = "Buscar por fechas";
            this.chbBuscarFechas.UseVisualStyleBackColor = true;
            this.chbBuscarFechas.CheckedChanged += new System.EventHandler(this.chbBuscarFechas_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(375, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha de asignacion: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Empleado";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Asignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1050, 621);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asignaciones";
            this.Text = "Asignaciones";
            this.Load += new System.EventHandler(this.Asignaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDatosEmpleadoSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvHerramientaSel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAsignacionesMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtfechaDevolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtfechaAsignacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dvAsignacionesMostrar;
        private System.Windows.Forms.Label lbAsignacionHerramientaA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.CheckBox chbBuscarFechas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvHerramientaSel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dvDatosEmpleadoSel;
        private System.Windows.Forms.Button btnCancelarEdit;
        private System.Windows.Forms.Button btnConfirmarEdit;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnEditEmpleado;
        private System.Windows.Forms.Button btnAgregarAsignacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHerramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNombreEmplSel;
        private System.Windows.Forms.Button btBuscarNombre;
        private System.Windows.Forms.CheckBox chbNombreEmpleBusc;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.Label lbNoHerraDisponibl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.CheckBox chEliminar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.CheckBox chInactivoMostrar;
    }
}