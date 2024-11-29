namespace ProyectoObrador
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.panelSubMenuPrestamo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.prestamos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelAdmSubMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.admHE = new System.Windows.Forms.Button();
            this.logoSevati = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuVertical.SuspendLayout();
            this.panelSubMenuPrestamo.SuspendLayout();
            this.panelAdmSubMenu.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.AutoScroll = true;
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.menuVertical.Controls.Add(this.btnTestConnection);
            this.menuVertical.Controls.Add(this.panelSubMenuPrestamo);
            this.menuVertical.Controls.Add(this.button3);
            this.menuVertical.Controls.Add(this.panelAdmSubMenu);
            this.menuVertical.Controls.Add(this.admHE);
            this.menuVertical.Controls.Add(this.logoSevati);
            this.menuVertical.Controls.Add(this.label1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 650);
            this.menuVertical.TabIndex = 5;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.Teal;
            this.btnTestConnection.FlatAppearance.BorderSize = 0;
            this.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConnection.ForeColor = System.Drawing.Color.White;
            this.btnTestConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnTestConnection.Image")));
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.Location = new System.Drawing.Point(50, 585);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(136, 40);
            this.btnTestConnection.TabIndex = 19;
            this.btnTestConnection.Text = "Prueba DB Conexion";
            this.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // panelSubMenuPrestamo
            // 
            this.panelSubMenuPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panelSubMenuPrestamo.Controls.Add(this.button1);
            this.panelSubMenuPrestamo.Controls.Add(this.prestamos);
            this.panelSubMenuPrestamo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuPrestamo.Location = new System.Drawing.Point(0, 324);
            this.panelSubMenuPrestamo.Name = "panelSubMenuPrestamo";
            this.panelSubMenuPrestamo.Size = new System.Drawing.Size(250, 105);
            this.panelSubMenuPrestamo.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(33)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(247, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Asignaciones";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // prestamos
            // 
            this.prestamos.FlatAppearance.BorderSize = 0;
            this.prestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(33)))));
            this.prestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prestamos.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prestamos.ForeColor = System.Drawing.SystemColors.Control;
            this.prestamos.Location = new System.Drawing.Point(6, 0);
            this.prestamos.Name = "prestamos";
            this.prestamos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.prestamos.Size = new System.Drawing.Size(244, 45);
            this.prestamos.TabIndex = 0;
            this.prestamos.Text = "Prestamos";
            this.prestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prestamos.UseVisualStyleBackColor = true;
            this.prestamos.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(33)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(0, 279);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Prestamos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelAdmSubMenu
            // 
            this.panelAdmSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panelAdmSubMenu.Controls.Add(this.button4);
            this.panelAdmSubMenu.Controls.Add(this.btnEmpleado);
            this.panelAdmSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmSubMenu.Location = new System.Drawing.Point(0, 174);
            this.panelAdmSubMenu.Name = "panelAdmSubMenu";
            this.panelAdmSubMenu.Size = new System.Drawing.Size(250, 105);
            this.panelAdmSubMenu.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(33)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(6, 51);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(247, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Herramientas";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(33)))));
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmpleado.Location = new System.Drawing.Point(6, 0);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(244, 45);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // admHE
            // 
            this.admHE.Dock = System.Windows.Forms.DockStyle.Top;
            this.admHE.FlatAppearance.BorderSize = 0;
            this.admHE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(33)))));
            this.admHE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admHE.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admHE.ForeColor = System.Drawing.SystemColors.Control;
            this.admHE.Location = new System.Drawing.Point(0, 129);
            this.admHE.Name = "admHE";
            this.admHE.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.admHE.Size = new System.Drawing.Size(250, 45);
            this.admHE.TabIndex = 5;
            this.admHE.Text = "Administracion";
            this.admHE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admHE.UseVisualStyleBackColor = true;
            this.admHE.Click += new System.EventHandler(this.admHE_Click);
            // 
            // logoSevati
            // 
            this.logoSevati.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoSevati.Location = new System.Drawing.Point(0, 0);
            this.logoSevati.Name = "logoSevati";
            this.logoSevati.Size = new System.Drawing.Size(250, 129);
            this.logoSevati.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(80, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "**LOGO SEVATI**";
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Controls.Add(this.btnSlide);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(250, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.barraTitulo.TabIndex = 6;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = global::ProyectoObrador.Properties.Resources.minimzanotanto;
            this.btnRestaurar.Location = new System.Drawing.Point(982, 9);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = global::ProyectoObrador.Properties.Resources.maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(982, 9);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::ProyectoObrador.Properties.Resources.minima;
            this.btnMinimizar.Location = new System.Drawing.Point(951, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::ProyectoObrador.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1013, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::ProyectoObrador.Properties.Resources.menu3barra;
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.panelContenedor.TabIndex = 7;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Principal";
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.panelSubMenuPrestamo.ResumeLayout(false);
            this.panelAdmSubMenu.ResumeLayout(false);
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdmSubMenu;
        private System.Windows.Forms.Panel logoSevati;
        private System.Windows.Forms.Panel panelSubMenuPrestamo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button prestamos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button admHE;
        internal System.Windows.Forms.Button btnTestConnection;
    }
}

