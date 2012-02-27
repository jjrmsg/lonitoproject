namespace Events4ALL
{
    partial class Clientes
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
            this.FormCliente = new System.Windows.Forms.TabControl();
            this.FichaCliente = new System.Windows.Forms.TabPage();
            this.cliente_Perfil_Foto = new System.Windows.Forms.PictureBox();
            this.datosPersonalesClientes = new System.Windows.Forms.GroupBox();
            this.comboBoxDomiciCli = new System.Windows.Forms.ComboBox();
            this.textBoxDomiciCli = new System.Windows.Forms.TextBox();
            this.labelDomiciCli = new System.Windows.Forms.Label();
            this.textBox2LocaliCli = new System.Windows.Forms.TextBox();
            this.label3LocaliCli = new System.Windows.Forms.Label();
            this.label3CPCli = new System.Windows.Forms.Label();
            this.textBox2CPCli = new System.Windows.Forms.TextBox();
            this.textBoxProvCli = new System.Windows.Forms.TextBox();
            this.labelClienteProv = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Admin_Perfil_numericUpDown_Mes = new System.Windows.Forms.NumericUpDown();
            this.Admin_Perfil_numericUpDown_Ano = new System.Windows.Forms.NumericUpDown();
            this.Admin_Perfil_numericUpDown_Dia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.apellidosCliente = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelNifCliente = new System.Windows.Forms.Label();
            this.textBoxNifC = new System.Windows.Forms.TextBox();
            this.textBoxNombreC = new System.Windows.Forms.TextBox();
            this.BuscarCliente = new System.Windows.Forms.TabPage();
            this.label3SexCli = new System.Windows.Forms.Label();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.Admin_Perfil_rButom_H = new System.Windows.Forms.RadioButton();
            this.Admin_Perfil_rButom_M = new System.Windows.Forms.RadioButton();
            this.FormCliente.SuspendLayout();
            this.FichaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_Perfil_Foto)).BeginInit();
            this.datosPersonalesClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Perfil_numericUpDown_Mes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Perfil_numericUpDown_Ano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Perfil_numericUpDown_Dia)).BeginInit();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormCliente
            // 
            this.FormCliente.AccessibleDescription = "Formulario Cliente";
            this.FormCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FormCliente.Controls.Add(this.FichaCliente);
            this.FormCliente.Controls.Add(this.BuscarCliente);
            this.FormCliente.Location = new System.Drawing.Point(3, 1);
            this.FormCliente.Name = "FormCliente";
            this.FormCliente.SelectedIndex = 0;
            this.FormCliente.Size = new System.Drawing.Size(901, 632);
            this.FormCliente.TabIndex = 1;
            // 
            // FichaCliente
            // 
            this.FichaCliente.AccessibleDescription = "Ficha Cliente";
            this.FichaCliente.Controls.Add(this.cliente_Perfil_Foto);
            this.FichaCliente.Controls.Add(this.datosPersonalesClientes);
            this.FichaCliente.Location = new System.Drawing.Point(4, 22);
            this.FichaCliente.Name = "FichaCliente";
            this.FichaCliente.Padding = new System.Windows.Forms.Padding(3);
            this.FichaCliente.Size = new System.Drawing.Size(893, 606);
            this.FichaCliente.TabIndex = 0;
            this.FichaCliente.Text = "Ficha";
            this.FichaCliente.UseVisualStyleBackColor = true;
            // 
            // cliente_Perfil_Foto
            // 
            this.cliente_Perfil_Foto.Image = global::Events4ALL.Properties.Resources.foto_usuario_defectojpg;
            this.cliente_Perfil_Foto.Location = new System.Drawing.Point(611, 59);
            this.cliente_Perfil_Foto.Name = "cliente_Perfil_Foto";
            this.cliente_Perfil_Foto.Size = new System.Drawing.Size(255, 252);
            this.cliente_Perfil_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cliente_Perfil_Foto.TabIndex = 5;
            this.cliente_Perfil_Foto.TabStop = false;
            this.cliente_Perfil_Foto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // datosPersonalesClientes
            // 
            this.datosPersonalesClientes.Controls.Add(this.groupBoxSexo);
            this.datosPersonalesClientes.Controls.Add(this.label3SexCli);
            this.datosPersonalesClientes.Controls.Add(this.comboBoxDomiciCli);
            this.datosPersonalesClientes.Controls.Add(this.textBoxDomiciCli);
            this.datosPersonalesClientes.Controls.Add(this.labelDomiciCli);
            this.datosPersonalesClientes.Controls.Add(this.textBox2LocaliCli);
            this.datosPersonalesClientes.Controls.Add(this.label3LocaliCli);
            this.datosPersonalesClientes.Controls.Add(this.label3CPCli);
            this.datosPersonalesClientes.Controls.Add(this.textBox2CPCli);
            this.datosPersonalesClientes.Controls.Add(this.textBoxProvCli);
            this.datosPersonalesClientes.Controls.Add(this.labelClienteProv);
            this.datosPersonalesClientes.Controls.Add(this.comboBox1);
            this.datosPersonalesClientes.Controls.Add(this.label2);
            this.datosPersonalesClientes.Controls.Add(this.Admin_Perfil_numericUpDown_Mes);
            this.datosPersonalesClientes.Controls.Add(this.Admin_Perfil_numericUpDown_Ano);
            this.datosPersonalesClientes.Controls.Add(this.Admin_Perfil_numericUpDown_Dia);
            this.datosPersonalesClientes.Controls.Add(this.label1);
            this.datosPersonalesClientes.Controls.Add(this.textBox1);
            this.datosPersonalesClientes.Controls.Add(this.apellidosCliente);
            this.datosPersonalesClientes.Controls.Add(this.labelNombreCliente);
            this.datosPersonalesClientes.Controls.Add(this.labelNifCliente);
            this.datosPersonalesClientes.Controls.Add(this.textBoxNifC);
            this.datosPersonalesClientes.Controls.Add(this.textBoxNombreC);
            this.datosPersonalesClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosPersonalesClientes.Location = new System.Drawing.Point(42, 59);
            this.datosPersonalesClientes.Name = "datosPersonalesClientes";
            this.datosPersonalesClientes.Size = new System.Drawing.Size(545, 383);
            this.datosPersonalesClientes.TabIndex = 4;
            this.datosPersonalesClientes.TabStop = false;
            this.datosPersonalesClientes.Text = "Datos Personales";
            this.datosPersonalesClientes.Enter += new System.EventHandler(this.datosPersonalesClientes_Enter);
            // 
            // comboBoxDomiciCli
            // 
            this.comboBoxDomiciCli.FormattingEnabled = true;
            this.comboBoxDomiciCli.Location = new System.Drawing.Point(34, 226);
            this.comboBoxDomiciCli.Name = "comboBoxDomiciCli";
            this.comboBoxDomiciCli.Size = new System.Drawing.Size(67, 28);
            this.comboBoxDomiciCli.TabIndex = 70;
            // 
            // textBoxDomiciCli
            // 
            this.textBoxDomiciCli.Location = new System.Drawing.Point(107, 228);
            this.textBoxDomiciCli.Name = "textBoxDomiciCli";
            this.textBoxDomiciCli.Size = new System.Drawing.Size(403, 26);
            this.textBoxDomiciCli.TabIndex = 69;
            // 
            // labelDomiciCli
            // 
            this.labelDomiciCli.AutoSize = true;
            this.labelDomiciCli.Location = new System.Drawing.Point(30, 205);
            this.labelDomiciCli.Name = "labelDomiciCli";
            this.labelDomiciCli.Size = new System.Drawing.Size(72, 20);
            this.labelDomiciCli.TabIndex = 68;
            this.labelDomiciCli.Text = "Domicilio";
            // 
            // textBox2LocaliCli
            // 
            this.textBox2LocaliCli.Location = new System.Drawing.Point(314, 170);
            this.textBox2LocaliCli.Name = "textBox2LocaliCli";
            this.textBox2LocaliCli.Size = new System.Drawing.Size(196, 26);
            this.textBox2LocaliCli.TabIndex = 67;
            // 
            // label3LocaliCli
            // 
            this.label3LocaliCli.AutoSize = true;
            this.label3LocaliCli.Location = new System.Drawing.Point(310, 147);
            this.label3LocaliCli.Name = "label3LocaliCli";
            this.label3LocaliCli.Size = new System.Drawing.Size(77, 20);
            this.label3LocaliCli.TabIndex = 66;
            this.label3LocaliCli.Text = "Localidad";
            // 
            // label3CPCli
            // 
            this.label3CPCli.AutoSize = true;
            this.label3CPCli.Location = new System.Drawing.Point(238, 147);
            this.label3CPCli.Name = "label3CPCli";
            this.label3CPCli.Size = new System.Drawing.Size(30, 20);
            this.label3CPCli.TabIndex = 65;
            this.label3CPCli.Text = "CP";
            // 
            // textBox2CPCli
            // 
            this.textBox2CPCli.Location = new System.Drawing.Point(242, 170);
            this.textBox2CPCli.Name = "textBox2CPCli";
            this.textBox2CPCli.Size = new System.Drawing.Size(51, 26);
            this.textBox2CPCli.TabIndex = 64;
            // 
            // textBoxProvCli
            // 
            this.textBoxProvCli.Location = new System.Drawing.Point(34, 170);
            this.textBoxProvCli.Name = "textBoxProvCli";
            this.textBoxProvCli.Size = new System.Drawing.Size(178, 26);
            this.textBoxProvCli.TabIndex = 60;
            // 
            // labelClienteProv
            // 
            this.labelClienteProv.AutoSize = true;
            this.labelClienteProv.Location = new System.Drawing.Point(30, 147);
            this.labelClienteProv.Name = "labelClienteProv";
            this.labelClienteProv.Size = new System.Drawing.Size(72, 20);
            this.labelClienteProv.TabIndex = 63;
            this.labelClienteProv.Text = "Provincia";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(314, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 28);
            this.comboBox1.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "País";
            // 
            // Admin_Perfil_numericUpDown_Mes
            // 
            this.Admin_Perfil_numericUpDown_Mes.Location = new System.Drawing.Point(176, 113);
            this.Admin_Perfil_numericUpDown_Mes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Admin_Perfil_numericUpDown_Mes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Admin_Perfil_numericUpDown_Mes.Name = "Admin_Perfil_numericUpDown_Mes";
            this.Admin_Perfil_numericUpDown_Mes.Size = new System.Drawing.Size(36, 26);
            this.Admin_Perfil_numericUpDown_Mes.TabIndex = 60;
            this.Admin_Perfil_numericUpDown_Mes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Admin_Perfil_numericUpDown_Ano
            // 
            this.Admin_Perfil_numericUpDown_Ano.Location = new System.Drawing.Point(218, 113);
            this.Admin_Perfil_numericUpDown_Ano.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.Admin_Perfil_numericUpDown_Ano.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Admin_Perfil_numericUpDown_Ano.Name = "Admin_Perfil_numericUpDown_Ano";
            this.Admin_Perfil_numericUpDown_Ano.Size = new System.Drawing.Size(71, 26);
            this.Admin_Perfil_numericUpDown_Ano.TabIndex = 59;
            this.Admin_Perfil_numericUpDown_Ano.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // Admin_Perfil_numericUpDown_Dia
            // 
            this.Admin_Perfil_numericUpDown_Dia.Location = new System.Drawing.Point(134, 113);
            this.Admin_Perfil_numericUpDown_Dia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Admin_Perfil_numericUpDown_Dia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Admin_Perfil_numericUpDown_Dia.Name = "Admin_Perfil_numericUpDown_Dia";
            this.Admin_Perfil_numericUpDown_Dia.Size = new System.Drawing.Size(36, 26);
            this.Admin_Perfil_numericUpDown_Dia.TabIndex = 58;
            this.Admin_Perfil_numericUpDown_Dia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 26);
            this.textBox1.TabIndex = 4;
            // 
            // apellidosCliente
            // 
            this.apellidosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosCliente.Location = new System.Drawing.Point(296, 31);
            this.apellidosCliente.Name = "apellidosCliente";
            this.apellidosCliente.Size = new System.Drawing.Size(81, 20);
            this.apellidosCliente.TabIndex = 2;
            this.apellidosCliente.Text = "Apellidos";
            this.apellidosCliente.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Location = new System.Drawing.Point(30, 31);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(65, 20);
            this.labelNombreCliente.TabIndex = 0;
            this.labelNombreCliente.Text = "Nombre";
            this.labelNombreCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNifCliente
            // 
            this.labelNifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifCliente.Location = new System.Drawing.Point(30, 90);
            this.labelNifCliente.Name = "labelNifCliente";
            this.labelNifCliente.Size = new System.Drawing.Size(35, 20);
            this.labelNifCliente.TabIndex = 2;
            this.labelNifCliente.Text = "NIF";
            // 
            // textBoxNifC
            // 
            this.textBoxNifC.Location = new System.Drawing.Point(35, 113);
            this.textBoxNifC.Name = "textBoxNifC";
            this.textBoxNifC.Size = new System.Drawing.Size(75, 26);
            this.textBoxNifC.TabIndex = 3;
            // 
            // textBoxNombreC
            // 
            this.textBoxNombreC.Location = new System.Drawing.Point(34, 54);
            this.textBoxNombreC.Name = "textBoxNombreC";
            this.textBoxNombreC.Size = new System.Drawing.Size(255, 26);
            this.textBoxNombreC.TabIndex = 1;
            this.textBoxNombreC.TextChanged += new System.EventHandler(this.textBoxNombreC_TextChanged);
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.AccessibleDescription = "Buscar Cliente";
            this.BuscarCliente.Location = new System.Drawing.Point(4, 22);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.BuscarCliente.Size = new System.Drawing.Size(893, 606);
            this.BuscarCliente.TabIndex = 1;
            this.BuscarCliente.Text = "Busqueda";
            this.BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // label3SexCli
            // 
            this.label3SexCli.AutoSize = true;
            this.label3SexCli.Location = new System.Drawing.Point(30, 261);
            this.label3SexCli.Name = "label3SexCli";
            this.label3SexCli.Size = new System.Drawing.Size(45, 20);
            this.label3SexCli.TabIndex = 71;
            this.label3SexCli.Text = "Sexo";
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.Admin_Perfil_rButom_H);
            this.groupBoxSexo.Controls.Add(this.Admin_Perfil_rButom_M);
            this.groupBoxSexo.Location = new System.Drawing.Point(35, 284);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(83, 76);
            this.groupBoxSexo.TabIndex = 76;
            this.groupBoxSexo.TabStop = false;
            // 
            // Admin_Perfil_rButom_H
            // 
            this.Admin_Perfil_rButom_H.AutoSize = true;
            this.Admin_Perfil_rButom_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Perfil_rButom_H.Location = new System.Drawing.Point(11, 19);
            this.Admin_Perfil_rButom_H.Name = "Admin_Perfil_rButom_H";
            this.Admin_Perfil_rButom_H.Size = new System.Drawing.Size(70, 19);
            this.Admin_Perfil_rButom_H.TabIndex = 30;
            this.Admin_Perfil_rButom_H.TabStop = true;
            this.Admin_Perfil_rButom_H.Text = "Hombre";
            this.Admin_Perfil_rButom_H.UseVisualStyleBackColor = true;
            // 
            // Admin_Perfil_rButom_M
            // 
            this.Admin_Perfil_rButom_M.AutoSize = true;
            this.Admin_Perfil_rButom_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Perfil_rButom_M.Location = new System.Drawing.Point(11, 45);
            this.Admin_Perfil_rButom_M.Name = "Admin_Perfil_rButom_M";
            this.Admin_Perfil_rButom_M.Size = new System.Drawing.Size(57, 19);
            this.Admin_Perfil_rButom_M.TabIndex = 31;
            this.Admin_Perfil_rButom_M.TabStop = true;
            this.Admin_Perfil_rButom_M.Text = "Mujer";
            this.Admin_Perfil_rButom_M.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FormCliente);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(907, 635);
            this.FormCliente.ResumeLayout(false);
            this.FichaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cliente_Perfil_Foto)).EndInit();
            this.datosPersonalesClientes.ResumeLayout(false);
            this.datosPersonalesClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Perfil_numericUpDown_Mes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Perfil_numericUpDown_Ano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Perfil_numericUpDown_Dia)).EndInit();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FormCliente;
        private System.Windows.Forms.TabPage FichaCliente;
        private System.Windows.Forms.TabPage BuscarCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox textBoxNombreC;
        private System.Windows.Forms.TextBox textBoxNifC;
        private System.Windows.Forms.Label labelNifCliente;
        private System.Windows.Forms.GroupBox datosPersonalesClientes;
        private System.Windows.Forms.PictureBox cliente_Perfil_Foto;
        private System.Windows.Forms.Label apellidosCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Admin_Perfil_numericUpDown_Mes;
        private System.Windows.Forms.NumericUpDown Admin_Perfil_numericUpDown_Ano;
        private System.Windows.Forms.NumericUpDown Admin_Perfil_numericUpDown_Dia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelClienteProv;
        private System.Windows.Forms.TextBox textBoxProvCli;
        private System.Windows.Forms.Label label3CPCli;
        private System.Windows.Forms.TextBox textBox2CPCli;
        private System.Windows.Forms.Label label3LocaliCli;
        private System.Windows.Forms.TextBox textBox2LocaliCli;
        private System.Windows.Forms.ComboBox comboBoxDomiciCli;
        private System.Windows.Forms.TextBox textBoxDomiciCli;
        private System.Windows.Forms.Label labelDomiciCli;
        private System.Windows.Forms.Label label3SexCli;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton Admin_Perfil_rButom_H;
        private System.Windows.Forms.RadioButton Admin_Perfil_rButom_M;
    }
}
