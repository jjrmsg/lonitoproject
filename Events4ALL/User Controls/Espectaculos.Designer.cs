namespace Events4ALL
{
    partial class Espectaculos
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
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarEsp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lbGenero = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbFechaIni = new System.Windows.Forms.Label();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.btCartel = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lbFechas = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbCartel = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridEspectaculos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLimpBusqueda = new System.Windows.Forms.Button();
            this.numPrecioBuscar = new System.Windows.Forms.NumericUpDown();
            this.cbPrecioBuscar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTipoBuscar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFechaBuscar = new System.Windows.Forms.ComboBox();
            this.cbSalaBuscar = new System.Windows.Forms.ComboBox();
            this.dtFechaBuscar = new System.Windows.Forms.DateTimePicker();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.errPrvEspectaculo = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartel)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspectaculos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvEspectaculo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 632);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btLimpiar);
            this.tabPage1.Controls.Add(this.btnGuardarEsp);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Espectáculo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.btLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpiar.Location = new System.Drawing.Point(748, 577);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(64, 23);
            this.btLimpiar.TabIndex = 11;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btnGuardarEsp
            // 
            this.btnGuardarEsp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEsp.Image = global::Events4ALL.Properties.Resources.add_save;
            this.btnGuardarEsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarEsp.Location = new System.Drawing.Point(818, 577);
            this.btnGuardarEsp.Name = "btnGuardarEsp";
            this.btnGuardarEsp.Size = new System.Drawing.Size(69, 23);
            this.btnGuardarEsp.TabIndex = 10;
            this.btnGuardarEsp.Text = "Guardar";
            this.btnGuardarEsp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEsp.UseVisualStyleBackColor = true;
            this.btnGuardarEsp.Click += new System.EventHandler(this.btnGuardarEsp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbGenero);
            this.groupBox2.Controls.Add(this.lbGenero);
            this.groupBox2.Controls.Add(this.cbTipo);
            this.groupBox2.Controls.Add(this.lbTipo);
            this.groupBox2.Controls.Add(this.numPrecio);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbSala);
            this.groupBox2.Controls.Add(this.dtFechaFin);
            this.groupBox2.Controls.Add(this.lbFechaFin);
            this.groupBox2.Controls.Add(this.lbDescripcion);
            this.groupBox2.Controls.Add(this.lbFechaIni);
            this.groupBox2.Controls.Add(this.dtFechaIni);
            this.groupBox2.Controls.Add(this.btCartel);
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Controls.Add(this.tbTitulo);
            this.groupBox2.Controls.Add(this.lbFechas);
            this.groupBox2.Controls.Add(this.lbTitulo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pbCartel);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 565);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del espectáculo";
            // 
            // cbGenero
            // 
            this.cbGenero.DisplayMember = "1;2";
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Acción",
            "Aventura",
            "Comedia",
            "Romántica",
            "Terror"});
            this.cbGenero.Location = new System.Drawing.Point(122, 241);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 4;
            this.cbGenero.Visible = false;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(119, 225);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(42, 13);
            this.lbGenero.TabIndex = 19;
            this.lbGenero.Text = "Genero";
            this.lbGenero.Visible = false;
            // 
            // cbTipo
            // 
            this.cbTipo.DisplayMember = "1;2";
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Cine",
            "Teatro",
            "Concierto"});
            this.cbTipo.Location = new System.Drawing.Point(19, 241);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(77, 21);
            this.cbTipo.TabIndex = 3;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(16, 225);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(28, 13);
            this.lbTipo.TabIndex = 17;
            this.lbTipo.Text = "Tipo";
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(93, 332);
            this.numPrecio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(53, 20);
            this.numPrecio.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sala asignada";
            // 
            // cbSala
            // 
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSala.Enabled = false;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(93, 295);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(121, 21);
            this.cbSala.TabIndex = 5;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(93, 428);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(93, 20);
            this.dtFechaFin.TabIndex = 8;
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(44, 432);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(21, 13);
            this.lbFechaFin.TabIndex = 11;
            this.lbFechaFin.Text = "Fin";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(16, 72);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 6;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbFechaIni
            // 
            this.lbFechaIni.AutoSize = true;
            this.lbFechaIni.Location = new System.Drawing.Point(44, 406);
            this.lbFechaIni.Name = "lbFechaIni";
            this.lbFechaIni.Size = new System.Drawing.Size(32, 13);
            this.lbFechaIni.TabIndex = 10;
            this.lbFechaIni.Text = "Inicio";
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(93, 402);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(93, 20);
            this.dtFechaIni.TabIndex = 7;
            // 
            // btCartel
            // 
            this.btCartel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCartel.Image = global::Events4ALL.Properties.Resources.photo;
            this.btCartel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCartel.Location = new System.Drawing.Point(742, 225);
            this.btCartel.Name = "btCartel";
            this.btCartel.Size = new System.Drawing.Size(109, 23);
            this.btCartel.TabIndex = 9;
            this.btCartel.Text = "Cambiar imágen";
            this.btCartel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCartel.UseVisualStyleBackColor = true;
            this.btCartel.Click += new System.EventHandler(this.btCartel_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(19, 92);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(670, 109);
            this.tbDescripcion.TabIndex = 2;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(56, 34);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(409, 20);
            this.tbTitulo.TabIndex = 1;
            // 
            // lbFechas
            // 
            this.lbFechas.AutoSize = true;
            this.lbFechas.Location = new System.Drawing.Point(14, 382);
            this.lbFechas.Name = "lbFechas";
            this.lbFechas.Size = new System.Drawing.Size(45, 13);
            this.lbFechas.TabIndex = 8;
            this.lbFechas.Text = "Fechas:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(15, 37);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(35, 13);
            this.lbTitulo.TabIndex = 5;
            this.lbTitulo.Text = "Título";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(784, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cartel";
            // 
            // pbCartel
            // 
            this.pbCartel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCartel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCartel.Image = global::Events4ALL.Properties.Resources.image_default;
            this.pbCartel.Location = new System.Drawing.Point(733, 50);
            this.pbCartel.Name = "pbCartel";
            this.pbCartel.Size = new System.Drawing.Size(132, 169);
            this.pbCartel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCartel.TabIndex = 0;
            this.pbCartel.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridEspectaculos);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Búsqueda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridEspectaculos
            // 
            this.dataGridEspectaculos.AllowUserToAddRows = false;
            this.dataGridEspectaculos.AllowUserToOrderColumns = true;
            this.dataGridEspectaculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEspectaculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEspectaculos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEspectaculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEspectaculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEsp,
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column8,
            this.Column7});
            this.dataGridEspectaculos.Location = new System.Drawing.Point(6, 168);
            this.dataGridEspectaculos.Name = "dataGridEspectaculos";
            this.dataGridEspectaculos.ReadOnly = true;
            this.dataGridEspectaculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEspectaculos.Size = new System.Drawing.Size(878, 432);
            this.dataGridEspectaculos.TabIndex = 6;
            this.dataGridEspectaculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEspectaculos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btLimpBusqueda);
            this.groupBox1.Controls.Add(this.numPrecioBuscar);
            this.groupBox1.Controls.Add(this.cbPrecioBuscar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbTipoBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbFechaBuscar);
            this.groupBox1.Controls.Add(this.cbSalaBuscar);
            this.groupBox1.Controls.Add(this.dtFechaBuscar);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTitBuscar);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de espectáculos";
            // 
            // btLimpBusqueda
            // 
            this.btLimpBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpBusqueda.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.btLimpBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpBusqueda.Location = new System.Drawing.Point(738, 117);
            this.btLimpBusqueda.Name = "btLimpBusqueda";
            this.btLimpBusqueda.Size = new System.Drawing.Size(64, 23);
            this.btLimpBusqueda.TabIndex = 52;
            this.btLimpBusqueda.Text = "Limpiar";
            this.btLimpBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpBusqueda.UseVisualStyleBackColor = true;
            this.btLimpBusqueda.Click += new System.EventHandler(this.btLimpBusqueda_Click);
            // 
            // numPrecioBuscar
            // 
            this.numPrecioBuscar.Location = new System.Drawing.Point(144, 111);
            this.numPrecioBuscar.Name = "numPrecioBuscar";
            this.numPrecioBuscar.Size = new System.Drawing.Size(54, 20);
            this.numPrecioBuscar.TabIndex = 16;
            // 
            // cbPrecioBuscar
            // 
            this.cbPrecioBuscar.DisplayMember = "0";
            this.cbPrecioBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrecioBuscar.FormattingEnabled = true;
            this.cbPrecioBuscar.Items.AddRange(new object[] {
            "igual a",
            "mayor que",
            "menor que"});
            this.cbPrecioBuscar.Location = new System.Drawing.Point(51, 111);
            this.cbPrecioBuscar.Name = "cbPrecioBuscar";
            this.cbPrecioBuscar.Size = new System.Drawing.Size(77, 21);
            this.cbPrecioBuscar.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Precio";
            // 
            // cbTipoBuscar
            // 
            this.cbTipoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBuscar.FormattingEnabled = true;
            this.cbTipoBuscar.Items.AddRange(new object[] {
            "Cine",
            "Teatro",
            "Concierto"});
            this.cbTipoBuscar.Location = new System.Drawing.Point(549, 31);
            this.cbTipoBuscar.Name = "cbTipoBuscar";
            this.cbTipoBuscar.Size = new System.Drawing.Size(121, 21);
            this.cbTipoBuscar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de evento";
            // 
            // cbFechaBuscar
            // 
            this.cbFechaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFechaBuscar.FormattingEnabled = true;
            this.cbFechaBuscar.Items.AddRange(new object[] {
            "igual a",
            "mayor que",
            "menor que"});
            this.cbFechaBuscar.Location = new System.Drawing.Point(51, 73);
            this.cbFechaBuscar.Name = "cbFechaBuscar";
            this.cbFechaBuscar.Size = new System.Drawing.Size(77, 21);
            this.cbFechaBuscar.TabIndex = 8;
            // 
            // cbSalaBuscar
            // 
            this.cbSalaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalaBuscar.FormattingEnabled = true;
            this.cbSalaBuscar.Location = new System.Drawing.Point(309, 31);
            this.cbSalaBuscar.Name = "cbSalaBuscar";
            this.cbSalaBuscar.Size = new System.Drawing.Size(137, 21);
            this.cbSalaBuscar.TabIndex = 7;
            // 
            // dtFechaBuscar
            // 
            this.dtFechaBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaBuscar.Location = new System.Drawing.Point(144, 74);
            this.dtFechaBuscar.Name = "dtFechaBuscar";
            this.dtFechaBuscar.Size = new System.Drawing.Size(94, 20);
            this.dtFechaBuscar.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(8, 34);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(35, 13);
            this.Nombre.TabIndex = 5;
            this.Nombre.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sala asignada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // tbTitBuscar
            // 
            this.tbTitBuscar.Location = new System.Drawing.Point(51, 31);
            this.tbTitBuscar.Name = "tbTitBuscar";
            this.tbTitBuscar.Size = new System.Drawing.Size(160, 20);
            this.tbTitBuscar.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Image = global::Events4ALL.Properties.Resources.search_icon;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(808, 117);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(64, 23);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // errPrvEspectaculo
            // 
            this.errPrvEspectaculo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPrvEspectaculo.ContainerControl = this;
            // 
            // IdEsp
            // 
            this.IdEsp.FillWeight = 20F;
            this.IdEsp.HeaderText = "Id";
            this.IdEsp.Name = "IdEsp";
            this.IdEsp.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 140F;
            this.Column1.HeaderText = "Título";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 70F;
            this.Column6.HeaderText = "Tipo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "Sala asignada";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Fecha Inicio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "Fecha Fin";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 50F;
            this.Column8.HeaderText = "Editar";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 30F;
            this.Column7.HeaderText = "Eliminar";
            this.Column7.Image = global::Events4ALL.Properties.Resources.delete;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Espectaculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Espectaculos";
            this.Size = new System.Drawing.Size(907, 635);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartel)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspectaculos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvEspectaculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridEspectaculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitBuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DateTimePicker dtFechaBuscar;
        private System.Windows.Forms.ComboBox cbFechaBuscar;
        private System.Windows.Forms.ComboBox cbSalaBuscar;
        private System.Windows.Forms.ComboBox cbTipoBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCartel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbFechas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button btnGuardarEsp;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.Label lbFechaIni;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.Button btCartel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.NumericUpDown numPrecioBuscar;
        private System.Windows.Forms.ComboBox cbPrecioBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btLimpBusqueda;
        public System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.ErrorProvider errPrvEspectaculo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
    }
}
