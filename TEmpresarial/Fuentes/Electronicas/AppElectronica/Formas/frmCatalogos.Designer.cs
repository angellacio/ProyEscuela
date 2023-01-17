namespace Aplicacion_Electronica.Formas
{
    partial class frmCatalogos
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
            this.components = new System.ComponentModel.Container();
            this.lblTabla = new System.Windows.Forms.Label();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.dtgCatalogo = new System.Windows.Forms.DataGridView();
            this.dgvCNumeroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.epCatalogos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCatalogos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabla
            // 
            this.lblTabla.Location = new System.Drawing.Point(12, 9);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(103, 17);
            this.lblTabla.TabIndex = 30;
            this.lblTabla.Text = "Tabla:";
            this.lblTabla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTabla
            // 
            this.cmbTabla.Enabled = false;
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(121, 8);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(199, 21);
            this.cmbTabla.TabIndex = 31;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(12, 36);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 17);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 35);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(276, 20);
            this.txtDescripcion.TabIndex = 33;
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // lblEstatus
            // 
            this.lblEstatus.Location = new System.Drawing.Point(12, 67);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(103, 17);
            this.lblEstatus.TabIndex = 34;
            this.lblEstatus.Text = "Estatus:";
            this.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.Location = new System.Drawing.Point(121, 67);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(56, 17);
            this.ckbEstado.TabIndex = 39;
            this.ckbEstado.Text = "Activo";
            this.ckbEstado.UseVisualStyleBackColor = true;
            // 
            // dtgCatalogo
            // 
            this.dtgCatalogo.AllowUserToAddRows = false;
            this.dtgCatalogo.AllowUserToDeleteRows = false;
            this.dtgCatalogo.AllowUserToResizeRows = false;
            this.dtgCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCNumeroId,
            this.dtgCDescripcion,
            this.dtgCEstado});
            this.dtgCatalogo.Location = new System.Drawing.Point(12, 90);
            this.dtgCatalogo.MultiSelect = false;
            this.dtgCatalogo.Name = "dtgCatalogo";
            this.dtgCatalogo.RowHeadersVisible = false;
            this.dtgCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCatalogo.ShowCellErrors = false;
            this.dtgCatalogo.ShowCellToolTips = false;
            this.dtgCatalogo.ShowEditingIcon = false;
            this.dtgCatalogo.ShowRowErrors = false;
            this.dtgCatalogo.Size = new System.Drawing.Size(524, 143);
            this.dtgCatalogo.TabIndex = 40;
            this.dtgCatalogo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCatalogo_CellDoubleClick);
            // 
            // dgvCNumeroId
            // 
            this.dgvCNumeroId.DataPropertyName = "nID";
            this.dgvCNumeroId.HeaderText = "ID";
            this.dgvCNumeroId.Name = "dgvCNumeroId";
            this.dgvCNumeroId.ReadOnly = true;
            this.dgvCNumeroId.Width = 43;
            // 
            // dtgCDescripcion
            // 
            this.dtgCDescripcion.DataPropertyName = "sDescripcion";
            this.dtgCDescripcion.HeaderText = "Descripción";
            this.dtgCDescripcion.Name = "dtgCDescripcion";
            this.dtgCDescripcion.ReadOnly = true;
            this.dtgCDescripcion.Width = 88;
            // 
            // dtgCEstado
            // 
            this.dtgCEstado.DataPropertyName = "bEstado";
            this.dtgCEstado.HeaderText = "Estado";
            this.dtgCEstado.Name = "dtgCEstado";
            this.dtgCEstado.ReadOnly = true;
            this.dtgCEstado.Width = 46;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(460, 63);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(36, 23);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Limpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Location = new System.Drawing.Point(500, 63);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(36, 23);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // epCatalogos
            // 
            this.epCatalogos.ContainerControl = this;
            // 
            // frmCatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 245);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtgCatalogo);
            this.Controls.Add(this.ckbEstado);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.lblTabla);
            this.Name = "frmCatalogos";
            this.Text = "Administración de Catalogos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCatalogos_FormClosing);
            this.Load += new System.EventHandler(this.frmCatalogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCatalogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.DataGridView dtgCatalogo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCNumeroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtgCEstado;
        private System.Windows.Forms.ErrorProvider epCatalogos;
    }
}