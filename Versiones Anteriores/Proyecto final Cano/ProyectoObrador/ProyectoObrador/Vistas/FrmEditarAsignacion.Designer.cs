namespace ProyectoObrador.Vistas
{
    partial class FrmEditarAsignacion
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
            this.lbNoHerraDisponibl = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvDatosEmpleadoSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvHerramientaSel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNoHerraDisponibl
            // 
            this.lbNoHerraDisponibl.AutoSize = true;
            this.lbNoHerraDisponibl.Location = new System.Drawing.Point(497, 160);
            this.lbNoHerraDisponibl.Name = "lbNoHerraDisponibl";
            this.lbNoHerraDisponibl.Size = new System.Drawing.Size(35, 13);
            this.lbNoHerraDisponibl.TabIndex = 94;
            this.lbNoHerraDisponibl.Text = "label2";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(905, 106);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 39);
            this.btnCancelar.TabIndex = 93;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmarEdit
            // 
            this.btnConfirmarEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarEdit.Enabled = false;
            this.btnConfirmarEdit.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarEdit.Location = new System.Drawing.Point(905, 63);
            this.btnConfirmarEdit.Name = "btnConfirmarEdit";
            this.btnConfirmarEdit.Size = new System.Drawing.Size(97, 39);
            this.btnConfirmarEdit.TabIndex = 92;
            this.btnConfirmarEdit.Text = "Confirmar";
            this.btnConfirmarEdit.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(793, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 39);
            this.button3.TabIndex = 91;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnEditEmpleado
            // 
            this.btnEditEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnEditEmpleado.Location = new System.Drawing.Point(793, 63);
            this.btnEditEmpleado.Name = "btnEditEmpleado";
            this.btnEditEmpleado.Size = new System.Drawing.Size(102, 79);
            this.btnEditEmpleado.TabIndex = 90;
            this.btnEditEmpleado.Text = "Editar";
            this.btnEditEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAsignacio
            // 
            this.btnAgregarAsignacio.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarAsignacio.Location = new System.Drawing.Point(793, 18);
            this.btnAgregarAsignacio.Name = "btnAgregarAsignacio";
            this.btnAgregarAsignacio.Size = new System.Drawing.Size(209, 39);
            this.btnAgregarAsignacio.TabIndex = 89;
            this.btnAgregarAsignacio.Text = "Agregar";
            this.btnAgregarAsignacio.UseVisualStyleBackColor = true;
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
            this.dvDatosEmpleadoSel.Location = new System.Drawing.Point(12, 41);
            this.dvDatosEmpleadoSel.Name = "dvDatosEmpleadoSel";
            this.dvDatosEmpleadoSel.ReadOnly = true;
            this.dvDatosEmpleadoSel.Size = new System.Drawing.Size(353, 69);
            this.dvDatosEmpleadoSel.TabIndex = 88;
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
            this.dvHerramientaSel.Location = new System.Drawing.Point(12, 131);
            this.dvHerramientaSel.Name = "dvHerramientaSel";
            this.dvHerramientaSel.ReadOnly = true;
            this.dvHerramientaSel.Size = new System.Drawing.Size(353, 72);
            this.dvHerramientaSel.TabIndex = 87;
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
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(371, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 59);
            this.button4.TabIndex = 86;
            this.button4.Text = "buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtfechaDevolucion
            // 
            this.dtfechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaDevolucion.Location = new System.Drawing.Point(662, 88);
            this.dtfechaDevolucion.Name = "dtfechaDevolucion";
            this.dtfechaDevolucion.Size = new System.Drawing.Size(118, 20);
            this.dtfechaDevolucion.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Fecha de devolucion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Herramienta";
            // 
            // dtfechaAsignacion
            // 
            this.dtfechaAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaAsignacion.Location = new System.Drawing.Point(662, 37);
            this.dtfechaAsignacion.Name = "dtfechaAsignacion";
            this.dtfechaAsignacion.Size = new System.Drawing.Size(118, 20);
            this.dtfechaAsignacion.TabIndex = 82;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 59);
            this.button1.TabIndex = 81;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Fecha de asignacion: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Empleado";
            // 
            // FrmEditarAsignacion
            // 
            this.ClientSize = new System.Drawing.Size(1034, 277);
            this.Controls.Add(this.lbNoHerraDisponibl);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditEmpleado);
            this.Controls.Add(this.btnAgregarAsignacio);
            this.Controls.Add(this.dvDatosEmpleadoSel);
            this.Controls.Add(this.dvHerramientaSel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtfechaDevolucion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtfechaAsignacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "FrmEditarAsignacion";
            this.Load += new System.EventHandler(this.FrmEditarAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvDatosEmpleadoSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvHerramientaSel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNoHerraDisponibl;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarEdit;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnEditEmpleado;
        private System.Windows.Forms.Button btnAgregarAsignacio;
        private System.Windows.Forms.DataGridView dvDatosEmpleadoSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridView dvHerramientaSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHerramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtfechaDevolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtfechaAsignacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}