namespace AppElectronica.Formas
{
    partial class frmSeguridad_Busqueda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSegBus_IDUsuario = new System.Windows.Forms.GroupBox();
            this.txtSegBus_IdCliente = new System.Windows.Forms.TextBox();
            this.gbSegBus_Nombre = new System.Windows.Forms.GroupBox();
            this.txtSegBus_Nombre = new System.Windows.Forms.TextBox();
            this.gbSegBus_Apellido2 = new System.Windows.Forms.GroupBox();
            this.txtSegBus_Apellido2 = new System.Windows.Forms.TextBox();
            this.gbSegBus_Apellido1 = new System.Windows.Forms.GroupBox();
            this.txtSegBus_Apellido1 = new System.Windows.Forms.TextBox();
            this.gbSegBus_Usuario = new System.Windows.Forms.GroupBox();
            this.txtSegBus_Usuario = new System.Windows.Forms.TextBox();
            this.dgvSeg_Encontrados = new System.Windows.Forms.DataGridView();
            this.clBus_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBus_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBus_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeg_Buscar = new System.Windows.Forms.Button();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.gbSegBus_IDUsuario.SuspendLayout();
            this.gbSegBus_Nombre.SuspendLayout();
            this.gbSegBus_Apellido2.SuspendLayout();
            this.gbSegBus_Apellido1.SuspendLayout();
            this.gbSegBus_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeg_Encontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSegBus_IDUsuario
            // 
            this.gbSegBus_IDUsuario.Controls.Add(this.txtSegBus_IdCliente);
            this.gbSegBus_IDUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbSegBus_IDUsuario.Name = "gbSegBus_IDUsuario";
            this.gbSegBus_IDUsuario.Size = new System.Drawing.Size(77, 46);
            this.gbSegBus_IDUsuario.TabIndex = 63;
            this.gbSegBus_IDUsuario.TabStop = false;
            this.gbSegBus_IDUsuario.Text = "ID Usuario";
            // 
            // txtSegBus_IdCliente
            // 
            this.txtSegBus_IdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegBus_IdCliente.Location = new System.Drawing.Point(6, 19);
            this.txtSegBus_IdCliente.Name = "txtSegBus_IdCliente";
            this.txtSegBus_IdCliente.Size = new System.Drawing.Size(65, 20);
            this.txtSegBus_IdCliente.TabIndex = 0;
            // 
            // gbSegBus_Nombre
            // 
            this.gbSegBus_Nombre.Controls.Add(this.txtSegBus_Nombre);
            this.gbSegBus_Nombre.Location = new System.Drawing.Point(358, 65);
            this.gbSegBus_Nombre.Name = "gbSegBus_Nombre";
            this.gbSegBus_Nombre.Size = new System.Drawing.Size(198, 46);
            this.gbSegBus_Nombre.TabIndex = 61;
            this.gbSegBus_Nombre.TabStop = false;
            this.gbSegBus_Nombre.Text = "Nombre";
            // 
            // txtSegBus_Nombre
            // 
            this.txtSegBus_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegBus_Nombre.Location = new System.Drawing.Point(6, 19);
            this.txtSegBus_Nombre.MaxLength = 250;
            this.txtSegBus_Nombre.Name = "txtSegBus_Nombre";
            this.txtSegBus_Nombre.Size = new System.Drawing.Size(186, 20);
            this.txtSegBus_Nombre.TabIndex = 50;
            // 
            // gbSegBus_Apellido2
            // 
            this.gbSegBus_Apellido2.Controls.Add(this.txtSegBus_Apellido2);
            this.gbSegBus_Apellido2.Location = new System.Drawing.Point(190, 65);
            this.gbSegBus_Apellido2.Name = "gbSegBus_Apellido2";
            this.gbSegBus_Apellido2.Size = new System.Drawing.Size(162, 46);
            this.gbSegBus_Apellido2.TabIndex = 62;
            this.gbSegBus_Apellido2.TabStop = false;
            this.gbSegBus_Apellido2.Text = "Apellido Materno";
            // 
            // txtSegBus_Apellido2
            // 
            this.txtSegBus_Apellido2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegBus_Apellido2.Location = new System.Drawing.Point(6, 19);
            this.txtSegBus_Apellido2.MaxLength = 150;
            this.txtSegBus_Apellido2.Name = "txtSegBus_Apellido2";
            this.txtSegBus_Apellido2.Size = new System.Drawing.Size(150, 20);
            this.txtSegBus_Apellido2.TabIndex = 40;
            // 
            // gbSegBus_Apellido1
            // 
            this.gbSegBus_Apellido1.Controls.Add(this.txtSegBus_Apellido1);
            this.gbSegBus_Apellido1.Location = new System.Drawing.Point(12, 65);
            this.gbSegBus_Apellido1.Name = "gbSegBus_Apellido1";
            this.gbSegBus_Apellido1.Size = new System.Drawing.Size(172, 46);
            this.gbSegBus_Apellido1.TabIndex = 60;
            this.gbSegBus_Apellido1.TabStop = false;
            this.gbSegBus_Apellido1.Text = "Apellido Paterno";
            // 
            // txtSegBus_Apellido1
            // 
            this.txtSegBus_Apellido1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegBus_Apellido1.Location = new System.Drawing.Point(6, 19);
            this.txtSegBus_Apellido1.MaxLength = 150;
            this.txtSegBus_Apellido1.Name = "txtSegBus_Apellido1";
            this.txtSegBus_Apellido1.Size = new System.Drawing.Size(160, 20);
            this.txtSegBus_Apellido1.TabIndex = 30;
            // 
            // gbSegBus_Usuario
            // 
            this.gbSegBus_Usuario.Controls.Add(this.txtSegBus_Usuario);
            this.gbSegBus_Usuario.Location = new System.Drawing.Point(106, 13);
            this.gbSegBus_Usuario.Name = "gbSegBus_Usuario";
            this.gbSegBus_Usuario.Size = new System.Drawing.Size(172, 46);
            this.gbSegBus_Usuario.TabIndex = 61;
            this.gbSegBus_Usuario.TabStop = false;
            this.gbSegBus_Usuario.Text = "Usuario";
            // 
            // txtSegBus_Usuario
            // 
            this.txtSegBus_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegBus_Usuario.Location = new System.Drawing.Point(6, 19);
            this.txtSegBus_Usuario.MaxLength = 8;
            this.txtSegBus_Usuario.Name = "txtSegBus_Usuario";
            this.txtSegBus_Usuario.Size = new System.Drawing.Size(160, 20);
            this.txtSegBus_Usuario.TabIndex = 30;
            // 
            // dgvSeg_Encontrados
            // 
            this.dgvSeg_Encontrados.AllowUserToAddRows = false;
            this.dgvSeg_Encontrados.AllowUserToDeleteRows = false;
            this.dgvSeg_Encontrados.AllowUserToResizeRows = false;
            this.dgvSeg_Encontrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeg_Encontrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSeg_Encontrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBus_ID,
            this.clBus_Nombre,
            this.clBus_Usuario});
            this.dgvSeg_Encontrados.Location = new System.Drawing.Point(12, 126);
            this.dgvSeg_Encontrados.MultiSelect = false;
            this.dgvSeg_Encontrados.Name = "dgvSeg_Encontrados";
            this.dgvSeg_Encontrados.RowHeadersVisible = false;
            this.dgvSeg_Encontrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeg_Encontrados.ShowCellErrors = false;
            this.dgvSeg_Encontrados.ShowCellToolTips = false;
            this.dgvSeg_Encontrados.ShowEditingIcon = false;
            this.dgvSeg_Encontrados.ShowRowErrors = false;
            this.dgvSeg_Encontrados.Size = new System.Drawing.Size(544, 312);
            this.dgvSeg_Encontrados.TabIndex = 65;
            this.dgvSeg_Encontrados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeg_Encontrados_CellContentDoubleClick);
            this.dgvSeg_Encontrados.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSeg_Encontrados_CellPainting);
            // 
            // clBus_ID
            // 
            this.clBus_ID.DataPropertyName = "nId";
            this.clBus_ID.HeaderText = "ID";
            this.clBus_ID.Name = "clBus_ID";
            this.clBus_ID.ReadOnly = true;
            this.clBus_ID.Width = 43;
            // 
            // clBus_Nombre
            // 
            this.clBus_Nombre.DataPropertyName = "sNombreCompleto";
            this.clBus_Nombre.HeaderText = "Nombre";
            this.clBus_Nombre.Name = "clBus_Nombre";
            this.clBus_Nombre.ReadOnly = true;
            this.clBus_Nombre.Width = 69;
            // 
            // clBus_Usuario
            // 
            this.clBus_Usuario.DataPropertyName = "sUsuario";
            this.clBus_Usuario.HeaderText = "Usuario";
            this.clBus_Usuario.Name = "clBus_Usuario";
            this.clBus_Usuario.ReadOnly = true;
            this.clBus_Usuario.Width = 68;
            // 
            // btnSeg_Buscar
            // 
            this.btnSeg_Buscar.BackgroundImage = global::AppElectronica.Properties.Resources.Buscar;
            this.btnSeg_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeg_Buscar.Location = new System.Drawing.Point(520, 30);
            this.btnSeg_Buscar.Name = "btnSeg_Buscar";
            this.btnSeg_Buscar.Size = new System.Drawing.Size(30, 23);
            this.btnSeg_Buscar.TabIndex = 66;
            this.btnSeg_Buscar.UseVisualStyleBackColor = true;
            this.btnSeg_Buscar.Click += new System.EventHandler(this.btnSeg_Buscar_Click);
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(329, 30);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(55, 17);
            this.rdbActivo.TabIndex = 67;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(390, 30);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivo.TabIndex = 68;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(459, 30);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 69;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // frmSeguridad_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.rdbInactivo);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.btnSeg_Buscar);
            this.Controls.Add(this.dgvSeg_Encontrados);
            this.Controls.Add(this.gbSegBus_Usuario);
            this.Controls.Add(this.gbSegBus_IDUsuario);
            this.Controls.Add(this.gbSegBus_Nombre);
            this.Controls.Add(this.gbSegBus_Apellido2);
            this.Controls.Add(this.gbSegBus_Apellido1);
            this.Name = "frmSeguridad_Busqueda";
            this.Text = "Busqueda usuario de seguridad....";
            this.Load += new System.EventHandler(this.frmSeguridad_Busqueda_Load);
            this.gbSegBus_IDUsuario.ResumeLayout(false);
            this.gbSegBus_IDUsuario.PerformLayout();
            this.gbSegBus_Nombre.ResumeLayout(false);
            this.gbSegBus_Nombre.PerformLayout();
            this.gbSegBus_Apellido2.ResumeLayout(false);
            this.gbSegBus_Apellido2.PerformLayout();
            this.gbSegBus_Apellido1.ResumeLayout(false);
            this.gbSegBus_Apellido1.PerformLayout();
            this.gbSegBus_Usuario.ResumeLayout(false);
            this.gbSegBus_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeg_Encontrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSegBus_IDUsuario;
        private System.Windows.Forms.TextBox txtSegBus_IdCliente;
        private System.Windows.Forms.GroupBox gbSegBus_Nombre;
        private System.Windows.Forms.TextBox txtSegBus_Nombre;
        private System.Windows.Forms.GroupBox gbSegBus_Apellido2;
        private System.Windows.Forms.TextBox txtSegBus_Apellido2;
        private System.Windows.Forms.GroupBox gbSegBus_Apellido1;
        private System.Windows.Forms.TextBox txtSegBus_Apellido1;
        private System.Windows.Forms.GroupBox gbSegBus_Usuario;
        private System.Windows.Forms.TextBox txtSegBus_Usuario;
        private System.Windows.Forms.DataGridView dgvSeg_Encontrados;
        private System.Windows.Forms.Button btnSeg_Buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBus_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBus_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBus_Usuario;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}