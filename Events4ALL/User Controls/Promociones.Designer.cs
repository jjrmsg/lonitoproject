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
            this.pictureBox_PE_imagEspec = new System.Windows.Forms.PictureBox();
            this.groupBox_PE_promoGen = new System.Windows.Forms.GroupBox();
            this.checkBox_PE_descParado = new System.Windows.Forms.CheckBox();
            this.checkBox_PE_descJubilado = new System.Windows.Forms.CheckBox();
            this.checkBox_PE_descEstudiante = new System.Windows.Forms.CheckBox();
            this.checkBox_PE_descCliente = new System.Windows.Forms.CheckBox();
            this.checkBox_PE_mayor65 = new System.Windows.Forms.CheckBox();
            this.checkBox_PE_menor25 = new System.Windows.Forms.CheckBox();
            this.groupBox_PE_promoEvent = new System.Windows.Forms.GroupBox();
            this.radioButton_PE_IVA = new System.Windows.Forms.RadioButton();
            this.radioButton_PE_otroDesc = new System.Windows.Forms.RadioButton();
            this.textBox_PE_TOtroDesc = new System.Windows.Forms.TextBox();
            this.radioButton_PE_50 = new System.Windows.Forms.RadioButton();
            this.radioButton_PE_10 = new System.Windows.Forms.RadioButton();
            this.radioButton_PE_20 = new System.Windows.Forms.RadioButton();
            this.radioButton_PE_5 = new System.Windows.Forms.RadioButton();
            this.groupBox_PE_DatosEspec = new System.Windows.Forms.GroupBox();
            this.label_PE_SAsig = new System.Windows.Forms.Label();
            this.label_PE_TSAsig = new System.Windows.Forms.Label();
            this.label_PE_Precio = new System.Windows.Forms.Label();
            this.label_PE_TPrecio = new System.Windows.Forms.Label();
            this.label_PE_TDescripcion = new System.Windows.Forms.Label();
            this.label_PE_Descripcion = new System.Windows.Forms.Label();
            this.label_PE_fecha = new System.Windows.Forms.Label();
            this.label_PE_titulo = new System.Windows.Forms.Label();
            this.label_PE_TTitulo = new System.Windows.Forms.Label();
            this.label_PE_TFecha = new System.Windows.Forms.Label();
            this.label_PE_Espectaculo = new System.Windows.Forms.Label();
            this.comboBox_PE_espectaculo = new System.Windows.Forms.ComboBox();
            this.tab_Mediante_condiciones = new System.Windows.Forms.TabPage();
            this.checkBox_MC_ActPromo = new System.Windows.Forms.CheckBox();
            this.label_MC_ActPromo = new System.Windows.Forms.Label();
            this.button_MC_Nueva = new System.Windows.Forms.Button();
            this.label_MC_Descripcion = new System.Windows.Forms.Label();
            this.textBox_MC_NomPromo = new System.Windows.Forms.TextBox();
            this.label_MC_Nombre = new System.Windows.Forms.Label();
            this.textBox_MC_Descripcion = new System.Windows.Forms.TextBox();
            this.button_MC_Eliminar = new System.Windows.Forms.Button();
            this.button_MC_Guardar = new System.Windows.Forms.Button();
            this.label_MC_ClientesAfectados = new System.Windows.Forms.Label();
            this.dataGridView_MC_ListaPromosCond = new System.Windows.Forms.DataGridView();
            this.MC_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox_MC_CartelPromo = new System.Windows.Forms.PictureBox();
            this.label_MC_CartelPromo = new System.Windows.Forms.Label();
            this.button_MC_SubirFoto = new System.Windows.Forms.Button();
            this.tabControl_promociones.SuspendLayout();
            this.tab_Por_espectaculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PE_imagEspec)).BeginInit();
            this.groupBox_PE_promoGen.SuspendLayout();
            this.groupBox_PE_promoEvent.SuspendLayout();
            this.groupBox_PE_DatosEspec.SuspendLayout();
            this.tab_Mediante_condiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MC_ListaPromosCond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MC_CartelPromo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_promociones
            // 
            this.tabControl_promociones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_promociones.Controls.Add(this.tab_Por_espectaculo);
            this.tabControl_promociones.Controls.Add(this.tab_Mediante_condiciones);
            this.tabControl_promociones.Location = new System.Drawing.Point(3, 1);
            this.tabControl_promociones.Name = "tabControl_promociones";
            this.tabControl_promociones.SelectedIndex = 0;
            this.tabControl_promociones.Size = new System.Drawing.Size(901, 632);
            this.tabControl_promociones.TabIndex = 1;
            // 
            // tab_Por_espectaculo
            // 
            this.tab_Por_espectaculo.Controls.Add(this.pictureBox_PE_imagEspec);
            this.tab_Por_espectaculo.Controls.Add(this.groupBox_PE_promoGen);
            this.tab_Por_espectaculo.Controls.Add(this.groupBox_PE_promoEvent);
            this.tab_Por_espectaculo.Controls.Add(this.groupBox_PE_DatosEspec);
            this.tab_Por_espectaculo.Controls.Add(this.label_PE_Espectaculo);
            this.tab_Por_espectaculo.Controls.Add(this.comboBox_PE_espectaculo);
            this.tab_Por_espectaculo.Location = new System.Drawing.Point(4, 22);
            this.tab_Por_espectaculo.Name = "tab_Por_espectaculo";
            this.tab_Por_espectaculo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Por_espectaculo.Size = new System.Drawing.Size(893, 606);
            this.tab_Por_espectaculo.TabIndex = 0;
            this.tab_Por_espectaculo.Text = "Espectáculo";
            this.tab_Por_espectaculo.UseVisualStyleBackColor = true;
            // 
            // pictureBox_PE_imagEspec
            // 
            this.pictureBox_PE_imagEspec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_PE_imagEspec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_PE_imagEspec.Image = global::Events4ALL.Properties.Resources.image_default;
            this.pictureBox_PE_imagEspec.Location = new System.Drawing.Point(350, 295);
            this.pictureBox_PE_imagEspec.Name = "pictureBox_PE_imagEspec";
            this.pictureBox_PE_imagEspec.Size = new System.Drawing.Size(537, 305);
            this.pictureBox_PE_imagEspec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_PE_imagEspec.TabIndex = 8;
            this.pictureBox_PE_imagEspec.TabStop = false;
            // 
            // groupBox_PE_promoGen
            // 
            this.groupBox_PE_promoGen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_PE_promoGen.Controls.Add(this.checkBox_PE_descParado);
            this.groupBox_PE_promoGen.Controls.Add(this.checkBox_PE_descJubilado);
            this.groupBox_PE_promoGen.Controls.Add(this.checkBox_PE_descEstudiante);
            this.groupBox_PE_promoGen.Controls.Add(this.checkBox_PE_descCliente);
            this.groupBox_PE_promoGen.Controls.Add(this.checkBox_PE_mayor65);
            this.groupBox_PE_promoGen.Controls.Add(this.checkBox_PE_menor25);
            this.groupBox_PE_promoGen.Location = new System.Drawing.Point(9, 441);
            this.groupBox_PE_promoGen.Name = "groupBox_PE_promoGen";
            this.groupBox_PE_promoGen.Size = new System.Drawing.Size(335, 159);
            this.groupBox_PE_promoGen.TabIndex = 7;
            this.groupBox_PE_promoGen.TabStop = false;
            this.groupBox_PE_promoGen.Text = "Promociones generales";
            // 
            // checkBox_PE_descParado
            // 
            this.checkBox_PE_descParado.AutoSize = true;
            this.checkBox_PE_descParado.Location = new System.Drawing.Point(167, 109);
            this.checkBox_PE_descParado.Name = "checkBox_PE_descParado";
            this.checkBox_PE_descParado.Size = new System.Drawing.Size(65, 17);
            this.checkBox_PE_descParado.TabIndex = 14;
            this.checkBox_PE_descParado.Text = "Parados";
            this.checkBox_PE_descParado.UseVisualStyleBackColor = true;
            // 
            // checkBox_PE_descJubilado
            // 
            this.checkBox_PE_descJubilado.AutoSize = true;
            this.checkBox_PE_descJubilado.Location = new System.Drawing.Point(167, 71);
            this.checkBox_PE_descJubilado.Name = "checkBox_PE_descJubilado";
            this.checkBox_PE_descJubilado.Size = new System.Drawing.Size(70, 17);
            this.checkBox_PE_descJubilado.TabIndex = 13;
            this.checkBox_PE_descJubilado.Text = "Jubilados";
            this.checkBox_PE_descJubilado.UseVisualStyleBackColor = true;
            // 
            // checkBox_PE_descEstudiante
            // 
            this.checkBox_PE_descEstudiante.AutoSize = true;
            this.checkBox_PE_descEstudiante.Location = new System.Drawing.Point(167, 33);
            this.checkBox_PE_descEstudiante.Name = "checkBox_PE_descEstudiante";
            this.checkBox_PE_descEstudiante.Size = new System.Drawing.Size(81, 17);
            this.checkBox_PE_descEstudiante.TabIndex = 12;
            this.checkBox_PE_descEstudiante.Text = "Estudiantes";
            this.checkBox_PE_descEstudiante.UseVisualStyleBackColor = true;
            // 
            // checkBox_PE_descCliente
            // 
            this.checkBox_PE_descCliente.AutoSize = true;
            this.checkBox_PE_descCliente.Location = new System.Drawing.Point(27, 109);
            this.checkBox_PE_descCliente.Name = "checkBox_PE_descCliente";
            this.checkBox_PE_descCliente.Size = new System.Drawing.Size(58, 17);
            this.checkBox_PE_descCliente.TabIndex = 11;
            this.checkBox_PE_descCliente.Text = "Cliente";
            this.checkBox_PE_descCliente.UseVisualStyleBackColor = true;
            // 
            // checkBox_PE_mayor65
            // 
            this.checkBox_PE_mayor65.AutoSize = true;
            this.checkBox_PE_mayor65.Location = new System.Drawing.Point(27, 71);
            this.checkBox_PE_mayor65.Name = "checkBox_PE_mayor65";
            this.checkBox_PE_mayor65.Size = new System.Drawing.Size(96, 17);
            this.checkBox_PE_mayor65.TabIndex = 10;
            this.checkBox_PE_mayor65.Text = "Mayores de 65";
            this.checkBox_PE_mayor65.UseVisualStyleBackColor = true;
            // 
            // checkBox_PE_menor25
            // 
            this.checkBox_PE_menor25.AutoSize = true;
            this.checkBox_PE_menor25.Location = new System.Drawing.Point(27, 33);
            this.checkBox_PE_menor25.Name = "checkBox_PE_menor25";
            this.checkBox_PE_menor25.Size = new System.Drawing.Size(97, 17);
            this.checkBox_PE_menor25.TabIndex = 9;
            this.checkBox_PE_menor25.Text = "Menores de 25";
            this.checkBox_PE_menor25.UseVisualStyleBackColor = true;
            // 
            // groupBox_PE_promoEvent
            // 
            this.groupBox_PE_promoEvent.Controls.Add(this.radioButton_PE_IVA);
            this.groupBox_PE_promoEvent.Controls.Add(this.radioButton_PE_otroDesc);
            this.groupBox_PE_promoEvent.Controls.Add(this.textBox_PE_TOtroDesc);
            this.groupBox_PE_promoEvent.Controls.Add(this.radioButton_PE_50);
            this.groupBox_PE_promoEvent.Controls.Add(this.radioButton_PE_10);
            this.groupBox_PE_promoEvent.Controls.Add(this.radioButton_PE_20);
            this.groupBox_PE_promoEvent.Controls.Add(this.radioButton_PE_5);
            this.groupBox_PE_promoEvent.Location = new System.Drawing.Point(9, 295);
            this.groupBox_PE_promoEvent.Name = "groupBox_PE_promoEvent";
            this.groupBox_PE_promoEvent.Size = new System.Drawing.Size(335, 140);
            this.groupBox_PE_promoEvent.TabIndex = 6;
            this.groupBox_PE_promoEvent.TabStop = false;
            this.groupBox_PE_promoEvent.Text = "Promociones eventuales";
            // 
            // radioButton_PE_IVA
            // 
            this.radioButton_PE_IVA.AutoSize = true;
            this.radioButton_PE_IVA.Location = new System.Drawing.Point(167, 66);
            this.radioButton_PE_IVA.Name = "radioButton_PE_IVA";
            this.radioButton_PE_IVA.Size = new System.Drawing.Size(108, 17);
            this.radioButton_PE_IVA.TabIndex = 6;
            this.radioButton_PE_IVA.TabStop = true;
            this.radioButton_PE_IVA.Text = "Día sin IVA (18%)";
            this.radioButton_PE_IVA.UseVisualStyleBackColor = true;
            // 
            // radioButton_PE_otroDesc
            // 
            this.radioButton_PE_otroDesc.AutoSize = true;
            this.radioButton_PE_otroDesc.Location = new System.Drawing.Point(167, 97);
            this.radioButton_PE_otroDesc.Name = "radioButton_PE_otroDesc";
            this.radioButton_PE_otroDesc.Size = new System.Drawing.Size(48, 17);
            this.radioButton_PE_otroDesc.TabIndex = 7;
            this.radioButton_PE_otroDesc.TabStop = true;
            this.radioButton_PE_otroDesc.Text = "Otro:";
            this.radioButton_PE_otroDesc.UseVisualStyleBackColor = true;
            // 
            // textBox_PE_TOtroDesc
            // 
            this.textBox_PE_TOtroDesc.Location = new System.Drawing.Point(218, 97);
            this.textBox_PE_TOtroDesc.Name = "textBox_PE_TOtroDesc";
            this.textBox_PE_TOtroDesc.Size = new System.Drawing.Size(57, 20);
            this.textBox_PE_TOtroDesc.TabIndex = 8;
            // 
            // radioButton_PE_50
            // 
            this.radioButton_PE_50.AutoSize = true;
            this.radioButton_PE_50.Location = new System.Drawing.Point(167, 36);
            this.radioButton_PE_50.Name = "radioButton_PE_50";
            this.radioButton_PE_50.Size = new System.Drawing.Size(45, 17);
            this.radioButton_PE_50.TabIndex = 5;
            this.radioButton_PE_50.TabStop = true;
            this.radioButton_PE_50.Text = "50%";
            this.radioButton_PE_50.UseVisualStyleBackColor = true;
            // 
            // radioButton_PE_10
            // 
            this.radioButton_PE_10.AutoSize = true;
            this.radioButton_PE_10.Location = new System.Drawing.Point(27, 66);
            this.radioButton_PE_10.Name = "radioButton_PE_10";
            this.radioButton_PE_10.Size = new System.Drawing.Size(45, 17);
            this.radioButton_PE_10.TabIndex = 3;
            this.radioButton_PE_10.TabStop = true;
            this.radioButton_PE_10.Text = "10%";
            this.radioButton_PE_10.UseVisualStyleBackColor = true;
            // 
            // radioButton_PE_20
            // 
            this.radioButton_PE_20.AutoSize = true;
            this.radioButton_PE_20.Location = new System.Drawing.Point(27, 98);
            this.radioButton_PE_20.Name = "radioButton_PE_20";
            this.radioButton_PE_20.Size = new System.Drawing.Size(45, 17);
            this.radioButton_PE_20.TabIndex = 4;
            this.radioButton_PE_20.TabStop = true;
            this.radioButton_PE_20.Text = "25%";
            this.radioButton_PE_20.UseVisualStyleBackColor = true;
            // 
            // radioButton_PE_5
            // 
            this.radioButton_PE_5.AutoSize = true;
            this.radioButton_PE_5.Location = new System.Drawing.Point(27, 36);
            this.radioButton_PE_5.Name = "radioButton_PE_5";
            this.radioButton_PE_5.Size = new System.Drawing.Size(39, 17);
            this.radioButton_PE_5.TabIndex = 2;
            this.radioButton_PE_5.TabStop = true;
            this.radioButton_PE_5.Text = "5%";
            this.radioButton_PE_5.UseVisualStyleBackColor = true;
            // 
            // groupBox_PE_DatosEspec
            // 
            this.groupBox_PE_DatosEspec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_SAsig);
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_TSAsig);
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_Precio);
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_TPrecio);
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_TDescripcion);
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_Descripcion);
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_fecha);
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_titulo);
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_TTitulo);
            this.groupBox_PE_DatosEspec.Controls.Add(this.label_PE_TFecha);
            this.groupBox_PE_DatosEspec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PE_DatosEspec.Location = new System.Drawing.Point(9, 48);
            this.groupBox_PE_DatosEspec.Name = "groupBox_PE_DatosEspec";
            this.groupBox_PE_DatosEspec.Size = new System.Drawing.Size(878, 241);
            this.groupBox_PE_DatosEspec.TabIndex = 5;
            this.groupBox_PE_DatosEspec.TabStop = false;
            this.groupBox_PE_DatosEspec.Text = "Datos";
            // 
            // label_PE_SAsig
            // 
            this.label_PE_SAsig.AutoSize = true;
            this.label_PE_SAsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_SAsig.Location = new System.Drawing.Point(24, 142);
            this.label_PE_SAsig.Name = "label_PE_SAsig";
            this.label_PE_SAsig.Size = new System.Drawing.Size(91, 13);
            this.label_PE_SAsig.TabIndex = 12;
            this.label_PE_SAsig.Text = "Sala asignada:";
            // 
            // label_PE_TSAsig
            // 
            this.label_PE_TSAsig.AutoSize = true;
            this.label_PE_TSAsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_TSAsig.Location = new System.Drawing.Point(130, 142);
            this.label_PE_TSAsig.Name = "label_PE_TSAsig";
            this.label_PE_TSAsig.Size = new System.Drawing.Size(35, 13);
            this.label_PE_TSAsig.TabIndex = 13;
            this.label_PE_TSAsig.Text = "label8";
            // 
            // label_PE_Precio
            // 
            this.label_PE_Precio.AutoSize = true;
            this.label_PE_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Precio.Location = new System.Drawing.Point(24, 192);
            this.label_PE_Precio.Name = "label_PE_Precio";
            this.label_PE_Precio.Size = new System.Drawing.Size(47, 13);
            this.label_PE_Precio.TabIndex = 10;
            this.label_PE_Precio.Text = "Precio:";
            // 
            // label_PE_TPrecio
            // 
            this.label_PE_TPrecio.AutoSize = true;
            this.label_PE_TPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_TPrecio.Location = new System.Drawing.Point(130, 192);
            this.label_PE_TPrecio.Name = "label_PE_TPrecio";
            this.label_PE_TPrecio.Size = new System.Drawing.Size(35, 13);
            this.label_PE_TPrecio.TabIndex = 11;
            this.label_PE_TPrecio.Text = "label8";
            // 
            // label_PE_TDescripcion
            // 
            this.label_PE_TDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PE_TDescripcion.AutoSize = true;
            this.label_PE_TDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_TDescripcion.Location = new System.Drawing.Point(330, 38);
            this.label_PE_TDescripcion.Name = "label_PE_TDescripcion";
            this.label_PE_TDescripcion.Size = new System.Drawing.Size(541, 26);
            this.label_PE_TDescripcion.TabIndex = 9;
            this.label_PE_TDescripcion.Text = "label8label8label8label8label8label8label8label8label8label8label8label8label8lab" +
    "el8label8label8l8labelljkjj5555667\r\nssssssssssssssssssssssssssssssssssssssssssss" +
    "sssssssss";
            // 
            // label_PE_Descripcion
            // 
            this.label_PE_Descripcion.AutoSize = true;
            this.label_PE_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Descripcion.Location = new System.Drawing.Point(246, 38);
            this.label_PE_Descripcion.Name = "label_PE_Descripcion";
            this.label_PE_Descripcion.Size = new System.Drawing.Size(78, 13);
            this.label_PE_Descripcion.TabIndex = 8;
            this.label_PE_Descripcion.Text = "Descripción:";
            // 
            // label_PE_fecha
            // 
            this.label_PE_fecha.AutoSize = true;
            this.label_PE_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_fecha.Location = new System.Drawing.Point(24, 89);
            this.label_PE_fecha.Name = "label_PE_fecha";
            this.label_PE_fecha.Size = new System.Drawing.Size(46, 13);
            this.label_PE_fecha.TabIndex = 1;
            this.label_PE_fecha.Text = "Fecha:";
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
            // label_PE_TTitulo
            // 
            this.label_PE_TTitulo.AutoSize = true;
            this.label_PE_TTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_TTitulo.Location = new System.Drawing.Point(130, 38);
            this.label_PE_TTitulo.Name = "label_PE_TTitulo";
            this.label_PE_TTitulo.Size = new System.Drawing.Size(35, 13);
            this.label_PE_TTitulo.TabIndex = 6;
            this.label_PE_TTitulo.Text = "label7";
            // 
            // label_PE_TFecha
            // 
            this.label_PE_TFecha.AutoSize = true;
            this.label_PE_TFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_TFecha.Location = new System.Drawing.Point(130, 89);
            this.label_PE_TFecha.Name = "label_PE_TFecha";
            this.label_PE_TFecha.Size = new System.Drawing.Size(35, 13);
            this.label_PE_TFecha.TabIndex = 7;
            this.label_PE_TFecha.Text = "label8";
            // 
            // label_PE_Espectaculo
            // 
            this.label_PE_Espectaculo.AutoSize = true;
            this.label_PE_Espectaculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PE_Espectaculo.Location = new System.Drawing.Point(6, 15);
            this.label_PE_Espectaculo.Name = "label_PE_Espectaculo";
            this.label_PE_Espectaculo.Size = new System.Drawing.Size(81, 13);
            this.label_PE_Espectaculo.TabIndex = 4;
            this.label_PE_Espectaculo.Text = "Espectáculo:";
            this.label_PE_Espectaculo.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_PE_espectaculo
            // 
            this.comboBox_PE_espectaculo.FormattingEnabled = true;
            this.comboBox_PE_espectaculo.Location = new System.Drawing.Point(93, 12);
            this.comboBox_PE_espectaculo.Name = "comboBox_PE_espectaculo";
            this.comboBox_PE_espectaculo.Size = new System.Drawing.Size(251, 21);
            this.comboBox_PE_espectaculo.TabIndex = 1;
            this.comboBox_PE_espectaculo.Text = "Seleccionar espectáculo ...";
            // 
            // tab_Mediante_condiciones
            // 
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_SubirFoto);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_CartelPromo);
            this.tab_Mediante_condiciones.Controls.Add(this.pictureBox_MC_CartelPromo);
            this.tab_Mediante_condiciones.Controls.Add(this.checkBox_MC_ActPromo);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_ActPromo);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_Nueva);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_Descripcion);
            this.tab_Mediante_condiciones.Controls.Add(this.textBox_MC_NomPromo);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_Nombre);
            this.tab_Mediante_condiciones.Controls.Add(this.textBox_MC_Descripcion);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_Eliminar);
            this.tab_Mediante_condiciones.Controls.Add(this.button_MC_Guardar);
            this.tab_Mediante_condiciones.Controls.Add(this.label_MC_ClientesAfectados);
            this.tab_Mediante_condiciones.Controls.Add(this.dataGridView_MC_ListaPromosCond);
            this.tab_Mediante_condiciones.Location = new System.Drawing.Point(4, 22);
            this.tab_Mediante_condiciones.Name = "tab_Mediante_condiciones";
            this.tab_Mediante_condiciones.Size = new System.Drawing.Size(893, 606);
            this.tab_Mediante_condiciones.TabIndex = 2;
            this.tab_Mediante_condiciones.Text = "Condiciones especiales";
            this.tab_Mediante_condiciones.UseVisualStyleBackColor = true;
            // 
            // checkBox_MC_ActPromo
            // 
            this.checkBox_MC_ActPromo.AutoSize = true;
            this.checkBox_MC_ActPromo.Location = new System.Drawing.Point(608, 250);
            this.checkBox_MC_ActPromo.Name = "checkBox_MC_ActPromo";
            this.checkBox_MC_ActPromo.Size = new System.Drawing.Size(15, 14);
            this.checkBox_MC_ActPromo.TabIndex = 4;
            this.checkBox_MC_ActPromo.UseVisualStyleBackColor = true;
            // 
            // label_MC_ActPromo
            // 
            this.label_MC_ActPromo.AutoSize = true;
            this.label_MC_ActPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MC_ActPromo.Location = new System.Drawing.Point(448, 250);
            this.label_MC_ActPromo.Name = "label_MC_ActPromo";
            this.label_MC_ActPromo.Size = new System.Drawing.Size(127, 13);
            this.label_MC_ActPromo.TabIndex = 17;
            this.label_MC_ActPromo.Text = "¿Activar promoción?:";
            // 
            // button_MC_Nueva
            // 
            this.button_MC_Nueva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_MC_Nueva.Location = new System.Drawing.Point(448, 580);
            this.button_MC_Nueva.Name = "button_MC_Nueva";
            this.button_MC_Nueva.Size = new System.Drawing.Size(125, 23);
            this.button_MC_Nueva.TabIndex = 6;
            this.button_MC_Nueva.Text = "Nueva";
            this.button_MC_Nueva.UseVisualStyleBackColor = true;
            // 
            // label_MC_Descripcion
            // 
            this.label_MC_Descripcion.AutoSize = true;
            this.label_MC_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MC_Descripcion.Location = new System.Drawing.Point(445, 123);
            this.label_MC_Descripcion.Name = "label_MC_Descripcion";
            this.label_MC_Descripcion.Size = new System.Drawing.Size(78, 13);
            this.label_MC_Descripcion.TabIndex = 15;
            this.label_MC_Descripcion.Text = "Descripción:";
            // 
            // textBox_MC_NomPromo
            // 
            this.textBox_MC_NomPromo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_MC_NomPromo.Location = new System.Drawing.Point(448, 42);
            this.textBox_MC_NomPromo.Name = "textBox_MC_NomPromo";
            this.textBox_MC_NomPromo.Size = new System.Drawing.Size(442, 20);
            this.textBox_MC_NomPromo.TabIndex = 2;
            // 
            // label_MC_Nombre
            // 
            this.label_MC_Nombre.AutoSize = true;
            this.label_MC_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MC_Nombre.Location = new System.Drawing.Point(445, 26);
            this.label_MC_Nombre.Name = "label_MC_Nombre";
            this.label_MC_Nombre.Size = new System.Drawing.Size(148, 13);
            this.label_MC_Nombre.TabIndex = 13;
            this.label_MC_Nombre.Text = "Nombre de la promoción:";
            // 
            // textBox_MC_Descripcion
            // 
            this.textBox_MC_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_MC_Descripcion.Location = new System.Drawing.Point(448, 139);
            this.textBox_MC_Descripcion.Multiline = true;
            this.textBox_MC_Descripcion.Name = "textBox_MC_Descripcion";
            this.textBox_MC_Descripcion.Size = new System.Drawing.Size(442, 108);
            this.textBox_MC_Descripcion.TabIndex = 3;
            // 
            // button_MC_Eliminar
            // 
            this.button_MC_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_MC_Eliminar.Location = new System.Drawing.Point(765, 580);
            this.button_MC_Eliminar.Name = "button_MC_Eliminar";
            this.button_MC_Eliminar.Size = new System.Drawing.Size(125, 23);
            this.button_MC_Eliminar.TabIndex = 8;
            this.button_MC_Eliminar.Text = "Eliminar";
            this.button_MC_Eliminar.UseVisualStyleBackColor = true;
            // 
            // button_MC_Guardar
            // 
            this.button_MC_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_MC_Guardar.Location = new System.Drawing.Point(608, 580);
            this.button_MC_Guardar.Name = "button_MC_Guardar";
            this.button_MC_Guardar.Size = new System.Drawing.Size(125, 23);
            this.button_MC_Guardar.TabIndex = 7;
            this.button_MC_Guardar.Text = "Guardar cambios";
            this.button_MC_Guardar.UseVisualStyleBackColor = true;
            // 
            // label_MC_ClientesAfectados
            // 
            this.label_MC_ClientesAfectados.AutoSize = true;
            this.label_MC_ClientesAfectados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MC_ClientesAfectados.Location = new System.Drawing.Point(3, 10);
            this.label_MC_ClientesAfectados.Name = "label_MC_ClientesAfectados";
            this.label_MC_ClientesAfectados.Size = new System.Drawing.Size(258, 13);
            this.label_MC_ClientesAfectados.TabIndex = 5;
            this.label_MC_ClientesAfectados.Text = "Lista de promociones mediante condiciones:";
            // 
            // dataGridView_MC_ListaPromosCond
            // 
            this.dataGridView_MC_ListaPromosCond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_MC_ListaPromosCond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MC_ListaPromosCond.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MC_NOMBRE,
            this.Estado});
            this.dataGridView_MC_ListaPromosCond.Location = new System.Drawing.Point(3, 26);
            this.dataGridView_MC_ListaPromosCond.Name = "dataGridView_MC_ListaPromosCond";
            this.dataGridView_MC_ListaPromosCond.Size = new System.Drawing.Size(439, 577);
            this.dataGridView_MC_ListaPromosCond.TabIndex = 1;
            // 
            // MC_NOMBRE
            // 
            this.MC_NOMBRE.HeaderText = "NOMBRE";
            this.MC_NOMBRE.Name = "MC_NOMBRE";
            this.MC_NOMBRE.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "¿Activado?";
            this.Estado.Name = "Estado";
            // 
            // pictureBox_MC_CartelPromo
            // 
            this.pictureBox_MC_CartelPromo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_MC_CartelPromo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_MC_CartelPromo.Image = global::Events4ALL.Properties.Resources.image_default;
            this.pictureBox_MC_CartelPromo.Location = new System.Drawing.Point(451, 303);
            this.pictureBox_MC_CartelPromo.Name = "pictureBox_MC_CartelPromo";
            this.pictureBox_MC_CartelPromo.Size = new System.Drawing.Size(439, 272);
            this.pictureBox_MC_CartelPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_MC_CartelPromo.TabIndex = 18;
            this.pictureBox_MC_CartelPromo.TabStop = false;
            // 
            // label_MC_CartelPromo
            // 
            this.label_MC_CartelPromo.AutoSize = true;
            this.label_MC_CartelPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MC_CartelPromo.Location = new System.Drawing.Point(448, 278);
            this.label_MC_CartelPromo.Name = "label_MC_CartelPromo";
            this.label_MC_CartelPromo.Size = new System.Drawing.Size(138, 13);
            this.label_MC_CartelPromo.TabIndex = 19;
            this.label_MC_CartelPromo.Text = "Cartel de la promoción:";
            // 
            // button_MC_SubirFoto
            // 
            this.button_MC_SubirFoto.Location = new System.Drawing.Point(608, 273);
            this.button_MC_SubirFoto.Name = "button_MC_SubirFoto";
            this.button_MC_SubirFoto.Size = new System.Drawing.Size(125, 23);
            this.button_MC_SubirFoto.TabIndex = 5;
            this.button_MC_SubirFoto.Text = "Seleccionar imágen";
            this.button_MC_SubirFoto.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PE_imagEspec)).EndInit();
            this.groupBox_PE_promoGen.ResumeLayout(false);
            this.groupBox_PE_promoGen.PerformLayout();
            this.groupBox_PE_promoEvent.ResumeLayout(false);
            this.groupBox_PE_promoEvent.PerformLayout();
            this.groupBox_PE_DatosEspec.ResumeLayout(false);
            this.groupBox_PE_DatosEspec.PerformLayout();
            this.tab_Mediante_condiciones.ResumeLayout(false);
            this.tab_Mediante_condiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MC_ListaPromosCond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MC_CartelPromo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_promociones;
        private System.Windows.Forms.TabPage tab_Por_espectaculo;
        private System.Windows.Forms.TabPage tab_Mediante_condiciones;
        private System.Windows.Forms.Label label_PE_Espectaculo;
        private System.Windows.Forms.ComboBox comboBox_PE_espectaculo;
        private System.Windows.Forms.Button button_MC_Eliminar;
        private System.Windows.Forms.Button button_MC_Guardar;
        private System.Windows.Forms.Label label_MC_ClientesAfectados;
        private System.Windows.Forms.DataGridView dataGridView_MC_ListaPromosCond;
        private System.Windows.Forms.DataGridViewTextBoxColumn MC_NOMBRE;
        private System.Windows.Forms.GroupBox groupBox_PE_DatosEspec;
        private System.Windows.Forms.Label label_PE_fecha;
        private System.Windows.Forms.Label label_PE_titulo;
        private System.Windows.Forms.Label label_PE_TTitulo;
        private System.Windows.Forms.Label label_PE_TFecha;
        private System.Windows.Forms.GroupBox groupBox_PE_promoEvent;
        private System.Windows.Forms.RadioButton radioButton_PE_20;
        private System.Windows.Forms.RadioButton radioButton_PE_5;
        private System.Windows.Forms.GroupBox groupBox_PE_promoGen;
        private System.Windows.Forms.CheckBox checkBox_PE_descParado;
        private System.Windows.Forms.CheckBox checkBox_PE_descJubilado;
        private System.Windows.Forms.CheckBox checkBox_PE_descEstudiante;
        private System.Windows.Forms.CheckBox checkBox_PE_descCliente;
        private System.Windows.Forms.CheckBox checkBox_PE_mayor65;
        private System.Windows.Forms.CheckBox checkBox_PE_menor25;
        private System.Windows.Forms.RadioButton radioButton_PE_IVA;
        private System.Windows.Forms.RadioButton radioButton_PE_otroDesc;
        private System.Windows.Forms.TextBox textBox_PE_TOtroDesc;
        private System.Windows.Forms.RadioButton radioButton_PE_50;
        private System.Windows.Forms.RadioButton radioButton_PE_10;
        private System.Windows.Forms.TextBox textBox_MC_Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.Label label_PE_TDescripcion;
        private System.Windows.Forms.Label label_PE_Descripcion;
        private System.Windows.Forms.Label label_PE_SAsig;
        private System.Windows.Forms.Label label_PE_TSAsig;
        private System.Windows.Forms.Label label_PE_Precio;
        private System.Windows.Forms.Label label_PE_TPrecio;
        private System.Windows.Forms.PictureBox pictureBox_PE_imagEspec;
        private System.Windows.Forms.Button button_MC_Nueva;
        private System.Windows.Forms.Label label_MC_Descripcion;
        private System.Windows.Forms.TextBox textBox_MC_NomPromo;
        private System.Windows.Forms.Label label_MC_Nombre;
        private System.Windows.Forms.CheckBox checkBox_MC_ActPromo;
        private System.Windows.Forms.Label label_MC_ActPromo;
        private System.Windows.Forms.Button button_MC_SubirFoto;
        private System.Windows.Forms.Label label_MC_CartelPromo;
        private System.Windows.Forms.PictureBox pictureBox_MC_CartelPromo;
    }
}
