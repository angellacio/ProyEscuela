namespace Aplicacion_Electronica.Formas
{
    partial class frmCliente_Busqueda
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
            this.btnCli_Buscar = new System.Windows.Forms.Button();
            this.gbCliBus_RFC = new System.Windows.Forms.GroupBox();
            this.txtCliBus_RFC = new System.Windows.Forms.TextBox();
            this.gbCliBus_Nombre = new System.Windows.Forms.GroupBox();
            this.txtCliBus_Nombre = new System.Windows.Forms.TextBox();
            this.gbCliBus_Apellido2 = new System.Windows.Forms.GroupBox();
            this.txtCliBus_Apellido2 = new System.Windows.Forms.TextBox();
            this.dgvCli_Encontrados = new System.Windows.Forms.DataGridView();
            this.clCliBus_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCliBus_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCliBus_RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCliBus_CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliBus_Apellido1 = new System.Windows.Forms.GroupBox();
            this.txtCliBus_Apellido1 = new System.Windows.Forms.TextBox();
            this.gbCliBus_IDCliente = new System.Windows.Forms.GroupBox();
            this.txtCliBus_IdCliente = new System.Windows.Forms.TextBox();
            this.gbCliBus_CURP = new System.Windows.Forms.GroupBox();
            this.txtCliBus_CURP = new System.Windows.Forms.TextBox();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.gbCliBus_RFC.SuspendLayout();
            this.gbCliBus_Nombre.SuspendLayout();
            this.gbCliBus_Apellido2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli_Encontrados)).BeginInit();
            this.gbCliBus_Apellido1.SuspendLayout();
            this.gbCliBus_IDCliente.SuspendLayout();
            this.gbCliBus_CURP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCli_Buscar
            // 
            this.btnCli_Buscar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Buscar;
            this.btnCli_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCli_Buscar.Location = new System.Drawing.Point(524, 29);
            this.btnCli_Buscar.Name = "btnCli_Buscar";
            this.btnCli_Buscar.Size = new System.Drawing.Size(26, 23);
            this.btnCli_Buscar.TabIndex = 60;
            this.btnCli_Buscar.UseVisualStyleBackColor = true;
            this.btnCli_Buscar.Click += new System.EventHandler(this.btnCli_Buscar_Click);
            // 
            // gbCliBus_RFC
            // 
            this.gbCliBus_RFC.Controls.Add(this.txtCliBus_RFC);
            this.gbCliBus_RFC.Location = new System.Drawing.Point(86, 12);
            this.gbCliBus_RFC.Name = "gbCliBus_RFC";
            this.gbCliBus_RFC.Size = new System.Drawing.Size(109, 46);
            this.gbCliBus_RFC.TabIndex = 9;
            this.gbCliBus_RFC.TabStop = false;
            this.gbCliBus_RFC.Text = "RFC";
            // 
            // txtCliBus_RFC
            // 
            this.txtCliBus_RFC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliBus_RFC.Location = new System.Drawing.Point(6, 19);
            this.txtCliBus_RFC.Name = "txtCliBus_RFC";
            this.txtCliBus_RFC.Size = new System.Drawing.Size(97, 20);
            this.txtCliBus_RFC.TabIndex = 10;
            // 
            // gbCliBus_Nombre
            // 
            this.gbCliBus_Nombre.Controls.Add(this.txtCliBus_Nombre);
            this.gbCliBus_Nombre.Location = new System.Drawing.Point(358, 65);
            this.gbCliBus_Nombre.Name = "gbCliBus_Nombre";
            this.gbCliBus_Nombre.Size = new System.Drawing.Size(198, 46);
            this.gbCliBus_Nombre.TabIndex = 6;
            this.gbCliBus_Nombre.TabStop = false;
            this.gbCliBus_Nombre.Text = "Nombre";
            // 
            // txtCliBus_Nombre
            // 
            this.txtCliBus_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliBus_Nombre.Location = new System.Drawing.Point(6, 19);
            this.txtCliBus_Nombre.Name = "txtCliBus_Nombre";
            this.txtCliBus_Nombre.Size = new System.Drawing.Size(186, 20);
            this.txtCliBus_Nombre.TabIndex = 50;
            // 
            // gbCliBus_Apellido2
            // 
            this.gbCliBus_Apellido2.Controls.Add(this.txtCliBus_Apellido2);
            this.gbCliBus_Apellido2.Location = new System.Drawing.Point(190, 65);
            this.gbCliBus_Apellido2.Name = "gbCliBus_Apellido2";
            this.gbCliBus_Apellido2.Size = new System.Drawing.Size(162, 46);
            this.gbCliBus_Apellido2.TabIndex = 7;
            this.gbCliBus_Apellido2.TabStop = false;
            this.gbCliBus_Apellido2.Text = "Apellido Materno";
            // 
            // txtCliBus_Apellido2
            // 
            this.txtCliBus_Apellido2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliBus_Apellido2.Location = new System.Drawing.Point(6, 19);
            this.txtCliBus_Apellido2.Name = "txtCliBus_Apellido2";
            this.txtCliBus_Apellido2.Size = new System.Drawing.Size(150, 20);
            this.txtCliBus_Apellido2.TabIndex = 40;
            // 
            // dgvCli_Encontrados
            // 
            this.dgvCli_Encontrados.AllowUserToAddRows = false;
            this.dgvCli_Encontrados.AllowUserToDeleteRows = false;
            this.dgvCli_Encontrados.AllowUserToResizeRows = false;
            this.dgvCli_Encontrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCli_Encontrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCli_Encontrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCliBus_ID,
            this.clCliBus_Nombre,
            this.clCliBus_RFC,
            this.clCliBus_CURP});
            this.dgvCli_Encontrados.Location = new System.Drawing.Point(12, 117);
            this.dgvCli_Encontrados.MultiSelect = false;
            this.dgvCli_Encontrados.Name = "dgvCli_Encontrados";
            this.dgvCli_Encontrados.RowHeadersVisible = false;
            this.dgvCli_Encontrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCli_Encontrados.ShowCellErrors = false;
            this.dgvCli_Encontrados.ShowCellToolTips = false;
            this.dgvCli_Encontrados.ShowEditingIcon = false;
            this.dgvCli_Encontrados.ShowRowErrors = false;
            this.dgvCli_Encontrados.Size = new System.Drawing.Size(544, 96);
            this.dgvCli_Encontrados.TabIndex = 8;
            this.dgvCli_Encontrados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCli_Encontrados_CellDoubleClick);
            // 
            // clCliBus_ID
            // 
            this.clCliBus_ID.DataPropertyName = "nId";
            this.clCliBus_ID.HeaderText = "ID";
            this.clCliBus_ID.Name = "clCliBus_ID";
            this.clCliBus_ID.ReadOnly = true;
            this.clCliBus_ID.Width = 43;
            // 
            // clCliBus_Nombre
            // 
            this.clCliBus_Nombre.DataPropertyName = "sNombreCompleto";
            this.clCliBus_Nombre.HeaderText = "Nombre";
            this.clCliBus_Nombre.Name = "clCliBus_Nombre";
            this.clCliBus_Nombre.ReadOnly = true;
            this.clCliBus_Nombre.Width = 69;
            // 
            // clCliBus_RFC
            // 
            this.clCliBus_RFC.DataPropertyName = "sRFC";
            this.clCliBus_RFC.HeaderText = "RFC";
            this.clCliBus_RFC.Name = "clCliBus_RFC";
            this.clCliBus_RFC.ReadOnly = true;
            this.clCliBus_RFC.Width = 53;
            // 
            // clCliBus_CURP
            // 
            this.clCliBus_CURP.DataPropertyName = "sCURP";
            this.clCliBus_CURP.HeaderText = "CURP";
            this.clCliBus_CURP.Name = "clCliBus_CURP";
            this.clCliBus_CURP.ReadOnly = true;
            this.clCliBus_CURP.Width = 62;
            // 
            // gbCliBus_Apellido1
            // 
            this.gbCliBus_Apellido1.Controls.Add(this.txtCliBus_Apellido1);
            this.gbCliBus_Apellido1.Location = new System.Drawing.Point(12, 65);
            this.gbCliBus_Apellido1.Name = "gbCliBus_Apellido1";
            this.gbCliBus_Apellido1.Size = new System.Drawing.Size(172, 46);
            this.gbCliBus_Apellido1.TabIndex = 5;
            this.gbCliBus_Apellido1.TabStop = false;
            this.gbCliBus_Apellido1.Text = "Apellido Paterno";
            // 
            // txtCliBus_Apellido1
            // 
            this.txtCliBus_Apellido1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliBus_Apellido1.Location = new System.Drawing.Point(6, 19);
            this.txtCliBus_Apellido1.Name = "txtCliBus_Apellido1";
            this.txtCliBus_Apellido1.Size = new System.Drawing.Size(160, 20);
            this.txtCliBus_Apellido1.TabIndex = 30;
            // 
            // gbCliBus_IDCliente
            // 
            this.gbCliBus_IDCliente.Controls.Add(this.txtCliBus_IdCliente);
            this.gbCliBus_IDCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliBus_IDCliente.Name = "gbCliBus_IDCliente";
            this.gbCliBus_IDCliente.Size = new System.Drawing.Size(68, 46);
            this.gbCliBus_IDCliente.TabIndex = 10;
            this.gbCliBus_IDCliente.TabStop = false;
            this.gbCliBus_IDCliente.Text = "ID Cliente";
            // 
            // txtCliBus_IdCliente
            // 
            this.txtCliBus_IdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliBus_IdCliente.Location = new System.Drawing.Point(6, 19);
            this.txtCliBus_IdCliente.Name = "txtCliBus_IdCliente";
            this.txtCliBus_IdCliente.Size = new System.Drawing.Size(56, 20);
            this.txtCliBus_IdCliente.TabIndex = 0;
            // 
            // gbCliBus_CURP
            // 
            this.gbCliBus_CURP.Controls.Add(this.txtCliBus_CURP);
            this.gbCliBus_CURP.Location = new System.Drawing.Point(201, 12);
            this.gbCliBus_CURP.Name = "gbCliBus_CURP";
            this.gbCliBus_CURP.Size = new System.Drawing.Size(151, 46);
            this.gbCliBus_CURP.TabIndex = 10;
            this.gbCliBus_CURP.TabStop = false;
            this.gbCliBus_CURP.Text = "CURP";
            // 
            // txtCliBus_CURP
            // 
            this.txtCliBus_CURP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliBus_CURP.Location = new System.Drawing.Point(6, 19);
            this.txtCliBus_CURP.Name = "txtCliBus_CURP";
            this.txtCliBus_CURP.Size = new System.Drawing.Size(139, 20);
            this.txtCliBus_CURP.TabIndex = 20;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(358, 18);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(60, 17);
            this.rdbActivo.TabIndex = 61;
            this.rdbActivo.Text = "Activos";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(358, 41);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(68, 17);
            this.rdbInactivo.TabIndex = 62;
            this.rdbInactivo.Text = "Inactivos";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(424, 31);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 63;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // frmCliente_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 225);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.rdbInactivo);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.gbCliBus_CURP);
            this.Controls.Add(this.gbCliBus_IDCliente);
            this.Controls.Add(this.btnCli_Buscar);
            this.Controls.Add(this.gbCliBus_RFC);
            this.Controls.Add(this.gbCliBus_Nombre);
            this.Controls.Add(this.gbCliBus_Apellido2);
            this.Controls.Add(this.dgvCli_Encontrados);
            this.Controls.Add(this.gbCliBus_Apellido1);
            this.Name = "frmCliente_Busqueda";
            this.Text = "frmCli_Busqueda";
            this.Load += new System.EventHandler(this.frmCliente_Busqueda_Load);
            this.gbCliBus_RFC.ResumeLayout(false);
            this.gbCliBus_RFC.PerformLayout();
            this.gbCliBus_Nombre.ResumeLayout(false);
            this.gbCliBus_Nombre.PerformLayout();
            this.gbCliBus_Apellido2.ResumeLayout(false);
            this.gbCliBus_Apellido2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli_Encontrados)).EndInit();
            this.gbCliBus_Apellido1.ResumeLayout(false);
            this.gbCliBus_Apellido1.PerformLayout();
            this.gbCliBus_IDCliente.ResumeLayout(false);
            this.gbCliBus_IDCliente.PerformLayout();
            this.gbCliBus_CURP.ResumeLayout(false);
            this.gbCliBus_CURP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCli_Buscar;
        private System.Windows.Forms.GroupBox gbCliBus_RFC;
        private System.Windows.Forms.TextBox txtCliBus_RFC;
        private System.Windows.Forms.GroupBox gbCliBus_Nombre;
        private System.Windows.Forms.TextBox txtCliBus_Nombre;
        private System.Windows.Forms.GroupBox gbCliBus_Apellido2;
        private System.Windows.Forms.TextBox txtCliBus_Apellido2;
        private System.Windows.Forms.DataGridView dgvCli_Encontrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliBus_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliBus_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliBus_RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliBus_CURP;
        private System.Windows.Forms.GroupBox gbCliBus_Apellido1;
        private System.Windows.Forms.TextBox txtCliBus_Apellido1;
        private System.Windows.Forms.GroupBox gbCliBus_IDCliente;
        private System.Windows.Forms.TextBox txtCliBus_IdCliente;
        private System.Windows.Forms.GroupBox gbCliBus_CURP;
        private System.Windows.Forms.TextBox txtCliBus_CURP;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.RadioButton rdbTodos;
    }
}