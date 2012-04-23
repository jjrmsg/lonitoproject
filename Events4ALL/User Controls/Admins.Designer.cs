namespace Events4ALL
{
    partial class Admins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admins));
            this.Buscar = new System.Windows.Forms.TabPage();
            this.groupBox_Busqueda = new System.Windows.Forms.GroupBox();
            this.textBox_filtro_busqueda = new System.Windows.Forms.TextBox();
            this.comboBox_filtro_busqueda = new System.Windows.Forms.ComboBox();
            this.label_filtro = new System.Windows.Forms.Label();
            this.comboBox_filtro = new System.Windows.Forms.ComboBox();
            this.boton_limpia_busqueda = new System.Windows.Forms.Button();
            this.buttom_Buscar = new System.Windows.Forms.Button();
            this.Resultados_Busqueda = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Perfil = new System.Windows.Forms.TabPage();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.groupBox_UsPs = new System.Windows.Forms.GroupBox();
            this.textBox_anterior_pass = new System.Windows.Forms.TextBox();
            this.label_anterior_pass = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_pass2 = new System.Windows.Forms.TextBox();
            this.textBox_pass1 = new System.Windows.Forms.TextBox();
            this.label_pass2 = new System.Windows.Forms.Label();
            this.label_pass1 = new System.Windows.Forms.Label();
            this.textBox_NombreUsuario = new System.Windows.Forms.TextBox();
            this.label_NombreUsuario = new System.Windows.Forms.Label();
            this.Admin_Perfil_boton_Foto = new System.Windows.Forms.Button();
            this.Admin_Perfil_boton_Guardar = new System.Windows.Forms.Button();
            this.Admin_Perfil_boton_Anadir = new System.Windows.Forms.Button();
            this.Admin_Perfil_Foto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.test3 = new System.Windows.Forms.Label();
            this.test2 = new System.Windows.Forms.Label();
            this.test1 = new System.Windows.Forms.Label();
            this.comboBox_Provincia = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Admin_Perfil_Label_Tel1 = new System.Windows.Forms.Label();
            this.Admin_Perfil_Label_Tel2 = new System.Windows.Forms.Label();
            this.Admin_Perfil_Label_Mail = new System.Windows.Forms.Label();
            this.Admin_Perfil_txtBox_Tel1 = new System.Windows.Forms.TextBox();
            this.Admin_Perfil_txtBox_Tel2 = new System.Windows.Forms.TextBox();
            this.Admin_Perfil_txtBox_Mail = new System.Windows.Forms.TextBox();
            this.Label_Provincia_Perfil = new System.Windows.Forms.Label();
            this.textBox_CP_Perfil = new System.Windows.Forms.TextBox();
            this.label_CP_Perfil = new System.Windows.Forms.Label();
            this.comboBoxDirec = new System.Windows.Forms.ComboBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.Admin_Perfil_rButom_H = new System.Windows.Forms.RadioButton();
            this.Admin_Perfil_rButom_M = new System.Windows.Forms.RadioButton();
            this.Admin_Perfil_txtBox_Nombre = new System.Windows.Forms.TextBox();
            this.grupEstadoCivil = new System.Windows.Forms.GroupBox();
            this.Admin_Perfil_rButom_Divorciado = new System.Windows.Forms.RadioButton();
            this.Admin_Perfil_rButom_Soltero = new System.Windows.Forms.RadioButton();
            this.Admin_Perfil_rButom_Casado = new System.Windows.Forms.RadioButton();
            this.Admin_Perfil_rButom_Viudo = new System.Windows.Forms.RadioButton();
            this.Admin_Perfil_Label_Nombre = new System.Windows.Forms.Label();
            this.Admin_Perfil_Label_Apellidos = new System.Windows.Forms.Label();
            this.Admin_Perfil_Label_Pais = new System.Windows.Forms.Label();
            this.Label_Localidad = new System.Windows.Forms.Label();
            this.Admin_Perfil_Label_FecNacimiento = new System.Windows.Forms.Label();
            this.Admin_Perfil_Label_NIF = new System.Windows.Forms.Label();
            this.Admin_Perfil_Label_Domicilio = new System.Windows.Forms.Label();
            this.Admin_Perfil_txtBox_Domicilio = new System.Windows.Forms.TextBox();
            this.txtBox_Localidad = new System.Windows.Forms.TextBox();
            this.Admin_Perfil_comboBox_Pais = new System.Windows.Forms.ComboBox();
            this.Admin_Perfil_Label_Sexo = new System.Windows.Forms.Label();
            this.Admin_Perfil_txtBox_Apellidos = new System.Windows.Forms.TextBox();
            this.Admin_Perfil_Label_EstCivil = new System.Windows.Forms.Label();
            this.Admin_Perfil_txtBox_NIF = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorProviderNif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPais = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLocalidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProvincia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDomicilo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSexo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTEL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMov = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFNAC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassInv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassDif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNick = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassAnt = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Buscar.SuspendLayout();
            this.groupBox_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultados_Busqueda)).BeginInit();
            this.Perfil.SuspendLayout();
            this.groupBox_UsPs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Perfil_Foto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.grupEstadoCivil.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDomicilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFNAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassDif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassAnt)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            resources.ApplyResources(this.Buscar, "Buscar");
            this.Buscar.Controls.Add(this.groupBox_Busqueda);
            this.Buscar.Controls.Add(this.Resultados_Busqueda);
            this.errorProviderLocalidad.SetError(this.Buscar, resources.GetString("Buscar.Error"));
            this.errorProviderCP.SetError(this.Buscar, resources.GetString("Buscar.Error1"));
            this.errorProviderNif.SetError(this.Buscar, resources.GetString("Buscar.Error2"));
            this.errorProviderNombre.SetError(this.Buscar, resources.GetString("Buscar.Error3"));
            this.errorProviderPais.SetError(this.Buscar, resources.GetString("Buscar.Error4"));
            this.errorProviderApellidos.SetError(this.Buscar, resources.GetString("Buscar.Error5"));
            this.errorProviderEC.SetError(this.Buscar, resources.GetString("Buscar.Error6"));
            this.errorProviderSexo.SetError(this.Buscar, resources.GetString("Buscar.Error7"));
            this.errorProviderFNAC.SetError(this.Buscar, resources.GetString("Buscar.Error8"));
            this.errorProviderMail.SetError(this.Buscar, resources.GetString("Buscar.Error9"));
            this.errorProviderMov.SetError(this.Buscar, resources.GetString("Buscar.Error10"));
            this.errorProviderTEL.SetError(this.Buscar, resources.GetString("Buscar.Error11"));
            this.errorProviderPassDif.SetError(this.Buscar, resources.GetString("Buscar.Error12"));
            this.errorProviderProvincia.SetError(this.Buscar, resources.GetString("Buscar.Error13"));
            this.errorProviderPassInv.SetError(this.Buscar, resources.GetString("Buscar.Error14"));
            this.errorProviderPassAnt.SetError(this.Buscar, resources.GetString("Buscar.Error15"));
            this.errorProviderDomicilo.SetError(this.Buscar, resources.GetString("Buscar.Error16"));
            this.errorProviderNick.SetError(this.Buscar, resources.GetString("Buscar.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment1"))));
            this.errorProviderPais.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment2"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment3"))));
            this.errorProviderApellidos.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment5"))));
            this.errorProviderNick.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment6"))));
            this.errorProviderEC.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment7"))));
            this.errorProviderPassInv.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment8"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment9"))));
            this.errorProviderPassDif.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment10"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment11"))));
            this.errorProviderProvincia.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment12"))));
            this.errorProviderNif.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment13"))));
            this.errorProviderNombre.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment14"))));
            this.errorProviderFNAC.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment15"))));
            this.errorProviderMail.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment16"))));
            this.errorProviderCP.SetIconAlignment(this.Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Buscar.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding1"))));
            this.errorProviderLocalidad.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding2"))));
            this.errorProviderProvincia.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding4"))));
            this.errorProviderApellidos.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding5"))));
            this.errorProviderNif.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding6"))));
            this.errorProviderNick.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding7"))));
            this.errorProviderMail.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding8"))));
            this.errorProviderFNAC.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding9"))));
            this.errorProviderPassAnt.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding10"))));
            this.errorProviderPassInv.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding11"))));
            this.errorProviderPassDif.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding12"))));
            this.errorProviderTEL.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding13"))));
            this.errorProviderEC.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding16"))));
            this.errorProviderSexo.SetIconPadding(this.Buscar, ((int)(resources.GetObject("Buscar.IconPadding17"))));
            this.Buscar.Name = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // groupBox_Busqueda
            // 
            resources.ApplyResources(this.groupBox_Busqueda, "groupBox_Busqueda");
            this.groupBox_Busqueda.Controls.Add(this.textBox_filtro_busqueda);
            this.groupBox_Busqueda.Controls.Add(this.comboBox_filtro_busqueda);
            this.groupBox_Busqueda.Controls.Add(this.label_filtro);
            this.groupBox_Busqueda.Controls.Add(this.comboBox_filtro);
            this.groupBox_Busqueda.Controls.Add(this.boton_limpia_busqueda);
            this.groupBox_Busqueda.Controls.Add(this.buttom_Buscar);
            this.errorProviderNif.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error"));
            this.errorProviderPais.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error1"));
            this.errorProviderPassDif.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error2"));
            this.errorProviderApellidos.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error3"));
            this.errorProviderPassInv.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error4"));
            this.errorProviderCP.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error5"));
            this.errorProviderNombre.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error6"));
            this.errorProviderMov.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error7"));
            this.errorProviderEC.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error8"));
            this.errorProviderMail.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error9"));
            this.errorProviderFNAC.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error10"));
            this.errorProviderSexo.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error11"));
            this.errorProviderLocalidad.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error12"));
            this.errorProviderDomicilo.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error13"));
            this.errorProviderProvincia.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error14"));
            this.errorProviderPassAnt.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error15"));
            this.errorProviderTEL.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error16"));
            this.errorProviderNick.SetError(this.groupBox_Busqueda, resources.GetString("groupBox_Busqueda.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment"))));
            this.errorProviderDomicilo.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment1"))));
            this.errorProviderLocalidad.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment2"))));
            this.errorProviderCP.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment3"))));
            this.errorProviderProvincia.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment4"))));
            this.errorProviderApellidos.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment6"))));
            this.errorProviderNombre.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment7"))));
            this.errorProviderEC.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment8"))));
            this.errorProviderPassInv.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment9"))));
            this.errorProviderNick.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment11"))));
            this.errorProviderMail.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment13"))));
            this.errorProviderMov.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment14"))));
            this.errorProviderPassDif.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment16"))));
            this.errorProviderNif.SetIconAlignment(this.groupBox_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_Busqueda.IconAlignment17"))));
            this.errorProviderLocalidad.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding1"))));
            this.errorProviderPassAnt.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding3"))));
            this.errorProviderProvincia.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding4"))));
            this.errorProviderEC.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding5"))));
            this.errorProviderNick.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding6"))));
            this.errorProviderSexo.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding7"))));
            this.errorProviderMov.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding9"))));
            this.errorProviderNif.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding10"))));
            this.errorProviderFNAC.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding12"))));
            this.errorProviderApellidos.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding13"))));
            this.errorProviderPassInv.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding15"))));
            this.errorProviderPassDif.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding16"))));
            this.errorProviderPais.SetIconPadding(this.groupBox_Busqueda, ((int)(resources.GetObject("groupBox_Busqueda.IconPadding17"))));
            this.groupBox_Busqueda.Name = "groupBox_Busqueda";
            this.groupBox_Busqueda.TabStop = false;
            this.groupBox_Busqueda.Enter += new System.EventHandler(this.groupBox_Busqueda_Enter);
            // 
            // textBox_filtro_busqueda
            // 
            resources.ApplyResources(this.textBox_filtro_busqueda, "textBox_filtro_busqueda");
            this.errorProviderPassDif.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error"));
            this.errorProviderMail.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error1"));
            this.errorProviderPassInv.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error2"));
            this.errorProviderNick.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error3"));
            this.errorProviderPassAnt.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error4"));
            this.errorProviderApellidos.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error5"));
            this.errorProviderCP.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error6"));
            this.errorProviderLocalidad.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error7"));
            this.errorProviderNombre.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error8"));
            this.errorProviderNif.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error9"));
            this.errorProviderPais.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error10"));
            this.errorProviderDomicilo.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error11"));
            this.errorProviderMov.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error12"));
            this.errorProviderTEL.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error13"));
            this.errorProviderFNAC.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error14"));
            this.errorProviderProvincia.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error15"));
            this.errorProviderEC.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error16"));
            this.errorProviderSexo.SetError(this.textBox_filtro_busqueda, resources.GetString("textBox_filtro_busqueda.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.textBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_filtro_busqueda.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.textBox_filtro_busqueda, ((int)(resources.GetObject("textBox_filtro_busqueda.IconPadding17"))));
            this.textBox_filtro_busqueda.Name = "textBox_filtro_busqueda";
            // 
            // comboBox_filtro_busqueda
            // 
            resources.ApplyResources(this.comboBox_filtro_busqueda, "comboBox_filtro_busqueda");
            this.errorProviderFNAC.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error"));
            this.errorProviderPassDif.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error1"));
            this.errorProviderMail.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error2"));
            this.errorProviderNick.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error3"));
            this.errorProviderPassAnt.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error4"));
            this.errorProviderPassInv.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error5"));
            this.errorProviderTEL.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error6"));
            this.errorProviderApellidos.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error7"));
            this.errorProviderCP.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error8"));
            this.errorProviderPais.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error9"));
            this.errorProviderNombre.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error10"));
            this.errorProviderNif.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error11"));
            this.errorProviderLocalidad.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error12"));
            this.errorProviderSexo.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error13"));
            this.errorProviderMov.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error14"));
            this.errorProviderEC.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error15"));
            this.errorProviderDomicilo.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error16"));
            this.errorProviderProvincia.SetError(this.comboBox_filtro_busqueda, resources.GetString("comboBox_filtro_busqueda.Error17"));
            this.comboBox_filtro_busqueda.FormattingEnabled = true;
            this.errorProviderSexo.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment1"))));
            this.errorProviderCP.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment2"))));
            this.errorProviderTEL.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment3"))));
            this.errorProviderMail.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment4"))));
            this.errorProviderEC.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment7"))));
            this.errorProviderLocalidad.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment8"))));
            this.errorProviderDomicilo.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment9"))));
            this.errorProviderNombre.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment10"))));
            this.errorProviderNif.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment11"))));
            this.errorProviderProvincia.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment12"))));
            this.errorProviderPassDif.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment14"))));
            this.errorProviderPassInv.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment15"))));
            this.errorProviderFNAC.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment16"))));
            this.errorProviderPassAnt.SetIconAlignment(this.comboBox_filtro_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro_busqueda.IconAlignment17"))));
            this.errorProviderNombre.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding"))));
            this.errorProviderPais.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding1"))));
            this.errorProviderLocalidad.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding2"))));
            this.errorProviderEC.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding4"))));
            this.errorProviderDomicilo.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding6"))));
            this.errorProviderProvincia.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding7"))));
            this.errorProviderApellidos.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding10"))));
            this.errorProviderPassDif.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding11"))));
            this.errorProviderFNAC.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding13"))));
            this.errorProviderMov.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding14"))));
            this.errorProviderNick.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding15"))));
            this.errorProviderPassAnt.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding16"))));
            this.errorProviderTEL.SetIconPadding(this.comboBox_filtro_busqueda, ((int)(resources.GetObject("comboBox_filtro_busqueda.IconPadding17"))));
            this.comboBox_filtro_busqueda.Name = "comboBox_filtro_busqueda";
            // 
            // label_filtro
            // 
            resources.ApplyResources(this.label_filtro, "label_filtro");
            this.errorProviderNif.SetError(this.label_filtro, resources.GetString("label_filtro.Error"));
            this.errorProviderNombre.SetError(this.label_filtro, resources.GetString("label_filtro.Error1"));
            this.errorProviderNick.SetError(this.label_filtro, resources.GetString("label_filtro.Error2"));
            this.errorProviderDomicilo.SetError(this.label_filtro, resources.GetString("label_filtro.Error3"));
            this.errorProviderLocalidad.SetError(this.label_filtro, resources.GetString("label_filtro.Error4"));
            this.errorProviderCP.SetError(this.label_filtro, resources.GetString("label_filtro.Error5"));
            this.errorProviderProvincia.SetError(this.label_filtro, resources.GetString("label_filtro.Error6"));
            this.errorProviderMov.SetError(this.label_filtro, resources.GetString("label_filtro.Error7"));
            this.errorProviderSexo.SetError(this.label_filtro, resources.GetString("label_filtro.Error8"));
            this.errorProviderEC.SetError(this.label_filtro, resources.GetString("label_filtro.Error9"));
            this.errorProviderApellidos.SetError(this.label_filtro, resources.GetString("label_filtro.Error10"));
            this.errorProviderPassAnt.SetError(this.label_filtro, resources.GetString("label_filtro.Error11"));
            this.errorProviderPais.SetError(this.label_filtro, resources.GetString("label_filtro.Error12"));
            this.errorProviderTEL.SetError(this.label_filtro, resources.GetString("label_filtro.Error13"));
            this.errorProviderPassInv.SetError(this.label_filtro, resources.GetString("label_filtro.Error14"));
            this.errorProviderFNAC.SetError(this.label_filtro, resources.GetString("label_filtro.Error15"));
            this.errorProviderMail.SetError(this.label_filtro, resources.GetString("label_filtro.Error16"));
            this.errorProviderPassDif.SetError(this.label_filtro, resources.GetString("label_filtro.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.label_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_filtro.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.label_filtro, ((int)(resources.GetObject("label_filtro.IconPadding17"))));
            this.label_filtro.Name = "label_filtro";
            // 
            // comboBox_filtro
            // 
            resources.ApplyResources(this.comboBox_filtro, "comboBox_filtro");
            this.errorProviderFNAC.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error"));
            this.errorProviderPassDif.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error1"));
            this.errorProviderMail.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error2"));
            this.errorProviderNick.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error3"));
            this.errorProviderPassAnt.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error4"));
            this.errorProviderPassInv.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error5"));
            this.errorProviderTEL.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error6"));
            this.errorProviderApellidos.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error7"));
            this.errorProviderCP.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error8"));
            this.errorProviderPais.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error9"));
            this.errorProviderNombre.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error10"));
            this.errorProviderNif.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error11"));
            this.errorProviderLocalidad.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error12"));
            this.errorProviderSexo.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error13"));
            this.errorProviderMov.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error14"));
            this.errorProviderEC.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error15"));
            this.errorProviderDomicilo.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error16"));
            this.errorProviderProvincia.SetError(this.comboBox_filtro, resources.GetString("comboBox_filtro.Error17"));
            this.comboBox_filtro.FormattingEnabled = true;
            this.errorProviderSexo.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment1"))));
            this.errorProviderCP.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment2"))));
            this.errorProviderTEL.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment3"))));
            this.errorProviderMail.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment4"))));
            this.errorProviderEC.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment7"))));
            this.errorProviderLocalidad.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment8"))));
            this.errorProviderDomicilo.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment9"))));
            this.errorProviderNombre.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment10"))));
            this.errorProviderNif.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment11"))));
            this.errorProviderProvincia.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment12"))));
            this.errorProviderPassDif.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment14"))));
            this.errorProviderPassInv.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment15"))));
            this.errorProviderFNAC.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment16"))));
            this.errorProviderPassAnt.SetIconAlignment(this.comboBox_filtro, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_filtro.IconAlignment17"))));
            this.errorProviderNombre.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding"))));
            this.errorProviderPais.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding1"))));
            this.errorProviderLocalidad.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding2"))));
            this.errorProviderEC.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding4"))));
            this.errorProviderDomicilo.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding6"))));
            this.errorProviderProvincia.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding7"))));
            this.errorProviderApellidos.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding10"))));
            this.errorProviderPassDif.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding11"))));
            this.errorProviderFNAC.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding13"))));
            this.errorProviderMov.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding14"))));
            this.errorProviderNick.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding15"))));
            this.errorProviderPassAnt.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding16"))));
            this.errorProviderTEL.SetIconPadding(this.comboBox_filtro, ((int)(resources.GetObject("comboBox_filtro.IconPadding17"))));
            this.comboBox_filtro.Items.AddRange(new object[] {
            resources.GetString("comboBox_filtro.Items"),
            resources.GetString("comboBox_filtro.Items1"),
            resources.GetString("comboBox_filtro.Items2"),
            resources.GetString("comboBox_filtro.Items3"),
            resources.GetString("comboBox_filtro.Items4"),
            resources.GetString("comboBox_filtro.Items5"),
            resources.GetString("comboBox_filtro.Items6"),
            resources.GetString("comboBox_filtro.Items7"),
            resources.GetString("comboBox_filtro.Items8"),
            resources.GetString("comboBox_filtro.Items9"),
            resources.GetString("comboBox_filtro.Items10"),
            resources.GetString("comboBox_filtro.Items11"),
            resources.GetString("comboBox_filtro.Items12"),
            resources.GetString("comboBox_filtro.Items13"),
            resources.GetString("comboBox_filtro.Items14")});
            this.comboBox_filtro.Name = "comboBox_filtro";
            this.comboBox_filtro.SelectedIndexChanged += new System.EventHandler(this.comboBox_filtro_SelectedIndexChanged);
            // 
            // boton_limpia_busqueda
            // 
            resources.ApplyResources(this.boton_limpia_busqueda, "boton_limpia_busqueda");
            this.errorProviderNif.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error"));
            this.errorProviderNombre.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error1"));
            this.errorProviderNick.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error2"));
            this.errorProviderFNAC.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error3"));
            this.errorProviderTEL.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error4"));
            this.errorProviderMov.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error5"));
            this.errorProviderMail.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error6"));
            this.errorProviderPassAnt.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error7"));
            this.errorProviderPassInv.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error8"));
            this.errorProviderPassDif.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error9"));
            this.errorProviderSexo.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error10"));
            this.errorProviderCP.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error11"));
            this.errorProviderApellidos.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error12"));
            this.errorProviderPais.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error13"));
            this.errorProviderLocalidad.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error14"));
            this.errorProviderEC.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error15"));
            this.errorProviderProvincia.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error16"));
            this.errorProviderDomicilo.SetError(this.boton_limpia_busqueda, resources.GetString("boton_limpia_busqueda.Error17"));
            this.errorProviderCP.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment1"))));
            this.errorProviderMov.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment3"))));
            this.errorProviderNif.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment4"))));
            this.errorProviderNombre.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment5"))));
            this.errorProviderApellidos.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment6"))));
            this.errorProviderPais.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment7"))));
            this.errorProviderMail.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment8"))));
            this.errorProviderFNAC.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment9"))));
            this.errorProviderPassDif.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment12"))));
            this.errorProviderEC.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment13"))));
            this.errorProviderProvincia.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment14"))));
            this.errorProviderSexo.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment16"))));
            this.errorProviderNick.SetIconAlignment(this.boton_limpia_busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_limpia_busqueda.IconAlignment17"))));
            this.errorProviderCP.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding"))));
            this.errorProviderLocalidad.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding1"))));
            this.errorProviderApellidos.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding2"))));
            this.errorProviderFNAC.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding3"))));
            this.errorProviderPais.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding4"))));
            this.errorProviderTEL.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding7"))));
            this.errorProviderProvincia.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding8"))));
            this.errorProviderMov.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding9"))));
            this.errorProviderDomicilo.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding10"))));
            this.errorProviderMail.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding11"))));
            this.errorProviderPassInv.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding12"))));
            this.errorProviderPassDif.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding15"))));
            this.errorProviderNif.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding16"))));
            this.errorProviderPassAnt.SetIconPadding(this.boton_limpia_busqueda, ((int)(resources.GetObject("boton_limpia_busqueda.IconPadding17"))));
            this.boton_limpia_busqueda.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.boton_limpia_busqueda.Name = "boton_limpia_busqueda";
            this.boton_limpia_busqueda.UseVisualStyleBackColor = true;
            this.boton_limpia_busqueda.Click += new System.EventHandler(this.boton_limpia_busqueda_Click);
            // 
            // buttom_Buscar
            // 
            resources.ApplyResources(this.buttom_Buscar, "buttom_Buscar");
            this.errorProviderNif.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error"));
            this.errorProviderNombre.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error1"));
            this.errorProviderNick.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error2"));
            this.errorProviderFNAC.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error3"));
            this.errorProviderTEL.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error4"));
            this.errorProviderMov.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error5"));
            this.errorProviderMail.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error6"));
            this.errorProviderPassAnt.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error7"));
            this.errorProviderPassInv.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error8"));
            this.errorProviderPassDif.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error9"));
            this.errorProviderSexo.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error10"));
            this.errorProviderCP.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error11"));
            this.errorProviderApellidos.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error12"));
            this.errorProviderPais.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error13"));
            this.errorProviderLocalidad.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error14"));
            this.errorProviderEC.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error15"));
            this.errorProviderProvincia.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error16"));
            this.errorProviderDomicilo.SetError(this.buttom_Buscar, resources.GetString("buttom_Buscar.Error17"));
            this.errorProviderCP.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment1"))));
            this.errorProviderMov.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment3"))));
            this.errorProviderNif.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment4"))));
            this.errorProviderNombre.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment5"))));
            this.errorProviderApellidos.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment6"))));
            this.errorProviderPais.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment7"))));
            this.errorProviderMail.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment8"))));
            this.errorProviderFNAC.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment9"))));
            this.errorProviderPassDif.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment12"))));
            this.errorProviderEC.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment13"))));
            this.errorProviderProvincia.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment14"))));
            this.errorProviderSexo.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment16"))));
            this.errorProviderNick.SetIconAlignment(this.buttom_Buscar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttom_Buscar.IconAlignment17"))));
            this.errorProviderCP.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding"))));
            this.errorProviderLocalidad.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding1"))));
            this.errorProviderApellidos.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding2"))));
            this.errorProviderFNAC.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding3"))));
            this.errorProviderPais.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding4"))));
            this.errorProviderTEL.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding7"))));
            this.errorProviderProvincia.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding8"))));
            this.errorProviderMov.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding9"))));
            this.errorProviderDomicilo.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding10"))));
            this.errorProviderMail.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding11"))));
            this.errorProviderPassInv.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding12"))));
            this.errorProviderPassDif.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding15"))));
            this.errorProviderNif.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding16"))));
            this.errorProviderPassAnt.SetIconPadding(this.buttom_Buscar, ((int)(resources.GetObject("buttom_Buscar.IconPadding17"))));
            this.buttom_Buscar.Image = global::Events4ALL.Properties.Resources.search_icon;
            this.buttom_Buscar.Name = "buttom_Buscar";
            this.buttom_Buscar.UseVisualStyleBackColor = true;
            this.buttom_Buscar.Click += new System.EventHandler(this.buttom_Buscar_Click);
            // 
            // Resultados_Busqueda
            // 
            resources.ApplyResources(this.Resultados_Busqueda, "Resultados_Busqueda");
            this.Resultados_Busqueda.AllowUserToAddRows = false;
            this.Resultados_Busqueda.AllowUserToDeleteRows = false;
            this.Resultados_Busqueda.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Resultados_Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resultados_Busqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NIF,
            this.usuario,
            this.Nombre,
            this.Apellidos,
            this.Mail,
            this.editar,
            this.borrar});
            this.errorProviderDomicilo.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error"));
            this.errorProviderNick.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error1"));
            this.errorProviderProvincia.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error2"));
            this.errorProviderApellidos.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error3"));
            this.errorProviderCP.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error4"));
            this.errorProviderLocalidad.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error5"));
            this.errorProviderNombre.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error6"));
            this.errorProviderNif.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error7"));
            this.errorProviderPais.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error8"));
            this.errorProviderEC.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error9"));
            this.errorProviderMail.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error10"));
            this.errorProviderPassDif.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error11"));
            this.errorProviderSexo.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error12"));
            this.errorProviderFNAC.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error13"));
            this.errorProviderTEL.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error14"));
            this.errorProviderMov.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error15"));
            this.errorProviderPassInv.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error16"));
            this.errorProviderPassAnt.SetError(this.Resultados_Busqueda, resources.GetString("Resultados_Busqueda.Error17"));
            this.errorProviderPassDif.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment1"))));
            this.errorProviderApellidos.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment2"))));
            this.errorProviderCP.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment3"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment4"))));
            this.errorProviderPassInv.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment6"))));
            this.errorProviderNombre.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment7"))));
            this.errorProviderMov.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment8"))));
            this.errorProviderTEL.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment9"))));
            this.errorProviderProvincia.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment10"))));
            this.errorProviderEC.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment11"))));
            this.errorProviderSexo.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment13"))));
            this.errorProviderMail.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment14"))));
            this.errorProviderNif.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment15"))));
            this.errorProviderNick.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment16"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Resultados_Busqueda, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Resultados_Busqueda.IconAlignment17"))));
            this.errorProviderNombre.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding"))));
            this.errorProviderNif.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding1"))));
            this.errorProviderCP.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding2"))));
            this.errorProviderPais.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding3"))));
            this.errorProviderApellidos.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding4"))));
            this.errorProviderPassAnt.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding5"))));
            this.errorProviderNick.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding6"))));
            this.errorProviderTEL.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding7"))));
            this.errorProviderFNAC.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding9"))));
            this.errorProviderEC.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding10"))));
            this.errorProviderSexo.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding11"))));
            this.errorProviderMov.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding12"))));
            this.errorProviderPassDif.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding13"))));
            this.errorProviderLocalidad.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding14"))));
            this.errorProviderDomicilo.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding16"))));
            this.errorProviderProvincia.SetIconPadding(this.Resultados_Busqueda, ((int)(resources.GetObject("Resultados_Busqueda.IconPadding17"))));
            this.Resultados_Busqueda.Name = "Resultados_Busqueda";
            this.Resultados_Busqueda.ReadOnly = true;
            this.Resultados_Busqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Resultados_Busqueda_CellContentClick);
            this.Resultados_Busqueda.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Resultados_Busqueda_CellMouseClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.FillWeight = 99.61344F;
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // NIF
            // 
            this.NIF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NIF.FillWeight = 77.68187F;
            resources.ApplyResources(this.NIF, "NIF");
            this.NIF.Name = "NIF";
            this.NIF.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.usuario.FillWeight = 120F;
            resources.ApplyResources(this.usuario, "usuario");
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.FillWeight = 115F;
            resources.ApplyResources(this.Nombre, "Nombre");
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apellidos.FillWeight = 140F;
            resources.ApplyResources(this.Apellidos, "Apellidos");
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mail.FillWeight = 160F;
            resources.ApplyResources(this.Mail, "Mail");
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.editar, "editar");
            this.editar.Image = global::Events4ALL.Properties.Resources.edit;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            // 
            // borrar
            // 
            this.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.borrar, "borrar");
            this.borrar.Image = global::Events4ALL.Properties.Resources.delete;
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            // 
            // Perfil
            // 
            resources.ApplyResources(this.Perfil, "Perfil");
            this.Perfil.Controls.Add(this.boton_eliminar);
            this.Perfil.Controls.Add(this.groupBox_UsPs);
            this.Perfil.Controls.Add(this.Admin_Perfil_boton_Foto);
            this.Perfil.Controls.Add(this.Admin_Perfil_boton_Guardar);
            this.Perfil.Controls.Add(this.Admin_Perfil_boton_Anadir);
            this.Perfil.Controls.Add(this.Admin_Perfil_Foto);
            this.Perfil.Controls.Add(this.groupBox1);
            this.errorProviderLocalidad.SetError(this.Perfil, resources.GetString("Perfil.Error"));
            this.errorProviderCP.SetError(this.Perfil, resources.GetString("Perfil.Error1"));
            this.errorProviderNif.SetError(this.Perfil, resources.GetString("Perfil.Error2"));
            this.errorProviderNombre.SetError(this.Perfil, resources.GetString("Perfil.Error3"));
            this.errorProviderPais.SetError(this.Perfil, resources.GetString("Perfil.Error4"));
            this.errorProviderApellidos.SetError(this.Perfil, resources.GetString("Perfil.Error5"));
            this.errorProviderEC.SetError(this.Perfil, resources.GetString("Perfil.Error6"));
            this.errorProviderSexo.SetError(this.Perfil, resources.GetString("Perfil.Error7"));
            this.errorProviderFNAC.SetError(this.Perfil, resources.GetString("Perfil.Error8"));
            this.errorProviderMail.SetError(this.Perfil, resources.GetString("Perfil.Error9"));
            this.errorProviderMov.SetError(this.Perfil, resources.GetString("Perfil.Error10"));
            this.errorProviderTEL.SetError(this.Perfil, resources.GetString("Perfil.Error11"));
            this.errorProviderPassDif.SetError(this.Perfil, resources.GetString("Perfil.Error12"));
            this.errorProviderProvincia.SetError(this.Perfil, resources.GetString("Perfil.Error13"));
            this.errorProviderPassInv.SetError(this.Perfil, resources.GetString("Perfil.Error14"));
            this.errorProviderPassAnt.SetError(this.Perfil, resources.GetString("Perfil.Error15"));
            this.errorProviderDomicilo.SetError(this.Perfil, resources.GetString("Perfil.Error16"));
            this.errorProviderNick.SetError(this.Perfil, resources.GetString("Perfil.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment1"))));
            this.errorProviderPais.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment2"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment3"))));
            this.errorProviderApellidos.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment5"))));
            this.errorProviderNick.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment6"))));
            this.errorProviderEC.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment7"))));
            this.errorProviderPassInv.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment8"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment9"))));
            this.errorProviderPassDif.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment10"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment11"))));
            this.errorProviderProvincia.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment12"))));
            this.errorProviderNif.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment13"))));
            this.errorProviderNombre.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment14"))));
            this.errorProviderFNAC.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment15"))));
            this.errorProviderMail.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment16"))));
            this.errorProviderCP.SetIconAlignment(this.Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Perfil.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding1"))));
            this.errorProviderLocalidad.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding2"))));
            this.errorProviderProvincia.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding4"))));
            this.errorProviderApellidos.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding5"))));
            this.errorProviderNif.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding6"))));
            this.errorProviderNick.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding7"))));
            this.errorProviderMail.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding8"))));
            this.errorProviderFNAC.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding9"))));
            this.errorProviderPassAnt.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding10"))));
            this.errorProviderPassInv.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding11"))));
            this.errorProviderPassDif.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding12"))));
            this.errorProviderTEL.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding13"))));
            this.errorProviderEC.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding16"))));
            this.errorProviderSexo.SetIconPadding(this.Perfil, ((int)(resources.GetObject("Perfil.IconPadding17"))));
            this.Perfil.Name = "Perfil";
            this.Perfil.UseVisualStyleBackColor = true;
            // 
            // boton_eliminar
            // 
            resources.ApplyResources(this.boton_eliminar, "boton_eliminar");
            this.errorProviderNif.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error"));
            this.errorProviderNombre.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error1"));
            this.errorProviderNick.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error2"));
            this.errorProviderFNAC.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error3"));
            this.errorProviderTEL.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error4"));
            this.errorProviderMov.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error5"));
            this.errorProviderMail.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error6"));
            this.errorProviderPassAnt.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error7"));
            this.errorProviderPassInv.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error8"));
            this.errorProviderPassDif.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error9"));
            this.errorProviderSexo.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error10"));
            this.errorProviderCP.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error11"));
            this.errorProviderApellidos.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error12"));
            this.errorProviderPais.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error13"));
            this.errorProviderLocalidad.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error14"));
            this.errorProviderEC.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error15"));
            this.errorProviderProvincia.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error16"));
            this.errorProviderDomicilo.SetError(this.boton_eliminar, resources.GetString("boton_eliminar.Error17"));
            this.errorProviderCP.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment1"))));
            this.errorProviderMov.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment3"))));
            this.errorProviderNif.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment4"))));
            this.errorProviderNombre.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment5"))));
            this.errorProviderApellidos.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment6"))));
            this.errorProviderPais.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment7"))));
            this.errorProviderMail.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment8"))));
            this.errorProviderFNAC.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment9"))));
            this.errorProviderPassDif.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment12"))));
            this.errorProviderEC.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment13"))));
            this.errorProviderProvincia.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment14"))));
            this.errorProviderSexo.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment16"))));
            this.errorProviderNick.SetIconAlignment(this.boton_eliminar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("boton_eliminar.IconAlignment17"))));
            this.errorProviderCP.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding"))));
            this.errorProviderLocalidad.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding1"))));
            this.errorProviderApellidos.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding2"))));
            this.errorProviderFNAC.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding3"))));
            this.errorProviderPais.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding4"))));
            this.errorProviderTEL.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding7"))));
            this.errorProviderProvincia.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding8"))));
            this.errorProviderMov.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding9"))));
            this.errorProviderDomicilo.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding10"))));
            this.errorProviderMail.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding11"))));
            this.errorProviderPassInv.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding12"))));
            this.errorProviderPassDif.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding15"))));
            this.errorProviderNif.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding16"))));
            this.errorProviderPassAnt.SetIconPadding(this.boton_eliminar, ((int)(resources.GetObject("boton_eliminar.IconPadding17"))));
            this.boton_eliminar.Image = global::Events4ALL.Properties.Resources.delete;
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // groupBox_UsPs
            // 
            resources.ApplyResources(this.groupBox_UsPs, "groupBox_UsPs");
            this.groupBox_UsPs.Controls.Add(this.textBox_anterior_pass);
            this.groupBox_UsPs.Controls.Add(this.label_anterior_pass);
            this.groupBox_UsPs.Controls.Add(this.label_ID);
            this.groupBox_UsPs.Controls.Add(this.textBox_pass2);
            this.groupBox_UsPs.Controls.Add(this.textBox_pass1);
            this.groupBox_UsPs.Controls.Add(this.label_pass2);
            this.groupBox_UsPs.Controls.Add(this.label_pass1);
            this.groupBox_UsPs.Controls.Add(this.textBox_NombreUsuario);
            this.groupBox_UsPs.Controls.Add(this.label_NombreUsuario);
            this.errorProviderNif.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error"));
            this.errorProviderPais.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error1"));
            this.errorProviderPassDif.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error2"));
            this.errorProviderApellidos.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error3"));
            this.errorProviderPassInv.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error4"));
            this.errorProviderCP.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error5"));
            this.errorProviderNombre.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error6"));
            this.errorProviderMov.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error7"));
            this.errorProviderEC.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error8"));
            this.errorProviderMail.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error9"));
            this.errorProviderFNAC.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error10"));
            this.errorProviderSexo.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error11"));
            this.errorProviderLocalidad.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error12"));
            this.errorProviderDomicilo.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error13"));
            this.errorProviderProvincia.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error14"));
            this.errorProviderPassAnt.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error15"));
            this.errorProviderTEL.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error16"));
            this.errorProviderNick.SetError(this.groupBox_UsPs, resources.GetString("groupBox_UsPs.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment"))));
            this.errorProviderDomicilo.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment1"))));
            this.errorProviderLocalidad.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment2"))));
            this.errorProviderCP.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment3"))));
            this.errorProviderProvincia.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment4"))));
            this.errorProviderApellidos.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment6"))));
            this.errorProviderNombre.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment7"))));
            this.errorProviderEC.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment8"))));
            this.errorProviderPassInv.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment9"))));
            this.errorProviderNick.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment11"))));
            this.errorProviderMail.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment13"))));
            this.errorProviderMov.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment14"))));
            this.errorProviderPassDif.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment16"))));
            this.errorProviderNif.SetIconAlignment(this.groupBox_UsPs, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox_UsPs.IconAlignment17"))));
            this.errorProviderLocalidad.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding1"))));
            this.errorProviderPassAnt.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding3"))));
            this.errorProviderProvincia.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding4"))));
            this.errorProviderEC.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding5"))));
            this.errorProviderNick.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding6"))));
            this.errorProviderSexo.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding7"))));
            this.errorProviderMov.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding9"))));
            this.errorProviderNif.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding10"))));
            this.errorProviderFNAC.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding12"))));
            this.errorProviderApellidos.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding13"))));
            this.errorProviderPassInv.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding15"))));
            this.errorProviderPassDif.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding16"))));
            this.errorProviderPais.SetIconPadding(this.groupBox_UsPs, ((int)(resources.GetObject("groupBox_UsPs.IconPadding17"))));
            this.groupBox_UsPs.Name = "groupBox_UsPs";
            this.groupBox_UsPs.TabStop = false;
            // 
            // textBox_anterior_pass
            // 
            resources.ApplyResources(this.textBox_anterior_pass, "textBox_anterior_pass");
            this.errorProviderPassDif.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error"));
            this.errorProviderMail.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error1"));
            this.errorProviderPassInv.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error2"));
            this.errorProviderNick.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error3"));
            this.errorProviderPassAnt.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error4"));
            this.errorProviderApellidos.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error5"));
            this.errorProviderCP.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error6"));
            this.errorProviderLocalidad.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error7"));
            this.errorProviderNombre.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error8"));
            this.errorProviderNif.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error9"));
            this.errorProviderPais.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error10"));
            this.errorProviderDomicilo.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error11"));
            this.errorProviderMov.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error12"));
            this.errorProviderTEL.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error13"));
            this.errorProviderFNAC.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error14"));
            this.errorProviderProvincia.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error15"));
            this.errorProviderEC.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error16"));
            this.errorProviderSexo.SetError(this.textBox_anterior_pass, resources.GetString("textBox_anterior_pass.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.textBox_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_anterior_pass.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.textBox_anterior_pass, ((int)(resources.GetObject("textBox_anterior_pass.IconPadding17"))));
            this.textBox_anterior_pass.Name = "textBox_anterior_pass";
            // 
            // label_anterior_pass
            // 
            resources.ApplyResources(this.label_anterior_pass, "label_anterior_pass");
            this.errorProviderNif.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error"));
            this.errorProviderNombre.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error1"));
            this.errorProviderNick.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error2"));
            this.errorProviderDomicilo.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error3"));
            this.errorProviderLocalidad.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error4"));
            this.errorProviderCP.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error5"));
            this.errorProviderProvincia.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error6"));
            this.errorProviderMov.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error7"));
            this.errorProviderSexo.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error8"));
            this.errorProviderEC.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error9"));
            this.errorProviderApellidos.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error10"));
            this.errorProviderPassAnt.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error11"));
            this.errorProviderPais.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error12"));
            this.errorProviderTEL.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error13"));
            this.errorProviderPassInv.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error14"));
            this.errorProviderFNAC.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error15"));
            this.errorProviderMail.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error16"));
            this.errorProviderPassDif.SetError(this.label_anterior_pass, resources.GetString("label_anterior_pass.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.label_anterior_pass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_anterior_pass.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.label_anterior_pass, ((int)(resources.GetObject("label_anterior_pass.IconPadding17"))));
            this.label_anterior_pass.Name = "label_anterior_pass";
            // 
            // label_ID
            // 
            resources.ApplyResources(this.label_ID, "label_ID");
            this.errorProviderNif.SetError(this.label_ID, resources.GetString("label_ID.Error"));
            this.errorProviderNombre.SetError(this.label_ID, resources.GetString("label_ID.Error1"));
            this.errorProviderNick.SetError(this.label_ID, resources.GetString("label_ID.Error2"));
            this.errorProviderDomicilo.SetError(this.label_ID, resources.GetString("label_ID.Error3"));
            this.errorProviderLocalidad.SetError(this.label_ID, resources.GetString("label_ID.Error4"));
            this.errorProviderCP.SetError(this.label_ID, resources.GetString("label_ID.Error5"));
            this.errorProviderProvincia.SetError(this.label_ID, resources.GetString("label_ID.Error6"));
            this.errorProviderMov.SetError(this.label_ID, resources.GetString("label_ID.Error7"));
            this.errorProviderSexo.SetError(this.label_ID, resources.GetString("label_ID.Error8"));
            this.errorProviderEC.SetError(this.label_ID, resources.GetString("label_ID.Error9"));
            this.errorProviderApellidos.SetError(this.label_ID, resources.GetString("label_ID.Error10"));
            this.errorProviderPassAnt.SetError(this.label_ID, resources.GetString("label_ID.Error11"));
            this.errorProviderPais.SetError(this.label_ID, resources.GetString("label_ID.Error12"));
            this.errorProviderTEL.SetError(this.label_ID, resources.GetString("label_ID.Error13"));
            this.errorProviderPassInv.SetError(this.label_ID, resources.GetString("label_ID.Error14"));
            this.errorProviderFNAC.SetError(this.label_ID, resources.GetString("label_ID.Error15"));
            this.errorProviderMail.SetError(this.label_ID, resources.GetString("label_ID.Error16"));
            this.errorProviderPassDif.SetError(this.label_ID, resources.GetString("label_ID.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.label_ID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_ID.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.label_ID, ((int)(resources.GetObject("label_ID.IconPadding17"))));
            this.label_ID.Name = "label_ID";
            // 
            // textBox_pass2
            // 
            resources.ApplyResources(this.textBox_pass2, "textBox_pass2");
            this.errorProviderPassDif.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error"));
            this.errorProviderMail.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error1"));
            this.errorProviderPassInv.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error2"));
            this.errorProviderNick.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error3"));
            this.errorProviderPassAnt.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error4"));
            this.errorProviderApellidos.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error5"));
            this.errorProviderCP.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error6"));
            this.errorProviderLocalidad.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error7"));
            this.errorProviderNombre.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error8"));
            this.errorProviderNif.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error9"));
            this.errorProviderPais.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error10"));
            this.errorProviderDomicilo.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error11"));
            this.errorProviderMov.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error12"));
            this.errorProviderTEL.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error13"));
            this.errorProviderFNAC.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error14"));
            this.errorProviderProvincia.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error15"));
            this.errorProviderEC.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error16"));
            this.errorProviderSexo.SetError(this.textBox_pass2, resources.GetString("textBox_pass2.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.textBox_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass2.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.textBox_pass2, ((int)(resources.GetObject("textBox_pass2.IconPadding17"))));
            this.textBox_pass2.Name = "textBox_pass2";
            // 
            // textBox_pass1
            // 
            resources.ApplyResources(this.textBox_pass1, "textBox_pass1");
            this.errorProviderPassDif.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error"));
            this.errorProviderMail.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error1"));
            this.errorProviderPassInv.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error2"));
            this.errorProviderNick.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error3"));
            this.errorProviderPassAnt.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error4"));
            this.errorProviderApellidos.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error5"));
            this.errorProviderCP.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error6"));
            this.errorProviderLocalidad.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error7"));
            this.errorProviderNombre.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error8"));
            this.errorProviderNif.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error9"));
            this.errorProviderPais.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error10"));
            this.errorProviderDomicilo.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error11"));
            this.errorProviderMov.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error12"));
            this.errorProviderTEL.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error13"));
            this.errorProviderFNAC.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error14"));
            this.errorProviderProvincia.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error15"));
            this.errorProviderEC.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error16"));
            this.errorProviderSexo.SetError(this.textBox_pass1, resources.GetString("textBox_pass1.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.textBox_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_pass1.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.textBox_pass1, ((int)(resources.GetObject("textBox_pass1.IconPadding17"))));
            this.textBox_pass1.Name = "textBox_pass1";
            // 
            // label_pass2
            // 
            resources.ApplyResources(this.label_pass2, "label_pass2");
            this.errorProviderNif.SetError(this.label_pass2, resources.GetString("label_pass2.Error"));
            this.errorProviderNombre.SetError(this.label_pass2, resources.GetString("label_pass2.Error1"));
            this.errorProviderNick.SetError(this.label_pass2, resources.GetString("label_pass2.Error2"));
            this.errorProviderDomicilo.SetError(this.label_pass2, resources.GetString("label_pass2.Error3"));
            this.errorProviderLocalidad.SetError(this.label_pass2, resources.GetString("label_pass2.Error4"));
            this.errorProviderCP.SetError(this.label_pass2, resources.GetString("label_pass2.Error5"));
            this.errorProviderProvincia.SetError(this.label_pass2, resources.GetString("label_pass2.Error6"));
            this.errorProviderMov.SetError(this.label_pass2, resources.GetString("label_pass2.Error7"));
            this.errorProviderSexo.SetError(this.label_pass2, resources.GetString("label_pass2.Error8"));
            this.errorProviderEC.SetError(this.label_pass2, resources.GetString("label_pass2.Error9"));
            this.errorProviderApellidos.SetError(this.label_pass2, resources.GetString("label_pass2.Error10"));
            this.errorProviderPassAnt.SetError(this.label_pass2, resources.GetString("label_pass2.Error11"));
            this.errorProviderPais.SetError(this.label_pass2, resources.GetString("label_pass2.Error12"));
            this.errorProviderTEL.SetError(this.label_pass2, resources.GetString("label_pass2.Error13"));
            this.errorProviderPassInv.SetError(this.label_pass2, resources.GetString("label_pass2.Error14"));
            this.errorProviderFNAC.SetError(this.label_pass2, resources.GetString("label_pass2.Error15"));
            this.errorProviderMail.SetError(this.label_pass2, resources.GetString("label_pass2.Error16"));
            this.errorProviderPassDif.SetError(this.label_pass2, resources.GetString("label_pass2.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.label_pass2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass2.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.label_pass2, ((int)(resources.GetObject("label_pass2.IconPadding17"))));
            this.label_pass2.Name = "label_pass2";
            // 
            // label_pass1
            // 
            resources.ApplyResources(this.label_pass1, "label_pass1");
            this.errorProviderNif.SetError(this.label_pass1, resources.GetString("label_pass1.Error"));
            this.errorProviderNombre.SetError(this.label_pass1, resources.GetString("label_pass1.Error1"));
            this.errorProviderNick.SetError(this.label_pass1, resources.GetString("label_pass1.Error2"));
            this.errorProviderDomicilo.SetError(this.label_pass1, resources.GetString("label_pass1.Error3"));
            this.errorProviderLocalidad.SetError(this.label_pass1, resources.GetString("label_pass1.Error4"));
            this.errorProviderCP.SetError(this.label_pass1, resources.GetString("label_pass1.Error5"));
            this.errorProviderProvincia.SetError(this.label_pass1, resources.GetString("label_pass1.Error6"));
            this.errorProviderMov.SetError(this.label_pass1, resources.GetString("label_pass1.Error7"));
            this.errorProviderSexo.SetError(this.label_pass1, resources.GetString("label_pass1.Error8"));
            this.errorProviderEC.SetError(this.label_pass1, resources.GetString("label_pass1.Error9"));
            this.errorProviderApellidos.SetError(this.label_pass1, resources.GetString("label_pass1.Error10"));
            this.errorProviderPassAnt.SetError(this.label_pass1, resources.GetString("label_pass1.Error11"));
            this.errorProviderPais.SetError(this.label_pass1, resources.GetString("label_pass1.Error12"));
            this.errorProviderTEL.SetError(this.label_pass1, resources.GetString("label_pass1.Error13"));
            this.errorProviderPassInv.SetError(this.label_pass1, resources.GetString("label_pass1.Error14"));
            this.errorProviderFNAC.SetError(this.label_pass1, resources.GetString("label_pass1.Error15"));
            this.errorProviderMail.SetError(this.label_pass1, resources.GetString("label_pass1.Error16"));
            this.errorProviderPassDif.SetError(this.label_pass1, resources.GetString("label_pass1.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.label_pass1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_pass1.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.label_pass1, ((int)(resources.GetObject("label_pass1.IconPadding17"))));
            this.label_pass1.Name = "label_pass1";
            // 
            // textBox_NombreUsuario
            // 
            resources.ApplyResources(this.textBox_NombreUsuario, "textBox_NombreUsuario");
            this.errorProviderPassDif.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error"));
            this.errorProviderMail.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error1"));
            this.errorProviderPassInv.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error2"));
            this.errorProviderNick.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error3"));
            this.errorProviderPassAnt.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error4"));
            this.errorProviderApellidos.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error5"));
            this.errorProviderCP.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error6"));
            this.errorProviderLocalidad.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error7"));
            this.errorProviderNombre.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error8"));
            this.errorProviderNif.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error9"));
            this.errorProviderPais.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error10"));
            this.errorProviderDomicilo.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error11"));
            this.errorProviderMov.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error12"));
            this.errorProviderTEL.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error13"));
            this.errorProviderFNAC.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error14"));
            this.errorProviderProvincia.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error15"));
            this.errorProviderEC.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error16"));
            this.errorProviderSexo.SetError(this.textBox_NombreUsuario, resources.GetString("textBox_NombreUsuario.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.textBox_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_NombreUsuario.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.textBox_NombreUsuario, ((int)(resources.GetObject("textBox_NombreUsuario.IconPadding17"))));
            this.textBox_NombreUsuario.Name = "textBox_NombreUsuario";
            // 
            // label_NombreUsuario
            // 
            resources.ApplyResources(this.label_NombreUsuario, "label_NombreUsuario");
            this.errorProviderNif.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error"));
            this.errorProviderNombre.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error1"));
            this.errorProviderNick.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error2"));
            this.errorProviderDomicilo.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error3"));
            this.errorProviderLocalidad.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error4"));
            this.errorProviderCP.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error5"));
            this.errorProviderProvincia.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error6"));
            this.errorProviderMov.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error7"));
            this.errorProviderSexo.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error8"));
            this.errorProviderEC.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error9"));
            this.errorProviderApellidos.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error10"));
            this.errorProviderPassAnt.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error11"));
            this.errorProviderPais.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error12"));
            this.errorProviderTEL.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error13"));
            this.errorProviderPassInv.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error14"));
            this.errorProviderFNAC.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error15"));
            this.errorProviderMail.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error16"));
            this.errorProviderPassDif.SetError(this.label_NombreUsuario, resources.GetString("label_NombreUsuario.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.label_NombreUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_NombreUsuario.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.label_NombreUsuario, ((int)(resources.GetObject("label_NombreUsuario.IconPadding17"))));
            this.label_NombreUsuario.Name = "label_NombreUsuario";
            // 
            // Admin_Perfil_boton_Foto
            // 
            resources.ApplyResources(this.Admin_Perfil_boton_Foto, "Admin_Perfil_boton_Foto");
            this.errorProviderNif.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error2"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error3"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error4"));
            this.errorProviderMov.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error5"));
            this.errorProviderMail.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error6"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error7"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error8"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error9"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error10"));
            this.errorProviderCP.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error11"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error12"));
            this.errorProviderPais.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error13"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error14"));
            this.errorProviderEC.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error15"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error16"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_boton_Foto, resources.GetString("Admin_Perfil_boton_Foto.Error17"));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment1"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment3"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment4"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment5"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment6"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment7"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment8"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment9"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment12"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment13"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment14"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment16"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_boton_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Foto.IconAlignment17"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding1"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding2"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding3"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding4"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding7"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding8"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding9"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding10"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding11"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding12"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding15"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding16"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_boton_Foto, ((int)(resources.GetObject("Admin_Perfil_boton_Foto.IconPadding17"))));
            this.Admin_Perfil_boton_Foto.Image = global::Events4ALL.Properties.Resources.photo;
            this.Admin_Perfil_boton_Foto.Name = "Admin_Perfil_boton_Foto";
            this.Admin_Perfil_boton_Foto.UseVisualStyleBackColor = true;
            this.Admin_Perfil_boton_Foto.Click += new System.EventHandler(this.Admin_Perfil_boton_Foto_Click);
            // 
            // Admin_Perfil_boton_Guardar
            // 
            resources.ApplyResources(this.Admin_Perfil_boton_Guardar, "Admin_Perfil_boton_Guardar");
            this.errorProviderNif.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error2"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error3"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error4"));
            this.errorProviderMov.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error5"));
            this.errorProviderMail.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error6"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error7"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error8"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error9"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error10"));
            this.errorProviderCP.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error11"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error12"));
            this.errorProviderPais.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error13"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error14"));
            this.errorProviderEC.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error15"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error16"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_boton_Guardar, resources.GetString("Admin_Perfil_boton_Guardar.Error17"));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment1"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment3"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment4"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment5"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment6"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment7"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment8"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment9"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment12"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment13"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment14"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment16"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_boton_Guardar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Guardar.IconAlignment17"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding1"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding2"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding3"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding4"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding7"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding8"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding9"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding10"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding11"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding12"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding15"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding16"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_boton_Guardar, ((int)(resources.GetObject("Admin_Perfil_boton_Guardar.IconPadding17"))));
            this.Admin_Perfil_boton_Guardar.Image = global::Events4ALL.Properties.Resources.add_save;
            this.Admin_Perfil_boton_Guardar.Name = "Admin_Perfil_boton_Guardar";
            this.Admin_Perfil_boton_Guardar.UseVisualStyleBackColor = true;
            this.Admin_Perfil_boton_Guardar.Click += new System.EventHandler(this.Admin_Perfil_boton_Guardar_Click);
            // 
            // Admin_Perfil_boton_Anadir
            // 
            resources.ApplyResources(this.Admin_Perfil_boton_Anadir, "Admin_Perfil_boton_Anadir");
            this.errorProviderNif.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error2"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error3"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error4"));
            this.errorProviderMov.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error5"));
            this.errorProviderMail.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error6"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error7"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error8"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error9"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error10"));
            this.errorProviderCP.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error11"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error12"));
            this.errorProviderPais.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error13"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error14"));
            this.errorProviderEC.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error15"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error16"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_boton_Anadir, resources.GetString("Admin_Perfil_boton_Anadir.Error17"));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment1"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment3"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment4"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment5"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment6"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment7"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment8"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment9"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment12"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment13"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment14"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment16"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_boton_Anadir, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_boton_Anadir.IconAlignment17"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding1"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding2"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding3"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding4"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding7"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding8"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding9"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding10"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding11"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding12"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding15"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding16"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_boton_Anadir, ((int)(resources.GetObject("Admin_Perfil_boton_Anadir.IconPadding17"))));
            this.Admin_Perfil_boton_Anadir.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.Admin_Perfil_boton_Anadir.Name = "Admin_Perfil_boton_Anadir";
            this.Admin_Perfil_boton_Anadir.UseVisualStyleBackColor = true;
            this.Admin_Perfil_boton_Anadir.Click += new System.EventHandler(this.Admin_Perfil_boton_Anadir_Click);
            // 
            // Admin_Perfil_Foto
            // 
            resources.ApplyResources(this.Admin_Perfil_Foto, "Admin_Perfil_Foto");
            this.Admin_Perfil_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProviderNick.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error1"));
            this.errorProviderNif.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error2"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error3"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error4"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error5"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error6"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error7"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error8"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error9"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error11"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error12"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Foto, resources.GetString("Admin_Perfil_Foto.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment1"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment2"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment4"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment6"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment7"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment8"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment9"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment10"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment11"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment12"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment13"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment14"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment15"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Foto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Foto.IconAlignment17"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding1"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding2"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding3"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding4"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding5"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding6"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding7"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding8"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding9"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding10"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding11"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding12"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding13"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding14"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding16"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Foto, ((int)(resources.GetObject("Admin_Perfil_Foto.IconPadding17"))));
            this.Admin_Perfil_Foto.Image = global::Events4ALL.Properties.Resources.Events4All;
            this.Admin_Perfil_Foto.Name = "Admin_Perfil_Foto";
            this.Admin_Perfil_Foto.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.test3);
            this.groupBox1.Controls.Add(this.test2);
            this.groupBox1.Controls.Add(this.test1);
            this.groupBox1.Controls.Add(this.comboBox_Provincia);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Label_Provincia_Perfil);
            this.groupBox1.Controls.Add(this.textBox_CP_Perfil);
            this.groupBox1.Controls.Add(this.label_CP_Perfil);
            this.groupBox1.Controls.Add(this.comboBoxDirec);
            this.groupBox1.Controls.Add(this.groupBoxSexo);
            this.groupBox1.Controls.Add(this.Admin_Perfil_txtBox_Nombre);
            this.groupBox1.Controls.Add(this.grupEstadoCivil);
            this.groupBox1.Controls.Add(this.Admin_Perfil_Label_Nombre);
            this.groupBox1.Controls.Add(this.Admin_Perfil_Label_Apellidos);
            this.groupBox1.Controls.Add(this.Admin_Perfil_Label_Pais);
            this.groupBox1.Controls.Add(this.Label_Localidad);
            this.groupBox1.Controls.Add(this.Admin_Perfil_Label_FecNacimiento);
            this.groupBox1.Controls.Add(this.Admin_Perfil_Label_NIF);
            this.groupBox1.Controls.Add(this.Admin_Perfil_Label_Domicilio);
            this.groupBox1.Controls.Add(this.Admin_Perfil_txtBox_Domicilio);
            this.groupBox1.Controls.Add(this.txtBox_Localidad);
            this.groupBox1.Controls.Add(this.Admin_Perfil_comboBox_Pais);
            this.groupBox1.Controls.Add(this.Admin_Perfil_Label_Sexo);
            this.groupBox1.Controls.Add(this.Admin_Perfil_txtBox_Apellidos);
            this.groupBox1.Controls.Add(this.Admin_Perfil_Label_EstCivil);
            this.groupBox1.Controls.Add(this.Admin_Perfil_txtBox_NIF);
            this.errorProviderNif.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.errorProviderPais.SetError(this.groupBox1, resources.GetString("groupBox1.Error1"));
            this.errorProviderPassDif.SetError(this.groupBox1, resources.GetString("groupBox1.Error2"));
            this.errorProviderApellidos.SetError(this.groupBox1, resources.GetString("groupBox1.Error3"));
            this.errorProviderPassInv.SetError(this.groupBox1, resources.GetString("groupBox1.Error4"));
            this.errorProviderCP.SetError(this.groupBox1, resources.GetString("groupBox1.Error5"));
            this.errorProviderNombre.SetError(this.groupBox1, resources.GetString("groupBox1.Error6"));
            this.errorProviderMov.SetError(this.groupBox1, resources.GetString("groupBox1.Error7"));
            this.errorProviderEC.SetError(this.groupBox1, resources.GetString("groupBox1.Error8"));
            this.errorProviderMail.SetError(this.groupBox1, resources.GetString("groupBox1.Error9"));
            this.errorProviderFNAC.SetError(this.groupBox1, resources.GetString("groupBox1.Error10"));
            this.errorProviderSexo.SetError(this.groupBox1, resources.GetString("groupBox1.Error11"));
            this.errorProviderLocalidad.SetError(this.groupBox1, resources.GetString("groupBox1.Error12"));
            this.errorProviderDomicilo.SetError(this.groupBox1, resources.GetString("groupBox1.Error13"));
            this.errorProviderProvincia.SetError(this.groupBox1, resources.GetString("groupBox1.Error14"));
            this.errorProviderPassAnt.SetError(this.groupBox1, resources.GetString("groupBox1.Error15"));
            this.errorProviderTEL.SetError(this.groupBox1, resources.GetString("groupBox1.Error16"));
            this.errorProviderNick.SetError(this.groupBox1, resources.GetString("groupBox1.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.errorProviderDomicilo.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment1"))));
            this.errorProviderLocalidad.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment2"))));
            this.errorProviderCP.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment3"))));
            this.errorProviderProvincia.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment4"))));
            this.errorProviderApellidos.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment6"))));
            this.errorProviderNombre.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment7"))));
            this.errorProviderEC.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment8"))));
            this.errorProviderPassInv.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment9"))));
            this.errorProviderNick.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment11"))));
            this.errorProviderMail.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment13"))));
            this.errorProviderMov.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment14"))));
            this.errorProviderPassDif.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment16"))));
            this.errorProviderNif.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment17"))));
            this.errorProviderLocalidad.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding1"))));
            this.errorProviderPassAnt.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding3"))));
            this.errorProviderProvincia.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding4"))));
            this.errorProviderEC.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding5"))));
            this.errorProviderNick.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding6"))));
            this.errorProviderSexo.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding7"))));
            this.errorProviderMov.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding9"))));
            this.errorProviderNif.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding10"))));
            this.errorProviderFNAC.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding12"))));
            this.errorProviderApellidos.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding13"))));
            this.errorProviderPassInv.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding15"))));
            this.errorProviderPassDif.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding16"))));
            this.errorProviderPais.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding17"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // test3
            // 
            resources.ApplyResources(this.test3, "test3");
            this.errorProviderNif.SetError(this.test3, resources.GetString("test3.Error"));
            this.errorProviderNombre.SetError(this.test3, resources.GetString("test3.Error1"));
            this.errorProviderNick.SetError(this.test3, resources.GetString("test3.Error2"));
            this.errorProviderDomicilo.SetError(this.test3, resources.GetString("test3.Error3"));
            this.errorProviderLocalidad.SetError(this.test3, resources.GetString("test3.Error4"));
            this.errorProviderCP.SetError(this.test3, resources.GetString("test3.Error5"));
            this.errorProviderProvincia.SetError(this.test3, resources.GetString("test3.Error6"));
            this.errorProviderMov.SetError(this.test3, resources.GetString("test3.Error7"));
            this.errorProviderSexo.SetError(this.test3, resources.GetString("test3.Error8"));
            this.errorProviderEC.SetError(this.test3, resources.GetString("test3.Error9"));
            this.errorProviderApellidos.SetError(this.test3, resources.GetString("test3.Error10"));
            this.errorProviderPassAnt.SetError(this.test3, resources.GetString("test3.Error11"));
            this.errorProviderPais.SetError(this.test3, resources.GetString("test3.Error12"));
            this.errorProviderTEL.SetError(this.test3, resources.GetString("test3.Error13"));
            this.errorProviderPassInv.SetError(this.test3, resources.GetString("test3.Error14"));
            this.errorProviderFNAC.SetError(this.test3, resources.GetString("test3.Error15"));
            this.errorProviderMail.SetError(this.test3, resources.GetString("test3.Error16"));
            this.errorProviderPassDif.SetError(this.test3, resources.GetString("test3.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.test3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test3.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.test3, ((int)(resources.GetObject("test3.IconPadding17"))));
            this.test3.Name = "test3";
            // 
            // test2
            // 
            resources.ApplyResources(this.test2, "test2");
            this.errorProviderNif.SetError(this.test2, resources.GetString("test2.Error"));
            this.errorProviderNombre.SetError(this.test2, resources.GetString("test2.Error1"));
            this.errorProviderNick.SetError(this.test2, resources.GetString("test2.Error2"));
            this.errorProviderDomicilo.SetError(this.test2, resources.GetString("test2.Error3"));
            this.errorProviderLocalidad.SetError(this.test2, resources.GetString("test2.Error4"));
            this.errorProviderCP.SetError(this.test2, resources.GetString("test2.Error5"));
            this.errorProviderProvincia.SetError(this.test2, resources.GetString("test2.Error6"));
            this.errorProviderMov.SetError(this.test2, resources.GetString("test2.Error7"));
            this.errorProviderSexo.SetError(this.test2, resources.GetString("test2.Error8"));
            this.errorProviderEC.SetError(this.test2, resources.GetString("test2.Error9"));
            this.errorProviderApellidos.SetError(this.test2, resources.GetString("test2.Error10"));
            this.errorProviderPassAnt.SetError(this.test2, resources.GetString("test2.Error11"));
            this.errorProviderPais.SetError(this.test2, resources.GetString("test2.Error12"));
            this.errorProviderTEL.SetError(this.test2, resources.GetString("test2.Error13"));
            this.errorProviderPassInv.SetError(this.test2, resources.GetString("test2.Error14"));
            this.errorProviderFNAC.SetError(this.test2, resources.GetString("test2.Error15"));
            this.errorProviderMail.SetError(this.test2, resources.GetString("test2.Error16"));
            this.errorProviderPassDif.SetError(this.test2, resources.GetString("test2.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.test2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test2.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.test2, ((int)(resources.GetObject("test2.IconPadding17"))));
            this.test2.Name = "test2";
            // 
            // test1
            // 
            resources.ApplyResources(this.test1, "test1");
            this.errorProviderNif.SetError(this.test1, resources.GetString("test1.Error"));
            this.errorProviderNombre.SetError(this.test1, resources.GetString("test1.Error1"));
            this.errorProviderNick.SetError(this.test1, resources.GetString("test1.Error2"));
            this.errorProviderDomicilo.SetError(this.test1, resources.GetString("test1.Error3"));
            this.errorProviderLocalidad.SetError(this.test1, resources.GetString("test1.Error4"));
            this.errorProviderCP.SetError(this.test1, resources.GetString("test1.Error5"));
            this.errorProviderProvincia.SetError(this.test1, resources.GetString("test1.Error6"));
            this.errorProviderMov.SetError(this.test1, resources.GetString("test1.Error7"));
            this.errorProviderSexo.SetError(this.test1, resources.GetString("test1.Error8"));
            this.errorProviderEC.SetError(this.test1, resources.GetString("test1.Error9"));
            this.errorProviderApellidos.SetError(this.test1, resources.GetString("test1.Error10"));
            this.errorProviderPassAnt.SetError(this.test1, resources.GetString("test1.Error11"));
            this.errorProviderPais.SetError(this.test1, resources.GetString("test1.Error12"));
            this.errorProviderTEL.SetError(this.test1, resources.GetString("test1.Error13"));
            this.errorProviderPassInv.SetError(this.test1, resources.GetString("test1.Error14"));
            this.errorProviderFNAC.SetError(this.test1, resources.GetString("test1.Error15"));
            this.errorProviderMail.SetError(this.test1, resources.GetString("test1.Error16"));
            this.errorProviderPassDif.SetError(this.test1, resources.GetString("test1.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.test1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("test1.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.test1, ((int)(resources.GetObject("test1.IconPadding17"))));
            this.test1.Name = "test1";
            // 
            // comboBox_Provincia
            // 
            resources.ApplyResources(this.comboBox_Provincia, "comboBox_Provincia");
            this.errorProviderFNAC.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error"));
            this.errorProviderPassDif.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error1"));
            this.errorProviderMail.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error2"));
            this.errorProviderNick.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error3"));
            this.errorProviderPassAnt.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error4"));
            this.errorProviderPassInv.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error5"));
            this.errorProviderTEL.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error6"));
            this.errorProviderApellidos.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error7"));
            this.errorProviderCP.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error8"));
            this.errorProviderPais.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error9"));
            this.errorProviderNombre.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error10"));
            this.errorProviderNif.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error11"));
            this.errorProviderLocalidad.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error12"));
            this.errorProviderSexo.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error13"));
            this.errorProviderMov.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error14"));
            this.errorProviderEC.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error15"));
            this.errorProviderDomicilo.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error16"));
            this.errorProviderProvincia.SetError(this.comboBox_Provincia, resources.GetString("comboBox_Provincia.Error17"));
            this.comboBox_Provincia.FormattingEnabled = true;
            this.errorProviderSexo.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment1"))));
            this.errorProviderCP.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment2"))));
            this.errorProviderTEL.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment3"))));
            this.errorProviderMail.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment4"))));
            this.errorProviderEC.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment7"))));
            this.errorProviderLocalidad.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment8"))));
            this.errorProviderDomicilo.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment9"))));
            this.errorProviderNombre.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment10"))));
            this.errorProviderNif.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment11"))));
            this.errorProviderProvincia.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment12"))));
            this.errorProviderPassDif.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment14"))));
            this.errorProviderPassInv.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment15"))));
            this.errorProviderFNAC.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment16"))));
            this.errorProviderPassAnt.SetIconAlignment(this.comboBox_Provincia, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox_Provincia.IconAlignment17"))));
            this.errorProviderNombre.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding"))));
            this.errorProviderPais.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding1"))));
            this.errorProviderLocalidad.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding2"))));
            this.errorProviderEC.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding4"))));
            this.errorProviderDomicilo.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding6"))));
            this.errorProviderProvincia.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding7"))));
            this.errorProviderApellidos.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding10"))));
            this.errorProviderPassDif.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding11"))));
            this.errorProviderFNAC.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding13"))));
            this.errorProviderMov.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding14"))));
            this.errorProviderNick.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding15"))));
            this.errorProviderPassAnt.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding16"))));
            this.errorProviderTEL.SetIconPadding(this.comboBox_Provincia, ((int)(resources.GetObject("comboBox_Provincia.IconPadding17"))));
            this.comboBox_Provincia.Items.AddRange(new object[] {
            resources.GetString("comboBox_Provincia.Items"),
            resources.GetString("comboBox_Provincia.Items1"),
            resources.GetString("comboBox_Provincia.Items2"),
            resources.GetString("comboBox_Provincia.Items3"),
            resources.GetString("comboBox_Provincia.Items4"),
            resources.GetString("comboBox_Provincia.Items5"),
            resources.GetString("comboBox_Provincia.Items6"),
            resources.GetString("comboBox_Provincia.Items7"),
            resources.GetString("comboBox_Provincia.Items8"),
            resources.GetString("comboBox_Provincia.Items9"),
            resources.GetString("comboBox_Provincia.Items10"),
            resources.GetString("comboBox_Provincia.Items11"),
            resources.GetString("comboBox_Provincia.Items12"),
            resources.GetString("comboBox_Provincia.Items13"),
            resources.GetString("comboBox_Provincia.Items14"),
            resources.GetString("comboBox_Provincia.Items15"),
            resources.GetString("comboBox_Provincia.Items16"),
            resources.GetString("comboBox_Provincia.Items17"),
            resources.GetString("comboBox_Provincia.Items18"),
            resources.GetString("comboBox_Provincia.Items19"),
            resources.GetString("comboBox_Provincia.Items20"),
            resources.GetString("comboBox_Provincia.Items21"),
            resources.GetString("comboBox_Provincia.Items22"),
            resources.GetString("comboBox_Provincia.Items23"),
            resources.GetString("comboBox_Provincia.Items24"),
            resources.GetString("comboBox_Provincia.Items25"),
            resources.GetString("comboBox_Provincia.Items26"),
            resources.GetString("comboBox_Provincia.Items27"),
            resources.GetString("comboBox_Provincia.Items28"),
            resources.GetString("comboBox_Provincia.Items29"),
            resources.GetString("comboBox_Provincia.Items30"),
            resources.GetString("comboBox_Provincia.Items31"),
            resources.GetString("comboBox_Provincia.Items32"),
            resources.GetString("comboBox_Provincia.Items33"),
            resources.GetString("comboBox_Provincia.Items34"),
            resources.GetString("comboBox_Provincia.Items35"),
            resources.GetString("comboBox_Provincia.Items36"),
            resources.GetString("comboBox_Provincia.Items37"),
            resources.GetString("comboBox_Provincia.Items38"),
            resources.GetString("comboBox_Provincia.Items39"),
            resources.GetString("comboBox_Provincia.Items40"),
            resources.GetString("comboBox_Provincia.Items41"),
            resources.GetString("comboBox_Provincia.Items42"),
            resources.GetString("comboBox_Provincia.Items43"),
            resources.GetString("comboBox_Provincia.Items44"),
            resources.GetString("comboBox_Provincia.Items45"),
            resources.GetString("comboBox_Provincia.Items46"),
            resources.GetString("comboBox_Provincia.Items47"),
            resources.GetString("comboBox_Provincia.Items48"),
            resources.GetString("comboBox_Provincia.Items49"),
            resources.GetString("comboBox_Provincia.Items50"),
            resources.GetString("comboBox_Provincia.Items51")});
            this.comboBox_Provincia.Name = "comboBox_Provincia";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.errorProviderCP.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error"));
            this.errorProviderNombre.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error1"));
            this.errorProviderApellidos.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error2"));
            this.errorProviderNick.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error3"));
            this.errorProviderPais.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error4"));
            this.errorProviderNif.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error5"));
            this.errorProviderEC.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error6"));
            this.errorProviderSexo.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error7"));
            this.errorProviderMov.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error8"));
            this.errorProviderLocalidad.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error9"));
            this.errorProviderDomicilo.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error10"));
            this.errorProviderProvincia.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error11"));
            this.errorProviderPassDif.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error12"));
            this.errorProviderPassInv.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error13"));
            this.errorProviderPassAnt.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error14"));
            this.errorProviderTEL.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error15"));
            this.errorProviderFNAC.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error16"));
            this.errorProviderMail.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error17"));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.errorProviderPassAnt.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment"))));
            this.errorProviderNick.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment1"))));
            this.errorProviderEC.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment2"))));
            this.errorProviderPais.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment3"))));
            this.errorProviderSexo.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment4"))));
            this.errorProviderNombre.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment6"))));
            this.errorProviderNif.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment8"))));
            this.errorProviderDomicilo.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment9"))));
            this.errorProviderPassInv.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment10"))));
            this.errorProviderFNAC.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment11"))));
            this.errorProviderPassDif.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment12"))));
            this.errorProviderCP.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment13"))));
            this.errorProviderApellidos.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment14"))));
            this.errorProviderMail.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment15"))));
            this.errorProviderMov.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment16"))));
            this.errorProviderTEL.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding"))));
            this.errorProviderNif.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding1"))));
            this.errorProviderLocalidad.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding2"))));
            this.errorProviderApellidos.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding4"))));
            this.errorProviderNombre.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding5"))));
            this.errorProviderMail.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding6"))));
            this.errorProviderFNAC.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding7"))));
            this.errorProviderNick.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding8"))));
            this.errorProviderPassAnt.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding10"))));
            this.errorProviderPassDif.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding11"))));
            this.errorProviderProvincia.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding12"))));
            this.errorProviderDomicilo.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding14"))));
            this.errorProviderMov.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding15"))));
            this.errorProviderSexo.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding16"))));
            this.errorProviderEC.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding17"))));
            this.dateTimePicker1.MaxDate = new System.DateTime(2210, 12, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Value = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.Admin_Perfil_Label_Tel1);
            this.groupBox2.Controls.Add(this.Admin_Perfil_Label_Tel2);
            this.groupBox2.Controls.Add(this.Admin_Perfil_Label_Mail);
            this.groupBox2.Controls.Add(this.Admin_Perfil_txtBox_Tel1);
            this.groupBox2.Controls.Add(this.Admin_Perfil_txtBox_Tel2);
            this.groupBox2.Controls.Add(this.Admin_Perfil_txtBox_Mail);
            this.errorProviderNif.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.errorProviderPais.SetError(this.groupBox2, resources.GetString("groupBox2.Error1"));
            this.errorProviderPassDif.SetError(this.groupBox2, resources.GetString("groupBox2.Error2"));
            this.errorProviderApellidos.SetError(this.groupBox2, resources.GetString("groupBox2.Error3"));
            this.errorProviderPassInv.SetError(this.groupBox2, resources.GetString("groupBox2.Error4"));
            this.errorProviderCP.SetError(this.groupBox2, resources.GetString("groupBox2.Error5"));
            this.errorProviderNombre.SetError(this.groupBox2, resources.GetString("groupBox2.Error6"));
            this.errorProviderMov.SetError(this.groupBox2, resources.GetString("groupBox2.Error7"));
            this.errorProviderEC.SetError(this.groupBox2, resources.GetString("groupBox2.Error8"));
            this.errorProviderMail.SetError(this.groupBox2, resources.GetString("groupBox2.Error9"));
            this.errorProviderFNAC.SetError(this.groupBox2, resources.GetString("groupBox2.Error10"));
            this.errorProviderSexo.SetError(this.groupBox2, resources.GetString("groupBox2.Error11"));
            this.errorProviderLocalidad.SetError(this.groupBox2, resources.GetString("groupBox2.Error12"));
            this.errorProviderDomicilo.SetError(this.groupBox2, resources.GetString("groupBox2.Error13"));
            this.errorProviderProvincia.SetError(this.groupBox2, resources.GetString("groupBox2.Error14"));
            this.errorProviderPassAnt.SetError(this.groupBox2, resources.GetString("groupBox2.Error15"));
            this.errorProviderTEL.SetError(this.groupBox2, resources.GetString("groupBox2.Error16"));
            this.errorProviderNick.SetError(this.groupBox2, resources.GetString("groupBox2.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errorProviderDomicilo.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment1"))));
            this.errorProviderLocalidad.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment2"))));
            this.errorProviderCP.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment3"))));
            this.errorProviderProvincia.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment4"))));
            this.errorProviderApellidos.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment6"))));
            this.errorProviderNombre.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment7"))));
            this.errorProviderEC.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment8"))));
            this.errorProviderPassInv.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment9"))));
            this.errorProviderNick.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment11"))));
            this.errorProviderMail.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment13"))));
            this.errorProviderMov.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment14"))));
            this.errorProviderPassDif.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment16"))));
            this.errorProviderNif.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment17"))));
            this.errorProviderLocalidad.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding1"))));
            this.errorProviderPassAnt.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding3"))));
            this.errorProviderProvincia.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding4"))));
            this.errorProviderEC.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding5"))));
            this.errorProviderNick.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding6"))));
            this.errorProviderSexo.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding7"))));
            this.errorProviderMov.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding9"))));
            this.errorProviderNif.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding10"))));
            this.errorProviderFNAC.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding12"))));
            this.errorProviderApellidos.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding13"))));
            this.errorProviderPassInv.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding15"))));
            this.errorProviderPassDif.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding16"))));
            this.errorProviderPais.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding17"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Admin_Perfil_Label_Tel1
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_Tel1, "Admin_Perfil_Label_Tel1");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_Tel1, resources.GetString("Admin_Perfil_Label_Tel1.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel1.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_Tel1, ((int)(resources.GetObject("Admin_Perfil_Label_Tel1.IconPadding17"))));
            this.Admin_Perfil_Label_Tel1.Name = "Admin_Perfil_Label_Tel1";
            // 
            // Admin_Perfil_Label_Tel2
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_Tel2, "Admin_Perfil_Label_Tel2");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_Tel2, resources.GetString("Admin_Perfil_Label_Tel2.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Tel2.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_Tel2, ((int)(resources.GetObject("Admin_Perfil_Label_Tel2.IconPadding17"))));
            this.Admin_Perfil_Label_Tel2.Name = "Admin_Perfil_Label_Tel2";
            // 
            // Admin_Perfil_Label_Mail
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_Mail, "Admin_Perfil_Label_Mail");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_Mail, resources.GetString("Admin_Perfil_Label_Mail.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Mail.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_Mail, ((int)(resources.GetObject("Admin_Perfil_Label_Mail.IconPadding17"))));
            this.Admin_Perfil_Label_Mail.Name = "Admin_Perfil_Label_Mail";
            // 
            // Admin_Perfil_txtBox_Tel1
            // 
            resources.ApplyResources(this.Admin_Perfil_txtBox_Tel1, "Admin_Perfil_txtBox_Tel1");
            this.errorProviderPassDif.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error"));
            this.errorProviderMail.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error1"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error2"));
            this.errorProviderNick.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error3"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error4"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error5"));
            this.errorProviderCP.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error6"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error7"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error8"));
            this.errorProviderNif.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error9"));
            this.errorProviderPais.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error10"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error11"));
            this.errorProviderMov.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error13"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error14"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error15"));
            this.errorProviderEC.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error16"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_txtBox_Tel1, resources.GetString("Admin_Perfil_txtBox_Tel1.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_txtBox_Tel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_txtBox_Tel1, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel1.IconPadding17"))));
            this.Admin_Perfil_txtBox_Tel1.Name = "Admin_Perfil_txtBox_Tel1";
            this.Admin_Perfil_txtBox_Tel1.Enter += new System.EventHandler(this.LimpiaTelefono);
            // 
            // Admin_Perfil_txtBox_Tel2
            // 
            resources.ApplyResources(this.Admin_Perfil_txtBox_Tel2, "Admin_Perfil_txtBox_Tel2");
            this.errorProviderPassDif.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error"));
            this.errorProviderMail.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error1"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error2"));
            this.errorProviderNick.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error3"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error4"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error5"));
            this.errorProviderCP.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error6"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error7"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error8"));
            this.errorProviderNif.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error9"));
            this.errorProviderPais.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error10"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error11"));
            this.errorProviderMov.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error13"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error14"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error15"));
            this.errorProviderEC.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error16"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_txtBox_Tel2, resources.GetString("Admin_Perfil_txtBox_Tel2.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_txtBox_Tel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_txtBox_Tel2, ((int)(resources.GetObject("Admin_Perfil_txtBox_Tel2.IconPadding17"))));
            this.Admin_Perfil_txtBox_Tel2.Name = "Admin_Perfil_txtBox_Tel2";
            this.Admin_Perfil_txtBox_Tel2.Enter += new System.EventHandler(this.LimpiaMovil);
            // 
            // Admin_Perfil_txtBox_Mail
            // 
            resources.ApplyResources(this.Admin_Perfil_txtBox_Mail, "Admin_Perfil_txtBox_Mail");
            this.errorProviderPassDif.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error"));
            this.errorProviderMail.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error1"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error2"));
            this.errorProviderNick.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error3"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error4"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error5"));
            this.errorProviderCP.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error6"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error7"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error8"));
            this.errorProviderNif.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error9"));
            this.errorProviderPais.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error10"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error11"));
            this.errorProviderMov.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error13"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error14"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error15"));
            this.errorProviderEC.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error16"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_txtBox_Mail, resources.GetString("Admin_Perfil_txtBox_Mail.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_txtBox_Mail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_txtBox_Mail, ((int)(resources.GetObject("Admin_Perfil_txtBox_Mail.IconPadding17"))));
            this.Admin_Perfil_txtBox_Mail.Name = "Admin_Perfil_txtBox_Mail";
            this.Admin_Perfil_txtBox_Mail.Enter += new System.EventHandler(this.LimpiaMail);
            // 
            // Label_Provincia_Perfil
            // 
            resources.ApplyResources(this.Label_Provincia_Perfil, "Label_Provincia_Perfil");
            this.errorProviderNif.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error"));
            this.errorProviderNombre.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error1"));
            this.errorProviderNick.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error2"));
            this.errorProviderDomicilo.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error3"));
            this.errorProviderLocalidad.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error4"));
            this.errorProviderCP.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error5"));
            this.errorProviderProvincia.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error6"));
            this.errorProviderMov.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error7"));
            this.errorProviderSexo.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error8"));
            this.errorProviderEC.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error9"));
            this.errorProviderApellidos.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error10"));
            this.errorProviderPassAnt.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error11"));
            this.errorProviderPais.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error12"));
            this.errorProviderTEL.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error13"));
            this.errorProviderPassInv.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error14"));
            this.errorProviderFNAC.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error15"));
            this.errorProviderMail.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error16"));
            this.errorProviderPassDif.SetError(this.Label_Provincia_Perfil, resources.GetString("Label_Provincia_Perfil.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Label_Provincia_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Provincia_Perfil.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Label_Provincia_Perfil, ((int)(resources.GetObject("Label_Provincia_Perfil.IconPadding17"))));
            this.Label_Provincia_Perfil.Name = "Label_Provincia_Perfil";
            // 
            // textBox_CP_Perfil
            // 
            resources.ApplyResources(this.textBox_CP_Perfil, "textBox_CP_Perfil");
            this.errorProviderPassDif.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error"));
            this.errorProviderMail.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error1"));
            this.errorProviderPassInv.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error2"));
            this.errorProviderNick.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error3"));
            this.errorProviderPassAnt.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error4"));
            this.errorProviderApellidos.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error5"));
            this.errorProviderCP.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error6"));
            this.errorProviderLocalidad.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error7"));
            this.errorProviderNombre.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error8"));
            this.errorProviderNif.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error9"));
            this.errorProviderPais.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error10"));
            this.errorProviderDomicilo.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error11"));
            this.errorProviderMov.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error12"));
            this.errorProviderTEL.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error13"));
            this.errorProviderFNAC.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error14"));
            this.errorProviderProvincia.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error15"));
            this.errorProviderEC.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error16"));
            this.errorProviderSexo.SetError(this.textBox_CP_Perfil, resources.GetString("textBox_CP_Perfil.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.textBox_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_CP_Perfil.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.textBox_CP_Perfil, ((int)(resources.GetObject("textBox_CP_Perfil.IconPadding17"))));
            this.textBox_CP_Perfil.Name = "textBox_CP_Perfil";
            // 
            // label_CP_Perfil
            // 
            resources.ApplyResources(this.label_CP_Perfil, "label_CP_Perfil");
            this.errorProviderNif.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error"));
            this.errorProviderNombre.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error1"));
            this.errorProviderNick.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error2"));
            this.errorProviderDomicilo.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error3"));
            this.errorProviderLocalidad.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error4"));
            this.errorProviderCP.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error5"));
            this.errorProviderProvincia.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error6"));
            this.errorProviderMov.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error7"));
            this.errorProviderSexo.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error8"));
            this.errorProviderEC.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error9"));
            this.errorProviderApellidos.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error10"));
            this.errorProviderPassAnt.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error11"));
            this.errorProviderPais.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error12"));
            this.errorProviderTEL.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error13"));
            this.errorProviderPassInv.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error14"));
            this.errorProviderFNAC.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error15"));
            this.errorProviderMail.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error16"));
            this.errorProviderPassDif.SetError(this.label_CP_Perfil, resources.GetString("label_CP_Perfil.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.label_CP_Perfil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_CP_Perfil.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.label_CP_Perfil, ((int)(resources.GetObject("label_CP_Perfil.IconPadding17"))));
            this.label_CP_Perfil.Name = "label_CP_Perfil";
            // 
            // comboBoxDirec
            // 
            resources.ApplyResources(this.comboBoxDirec, "comboBoxDirec");
            this.errorProviderFNAC.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error"));
            this.errorProviderPassDif.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error1"));
            this.errorProviderMail.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error2"));
            this.errorProviderNick.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error3"));
            this.errorProviderPassAnt.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error4"));
            this.errorProviderPassInv.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error5"));
            this.errorProviderTEL.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error6"));
            this.errorProviderApellidos.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error7"));
            this.errorProviderCP.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error8"));
            this.errorProviderPais.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error9"));
            this.errorProviderNombre.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error10"));
            this.errorProviderNif.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error11"));
            this.errorProviderLocalidad.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error12"));
            this.errorProviderSexo.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error13"));
            this.errorProviderMov.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error14"));
            this.errorProviderEC.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error15"));
            this.errorProviderDomicilo.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error16"));
            this.errorProviderProvincia.SetError(this.comboBoxDirec, resources.GetString("comboBoxDirec.Error17"));
            this.comboBoxDirec.FormattingEnabled = true;
            this.errorProviderSexo.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment1"))));
            this.errorProviderCP.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment2"))));
            this.errorProviderTEL.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment3"))));
            this.errorProviderMail.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment4"))));
            this.errorProviderEC.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment7"))));
            this.errorProviderLocalidad.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment8"))));
            this.errorProviderDomicilo.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment9"))));
            this.errorProviderNombre.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment10"))));
            this.errorProviderNif.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment11"))));
            this.errorProviderProvincia.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment12"))));
            this.errorProviderPassDif.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment14"))));
            this.errorProviderPassInv.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment15"))));
            this.errorProviderFNAC.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment16"))));
            this.errorProviderPassAnt.SetIconAlignment(this.comboBoxDirec, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDirec.IconAlignment17"))));
            this.errorProviderNombre.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding"))));
            this.errorProviderPais.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding1"))));
            this.errorProviderLocalidad.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding2"))));
            this.errorProviderEC.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding4"))));
            this.errorProviderDomicilo.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding6"))));
            this.errorProviderProvincia.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding7"))));
            this.errorProviderApellidos.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding10"))));
            this.errorProviderPassDif.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding11"))));
            this.errorProviderFNAC.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding13"))));
            this.errorProviderMov.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding14"))));
            this.errorProviderNick.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding15"))));
            this.errorProviderPassAnt.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding16"))));
            this.errorProviderTEL.SetIconPadding(this.comboBoxDirec, ((int)(resources.GetObject("comboBoxDirec.IconPadding17"))));
            this.comboBoxDirec.Items.AddRange(new object[] {
            resources.GetString("comboBoxDirec.Items"),
            resources.GetString("comboBoxDirec.Items1"),
            resources.GetString("comboBoxDirec.Items2"),
            resources.GetString("comboBoxDirec.Items3")});
            this.comboBoxDirec.Name = "comboBoxDirec";
            // 
            // groupBoxSexo
            // 
            resources.ApplyResources(this.groupBoxSexo, "groupBoxSexo");
            this.groupBoxSexo.Controls.Add(this.Admin_Perfil_rButom_H);
            this.groupBoxSexo.Controls.Add(this.Admin_Perfil_rButom_M);
            this.errorProviderNif.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error"));
            this.errorProviderPais.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error1"));
            this.errorProviderPassDif.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error2"));
            this.errorProviderApellidos.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error3"));
            this.errorProviderPassInv.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error4"));
            this.errorProviderCP.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error5"));
            this.errorProviderNombre.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error6"));
            this.errorProviderMov.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error7"));
            this.errorProviderEC.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error8"));
            this.errorProviderMail.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error9"));
            this.errorProviderFNAC.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error10"));
            this.errorProviderSexo.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error11"));
            this.errorProviderLocalidad.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error12"));
            this.errorProviderDomicilo.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error13"));
            this.errorProviderProvincia.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error14"));
            this.errorProviderPassAnt.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error15"));
            this.errorProviderTEL.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error16"));
            this.errorProviderNick.SetError(this.groupBoxSexo, resources.GetString("groupBoxSexo.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment"))));
            this.errorProviderDomicilo.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment1"))));
            this.errorProviderLocalidad.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment2"))));
            this.errorProviderCP.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment3"))));
            this.errorProviderProvincia.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment4"))));
            this.errorProviderApellidos.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment6"))));
            this.errorProviderNombre.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment7"))));
            this.errorProviderEC.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment8"))));
            this.errorProviderPassInv.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment9"))));
            this.errorProviderNick.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment11"))));
            this.errorProviderMail.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment13"))));
            this.errorProviderMov.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment14"))));
            this.errorProviderPassDif.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment16"))));
            this.errorProviderNif.SetIconAlignment(this.groupBoxSexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBoxSexo.IconAlignment17"))));
            this.errorProviderLocalidad.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding1"))));
            this.errorProviderPassAnt.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding3"))));
            this.errorProviderProvincia.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding4"))));
            this.errorProviderEC.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding5"))));
            this.errorProviderNick.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding6"))));
            this.errorProviderSexo.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding7"))));
            this.errorProviderMov.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding9"))));
            this.errorProviderNif.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding10"))));
            this.errorProviderFNAC.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding12"))));
            this.errorProviderApellidos.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding13"))));
            this.errorProviderPassInv.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding15"))));
            this.errorProviderPassDif.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding16"))));
            this.errorProviderPais.SetIconPadding(this.groupBoxSexo, ((int)(resources.GetObject("groupBoxSexo.IconPadding17"))));
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.TabStop = false;
            // 
            // Admin_Perfil_rButom_H
            // 
            resources.ApplyResources(this.Admin_Perfil_rButom_H, "Admin_Perfil_rButom_H");
            this.errorProviderNombre.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error"));
            this.errorProviderNick.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error1"));
            this.errorProviderEC.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error2"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error3"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error4"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error5"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error6"));
            this.errorProviderMail.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error7"));
            this.errorProviderMov.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error8"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error9"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error10"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error11"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error12"));
            this.errorProviderNif.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error13"));
            this.errorProviderCP.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error14"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error15"));
            this.errorProviderPais.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error16"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_rButom_H, resources.GetString("Admin_Perfil_rButom_H.Error17"));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment1"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment3"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment5"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment7"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment8"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment9"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment10"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment13"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment14"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment15"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment16"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_rButom_H, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_H.IconAlignment17"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding1"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding2"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding3"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding5"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding7"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding10"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding14"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding15"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_rButom_H, ((int)(resources.GetObject("Admin_Perfil_rButom_H.IconPadding17"))));
            this.Admin_Perfil_rButom_H.Name = "Admin_Perfil_rButom_H";
            this.Admin_Perfil_rButom_H.TabStop = true;
            this.Admin_Perfil_rButom_H.UseVisualStyleBackColor = true;
            // 
            // Admin_Perfil_rButom_M
            // 
            resources.ApplyResources(this.Admin_Perfil_rButom_M, "Admin_Perfil_rButom_M");
            this.errorProviderNombre.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error"));
            this.errorProviderNick.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error1"));
            this.errorProviderEC.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error2"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error3"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error4"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error5"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error6"));
            this.errorProviderMail.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error7"));
            this.errorProviderMov.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error8"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error9"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error10"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error11"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error12"));
            this.errorProviderNif.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error13"));
            this.errorProviderCP.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error14"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error15"));
            this.errorProviderPais.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error16"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_rButom_M, resources.GetString("Admin_Perfil_rButom_M.Error17"));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment1"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment3"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment5"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment7"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment8"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment9"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment10"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment13"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment14"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment15"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment16"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_rButom_M, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_M.IconAlignment17"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding1"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding2"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding3"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding5"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding7"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding10"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding14"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding15"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_rButom_M, ((int)(resources.GetObject("Admin_Perfil_rButom_M.IconPadding17"))));
            this.Admin_Perfil_rButom_M.Name = "Admin_Perfil_rButom_M";
            this.Admin_Perfil_rButom_M.TabStop = true;
            this.Admin_Perfil_rButom_M.UseVisualStyleBackColor = true;
            // 
            // Admin_Perfil_txtBox_Nombre
            // 
            resources.ApplyResources(this.Admin_Perfil_txtBox_Nombre, "Admin_Perfil_txtBox_Nombre");
            this.errorProviderPassDif.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error"));
            this.errorProviderMail.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error1"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error2"));
            this.errorProviderNick.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error3"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error4"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error5"));
            this.errorProviderCP.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error6"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error7"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error8"));
            this.errorProviderNif.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error9"));
            this.errorProviderPais.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error10"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error11"));
            this.errorProviderMov.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error13"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error14"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error15"));
            this.errorProviderEC.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error16"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_txtBox_Nombre, resources.GetString("Admin_Perfil_txtBox_Nombre.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_txtBox_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_txtBox_Nombre, ((int)(resources.GetObject("Admin_Perfil_txtBox_Nombre.IconPadding17"))));
            this.Admin_Perfil_txtBox_Nombre.Name = "Admin_Perfil_txtBox_Nombre";
            // 
            // grupEstadoCivil
            // 
            resources.ApplyResources(this.grupEstadoCivil, "grupEstadoCivil");
            this.grupEstadoCivil.Controls.Add(this.Admin_Perfil_rButom_Divorciado);
            this.grupEstadoCivil.Controls.Add(this.Admin_Perfil_rButom_Soltero);
            this.grupEstadoCivil.Controls.Add(this.Admin_Perfil_rButom_Casado);
            this.grupEstadoCivil.Controls.Add(this.Admin_Perfil_rButom_Viudo);
            this.errorProviderNif.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error"));
            this.errorProviderPais.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error1"));
            this.errorProviderPassDif.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error2"));
            this.errorProviderApellidos.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error3"));
            this.errorProviderPassInv.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error4"));
            this.errorProviderCP.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error5"));
            this.errorProviderNombre.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error6"));
            this.errorProviderMov.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error7"));
            this.errorProviderEC.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error8"));
            this.errorProviderMail.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error9"));
            this.errorProviderFNAC.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error10"));
            this.errorProviderSexo.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error11"));
            this.errorProviderLocalidad.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error12"));
            this.errorProviderDomicilo.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error13"));
            this.errorProviderProvincia.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error14"));
            this.errorProviderPassAnt.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error15"));
            this.errorProviderTEL.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error16"));
            this.errorProviderNick.SetError(this.grupEstadoCivil, resources.GetString("grupEstadoCivil.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment"))));
            this.errorProviderDomicilo.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment1"))));
            this.errorProviderLocalidad.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment2"))));
            this.errorProviderCP.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment3"))));
            this.errorProviderProvincia.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment4"))));
            this.errorProviderApellidos.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment6"))));
            this.errorProviderNombre.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment7"))));
            this.errorProviderEC.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment8"))));
            this.errorProviderPassInv.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment9"))));
            this.errorProviderNick.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment11"))));
            this.errorProviderMail.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment13"))));
            this.errorProviderMov.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment14"))));
            this.errorProviderPassDif.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment15"))));
            this.errorProviderTEL.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment16"))));
            this.errorProviderNif.SetIconAlignment(this.grupEstadoCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grupEstadoCivil.IconAlignment17"))));
            this.errorProviderLocalidad.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding1"))));
            this.errorProviderPassAnt.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding3"))));
            this.errorProviderProvincia.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding4"))));
            this.errorProviderEC.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding5"))));
            this.errorProviderNick.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding6"))));
            this.errorProviderSexo.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding7"))));
            this.errorProviderMov.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding9"))));
            this.errorProviderNif.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding10"))));
            this.errorProviderFNAC.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding12"))));
            this.errorProviderApellidos.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding13"))));
            this.errorProviderPassInv.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding15"))));
            this.errorProviderPassDif.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding16"))));
            this.errorProviderPais.SetIconPadding(this.grupEstadoCivil, ((int)(resources.GetObject("grupEstadoCivil.IconPadding17"))));
            this.grupEstadoCivil.Name = "grupEstadoCivil";
            this.grupEstadoCivil.TabStop = false;
            // 
            // Admin_Perfil_rButom_Divorciado
            // 
            resources.ApplyResources(this.Admin_Perfil_rButom_Divorciado, "Admin_Perfil_rButom_Divorciado");
            this.errorProviderNombre.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error"));
            this.errorProviderNick.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error1"));
            this.errorProviderEC.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error2"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error3"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error4"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error5"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error6"));
            this.errorProviderMail.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error7"));
            this.errorProviderMov.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error8"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error9"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error10"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error11"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error12"));
            this.errorProviderNif.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error13"));
            this.errorProviderCP.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error14"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error15"));
            this.errorProviderPais.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error16"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_rButom_Divorciado, resources.GetString("Admin_Perfil_rButom_Divorciado.Error17"));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment1"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment3"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment5"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment7"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment8"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment9"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment10"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment13"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment14"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment15"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment16"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_rButom_Divorciado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconAlignment17"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding1"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding2"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding3"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding5"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding7"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding10"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding14"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding15"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_rButom_Divorciado, ((int)(resources.GetObject("Admin_Perfil_rButom_Divorciado.IconPadding17"))));
            this.Admin_Perfil_rButom_Divorciado.Name = "Admin_Perfil_rButom_Divorciado";
            this.Admin_Perfil_rButom_Divorciado.TabStop = true;
            this.Admin_Perfil_rButom_Divorciado.Tag = "";
            this.Admin_Perfil_rButom_Divorciado.UseVisualStyleBackColor = true;
            // 
            // Admin_Perfil_rButom_Soltero
            // 
            resources.ApplyResources(this.Admin_Perfil_rButom_Soltero, "Admin_Perfil_rButom_Soltero");
            this.errorProviderNombre.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error"));
            this.errorProviderNick.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error1"));
            this.errorProviderEC.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error2"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error3"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error4"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error5"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error6"));
            this.errorProviderMail.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error7"));
            this.errorProviderMov.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error8"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error9"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error10"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error11"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error12"));
            this.errorProviderNif.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error13"));
            this.errorProviderCP.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error14"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error15"));
            this.errorProviderPais.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error16"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_rButom_Soltero, resources.GetString("Admin_Perfil_rButom_Soltero.Error17"));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment1"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment3"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment5"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment7"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment8"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment9"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment10"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment13"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment14"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment15"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment16"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_rButom_Soltero, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconAlignment17"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding1"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding2"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding3"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding5"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding7"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding10"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding14"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding15"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_rButom_Soltero, ((int)(resources.GetObject("Admin_Perfil_rButom_Soltero.IconPadding17"))));
            this.Admin_Perfil_rButom_Soltero.Name = "Admin_Perfil_rButom_Soltero";
            this.Admin_Perfil_rButom_Soltero.TabStop = true;
            this.Admin_Perfil_rButom_Soltero.UseVisualStyleBackColor = true;
            // 
            // Admin_Perfil_rButom_Casado
            // 
            resources.ApplyResources(this.Admin_Perfil_rButom_Casado, "Admin_Perfil_rButom_Casado");
            this.errorProviderNombre.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error"));
            this.errorProviderNick.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error1"));
            this.errorProviderEC.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error2"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error3"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error4"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error5"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error6"));
            this.errorProviderMail.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error7"));
            this.errorProviderMov.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error8"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error9"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error10"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error11"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error12"));
            this.errorProviderNif.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error13"));
            this.errorProviderCP.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error14"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error15"));
            this.errorProviderPais.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error16"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_rButom_Casado, resources.GetString("Admin_Perfil_rButom_Casado.Error17"));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment1"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment3"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment5"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment7"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment8"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment9"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment10"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment13"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment14"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment15"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment16"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_rButom_Casado, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Casado.IconAlignment17"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding1"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding2"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding3"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding5"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding7"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding10"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding14"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding15"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_rButom_Casado, ((int)(resources.GetObject("Admin_Perfil_rButom_Casado.IconPadding17"))));
            this.Admin_Perfil_rButom_Casado.Name = "Admin_Perfil_rButom_Casado";
            this.Admin_Perfil_rButom_Casado.TabStop = true;
            this.Admin_Perfil_rButom_Casado.UseVisualStyleBackColor = true;
            // 
            // Admin_Perfil_rButom_Viudo
            // 
            resources.ApplyResources(this.Admin_Perfil_rButom_Viudo, "Admin_Perfil_rButom_Viudo");
            this.errorProviderNombre.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error"));
            this.errorProviderNick.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error1"));
            this.errorProviderEC.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error2"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error3"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error4"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error5"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error6"));
            this.errorProviderMail.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error7"));
            this.errorProviderMov.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error8"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error9"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error10"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error11"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error12"));
            this.errorProviderNif.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error13"));
            this.errorProviderCP.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error14"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error15"));
            this.errorProviderPais.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error16"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_rButom_Viudo, resources.GetString("Admin_Perfil_rButom_Viudo.Error17"));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment1"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment2"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment3"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment5"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment7"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment8"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment9"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment10"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment11"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment13"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment14"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment15"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment16"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_rButom_Viudo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconAlignment17"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding1"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding2"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding3"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding5"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding6"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding7"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding10"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding11"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding13"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding14"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding15"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_rButom_Viudo, ((int)(resources.GetObject("Admin_Perfil_rButom_Viudo.IconPadding17"))));
            this.Admin_Perfil_rButom_Viudo.Name = "Admin_Perfil_rButom_Viudo";
            this.Admin_Perfil_rButom_Viudo.TabStop = true;
            this.Admin_Perfil_rButom_Viudo.UseVisualStyleBackColor = true;
            // 
            // Admin_Perfil_Label_Nombre
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_Nombre, "Admin_Perfil_Label_Nombre");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_Nombre, resources.GetString("Admin_Perfil_Label_Nombre.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_Nombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Nombre.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_Nombre, ((int)(resources.GetObject("Admin_Perfil_Label_Nombre.IconPadding17"))));
            this.Admin_Perfil_Label_Nombre.Name = "Admin_Perfil_Label_Nombre";
            // 
            // Admin_Perfil_Label_Apellidos
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_Apellidos, "Admin_Perfil_Label_Apellidos");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_Apellidos, resources.GetString("Admin_Perfil_Label_Apellidos.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_Apellidos, ((int)(resources.GetObject("Admin_Perfil_Label_Apellidos.IconPadding17"))));
            this.Admin_Perfil_Label_Apellidos.Name = "Admin_Perfil_Label_Apellidos";
            // 
            // Admin_Perfil_Label_Pais
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_Pais, "Admin_Perfil_Label_Pais");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_Pais, resources.GetString("Admin_Perfil_Label_Pais.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Pais.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_Pais, ((int)(resources.GetObject("Admin_Perfil_Label_Pais.IconPadding17"))));
            this.Admin_Perfil_Label_Pais.Name = "Admin_Perfil_Label_Pais";
            // 
            // Label_Localidad
            // 
            resources.ApplyResources(this.Label_Localidad, "Label_Localidad");
            this.errorProviderNif.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error"));
            this.errorProviderNombre.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error1"));
            this.errorProviderNick.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error2"));
            this.errorProviderDomicilo.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error3"));
            this.errorProviderLocalidad.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error4"));
            this.errorProviderCP.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error5"));
            this.errorProviderProvincia.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error6"));
            this.errorProviderMov.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error7"));
            this.errorProviderSexo.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error8"));
            this.errorProviderEC.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error9"));
            this.errorProviderApellidos.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error10"));
            this.errorProviderPassAnt.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error11"));
            this.errorProviderPais.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error12"));
            this.errorProviderTEL.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error13"));
            this.errorProviderPassInv.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error14"));
            this.errorProviderFNAC.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error15"));
            this.errorProviderMail.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error16"));
            this.errorProviderPassDif.SetError(this.Label_Localidad, resources.GetString("Label_Localidad.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Label_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Label_Localidad.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Label_Localidad, ((int)(resources.GetObject("Label_Localidad.IconPadding17"))));
            this.Label_Localidad.Name = "Label_Localidad";
            // 
            // Admin_Perfil_Label_FecNacimiento
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_FecNacimiento, "Admin_Perfil_Label_FecNacimiento");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_FecNacimiento, resources.GetString("Admin_Perfil_Label_FecNacimiento.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_FecNacimiento, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_FecNacimiento, ((int)(resources.GetObject("Admin_Perfil_Label_FecNacimiento.IconPadding17"))));
            this.Admin_Perfil_Label_FecNacimiento.Name = "Admin_Perfil_Label_FecNacimiento";
            // 
            // Admin_Perfil_Label_NIF
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_NIF, "Admin_Perfil_Label_NIF");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_NIF, resources.GetString("Admin_Perfil_Label_NIF.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_NIF.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_NIF, ((int)(resources.GetObject("Admin_Perfil_Label_NIF.IconPadding17"))));
            this.Admin_Perfil_Label_NIF.Name = "Admin_Perfil_Label_NIF";
            // 
            // Admin_Perfil_Label_Domicilio
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_Domicilio, "Admin_Perfil_Label_Domicilio");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_Domicilio, resources.GetString("Admin_Perfil_Label_Domicilio.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_Domicilio, ((int)(resources.GetObject("Admin_Perfil_Label_Domicilio.IconPadding17"))));
            this.Admin_Perfil_Label_Domicilio.Name = "Admin_Perfil_Label_Domicilio";
            // 
            // Admin_Perfil_txtBox_Domicilio
            // 
            resources.ApplyResources(this.Admin_Perfil_txtBox_Domicilio, "Admin_Perfil_txtBox_Domicilio");
            this.errorProviderPassDif.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error"));
            this.errorProviderMail.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error1"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error2"));
            this.errorProviderNick.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error3"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error4"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error5"));
            this.errorProviderCP.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error6"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error7"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error8"));
            this.errorProviderNif.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error9"));
            this.errorProviderPais.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error10"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error11"));
            this.errorProviderMov.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error13"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error14"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error15"));
            this.errorProviderEC.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error16"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_txtBox_Domicilio, resources.GetString("Admin_Perfil_txtBox_Domicilio.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_txtBox_Domicilio, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_txtBox_Domicilio, ((int)(resources.GetObject("Admin_Perfil_txtBox_Domicilio.IconPadding17"))));
            this.Admin_Perfil_txtBox_Domicilio.Name = "Admin_Perfil_txtBox_Domicilio";
            // 
            // txtBox_Localidad
            // 
            resources.ApplyResources(this.txtBox_Localidad, "txtBox_Localidad");
            this.errorProviderPassDif.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error"));
            this.errorProviderMail.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error1"));
            this.errorProviderPassInv.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error2"));
            this.errorProviderNick.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error3"));
            this.errorProviderPassAnt.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error4"));
            this.errorProviderApellidos.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error5"));
            this.errorProviderCP.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error6"));
            this.errorProviderLocalidad.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error7"));
            this.errorProviderNombre.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error8"));
            this.errorProviderNif.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error9"));
            this.errorProviderPais.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error10"));
            this.errorProviderDomicilo.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error11"));
            this.errorProviderMov.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error12"));
            this.errorProviderTEL.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error13"));
            this.errorProviderFNAC.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error14"));
            this.errorProviderProvincia.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error15"));
            this.errorProviderEC.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error16"));
            this.errorProviderSexo.SetError(this.txtBox_Localidad, resources.GetString("txtBox_Localidad.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.txtBox_Localidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBox_Localidad.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.txtBox_Localidad, ((int)(resources.GetObject("txtBox_Localidad.IconPadding17"))));
            this.txtBox_Localidad.Name = "txtBox_Localidad";
            // 
            // Admin_Perfil_comboBox_Pais
            // 
            resources.ApplyResources(this.Admin_Perfil_comboBox_Pais, "Admin_Perfil_comboBox_Pais");
            this.errorProviderFNAC.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error1"));
            this.errorProviderMail.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error2"));
            this.errorProviderNick.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error3"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error4"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error5"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error6"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error7"));
            this.errorProviderCP.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error8"));
            this.errorProviderPais.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error9"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error10"));
            this.errorProviderNif.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error11"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error12"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error13"));
            this.errorProviderMov.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error14"));
            this.errorProviderEC.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error15"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error16"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_comboBox_Pais, resources.GetString("Admin_Perfil_comboBox_Pais.Error17"));
            this.Admin_Perfil_comboBox_Pais.FormattingEnabled = true;
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment1"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment2"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment3"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment4"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment7"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment8"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment9"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment10"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment11"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment12"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment14"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment15"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment16"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_comboBox_Pais, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconAlignment17"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding1"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding2"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding4"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding6"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding7"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding8"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding10"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding11"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding12"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding13"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding14"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding15"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding16"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_comboBox_Pais, ((int)(resources.GetObject("Admin_Perfil_comboBox_Pais.IconPadding17"))));
            this.Admin_Perfil_comboBox_Pais.Items.AddRange(new object[] {
            resources.GetString("Admin_Perfil_comboBox_Pais.Items"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items1"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items2"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items3"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items4"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items5"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items6"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items7"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items8"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items9"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items10"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items11"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items12"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items13"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items14"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items15"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items16"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items17"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items18"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items19"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items20"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items21"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items22"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items23"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items24"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items25"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items26"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items27"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items28"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items29"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items30"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items31"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items32"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items33"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items34"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items35"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items36"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items37"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items38"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items39"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items40"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items41"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items42"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items43"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items44"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items45"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items46"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items47"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items48"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items49"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items50"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items51"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items52"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items53"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items54"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items55"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items56"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items57"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items58"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items59"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items60"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items61"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items62"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items63"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items64"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items65"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items66"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items67"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items68"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items69"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items70"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items71"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items72"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items73"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items74"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items75"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items76"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items77"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items78"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items79"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items80"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items81"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items82"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items83"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items84"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items85"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items86"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items87"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items88"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items89"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items90"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items91"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items92"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items93"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items94"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items95"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items96"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items97"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items98"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items99"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items100"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items101"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items102"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items103"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items104"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items105"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items106"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items107"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items108"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items109"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items110"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items111"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items112"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items113"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items114"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items115"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items116"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items117"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items118"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items119"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items120"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items121"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items122"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items123"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items124"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items125"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items126"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items127"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items128"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items129"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items130"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items131"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items132"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items133"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items134"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items135"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items136"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items137"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items138"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items139"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items140"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items141"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items142"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items143"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items144"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items145"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items146"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items147"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items148"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items149"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items150"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items151"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items152"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items153"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items154"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items155"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items156"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items157"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items158"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items159"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items160"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items161"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items162"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items163"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items164"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items165"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items166"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items167"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items168"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items169"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items170"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items171"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items172"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items173"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items174"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items175"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items176"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items177"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items178"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items179"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items180"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items181"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items182"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items183"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items184"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items185"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items186"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items187"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items188"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items189"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items190"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items191"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items192"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items193"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items194"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items195"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items196"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items197"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items198"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items199"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items200"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items201"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items202"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items203"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items204"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items205"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items206"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items207"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items208"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items209"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items210"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items211"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items212"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items213"),
            resources.GetString("Admin_Perfil_comboBox_Pais.Items214")});
            this.Admin_Perfil_comboBox_Pais.Name = "Admin_Perfil_comboBox_Pais";
            // 
            // Admin_Perfil_Label_Sexo
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_Sexo, "Admin_Perfil_Label_Sexo");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_Sexo, resources.GetString("Admin_Perfil_Label_Sexo.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_Sexo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_Sexo.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_Sexo, ((int)(resources.GetObject("Admin_Perfil_Label_Sexo.IconPadding17"))));
            this.Admin_Perfil_Label_Sexo.Name = "Admin_Perfil_Label_Sexo";
            // 
            // Admin_Perfil_txtBox_Apellidos
            // 
            resources.ApplyResources(this.Admin_Perfil_txtBox_Apellidos, "Admin_Perfil_txtBox_Apellidos");
            this.errorProviderPassDif.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error"));
            this.errorProviderMail.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error1"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error2"));
            this.errorProviderNick.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error3"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error4"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error5"));
            this.errorProviderCP.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error6"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error7"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error8"));
            this.errorProviderNif.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error9"));
            this.errorProviderPais.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error10"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error11"));
            this.errorProviderMov.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error13"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error14"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error15"));
            this.errorProviderEC.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error16"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_txtBox_Apellidos, resources.GetString("Admin_Perfil_txtBox_Apellidos.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_txtBox_Apellidos, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_txtBox_Apellidos, ((int)(resources.GetObject("Admin_Perfil_txtBox_Apellidos.IconPadding17"))));
            this.Admin_Perfil_txtBox_Apellidos.Name = "Admin_Perfil_txtBox_Apellidos";
            // 
            // Admin_Perfil_Label_EstCivil
            // 
            resources.ApplyResources(this.Admin_Perfil_Label_EstCivil, "Admin_Perfil_Label_EstCivil");
            this.errorProviderNif.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error1"));
            this.errorProviderNick.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error2"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error3"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error4"));
            this.errorProviderCP.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error5"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error6"));
            this.errorProviderMov.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error7"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error8"));
            this.errorProviderEC.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error9"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error10"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error11"));
            this.errorProviderPais.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error13"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error14"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error15"));
            this.errorProviderMail.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error16"));
            this.errorProviderPassDif.SetError(this.Admin_Perfil_Label_EstCivil, resources.GetString("Admin_Perfil_Label_EstCivil.Error17"));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment1"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment2"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment3"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment4"))));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment5"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment6"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment7"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment8"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment10"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment12"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment13"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment15"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment16"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_Label_EstCivil, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding2"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding3"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding5"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding6"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding8"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding9"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding11"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding12"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding13"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding14"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding15"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_Label_EstCivil, ((int)(resources.GetObject("Admin_Perfil_Label_EstCivil.IconPadding17"))));
            this.Admin_Perfil_Label_EstCivil.Name = "Admin_Perfil_Label_EstCivil";
            // 
            // Admin_Perfil_txtBox_NIF
            // 
            resources.ApplyResources(this.Admin_Perfil_txtBox_NIF, "Admin_Perfil_txtBox_NIF");
            this.errorProviderPassDif.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error"));
            this.errorProviderMail.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error1"));
            this.errorProviderPassInv.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error2"));
            this.errorProviderNick.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error3"));
            this.errorProviderPassAnt.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error4"));
            this.errorProviderApellidos.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error5"));
            this.errorProviderCP.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error6"));
            this.errorProviderLocalidad.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error7"));
            this.errorProviderNombre.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error8"));
            this.errorProviderNif.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error9"));
            this.errorProviderPais.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error10"));
            this.errorProviderDomicilo.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error11"));
            this.errorProviderMov.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error12"));
            this.errorProviderTEL.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error13"));
            this.errorProviderFNAC.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error14"));
            this.errorProviderProvincia.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error15"));
            this.errorProviderEC.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error16"));
            this.errorProviderSexo.SetError(this.Admin_Perfil_txtBox_NIF, resources.GetString("Admin_Perfil_txtBox_NIF.Error17"));
            this.errorProviderTEL.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment"))));
            this.errorProviderMov.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment1"))));
            this.errorProviderFNAC.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment2"))));
            this.errorProviderMail.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment3"))));
            this.errorProviderEC.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment5"))));
            this.errorProviderCP.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment6"))));
            this.errorProviderLocalidad.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment8"))));
            this.errorProviderApellidos.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment9"))));
            this.errorProviderNif.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment10"))));
            this.errorProviderPais.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment11"))));
            this.errorProviderNick.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment12"))));
            this.errorProviderPassAnt.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment13"))));
            this.errorProviderDomicilo.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment14"))));
            this.errorProviderNombre.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment15"))));
            this.errorProviderPassDif.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment16"))));
            this.errorProviderPassInv.SetIconAlignment(this.Admin_Perfil_txtBox_NIF, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding"))));
            this.errorProviderDomicilo.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding1"))));
            this.errorProviderProvincia.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding2"))));
            this.errorProviderNombre.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding3"))));
            this.errorProviderNif.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding5"))));
            this.errorProviderCP.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding7"))));
            this.errorProviderPassDif.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding8"))));
            this.errorProviderMail.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding9"))));
            this.errorProviderApellidos.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding10"))));
            this.errorProviderNick.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding11"))));
            this.errorProviderPassAnt.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding13"))));
            this.errorProviderSexo.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding14"))));
            this.errorProviderTEL.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding15"))));
            this.errorProviderMov.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this.Admin_Perfil_txtBox_NIF, ((int)(resources.GetObject("Admin_Perfil_txtBox_NIF.IconPadding17"))));
            this.Admin_Perfil_txtBox_NIF.Name = "Admin_Perfil_txtBox_NIF";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.Buscar);
            this.tabControl1.Controls.Add(this.Perfil);
            this.errorProviderMail.SetError(this.tabControl1, resources.GetString("tabControl1.Error"));
            this.errorProviderPais.SetError(this.tabControl1, resources.GetString("tabControl1.Error1"));
            this.errorProviderDomicilo.SetError(this.tabControl1, resources.GetString("tabControl1.Error2"));
            this.errorProviderSexo.SetError(this.tabControl1, resources.GetString("tabControl1.Error3"));
            this.errorProviderMov.SetError(this.tabControl1, resources.GetString("tabControl1.Error4"));
            this.errorProviderProvincia.SetError(this.tabControl1, resources.GetString("tabControl1.Error5"));
            this.errorProviderEC.SetError(this.tabControl1, resources.GetString("tabControl1.Error6"));
            this.errorProviderNif.SetError(this.tabControl1, resources.GetString("tabControl1.Error7"));
            this.errorProviderFNAC.SetError(this.tabControl1, resources.GetString("tabControl1.Error8"));
            this.errorProviderTEL.SetError(this.tabControl1, resources.GetString("tabControl1.Error9"));
            this.errorProviderNombre.SetError(this.tabControl1, resources.GetString("tabControl1.Error10"));
            this.errorProviderApellidos.SetError(this.tabControl1, resources.GetString("tabControl1.Error11"));
            this.errorProviderPassDif.SetError(this.tabControl1, resources.GetString("tabControl1.Error12"));
            this.errorProviderPassAnt.SetError(this.tabControl1, resources.GetString("tabControl1.Error13"));
            this.errorProviderCP.SetError(this.tabControl1, resources.GetString("tabControl1.Error14"));
            this.errorProviderPassInv.SetError(this.tabControl1, resources.GetString("tabControl1.Error15"));
            this.errorProviderNick.SetError(this.tabControl1, resources.GetString("tabControl1.Error16"));
            this.errorProviderLocalidad.SetError(this.tabControl1, resources.GetString("tabControl1.Error17"));
            this.errorProviderNif.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment"))));
            this.errorProviderDomicilo.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment1"))));
            this.errorProviderMov.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment2"))));
            this.errorProviderApellidos.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment3"))));
            this.errorProviderNombre.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment4"))));
            this.errorProviderSexo.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment5"))));
            this.errorProviderEC.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment6"))));
            this.errorProviderNick.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment7"))));
            this.errorProviderProvincia.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment8"))));
            this.errorProviderTEL.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment9"))));
            this.errorProviderPassInv.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment10"))));
            this.errorProviderMail.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment11"))));
            this.errorProviderPais.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment12"))));
            this.errorProviderPassDif.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment13"))));
            this.errorProviderLocalidad.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment14"))));
            this.errorProviderPassAnt.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment15"))));
            this.errorProviderFNAC.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment16"))));
            this.errorProviderCP.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment17"))));
            this.errorProviderPais.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding"))));
            this.errorProviderApellidos.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding1"))));
            this.errorProviderNombre.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding2"))));
            this.errorProviderNif.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding3"))));
            this.errorProviderLocalidad.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding4"))));
            this.errorProviderCP.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding5"))));
            this.errorProviderDomicilo.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding6"))));
            this.errorProviderPassDif.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding7"))));
            this.errorProviderMail.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding8"))));
            this.errorProviderNick.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding9"))));
            this.errorProviderPassInv.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding10"))));
            this.errorProviderPassAnt.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding11"))));
            this.errorProviderFNAC.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding12"))));
            this.errorProviderEC.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding13"))));
            this.errorProviderProvincia.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding14"))));
            this.errorProviderSexo.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding15"))));
            this.errorProviderTEL.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding16"))));
            this.errorProviderMov.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding17"))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // errorProviderNif
            // 
            this.errorProviderNif.BlinkRate = 0;
            this.errorProviderNif.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNif.ContainerControl = this;
            resources.ApplyResources(this.errorProviderNif, "errorProviderNif");
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.BlinkRate = 0;
            this.errorProviderNombre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNombre.ContainerControl = this;
            resources.ApplyResources(this.errorProviderNombre, "errorProviderNombre");
            // 
            // errorProviderApellidos
            // 
            this.errorProviderApellidos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderApellidos.ContainerControl = this;
            resources.ApplyResources(this.errorProviderApellidos, "errorProviderApellidos");
            // 
            // errorProviderPais
            // 
            this.errorProviderPais.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPais.ContainerControl = this;
            resources.ApplyResources(this.errorProviderPais, "errorProviderPais");
            // 
            // errorProviderLocalidad
            // 
            this.errorProviderLocalidad.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLocalidad.ContainerControl = this;
            resources.ApplyResources(this.errorProviderLocalidad, "errorProviderLocalidad");
            // 
            // errorProviderCP
            // 
            this.errorProviderCP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCP.ContainerControl = this;
            resources.ApplyResources(this.errorProviderCP, "errorProviderCP");
            // 
            // errorProviderProvincia
            // 
            this.errorProviderProvincia.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderProvincia.ContainerControl = this;
            resources.ApplyResources(this.errorProviderProvincia, "errorProviderProvincia");
            // 
            // errorProviderDomicilo
            // 
            this.errorProviderDomicilo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDomicilo.ContainerControl = this;
            resources.ApplyResources(this.errorProviderDomicilo, "errorProviderDomicilo");
            // 
            // errorProviderSexo
            // 
            this.errorProviderSexo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSexo.ContainerControl = this;
            resources.ApplyResources(this.errorProviderSexo, "errorProviderSexo");
            // 
            // errorProviderEC
            // 
            this.errorProviderEC.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEC.ContainerControl = this;
            resources.ApplyResources(this.errorProviderEC, "errorProviderEC");
            // 
            // errorProviderTEL
            // 
            this.errorProviderTEL.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTEL.ContainerControl = this;
            resources.ApplyResources(this.errorProviderTEL, "errorProviderTEL");
            // 
            // errorProviderMov
            // 
            this.errorProviderMov.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMov.ContainerControl = this;
            resources.ApplyResources(this.errorProviderMov, "errorProviderMov");
            // 
            // errorProviderMail
            // 
            this.errorProviderMail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMail.ContainerControl = this;
            resources.ApplyResources(this.errorProviderMail, "errorProviderMail");
            // 
            // errorProviderFNAC
            // 
            this.errorProviderFNAC.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFNAC.ContainerControl = this;
            resources.ApplyResources(this.errorProviderFNAC, "errorProviderFNAC");
            // 
            // errorProviderPassInv
            // 
            this.errorProviderPassInv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPassInv.ContainerControl = this;
            resources.ApplyResources(this.errorProviderPassInv, "errorProviderPassInv");
            // 
            // errorProviderPassDif
            // 
            this.errorProviderPassDif.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPassDif.ContainerControl = this;
            resources.ApplyResources(this.errorProviderPassDif, "errorProviderPassDif");
            // 
            // errorProviderNick
            // 
            this.errorProviderNick.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNick.ContainerControl = this;
            resources.ApplyResources(this.errorProviderNick, "errorProviderNick");
            // 
            // errorProviderPassAnt
            // 
            this.errorProviderPassAnt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPassAnt.ContainerControl = this;
            resources.ApplyResources(this.errorProviderPassAnt, "errorProviderPassAnt");
            // 
            // dataGridViewImageColumn1
            // 
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::Events4ALL.Properties.Resources.baron;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = global::Events4ALL.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // Admins
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.errorProviderPais.SetError(this, resources.GetString("$this.Error"));
            this.errorProviderMail.SetError(this, resources.GetString("$this.Error1"));
            this.errorProviderFNAC.SetError(this, resources.GetString("$this.Error2"));
            this.errorProviderPassDif.SetError(this, resources.GetString("$this.Error3"));
            this.errorProviderApellidos.SetError(this, resources.GetString("$this.Error4"));
            this.errorProviderPassInv.SetError(this, resources.GetString("$this.Error5"));
            this.errorProviderProvincia.SetError(this, resources.GetString("$this.Error6"));
            this.errorProviderMov.SetError(this, resources.GetString("$this.Error7"));
            this.errorProviderEC.SetError(this, resources.GetString("$this.Error8"));
            this.errorProviderSexo.SetError(this, resources.GetString("$this.Error9"));
            this.errorProviderNif.SetError(this, resources.GetString("$this.Error10"));
            this.errorProviderNombre.SetError(this, resources.GetString("$this.Error11"));
            this.errorProviderTEL.SetError(this, resources.GetString("$this.Error12"));
            this.errorProviderLocalidad.SetError(this, resources.GetString("$this.Error13"));
            this.errorProviderPassAnt.SetError(this, resources.GetString("$this.Error14"));
            this.errorProviderCP.SetError(this, resources.GetString("$this.Error15"));
            this.errorProviderDomicilo.SetError(this, resources.GetString("$this.Error16"));
            this.errorProviderNick.SetError(this, resources.GetString("$this.Error17"));
            this.errorProviderEC.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProviderNombre.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProviderSexo.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment2"))));
            this.errorProviderLocalidad.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment3"))));
            this.errorProviderCP.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment4"))));
            this.errorProviderApellidos.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment5"))));
            this.errorProviderPais.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment6"))));
            this.errorProviderNif.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment7"))));
            this.errorProviderDomicilo.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment8"))));
            this.errorProviderProvincia.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment9"))));
            this.errorProviderMail.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment10"))));
            this.errorProviderPassAnt.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment11"))));
            this.errorProviderTEL.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment12"))));
            this.errorProviderFNAC.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment13"))));
            this.errorProviderPassInv.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment14"))));
            this.errorProviderPassDif.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment15"))));
            this.errorProviderMov.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment16"))));
            this.errorProviderNick.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment17"))));
            this.errorProviderCP.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.errorProviderPais.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.errorProviderDomicilo.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding2"))));
            this.errorProviderProvincia.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding3"))));
            this.errorProviderNick.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding4"))));
            this.errorProviderLocalidad.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding5"))));
            this.errorProviderPassAnt.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding6"))));
            this.errorProviderPassInv.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding7"))));
            this.errorProviderEC.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding8"))));
            this.errorProviderNombre.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding9"))));
            this.errorProviderSexo.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding10"))));
            this.errorProviderMov.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding11"))));
            this.errorProviderTEL.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding12"))));
            this.errorProviderPassDif.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding13"))));
            this.errorProviderMail.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding14"))));
            this.errorProviderApellidos.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding15"))));
            this.errorProviderNif.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding16"))));
            this.errorProviderFNAC.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding17"))));
            this.Name = "Admins";
            this.Buscar.ResumeLayout(false);
            this.groupBox_Busqueda.ResumeLayout(false);
            this.groupBox_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultados_Busqueda)).EndInit();
            this.Perfil.ResumeLayout(false);
            this.groupBox_UsPs.ResumeLayout(false);
            this.groupBox_UsPs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Perfil_Foto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.grupEstadoCivil.ResumeLayout(false);
            this.grupEstadoCivil.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDomicilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFNAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassDif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassAnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Buscar;
        private System.Windows.Forms.TabPage Perfil;
        private System.Windows.Forms.Label Admin_Perfil_Label_Apellidos;
        private System.Windows.Forms.Label Admin_Perfil_Label_Nombre;
        private System.Windows.Forms.Label Admin_Perfil_Label_Domicilio;
        private System.Windows.Forms.Label Admin_Perfil_Label_Mail;
        private System.Windows.Forms.Label Admin_Perfil_Label_Tel1;
        private System.Windows.Forms.Label Admin_Perfil_Label_Tel2;
        private System.Windows.Forms.Label Admin_Perfil_Label_Sexo;
        private System.Windows.Forms.Label Admin_Perfil_Label_NIF;
        private System.Windows.Forms.Label Admin_Perfil_Label_FecNacimiento;
        private System.Windows.Forms.Label Label_Localidad;
        private System.Windows.Forms.Label Admin_Perfil_Label_Pais;
        private System.Windows.Forms.TextBox Admin_Perfil_txtBox_Mail;
        private System.Windows.Forms.TextBox Admin_Perfil_txtBox_NIF;
        private System.Windows.Forms.TextBox Admin_Perfil_txtBox_Apellidos;
        private System.Windows.Forms.TextBox txtBox_Localidad;
        private System.Windows.Forms.TextBox Admin_Perfil_txtBox_Domicilio;
        private System.Windows.Forms.TextBox Admin_Perfil_txtBox_Tel2;
        private System.Windows.Forms.TextBox Admin_Perfil_txtBox_Tel1;
        private System.Windows.Forms.ComboBox Admin_Perfil_comboBox_Pais;
        private System.Windows.Forms.RadioButton Admin_Perfil_rButom_Viudo;
        private System.Windows.Forms.RadioButton Admin_Perfil_rButom_Divorciado;
        private System.Windows.Forms.RadioButton Admin_Perfil_rButom_Casado;
        private System.Windows.Forms.RadioButton Admin_Perfil_rButom_Soltero;
        private System.Windows.Forms.RadioButton Admin_Perfil_rButom_M;
        private System.Windows.Forms.RadioButton Admin_Perfil_rButom_H;
        private System.Windows.Forms.Button Admin_Perfil_boton_Guardar;
        private System.Windows.Forms.Button Admin_Perfil_boton_Anadir;
        private System.Windows.Forms.DataGridView Resultados_Busqueda;
        private System.Windows.Forms.Button Admin_Perfil_boton_Foto;
        private System.Windows.Forms.PictureBox Admin_Perfil_Foto;
        private System.Windows.Forms.GroupBox grupEstadoCivil;
        private System.Windows.Forms.Label Admin_Perfil_Label_EstCivil;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDirec;
        private System.Windows.Forms.TextBox textBox_CP_Perfil;
        private System.Windows.Forms.Label label_CP_Perfil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label_Provincia_Perfil;
        private System.Windows.Forms.GroupBox groupBox_Busqueda;
        private System.Windows.Forms.Button buttom_Buscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ComboBox comboBox_Provincia;
        public System.Windows.Forms.TextBox Admin_Perfil_txtBox_Nombre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorProviderNif;
        private System.Windows.Forms.Label test2;
        private System.Windows.Forms.Label test1;
        private System.Windows.Forms.Label test3;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderApellidos;
        private System.Windows.Forms.ErrorProvider errorProviderPais;
        private System.Windows.Forms.ErrorProvider errorProviderLocalidad;
        private System.Windows.Forms.ErrorProvider errorProviderCP;
        private System.Windows.Forms.ErrorProvider errorProviderProvincia;
        private System.Windows.Forms.ErrorProvider errorProviderDomicilo;
        private System.Windows.Forms.ErrorProvider errorProviderSexo;
        private System.Windows.Forms.ErrorProvider errorProviderEC;
        private System.Windows.Forms.ErrorProvider errorProviderTEL;
        private System.Windows.Forms.ErrorProvider errorProviderMov;
        private System.Windows.Forms.ErrorProvider errorProviderMail;
        private System.Windows.Forms.ErrorProvider errorProviderFNAC;
        private System.Windows.Forms.GroupBox groupBox_UsPs;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_pass2;
        private System.Windows.Forms.TextBox textBox_pass1;
        private System.Windows.Forms.Label label_pass2;
        private System.Windows.Forms.Label label_pass1;
        private System.Windows.Forms.TextBox textBox_NombreUsuario;
        private System.Windows.Forms.Label label_NombreUsuario;
        private System.Windows.Forms.ErrorProvider errorProviderPassInv;
        private System.Windows.Forms.ErrorProvider errorProviderPassDif;
        private System.Windows.Forms.ErrorProvider errorProviderNick;
        private System.Windows.Forms.Button boton_limpia_busqueda;
        private System.Windows.Forms.TextBox textBox_anterior_pass;
        private System.Windows.Forms.Label label_anterior_pass;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.ErrorProvider errorProviderPassAnt;
        private System.Windows.Forms.Label label_filtro;
        private System.Windows.Forms.ComboBox comboBox_filtro;
        private System.Windows.Forms.TextBox textBox_filtro_busqueda;
        private System.Windows.Forms.ComboBox comboBox_filtro_busqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn borrar;

    }
}
