namespace Formularios
{
    partial class FormCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuenta));
            this.cuenta_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cuenta_contraseña = new System.Windows.Forms.TextBox();
            this.cuenta_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaCuentas = new System.Windows.Forms.DataGridView();
            this.cuentaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta_contraseña2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuenta_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listaServicios = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaCuentas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuenta_nombre
            // 
            this.cuenta_nombre.Location = new System.Drawing.Point(254, 42);
            this.cuenta_nombre.Name = "cuenta_nombre";
            this.cuenta_nombre.Size = new System.Drawing.Size(188, 20);
            this.cuenta_nombre.TabIndex = 0;
            this.cuenta_nombre.TextChanged += new System.EventHandler(this.cuenta_nombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // cuenta_contraseña
            // 
            this.cuenta_contraseña.Location = new System.Drawing.Point(254, 132);
            this.cuenta_contraseña.Name = "cuenta_contraseña";
            this.cuenta_contraseña.Size = new System.Drawing.Size(188, 20);
            this.cuenta_contraseña.TabIndex = 3;
            this.cuenta_contraseña.UseSystemPasswordChar = true;
            this.cuenta_contraseña.TextChanged += new System.EventHandler(this.cuenta_contraseña_TextChanged);
            // 
            // cuenta_usuario
            // 
            this.cuenta_usuario.Location = new System.Drawing.Point(254, 72);
            this.cuenta_usuario.Name = "cuenta_usuario";
            this.cuenta_usuario.Size = new System.Drawing.Size(188, 20);
            this.cuenta_usuario.TabIndex = 1;
            this.cuenta_usuario.TextChanged += new System.EventHandler(this.cuenta_usuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección:";
            // 
            // listaCuentas
            // 
            this.listaCuentas.AllowUserToAddRows = false;
            this.listaCuentas.AllowUserToOrderColumns = true;
            this.listaCuentas.AllowUserToResizeColumns = false;
            this.listaCuentas.AllowUserToResizeRows = false;
            this.listaCuentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listaCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuentaId,
            this.nombre,
            this.usuario,
            this.contraseña,
            this.servicio});
            this.listaCuentas.Location = new System.Drawing.Point(2, 191);
            this.listaCuentas.MultiSelect = false;
            this.listaCuentas.Name = "listaCuentas";
            this.listaCuentas.ReadOnly = true;
            this.listaCuentas.RowHeadersVisible = false;
            this.listaCuentas.Size = new System.Drawing.Size(653, 156);
            this.listaCuentas.TabIndex = 0;
            this.listaCuentas.TabStop = false;
            this.listaCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaCuentas_CellClick);
            this.listaCuentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaCuentas_CellDoubleClick);
            this.listaCuentas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaCuentas_RowEnter);
            // 
            // cuentaId
            // 
            this.cuentaId.HeaderText = "ID";
            this.cuentaId.Name = "cuentaId";
            this.cuentaId.ReadOnly = true;
            this.cuentaId.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 250;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Dirección";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 300;
            // 
            // contraseña
            // 
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            this.contraseña.Visible = false;
            this.contraseña.Width = 200;
            // 
            // servicio
            // 
            this.servicio.HeaderText = "Servicio";
            this.servicio.Name = "servicio";
            this.servicio.ReadOnly = true;
            // 
            // cuenta_contraseña2
            // 
            this.cuenta_contraseña2.Location = new System.Drawing.Point(254, 163);
            this.cuenta_contraseña2.Name = "cuenta_contraseña2";
            this.cuenta_contraseña2.Size = new System.Drawing.Size(188, 20);
            this.cuenta_contraseña2.TabIndex = 4;
            this.cuenta_contraseña2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Validar Contraseña:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.nuevoToolStripMenuItem.Text = "Nueva";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrarToolStripMenuItem.Image")));
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // cuenta_id
            // 
            this.cuenta_id.Location = new System.Drawing.Point(523, 47);
            this.cuenta_id.Name = "cuenta_id";
            this.cuenta_id.Size = new System.Drawing.Size(100, 20);
            this.cuenta_id.TabIndex = 0;
            this.cuenta_id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Servicio:";
            // 
            // listaServicios
            // 
            this.listaServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaServicios.FormattingEnabled = true;
            this.listaServicios.Location = new System.Drawing.Point(254, 102);
            this.listaServicios.Name = "listaServicios";
            this.listaServicios.Size = new System.Drawing.Size(188, 21);
            this.listaServicios.TabIndex = 2;
            this.listaServicios.SelectedIndexChanged += new System.EventHandler(this.listaServicios_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ejemplo: usuario@servicio.com";
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.Location = new System.Drawing.Point(451, 135);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(115, 17);
            this.mostrar.TabIndex = 6;
            this.mostrar.Text = "Mostrar Caracteres";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.CheckedChanged += new System.EventHandler(this.mostrar_CheckedChanged);
            // 
            // FormCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(656, 349);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listaServicios);
            this.Controls.Add(this.cuenta_id);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cuenta_contraseña2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listaCuentas);
            this.Controls.Add(this.cuenta_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cuenta_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cuenta_contraseña);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Cuentas";
            this.Load += new System.EventHandler(this.FormCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCuentas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cuenta_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cuenta_contraseña;
        private System.Windows.Forms.TextBox cuenta_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listaCuentas;
        private System.Windows.Forms.TextBox cuenta_contraseña2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.TextBox cuenta_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listaServicios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.CheckBox mostrar;
    }
}