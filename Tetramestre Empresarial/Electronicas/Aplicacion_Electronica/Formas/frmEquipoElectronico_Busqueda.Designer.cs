namespace Aplicacion_Electronica.Formas
{
    partial class frmEquipoElectronico_Busqueda
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtCli_ID = new System.Windows.Forms.TextBox();
            this.lblCli_ID = new System.Windows.Forms.Label();
            this.btnCli_Buscar = new System.Windows.Forms.Button();
            this.lblCli_Dato = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbTipoEquipo = new System.Windows.Forms.ComboBox();
            this.gbTipoEquipo = new System.Windows.Forms.GroupBox();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvCli_Encontrados = new System.Windows.Forms.DataGridView();
            this.clCliBus_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCliBus_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCliBus_RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCliBus_CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente.SuspendLayout();
            this.gbTipoEquipo.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli_Encontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCliente.Controls.Add(this.lblCli_Dato);
            this.gbCliente.Controls.Add(this.btnCli_Buscar);
            this.gbCliente.Controls.Add(this.lblCli_ID);
            this.gbCliente.Controls.Add(this.txtCli_ID);
            this.gbCliente.Location = new System.Drawing.Point(13, 13);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(548, 45);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtCli_ID
            // 
            this.txtCli_ID.Location = new System.Drawing.Point(34, 17);
            this.txtCli_ID.Name = "txtCli_ID";
            this.txtCli_ID.Size = new System.Drawing.Size(57, 20);
            this.txtCli_ID.TabIndex = 0;
            // 
            // lblCli_ID
            // 
            this.lblCli_ID.AutoSize = true;
            this.lblCli_ID.Location = new System.Drawing.Point(7, 20);
            this.lblCli_ID.Name = "lblCli_ID";
            this.lblCli_ID.Size = new System.Drawing.Size(21, 13);
            this.lblCli_ID.TabIndex = 1;
            this.lblCli_ID.Text = "ID:";
            // 
            // btnCli_Buscar
            // 
            this.btnCli_Buscar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Buscar;
            this.btnCli_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCli_Buscar.Location = new System.Drawing.Point(97, 15);
            this.btnCli_Buscar.Name = "btnCli_Buscar";
            this.btnCli_Buscar.Size = new System.Drawing.Size(28, 23);
            this.btnCli_Buscar.TabIndex = 2;
            this.btnCli_Buscar.UseVisualStyleBackColor = true;
            // 
            // lblCli_Dato
            // 
            this.lblCli_Dato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCli_Dato.Location = new System.Drawing.Point(131, 17);
            this.lblCli_Dato.Name = "lblCli_Dato";
            this.lblCli_Dato.Size = new System.Drawing.Size(411, 20);
            this.lblCli_Dato.TabIndex = 3;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumSerie.Location = new System.Drawing.Point(6, 19);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(290, 20);
            this.txtNumSerie.TabIndex = 18;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.Location = new System.Drawing.Point(6, 19);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(261, 20);
            this.txtMarca.TabIndex = 16;
            // 
            // cmbTipoEquipo
            // 
            this.cmbTipoEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoEquipo.FormattingEnabled = true;
            this.cmbTipoEquipo.Location = new System.Drawing.Point(6, 19);
            this.cmbTipoEquipo.Name = "cmbTipoEquipo";
            this.cmbTipoEquipo.Size = new System.Drawing.Size(227, 21);
            this.cmbTipoEquipo.TabIndex = 14;
            // 
            // gbTipoEquipo
            // 
            this.gbTipoEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTipoEquipo.Controls.Add(this.cmbTipoEquipo);
            this.gbTipoEquipo.Location = new System.Drawing.Point(13, 65);
            this.gbTipoEquipo.Name = "gbTipoEquipo";
            this.gbTipoEquipo.Size = new System.Drawing.Size(253, 49);
            this.gbTipoEquipo.TabIndex = 19;
            this.gbTipoEquipo.TabStop = false;
            this.gbTipoEquipo.Text = "Tipo equipo";
            // 
            // gbMarca
            // 
            this.gbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMarca.Controls.Add(this.txtMarca);
            this.gbMarca.Location = new System.Drawing.Point(272, 64);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(288, 49);
            this.gbMarca.TabIndex = 20;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumSerie);
            this.groupBox1.Location = new System.Drawing.Point(13, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 49);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Número de serie";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Buscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(335, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
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
            this.dgvCli_Encontrados.Location = new System.Drawing.Point(12, 175);
            this.dgvCli_Encontrados.MultiSelect = false;
            this.dgvCli_Encontrados.Name = "dgvCli_Encontrados";
            this.dgvCli_Encontrados.RowHeadersVisible = false;
            this.dgvCli_Encontrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCli_Encontrados.ShowCellErrors = false;
            this.dgvCli_Encontrados.ShowCellToolTips = false;
            this.dgvCli_Encontrados.ShowEditingIcon = false;
            this.dgvCli_Encontrados.ShowRowErrors = false;
            this.dgvCli_Encontrados.Size = new System.Drawing.Size(549, 111);
            this.dgvCli_Encontrados.TabIndex = 21;
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
            // frmEquipoElectronico_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 298);
            this.Controls.Add(this.dgvCli_Encontrados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.gbTipoEquipo);
            this.Controls.Add(this.gbCliente);
            this.Name = "frmEquipoElectronico_Busqueda";
            this.Text = "frmEquipoElectronico_Busqueda";
            this.Load += new System.EventHandler(this.frmEquipoElectronico_Busqueda_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbTipoEquipo.ResumeLayout(false);
            this.gbMarca.ResumeLayout(false);
            this.gbMarca.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCli_Encontrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblCli_ID;
        private System.Windows.Forms.TextBox txtCli_ID;
        private System.Windows.Forms.Button btnCli_Buscar;
        private System.Windows.Forms.Label lblCli_Dato;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cmbTipoEquipo;
        private System.Windows.Forms.GroupBox gbTipoEquipo;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCli_Encontrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliBus_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliBus_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliBus_RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliBus_CURP;
    }
}