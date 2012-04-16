namespace Events4ALL
{
    partial class Ventas
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbVenta = new System.Windows.Forms.CheckBox();
            this.cbEspectaculo = new System.Windows.Forms.CheckBox();
            this.dtFechEspectaculo = new System.Windows.Forms.DateTimePicker();
            this.dtFechVenta = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 632);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridVentas);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Búsqueda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVentas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenta,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Eliminar});
            this.dataGridVentas.Location = new System.Drawing.Point(6, 175);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.ReadOnly = true;
            this.dataGridVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVentas.Size = new System.Drawing.Size(878, 425);
            this.dataGridVentas.TabIndex = 8;
            this.dataGridVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVentas_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbVenta);
            this.groupBox1.Controls.Add(this.cbEspectaculo);
            this.groupBox1.Controls.Add(this.dtFechEspectaculo);
            this.groupBox1.Controls.Add(this.dtFechVenta);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.labelTipo);
            this.groupBox1.Controls.Add(this.tbTitulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de ventas";
            // 
            // cbVenta
            // 
            this.cbVenta.AutoSize = true;
            this.cbVenta.Location = new System.Drawing.Point(20, 112);
            this.cbVenta.Name = "cbVenta";
            this.cbVenta.Size = new System.Drawing.Size(101, 17);
            this.cbVenta.TabIndex = 68;
            this.cbVenta.Text = "Fecha de venta";
            this.cbVenta.UseVisualStyleBackColor = true;
            this.cbVenta.CheckedChanged += new System.EventHandler(this.cbVenta_CheckedChanged);
            // 
            // cbEspectaculo
            // 
            this.cbEspectaculo.AutoSize = true;
            this.cbEspectaculo.Location = new System.Drawing.Point(521, 73);
            this.cbEspectaculo.Name = "cbEspectaculo";
            this.cbEspectaculo.Size = new System.Drawing.Size(134, 17);
            this.cbEspectaculo.TabIndex = 67;
            this.cbEspectaculo.Text = "Fecha del espectáculo";
            this.cbEspectaculo.UseVisualStyleBackColor = true;
            this.cbEspectaculo.CheckedChanged += new System.EventHandler(this.cbEspectaculo_CheckedChanged);
            // 
            // dtFechEspectaculo
            // 
            this.dtFechEspectaculo.Enabled = false;
            this.dtFechEspectaculo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechEspectaculo.Location = new System.Drawing.Point(661, 71);
            this.dtFechEspectaculo.Name = "dtFechEspectaculo";
            this.dtFechEspectaculo.Size = new System.Drawing.Size(92, 20);
            this.dtFechEspectaculo.TabIndex = 66;
            // 
            // dtFechVenta
            // 
            this.dtFechVenta.Enabled = false;
            this.dtFechVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechVenta.Location = new System.Drawing.Point(127, 109);
            this.dtFechVenta.Name = "dtFechVenta";
            this.dtFechVenta.Size = new System.Drawing.Size(92, 20);
            this.dtFechVenta.TabIndex = 64;
            // 
            // cbTipo
            // 
            this.cbTipo.DisplayMember = "1;2";
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Cine",
            "Teatro",
            "Concierto"});
            this.cbTipo.Location = new System.Drawing.Point(431, 71);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(77, 21);
            this.cbTipo.TabIndex = 62;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(321, 74);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(104, 13);
            this.labelTipo.TabIndex = 61;
            this.labelTipo.Text = "Tipo de espectáculo";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(119, 71);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(186, 20);
            this.tbTitulo.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Título espectáculo";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(324, 35);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(108, 20);
            this.tbDni.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Dni cliente";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(119, 35);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(131, 20);
            this.tbNombre.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nombre cliente";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.btLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpiar.Location = new System.Drawing.Point(738, 122);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(64, 23);
            this.btLimpiar.TabIndex = 52;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Image = global::Events4ALL.Properties.Resources.search_icon;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(808, 122);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(64, 23);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // IdVenta
            // 
            this.IdVenta.FillWeight = 20F;
            this.IdVenta.HeaderText = "Id";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DNI";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Título espectaculo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha de venta";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 30F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Events4ALL.Properties.Resources.delete;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(907, 635);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dtFechEspectaculo;
        private System.Windows.Forms.DateTimePicker dtFechVenta;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label labelTipo;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.CheckBox cbVenta;
        private System.Windows.Forms.CheckBox cbEspectaculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
