namespace Formularios
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.correo_texto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listaCuentas = new System.Windows.Forms.ComboBox();
            this.labelFormato = new System.Windows.Forms.Label();
            this.rbtEML = new System.Windows.Forms.RadioButton();
            this.rbtTextoPlano = new System.Windows.Forms.RadioButton();
            this.btExportar = new System.Windows.Forms.Button();
            this.panelCorreo = new System.Windows.Forms.Panel();
            this.correo_Adjuntos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.correo_eliminado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.correo_cuentaOrigen = new System.Windows.Forms.TextBox();
            this.correo_tipocorreo = new System.Windows.Forms.TextBox();
            this.correo_servicioid = new System.Windows.Forms.TextBox();
            this.correo_leido = new System.Windows.Forms.TextBox();
            this.correo_id = new System.Windows.Forms.TextBox();
            this.correo_fecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.correo_asunto = new System.Windows.Forms.Label();
            this.correo_cuentaDestino = new System.Windows.Forms.TextBox();
            this.listaEnviados = new System.Windows.Forms.DataGridView();
            this.correoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaRecibidos = new System.Windows.Forms.DataGridView();
            this.correoIdR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCorreoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaOrigenR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDestinoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leidoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioIdR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminadoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEnviados = new System.Windows.Forms.Button();
            this.btRecibidos = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btReenviar = new System.Windows.Forms.Button();
            this.btRedactar = new System.Windows.Forms.Button();
            this.btResponder = new System.Windows.Forms.Button();
            this.mensajeActualizando = new System.Windows.Forms.TextBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btLeido = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelCorreo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEnviados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecibidos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarCuentasToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarCuentasToolStripMenuItem
            // 
            this.administrarCuentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administrarCuentasToolStripMenuItem.Image")));
            this.administrarCuentasToolStripMenuItem.Name = "administrarCuentasToolStripMenuItem";
            this.administrarCuentasToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.administrarCuentasToolStripMenuItem.Text = "Administrar Cuentas";
            this.administrarCuentasToolStripMenuItem.Click += new System.EventHandler(this.configuracionCuentasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem2});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem2
            // 
            this.ayudaToolStripMenuItem2.Name = "ayudaToolStripMenuItem2";
            this.ayudaToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.ayudaToolStripMenuItem2.Text = "Ver la Ayuda";
            this.ayudaToolStripMenuItem2.Click += new System.EventHandler(this.ayudaToolStripMenuItem2_Click);
            // 
            // configuraciónDeCuentasToolStripMenuItem
            // 
            this.configuraciónDeCuentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configuraciónDeCuentasToolStripMenuItem.Image")));
            this.configuraciónDeCuentasToolStripMenuItem.Name = "configuraciónDeCuentasToolStripMenuItem";
            this.configuraciónDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.configuraciónDeCuentasToolStripMenuItem.Text = "Configuración de Cuentas";
            this.configuraciónDeCuentasToolStripMenuItem.Click += new System.EventHandler(this.configuracionCuentasToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // correo_texto
            // 
            this.correo_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correo_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_texto.Location = new System.Drawing.Point(41, 116);
            this.correo_texto.Multiline = true;
            this.correo_texto.Name = "correo_texto";
            this.correo_texto.ReadOnly = true;
            this.correo_texto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.correo_texto.Size = new System.Drawing.Size(745, 303);
            this.correo_texto.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listaCuentas
            // 
            this.listaCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaCuentas.FormattingEnabled = true;
            this.listaCuentas.Location = new System.Drawing.Point(12, 27);
            this.listaCuentas.Name = "listaCuentas";
            this.listaCuentas.Size = new System.Drawing.Size(134, 21);
            this.listaCuentas.TabIndex = 0;
            this.listaCuentas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelFormato
            // 
            this.labelFormato.AutoSize = true;
            this.labelFormato.Location = new System.Drawing.Point(12, 386);
            this.labelFormato.Name = "labelFormato";
            this.labelFormato.Size = new System.Drawing.Size(101, 13);
            this.labelFormato.TabIndex = 9;
            this.labelFormato.Text = "Seleccione formato:";
            this.labelFormato.Visible = false;
            // 
            // rbtEML
            // 
            this.rbtEML.AutoSize = true;
            this.rbtEML.Location = new System.Drawing.Point(47, 434);
            this.rbtEML.Name = "rbtEML";
            this.rbtEML.Size = new System.Drawing.Size(47, 17);
            this.rbtEML.TabIndex = 11;
            this.rbtEML.Text = "EML";
            this.rbtEML.UseVisualStyleBackColor = true;
            this.rbtEML.Visible = false;
            // 
            // rbtTextoPlano
            // 
            this.rbtTextoPlano.AutoSize = true;
            this.rbtTextoPlano.Checked = true;
            this.rbtTextoPlano.Location = new System.Drawing.Point(47, 411);
            this.rbtTextoPlano.Name = "rbtTextoPlano";
            this.rbtTextoPlano.Size = new System.Drawing.Size(82, 17);
            this.rbtTextoPlano.TabIndex = 10;
            this.rbtTextoPlano.TabStop = true;
            this.rbtTextoPlano.Text = "Texto Plano";
            this.rbtTextoPlano.UseVisualStyleBackColor = true;
            this.rbtTextoPlano.Visible = false;
            // 
            // btExportar
            // 
            this.btExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExportar.Location = new System.Drawing.Point(15, 457);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(127, 29);
            this.btExportar.TabIndex = 12;
            this.btExportar.Text = "Exportar";
            this.btExportar.UseVisualStyleBackColor = false;
            this.btExportar.Visible = false;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // panelCorreo
            // 
            this.panelCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.panelCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCorreo.Controls.Add(this.correo_Adjuntos);
            this.panelCorreo.Controls.Add(this.label2);
            this.panelCorreo.Controls.Add(this.correo_eliminado);
            this.panelCorreo.Controls.Add(this.label1);
            this.panelCorreo.Controls.Add(this.correo_cuentaOrigen);
            this.panelCorreo.Controls.Add(this.correo_tipocorreo);
            this.panelCorreo.Controls.Add(this.correo_servicioid);
            this.panelCorreo.Controls.Add(this.correo_leido);
            this.panelCorreo.Controls.Add(this.correo_id);
            this.panelCorreo.Controls.Add(this.correo_texto);
            this.panelCorreo.Controls.Add(this.correo_fecha);
            this.panelCorreo.Controls.Add(this.label7);
            this.panelCorreo.Controls.Add(this.label5);
            this.panelCorreo.Controls.Add(this.correo_asunto);
            this.panelCorreo.Controls.Add(this.correo_cuentaDestino);
            this.panelCorreo.Location = new System.Drawing.Point(153, 27);
            this.panelCorreo.Name = "panelCorreo";
            this.panelCorreo.Size = new System.Drawing.Size(816, 488);
            this.panelCorreo.TabIndex = 34;
            // 
            // correo_Adjuntos
            // 
            this.correo_Adjuntos.Location = new System.Drawing.Point(123, 430);
            this.correo_Adjuntos.Multiline = true;
            this.correo_Adjuntos.Name = "correo_Adjuntos";
            this.correo_Adjuntos.ReadOnly = true;
            this.correo_Adjuntos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.correo_Adjuntos.Size = new System.Drawing.Size(662, 48);
            this.correo_Adjuntos.TabIndex = 42;
            this.correo_Adjuntos.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Adjuntos:";
            this.label2.Visible = false;
            // 
            // correo_eliminado
            // 
            this.correo_eliminado.Location = new System.Drawing.Point(791, 58);
            this.correo_eliminado.Name = "correo_eliminado";
            this.correo_eliminado.Size = new System.Drawing.Size(20, 20);
            this.correo_eliminado.TabIndex = 12;
            this.correo_eliminado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha:";
            // 
            // correo_cuentaOrigen
            // 
            this.correo_cuentaOrigen.Location = new System.Drawing.Point(103, 26);
            this.correo_cuentaOrigen.Name = "correo_cuentaOrigen";
            this.correo_cuentaOrigen.ReadOnly = true;
            this.correo_cuentaOrigen.Size = new System.Drawing.Size(311, 20);
            this.correo_cuentaOrigen.TabIndex = 5;
            // 
            // correo_tipocorreo
            // 
            this.correo_tipocorreo.Location = new System.Drawing.Point(763, 32);
            this.correo_tipocorreo.Name = "correo_tipocorreo";
            this.correo_tipocorreo.Size = new System.Drawing.Size(22, 20);
            this.correo_tipocorreo.TabIndex = 10;
            this.correo_tipocorreo.Visible = false;
            // 
            // correo_servicioid
            // 
            this.correo_servicioid.Location = new System.Drawing.Point(792, 32);
            this.correo_servicioid.Name = "correo_servicioid";
            this.correo_servicioid.Size = new System.Drawing.Size(20, 20);
            this.correo_servicioid.TabIndex = 11;
            this.correo_servicioid.Visible = false;
            // 
            // correo_leido
            // 
            this.correo_leido.Location = new System.Drawing.Point(763, 6);
            this.correo_leido.Name = "correo_leido";
            this.correo_leido.Size = new System.Drawing.Size(22, 20);
            this.correo_leido.TabIndex = 8;
            this.correo_leido.Visible = false;
            // 
            // correo_id
            // 
            this.correo_id.Location = new System.Drawing.Point(792, 6);
            this.correo_id.Name = "correo_id";
            this.correo_id.Size = new System.Drawing.Size(20, 20);
            this.correo_id.TabIndex = 9;
            this.correo_id.Visible = false;
            // 
            // correo_fecha
            // 
            this.correo_fecha.AutoSize = true;
            this.correo_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_fecha.Location = new System.Drawing.Point(100, 95);
            this.correo_fecha.Name = "correo_fecha";
            this.correo_fecha.Size = new System.Drawing.Size(54, 18);
            this.correo_fecha.TabIndex = 7;
            this.correo_fecha.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Para:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "De: ";
            // 
            // correo_asunto
            // 
            this.correo_asunto.AutoSize = true;
            this.correo_asunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_asunto.Location = new System.Drawing.Point(38, 4);
            this.correo_asunto.MaximumSize = new System.Drawing.Size(750, 20);
            this.correo_asunto.Name = "correo_asunto";
            this.correo_asunto.Size = new System.Drawing.Size(66, 20);
            this.correo_asunto.TabIndex = 0;
            this.correo_asunto.Text = "Asunto";
            // 
            // correo_cuentaDestino
            // 
            this.correo_cuentaDestino.Location = new System.Drawing.Point(103, 53);
            this.correo_cuentaDestino.Multiline = true;
            this.correo_cuentaDestino.Name = "correo_cuentaDestino";
            this.correo_cuentaDestino.ReadOnly = true;
            this.correo_cuentaDestino.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.correo_cuentaDestino.Size = new System.Drawing.Size(683, 35);
            this.correo_cuentaDestino.TabIndex = 6;
            // 
            // listaEnviados
            // 
            this.listaEnviados.AllowUserToAddRows = false;
            this.listaEnviados.AllowUserToOrderColumns = true;
            this.listaEnviados.AllowUserToResizeColumns = false;
            this.listaEnviados.AllowUserToResizeRows = false;
            this.listaEnviados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaEnviados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listaEnviados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.listaEnviados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaEnviados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaEnviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEnviados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correoId,
            this.tipoCorreo,
            this.asunto,
            this.cuentaOrigen,
            this.cuentaDestino,
            this.Fecha,
            this.texto,
            this.leido,
            this.servicioId,
            this.eliminado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaEnviados.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaEnviados.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listaEnviados.Location = new System.Drawing.Point(152, 27);
            this.listaEnviados.MultiSelect = false;
            this.listaEnviados.Name = "listaEnviados";
            this.listaEnviados.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaEnviados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaEnviados.RowHeadersVisible = false;
            this.listaEnviados.RowHeadersWidth = 20;
            this.listaEnviados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listaEnviados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listaEnviados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaEnviados.Size = new System.Drawing.Size(817, 488);
            this.listaEnviados.TabIndex = 10;
            this.listaEnviados.TabStop = false;
            this.listaEnviados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaEnviados_CellDoubleClick);
            this.listaEnviados.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaEnviados_CellEnter);
            // 
            // correoId
            // 
            this.correoId.HeaderText = "correoid";
            this.correoId.Name = "correoId";
            this.correoId.ReadOnly = true;
            this.correoId.Visible = false;
            // 
            // tipoCorreo
            // 
            this.tipoCorreo.HeaderText = "Tipo Correo";
            this.tipoCorreo.Name = "tipoCorreo";
            this.tipoCorreo.ReadOnly = true;
            this.tipoCorreo.Visible = false;
            // 
            // asunto
            // 
            this.asunto.HeaderText = "Asunto";
            this.asunto.Name = "asunto";
            this.asunto.ReadOnly = true;
            // 
            // cuentaOrigen
            // 
            this.cuentaOrigen.HeaderText = "De";
            this.cuentaOrigen.Name = "cuentaOrigen";
            this.cuentaOrigen.ReadOnly = true;
            // 
            // cuentaDestino
            // 
            this.cuentaDestino.HeaderText = "Para";
            this.cuentaDestino.Name = "cuentaDestino";
            this.cuentaDestino.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 70;
            // 
            // texto
            // 
            this.texto.HeaderText = "Mensaje";
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            this.texto.Visible = false;
            // 
            // leido
            // 
            this.leido.HeaderText = "Leido";
            this.leido.Name = "leido";
            this.leido.ReadOnly = true;
            this.leido.Visible = false;
            // 
            // servicioId
            // 
            this.servicioId.HeaderText = "ServicioId";
            this.servicioId.Name = "servicioId";
            this.servicioId.ReadOnly = true;
            this.servicioId.Visible = false;
            // 
            // eliminado
            // 
            this.eliminado.HeaderText = "Eliminado";
            this.eliminado.Name = "eliminado";
            this.eliminado.ReadOnly = true;
            this.eliminado.Visible = false;
            // 
            // listaRecibidos
            // 
            this.listaRecibidos.AllowUserToAddRows = false;
            this.listaRecibidos.AllowUserToResizeColumns = false;
            this.listaRecibidos.AllowUserToResizeRows = false;
            this.listaRecibidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaRecibidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listaRecibidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.listaRecibidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaRecibidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listaRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaRecibidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correoIdR,
            this.tipoCorreoR,
            this.asuntoR,
            this.cuentaOrigenR,
            this.cuentaDestinoR,
            this.fechaR,
            this.textoR,
            this.leidoR,
            this.servicioIdR,
            this.eliminadoR});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaRecibidos.DefaultCellStyle = dataGridViewCellStyle5;
            this.listaRecibidos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listaRecibidos.Location = new System.Drawing.Point(152, 27);
            this.listaRecibidos.MultiSelect = false;
            this.listaRecibidos.Name = "listaRecibidos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaRecibidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.listaRecibidos.RowHeadersVisible = false;
            this.listaRecibidos.RowHeadersWidth = 20;
            this.listaRecibidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaRecibidos.Size = new System.Drawing.Size(817, 488);
            this.listaRecibidos.TabIndex = 38;
            this.listaRecibidos.TabStop = false;
            this.listaRecibidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaRecibidos_CellDoubleClick);
            this.listaRecibidos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaRecibidos_CellEnter);
            // 
            // correoIdR
            // 
            this.correoIdR.HeaderText = "Correo ID";
            this.correoIdR.Name = "correoIdR";
            this.correoIdR.Visible = false;
            // 
            // tipoCorreoR
            // 
            this.tipoCorreoR.HeaderText = "Tipo Correo";
            this.tipoCorreoR.Name = "tipoCorreoR";
            this.tipoCorreoR.Visible = false;
            // 
            // asuntoR
            // 
            this.asuntoR.HeaderText = "Asunto";
            this.asuntoR.Name = "asuntoR";
            this.asuntoR.ReadOnly = true;
            // 
            // cuentaOrigenR
            // 
            this.cuentaOrigenR.HeaderText = "De";
            this.cuentaOrigenR.Name = "cuentaOrigenR";
            this.cuentaOrigenR.ReadOnly = true;
            // 
            // cuentaDestinoR
            // 
            this.cuentaDestinoR.HeaderText = "Para";
            this.cuentaDestinoR.Name = "cuentaDestinoR";
            // 
            // fechaR
            // 
            this.fechaR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fechaR.HeaderText = "Fecha";
            this.fechaR.Name = "fechaR";
            this.fechaR.ReadOnly = true;
            this.fechaR.Width = 70;
            // 
            // textoR
            // 
            this.textoR.HeaderText = "Mensaje";
            this.textoR.Name = "textoR";
            this.textoR.Visible = false;
            // 
            // leidoR
            // 
            this.leidoR.HeaderText = "Leido";
            this.leidoR.Name = "leidoR";
            this.leidoR.Visible = false;
            // 
            // servicioIdR
            // 
            this.servicioIdR.HeaderText = "ServicioIdR";
            this.servicioIdR.Name = "servicioIdR";
            this.servicioIdR.Visible = false;
            // 
            // eliminadoR
            // 
            this.eliminadoR.HeaderText = "Eliminado";
            this.eliminadoR.Name = "eliminadoR";
            this.eliminadoR.Visible = false;
            // 
            // btEnviados
            // 
            this.btEnviados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btEnviados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnviados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btEnviados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEnviados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEnviados.Location = new System.Drawing.Point(15, 132);
            this.btEnviados.Name = "btEnviados";
            this.btEnviados.Size = new System.Drawing.Size(127, 29);
            this.btEnviados.TabIndex = 3;
            this.btEnviados.Text = "Enviados";
            this.btEnviados.UseVisualStyleBackColor = false;
            this.btEnviados.Visible = false;
            this.btEnviados.Click += new System.EventHandler(this.btEnviados_Click);
            // 
            // btRecibidos
            // 
            this.btRecibidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btRecibidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecibidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btRecibidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecibidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecibidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRecibidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRecibidos.Location = new System.Drawing.Point(15, 160);
            this.btRecibidos.Name = "btRecibidos";
            this.btRecibidos.Size = new System.Drawing.Size(127, 29);
            this.btRecibidos.TabIndex = 4;
            this.btRecibidos.Text = "Recibidos";
            this.btRecibidos.UseVisualStyleBackColor = false;
            this.btRecibidos.Visible = false;
            this.btRecibidos.Click += new System.EventHandler(this.btRecibidos_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminar.Location = new System.Drawing.Point(15, 217);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(127, 29);
            this.btEliminar.TabIndex = 5;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Visible = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btReenviar
            // 
            this.btReenviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btReenviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReenviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btReenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReenviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btReenviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReenviar.Location = new System.Drawing.Point(15, 245);
            this.btReenviar.Name = "btReenviar";
            this.btReenviar.Size = new System.Drawing.Size(127, 29);
            this.btReenviar.TabIndex = 6;
            this.btReenviar.Text = "Reenviar";
            this.btReenviar.UseVisualStyleBackColor = false;
            this.btReenviar.Visible = false;
            this.btReenviar.Click += new System.EventHandler(this.botonReenviar_Click);
            // 
            // btRedactar
            // 
            this.btRedactar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btRedactar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRedactar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRedactar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btRedactar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRedactar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRedactar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRedactar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRedactar.Location = new System.Drawing.Point(15, 79);
            this.btRedactar.Name = "btRedactar";
            this.btRedactar.Size = new System.Drawing.Size(127, 29);
            this.btRedactar.TabIndex = 2;
            this.btRedactar.Text = "Redactar";
            this.btRedactar.UseVisualStyleBackColor = false;
            this.btRedactar.Click += new System.EventHandler(this.btRedactar_Click);
            // 
            // btResponder
            // 
            this.btResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btResponder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btResponder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResponder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btResponder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btResponder.Location = new System.Drawing.Point(15, 273);
            this.btResponder.Name = "btResponder";
            this.btResponder.Size = new System.Drawing.Size(127, 29);
            this.btResponder.TabIndex = 7;
            this.btResponder.Text = "Responder";
            this.btResponder.UseVisualStyleBackColor = false;
            this.btResponder.Visible = false;
            this.btResponder.Click += new System.EventHandler(this.btResponder_Click);
            // 
            // mensajeActualizando
            // 
            this.mensajeActualizando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.mensajeActualizando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mensajeActualizando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeActualizando.ForeColor = System.Drawing.Color.Black;
            this.mensajeActualizando.Location = new System.Drawing.Point(310, 234);
            this.mensajeActualizando.Multiline = true;
            this.mensajeActualizando.Name = "mensajeActualizando";
            this.mensajeActualizando.Size = new System.Drawing.Size(517, 47);
            this.mensajeActualizando.TabIndex = 39;
            this.mensajeActualizando.Text = "\r\nPor favor espere mientras su cuenta es actualizada\r\n\r\n";
            this.mensajeActualizando.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mensajeActualizando.Visible = false;
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btActualizar.Location = new System.Drawing.Point(15, 52);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(127, 29);
            this.btActualizar.TabIndex = 1;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btLeido
            // 
            this.btLeido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btLeido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLeido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btLeido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLeido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLeido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLeido.Location = new System.Drawing.Point(15, 299);
            this.btLeido.Name = "btLeido";
            this.btLeido.Size = new System.Drawing.Size(127, 29);
            this.btLeido.TabIndex = 8;
            this.btLeido.Text = "Leído";
            this.btLeido.UseVisualStyleBackColor = false;
            this.btLeido.Visible = false;
            this.btLeido.Click += new System.EventHandler(this.buttonLeido_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(978, 518);
            this.Controls.Add(this.labelFormato);
            this.Controls.Add(this.btLeido);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.btRedactar);
            this.Controls.Add(this.rbtTextoPlano);
            this.Controls.Add(this.btRecibidos);
            this.Controls.Add(this.rbtEML);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEnviados);
            this.Controls.Add(this.btReenviar);
            this.Controls.Add(this.mensajeActualizando);
            this.Controls.Add(this.btResponder);
            this.Controls.Add(this.listaCuentas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listaEnviados);
            this.Controls.Add(this.panelCorreo);
            this.Controls.Add(this.listaRecibidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de correos ";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCorreo.ResumeLayout(false);
            this.panelCorreo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEnviados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecibidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btRedactar;
        private System.Windows.Forms.Button btReenviar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox correo_texto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox listaCuentas;
        private System.Windows.Forms.Label labelFormato;
        private System.Windows.Forms.RadioButton rbtEML;
        private System.Windows.Forms.RadioButton rbtTextoPlano;
        private System.Windows.Forms.ToolStripMenuItem configuraciónDeCuentasToolStripMenuItem;
        private System.Windows.Forms.Panel panelCorreo;
        private System.Windows.Forms.Label correo_asunto;
        private System.Windows.Forms.Label correo_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btRecibidos;
        private System.Windows.Forms.Button btEnviados;
        private System.Windows.Forms.DataGridView listaRecibidos;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.DataGridView listaEnviados;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.TextBox correo_id;
        private System.Windows.Forms.TextBox correo_tipocorreo;
        private System.Windows.Forms.TextBox correo_servicioid;
        private System.Windows.Forms.TextBox correo_leido;
        private System.Windows.Forms.TextBox correo_cuentaDestino;
        private System.Windows.Forms.TextBox correo_cuentaOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btResponder;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoIdR;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCorreoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaOrigenR;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDestinoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn leidoR;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioIdR;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminadoR;
        private System.Windows.Forms.TextBox correo_eliminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn texto;
        private System.Windows.Forms.DataGridViewTextBoxColumn leido;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminado;
        private System.Windows.Forms.TextBox mensajeActualizando;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btLeido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox correo_Adjuntos;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem2;

    }
}

