namespace Formularios
{
    partial class FormContraseña
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
            this.btSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.CheckBox();
            this.cuenta_contraseña = new System.Windows.Forms.TextBox();
            this.labelCuenta = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSiguiente
            // 
            this.btSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSiguiente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSiguiente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSiguiente.Location = new System.Drawing.Point(85, 197);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(127, 29);
            this.btSiguiente.TabIndex = 5;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = false;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su contraseña para continuar:";
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.Location = new System.Drawing.Point(45, 140);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(115, 17);
            this.mostrar.TabIndex = 4;
            this.mostrar.Text = "Mostrar Caracteres";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.CheckedChanged += new System.EventHandler(this.mostrar_CheckedChanged);
            // 
            // cuenta_contraseña
            // 
            this.cuenta_contraseña.Location = new System.Drawing.Point(45, 101);
            this.cuenta_contraseña.Name = "cuenta_contraseña";
            this.cuenta_contraseña.Size = new System.Drawing.Size(188, 20);
            this.cuenta_contraseña.TabIndex = 3;
            this.cuenta_contraseña.UseSystemPasswordChar = true;
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuenta.Location = new System.Drawing.Point(42, 68);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(60, 16);
            this.labelCuenta.TabIndex = 1;
            this.labelCuenta.Text = "Cuenta:";
            this.labelCuenta.Visible = false;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(108, 68);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(72, 16);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "direccion";
            this.labelDireccion.Visible = false;
            // 
            // FormContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(307, 262);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelCuenta);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.cuenta_contraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSiguiente);
            this.Name = "FormContraseña";
            this.Text = "Contraseña";
            this.Load += new System.EventHandler(this.FormContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox mostrar;
        private System.Windows.Forms.TextBox cuenta_contraseña;
        private System.Windows.Forms.Label labelCuenta;
        private System.Windows.Forms.Label labelDireccion;
    }
}