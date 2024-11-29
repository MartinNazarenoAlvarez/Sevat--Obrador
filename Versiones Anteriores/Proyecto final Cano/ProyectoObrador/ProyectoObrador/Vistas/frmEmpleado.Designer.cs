namespace ProyectoObrador.Vistas
{
    partial class frmEmpleado
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditEmpleado = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnConfirmarEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefonoLetra = new System.Windows.Forms.Label();
            this.lblDNILetra = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBorrarBusqueda = new System.Windows.Forms.Button();
            this.lbInactivoT = new System.Windows.Forms.Label();
            this.lbActivoT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbEmpInact = new System.Windows.Forms.CheckBox();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalEmpleado = new System.Windows.Forms.Label();
            this.chbEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(335, 96);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(140, 29);
            this.txtApellido.TabIndex = 41;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(595, 37);
            this.txtDNI.MaxLength = 10;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(138, 29);
            this.txtDNI.TabIndex = 40;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(335, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 29);
            this.txtNombre.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Telefono(*)";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(595, 99);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(140, 29);
            this.txtCargo.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Cargo  (*)";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(335, 166);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 29);
            this.txtTelefono.TabIndex = 44;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre (*)";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(754, 27);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(209, 39);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Apellido (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "DNI (*)";
            // 
            // btnEditEmpleado
            // 
            this.btnEditEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnEditEmpleado.Location = new System.Drawing.Point(754, 72);
            this.btnEditEmpleado.Name = "btnEditEmpleado";
            this.btnEditEmpleado.Size = new System.Drawing.Size(102, 79);
            this.btnEditEmpleado.TabIndex = 46;
            this.btnEditEmpleado.Text = "Editar";
            this.btnEditEmpleado.UseVisualStyleBackColor = true;
            this.btnEditEmpleado.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(754, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 39);
            this.button4.TabIndex = 47;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConfirmarEdit
            // 
            this.btnConfirmarEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarEdit.Enabled = false;
            this.btnConfirmarEdit.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarEdit.Location = new System.Drawing.Point(866, 72);
            this.btnConfirmarEdit.Name = "btnConfirmarEdit";
            this.btnConfirmarEdit.Size = new System.Drawing.Size(97, 39);
            this.btnConfirmarEdit.TabIndex = 49;
            this.btnConfirmarEdit.Text = "Confirmar";
            this.btnConfirmarEdit.UseVisualStyleBackColor = false;
            this.btnConfirmarEdit.Click += new System.EventHandler(this.btnConfirmarEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblTelefonoLetra);
            this.groupBox1.Controls.Add(this.lblDNILetra);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.chbActivo);
            this.groupBox1.Controls.Add(this.lblActivo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnConfirmarEdit);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnEditEmpleado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCargo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 211);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Empleados";
            // 
            // lblTelefonoLetra
            // 
            this.lblTelefonoLetra.AutoSize = true;
            this.lblTelefonoLetra.BackColor = System.Drawing.Color.DarkGray;
            this.lblTelefonoLetra.Location = new System.Drawing.Point(226, 143);
            this.lblTelefonoLetra.Name = "lblTelefonoLetra";
            this.lblTelefonoLetra.Size = new System.Drawing.Size(259, 20);
            this.lblTelefonoLetra.TabIndex = 55;
            this.lblTelefonoLetra.Text = "Solo se permiten ingresar numeros.";
            this.lblTelefonoLetra.Visible = false;
            // 
            // lblDNILetra
            // 
            this.lblDNILetra.AutoSize = true;
            this.lblDNILetra.BackColor = System.Drawing.Color.DarkGray;
            this.lblDNILetra.Location = new System.Drawing.Point(489, 16);
            this.lblDNILetra.Name = "lblDNILetra";
            this.lblDNILetra.Size = new System.Drawing.Size(259, 20);
            this.lblDNILetra.TabIndex = 54;
            this.lblDNILetra.Text = "Solo se permiten ingresar numeros.";
            this.lblDNILetra.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(866, 115);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 39);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Enabled = false;
            this.chbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbActivo.Location = new System.Drawing.Point(595, 166);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(15, 14);
            this.chbActivo.TabIndex = 52;
            this.chbActivo.UseVisualStyleBackColor = true;
            this.chbActivo.Visible = false;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Enabled = false;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(510, 160);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(61, 24);
            this.lblActivo.TabIndex = 51;
            this.lblActivo.Text = "Activo";
            this.lblActivo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoObrador.Properties.Resources.empleado;
            this.pictureBox1.Location = new System.Drawing.Point(29, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.btnBorrarBusqueda);
            this.tabPage3.Controls.Add(this.lbInactivoT);
            this.tabPage3.Controls.Add(this.lbActivoT);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.chbEmpInact);
            this.tabPage3.Controls.Add(this.cmbBusqueda);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.lblTotalEmpleado);
            this.tabPage3.Controls.Add(this.chbEliminar);
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.btnBuscarEmpleado);
            this.tabPage3.Controls.Add(this.txtBusqueda);
            this.tabPage3.Controls.Add(this.dgvEmpleados);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(989, 325);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Listado de Empleados";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnBorrarBusqueda
            // 
            this.btnBorrarBusqueda.Location = new System.Drawing.Point(299, 15);
            this.btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            this.btnBorrarBusqueda.Size = new System.Drawing.Size(26, 29);
            this.btnBorrarBusqueda.TabIndex = 58;
            this.btnBorrarBusqueda.Text = "X";
            this.btnBorrarBusqueda.UseVisualStyleBackColor = true;
            this.btnBorrarBusqueda.Click += new System.EventHandler(this.btnBorrarBusqueda_Click);
            // 
            // lbInactivoT
            // 
            this.lbInactivoT.AutoSize = true;
            this.lbInactivoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInactivoT.Location = new System.Drawing.Point(874, 53);
            this.lbInactivoT.Name = "lbInactivoT";
            this.lbInactivoT.Size = new System.Drawing.Size(92, 24);
            this.lbInactivoT.TabIndex = 57;
            this.lbInactivoT.Text = "Inactivos: ";
            // 
            // lbActivoT
            // 
            this.lbActivoT.AutoSize = true;
            this.lbActivoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActivoT.Location = new System.Drawing.Point(884, 33);
            this.lbActivoT.Name = "lbActivoT";
            this.lbActivoT.Size = new System.Drawing.Size(75, 24);
            this.lbActivoT.TabIndex = 56;
            this.lbActivoT.Text = "Activos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Mostrar empleados inactivos";
            // 
            // chbEmpInact
            // 
            this.chbEmpInact.AutoSize = true;
            this.chbEmpInact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEmpInact.Location = new System.Drawing.Point(712, 19);
            this.chbEmpInact.Name = "chbEmpInact";
            this.chbEmpInact.Size = new System.Drawing.Size(15, 14);
            this.chbEmpInact.TabIndex = 54;
            this.chbEmpInact.UseVisualStyleBackColor = true;
            this.chbEmpInact.CheckedChanged += new System.EventHandler(this.chbEmpInact_CheckedChanged);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "DNI",
            "ID",
            "Apellido"});
            this.cmbBusqueda.Location = new System.Drawing.Point(25, 15);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(89, 32);
            this.cmbBusqueda.TabIndex = 51;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBusqueda_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(133, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 28);
            this.button1.TabIndex = 50;
            this.button1.Text = "Limpiar Busqueda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // lblTotalEmpleado
            // 
            this.lblTotalEmpleado.AutoSize = true;
            this.lblTotalEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblTotalEmpleado.Location = new System.Drawing.Point(733, 13);
            this.lblTotalEmpleado.Name = "lblTotalEmpleado";
            this.lblTotalEmpleado.Size = new System.Drawing.Size(226, 24);
            this.lblTotalEmpleado.TabIndex = 49;
            this.lblTotalEmpleado.Text = "Empleados en el sistema:";
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.BackColor = System.Drawing.Color.Transparent;
            this.chbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEliminar.ForeColor = System.Drawing.Color.Black;
            this.chbEliminar.Location = new System.Drawing.Point(25, 49);
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Size = new System.Drawing.Size(97, 28);
            this.chbEliminar.TabIndex = 48;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(331, 45);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 29);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(331, 10);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(113, 30);
            this.btnBuscarEmpleado.TabIndex = 46;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(133, 15);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(160, 29);
            this.txtBusqueda.TabIndex = 41;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(25, 84);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(941, 232);
            this.dgvEmpleados.TabIndex = 40;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(27, 245);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(997, 358);
            this.tabControl2.TabIndex = 47;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1050, 621);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de empleados";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnEditEmpleado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnConfirmarEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalEmpleado;
        private System.Windows.Forms.CheckBox chbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chbEmpInact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbInactivoT;
        private System.Windows.Forms.Label lbActivoT;
        private System.Windows.Forms.Label lblTelefonoLetra;
        private System.Windows.Forms.Label lblDNILetra;
        private System.Windows.Forms.Button btnBorrarBusqueda;
    }
}