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
            this.dataGridView_PE_listado = new System.Windows.Forms.DataGridView();
            this.label_PE_Espectaculo = new System.Windows.Forms.Label();
            this.comboBox_PE_espectaculo = new System.Windows.Forms.ComboBox();
            this.label_PE_Titulo = new System.Windows.Forms.Label();
            this.tab_Por_cliente = new System.Windows.Forms.TabPage();
            this.dataGridView_PE_promoClientes = new System.Windows.Forms.DataGridView();
            this.label_PC_Cliente = new System.Windows.Forms.Label();
            this.comboBox_PC_cliente = new System.Windows.Forms.ComboBox();
            this.label_PC_Titulo = new System.Windows.Forms.Label();
            this.tab_Mediante_condiciones = new System.Windows.Forms.TabPage();
            this.label_MC_Titulo = new System.Windows.Forms.Label();
            this.dataGridView_MC_ClientesAfectados = new System.Windows.Forms.DataGridView();
            this.comboBox_MC_ListadoCondiciones = new System.Windows.Forms.ComboBox();
            this.label_MC_ListadoCondiciones = new System.Windows.Forms.Label();
            this.dataGridView_MC_Espectaculos = new System.Windows.Forms.DataGridView();
            this.label_MC_ClientesAfectados = new System.Windows.Forms.Label();
            this.label_MC_EspectaculosAfectados = new System.Windows.Forms.Label();
            this.label_MC_ListadoEspectaculos = new System.Windows.Forms.Label();
            this.comboBox_MC_Listado_Espectaculo = new System.Windows.Forms.ComboBox();
            this.button_MC_agregarC = new System.Windows.Forms.Button();
            this.button_MC_modificarC = new System.Windows.Forms.Button();
            this.button_MC_eliminarC = new System.Windows.Forms.Button();
            this.button_MC_agregarE = new System.Windows.Forms.Button();
            this.button_MC_modificarE = new System.Windows.Forms.Button();
            this.button_MC_eliminarE = new System.Windows.Forms.Button();
            this.MC_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MC_ESPECTACULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_POBLACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_LUGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PC_DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE_FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE_HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE_POBLACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE_PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE_LUGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE_DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE_DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_promociones.SuspendLayout();
            this.tab_Por_espectaculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PE_listado)).BeginInit();
            this.tab_Por_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PE_promoClientes)).BeginInit();
            this.tab_Mediante_condiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MC_ClientesAfectados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MC_Espectaculos)).BeginInit();
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
            this.tab_Por_espectaculo.Controls.Add(this.dataGridView_PE_listado);
            this.tab_Por_espectaculo.Controls.Add(this.label_PE_Espectaculo);
            this.tab_Por_espectaculo.Controls.Add(this.comboBox_PE_espectaculo);
            this.tab_Por_espectaculo.Controls.Add(this.label_PE_Titulo);
            this.tab_Por_espectaculo.Location = new System.Drawing.Point(4, 22);
            this.tab_Por_espectaculo.Name = "tab_Por_espectaculo";
            this.tab_Por_espectaculo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Por_espectaculo.Size = new System.Drawing.Size(893, 606);
            this.tab_Por_espectaculo.TabIndex = 0;
            this.tab_Por_espectaculo.Text = "Por_espectaculo";
            this.tab_Por_espectaculo.UseVisualStyleBackColor = true;
            // 
            // dataGridView_PE_listado
            // 
            this.dataGridView_PE_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PE_listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PE_FECHA,
            this.PE_HORA,
            this.PE_POBLACION,
            this.PE_PROVINCIA,
            this.PE_LUGAR,
            this.PE_DESCUENTO,
            this.PE_DESCRIPCION});
            this.dataGridView_PE_listado.Location = new System.Drawing.Point(6, 119);
            this.dataGridView_PE_listado.Name = "dataGridView_PE_listado";
            this.dataGridView_PE_listado.Size = new System.Drawing.Size(881, 481);
            this.dataGridView_PE_listado.TabIndex = 7;
            this.dataGridView_PE_listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PE_listado_CellContentClick);
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
            // comboBox_PE_espectaculo
            // 
            this.comboBox_PE_espectaculo.FormattingEnabled = true;
            this.comboBox_PE_espectaculo.Location = new System.Drawing.Point(177, 92);
            this.comboBox_PE_espectaculo.Name = "comboBox_PE_espectaculo";
            this.comboBox_PE_espectaculo.Size = new System.Drawing.Size(228, 21);
            this.comboBox_PE_espectaculo.TabIndex = 3;
            this.comboBox_PE_espectaculo.Text = "Seleccionar espectaculo ...";
            // 
            // label_PE_Titulo
            // 
            this.label_PE_Titulo.AutoSize = true;
            this.label_PE_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Titulo.Location = new System.Drawing.Point(95, 15);
            this.label_PE_Titulo.Name = "label_PE_Titulo";
            this.label_PE_Titulo.Size = new System.Drawing.Size(685, 55);
            this.label_PE_Titulo.TabIndex = 2;
            this.label_PE_Titulo.Text = "Promociones por espectaculo";
            this.label_PE_Titulo.Click += new System.EventHandler(this.label1_Click);
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
            this.tab_Por_cliente.Text = "Por_cliente";
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
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_eliminarE);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_modificarE);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_agregarE);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_eliminarC);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_modificarC);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_agregarC);
            this.tab_Mediante_condiciones.Controls.Add(this.comboBox_MC_Listado_Espectaculo);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_ListadoEspectaculos);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_EspectaculosAfectados);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_ClientesAfectados);
            this.tab_Mediante_condiciones.Controls.Add(this.dataGridView_MC_Espectaculos);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_ListadoCondiciones);
            this.tab_Mediante_condiciones.Controls.Add(this.comboBox_MC_ListadoCondiciones);
            this.tab_Mediante_condiciones.Controls.Add(this.dataGridView_MC_ClientesAfectados);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_Titulo);
            this.tab_Mediante_condiciones.Location = new System.Drawing.Point(4, 22);
            this.tab_Mediante_condiciones.Name = "tab_Mediante_condiciones";
            this.tab_Mediante_condiciones.Size = new System.Drawing.Size(893, 606);
            this.tab_Mediante_condiciones.TabIndex = 2;
            this.tab_Mediante_condiciones.Text = "Mediante_condiciones";
            this.tab_Mediante_condiciones.UseVisualStyleBackColor = true;
            // 
            // label_MC_Titulo
            // 
            this.label_MC_Titulo.AutoSize = true;
            this.label_MC_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MC_Titulo.Location = new System.Drawing.Point(130, 22);
            this.label_MC_Titulo.Name = "label_MC_Titulo";
            this.label_MC_Titulo.Size = new System.Drawing.Size(644, 55);
            this.label_MC_Titulo.TabIndex = 0;
            this.label_MC_Titulo.Text = "MEDIANTE CONDICIONES";
            this.label_MC_Titulo.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // dataGridView_MC_ClientesAfectados
            // 
            this.dataGridView_MC_ClientesAfectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MC_ClientesAfectados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MC_NOMBRE});
            this.dataGridView_MC_ClientesAfectados.Location = new System.Drawing.Point(3, 252);
            this.dataGridView_MC_ClientesAfectados.Name = "dataGridView_MC_ClientesAfectados";
            this.dataGridView_MC_ClientesAfectados.Size = new System.Drawing.Size(439, 351);
            this.dataGridView_MC_ClientesAfectados.TabIndex = 1;
            // 
            // comboBox_MC_ListadoCondiciones
            // 
            this.comboBox_MC_ListadoCondiciones.FormattingEnabled = true;
            this.comboBox_MC_ListadoCondiciones.Location = new System.Drawing.Point(198, 113);
            this.comboBox_MC_ListadoCondiciones.Name = "comboBox_MC_ListadoCondiciones";
            this.comboBox_MC_ListadoCondiciones.Size = new System.Drawing.Size(244, 21);
            this.comboBox_MC_ListadoCondiciones.TabIndex = 2;
            this.comboBox_MC_ListadoCondiciones.Text = "Seleccionar condición ...";
            // 
            // label_MC_ListadoCondiciones
            // 
            this.label_MC_ListadoCondiciones.AutoSize = true;
            this.label_MC_ListadoCondiciones.Location = new System.Drawing.Point(3, 113);
            this.label_MC_ListadoCondiciones.Name = "label_MC_ListadoCondiciones";
            this.label_MC_ListadoCondiciones.Size = new System.Drawing.Size(189, 13);
            this.label_MC_ListadoCondiciones.TabIndex = 3;
            this.label_MC_ListadoCondiciones.Text = "Listado de condiciones de los clientes:";
            // 
            // dataGridView_MC_Espectaculos
            // 
            this.dataGridView_MC_Espectaculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MC_Espectaculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MC_ESPECTACULO});
            this.dataGridView_MC_Espectaculos.Location = new System.Drawing.Point(471, 252);
            this.dataGridView_MC_Espectaculos.Name = "dataGridView_MC_Espectaculos";
            this.dataGridView_MC_Espectaculos.Size = new System.Drawing.Size(419, 351);
            this.dataGridView_MC_Espectaculos.TabIndex = 4;
            // 
            // label_MC_ClientesAfectados
            // 
            this.label_MC_ClientesAfectados.AutoSize = true;
            this.label_MC_ClientesAfectados.Location = new System.Drawing.Point(3, 236);
            this.label_MC_ClientesAfectados.Name = "label_MC_ClientesAfectados";
            this.label_MC_ClientesAfectados.Size = new System.Drawing.Size(172, 13);
            this.label_MC_ClientesAfectados.TabIndex = 5;
            this.label_MC_ClientesAfectados.Text = "Clientes afectados por la condición";
            // 
            // label_MC_EspectaculosAfectados
            // 
            this.label_MC_EspectaculosAfectados.AutoSize = true;
            this.label_MC_EspectaculosAfectados.Location = new System.Drawing.Point(468, 236);
            this.label_MC_EspectaculosAfectados.Name = "label_MC_EspectaculosAfectados";
            this.label_MC_EspectaculosAfectados.Size = new System.Drawing.Size(199, 13);
            this.label_MC_EspectaculosAfectados.TabIndex = 6;
            this.label_MC_EspectaculosAfectados.Text = "Espectaculos afectados por la condición";
            // 
            // label_MC_ListadoEspectaculos
            // 
            this.label_MC_ListadoEspectaculos.AutoSize = true;
            this.label_MC_ListadoEspectaculos.Location = new System.Drawing.Point(471, 118);
            this.label_MC_ListadoEspectaculos.Name = "label_MC_ListadoEspectaculos";
            this.label_MC_ListadoEspectaculos.Size = new System.Drawing.Size(216, 13);
            this.label_MC_ListadoEspectaculos.TabIndex = 7;
            this.label_MC_ListadoEspectaculos.Text = "Listado de condiciones de los espectaculos:";
            // 
            // comboBox_MC_Listado_Espectaculo
            // 
            this.comboBox_MC_Listado_Espectaculo.FormattingEnabled = true;
            this.comboBox_MC_Listado_Espectaculo.Location = new System.Drawing.Point(693, 113);
            this.comboBox_MC_Listado_Espectaculo.Name = "comboBox_MC_Listado_Espectaculo";
            this.comboBox_MC_Listado_Espectaculo.Size = new System.Drawing.Size(197, 21);
            this.comboBox_MC_Listado_Espectaculo.TabIndex = 8;
            this.comboBox_MC_Listado_Espectaculo.Text = "Seleccionar condición ...";
            // 
            // button_MC_agregarC
            // 
            this.button_MC_agregarC.Location = new System.Drawing.Point(3, 170);
            this.button_MC_agregarC.Name = "button_MC_agregarC";
            this.button_MC_agregarC.Size = new System.Drawing.Size(75, 23);
            this.button_MC_agregarC.TabIndex = 9;
            this.button_MC_agregarC.Text = "Agregar";
            this.button_MC_agregarC.UseVisualStyleBackColor = true;
            // 
            // button_MC_modificarC
            // 
            this.button_MC_modificarC.Location = new System.Drawing.Point(117, 170);
            this.button_MC_modificarC.Name = "button_MC_modificarC";
            this.button_MC_modificarC.Size = new System.Drawing.Size(75, 23);
            this.button_MC_modificarC.TabIndex = 10;
            this.button_MC_modificarC.Text = "Modificar";
            this.button_MC_modificarC.UseVisualStyleBackColor = true;
            // 
            // button_MC_eliminarC
            // 
            this.button_MC_eliminarC.Location = new System.Drawing.Point(226, 170);
            this.button_MC_eliminarC.Name = "button_MC_eliminarC";
            this.button_MC_eliminarC.Size = new System.Drawing.Size(75, 23);
            this.button_MC_eliminarC.TabIndex = 11;
            this.button_MC_eliminarC.Text = "Eliminar";
            this.button_MC_eliminarC.UseVisualStyleBackColor = true;
            // 
            // button_MC_agregarE
            // 
            this.button_MC_agregarE.Location = new System.Drawing.Point(583, 170);
            this.button_MC_agregarE.Name = "button_MC_agregarE";
            this.button_MC_agregarE.Size = new System.Drawing.Size(75, 23);
            this.button_MC_agregarE.TabIndex = 12;
            this.button_MC_agregarE.Text = "Agregar";
            this.button_MC_agregarE.UseVisualStyleBackColor = true;
            // 
            // button_MC_modificarE
            // 
            this.button_MC_modificarE.Location = new System.Drawing.Point(699, 170);
            this.button_MC_modificarE.Name = "button_MC_modificarE";
            this.button_MC_modificarE.Size = new System.Drawing.Size(75, 23);
            this.button_MC_modificarE.TabIndex = 13;
            this.button_MC_modificarE.Text = "Modificar";
            this.button_MC_modificarE.UseVisualStyleBackColor = true;
            // 
            // button_MC_eliminarE
            // 
            this.button_MC_eliminarE.Location = new System.Drawing.Point(815, 170);
            this.button_MC_eliminarE.Name = "button_MC_eliminarE";
            this.button_MC_eliminarE.Size = new System.Drawing.Size(75, 23);
            this.button_MC_eliminarE.TabIndex = 14;
            this.button_MC_eliminarE.Text = "Eliminar";
            this.button_MC_eliminarE.UseVisualStyleBackColor = true;
            // 
            // MC_NOMBRE
            // 
            this.MC_NOMBRE.HeaderText = "NOMBRE";
            this.MC_NOMBRE.Name = "MC_NOMBRE";
            this.MC_NOMBRE.ReadOnly = true;
            // 
            // MC_ESPECTACULO
            // 
            this.MC_ESPECTACULO.HeaderText = "ESPECTACULO";
            this.MC_ESPECTACULO.Name = "MC_ESPECTACULO";
            this.MC_ESPECTACULO.ReadOnly = true;
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
            // PE_FECHA
            // 
            this.PE_FECHA.HeaderText = "FECHA";
            this.PE_FECHA.Name = "PE_FECHA";
            this.PE_FECHA.ReadOnly = true;
            // 
            // PE_HORA
            // 
            this.PE_HORA.HeaderText = "HORA";
            this.PE_HORA.Name = "PE_HORA";
            this.PE_HORA.ReadOnly = true;
            // 
            // PE_POBLACION
            // 
            this.PE_POBLACION.HeaderText = "POBLACION";
            this.PE_POBLACION.Name = "PE_POBLACION";
            this.PE_POBLACION.ReadOnly = true;
            // 
            // PE_PROVINCIA
            // 
            this.PE_PROVINCIA.HeaderText = "PROVINCIA";
            this.PE_PROVINCIA.Name = "PE_PROVINCIA";
            this.PE_PROVINCIA.ReadOnly = true;
            // 
            // PE_LUGAR
            // 
            this.PE_LUGAR.HeaderText = "LUGAR";
            this.PE_LUGAR.Name = "PE_LUGAR";
            this.PE_LUGAR.ReadOnly = true;
            // 
            // PE_DESCUENTO
            // 
            this.PE_DESCUENTO.HeaderText = "DESCUENTO";
            this.PE_DESCUENTO.Name = "PE_DESCUENTO";
            // 
            // PE_DESCRIPCION
            // 
            this.PE_DESCRIPCION.HeaderText = "DESCRIPCION";
            this.PE_DESCRIPCION.Name = "PE_DESCRIPCION";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PE_listado)).EndInit();
            this.tab_Por_cliente.ResumeLayout(false);
            this.tab_Por_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PE_promoClientes)).EndInit();
            this.tab_Mediante_condiciones.ResumeLayout(false);
            this.tab_Mediante_condiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MC_ClientesAfectados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MC_Espectaculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_promociones;
        private System.Windows.Forms.TabPage tab_Por_espectaculo;
        private System.Windows.Forms.TabPage tab_Por_cliente;
        private System.Windows.Forms.Label label_PE_Titulo;
        private System.Windows.Forms.TabPage tab_Mediante_condiciones;
        private System.Windows.Forms.Label label_PE_Espectaculo;
        private System.Windows.Forms.ComboBox comboBox_PE_espectaculo;
        private System.Windows.Forms.Label label_PC_Titulo;
        private System.Windows.Forms.Label label_PC_Cliente;
        private System.Windows.Forms.ComboBox comboBox_PC_cliente;
        private System.Windows.Forms.DataGridView dataGridView_PE_promoClientes;
        private System.Windows.Forms.DataGridView dataGridView_PE_listado;
        private System.Windows.Forms.Label label_MC_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE_FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE_HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE_POBLACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE_PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE_LUGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE_DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE_DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_POBLACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_LUGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC_DESCRIPCION;
        private System.Windows.Forms.Button button_MC_eliminarE;
        private System.Windows.Forms.Button button_MC_modificarE;
        private System.Windows.Forms.Button button_MC_agregarE;
        private System.Windows.Forms.Button button_MC_eliminarC;
        private System.Windows.Forms.Button button_MC_modificarC;
        private System.Windows.Forms.Button button_MC_agregarC;
        private System.Windows.Forms.ComboBox comboBox_MC_Listado_Espectaculo;
        private System.Windows.Forms.Label label_MC_ListadoEspectaculos;
        private System.Windows.Forms.Label label_MC_EspectaculosAfectados;
        private System.Windows.Forms.Label label_MC_ClientesAfectados;
        private System.Windows.Forms.DataGridView dataGridView_MC_Espectaculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MC_ESPECTACULO;
        private System.Windows.Forms.Label label_MC_ListadoCondiciones;
        private System.Windows.Forms.ComboBox comboBox_MC_ListadoCondiciones;
        private System.Windows.Forms.DataGridView dataGridView_MC_ClientesAfectados;
        private System.Windows.Forms.DataGridViewTextBoxColumn MC_NOMBRE;
    }
}
