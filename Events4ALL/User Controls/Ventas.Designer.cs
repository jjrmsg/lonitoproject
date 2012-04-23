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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.dataGridVentas);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridVentas
            // 
            resources.ApplyResources(this.dataGridVentas, "dataGridVentas");
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVentas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenta,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Importe,
            this.Column5,
            this.Eliminar});
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.ReadOnly = true;
            this.dataGridVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVentas_CellClick);
            // 
            // IdVenta
            // 
            this.IdVenta.FillWeight = 20F;
            resources.ApplyResources(this.IdVenta, "IdVenta");
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.FillWeight = 60F;
            resources.ApplyResources(this.Importe, "Importe");
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 35F;
            resources.ApplyResources(this.Eliminar, "Eliminar");
            this.Eliminar.Image = global::Events4ALL.Properties.Resources.delete;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cbVenta
            // 
            resources.ApplyResources(this.cbVenta, "cbVenta");
            this.cbVenta.Name = "cbVenta";
            this.cbVenta.UseVisualStyleBackColor = true;
            this.cbVenta.CheckedChanged += new System.EventHandler(this.cbVenta_CheckedChanged);
            // 
            // cbEspectaculo
            // 
            resources.ApplyResources(this.cbEspectaculo, "cbEspectaculo");
            this.cbEspectaculo.Name = "cbEspectaculo";
            this.cbEspectaculo.UseVisualStyleBackColor = true;
            this.cbEspectaculo.CheckedChanged += new System.EventHandler(this.cbEspectaculo_CheckedChanged);
            // 
            // dtFechEspectaculo
            // 
            resources.ApplyResources(this.dtFechEspectaculo, "dtFechEspectaculo");
            this.dtFechEspectaculo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechEspectaculo.Name = "dtFechEspectaculo";
            // 
            // dtFechVenta
            // 
            resources.ApplyResources(this.dtFechVenta, "dtFechVenta");
            this.dtFechVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechVenta.Name = "dtFechVenta";
            // 
            // cbTipo
            // 
            resources.ApplyResources(this.cbTipo, "cbTipo");
            this.cbTipo.DisplayMember = "1;2";
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            resources.GetString("cbTipo.Items"),
            resources.GetString("cbTipo.Items1"),
            resources.GetString("cbTipo.Items2")});
            this.cbTipo.Name = "cbTipo";
            // 
            // labelTipo
            // 
            resources.ApplyResources(this.labelTipo, "labelTipo");
            this.labelTipo.Name = "labelTipo";
            // 
            // tbTitulo
            // 
            resources.ApplyResources(this.tbTitulo, "tbTitulo");
            this.tbTitulo.Name = "tbTitulo";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbDni
            // 
            resources.ApplyResources(this.tbDni, "tbDni");
            this.tbDni.Name = "tbDni";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbNombre
            // 
            resources.ApplyResources(this.tbNombre, "tbNombre");
            this.tbNombre.Name = "tbNombre";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btLimpiar
            // 
            resources.ApplyResources(this.btLimpiar, "btLimpiar");
            this.btLimpiar.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btBuscar
            // 
            resources.ApplyResources(this.btBuscar, "btBuscar");
            this.btBuscar.Image = global::Events4ALL.Properties.Resources.search_icon;
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 35F;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::Events4ALL.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Ventas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Ventas";
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
