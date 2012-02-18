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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
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
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.logoutButton.Controls.Add(this.label2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Events4ALL.Properties.Resources.update;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Name = "panel2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Name = "label4";
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
            this.Controls.Add(this.panel2);
            this.Name = "FormBase";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.exitButton.ResumeLayout(false);
            this.exitButton.PerformLayout();
            this.logoutButton.ResumeLayout(false);
            this.logoutButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

