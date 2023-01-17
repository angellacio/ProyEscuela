namespace AppElectronica.Formas
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
            this.lblCli_Dato = new System.Windows.Forms.Label();
            this.btnCli_Buscar = new System.Windows.Forms.Button();
            this.lblCli_ID = new System.Windows.Forms.Label();
            this.txtCli_ID = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbTipoEquipo = new System.Windows.Forms.ComboBox();
            this.gbTipoEquipo = new System.Windows.Forms.GroupBox();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvTal_Encontrados = new System.Windows.Forms.DataGridView();
            this.clTal_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTal_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTal_TipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCliBus_CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTal_NumeroSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTal_Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTal_PorCobrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTal_Cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTal_Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente.SuspendLayout();
            this.gbTipoEquipo.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTal_Encontrados)).BeginInit();
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
            // btnCli_Buscar
            // 
            this.btnCli_Buscar.BackgroundImage = global::AppElectronica.Properties.Resources.Buscar;
            this.btnCli_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCli_Buscar.Location = new System.Drawing.Point(97, 15);
            this.btnCli_Buscar.Name = "btnCli_Buscar";
            this.btnCli_Buscar.Size = new System.Drawing.Size(28, 23);
            this.btnCli_Buscar.TabIndex = 2;
            this.btnCli_Buscar.UseVisualStyleBackColor = true;
            this.btnCli_Buscar.Click += new System.EventHandler(this.btnCli_Buscar_Click);
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
            // txtCli_ID
            // 
            this.txtCli_ID.Location = new System.Drawing.Point(34, 17);
            this.txtCli_ID.Name = "txtCli_ID";
            this.txtCli_ID.Size = new System.Drawing.Size(57, 20);
            this.txtCli_ID.TabIndex = 0;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumSerie.Location = new System.Drawing.Point(6, 19);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(241, 20);
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
            this.cmbTipoEquipo.Size = new System.Drawing.Size(241, 21);
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
            this.groupBox1.Size = new System.Drawing.Size(253, 49);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Número de serie";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::AppElectronica.Properties.Resources.Buscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(532, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvTal_Encontrados
            // 
            this.dgvTal_Encontrados.AllowUserToAddRows = false;
            this.dgvTal_Encontrados.AllowUserToDeleteRows = false;
            this.dgvTal_Encontrados.AllowUserToResizeRows = false;
            this.dgvTal_Encontrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTal_Encontrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTal_Encontrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTal_Id,
            this.clTal_Cliente,
            this.clTal_TipoEquipo,
            this.clCliBus_CURP,
            this.dtgTal_NumeroSerie,
            this.dtgTal_Observaciones,
            this.dtgTal_PorCobrar,
            this.dtgTal_Cobrado,
            this.dtgTal_Neto});
            this.dgvTal_Encontrados.Location = new System.Drawing.Point(12, 175);
            this.dgvTal_Encontrados.MultiSelect = false;
            this.dgvTal_Encontrados.Name = "dgvTal_Encontrados";
            this.dgvTal_Encontrados.RowHeadersVisible = false;
            this.dgvTal_Encontrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTal_Encontrados.ShowCellErrors = false;
            this.dgvTal_Encontrados.ShowCellToolTips = false;
            this.dgvTal_Encontrados.ShowEditingIcon = false;
            this.dgvTal_Encontrados.ShowRowErrors = false;
            this.dgvTal_Encontrados.Size = new System.Drawing.Size(549, 111);
            this.dgvTal_Encontrados.TabIndex = 21;
            this.dgvTal_Encontrados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTal_Encontrados_CellDoubleClick);
            // 
            // clTal_Id
            // 
            this.clTal_Id.DataPropertyName = "nIdTaller";
            this.clTal_Id.HeaderText = "ID";
            this.clTal_Id.Name = "clTal_Id";
            this.clTal_Id.ReadOnly = true;
            this.clTal_Id.Width = 43;
            // 
            // clTal_Cliente
            // 
            this.clTal_Cliente.DataPropertyName = "sClienteC";
            this.clTal_Cliente.HeaderText = "Cliente";
            this.clTal_Cliente.Name = "clTal_Cliente";
            this.clTal_Cliente.ReadOnly = true;
            this.clTal_Cliente.Width = 64;
            // 
            // clTal_TipoEquipo
            // 
            this.clTal_TipoEquipo.DataPropertyName = "TipoEquipo";
            this.clTal_TipoEquipo.HeaderText = "Tipo Equipo";
            this.clTal_TipoEquipo.Name = "clTal_TipoEquipo";
            this.clTal_TipoEquipo.ReadOnly = true;
            this.clTal_TipoEquipo.Width = 89;
            // 
            // clCliBus_CURP
            // 
            this.clCliBus_CURP.DataPropertyName = "sMarca";
            this.clCliBus_CURP.HeaderText = "Marca";
            this.clCliBus_CURP.Name = "clCliBus_CURP";
            this.clCliBus_CURP.ReadOnly = true;
            this.clCliBus_CURP.Width = 62;
            // 
            // dtgTal_NumeroSerie
            // 
            this.dtgTal_NumeroSerie.DataPropertyName = "sNumSerie";
            this.dtgTal_NumeroSerie.HeaderText = "Número Serie";
            this.dtgTal_NumeroSerie.Name = "dtgTal_NumeroSerie";
            this.dtgTal_NumeroSerie.ReadOnly = true;
            this.dtgTal_NumeroSerie.Width = 96;
            // 
            // dtgTal_Observaciones
            // 
            this.dtgTal_Observaciones.DataPropertyName = "sObservaciones";
            this.dtgTal_Observaciones.HeaderText = "Observaciones";
            this.dtgTal_Observaciones.Name = "dtgTal_Observaciones";
            this.dtgTal_Observaciones.ReadOnly = true;
            this.dtgTal_Observaciones.Width = 103;
            // 
            // dtgTal_PorCobrar
            // 
            this.dtgTal_PorCobrar.DataPropertyName = "dbMontoPorCobrar";
            this.dtgTal_PorCobrar.HeaderText = "Por Cobrar";
            this.dtgTal_PorCobrar.Name = "dtgTal_PorCobrar";
            this.dtgTal_PorCobrar.ReadOnly = true;
            this.dtgTal_PorCobrar.Width = 82;
            // 
            // dtgTal_Cobrado
            // 
            this.dtgTal_Cobrado.DataPropertyName = "dbMontoCobrado";
            this.dtgTal_Cobrado.HeaderText = "Cobrado";
            this.dtgTal_Cobrado.Name = "dtgTal_Cobrado";
            this.dtgTal_Cobrado.ReadOnly = true;
            this.dtgTal_Cobrado.Width = 72;
            // 
            // dtgTal_Neto
            // 
            this.dtgTal_Neto.DataPropertyName = "dbMontoNeto";
            this.dtgTal_Neto.HeaderText = "Neto";
            this.dtgTal_Neto.Name = "dtgTal_Neto";
            this.dtgTal_Neto.ReadOnly = true;
            this.dtgTal_Neto.Width = 55;
            // 
            // frmEquipoElectronico_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 298);
            this.Controls.Add(this.dgvTal_Encontrados);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTal_Encontrados)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTal_Encontrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTal_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTal_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTal_TipoEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCliBus_CURP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTal_NumeroSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTal_Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTal_PorCobrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTal_Cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTal_Neto;
    }
}