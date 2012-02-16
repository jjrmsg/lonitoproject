namespace Events4ALL
{
    partial class Promociones
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
            this.tabControl_promociones = new System.Windows.Forms.TabControl();
            this.tab_Por_espectaculo = new System.Windows.Forms.TabPage();
            this.label_PE_PpE = new System.Windows.Forms.Label();
            this.tab_Por_cliente = new System.Windows.Forms.TabPage();
            this.tab_Mediante_condiciones = new System.Windows.Forms.TabPage();
            this.comboBox_PE_espectaculo = new System.Windows.Forms.ComboBox();
            this.label_PE_Espectaculo = new System.Windows.Forms.Label();
            this.dateTimePicker_PE_fecha = new System.Windows.Forms.DateTimePicker();
            this.label_PE_Fecha = new System.Windows.Forms.Label();
            this.label_PC_PpC = new System.Windows.Forms.Label();
            this.comboBox_PC_cliente = new System.Windows.Forms.ComboBox();
            this.label_PC_Cliente = new System.Windows.Forms.Label();
            this.dataGridView_PE_promoClientes = new System.Windows.Forms.DataGridView();
            this.tabControl_promociones.SuspendLayout();
            this.tab_Por_espectaculo.SuspendLayout();
            this.tab_Por_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PE_promoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_promociones
            // 
            this.tabControl_promociones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_promociones.Controls.Add(this.tab_Por_espectaculo);
            this.tabControl_promociones.Controls.Add(this.tab_Por_cliente);
            this.tabControl_promociones.Controls.Add(this.tab_Mediante_condiciones);
            this.tabControl_promociones.Location = new System.Drawing.Point(3, 1);
            this.tabControl_promociones.Name = "tabControl_promociones";
            this.tabControl_promociones.SelectedIndex = 0;
            this.tabControl_promociones.Size = new System.Drawing.Size(901, 632);
            this.tabControl_promociones.TabIndex = 1;
            // 
            // tab_Por_espectaculo
            // 
            this.tab_Por_espectaculo.Controls.Add(this.label_PE_Fecha);
            this.tab_Por_espectaculo.Controls.Add(this.dateTimePicker_PE_fecha);
            this.tab_Por_espectaculo.Controls.Add(this.label_PE_Espectaculo);
            this.tab_Por_espectaculo.Controls.Add(this.comboBox_PE_espectaculo);
            this.tab_Por_espectaculo.Controls.Add(this.label_PE_PpE);
            this.tab_Por_espectaculo.Location = new System.Drawing.Point(4, 22);
            this.tab_Por_espectaculo.Name = "tab_Por_espectaculo";
            this.tab_Por_espectaculo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Por_espectaculo.Size = new System.Drawing.Size(893, 606);
            this.tab_Por_espectaculo.TabIndex = 0;
            this.tab_Por_espectaculo.Text = "Por_espectaculo";
            this.tab_Por_espectaculo.UseVisualStyleBackColor = true;
            // 
            // label_PE_PpE
            // 
            this.label_PE_PpE.AutoSize = true;
            this.label_PE_PpE.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_PpE.Location = new System.Drawing.Point(95, 15);
            this.label_PE_PpE.Name = "label_PE_PpE";
            this.label_PE_PpE.Size = new System.Drawing.Size(685, 55);
            this.label_PE_PpE.TabIndex = 2;
            this.label_PE_PpE.Text = "Promociones por espectaculo";
            this.label_PE_PpE.Click += new System.EventHandler(this.label1_Click);
            // 
            // tab_Por_cliente
            // 
            this.tab_Por_cliente.Controls.Add(this.dataGridView_PE_promoClientes);
            this.tab_Por_cliente.Controls.Add(this.label_PC_Cliente);
            this.tab_Por_cliente.Controls.Add(this.comboBox_PC_cliente);
            this.tab_Por_cliente.Controls.Add(this.label_PC_PpC);
            this.tab_Por_cliente.Location = new System.Drawing.Point(4, 22);
            this.tab_Por_cliente.Name = "tab_Por_cliente";
            this.tab_Por_cliente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Por_cliente.Size = new System.Drawing.Size(893, 606);
            this.tab_Por_cliente.TabIndex = 1;
            this.tab_Por_cliente.Text = "Por_cliente";
            this.tab_Por_cliente.UseVisualStyleBackColor = true;
            // 
            // tab_Mediante_condiciones
            // 
            this.tab_Mediante_condiciones.Location = new System.Drawing.Point(4, 22);
            this.tab_Mediante_condiciones.Name = "tab_Mediante_condiciones";
            this.tab_Mediante_condiciones.Size = new System.Drawing.Size(893, 606);
            this.tab_Mediante_condiciones.TabIndex = 2;
            this.tab_Mediante_condiciones.Text = "Mediante_condiciones";
            this.tab_Mediante_condiciones.UseVisualStyleBackColor = true;
            // 
            // comboBox_PE_espectaculo
            // 
            this.comboBox_PE_espectaculo.FormattingEnabled = true;
            this.comboBox_PE_espectaculo.Location = new System.Drawing.Point(177, 92);
            this.comboBox_PE_espectaculo.Name = "comboBox_PE_espectaculo";
            this.comboBox_PE_espectaculo.Size = new System.Drawing.Size(228, 21);
            this.comboBox_PE_espectaculo.TabIndex = 3;
            this.comboBox_PE_espectaculo.Text = "Seleccionar espectaculo ...";
            // 
            // label_PE_Espectaculo
            // 
            this.label_PE_Espectaculo.AutoSize = true;
            this.label_PE_Espectaculo.Location = new System.Drawing.Point(102, 92);
            this.label_PE_Espectaculo.Name = "label_PE_Espectaculo";
            this.label_PE_Espectaculo.Size = new System.Drawing.Size(69, 13);
            this.label_PE_Espectaculo.TabIndex = 4;
            this.label_PE_Espectaculo.Text = "Espectaculo:";
            this.label_PE_Espectaculo.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker_PE_fecha
            // 
            this.dateTimePicker_PE_fecha.Location = new System.Drawing.Point(177, 139);
            this.dateTimePicker_PE_fecha.Name = "dateTimePicker_PE_fecha";
            this.dateTimePicker_PE_fecha.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker_PE_fecha.TabIndex = 5;
            // 
            // label_PE_Fecha
            // 
            this.label_PE_Fecha.AutoSize = true;
            this.label_PE_Fecha.Location = new System.Drawing.Point(102, 145);
            this.label_PE_Fecha.Name = "label_PE_Fecha";
            this.label_PE_Fecha.Size = new System.Drawing.Size(40, 13);
            this.label_PE_Fecha.TabIndex = 6;
            this.label_PE_Fecha.Text = "Fecha:";
            // 
            // label_PC_PpC
            // 
            this.label_PC_PpC.AutoSize = true;
            this.label_PC_PpC.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PC_PpC.Location = new System.Drawing.Point(106, 21);
            this.label_PC_PpC.Name = "label_PC_PpC";
            this.label_PC_PpC.Size = new System.Drawing.Size(539, 55);
            this.label_PC_PpC.TabIndex = 0;
            this.label_PC_PpC.Text = "Promociones por cliente";
            // 
            // comboBox_PC_cliente
            // 
            this.comboBox_PC_cliente.FormattingEnabled = true;
            this.comboBox_PC_cliente.Location = new System.Drawing.Point(200, 97);
            this.comboBox_PC_cliente.Name = "comboBox_PC_cliente";
            this.comboBox_PC_cliente.Size = new System.Drawing.Size(210, 21);
            this.comboBox_PC_cliente.TabIndex = 1;
            this.comboBox_PC_cliente.Text = "Seleccionar cliente ...";
            // 
            // label_PC_Cliente
            // 
            this.label_PC_Cliente.AutoSize = true;
            this.label_PC_Cliente.Location = new System.Drawing.Point(113, 97);
            this.label_PC_Cliente.Name = "label_PC_Cliente";
            this.label_PC_Cliente.Size = new System.Drawing.Size(42, 13);
            this.label_PC_Cliente.TabIndex = 2;
            this.label_PC_Cliente.Text = "Cliente:";
            this.label_PC_Cliente.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataGridView_PE_promoClientes
            // 
            this.dataGridView_PE_promoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PE_promoClientes.Location = new System.Drawing.Point(116, 143);
            this.dataGridView_PE_promoClientes.Name = "dataGridView_PE_promoClientes";
            this.dataGridView_PE_promoClientes.Size = new System.Drawing.Size(529, 134);
            this.dataGridView_PE_promoClientes.TabIndex = 3;
            // 
            // Promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_promociones);
            this.Name = "Promociones";
            this.Size = new System.Drawing.Size(907, 635);
            this.tabControl_promociones.ResumeLayout(false);
            this.tab_Por_espectaculo.ResumeLayout(false);
            this.tab_Por_espectaculo.PerformLayout();
            this.tab_Por_cliente.ResumeLayout(false);
            this.tab_Por_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PE_promoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_promociones;
        private System.Windows.Forms.TabPage tab_Por_espectaculo;
        private System.Windows.Forms.TabPage tab_Por_cliente;
        private System.Windows.Forms.Label label_PE_PpE;
        private System.Windows.Forms.TabPage tab_Mediante_condiciones;
        private System.Windows.Forms.Label label_PE_Espectaculo;
        private System.Windows.Forms.ComboBox comboBox_PE_espectaculo;
        private System.Windows.Forms.Label label_PE_Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PE_fecha;
        private System.Windows.Forms.Label label_PC_PpC;
        private System.Windows.Forms.Label label_PC_Cliente;
        private System.Windows.Forms.ComboBox comboBox_PC_cliente;
        private System.Windows.Forms.DataGridView dataGridView_PE_promoClientes;
    }
}
