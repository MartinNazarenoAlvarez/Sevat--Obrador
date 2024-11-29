﻿namespace ProyectoObrador.Vistas
{
    partial class HerramientasAsignadas
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
            this.lbHerraTodaPrestada = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbHerraTodaPrestada);
            this.groupBox1.Controls.Add(this.dgvDescripcion);
            this.groupBox1.Controls.Add(this.btnBorrarBusquedaHerramienta);
            this.groupBox1.Controls.Add(this.cmbBusquedaHerramienta);
            this.groupBox1.Controls.Add(this.btnBuscarHerramienta);
            this.groupBox1.Controls.Add(this.txtBusquedaHerramienta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvHerramientas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 2;
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
            this.btnBorrarBusquedaHerramienta.Location = new System.Drawing.Point(356, 26);
            this.btnBorrarBusquedaHerramienta.Name = "btnBorrarBusquedaHerramienta";
            this.btnBorrarBusquedaHerramienta.Size = new System.Drawing.Size(26, 29);
            this.btnBorrarBusquedaHerramienta.TabIndex = 73;
            this.btnBorrarBusquedaHerramienta.Text = "X";
            this.btnBorrarBusquedaHerramienta.UseVisualStyleBackColor = true;
            this.btnBorrarBusquedaHerramienta.Click += new System.EventHandler(this.btnBorrarBusquedaHerramienta_Click_1);
            // 
            // cmbBusquedaHerramienta
            // 
            this.cmbBusquedaHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusquedaHerramienta.FormattingEnabled = true;
            this.cmbBusquedaHerramienta.Items.AddRange(new object[] {
            "IDHerramienta",
            "IDAsignacion",
            "Marca"});
            this.cmbBusquedaHerramienta.Location = new System.Drawing.Point(6, 25);
            this.cmbBusquedaHerramienta.Name = "cmbBusquedaHerramienta";
            this.cmbBusquedaHerramienta.Size = new System.Drawing.Size(174, 32);
            this.cmbBusquedaHerramienta.TabIndex = 72;
            // 
            // btnBuscarHerramienta
            // 
            this.btnBuscarHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHerramienta.Location = new System.Drawing.Point(383, 25);
            this.btnBuscarHerramienta.Name = "btnBuscarHerramienta";
            this.btnBuscarHerramienta.Size = new System.Drawing.Size(113, 30);
            this.btnBuscarHerramienta.TabIndex = 71;
            this.btnBuscarHerramienta.Text = "Buscar";
            this.btnBuscarHerramienta.UseVisualStyleBackColor = true;
            this.btnBuscarHerramienta.Click += new System.EventHandler(this.btnBuscarHerramienta_Click_1);
            // 
            // txtBusquedaHerramienta
            // 
            this.txtBusquedaHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaHerramienta.Location = new System.Drawing.Point(186, 25);
            this.txtBusquedaHerramienta.Name = "txtBusquedaHerramienta";
            this.txtBusquedaHerramienta.Size = new System.Drawing.Size(164, 29);
            this.txtBusquedaHerramienta.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(647, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 53;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.dgvHerramientas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHerramientas_CellContentClick);
            // 
            // lbHerraTodaPrestada
            // 
            this.lbHerraTodaPrestada.AutoSize = true;
            this.lbHerraTodaPrestada.Location = new System.Drawing.Point(186, 2);
            this.lbHerraTodaPrestada.Name = "lbHerraTodaPrestada";
            this.lbHerraTodaPrestada.Size = new System.Drawing.Size(39, 20);
            this.lbHerraTodaPrestada.TabIndex = 75;
            this.lbHerraTodaPrestada.Text = "*****";
            this.lbHerraTodaPrestada.Visible = false;
            // 
            // HerramientasAsignadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "HerramientasAsignadas";
            this.Text = "HerramientasAsignadas";
            this.Load += new System.EventHandler(this.HerramientasAsignadas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramientas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDescripcion;
        private System.Windows.Forms.Button btnBorrarBusquedaHerramienta;
        private System.Windows.Forms.ComboBox cmbBusquedaHerramienta;
        private System.Windows.Forms.Button btnBuscarHerramienta;
        private System.Windows.Forms.TextBox txtBusquedaHerramienta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvHerramientas;
        private System.Windows.Forms.Label lbHerraTodaPrestada;
    }
}