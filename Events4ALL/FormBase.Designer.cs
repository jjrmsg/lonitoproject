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
            this.salas1 = new Events4ALL.Salas();
            this.promociones1 = new Events4ALL.Promociones();
            this.logs1 = new Events4ALL.Logs();
            this.inicio1 = new Events4ALL.Inicio();
            this.estadisticas1 = new Events4ALL.Estadisticas();
            this.espectaculos1 = new Events4ALL.Espectaculos();
            this.clientes1 = new Events4ALL.Clientes();
            this.admins1 = new Events4ALL.Admins();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(12, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 285);
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
            // salas1
            // 
            this.salas1.Location = new System.Drawing.Point(246, 34);
            this.salas1.Name = "salas1";
            this.salas1.Size = new System.Drawing.Size(794, 519);
            this.salas1.TabIndex = 9;
            // 
            // promociones1
            // 
            this.promociones1.Location = new System.Drawing.Point(246, 34);
            this.promociones1.Name = "promociones1";
            this.promociones1.Size = new System.Drawing.Size(794, 519);
            this.promociones1.TabIndex = 8;
            // 
            // logs1
            // 
            this.logs1.Location = new System.Drawing.Point(246, 34);
            this.logs1.Name = "logs1";
            this.logs1.Size = new System.Drawing.Size(794, 519);
            this.logs1.TabIndex = 7;
            // 
            // inicio1
            // 
            this.inicio1.Location = new System.Drawing.Point(246, 34);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(794, 519);
            this.inicio1.TabIndex = 6;
            // 
            // estadisticas1
            // 
            this.estadisticas1.Location = new System.Drawing.Point(246, 34);
            this.estadisticas1.Name = "estadisticas1";
            this.estadisticas1.Size = new System.Drawing.Size(794, 519);
            this.estadisticas1.TabIndex = 5;
            // 
            // espectaculos1
            // 
            this.espectaculos1.Location = new System.Drawing.Point(246, 34);
            this.espectaculos1.Name = "espectaculos1";
            this.espectaculos1.Size = new System.Drawing.Size(794, 519);
            this.espectaculos1.TabIndex = 4;
            // 
            // clientes1
            // 
            this.clientes1.Location = new System.Drawing.Point(246, 34);
            this.clientes1.Name = "clientes1";
            this.clientes1.Size = new System.Drawing.Size(794, 519);
            this.clientes1.TabIndex = 3;
            // 
            // admins1
            // 
            this.admins1.Location = new System.Drawing.Point(246, 34);
            this.admins1.Name = "admins1";
            this.admins1.Size = new System.Drawing.Size(794, 519);
            this.admins1.TabIndex = 2;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 565);
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
    }
}

