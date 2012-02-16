namespace Events4ALL
{
    partial class Salas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAñadirSala = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBusquedaSala = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabAñadirSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabAñadirSala);
            this.tabControl1.Controls.Add(this.tabBusquedaSala);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 516);
            this.tabControl1.TabIndex = 1;
            // 
            // tabAñadirSala
            // 
            this.tabAñadirSala.Controls.Add(this.label1);
            this.tabAñadirSala.Location = new System.Drawing.Point(4, 22);
            this.tabAñadirSala.Name = "tabAñadirSala";
            this.tabAñadirSala.Padding = new System.Windows.Forms.Padding(3);
            this.tabAñadirSala.Size = new System.Drawing.Size(780, 490);
            this.tabAñadirSala.TabIndex = 0;
            this.tabAñadirSala.Text = "Añadir";
            this.tabAñadirSala.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salas";
            // 
            // tabBusquedaSala
            // 
            this.tabBusquedaSala.Location = new System.Drawing.Point(4, 22);
            this.tabBusquedaSala.Name = "tabBusquedaSala";
            this.tabBusquedaSala.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusquedaSala.Size = new System.Drawing.Size(780, 490);
            this.tabBusquedaSala.TabIndex = 1;
            this.tabBusquedaSala.Text = "Busqueda";
            this.tabBusquedaSala.UseVisualStyleBackColor = true;
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Salas";
            this.Size = new System.Drawing.Size(794, 519);
            this.tabControl1.ResumeLayout(false);
            this.tabAñadirSala.ResumeLayout(false);
            this.tabAñadirSala.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAñadirSala;
        private System.Windows.Forms.TabPage tabBusquedaSala;
        private System.Windows.Forms.Label label1;
    }
}
