namespace Events4ALL
{
    partial class FormBase
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ventas1 = new Events4ALL.Ventas();
            this.salas1 = new Events4ALL.Salas();
            this.promociones1 = new Events4ALL.Promociones();
            this.logs1 = new Events4ALL.Logs();
            this.inicio1 = new Events4ALL.Inicio();
            this.estadisticas1 = new Events4ALL.Estadisticas();
            this.espectaculos1 = new Events4ALL.Espectaculos();
            this.clientes1 = new Events4ALL.Clientes();
            this.admins1 = new Events4ALL.Admins();
            this.panel1.SuspendLayout();
            this.exitButton.SuspendLayout();
            this.logoutButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(15, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 491);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ok.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(15, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 33);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exitButton.Controls.Add(this.label3);
            this.exitButton.Location = new System.Drawing.Point(15, 624);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(179, 37);
            this.exitButton.TabIndex = 12;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salir";
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logoutButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoutButton.Controls.Add(this.label2);
            this.logoutButton.Location = new System.Drawing.Point(15, 583);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(179, 35);
            this.logoutButton.TabIndex = 13;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Logout";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ventas1
            // 
            this.ventas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ventas1.Location = new System.Drawing.Point(200, 34);
            this.ventas1.Name = "ventas1";
            this.ventas1.Size = new System.Drawing.Size(907, 635);
            this.ventas1.TabIndex = 10;
            // 
            // salas1
            // 
            this.salas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.salas1.Location = new System.Drawing.Point(201, 34);
            this.salas1.Name = "salas1";
            this.salas1.Size = new System.Drawing.Size(906, 635);
            this.salas1.TabIndex = 9;
            // 
            // promociones1
            // 
            this.promociones1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.promociones1.Location = new System.Drawing.Point(201, 34);
            this.promociones1.Name = "promociones1";
            this.promociones1.Size = new System.Drawing.Size(906, 635);
            this.promociones1.TabIndex = 8;
            // 
            // logs1
            // 
            this.logs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logs1.Location = new System.Drawing.Point(201, 34);
            this.logs1.Name = "logs1";
            this.logs1.Size = new System.Drawing.Size(906, 635);
            this.logs1.TabIndex = 7;
            // 
            // inicio1
            // 
            this.inicio1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.inicio1.Location = new System.Drawing.Point(201, 34);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(906, 635);
            this.inicio1.TabIndex = 6;
            // 
            // estadisticas1
            // 
            this.estadisticas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.estadisticas1.Location = new System.Drawing.Point(201, 34);
            this.estadisticas1.Name = "estadisticas1";
            this.estadisticas1.Size = new System.Drawing.Size(906, 635);
            this.estadisticas1.TabIndex = 5;
            // 
            // espectaculos1
            // 
            this.espectaculos1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.espectaculos1.Location = new System.Drawing.Point(201, 34);
            this.espectaculos1.Name = "espectaculos1";
            this.espectaculos1.Size = new System.Drawing.Size(906, 635);
            this.espectaculos1.TabIndex = 4;
            // 
            // clientes1
            // 
            this.clientes1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.clientes1.Location = new System.Drawing.Point(201, 34);
            this.clientes1.Name = "clientes1";
            this.clientes1.Size = new System.Drawing.Size(906, 635);
            this.clientes1.TabIndex = 3;
            // 
            // admins1
            // 
            this.admins1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.admins1.Location = new System.Drawing.Point(201, 34);
            this.admins1.Name = "admins1";
            this.admins1.Size = new System.Drawing.Size(906, 635);
            this.admins1.TabIndex = 2;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ventas1);
            this.Controls.Add(this.salas1);
            this.Controls.Add(this.promociones1);
            this.Controls.Add(this.logs1);
            this.Controls.Add(this.inicio1);
            this.Controls.Add(this.estadisticas1);
            this.Controls.Add(this.espectaculos1);
            this.Controls.Add(this.clientes1);
            this.Controls.Add(this.admins1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormBase";
            this.Text = "Events4ALL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.exitButton.ResumeLayout(false);
            this.exitButton.PerformLayout();
            this.logoutButton.ResumeLayout(false);
            this.logoutButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ImageList imageList1;
        private Admins admins1;
        private Clientes clientes1;
        private Espectaculos espectaculos1;
        private Estadisticas estadisticas1;
        private Inicio inicio1;
        private Logs logs1;
        private Promociones promociones1;
        private Salas salas1;
        private Ventas ventas1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel logoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

