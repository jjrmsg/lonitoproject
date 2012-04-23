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
            this.errPrvEspectaculo.SetError(this.tabControl1, resources.GetString("tabControl1.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding"))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.dataGridEspectaculos);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.errPrvEspectaculo.SetError(this.tabPage2, resources.GetString("tabPage2.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.tabPage2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage2.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.tabPage2, ((int)(resources.GetObject("tabPage2.IconPadding"))));
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridEspectaculos
            // 
            resources.ApplyResources(this.dataGridEspectaculos, "dataGridEspectaculos");
            this.dataGridEspectaculos.AllowUserToAddRows = false;
            this.dataGridEspectaculos.AllowUserToOrderColumns = true;
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
            this.errPrvEspectaculo.SetError(this.dataGridEspectaculos, resources.GetString("dataGridEspectaculos.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.dataGridEspectaculos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridEspectaculos.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.dataGridEspectaculos, ((int)(resources.GetObject("dataGridEspectaculos.IconPadding"))));
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
            this.errPrvEspectaculo.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btLimpBusqueda
            // 
            resources.ApplyResources(this.btLimpBusqueda, "btLimpBusqueda");
            this.errPrvEspectaculo.SetError(this.btLimpBusqueda, resources.GetString("btLimpBusqueda.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.btLimpBusqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btLimpBusqueda.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.btLimpBusqueda, ((int)(resources.GetObject("btLimpBusqueda.IconPadding"))));
            this.btLimpBusqueda.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.btLimpBusqueda.Name = "btLimpBusqueda";
            this.btLimpBusqueda.UseVisualStyleBackColor = true;
            this.btLimpBusqueda.Click += new System.EventHandler(this.btLimpBusqueda_Click);
            // 
            // numPrecioBuscar
            // 
            resources.ApplyResources(this.numPrecioBuscar, "numPrecioBuscar");
            this.errPrvEspectaculo.SetError(this.numPrecioBuscar, resources.GetString("numPrecioBuscar.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.numPrecioBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("numPrecioBuscar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.numPrecioBuscar, ((int)(resources.GetObject("numPrecioBuscar.IconPadding"))));
            this.numPrecioBuscar.Name = "numPrecioBuscar";
            // 
            // cbPrecioBuscar
            // 
            resources.ApplyResources(this.cbPrecioBuscar, "cbPrecioBuscar");
            this.cbPrecioBuscar.DisplayMember = "0";
            this.cbPrecioBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errPrvEspectaculo.SetError(this.cbPrecioBuscar, resources.GetString("cbPrecioBuscar.Error"));
            this.cbPrecioBuscar.FormattingEnabled = true;
            this.errPrvEspectaculo.SetIconAlignment(this.cbPrecioBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbPrecioBuscar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.cbPrecioBuscar, ((int)(resources.GetObject("cbPrecioBuscar.IconPadding"))));
            this.cbPrecioBuscar.Items.AddRange(new object[] {
            resources.GetString("cbPrecioBuscar.Items"),
            resources.GetString("cbPrecioBuscar.Items1"),
            resources.GetString("cbPrecioBuscar.Items2")});
            this.cbPrecioBuscar.Name = "cbPrecioBuscar";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.errPrvEspectaculo.SetError(this.label12, resources.GetString("label12.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.label12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label12.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.label12, ((int)(resources.GetObject("label12.IconPadding"))));
            this.label12.Name = "label12";
            // 
            // cbTipoBuscar
            // 
            resources.ApplyResources(this.cbTipoBuscar, "cbTipoBuscar");
            this.cbTipoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errPrvEspectaculo.SetError(this.cbTipoBuscar, resources.GetString("cbTipoBuscar.Error"));
            this.cbTipoBuscar.FormattingEnabled = true;
            this.errPrvEspectaculo.SetIconAlignment(this.cbTipoBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbTipoBuscar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.cbTipoBuscar, ((int)(resources.GetObject("cbTipoBuscar.IconPadding"))));
            this.cbTipoBuscar.Items.AddRange(new object[] {
            resources.GetString("cbTipoBuscar.Items"),
            resources.GetString("cbTipoBuscar.Items1"),
            resources.GetString("cbTipoBuscar.Items2")});
            this.cbTipoBuscar.Name = "cbTipoBuscar";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errPrvEspectaculo.SetError(this.label3, resources.GetString("label3.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // cbFechaBuscar
            // 
            resources.ApplyResources(this.cbFechaBuscar, "cbFechaBuscar");
            this.cbFechaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errPrvEspectaculo.SetError(this.cbFechaBuscar, resources.GetString("cbFechaBuscar.Error"));
            this.cbFechaBuscar.FormattingEnabled = true;
            this.errPrvEspectaculo.SetIconAlignment(this.cbFechaBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbFechaBuscar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.cbFechaBuscar, ((int)(resources.GetObject("cbFechaBuscar.IconPadding"))));
            this.cbFechaBuscar.Items.AddRange(new object[] {
            resources.GetString("cbFechaBuscar.Items"),
            resources.GetString("cbFechaBuscar.Items1"),
            resources.GetString("cbFechaBuscar.Items2")});
            this.cbFechaBuscar.Name = "cbFechaBuscar";
            // 
            // cbSalaBuscar
            // 
            resources.ApplyResources(this.cbSalaBuscar, "cbSalaBuscar");
            this.cbSalaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errPrvEspectaculo.SetError(this.cbSalaBuscar, resources.GetString("cbSalaBuscar.Error"));
            this.cbSalaBuscar.FormattingEnabled = true;
            this.errPrvEspectaculo.SetIconAlignment(this.cbSalaBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbSalaBuscar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.cbSalaBuscar, ((int)(resources.GetObject("cbSalaBuscar.IconPadding"))));
            this.cbSalaBuscar.Name = "cbSalaBuscar";
            this.cbSalaBuscar.DropDown += new System.EventHandler(this.cbSalaBuscar_DropDown);
            // 
            // dtFechaBuscar
            // 
            resources.ApplyResources(this.dtFechaBuscar, "dtFechaBuscar");
            this.errPrvEspectaculo.SetError(this.dtFechaBuscar, resources.GetString("dtFechaBuscar.Error"));
            this.dtFechaBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errPrvEspectaculo.SetIconAlignment(this.dtFechaBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dtFechaBuscar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.dtFechaBuscar, ((int)(resources.GetObject("dtFechaBuscar.IconPadding"))));
            this.dtFechaBuscar.Name = "dtFechaBuscar";
            // 
            // Nombre
            // 
            resources.ApplyResources(this.Nombre, "Nombre");
            this.errPrvEspectaculo.SetError(this.Nombre, resources.GetString("Nombre.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Nombre.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.Nombre, ((int)(resources.GetObject("Nombre.IconPadding"))));
            this.Nombre.Name = "Nombre";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errPrvEspectaculo.SetError(this.label1, resources.GetString("label1.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errPrvEspectaculo.SetError(this.label2, resources.GetString("label2.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // tbTitBuscar
            // 
            resources.ApplyResources(this.tbTitBuscar, "tbTitBuscar");
            this.errPrvEspectaculo.SetError(this.tbTitBuscar, resources.GetString("tbTitBuscar.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.tbTitBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbTitBuscar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.tbTitBuscar, ((int)(resources.GetObject("tbTitBuscar.IconPadding"))));
            this.tbTitBuscar.Name = "tbTitBuscar";
            // 
            // btBuscar
            // 
            resources.ApplyResources(this.btBuscar, "btBuscar");
            this.errPrvEspectaculo.SetError(this.btBuscar, resources.GetString("btBuscar.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.btBuscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btBuscar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.btBuscar, ((int)(resources.GetObject("btBuscar.IconPadding"))));
            this.btBuscar.Image = global::Events4ALL.Properties.Resources.search_icon;
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.btnGuardarEsp);
            this.tabPage1.Controls.Add(this.btFormNuevo);
            this.tabPage1.Controls.Add(this.btInsertar);
            this.tabPage1.Controls.Add(this.btLimpiar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.errPrvEspectaculo.SetError(this.tabPage1, resources.GetString("tabPage1.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.tabPage1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabPage1.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.tabPage1, ((int)(resources.GetObject("tabPage1.IconPadding"))));
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEsp
            // 
            resources.ApplyResources(this.btnGuardarEsp, "btnGuardarEsp");
            this.errPrvEspectaculo.SetError(this.btnGuardarEsp, resources.GetString("btnGuardarEsp.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.btnGuardarEsp, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnGuardarEsp.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.btnGuardarEsp, ((int)(resources.GetObject("btnGuardarEsp.IconPadding"))));
            this.btnGuardarEsp.Image = global::Events4ALL.Properties.Resources.add_save;
            this.btnGuardarEsp.Name = "btnGuardarEsp";
            this.btnGuardarEsp.UseVisualStyleBackColor = true;
            this.btnGuardarEsp.Click += new System.EventHandler(this.btnGuardarEsp_Click);
            // 
            // btFormNuevo
            // 
            resources.ApplyResources(this.btFormNuevo, "btFormNuevo");
            this.errPrvEspectaculo.SetError(this.btFormNuevo, resources.GetString("btFormNuevo.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.btFormNuevo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btFormNuevo.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.btFormNuevo, ((int)(resources.GetObject("btFormNuevo.IconPadding"))));
            this.btFormNuevo.Image = global::Events4ALL.Properties.Resources.mas;
            this.btFormNuevo.Name = "btFormNuevo";
            this.btFormNuevo.UseVisualStyleBackColor = true;
            this.btFormNuevo.Click += new System.EventHandler(this.btFormNuevo_Click);
            // 
            // btInsertar
            // 
            resources.ApplyResources(this.btInsertar, "btInsertar");
            this.errPrvEspectaculo.SetError(this.btInsertar, resources.GetString("btInsertar.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.btInsertar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btInsertar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.btInsertar, ((int)(resources.GetObject("btInsertar.IconPadding"))));
            this.btInsertar.Image = global::Events4ALL.Properties.Resources.add_save;
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btLimpiar
            // 
            resources.ApplyResources(this.btLimpiar, "btLimpiar");
            this.errPrvEspectaculo.SetError(this.btLimpiar, resources.GetString("btLimpiar.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.btLimpiar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btLimpiar.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.btLimpiar, ((int)(resources.GetObject("btLimpiar.IconPadding"))));
            this.btLimpiar.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
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
            this.errPrvEspectaculo.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbGenero
            // 
            resources.ApplyResources(this.cbGenero, "cbGenero");
            this.cbGenero.DisplayMember = "1;2";
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errPrvEspectaculo.SetError(this.cbGenero, resources.GetString("cbGenero.Error"));
            this.cbGenero.FormattingEnabled = true;
            this.errPrvEspectaculo.SetIconAlignment(this.cbGenero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbGenero.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.cbGenero, ((int)(resources.GetObject("cbGenero.IconPadding"))));
            this.cbGenero.Items.AddRange(new object[] {
            resources.GetString("cbGenero.Items"),
            resources.GetString("cbGenero.Items1"),
            resources.GetString("cbGenero.Items2"),
            resources.GetString("cbGenero.Items3"),
            resources.GetString("cbGenero.Items4")});
            this.cbGenero.Name = "cbGenero";
            // 
            // lbGenero
            // 
            resources.ApplyResources(this.lbGenero, "lbGenero");
            this.errPrvEspectaculo.SetError(this.lbGenero, resources.GetString("lbGenero.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.lbGenero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbGenero.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.lbGenero, ((int)(resources.GetObject("lbGenero.IconPadding"))));
            this.lbGenero.Name = "lbGenero";
            // 
            // cbTipo
            // 
            resources.ApplyResources(this.cbTipo, "cbTipo");
            this.cbTipo.DisplayMember = "1;2";
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errPrvEspectaculo.SetError(this.cbTipo, resources.GetString("cbTipo.Error"));
            this.cbTipo.FormattingEnabled = true;
            this.errPrvEspectaculo.SetIconAlignment(this.cbTipo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbTipo.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.cbTipo, ((int)(resources.GetObject("cbTipo.IconPadding"))));
            this.cbTipo.Items.AddRange(new object[] {
            resources.GetString("cbTipo.Items"),
            resources.GetString("cbTipo.Items1"),
            resources.GetString("cbTipo.Items2")});
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lbTipo
            // 
            resources.ApplyResources(this.lbTipo, "lbTipo");
            this.errPrvEspectaculo.SetError(this.lbTipo, resources.GetString("lbTipo.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.lbTipo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbTipo.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.lbTipo, ((int)(resources.GetObject("lbTipo.IconPadding"))));
            this.lbTipo.Name = "lbTipo";
            // 
            // numPrecio
            // 
            resources.ApplyResources(this.numPrecio, "numPrecio");
            this.errPrvEspectaculo.SetError(this.numPrecio, resources.GetString("numPrecio.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.numPrecio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("numPrecio.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.numPrecio, ((int)(resources.GetObject("numPrecio.IconPadding"))));
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
            this.errPrvEspectaculo.SetError(this.label11, resources.GetString("label11.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errPrvEspectaculo.SetError(this.label10, resources.GetString("label10.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            // 
            // cbSala
            // 
            resources.ApplyResources(this.cbSala, "cbSala");
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errPrvEspectaculo.SetError(this.cbSala, resources.GetString("cbSala.Error"));
            this.cbSala.FormattingEnabled = true;
            this.errPrvEspectaculo.SetIconAlignment(this.cbSala, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbSala.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.cbSala, ((int)(resources.GetObject("cbSala.IconPadding"))));
            this.cbSala.Name = "cbSala";
            // 
            // dtFechaFin
            // 
            resources.ApplyResources(this.dtFechaFin, "dtFechaFin");
            this.errPrvEspectaculo.SetError(this.dtFechaFin, resources.GetString("dtFechaFin.Error"));
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errPrvEspectaculo.SetIconAlignment(this.dtFechaFin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dtFechaFin.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.dtFechaFin, ((int)(resources.GetObject("dtFechaFin.IconPadding"))));
            this.dtFechaFin.Name = "dtFechaFin";
            // 
            // lbFechaFin
            // 
            resources.ApplyResources(this.lbFechaFin, "lbFechaFin");
            this.errPrvEspectaculo.SetError(this.lbFechaFin, resources.GetString("lbFechaFin.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.lbFechaFin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbFechaFin.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.lbFechaFin, ((int)(resources.GetObject("lbFechaFin.IconPadding"))));
            this.lbFechaFin.Name = "lbFechaFin";
            // 
            // lbDescripcion
            // 
            resources.ApplyResources(this.lbDescripcion, "lbDescripcion");
            this.errPrvEspectaculo.SetError(this.lbDescripcion, resources.GetString("lbDescripcion.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.lbDescripcion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbDescripcion.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.lbDescripcion, ((int)(resources.GetObject("lbDescripcion.IconPadding"))));
            this.lbDescripcion.Name = "lbDescripcion";
            // 
            // lbFechaIni
            // 
            resources.ApplyResources(this.lbFechaIni, "lbFechaIni");
            this.errPrvEspectaculo.SetError(this.lbFechaIni, resources.GetString("lbFechaIni.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.lbFechaIni, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbFechaIni.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.lbFechaIni, ((int)(resources.GetObject("lbFechaIni.IconPadding"))));
            this.lbFechaIni.Name = "lbFechaIni";
            // 
            // dtFechaIni
            // 
            resources.ApplyResources(this.dtFechaIni, "dtFechaIni");
            this.errPrvEspectaculo.SetError(this.dtFechaIni, resources.GetString("dtFechaIni.Error"));
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errPrvEspectaculo.SetIconAlignment(this.dtFechaIni, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dtFechaIni.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.dtFechaIni, ((int)(resources.GetObject("dtFechaIni.IconPadding"))));
            this.dtFechaIni.Name = "dtFechaIni";
            // 
            // btCartel
            // 
            resources.ApplyResources(this.btCartel, "btCartel");
            this.errPrvEspectaculo.SetError(this.btCartel, resources.GetString("btCartel.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.btCartel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btCartel.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.btCartel, ((int)(resources.GetObject("btCartel.IconPadding"))));
            this.btCartel.Image = global::Events4ALL.Properties.Resources.photo;
            this.btCartel.Name = "btCartel";
            this.btCartel.UseVisualStyleBackColor = true;
            this.btCartel.Click += new System.EventHandler(this.btCartel_Click);
            // 
            // tbDescripcion
            // 
            resources.ApplyResources(this.tbDescripcion, "tbDescripcion");
            this.errPrvEspectaculo.SetError(this.tbDescripcion, resources.GetString("tbDescripcion.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.tbDescripcion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbDescripcion.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.tbDescripcion, ((int)(resources.GetObject("tbDescripcion.IconPadding"))));
            this.tbDescripcion.Name = "tbDescripcion";
            // 
            // tbTitulo
            // 
            resources.ApplyResources(this.tbTitulo, "tbTitulo");
            this.errPrvEspectaculo.SetError(this.tbTitulo, resources.GetString("tbTitulo.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.tbTitulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tbTitulo.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.tbTitulo, ((int)(resources.GetObject("tbTitulo.IconPadding"))));
            this.tbTitulo.Name = "tbTitulo";
            // 
            // lbFechas
            // 
            resources.ApplyResources(this.lbFechas, "lbFechas");
            this.errPrvEspectaculo.SetError(this.lbFechas, resources.GetString("lbFechas.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.lbFechas, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbFechas.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.lbFechas, ((int)(resources.GetObject("lbFechas.IconPadding"))));
            this.lbFechas.Name = "lbFechas";
            // 
            // lbTitulo
            // 
            resources.ApplyResources(this.lbTitulo, "lbTitulo");
            this.errPrvEspectaculo.SetError(this.lbTitulo, resources.GetString("lbTitulo.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.lbTitulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbTitulo.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.lbTitulo, ((int)(resources.GetObject("lbTitulo.IconPadding"))));
            this.lbTitulo.Name = "lbTitulo";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errPrvEspectaculo.SetError(this.label6, resources.GetString("label6.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // pbCartel
            // 
            resources.ApplyResources(this.pbCartel, "pbCartel");
            this.pbCartel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errPrvEspectaculo.SetError(this.pbCartel, resources.GetString("pbCartel.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this.pbCartel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pbCartel.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this.pbCartel, ((int)(resources.GetObject("pbCartel.IconPadding"))));
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
            this.errPrvEspectaculo.SetError(this, resources.GetString("$this.Error"));
            this.errPrvEspectaculo.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errPrvEspectaculo.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
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
    }
}
