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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Espectaculos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridEspectaculos = new System.Windows.Forms.DataGridView();
            this.IdEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuardarEsp = new System.Windows.Forms.Button();
            this.btFormNuevo = new System.Windows.Forms.Button();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbHorSeparador = new System.Windows.Forms.Label();
            this.listHorarios = new System.Windows.Forms.ListBox();
            this.btAddHorario = new System.Windows.Forms.Button();
            this.numMinHorario = new System.Windows.Forms.NumericUpDown();
            this.numHoraHorario = new System.Windows.Forms.NumericUpDown();
            this.btBorrarHorario = new System.Windows.Forms.Button();
            this.lbHorarios = new System.Windows.Forms.Label();
            this.lbMedia = new System.Windows.Forms.Label();
            this.tbMedia = new System.Windows.Forms.TextBox();
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
            this.errPrvEspectaculo = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspectaculos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBuscar)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvEspectaculo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridEspectaculos);
            this.tabPage2.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridEspectaculos
            // 
            this.dataGridEspectaculos.AllowUserToAddRows = false;
            this.dataGridEspectaculos.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dataGridEspectaculos, "dataGridEspectaculos");
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
            this.dataGridEspectaculos.Name = "dataGridEspectaculos";
            this.dataGridEspectaculos.ReadOnly = true;
            this.dataGridEspectaculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEspectaculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEspectaculos_CellClick);
            // 
            // IdEsp
            // 
            this.IdEsp.FillWeight = 20F;
            resources.ApplyResources(this.IdEsp, "IdEsp");
            this.IdEsp.Name = "IdEsp";
            this.IdEsp.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 140F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 70F;
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 70F;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 80F;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 80F;
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 35F;
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Image = global::Events4ALL.Properties.Resources.edit;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 35F;
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Image = global::Events4ALL.Properties.Resources.delete;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btLimpBusqueda
            // 
            resources.ApplyResources(this.btLimpBusqueda, "btLimpBusqueda");
            this.btLimpBusqueda.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.btLimpBusqueda.Name = "btLimpBusqueda";
            this.btLimpBusqueda.UseVisualStyleBackColor = true;
            this.btLimpBusqueda.Click += new System.EventHandler(this.btLimpBusqueda_Click);
            // 
            // numPrecioBuscar
            // 
            resources.ApplyResources(this.numPrecioBuscar, "numPrecioBuscar");
            this.numPrecioBuscar.Name = "numPrecioBuscar";
            // 
            // cbPrecioBuscar
            // 
            this.cbPrecioBuscar.DisplayMember = "0";
            this.cbPrecioBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrecioBuscar.FormattingEnabled = true;
            this.cbPrecioBuscar.Items.AddRange(new object[] {
            resources.GetString("cbPrecioBuscar.Items"),
            resources.GetString("cbPrecioBuscar.Items1"),
            resources.GetString("cbPrecioBuscar.Items2")});
            resources.ApplyResources(this.cbPrecioBuscar, "cbPrecioBuscar");
            this.cbPrecioBuscar.Name = "cbPrecioBuscar";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // cbTipoBuscar
            // 
            this.cbTipoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBuscar.FormattingEnabled = true;
            this.cbTipoBuscar.Items.AddRange(new object[] {
            resources.GetString("cbTipoBuscar.Items"),
            resources.GetString("cbTipoBuscar.Items1"),
            resources.GetString("cbTipoBuscar.Items2")});
            resources.ApplyResources(this.cbTipoBuscar, "cbTipoBuscar");
            this.cbTipoBuscar.Name = "cbTipoBuscar";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbFechaBuscar
            // 
            this.cbFechaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFechaBuscar.FormattingEnabled = true;
            this.cbFechaBuscar.Items.AddRange(new object[] {
            resources.GetString("cbFechaBuscar.Items"),
            resources.GetString("cbFechaBuscar.Items1"),
            resources.GetString("cbFechaBuscar.Items2")});
            resources.ApplyResources(this.cbFechaBuscar, "cbFechaBuscar");
            this.cbFechaBuscar.Name = "cbFechaBuscar";
            // 
            // cbSalaBuscar
            // 
            this.cbSalaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalaBuscar.FormattingEnabled = true;
            resources.ApplyResources(this.cbSalaBuscar, "cbSalaBuscar");
            this.cbSalaBuscar.Name = "cbSalaBuscar";
            this.cbSalaBuscar.DropDown += new System.EventHandler(this.cbSalaBuscar_DropDown);
            // 
            // dtFechaBuscar
            // 
            this.dtFechaBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtFechaBuscar, "dtFechaBuscar");
            this.dtFechaBuscar.Name = "dtFechaBuscar";
            // 
            // Nombre
            // 
            resources.ApplyResources(this.Nombre, "Nombre");
            this.Nombre.Name = "Nombre";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbTitBuscar
            // 
            resources.ApplyResources(this.tbTitBuscar, "tbTitBuscar");
            this.tbTitBuscar.Name = "tbTitBuscar";
            // 
            // btBuscar
            // 
            resources.ApplyResources(this.btBuscar, "btBuscar");
            this.btBuscar.Image = global::Events4ALL.Properties.Resources.search_icon;
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuardarEsp);
            this.tabPage1.Controls.Add(this.btFormNuevo);
            this.tabPage1.Controls.Add(this.btInsertar);
            this.tabPage1.Controls.Add(this.btLimpiar);
            this.tabPage1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEsp
            // 
            resources.ApplyResources(this.btnGuardarEsp, "btnGuardarEsp");
            this.btnGuardarEsp.Image = global::Events4ALL.Properties.Resources.add_save;
            this.btnGuardarEsp.Name = "btnGuardarEsp";
            this.btnGuardarEsp.UseVisualStyleBackColor = true;
            this.btnGuardarEsp.Click += new System.EventHandler(this.btnGuardarEsp_Click);
            // 
            // btFormNuevo
            // 
            resources.ApplyResources(this.btFormNuevo, "btFormNuevo");
            this.btFormNuevo.Image = global::Events4ALL.Properties.Resources.mas;
            this.btFormNuevo.Name = "btFormNuevo";
            this.btFormNuevo.UseVisualStyleBackColor = true;
            this.btFormNuevo.Click += new System.EventHandler(this.btFormNuevo_Click);
            // 
            // btInsertar
            // 
            resources.ApplyResources(this.btInsertar, "btInsertar");
            this.btInsertar.Image = global::Events4ALL.Properties.Resources.add_save;
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btLimpiar
            // 
            resources.ApplyResources(this.btLimpiar, "btLimpiar");
            this.btLimpiar.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.lbHorSeparador);
            this.groupBox2.Controls.Add(this.listHorarios);
            this.groupBox2.Controls.Add(this.btAddHorario);
            this.groupBox2.Controls.Add(this.numMinHorario);
            this.groupBox2.Controls.Add(this.numHoraHorario);
            this.groupBox2.Controls.Add(this.btBorrarHorario);
            this.groupBox2.Controls.Add(this.lbHorarios);
            this.groupBox2.Controls.Add(this.lbMedia);
            this.groupBox2.Controls.Add(this.tbMedia);
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
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lbHorSeparador
            // 
            resources.ApplyResources(this.lbHorSeparador, "lbHorSeparador");
            this.lbHorSeparador.Name = "lbHorSeparador";
            // 
            // listHorarios
            // 
            this.listHorarios.FormattingEnabled = true;
            resources.ApplyResources(this.listHorarios, "listHorarios");
            this.listHorarios.Name = "listHorarios";
            this.listHorarios.SelectedIndexChanged += new System.EventHandler(this.listHorarios_SelectedIndexChanged);
            // 
            // btAddHorario
            // 
            resources.ApplyResources(this.btAddHorario, "btAddHorario");
            this.btAddHorario.Name = "btAddHorario";
            this.btAddHorario.UseVisualStyleBackColor = true;
            this.btAddHorario.Click += new System.EventHandler(this.btAddHorario_Click);
            // 
            // numMinHorario
            // 
            resources.ApplyResources(this.numMinHorario, "numMinHorario");
            this.numMinHorario.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinHorario.Name = "numMinHorario";
            // 
            // numHoraHorario
            // 
            resources.ApplyResources(this.numHoraHorario, "numHoraHorario");
            this.numHoraHorario.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHoraHorario.Name = "numHoraHorario";
            // 
            // btBorrarHorario
            // 
            resources.ApplyResources(this.btBorrarHorario, "btBorrarHorario");
            this.btBorrarHorario.Name = "btBorrarHorario";
            this.btBorrarHorario.UseVisualStyleBackColor = true;
            this.btBorrarHorario.Click += new System.EventHandler(this.btBorrarHorario_Click);
            // 
            // lbHorarios
            // 
            resources.ApplyResources(this.lbHorarios, "lbHorarios");
            this.lbHorarios.Name = "lbHorarios";
            // 
            // lbMedia
            // 
            resources.ApplyResources(this.lbMedia, "lbMedia");
            this.lbMedia.Name = "lbMedia";
            // 
            // tbMedia
            // 
            resources.ApplyResources(this.tbMedia, "tbMedia");
            this.tbMedia.Name = "tbMedia";
            // 
            // cbGenero
            // 
            this.cbGenero.DisplayMember = "1;2";
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            resources.GetString("cbGenero.Items"),
            resources.GetString("cbGenero.Items1"),
            resources.GetString("cbGenero.Items2"),
            resources.GetString("cbGenero.Items3"),
            resources.GetString("cbGenero.Items4")});
            resources.ApplyResources(this.cbGenero, "cbGenero");
            this.cbGenero.Name = "cbGenero";
            // 
            // lbGenero
            // 
            resources.ApplyResources(this.lbGenero, "lbGenero");
            this.lbGenero.Name = "lbGenero";
            // 
            // cbTipo
            // 
            this.cbTipo.DisplayMember = "1;2";
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            resources.GetString("cbTipo.Items"),
            resources.GetString("cbTipo.Items1"),
            resources.GetString("cbTipo.Items2")});
            resources.ApplyResources(this.cbTipo, "cbTipo");
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lbTipo
            // 
            resources.ApplyResources(this.lbTipo, "lbTipo");
            this.lbTipo.Name = "lbTipo";
            // 
            // numPrecio
            // 
            resources.ApplyResources(this.numPrecio, "numPrecio");
            this.numPrecio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // cbSala
            // 
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbSala, "cbSala");
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Name = "cbSala";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtFechaFin, "dtFechaFin");
            this.dtFechaFin.Name = "dtFechaFin";
            // 
            // lbFechaFin
            // 
            resources.ApplyResources(this.lbFechaFin, "lbFechaFin");
            this.lbFechaFin.Name = "lbFechaFin";
            // 
            // lbDescripcion
            // 
            resources.ApplyResources(this.lbDescripcion, "lbDescripcion");
            this.lbDescripcion.Name = "lbDescripcion";
            // 
            // lbFechaIni
            // 
            resources.ApplyResources(this.lbFechaIni, "lbFechaIni");
            this.lbFechaIni.Name = "lbFechaIni";
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtFechaIni, "dtFechaIni");
            this.dtFechaIni.Name = "dtFechaIni";
            // 
            // btCartel
            // 
            resources.ApplyResources(this.btCartel, "btCartel");
            this.btCartel.Image = global::Events4ALL.Properties.Resources.photo;
            this.btCartel.Name = "btCartel";
            this.btCartel.UseVisualStyleBackColor = true;
            this.btCartel.Click += new System.EventHandler(this.btCartel_Click);
            // 
            // tbDescripcion
            // 
            resources.ApplyResources(this.tbDescripcion, "tbDescripcion");
            this.tbDescripcion.Name = "tbDescripcion";
            // 
            // tbTitulo
            // 
            resources.ApplyResources(this.tbTitulo, "tbTitulo");
            this.tbTitulo.Name = "tbTitulo";
            // 
            // lbFechas
            // 
            resources.ApplyResources(this.lbFechas, "lbFechas");
            this.lbFechas.Name = "lbFechas";
            // 
            // lbTitulo
            // 
            resources.ApplyResources(this.lbTitulo, "lbTitulo");
            this.lbTitulo.Name = "lbTitulo";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // pbCartel
            // 
            resources.ApplyResources(this.pbCartel, "pbCartel");
            this.pbCartel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCartel.Image = global::Events4ALL.Properties.Resources.image_default;
            this.pbCartel.Name = "pbCartel";
            this.pbCartel.TabStop = false;
            // 
            // errPrvEspectaculo
            // 
            this.errPrvEspectaculo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPrvEspectaculo.ContainerControl = this;
            resources.ApplyResources(this.errPrvEspectaculo, "errPrvEspectaculo");
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 35F;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::Events4ALL.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 35F;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = global::Events4ALL.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // Espectaculos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Espectaculos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspectaculos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBuscar)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartel)).EndInit();
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
        private System.Windows.Forms.Button btFormNuevo;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.Label lbMedia;
        private System.Windows.Forms.TextBox tbMedia;
        private System.Windows.Forms.Label lbHorarios;
        private System.Windows.Forms.Button btBorrarHorario;
        private System.Windows.Forms.Button btAddHorario;
        private System.Windows.Forms.NumericUpDown numMinHorario;
        private System.Windows.Forms.NumericUpDown numHoraHorario;
        private System.Windows.Forms.ListBox listHorarios;
        private System.Windows.Forms.Label lbHorSeparador;
    }
}
