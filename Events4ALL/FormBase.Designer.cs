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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.apellidosLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clockLabel = new System.Windows.Forms.Label();
            this.messagePicture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.admins1 = new Events4ALL.Admins();
            this.clientes1 = new Events4ALL.Clientes();
            this.estadisticas1 = new Events4ALL.Estadisticas();
            this.inicio1 = new Events4ALL.Inicio();
            this.promociones1 = new Events4ALL.Promociones();
            this.salas1 = new Events4ALL.Salas();
            this.mensajes1 = new Events4ALL.User_Controls.Mensajes();
            this.ventas1 = new Events4ALL.Ventas();
            this.espectaculos1 = new Events4ALL.Espectaculos();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.TabStop = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "admins.png");
            this.imageList1.Images.SetKeyName(2, "clientes.png");
            this.imageList1.Images.SetKeyName(3, "salas.png");
            this.imageList1.Images.SetKeyName(4, "espectaculos.png");
            this.imageList1.Images.SetKeyName(5, "promociones.png");
            this.imageList1.Images.SetKeyName(6, "estadisticas.png");
            this.imageList1.Images.SetKeyName(7, "ventas.png");
            this.imageList1.Images.SetKeyName(8, "mensajes.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BackgroundImage = global::Events4ALL.Properties.Resources.log_bg;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.idLabel);
            this.panel4.Controls.Add(this.apellidosLabel);
            this.panel4.Controls.Add(this.nombreLabel);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Name = "panel4";
            // 
            // button2
            // 
            this.button2.Image = global::Events4ALL.Properties.Resources.quit_icon;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Events4ALL.Properties.Resources.logout_img;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // idLabel
            // 
            resources.ApplyResources(this.idLabel, "idLabel");
            this.idLabel.Name = "idLabel";
            // 
            // apellidosLabel
            // 
            resources.ApplyResources(this.apellidosLabel, "apellidosLabel");
            this.apellidosLabel.Name = "apellidosLabel";
            // 
            // nombreLabel
            // 
            resources.ApplyResources(this.nombreLabel, "nombreLabel");
            this.nombreLabel.Name = "nombreLabel";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::Events4ALL.Properties.Resources.foto_usuario_defectojpg;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Events4ALL.Properties.Resources.bg;
            this.panel2.Controls.Add(this.clockLabel);
            this.panel2.Controls.Add(this.messagePicture);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Name = "panel2";
            // 
            // clockLabel
            // 
            resources.ApplyResources(this.clockLabel, "clockLabel");
            this.clockLabel.ForeColor = System.Drawing.Color.Silver;
            this.clockLabel.Name = "clockLabel";
            // 
            // messagePicture
            // 
            resources.ApplyResources(this.messagePicture, "messagePicture");
            this.messagePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messagePicture.Image = global::Events4ALL.Properties.Resources.mensajes;
            this.messagePicture.Name = "messagePicture";
            this.messagePicture.TabStop = false;
            this.messagePicture.Click += new System.EventHandler(this.messagePicture_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Name = "label5";
            // 
            // updateButton
            // 
            resources.ApplyResources(this.updateButton, "updateButton");
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Image = global::Events4ALL.Properties.Resources.update;
            this.updateButton.Name = "updateButton";
            this.updateButton.TabStop = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Events4ALL.Properties.Resources.logo;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // admins1
            // 
            resources.ApplyResources(this.admins1, "admins1");
            this.admins1.Name = "admins1";
            // 
            // clientes1
            // 
            resources.ApplyResources(this.clientes1, "clientes1");
            this.clientes1.Name = "clientes1";
            // 
            // estadisticas1
            // 
            resources.ApplyResources(this.estadisticas1, "estadisticas1");
            this.estadisticas1.Name = "estadisticas1";
            // 
            // inicio1
            // 
            resources.ApplyResources(this.inicio1, "inicio1");
            this.inicio1.Name = "inicio1";
            // 
            // promociones1
            // 
            resources.ApplyResources(this.promociones1, "promociones1");
            this.promociones1.Name = "promociones1";
            // 
            // salas1
            // 
            resources.ApplyResources(this.salas1, "salas1");
            this.salas1.Name = "salas1";
            // 
            // mensajes1
            // 
            resources.ApplyResources(this.mensajes1, "mensajes1");
            this.mensajes1.Name = "mensajes1";
            // 
            // ventas1
            // 
            resources.ApplyResources(this.ventas1, "ventas1");
            this.ventas1.Name = "ventas1";
            // 
            // espectaculos1
            // 
            resources.ApplyResources(this.espectaculos1, "espectaculos1");
            this.espectaculos1.Name = "espectaculos1";
            // 
            // FormBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.espectaculos1);
            this.Controls.Add(this.ventas1);
            this.Controls.Add(this.mensajes1);
            this.Controls.Add(this.salas1);
            this.Controls.Add(this.promociones1);
            this.Controls.Add(this.inicio1);
            this.Controls.Add(this.estadisticas1);
            this.Controls.Add(this.clientes1);
            this.Controls.Add(this.admins1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Name = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox updateButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox messagePicture;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label apellidosLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Admins admins1;
        private Clientes clientes1;
        private Estadisticas estadisticas1;
        private Inicio inicio1;
        private Promociones promociones1;
        private Salas salas1;
        private User_Controls.Mensajes mensajes1;
        private Ventas ventas1;
        private Espectaculos espectaculos1;
    }
}

