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
            this.components = new System.ComponentModel.Container();
            this.formCliente = new System.Windows.Forms.TabControl();
            this.FichaCliente = new System.Windows.Forms.TabPage();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonLimpiarCliente = new System.Windows.Forms.Button();
            this.buttonGuardarCliente = new System.Windows.Forms.Button();
            this.buttonFotoCliente = new System.Windows.Forms.Button();
            this.cliente_Perfil_Foto = new System.Windows.Forms.PictureBox();
            this.comboBoxProvinciaCli = new System.Windows.Forms.GroupBox();
            this.textBoxNifC = new System.Windows.Forms.TextBox();
            this.comboBoxProvCli = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCli = new System.Windows.Forms.DateTimePicker();
            this.groupContactoCliente = new System.Windows.Forms.GroupBox();
            this.telefonoCli = new System.Windows.Forms.Label();
            this.MovilCli = new System.Windows.Forms.Label();
            this.emailCli = new System.Windows.Forms.Label();
            this.textBoxTelfCli = new System.Windows.Forms.TextBox();
            this.textBoxMovilCli = new System.Windows.Forms.TextBox();
            this.textBoxEmailCli = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.rButom_H_Cliente = new System.Windows.Forms.RadioButton();
            this.rButom_M_Cliente = new System.Windows.Forms.RadioButton();
            this.comboBoxDomiciCli = new System.Windows.Forms.ComboBox();
            this.textBoxDomiciCli = new System.Windows.Forms.TextBox();
            this.labelDomiciCli = new System.Windows.Forms.Label();
            this.textBoxLocaliCli = new System.Windows.Forms.TextBox();
            this.labelLocaliCli = new System.Windows.Forms.Label();
            this.labelCPCli = new System.Windows.Forms.Label();
            this.textBoxCPCli = new System.Windows.Forms.TextBox();
            this.labelClienteProv = new System.Windows.Forms.Label();
            this.comboBoxPaisCli = new System.Windows.Forms.ComboBox();
            this.labelPaisCli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellidosC = new System.Windows.Forms.TextBox();
            this.labelApellidosCliente = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelNifCliente = new System.Windows.Forms.Label();
            this.textBoxNombreC = new System.Windows.Forms.TextBox();
            this.BuscarCliente = new System.Windows.Forms.TabPage();
            this.Resultado_busqueda_cliente = new System.Windows.Forms.DataGridView();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBoxBusquedaCliente = new System.Windows.Forms.GroupBox();
            this.textBox_filtro_busqueda = new System.Windows.Forms.TextBox();
            this.comboBox_filtro_busqueda = new System.Windows.Forms.ComboBox();
            this.label_filtro_busqueda = new System.Windows.Forms.Label();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonNuevoCliente = new System.Windows.Forms.Button();
            this.formCliente.SuspendLayout();
            this.FichaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_Perfil_Foto)).BeginInit();
            this.comboBoxProvinciaCli.SuspendLayout();
            this.groupContactoCliente.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.BuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultado_busqueda_cliente)).BeginInit();
            this.groupBoxBusquedaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // formCliente
            // 
            this.formCliente.AccessibleDescription = "Formulario Cliente";
            this.formCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formCliente.Controls.Add(this.BuscarCliente);
            this.formCliente.Controls.Add(this.FichaCliente);
            this.formCliente.Location = new System.Drawing.Point(3, 0);
            this.formCliente.Name = "formCliente";
            this.formCliente.SelectedIndex = 0;
            this.formCliente.Size = new System.Drawing.Size(901, 633);
            this.formCliente.TabIndex = 1;
            this.formCliente.Click += new System.EventHandler(this.formCliente_Click);
            // 
            // FichaCliente
            // 
            this.FichaCliente.AccessibleDescription = "Ficha Cliente";
            this.FichaCliente.Controls.Add(this.buttonNuevoCliente);
            this.FichaCliente.Controls.Add(this.textBoxPassword);
            this.FichaCliente.Controls.Add(this.textBoxUsuario);
            this.FichaCliente.Controls.Add(this.labelPassword);
            this.FichaCliente.Controls.Add(this.labelUsuario);
            this.FichaCliente.Controls.Add(this.buttonLimpiarCliente);
            this.FichaCliente.Controls.Add(this.buttonGuardarCliente);
            this.FichaCliente.Controls.Add(this.buttonFotoCliente);
            this.FichaCliente.Controls.Add(this.cliente_Perfil_Foto);
            this.FichaCliente.Controls.Add(this.comboBoxProvinciaCli);
            this.FichaCliente.Location = new System.Drawing.Point(4, 22);
            this.FichaCliente.Name = "FichaCliente";
            this.FichaCliente.Padding = new System.Windows.Forms.Padding(3);
            this.FichaCliente.Size = new System.Drawing.Size(893, 607);
            this.FichaCliente.TabIndex = 0;
            this.FichaCliente.Text = "Perfil";
            this.FichaCliente.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(628, 447);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 12;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(628, 381);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 11;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(625, 431);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(625, 362);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Usuario";
            // 
            // buttonLimpiarCliente
            // 
            this.buttonLimpiarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpiarCliente.Image = global::Events4ALL.Properties.Resources.clear_2;
            this.buttonLimpiarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiarCliente.Location = new System.Drawing.Point(710, 555);
            this.buttonLimpiarCliente.Name = "buttonLimpiarCliente";
            this.buttonLimpiarCliente.Size = new System.Drawing.Size(70, 23);
            this.buttonLimpiarCliente.TabIndex = 8;
            this.buttonLimpiarCliente.Text = "Limpiar";
            this.buttonLimpiarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimpiarCliente.UseVisualStyleBackColor = true;
            this.buttonLimpiarCliente.Click += new System.EventHandler(this.buttonLimpiarCliente_Click);
            // 
            // buttonGuardarCliente
            // 
            this.buttonGuardarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuardarCliente.Image = global::Events4ALL.Properties.Resources.add_save;
            this.buttonGuardarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonGuardarCliente.Location = new System.Drawing.Point(786, 555);
            this.buttonGuardarCliente.Name = "buttonGuardarCliente";
            this.buttonGuardarCliente.Size = new System.Drawing.Size(70, 23);
            this.buttonGuardarCliente.TabIndex = 7;
            this.buttonGuardarCliente.Text = "Guardar";
            this.buttonGuardarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardarCliente.UseVisualStyleBackColor = true;
            this.buttonGuardarCliente.Click += new System.EventHandler(this.buttonGuardarCliente_Click);
            // 
            // buttonFotoCliente
            // 
            this.buttonFotoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFotoCliente.Image = global::Events4ALL.Properties.Resources.photo;
            this.buttonFotoCliente.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonFotoCliente.Location = new System.Drawing.Point(674, 318);
            this.buttonFotoCliente.Name = "buttonFotoCliente";
            this.buttonFotoCliente.Size = new System.Drawing.Size(121, 23);
            this.buttonFotoCliente.TabIndex = 6;
            this.buttonFotoCliente.Text = "Seleccionar Foto...";
            this.buttonFotoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFotoCliente.UseVisualStyleBackColor = true;
            this.buttonFotoCliente.Click += new System.EventHandler(this.buttonFotoCliente_Click);
            // 
            // cliente_Perfil_Foto
            // 
            this.cliente_Perfil_Foto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cliente_Perfil_Foto.Image = global::Events4ALL.Properties.Resources.foto_usuario_defectojpg;
            this.cliente_Perfil_Foto.Location = new System.Drawing.Point(604, 43);
            this.cliente_Perfil_Foto.Name = "cliente_Perfil_Foto";
            this.cliente_Perfil_Foto.Size = new System.Drawing.Size(255, 252);
            this.cliente_Perfil_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cliente_Perfil_Foto.TabIndex = 5;
            this.cliente_Perfil_Foto.TabStop = false;
            this.cliente_Perfil_Foto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxProvinciaCli
            // 
            this.comboBoxProvinciaCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProvinciaCli.Controls.Add(this.textBoxNifC);
            this.comboBoxProvinciaCli.Controls.Add(this.comboBoxProvCli);
            this.comboBoxProvinciaCli.Controls.Add(this.dateTimePickerCli);
            this.comboBoxProvinciaCli.Controls.Add(this.groupContactoCliente);
            this.comboBoxProvinciaCli.Controls.Add(this.groupBoxSexo);
            this.comboBoxProvinciaCli.Controls.Add(this.comboBoxDomiciCli);
            this.comboBoxProvinciaCli.Controls.Add(this.textBoxDomiciCli);
            this.comboBoxProvinciaCli.Controls.Add(this.labelDomiciCli);
            this.comboBoxProvinciaCli.Controls.Add(this.textBoxLocaliCli);
            this.comboBoxProvinciaCli.Controls.Add(this.labelLocaliCli);
            this.comboBoxProvinciaCli.Controls.Add(this.labelCPCli);
            this.comboBoxProvinciaCli.Controls.Add(this.textBoxCPCli);
            this.comboBoxProvinciaCli.Controls.Add(this.labelClienteProv);
            this.comboBoxProvinciaCli.Controls.Add(this.comboBoxPaisCli);
            this.comboBoxProvinciaCli.Controls.Add(this.labelPaisCli);
            this.comboBoxProvinciaCli.Controls.Add(this.label1);
            this.comboBoxProvinciaCli.Controls.Add(this.textBoxApellidosC);
            this.comboBoxProvinciaCli.Controls.Add(this.labelApellidosCliente);
            this.comboBoxProvinciaCli.Controls.Add(this.labelNombreCliente);
            this.comboBoxProvinciaCli.Controls.Add(this.labelNifCliente);
            this.comboBoxProvinciaCli.Controls.Add(this.textBoxNombreC);
            this.comboBoxProvinciaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProvinciaCli.Location = new System.Drawing.Point(35, 34);
            this.comboBoxProvinciaCli.Name = "comboBoxProvinciaCli";
            this.comboBoxProvinciaCli.Size = new System.Drawing.Size(545, 543);
            this.comboBoxProvinciaCli.TabIndex = 4;
            this.comboBoxProvinciaCli.TabStop = false;
            this.comboBoxProvinciaCli.Text = "Datos Personales";
            this.comboBoxProvinciaCli.Enter += new System.EventHandler(this.datosPersonalesClientes_Enter);
            // 
            // textBoxNifC
            // 
            this.textBoxNifC.Location = new System.Drawing.Point(35, 113);
            this.textBoxNifC.Name = "textBoxNifC";
            this.textBoxNifC.Size = new System.Drawing.Size(75, 20);
            this.textBoxNifC.TabIndex = 82;
            // 
            // comboBoxProvCli
            // 
            this.comboBoxProvCli.FormattingEnabled = true;
            this.comboBoxProvCli.Items.AddRange(new object[] {
            "",
            "Álava",
            "Albacete",
            "Alicante",
            "Almería",
            "Asturias",
            "Avila",
            "Badajoz",
            "Barcelona",
            "Burgos",
            "Cáceres",
            "Cádiz",
            "Cantabria",
            "Castellón",
            "Ceuta",
            "Ciudad Real",
            "Córdoba",
            "Cuenca",
            "Gerona",
            "Granada",
            "Guadalajara",
            "Huelva",
            "Huesca",
            "Islas Baleares",
            "Jaén ",
            "La Coruña",
            "La Rioja",
            "Las Palmas",
            "León",
            "Lérida",
            "Lugo",
            "Madrid",
            "Málaga",
            "Melilla",
            "Murcia",
            "Navarra",
            "Orense",
            "Palencia",
            "Pontevedra",
            "S.C. De Tenerife",
            "Salamanca",
            "Segovia",
            "Sevilla",
            "Soria",
            "Tarragona",
            "Teruel",
            "Toledo",
            "Valencia",
            "Valladolid",
            "Vizcaya",
            "Zamora",
            "Zaragoza"});
            this.comboBoxProvCli.Location = new System.Drawing.Point(34, 168);
            this.comboBoxProvCli.Name = "comboBoxProvCli";
            this.comboBoxProvCli.Size = new System.Drawing.Size(181, 21);
            this.comboBoxProvCli.TabIndex = 81;
            // 
            // dateTimePickerCli
            // 
            this.dateTimePickerCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCli.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCli.Location = new System.Drawing.Point(134, 113);
            this.dateTimePickerCli.Name = "dateTimePickerCli";
            this.dateTimePickerCli.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerCli.TabIndex = 80;
            // 
            // groupContactoCliente
            // 
            this.groupContactoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupContactoCliente.Controls.Add(this.telefonoCli);
            this.groupContactoCliente.Controls.Add(this.MovilCli);
            this.groupContactoCliente.Controls.Add(this.emailCli);
            this.groupContactoCliente.Controls.Add(this.textBoxTelfCli);
            this.groupContactoCliente.Controls.Add(this.textBoxMovilCli);
            this.groupContactoCliente.Controls.Add(this.textBoxEmailCli);
            this.groupContactoCliente.Location = new System.Drawing.Point(35, 284);
            this.groupContactoCliente.Name = "groupContactoCliente";
            this.groupContactoCliente.Size = new System.Drawing.Size(258, 126);
            this.groupContactoCliente.TabIndex = 79;
            this.groupContactoCliente.TabStop = false;
            this.groupContactoCliente.Text = "Contacto";
            // 
            // telefonoCli
            // 
            this.telefonoCli.AutoSize = true;
            this.telefonoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoCli.Location = new System.Drawing.Point(17, 21);
            this.telefonoCli.Name = "telefonoCli";
            this.telefonoCli.Size = new System.Drawing.Size(49, 13);
            this.telefonoCli.TabIndex = 11;
            this.telefonoCli.Text = "Teléfono";
            // 
            // MovilCli
            // 
            this.MovilCli.AutoSize = true;
            this.MovilCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovilCli.Location = new System.Drawing.Point(124, 22);
            this.MovilCli.Name = "MovilCli";
            this.MovilCli.Size = new System.Drawing.Size(32, 13);
            this.MovilCli.TabIndex = 10;
            this.MovilCli.Text = "Móvil";
            // 
            // emailCli
            // 
            this.emailCli.AutoSize = true;
            this.emailCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCli.Location = new System.Drawing.Point(17, 70);
            this.emailCli.Name = "emailCli";
            this.emailCli.Size = new System.Drawing.Size(94, 13);
            this.emailCli.TabIndex = 12;
            this.emailCli.Text = "Correo Eléctronico";
            this.emailCli.Click += new System.EventHandler(this.Admin_Perfil_Label_Mail_Click);
            // 
            // textBoxTelfCli
            // 
            this.textBoxTelfCli.Location = new System.Drawing.Point(20, 37);
            this.textBoxTelfCli.Name = "textBoxTelfCli";
            this.textBoxTelfCli.Size = new System.Drawing.Size(86, 20);
            this.textBoxTelfCli.TabIndex = 19;
            // 
            // textBoxMovilCli
            // 
            this.textBoxMovilCli.Location = new System.Drawing.Point(127, 37);
            this.textBoxMovilCli.Name = "textBoxMovilCli";
            this.textBoxMovilCli.Size = new System.Drawing.Size(111, 20);
            this.textBoxMovilCli.TabIndex = 20;
            // 
            // textBoxEmailCli
            // 
            this.textBoxEmailCli.Location = new System.Drawing.Point(20, 87);
            this.textBoxEmailCli.Name = "textBoxEmailCli";
            this.textBoxEmailCli.Size = new System.Drawing.Size(218, 20);
            this.textBoxEmailCli.TabIndex = 25;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.rButom_H_Cliente);
            this.groupBoxSexo.Controls.Add(this.rButom_M_Cliente);
            this.groupBoxSexo.Location = new System.Drawing.Point(303, 284);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(207, 83);
            this.groupBoxSexo.TabIndex = 76;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // rButom_H_Cliente
            // 
            this.rButom_H_Cliente.AutoSize = true;
            this.rButom_H_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButom_H_Cliente.Location = new System.Drawing.Point(11, 19);
            this.rButom_H_Cliente.Name = "rButom_H_Cliente";
            this.rButom_H_Cliente.Size = new System.Drawing.Size(62, 17);
            this.rButom_H_Cliente.TabIndex = 30;
            this.rButom_H_Cliente.TabStop = true;
            this.rButom_H_Cliente.Text = "Hombre";
            this.rButom_H_Cliente.UseVisualStyleBackColor = true;
            // 
            // rButom_M_Cliente
            // 
            this.rButom_M_Cliente.AutoSize = true;
            this.rButom_M_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButom_M_Cliente.Location = new System.Drawing.Point(11, 45);
            this.rButom_M_Cliente.Name = "rButom_M_Cliente";
            this.rButom_M_Cliente.Size = new System.Drawing.Size(51, 17);
            this.rButom_M_Cliente.TabIndex = 31;
            this.rButom_M_Cliente.TabStop = true;
            this.rButom_M_Cliente.Text = "Mujer";
            this.rButom_M_Cliente.UseVisualStyleBackColor = true;
            // 
            // comboBoxDomiciCli
            // 
            this.comboBoxDomiciCli.FormattingEnabled = true;
            this.comboBoxDomiciCli.Items.AddRange(new object[] {
            "",
            "Calle",
            "Avenida",
            "Vía"});
            this.comboBoxDomiciCli.Location = new System.Drawing.Point(34, 226);
            this.comboBoxDomiciCli.Name = "comboBoxDomiciCli";
            this.comboBoxDomiciCli.Size = new System.Drawing.Size(67, 21);
            this.comboBoxDomiciCli.TabIndex = 70;
            // 
            // textBoxDomiciCli
            // 
            this.textBoxDomiciCli.Location = new System.Drawing.Point(107, 228);
            this.textBoxDomiciCli.Name = "textBoxDomiciCli";
            this.textBoxDomiciCli.Size = new System.Drawing.Size(403, 20);
            this.textBoxDomiciCli.TabIndex = 69;
            // 
            // labelDomiciCli
            // 
            this.labelDomiciCli.AutoSize = true;
            this.labelDomiciCli.Location = new System.Drawing.Point(30, 210);
            this.labelDomiciCli.Name = "labelDomiciCli";
            this.labelDomiciCli.Size = new System.Drawing.Size(49, 13);
            this.labelDomiciCli.TabIndex = 68;
            this.labelDomiciCli.Text = "Domicilio";
            // 
            // textBoxLocaliCli
            // 
            this.textBoxLocaliCli.Location = new System.Drawing.Point(303, 170);
            this.textBoxLocaliCli.Name = "textBoxLocaliCli";
            this.textBoxLocaliCli.Size = new System.Drawing.Size(207, 20);
            this.textBoxLocaliCli.TabIndex = 67;
            // 
            // labelLocaliCli
            // 
            this.labelLocaliCli.AutoSize = true;
            this.labelLocaliCli.Location = new System.Drawing.Point(300, 154);
            this.labelLocaliCli.Name = "labelLocaliCli";
            this.labelLocaliCli.Size = new System.Drawing.Size(53, 13);
            this.labelLocaliCli.TabIndex = 66;
            this.labelLocaliCli.Text = "Localidad";
            // 
            // labelCPCli
            // 
            this.labelCPCli.AutoSize = true;
            this.labelCPCli.Location = new System.Drawing.Point(239, 154);
            this.labelCPCli.Name = "labelCPCli";
            this.labelCPCli.Size = new System.Drawing.Size(21, 13);
            this.labelCPCli.TabIndex = 65;
            this.labelCPCli.Text = "CP";
            // 
            // textBoxCPCli
            // 
            this.textBoxCPCli.Location = new System.Drawing.Point(242, 170);
            this.textBoxCPCli.Name = "textBoxCPCli";
            this.textBoxCPCli.Size = new System.Drawing.Size(51, 20);
            this.textBoxCPCli.TabIndex = 64;
            // 
            // labelClienteProv
            // 
            this.labelClienteProv.AutoSize = true;
            this.labelClienteProv.Location = new System.Drawing.Point(30, 154);
            this.labelClienteProv.Name = "labelClienteProv";
            this.labelClienteProv.Size = new System.Drawing.Size(51, 13);
            this.labelClienteProv.TabIndex = 63;
            this.labelClienteProv.Text = "Provincia";
            // 
            // comboBoxPaisCli
            // 
            this.comboBoxPaisCli.FormattingEnabled = true;
            this.comboBoxPaisCli.Items.AddRange(new object[] {
            "",
            "Afganistan",
            "Africa del Sur",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Antillas Holandesas",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarusia",
            "Belgica",
            "Belice",
            "Benin",
            "Bermudas",
            "Bolivia",
            "Bosnia",
            "Botswana",
            "Brasil",
            "Brunei Darussulam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Butan",
            "Camboya",
            "Camerun",
            "Canada",
            "Cape Verde",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Colombia",
            "Comoros",
            "Congo",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfíl",
            "Costa Rica",
            "Croasia",
            "Cuba",
            "Dinamarca",
            "Djibouti",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Arabes Unidos",
            "Eritrea",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopia",
            "Fiji",
            "Filipinas",
            "Finlandia",
            "Francia",
            "Gabon",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Groenlandia",
            "Guadalupe",
            "Guam",
            "Guatemala",
            "Guayana Francesa",
            "Guerney",
            "Guinea",
            "Guinea-Bissau",
            "Guinea Equatorial",
            "Guyana",
            "Haiti",
            "Holanda",
            "Honduras",
            "Hong Kong",
            "Hungria",
            "India",
            "Indonesia",
            "Irak",
            "Iran",
            "Irlanda",
            "Islandia",
            "Islas Caiman",
            "Islas Faroe",
            "Islas Malvinas",
            "Islas Marshall",
            "Islas Solomon",
            "Islas Virgenes (U.S.)",
            "Israel",
            "Italia",
            "Jamaica",
            "Japon",
            "Jersey",
            "Jordania",
            "Kazakhstan",
            "Kenia",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lesotho",
            "Libano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macao",
            "Macedionia",
            "Madagascar",
            "Malasia",
            "Malawi",
            "Maldivas",
            "Mali",
            "Malta",
            "Marruecos",
            "Martinica",
            "Mauricio",
            "Mauritania",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nepal",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Noruega",
            "Nueva Caledonia",
            "Nueva Zealandia",
            "Oman",
            "Pakistan",
            "Palestina",
            "Panama",
            "Papua Nueva Guinea",
            "Paraguay",
            "Peru",
            "Polinesia Francesa",
            "Polonia",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reino Unido",
            "Republica Centroafricana",
            "Republica Checa",
            "Republica Democratica del Congo",
            "Republica Dominicana",
            "Republica Eslovaca",
            "Reunion",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Sahara",
            "Samoa",
            "San Cristobal-Nevis (St. Kitts)",
            "San Marino",
            "San Vincente y las Granadinas",
            "Santa Lucia",
            "Santa Sede (Vaticano)",
            "Sao Tome & Principe",
            "Senegal",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka (Ceilan)",
            "Sudan",
            "Suecia",
            "Suiza",
            "Sur Africa",
            "Surinam",
            "Swaziland",
            "Tailandia",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkmenistan",
            "Turquia",
            "Ucrania",
            "Uganda",
            "Union Europea",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yugoslavia",
            "Zambia",
            "Zimbabwe"});
            this.comboBoxPaisCli.Location = new System.Drawing.Point(303, 113);
            this.comboBoxPaisCli.Name = "comboBoxPaisCli";
            this.comboBoxPaisCli.Size = new System.Drawing.Size(207, 21);
            this.comboBoxPaisCli.TabIndex = 62;
            // 
            // labelPaisCli
            // 
            this.labelPaisCli.AutoSize = true;
            this.labelPaisCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaisCli.Location = new System.Drawing.Point(300, 97);
            this.labelPaisCli.Name = "labelPaisCli";
            this.labelPaisCli.Size = new System.Drawing.Size(29, 13);
            this.labelPaisCli.TabIndex = 61;
            this.labelPaisCli.Text = "País";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // textBoxApellidosC
            // 
            this.textBoxApellidosC.Location = new System.Drawing.Point(303, 54);
            this.textBoxApellidosC.Name = "textBoxApellidosC";
            this.textBoxApellidosC.Size = new System.Drawing.Size(207, 20);
            this.textBoxApellidosC.TabIndex = 4;
            // 
            // labelApellidosCliente
            // 
            this.labelApellidosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidosCliente.Location = new System.Drawing.Point(300, 38);
            this.labelApellidosCliente.Name = "labelApellidosCliente";
            this.labelApellidosCliente.Size = new System.Drawing.Size(53, 13);
            this.labelApellidosCliente.TabIndex = 2;
            this.labelApellidosCliente.Text = "Apellidos";
            this.labelApellidosCliente.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Location = new System.Drawing.Point(32, 38);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.labelNombreCliente.TabIndex = 0;
            this.labelNombreCliente.Text = "Nombre";
            this.labelNombreCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNifCliente
            // 
            this.labelNifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNifCliente.Location = new System.Drawing.Point(32, 97);
            this.labelNifCliente.Name = "labelNifCliente";
            this.labelNifCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNifCliente.TabIndex = 2;
            this.labelNifCliente.Text = "NIF";
            // 
            // textBoxNombreC
            // 
            this.textBoxNombreC.Location = new System.Drawing.Point(34, 54);
            this.textBoxNombreC.Name = "textBoxNombreC";
            this.textBoxNombreC.Size = new System.Drawing.Size(255, 20);
            this.textBoxNombreC.TabIndex = 1;
            this.textBoxNombreC.TextChanged += new System.EventHandler(this.textBoxNombreC_TextChanged);
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.AccessibleDescription = "Buscar Cliente";
            this.BuscarCliente.Controls.Add(this.Resultado_busqueda_cliente);
            this.BuscarCliente.Controls.Add(this.groupBoxBusquedaCliente);
            this.BuscarCliente.Location = new System.Drawing.Point(4, 22);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.BuscarCliente.Size = new System.Drawing.Size(893, 607);
            this.BuscarCliente.TabIndex = 1;
            this.BuscarCliente.Text = "Busqueda";
            this.BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // Resultado_busqueda_cliente
            // 
            this.Resultado_busqueda_cliente.AllowUserToAddRows = false;
            this.Resultado_busqueda_cliente.AllowUserToDeleteRows = false;
            this.Resultado_busqueda_cliente.AllowUserToOrderColumns = true;
            this.Resultado_busqueda_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultado_busqueda_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Resultado_busqueda_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Resultado_busqueda_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resultado_busqueda_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIF,
            this.Usuario,
            this.Nombre,
            this.Apellidos,
            this.Localidad,
            this.Provincia,
            this.Editar,
            this.Borrar});
            this.Resultado_busqueda_cliente.Location = new System.Drawing.Point(20, 140);
            this.Resultado_busqueda_cliente.Name = "Resultado_busqueda_cliente";
            this.Resultado_busqueda_cliente.ReadOnly = true;
            this.Resultado_busqueda_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Resultado_busqueda_cliente.Size = new System.Drawing.Size(849, 449);
            this.Resultado_busqueda_cliente.TabIndex = 3;
            this.Resultado_busqueda_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.Resultado_busqueda_cliente.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Resultado_busqueda_clienteCellMouseClick);
            // 
            // NIF
            // 
            this.NIF.FillWeight = 71.2275F;
            this.NIF.HeaderText = "NIF";
            this.NIF.Name = "NIF";
            this.NIF.ReadOnly = true;
            this.NIF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Usuario
            // 
            this.Usuario.FillWeight = 71.2275F;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 90.2275F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.FillWeight = 150.0456F;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.FillWeight = 80.2275F;
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.FillWeight = 71.2275F;
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 50.58931F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Events4ALL.Properties.Resources.edit;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Borrar
            // 
            this.Borrar.FillWeight = 50.2275F;
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::Events4ALL.Properties.Resources.delete;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            // 
            // groupBoxBusquedaCliente
            // 
            this.groupBoxBusquedaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBusquedaCliente.Controls.Add(this.textBox_filtro_busqueda);
            this.groupBoxBusquedaCliente.Controls.Add(this.comboBox_filtro_busqueda);
            this.groupBoxBusquedaCliente.Controls.Add(this.label_filtro_busqueda);
            this.groupBoxBusquedaCliente.Controls.Add(this.buttonBuscarCliente);
            this.groupBoxBusquedaCliente.Location = new System.Drawing.Point(20, 19);
            this.groupBoxBusquedaCliente.Name = "groupBoxBusquedaCliente";
            this.groupBoxBusquedaCliente.Size = new System.Drawing.Size(849, 80);
            this.groupBoxBusquedaCliente.TabIndex = 2;
            this.groupBoxBusquedaCliente.TabStop = false;
            this.groupBoxBusquedaCliente.Text = "Búsqueda";
            // 
            // textBox_filtro_busqueda
            // 
            this.textBox_filtro_busqueda.Location = new System.Drawing.Point(254, 32);
            this.textBox_filtro_busqueda.Name = "textBox_filtro_busqueda";
            this.textBox_filtro_busqueda.Size = new System.Drawing.Size(139, 20);
            this.textBox_filtro_busqueda.TabIndex = 67;
            // 
            // comboBox_filtro_busqueda
            // 
            this.comboBox_filtro_busqueda.FormattingEnabled = true;
            this.comboBox_filtro_busqueda.Items.AddRange(new object[] {
            "Mostrar Todos",
            "NIF",
            "Nombre",
            "Apellido",
            "Usuario",
            "Pais",
            "Provincia",
            "Localidad",
            "Sexo"});
            this.comboBox_filtro_busqueda.Location = new System.Drawing.Point(82, 32);
            this.comboBox_filtro_busqueda.Name = "comboBox_filtro_busqueda";
            this.comboBox_filtro_busqueda.Size = new System.Drawing.Size(127, 21);
            this.comboBox_filtro_busqueda.TabIndex = 66;
            // 
            // label_filtro_busqueda
            // 
            this.label_filtro_busqueda.AutoSize = true;
            this.label_filtro_busqueda.Location = new System.Drawing.Point(23, 35);
            this.label_filtro_busqueda.Name = "label_filtro_busqueda";
            this.label_filtro_busqueda.Size = new System.Drawing.Size(53, 13);
            this.label_filtro_busqueda.TabIndex = 65;
            this.label_filtro_busqueda.Text = "Filtrar por:";
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarCliente.Image = global::Events4ALL.Properties.Resources.search_icon;
            this.buttonBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarCliente.Location = new System.Drawing.Point(749, 51);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(94, 23);
            this.buttonBuscarCliente.TabIndex = 64;
            this.buttonBuscarCliente.Text = "Buscar";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonNuevoCliente
            // 
            this.buttonNuevoCliente.Image = global::Events4ALL.Properties.Resources.mas;
            this.buttonNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevoCliente.Location = new System.Drawing.Point(628, 555);
            this.buttonNuevoCliente.Name = "buttonNuevoCliente";
            this.buttonNuevoCliente.Size = new System.Drawing.Size(70, 23);
            this.buttonNuevoCliente.TabIndex = 13;
            this.buttonNuevoCliente.Text = "Nuevo";
            this.buttonNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNuevoCliente.UseVisualStyleBackColor = true;
            this.buttonNuevoCliente.Click += new System.EventHandler(this.buttonNuevoCliente_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.formCliente);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(907, 635);
            this.formCliente.ResumeLayout(false);
            this.FichaCliente.ResumeLayout(false);
            this.FichaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_Perfil_Foto)).EndInit();
            this.comboBoxProvinciaCli.ResumeLayout(false);
            this.comboBoxProvinciaCli.PerformLayout();
            this.groupContactoCliente.ResumeLayout(false);
            this.groupContactoCliente.PerformLayout();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.BuscarCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resultado_busqueda_cliente)).EndInit();
            this.groupBoxBusquedaCliente.ResumeLayout(false);
            this.groupBoxBusquedaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl formCliente;
        private System.Windows.Forms.TabPage FichaCliente;
        private System.Windows.Forms.TabPage BuscarCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Label labelNifCliente;
        private System.Windows.Forms.GroupBox comboBoxProvinciaCli;
        private System.Windows.Forms.PictureBox cliente_Perfil_Foto;
        private System.Windows.Forms.Label labelApellidosCliente;
        private System.Windows.Forms.TextBox textBoxApellidosC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPaisCli;
        private System.Windows.Forms.ComboBox comboBoxPaisCli;
        private System.Windows.Forms.Label labelClienteProv;
        private System.Windows.Forms.TextBox textBoxCPCli;
        private System.Windows.Forms.Label labelLocaliCli;
        private System.Windows.Forms.TextBox textBoxLocaliCli;
        private System.Windows.Forms.ComboBox comboBoxDomiciCli;
        private System.Windows.Forms.TextBox textBoxDomiciCli;
        private System.Windows.Forms.Label labelDomiciCli;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton rButom_H_Cliente;
        private System.Windows.Forms.RadioButton rButom_M_Cliente;
        private System.Windows.Forms.GroupBox groupContactoCliente;
        private System.Windows.Forms.Label telefonoCli;
        private System.Windows.Forms.Label MovilCli;
        private System.Windows.Forms.Label emailCli;
        private System.Windows.Forms.TextBox textBoxTelfCli;
        private System.Windows.Forms.TextBox textBoxMovilCli;
        private System.Windows.Forms.TextBox textBoxEmailCli;
        private System.Windows.Forms.Button buttonFotoCliente;
        private System.Windows.Forms.Button buttonLimpiarCliente;
        private System.Windows.Forms.Button buttonGuardarCliente;
        private System.Windows.Forms.GroupBox groupBoxBusquedaCliente;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.DataGridView Resultado_busqueda_cliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerCli;
        private System.Windows.Forms.Label labelCPCli;
        public System.Windows.Forms.TextBox textBoxNombreC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBoxProvCli;
        private System.Windows.Forms.TextBox textBoxNifC;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label_filtro_busqueda;
        private System.Windows.Forms.ComboBox comboBox_filtro_busqueda;
        private System.Windows.Forms.TextBox textBox_filtro_busqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.Button buttonNuevoCliente;
    }
}
