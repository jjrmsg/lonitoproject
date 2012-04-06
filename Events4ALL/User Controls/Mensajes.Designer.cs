namespace Events4ALL.User_Controls
{
    partial class Mensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensajes));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.mailButton = new System.Windows.Forms.Button();
            this.responseText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textConsulta = new System.Windows.Forms.TextBox();
            this.textAsunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.msgGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.mailButton);
            this.groupBox1.Controls.Add(this.responseText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textConsulta);
            this.groupBox1.Controls.Add(this.textAsunto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textApellidos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // mailButton
            // 
            resources.ApplyResources(this.mailButton, "mailButton");
            this.mailButton.Name = "mailButton";
            this.mailButton.UseVisualStyleBackColor = true;
            this.mailButton.Click += new System.EventHandler(this.mailButton_Click);
            // 
            // responseText
            // 
            resources.ApplyResources(this.responseText, "responseText");
            this.responseText.Name = "responseText";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textConsulta
            // 
            resources.ApplyResources(this.textConsulta, "textConsulta");
            this.textConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.textConsulta.Name = "textConsulta";
            this.textConsulta.ReadOnly = true;
            // 
            // textAsunto
            // 
            resources.ApplyResources(this.textAsunto, "textAsunto");
            this.textAsunto.Cursor = System.Windows.Forms.Cursors.Default;
            this.textAsunto.Name = "textAsunto";
            this.textAsunto.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textApellidos
            // 
            resources.ApplyResources(this.textApellidos, "textApellidos");
            this.textApellidos.Cursor = System.Windows.Forms.Cursors.Default;
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textNombre
            // 
            resources.ApplyResources(this.textNombre, "textNombre");
            this.textNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            // 
            // msgGridView
            // 
            this.msgGridView.AllowUserToAddRows = false;
            this.msgGridView.AllowUserToDeleteRows = false;
            this.msgGridView.AllowUserToResizeColumns = false;
            this.msgGridView.AllowUserToResizeRows = false;
            resources.ApplyResources(this.msgGridView, "msgGridView");
            this.msgGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.msgGridView.BackgroundColor = System.Drawing.Color.White;
            this.msgGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.msgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msgGridView.ColumnHeadersVisible = false;
            this.msgGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Asunto,
            this.Eliminar});
            this.msgGridView.Name = "msgGridView";
            this.msgGridView.ReadOnly = true;
            this.msgGridView.RowHeadersVisible = false;
            this.msgGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.msgGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.msgGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msgGridView_CellClick);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Asunto
            // 
            this.Asunto.FillWeight = 189.8477F;
            resources.ApplyResources(this.Asunto, "Asunto");
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 10.15228F;
            resources.ApplyResources(this.Eliminar, "Eliminar");
            this.Eliminar.Image = global::Events4ALL.Properties.Resources.delete;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 10.15228F;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::Events4ALL.Properties.Resources.delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // refreshButton
            // 
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.Image = global::Events4ALL.Properties.Resources.reload;
            resources.ApplyResources(this.refreshButton, "refreshButton");
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.TabStop = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Mensajes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msgGridView);
            this.Name = "Mensajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mailButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textConsulta;
        private System.Windows.Forms.TextBox textAsunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DataGridView msgGridView;
        private System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.TextBox responseText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.PictureBox refreshButton;
    }
}
