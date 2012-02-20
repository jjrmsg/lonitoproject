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
            this.label_PE_Espectaculo = new System.Windows.Forms.Label();
            this.comboBox_PE_espectaculo = new System.Windows.Forms.ComboBox();
            this.tab_Por_cliente = new System.Windows.Forms.TabPage();
            this.dataGridView_PE_promoClientes = new System.Windows.Forms.DataGridView();
            this.PC_FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_POBLACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_LUGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_PC_Cliente = new System.Windows.Forms.Label();
            this.comboBox_PC_cliente = new System.Windows.Forms.ComboBox();
            this.label_PC_Titulo = new System.Windows.Forms.Label();
            this.tab_Mediante_condiciones = new System.Windows.Forms.TabPage();
            this.button_MC_eliminarC = new System.Windows.Forms.Button();
            this.button_MC_modificarC = new System.Windows.Forms.Button();
            this.button_MC_agregarC = new System.Windows.Forms.Button();
            this.label_MC_ClientesAfectados = new System.Windows.Forms.Label();
            this.dataGridView_MC_ClientesAfectados = new System.Windows.Forms.DataGridView();
            this.MC_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_PE_Datos = new System.Windows.Forms.GroupBox();
            this.label_PE_titulo = new System.Windows.Forms.Label();
            this.label_PE_fecha = new System.Windows.Forms.Label();
            this.label_PE_hora = new System.Windows.Forms.Label();
            this.label_PE_poblacion = new System.Windows.Forms.Label();
            this.label_PE_provincia = new System.Windows.Forms.Label();
            this.label_PE_lugar = new System.Windows.Forms.Label();
            this.label_PE_Ctitulo = new System.Windows.Forms.Label();
            this.label_PE_Cfecha = new System.Windows.Forms.Label();
            this.label_PE_Chora = new System.Windows.Forms.Label();
            this.label_PE_Cpoblacion = new System.Windows.Forms.Label();
            this.label_PE_Cprovincia = new System.Windows.Forms.Label();
            this.label_PE_Clugar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl_promociones.SuspendLayout();
            this.tab_Por_espectaculo.SuspendLayout();
            this.tab_Por_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PE_promoClientes)).BeginInit();
            this.tab_Mediante_condiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MC_ClientesAfectados)).BeginInit();
            this.groupBox_PE_Datos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tab_Por_espectaculo.Controls.Add(this.groupBox2);
            this.tab_Por_espectaculo.Controls.Add(this.groupBox1);
            this.tab_Por_espectaculo.Controls.Add(this.groupBox_PE_Datos);
            this.tab_Por_espectaculo.Controls.Add(this.label_PE_Espectaculo);
            this.tab_Por_espectaculo.Controls.Add(this.comboBox_PE_espectaculo);
            this.tab_Por_espectaculo.Location = new System.Drawing.Point(4, 22);
            this.tab_Por_espectaculo.Name = "tab_Por_espectaculo";
            this.tab_Por_espectaculo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Por_espectaculo.Size = new System.Drawing.Size(893, 606);
            this.tab_Por_espectaculo.TabIndex = 0;
            this.tab_Por_espectaculo.Text = "Por espectaculo";
            this.tab_Por_espectaculo.UseVisualStyleBackColor = true;
            // 
            // label_PE_Espectaculo
            // 
            this.label_PE_Espectaculo.AutoSize = true;
            this.label_PE_Espectaculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Espectaculo.Location = new System.Drawing.Point(6, 15);
            this.label_PE_Espectaculo.Name = "label_PE_Espectaculo";
            this.label_PE_Espectaculo.Size = new System.Drawing.Size(81, 13);
            this.label_PE_Espectaculo.TabIndex = 4;
            this.label_PE_Espectaculo.Text = "Espectaculo:";
            this.label_PE_Espectaculo.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_PE_espectaculo
            // 
            this.comboBox_PE_espectaculo.FormattingEnabled = true;
            this.comboBox_PE_espectaculo.Location = new System.Drawing.Point(93, 12);
            this.comboBox_PE_espectaculo.Name = "comboBox_PE_espectaculo";
            this.comboBox_PE_espectaculo.Size = new System.Drawing.Size(251, 21);
            this.comboBox_PE_espectaculo.TabIndex = 3;
            this.comboBox_PE_espectaculo.Text = "Seleccionar espectaculo ...";
            // 
            // tab_Por_cliente
            // 
            this.tab_Por_cliente.Controls.Add(this.dataGridView_PE_promoClientes);
            this.tab_Por_cliente.Controls.Add(this.label_PC_Cliente);
            this.tab_Por_cliente.Controls.Add(this.comboBox_PC_cliente);
            this.tab_Por_cliente.Controls.Add(this.label_PC_Titulo);
            this.tab_Por_cliente.Location = new System.Drawing.Point(4, 22);
            this.tab_Por_cliente.Name = "tab_Por_cliente";
            this.tab_Por_cliente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Por_cliente.Size = new System.Drawing.Size(893, 606);
            this.tab_Por_cliente.TabIndex = 1;
            this.tab_Por_cliente.Text = "Por cliente";
            this.tab_Por_cliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView_PE_promoClientes
            // 
            this.dataGridView_PE_promoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PE_promoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PC_FECHA,
            this.PC_HORA,
            this.PC_POBLACION,
            this.PC_PROVINCIA,
            this.PC_LUGAR,
            this.PC_DESCUENTO,
            this.PC_DESCRIPCION});
            this.dataGridView_PE_promoClientes.Location = new System.Drawing.Point(6, 124);
            this.dataGridView_PE_promoClientes.Name = "dataGridView_PE_promoClientes";
            this.dataGridView_PE_promoClientes.Size = new System.Drawing.Size(881, 476);
            this.dataGridView_PE_promoClientes.TabIndex = 3;
            // 
            // PC_FECHA
            // 
            this.PC_FECHA.HeaderText = "FECHA";
            this.PC_FECHA.Name = "PC_FECHA";
            // 
            // PC_HORA
            // 
            this.PC_HORA.HeaderText = "HORA";
            this.PC_HORA.Name = "PC_HORA";
            // 
            // PC_POBLACION
            // 
            this.PC_POBLACION.HeaderText = "POBLACION";
            this.PC_POBLACION.Name = "PC_POBLACION";
            // 
            // PC_PROVINCIA
            // 
            this.PC_PROVINCIA.HeaderText = "PROVINCIA";
            this.PC_PROVINCIA.Name = "PC_PROVINCIA";
            // 
            // PC_LUGAR
            // 
            this.PC_LUGAR.HeaderText = "LUGAR";
            this.PC_LUGAR.Name = "PC_LUGAR";
            // 
            // PC_DESCUENTO
            // 
            this.PC_DESCUENTO.HeaderText = "DESCUENTO";
            this.PC_DESCUENTO.Name = "PC_DESCUENTO";
            // 
            // PC_DESCRIPCION
            // 
            this.PC_DESCRIPCION.HeaderText = "DESCRIPCION";
            this.PC_DESCRIPCION.Name = "PC_DESCRIPCION";
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
            // comboBox_PC_cliente
            // 
            this.comboBox_PC_cliente.FormattingEnabled = true;
            this.comboBox_PC_cliente.Location = new System.Drawing.Point(200, 97);
            this.comboBox_PC_cliente.Name = "comboBox_PC_cliente";
            this.comboBox_PC_cliente.Size = new System.Drawing.Size(210, 21);
            this.comboBox_PC_cliente.TabIndex = 1;
            this.comboBox_PC_cliente.Text = "Seleccionar cliente ...";
            // 
            // label_PC_Titulo
            // 
            this.label_PC_Titulo.AutoSize = true;
            this.label_PC_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PC_Titulo.Location = new System.Drawing.Point(106, 21);
            this.label_PC_Titulo.Name = "label_PC_Titulo";
            this.label_PC_Titulo.Size = new System.Drawing.Size(562, 55);
            this.label_PC_Titulo.TabIndex = 0;
            this.label_PC_Titulo.Text = "Promociones por cliente";
            // 
            // tab_Mediante_condiciones
            // 
            this.tab_Mediante_condiciones.Controls.Add(this.textBox2);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_eliminarC);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_modificarC);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_agregarC);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_ClientesAfectados);
            this.tab_Mediante_condiciones.Controls.Add(this.dataGridView_MC_ClientesAfectados);
            this.tab_Mediante_condiciones.Location = new System.Drawing.Point(4, 22);
            this.tab_Mediante_condiciones.Name = "tab_Mediante_condiciones";
            this.tab_Mediante_condiciones.Size = new System.Drawing.Size(893, 606);
            this.tab_Mediante_condiciones.TabIndex = 2;
            this.tab_Mediante_condiciones.Text = "Mediante condiciones";
            this.tab_Mediante_condiciones.UseVisualStyleBackColor = true;
            // 
            // button_MC_eliminarC
            // 
            this.button_MC_eliminarC.Location = new System.Drawing.Point(756, 185);
            this.button_MC_eliminarC.Name = "button_MC_eliminarC";
            this.button_MC_eliminarC.Size = new System.Drawing.Size(134, 23);
            this.button_MC_eliminarC.TabIndex = 11;
            this.button_MC_eliminarC.Text = "Eliminar";
            this.button_MC_eliminarC.UseVisualStyleBackColor = true;
            // 
            // button_MC_modificarC
            // 
            this.button_MC_modificarC.Location = new System.Drawing.Point(598, 185);
            this.button_MC_modificarC.Name = "button_MC_modificarC";
            this.button_MC_modificarC.Size = new System.Drawing.Size(134, 23);
            this.button_MC_modificarC.TabIndex = 10;
            this.button_MC_modificarC.Text = "Modificar";
            this.button_MC_modificarC.UseVisualStyleBackColor = true;
            // 
            // button_MC_agregarC
            // 
            this.button_MC_agregarC.Location = new System.Drawing.Point(448, 185);
            this.button_MC_agregarC.Name = "button_MC_agregarC";
            this.button_MC_agregarC.Size = new System.Drawing.Size(134, 23);
            this.button_MC_agregarC.TabIndex = 9;
            this.button_MC_agregarC.Text = "Agregar";
            this.button_MC_agregarC.UseVisualStyleBackColor = true;
            // 
            // label_MC_ClientesAfectados
            // 
            this.label_MC_ClientesAfectados.AutoSize = true;
            this.label_MC_ClientesAfectados.Location = new System.Drawing.Point(3, 10);
            this.label_MC_ClientesAfectados.Name = "label_MC_ClientesAfectados";
            this.label_MC_ClientesAfectados.Size = new System.Drawing.Size(216, 13);
            this.label_MC_ClientesAfectados.TabIndex = 5;
            this.label_MC_ClientesAfectados.Text = "Lista de promociones mediante condiciones:";
            // 
            // dataGridView_MC_ClientesAfectados
            // 
            this.dataGridView_MC_ClientesAfectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MC_ClientesAfectados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MC_NOMBRE,
            this.Estado});
            this.dataGridView_MC_ClientesAfectados.Location = new System.Drawing.Point(3, 26);
            this.dataGridView_MC_ClientesAfectados.Name = "dataGridView_MC_ClientesAfectados";
            this.dataGridView_MC_ClientesAfectados.Size = new System.Drawing.Size(439, 577);
            this.dataGridView_MC_ClientesAfectados.TabIndex = 1;
            // 
            // MC_NOMBRE
            // 
            this.MC_NOMBRE.HeaderText = "NOMBRE";
            this.MC_NOMBRE.Name = "MC_NOMBRE";
            this.MC_NOMBRE.ReadOnly = true;
            // 
            // groupBox_PE_Datos
            // 
            this.groupBox_PE_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_Clugar);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_lugar);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_provincia);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_Cprovincia);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_poblacion);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_hora);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_Cpoblacion);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_fecha);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_Chora);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_titulo);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_Ctitulo);
            this.groupBox_PE_Datos.Controls.Add(this.label_PE_Cfecha);
            this.groupBox_PE_Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PE_Datos.Location = new System.Drawing.Point(9, 48);
            this.groupBox_PE_Datos.Name = "groupBox_PE_Datos";
            this.groupBox_PE_Datos.Size = new System.Drawing.Size(335, 241);
            this.groupBox_PE_Datos.TabIndex = 5;
            this.groupBox_PE_Datos.TabStop = false;
            this.groupBox_PE_Datos.Text = "Datos";
            // 
            // label_PE_titulo
            // 
            this.label_PE_titulo.AutoSize = true;
            this.label_PE_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_titulo.Location = new System.Drawing.Point(24, 38);
            this.label_PE_titulo.Name = "label_PE_titulo";
            this.label_PE_titulo.Size = new System.Drawing.Size(45, 13);
            this.label_PE_titulo.TabIndex = 0;
            this.label_PE_titulo.Text = "Título:";
            this.label_PE_titulo.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // label_PE_fecha
            // 
            this.label_PE_fecha.AutoSize = true;
            this.label_PE_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_fecha.Location = new System.Drawing.Point(24, 69);
            this.label_PE_fecha.Name = "label_PE_fecha";
            this.label_PE_fecha.Size = new System.Drawing.Size(46, 13);
            this.label_PE_fecha.TabIndex = 1;
            this.label_PE_fecha.Text = "Fecha:";
            // 
            // label_PE_hora
            // 
            this.label_PE_hora.AutoSize = true;
            this.label_PE_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_hora.Location = new System.Drawing.Point(24, 100);
            this.label_PE_hora.Name = "label_PE_hora";
            this.label_PE_hora.Size = new System.Drawing.Size(38, 13);
            this.label_PE_hora.TabIndex = 2;
            this.label_PE_hora.Text = "Hora:";
            // 
            // label_PE_poblacion
            // 
            this.label_PE_poblacion.AutoSize = true;
            this.label_PE_poblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_poblacion.Location = new System.Drawing.Point(24, 131);
            this.label_PE_poblacion.Name = "label_PE_poblacion";
            this.label_PE_poblacion.Size = new System.Drawing.Size(67, 13);
            this.label_PE_poblacion.TabIndex = 3;
            this.label_PE_poblacion.Text = "Población:";
            // 
            // label_PE_provincia
            // 
            this.label_PE_provincia.AutoSize = true;
            this.label_PE_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_provincia.Location = new System.Drawing.Point(24, 163);
            this.label_PE_provincia.Name = "label_PE_provincia";
            this.label_PE_provincia.Size = new System.Drawing.Size(64, 13);
            this.label_PE_provincia.TabIndex = 4;
            this.label_PE_provincia.Text = "Provincia:";
            // 
            // label_PE_lugar
            // 
            this.label_PE_lugar.AutoSize = true;
            this.label_PE_lugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_lugar.Location = new System.Drawing.Point(24, 194);
            this.label_PE_lugar.Name = "label_PE_lugar";
            this.label_PE_lugar.Size = new System.Drawing.Size(43, 13);
            this.label_PE_lugar.TabIndex = 5;
            this.label_PE_lugar.Text = "Lugar:";
            // 
            // label_PE_Ctitulo
            // 
            this.label_PE_Ctitulo.AutoSize = true;
            this.label_PE_Ctitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Ctitulo.Location = new System.Drawing.Point(130, 38);
            this.label_PE_Ctitulo.Name = "label_PE_Ctitulo";
            this.label_PE_Ctitulo.Size = new System.Drawing.Size(35, 13);
            this.label_PE_Ctitulo.TabIndex = 6;
            this.label_PE_Ctitulo.Text = "label7";
            // 
            // label_PE_Cfecha
            // 
            this.label_PE_Cfecha.AutoSize = true;
            this.label_PE_Cfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Cfecha.Location = new System.Drawing.Point(130, 69);
            this.label_PE_Cfecha.Name = "label_PE_Cfecha";
            this.label_PE_Cfecha.Size = new System.Drawing.Size(35, 13);
            this.label_PE_Cfecha.TabIndex = 7;
            this.label_PE_Cfecha.Text = "label8";
            // 
            // label_PE_Chora
            // 
            this.label_PE_Chora.AutoSize = true;
            this.label_PE_Chora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Chora.Location = new System.Drawing.Point(130, 100);
            this.label_PE_Chora.Name = "label_PE_Chora";
            this.label_PE_Chora.Size = new System.Drawing.Size(35, 13);
            this.label_PE_Chora.TabIndex = 8;
            this.label_PE_Chora.Text = "label9";
            // 
            // label_PE_Cpoblacion
            // 
            this.label_PE_Cpoblacion.AutoSize = true;
            this.label_PE_Cpoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Cpoblacion.Location = new System.Drawing.Point(130, 131);
            this.label_PE_Cpoblacion.Name = "label_PE_Cpoblacion";
            this.label_PE_Cpoblacion.Size = new System.Drawing.Size(41, 13);
            this.label_PE_Cpoblacion.TabIndex = 9;
            this.label_PE_Cpoblacion.Text = "label10";
            // 
            // label_PE_Cprovincia
            // 
            this.label_PE_Cprovincia.AutoSize = true;
            this.label_PE_Cprovincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Cprovincia.Location = new System.Drawing.Point(130, 163);
            this.label_PE_Cprovincia.Name = "label_PE_Cprovincia";
            this.label_PE_Cprovincia.Size = new System.Drawing.Size(41, 13);
            this.label_PE_Cprovincia.TabIndex = 10;
            this.label_PE_Cprovincia.Text = "label11";
            // 
            // label_PE_Clugar
            // 
            this.label_PE_Clugar.AutoSize = true;
            this.label_PE_Clugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Clugar.Location = new System.Drawing.Point(130, 194);
            this.label_PE_Clugar.Name = "label_PE_Clugar";
            this.label_PE_Clugar.Size = new System.Drawing.Size(41, 13);
            this.label_PE_Clugar.TabIndex = 11;
            this.label_PE_Clugar.Text = "label12";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promociones eventuales";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5%";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 98);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "25%";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "10%";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(167, 36);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "50%";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 5;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(167, 97);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Otro:";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(167, 66);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(106, 17);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Dia sin IVA (18%)";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(9, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Promociones generales";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Menores de 25";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(27, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mayores de 65";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(27, 109);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Cliente";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(167, 33);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(81, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Estudiantes";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(167, 71);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(70, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Jubilados";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(167, 109);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(65, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Parados";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "¿Activado?";
            this.Estado.Name = "Estado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(448, 71);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(442, 108);
            this.textBox2.TabIndex = 12;
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
            this.tab_Mediante_condiciones.ResumeLayout(false);
            this.tab_Mediante_condiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MC_ClientesAfectados)).EndInit();
            this.groupBox_PE_Datos.ResumeLayout(false);
            this.groupBox_PE_Datos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_promociones;
        private System.Windows.Forms.TabPage tab_Por_espectaculo;
        private System.Windows.Forms.TabPage tab_Por_cliente;
        private System.Windows.Forms.TabPage tab_Mediante_condiciones;
        private System.Windows.Forms.Label label_PE_Espectaculo;
        private System.Windows.Forms.ComboBox comboBox_PE_espectaculo;
        private System.Windows.Forms.Label label_PC_Titulo;
        private System.Windows.Forms.Label label_PC_Cliente;
        private System.Windows.Forms.ComboBox comboBox_PC_cliente;
        private System.Windows.Forms.DataGridView dataGridView_PE_promoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_POBLACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_LUGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_DESCRIPCION;
        private System.Windows.Forms.Button button_MC_eliminarC;
        private System.Windows.Forms.Button button_MC_modificarC;
        private System.Windows.Forms.Button button_MC_agregarC;
        private System.Windows.Forms.Label label_MC_ClientesAfectados;
        private System.Windows.Forms.DataGridView dataGridView_MC_ClientesAfectados;
        private System.Windows.Forms.DataGridViewTextBoxColumn MC_NOMBRE;
        private System.Windows.Forms.GroupBox groupBox_PE_Datos;
        private System.Windows.Forms.Label label_PE_provincia;
        private System.Windows.Forms.Label label_PE_poblacion;
        private System.Windows.Forms.Label label_PE_hora;
        private System.Windows.Forms.Label label_PE_fecha;
        private System.Windows.Forms.Label label_PE_titulo;
        private System.Windows.Forms.Label label_PE_Ctitulo;
        private System.Windows.Forms.Label label_PE_lugar;
        private System.Windows.Forms.Label label_PE_Clugar;
        private System.Windows.Forms.Label label_PE_Cprovincia;
        private System.Windows.Forms.Label label_PE_Cpoblacion;
        private System.Windows.Forms.Label label_PE_Chora;
        private System.Windows.Forms.Label label_PE_Cfecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}
