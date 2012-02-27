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
            this.exitButton = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clockLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.messagePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mensajes1 = new Events4ALL.User_Controls.Mensajes();
            this.ventas1 = new Events4ALL.Ventas();
            this.salas1 = new Events4ALL.Salas();
            this.promociones1 = new Events4ALL.Promociones();
            this.logs1 = new Events4ALL.Logs();
            this.inicio1 = new Events4ALL.Inicio();
            this.estadisticas1 = new Events4ALL.Estadisticas();
            this.espectaculos1 = new Events4ALL.Espectaculos();
            this.clientes1 = new Events4ALL.Clientes();
            this.admins1 = new Events4ALL.Admins();
            this.exitButton.SuspendLayout();
            this.logoutButton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "credit_card.png");
            this.imageList1.Images.SetKeyName(2, "friends_group.png");
            this.imageList1.Images.SetKeyName(3, "stop.png");
            this.imageList1.Images.SetKeyName(4, "star.png");
            this.imageList1.Images.SetKeyName(5, "tag_orange.png");
            this.imageList1.Images.SetKeyName(6, "pie-chart_graph.png");
            this.imageList1.Images.SetKeyName(7, "shopping_cart.png");
            this.imageList1.Images.SetKeyName(8, "copy.png");
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exitButton.Controls.Add(this.pictureBox4);
            this.exitButton.Controls.Add(this.label3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // logoutButton
            // 
            resources.ApplyResources(this.logoutButton, "logoutButton");
            this.logoutButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logoutButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoutButton.Controls.Add(this.pictureBox3);
            this.logoutButton.Controls.Add(this.label2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.clockLabel);
            this.panel2.Controls.Add(this.messagePicture);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Name = "panel2";
            // 
            // clockLabel
            // 
            resources.ApplyResources(this.clockLabel, "clockLabel");
            this.clockLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.clockLabel.Name = "clockLabel";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.OliveDrab;
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Name = "label5";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.logoutButton);
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Name = "panel3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Events4ALL.Properties.Resources.logo;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // messagePicture
            // 
            resources.ApplyResources(this.messagePicture, "messagePicture");
            this.messagePicture.Image = global::Events4ALL.Properties.Resources.carta;
            this.messagePicture.Name = "messagePicture";
            this.messagePicture.TabStop = false;
            this.messagePicture.Click += new System.EventHandler(this.messagePicture_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Events4ALL.Properties.Resources.update;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Events4ALL.Properties.Resources.bloqueo;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Events4ALL.Properties.Resources.arrow_right;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox5);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::Events4ALL.Properties.Resources.foto_usuario_defectojpg;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
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
            // salas1
            // 
            resources.ApplyResources(this.salas1, "salas1");
            this.salas1.Name = "salas1";
            // 
            // promociones1
            // 
            resources.ApplyResources(this.promociones1, "promociones1");
            this.promociones1.Name = "promociones1";
            // 
            // logs1
            // 
            resources.ApplyResources(this.logs1, "logs1");
            this.logs1.Name = "logs1";
            // 
            // inicio1
            // 
            resources.ApplyResources(this.inicio1, "inicio1");
            this.inicio1.Name = "inicio1";
            // 
            // estadisticas1
            // 
            resources.ApplyResources(this.estadisticas1, "estadisticas1");
            this.estadisticas1.Name = "estadisticas1";
            // 
            // espectaculos1
            // 
            resources.ApplyResources(this.espectaculos1, "espectaculos1");
            this.espectaculos1.Name = "espectaculos1";
            // 
            // clientes1
            // 
            resources.ApplyResources(this.clientes1, "clientes1");
            this.clientes1.Name = "clientes1";
            // 
            // admins1
            // 
            resources.ApplyResources(this.admins1, "admins1");
            this.admins1.Name = "admins1";
            // 
            // FormBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.mensajes1);
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.exitButton.ResumeLayout(false);
            this.exitButton.PerformLayout();
            this.logoutButton.ResumeLayout(false);
            this.logoutButton.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.Panel exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel logoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox messagePicture;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer timer1;
        private User_Controls.Mensajes mensajes1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

