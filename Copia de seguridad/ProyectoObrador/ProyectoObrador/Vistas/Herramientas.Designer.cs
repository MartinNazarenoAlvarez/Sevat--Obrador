namespace ProyectoObrador.Vistas
{
    partial class Herramientas
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
            this.dgvDescripcion = new System.Windows.Forms.DataGridView();
            this.btnBorrarBusquedaHerramienta = new System.Windows.Forms.Button();
            this.cmbBusquedaHerramienta = new System.Windows.Forms.ComboBox();
            this.btnBuscarHerramienta = new System.Windows.Forms.Button();
            this.txtBusquedaHerramienta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvHerramientas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDescripcion);
            this.groupBox1.Controls.Add(this.btnBorrarBusquedaHerramienta);
            this.groupBox1.Controls.Add(this.cmbBusquedaHerramienta);
            this.groupBox1.Controls.Add(this.btnBuscarHerramienta);
            this.groupBox1.Controls.Add(this.txtBusquedaHerramienta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvHerramientas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Herramientas";
            // 
            // dgvDescripcion
            // 
            this.dgvDescripcion.AllowUserToAddRows = false;
            this.dgvDescripcion.AllowUserToDeleteRows = false;
            this.dgvDescripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescripcion.Location = new System.Drawing.Point(608, 63);
            this.dgvDescripcion.Name = "dgvDescripcion";
            this.dgvDescripcion.ReadOnly = true;
            this.dgvDescripcion.Size = new System.Drawing.Size(162, 357);
            this.dgvDescripcion.TabIndex = 74;
            // 
            // btnBorrarBusquedaHerramienta
            // 
            this.btnBorrarBusquedaHerramienta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnBorrarBusquedaHerramienta.ForeColor = System.Drawing.Color.LightGray;
            this.btnBorrarBusquedaHerramienta.Location = new System.Drawing.Point(356, 26);
            this.btnBorrarBusquedaHerramienta.Name = "btnBorrarBusquedaHerramienta";
            this.btnBorrarBusquedaHerramienta.Size = new System.Drawing.Size(26, 29);
            this.btnBorrarBusquedaHerramienta.TabIndex = 73;
            this.btnBorrarBusquedaHerramienta.Text = "X";
            this.btnBorrarBusquedaHerramienta.UseVisualStyleBackColor = false;
            this.btnBorrarBusquedaHerramienta.Click += new System.EventHandler(this.btnBorrarBusquedaHerramienta_Click);
            // 
            // cmbBusquedaHerramienta
            // 
            this.cmbBusquedaHerramienta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cmbBusquedaHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusquedaHerramienta.ForeColor = System.Drawing.Color.LightGray;
            this.cmbBusquedaHerramienta.FormattingEnabled = true;
            this.cmbBusquedaHerramienta.Items.AddRange(new object[] {
            "ID",
            "Numero de serie",
            "Marca"});
            this.cmbBusquedaHerramienta.Location = new System.Drawing.Point(6, 25);
            this.cmbBusquedaHerramienta.Name = "cmbBusquedaHerramienta";
            this.cmbBusquedaHerramienta.Size = new System.Drawing.Size(174, 32);
            this.cmbBusquedaHerramienta.TabIndex = 72;
            // 
            // btnBuscarHerramienta
            // 
            this.btnBuscarHerramienta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnBuscarHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHerramienta.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarHerramienta.Location = new System.Drawing.Point(383, 25);
            this.btnBuscarHerramienta.Name = "btnBuscarHerramienta";
            this.btnBuscarHerramienta.Size = new System.Drawing.Size(113, 30);
            this.btnBuscarHerramienta.TabIndex = 71;
            this.btnBuscarHerramienta.Text = "Buscar";
            this.btnBuscarHerramienta.UseVisualStyleBackColor = false;
            this.btnBuscarHerramienta.Click += new System.EventHandler(this.btnBuscarHerramienta_Click);
            // 
            // txtBusquedaHerramienta
            // 
            this.txtBusquedaHerramienta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.txtBusquedaHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaHerramienta.ForeColor = System.Drawing.Color.LightGray;
            this.txtBusquedaHerramienta.Location = new System.Drawing.Point(186, 25);
            this.txtBusquedaHerramienta.Name = "txtBusquedaHerramienta";
            this.txtBusquedaHerramienta.Size = new System.Drawing.Size(164, 29);
            this.txtBusquedaHerramienta.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(647, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 53;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvHerramientas
            // 
            this.dgvHerramientas.AllowUserToAddRows = false;
            this.dgvHerramientas.AllowUserToDeleteRows = false;
            this.dgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerramientas.Location = new System.Drawing.Point(6, 63);
            this.dgvHerramientas.Name = "dgvHerramientas";
            this.dgvHerramientas.ReadOnly = true;
            this.dgvHerramientas.Size = new System.Drawing.Size(596, 357);
            this.dgvHerramientas.TabIndex = 52;
            // 
            // Herramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Herramientas";
            this.Text = "Herramientas";
            this.Load += new System.EventHandler(this.Herramientas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvHerramientas;
        private System.Windows.Forms.Button btnBorrarBusquedaHerramienta;
        private System.Windows.Forms.ComboBox cmbBusquedaHerramienta;
        private System.Windows.Forms.Button btnBuscarHerramienta;
        private System.Windows.Forms.TextBox txtBusquedaHerramienta;
        private System.Windows.Forms.DataGridView dgvDescripcion;
    }
}