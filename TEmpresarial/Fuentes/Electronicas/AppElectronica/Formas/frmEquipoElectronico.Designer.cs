namespace AppElectronica.Formas
{
    partial class frmEquipoElectronico
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
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblCURP = new System.Windows.Forms.Label();
            this.lblTipoEquipo = new System.Windows.Forms.Label();
            this.cmbTipoEquipo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.tbcEquipoElectronico = new System.Windows.Forms.TabControl();
            this.tbpCostos = new System.Windows.Forms.TabPage();
            this.gbObservaciones = new System.Windows.Forms.GroupBox();
            this.txtCos_Observaciones = new System.Windows.Forms.TextBox();
            this.btnMonto = new System.Windows.Forms.Button();
            this.dgvEquElec_Costos = new System.Windows.Forms.DataGridView();
            this.clRegEqui_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRegEqui_TipoMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRegEqui_PoCobrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRegEqui_Cobrados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRegEqui_Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRegEqui_ButtonBorrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmbCos_TipoCosto = new System.Windows.Forms.ComboBox();
            this.lblTipoMonto = new System.Windows.Forms.Label();
            this.txtCos_Monto = new System.Windows.Forms.TextBox();
            this.tbpRecojer = new System.Windows.Forms.TabPage();
            this.dtgCli_AutRec = new System.Windows.Forms.DataGridView();
            this.dtgCNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCCURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.epTaller = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevoTipoEquipo = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbcEquipoElectronico.SuspendLayout();
            this.tbpCostos.SuspendLayout();
            this.gbObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquElec_Costos)).BeginInit();
            this.tbpRecojer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCli_AutRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTaller)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(12, 16);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(53, 13);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "ID Cliente";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(96, 13);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(64, 20);
            this.txtIDCliente.TabIndex = 1;
            this.txtIDCliente.Leave += new System.EventHandler(this.txtIDCliente_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(15, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(228, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRFC
            // 
            this.lblRFC.Location = new System.Drawing.Point(249, 36);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(97, 23);
            this.lblRFC.TabIndex = 3;
            this.lblRFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCURP
            // 
            this.lblCURP.Location = new System.Drawing.Point(360, 36);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(135, 23);
            this.lblCURP.TabIndex = 4;
            this.lblCURP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipoEquipo
            // 
            this.lblTipoEquipo.AutoSize = true;
            this.lblTipoEquipo.Location = new System.Drawing.Point(12, 71);
            this.lblTipoEquipo.Name = "lblTipoEquipo";
            this.lblTipoEquipo.Size = new System.Drawing.Size(66, 13);
            this.lblTipoEquipo.TabIndex = 6;
            this.lblTipoEquipo.Text = "Tipo equipo:";
            // 
            // cmbTipoEquipo
            // 
            this.cmbTipoEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEquipo.FormattingEnabled = true;
            this.cmbTipoEquipo.Location = new System.Drawing.Point(96, 70);
            this.cmbTipoEquipo.Name = "cmbTipoEquipo";
            this.cmbTipoEquipo.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoEquipo.TabIndex = 7;
            this.cmbTipoEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEquipo_SelectedIndexChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 102);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(96, 97);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(256, 20);
            this.txtMarca.TabIndex = 10;
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(96, 123);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(256, 20);
            this.txtNumSerie.TabIndex = 12;
            this.txtNumSerie.Leave += new System.EventHandler(this.txtNumSerie_Leave);
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(12, 129);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(72, 13);
            this.lblNumeroSerie.TabIndex = 11;
            this.lblNumeroSerie.Text = "Núm de serie:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(12, 152);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(96, 149);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtObservaciones.Size = new System.Drawing.Size(361, 49);
            this.txtObservaciones.TabIndex = 14;
            this.txtObservaciones.Leave += new System.EventHandler(this.txtObservaciones_Leave);
            // 
            // tbcEquipoElectronico
            // 
            this.tbcEquipoElectronico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcEquipoElectronico.Controls.Add(this.tbpCostos);
            this.tbcEquipoElectronico.Controls.Add(this.tbpRecojer);
            this.tbcEquipoElectronico.Location = new System.Drawing.Point(5, 204);
            this.tbcEquipoElectronico.Name = "tbcEquipoElectronico";
            this.tbcEquipoElectronico.SelectedIndex = 0;
            this.tbcEquipoElectronico.Size = new System.Drawing.Size(496, 225);
            this.tbcEquipoElectronico.TabIndex = 15;
            // 
            // tbpCostos
            // 
            this.tbpCostos.Controls.Add(this.gbObservaciones);
            this.tbpCostos.Controls.Add(this.btnMonto);
            this.tbpCostos.Controls.Add(this.dgvEquElec_Costos);
            this.tbpCostos.Controls.Add(this.lblMonto);
            this.tbpCostos.Controls.Add(this.cmbCos_TipoCosto);
            this.tbpCostos.Controls.Add(this.lblTipoMonto);
            this.tbpCostos.Controls.Add(this.txtCos_Monto);
            this.tbpCostos.Location = new System.Drawing.Point(4, 22);
            this.tbpCostos.Name = "tbpCostos";
            this.tbpCostos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCostos.Size = new System.Drawing.Size(488, 199);
            this.tbpCostos.TabIndex = 0;
            this.tbpCostos.Text = "Costos";
            this.tbpCostos.UseVisualStyleBackColor = true;
            // 
            // gbObservaciones
            // 
            this.gbObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbObservaciones.Controls.Add(this.txtCos_Observaciones);
            this.gbObservaciones.Location = new System.Drawing.Point(254, 3);
            this.gbObservaciones.Name = "gbObservaciones";
            this.gbObservaciones.Size = new System.Drawing.Size(183, 52);
            this.gbObservaciones.TabIndex = 11;
            this.gbObservaciones.TabStop = false;
            this.gbObservaciones.Text = "Observaciones";
            // 
            // txtCos_Observaciones
            // 
            this.txtCos_Observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCos_Observaciones.Location = new System.Drawing.Point(6, 19);
            this.txtCos_Observaciones.Multiline = true;
            this.txtCos_Observaciones.Name = "txtCos_Observaciones";
            this.txtCos_Observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCos_Observaciones.Size = new System.Drawing.Size(170, 27);
            this.txtCos_Observaciones.TabIndex = 11;
            // 
            // btnMonto
            // 
            this.btnMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonto.BackgroundImage = global::AppElectronica.Properties.Resources.Agregar;
            this.btnMonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonto.Location = new System.Drawing.Point(443, 17);
            this.btnMonto.Name = "btnMonto";
            this.btnMonto.Size = new System.Drawing.Size(39, 28);
            this.btnMonto.TabIndex = 10;
            this.btnMonto.UseVisualStyleBackColor = true;
            this.btnMonto.Click += new System.EventHandler(this.btnMonto_Click);
            // 
            // dgvEquElec_Costos
            // 
            this.dgvEquElec_Costos.AllowUserToAddRows = false;
            this.dgvEquElec_Costos.AllowUserToDeleteRows = false;
            this.dgvEquElec_Costos.AllowUserToResizeRows = false;
            this.dgvEquElec_Costos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquElec_Costos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEquElec_Costos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRegEqui_ID,
            this.clRegEqui_TipoMonto,
            this.clRegEqui_PoCobrar,
            this.clRegEqui_Cobrados,
            this.clRegEqui_Observacion,
            this.clRegEqui_ButtonBorrar});
            this.dgvEquElec_Costos.Location = new System.Drawing.Point(6, 60);
            this.dgvEquElec_Costos.MultiSelect = false;
            this.dgvEquElec_Costos.Name = "dgvEquElec_Costos";
            this.dgvEquElec_Costos.RowHeadersVisible = false;
            this.dgvEquElec_Costos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquElec_Costos.ShowCellErrors = false;
            this.dgvEquElec_Costos.ShowCellToolTips = false;
            this.dgvEquElec_Costos.ShowEditingIcon = false;
            this.dgvEquElec_Costos.ShowRowErrors = false;
            this.dgvEquElec_Costos.Size = new System.Drawing.Size(476, 133);
            this.dgvEquElec_Costos.TabIndex = 9;
            this.dgvEquElec_Costos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquElec_Costos_CellClick);
            // 
            // clRegEqui_ID
            // 
            this.clRegEqui_ID.DataPropertyName = "nIDCosto";
            this.clRegEqui_ID.HeaderText = "ID";
            this.clRegEqui_ID.Name = "clRegEqui_ID";
            this.clRegEqui_ID.ReadOnly = true;
            this.clRegEqui_ID.Width = 43;
            // 
            // clRegEqui_TipoMonto
            // 
            this.clRegEqui_TipoMonto.DataPropertyName = "sTipoCosto";
            this.clRegEqui_TipoMonto.HeaderText = "Tipo Monto";
            this.clRegEqui_TipoMonto.Name = "clRegEqui_TipoMonto";
            this.clRegEqui_TipoMonto.ReadOnly = true;
            this.clRegEqui_TipoMonto.Width = 86;
            // 
            // clRegEqui_PoCobrar
            // 
            this.clRegEqui_PoCobrar.DataPropertyName = "mPorCobrar";
            this.clRegEqui_PoCobrar.HeaderText = "Por Cobrar";
            this.clRegEqui_PoCobrar.Name = "clRegEqui_PoCobrar";
            this.clRegEqui_PoCobrar.ReadOnly = true;
            this.clRegEqui_PoCobrar.Width = 82;
            // 
            // clRegEqui_Cobrados
            // 
            this.clRegEqui_Cobrados.DataPropertyName = "mCobrado";
            this.clRegEqui_Cobrados.HeaderText = "Cobrados";
            this.clRegEqui_Cobrados.Name = "clRegEqui_Cobrados";
            this.clRegEqui_Cobrados.ReadOnly = true;
            this.clRegEqui_Cobrados.Width = 77;
            // 
            // clRegEqui_Observacion
            // 
            this.clRegEqui_Observacion.DataPropertyName = "sObservaciones";
            this.clRegEqui_Observacion.HeaderText = "Observación";
            this.clRegEqui_Observacion.Name = "clRegEqui_Observacion";
            this.clRegEqui_Observacion.ReadOnly = true;
            this.clRegEqui_Observacion.Width = 92;
            // 
            // clRegEqui_ButtonBorrar
            // 
            this.clRegEqui_ButtonBorrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clRegEqui_ButtonBorrar.HeaderText = "Borrar";
            this.clRegEqui_ButtonBorrar.Image = global::AppElectronica.Properties.Resources.Borrar;
            this.clRegEqui_ButtonBorrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clRegEqui_ButtonBorrar.Name = "clRegEqui_ButtonBorrar";
            this.clRegEqui_ButtonBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clRegEqui_ButtonBorrar.Width = 41;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(6, 37);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto:";
            // 
            // cmbCos_TipoCosto
            // 
            this.cmbCos_TipoCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCos_TipoCosto.FormattingEnabled = true;
            this.cmbCos_TipoCosto.Location = new System.Drawing.Point(73, 7);
            this.cmbCos_TipoCosto.Name = "cmbCos_TipoCosto";
            this.cmbCos_TipoCosto.Size = new System.Drawing.Size(175, 21);
            this.cmbCos_TipoCosto.TabIndex = 2;
            // 
            // lblTipoMonto
            // 
            this.lblTipoMonto.AutoSize = true;
            this.lblTipoMonto.Location = new System.Drawing.Point(3, 10);
            this.lblTipoMonto.Name = "lblTipoMonto";
            this.lblTipoMonto.Size = new System.Drawing.Size(64, 13);
            this.lblTipoMonto.TabIndex = 1;
            this.lblTipoMonto.Text = "Tipo Monto:";
            // 
            // txtCos_Monto
            // 
            this.txtCos_Monto.Location = new System.Drawing.Point(73, 34);
            this.txtCos_Monto.Name = "txtCos_Monto";
            this.txtCos_Monto.Size = new System.Drawing.Size(116, 20);
            this.txtCos_Monto.TabIndex = 0;
            // 
            // tbpRecojer
            // 
            this.tbpRecojer.Controls.Add(this.dtgCli_AutRec);
            this.tbpRecojer.Location = new System.Drawing.Point(4, 22);
            this.tbpRecojer.Name = "tbpRecojer";
            this.tbpRecojer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRecojer.Size = new System.Drawing.Size(488, 199);
            this.tbpRecojer.TabIndex = 1;
            this.tbpRecojer.Text = "Personas que pueden recojer";
            this.tbpRecojer.UseVisualStyleBackColor = true;
            // 
            // dtgCli_AutRec
            // 
            this.dtgCli_AutRec.AllowUserToAddRows = false;
            this.dtgCli_AutRec.AllowUserToDeleteRows = false;
            this.dtgCli_AutRec.AllowUserToResizeRows = false;
            this.dtgCli_AutRec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCli_AutRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgCli_AutRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCli_AutRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgCNombre,
            this.dtgCRFC,
            this.dtgCCURP,
            this.dtgCTelefono,
            this.dtgCCorreo,
            this.dtgCEstado});
            this.dtgCli_AutRec.Location = new System.Drawing.Point(6, 6);
            this.dtgCli_AutRec.MultiSelect = false;
            this.dtgCli_AutRec.Name = "dtgCli_AutRec";
            this.dtgCli_AutRec.RowHeadersVisible = false;
            this.dtgCli_AutRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCli_AutRec.ShowCellErrors = false;
            this.dtgCli_AutRec.ShowCellToolTips = false;
            this.dtgCli_AutRec.ShowEditingIcon = false;
            this.dtgCli_AutRec.ShowRowErrors = false;
            this.dtgCli_AutRec.Size = new System.Drawing.Size(476, 187);
            this.dtgCli_AutRec.TabIndex = 1;
            // 
            // dtgCNombre
            // 
            this.dtgCNombre.DataPropertyName = "sNombreCompleto";
            this.dtgCNombre.HeaderText = "Nombre";
            this.dtgCNombre.Name = "dtgCNombre";
            this.dtgCNombre.ReadOnly = true;
            this.dtgCNombre.Width = 69;
            // 
            // dtgCRFC
            // 
            this.dtgCRFC.DataPropertyName = "sRFC";
            this.dtgCRFC.HeaderText = "RFC";
            this.dtgCRFC.Name = "dtgCRFC";
            this.dtgCRFC.ReadOnly = true;
            this.dtgCRFC.Width = 53;
            // 
            // dtgCCURP
            // 
            this.dtgCCURP.DataPropertyName = "sCURP";
            this.dtgCCURP.HeaderText = "CURP";
            this.dtgCCURP.Name = "dtgCCURP";
            this.dtgCCURP.ReadOnly = true;
            this.dtgCCURP.Width = 62;
            // 
            // dtgCTelefono
            // 
            this.dtgCTelefono.DataPropertyName = "sTelefono";
            this.dtgCTelefono.HeaderText = "Telefono";
            this.dtgCTelefono.Name = "dtgCTelefono";
            this.dtgCTelefono.ReadOnly = true;
            this.dtgCTelefono.Width = 74;
            // 
            // dtgCCorreo
            // 
            this.dtgCCorreo.DataPropertyName = "sCorreo";
            this.dtgCCorreo.HeaderText = "Correo";
            this.dtgCCorreo.Name = "dtgCCorreo";
            this.dtgCCorreo.ReadOnly = true;
            this.dtgCCorreo.Width = 63;
            // 
            // dtgCEstado
            // 
            this.dtgCEstado.DataPropertyName = "bEstdo";
            this.dtgCEstado.HeaderText = "Estado";
            this.dtgCEstado.Name = "dtgCEstado";
            this.dtgCEstado.ReadOnly = true;
            this.dtgCEstado.Width = 46;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(463, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(34, 32);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Modificar...";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // epTaller
            // 
            this.epTaller.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::AppElectronica.Properties.Resources.Limpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Location = new System.Drawing.Point(463, 141);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(34, 29);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Tag = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevoTipoEquipo
            // 
            this.btnNuevoTipoEquipo.BackgroundImage = global::AppElectronica.Properties.Resources.Agregar;
            this.btnNuevoTipoEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoTipoEquipo.Location = new System.Drawing.Point(269, 68);
            this.btnNuevoTipoEquipo.Name = "btnNuevoTipoEquipo";
            this.btnNuevoTipoEquipo.Size = new System.Drawing.Size(33, 23);
            this.btnNuevoTipoEquipo.TabIndex = 8;
            this.btnNuevoTipoEquipo.Tag = "Alta de nuevo equipo";
            this.btnNuevoTipoEquipo.UseVisualStyleBackColor = true;
            this.btnNuevoTipoEquipo.Click += new System.EventHandler(this.btnNuevoTipoEquipo_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = global::AppElectronica.Properties.Resources.Buscar;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.Location = new System.Drawing.Point(191, 13);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(20, 20);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(357, 71);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(144, 21);
            this.cmbEstado.TabIndex = 19;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(308, 74);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado:";
            // 
            // frmEquipoElectronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 441);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tbcEquipoElectronico);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnNuevoTipoEquipo);
            this.Controls.Add(this.cmbTipoEquipo);
            this.Controls.Add(this.lblTipoEquipo);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblCURP);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Name = "frmEquipoElectronico";
            this.Text = "frmEquipoElectronico";
            this.Load += new System.EventHandler(this.frmEquipoElectronico_Load);
            this.tbcEquipoElectronico.ResumeLayout(false);
            this.tbpCostos.ResumeLayout(false);
            this.tbpCostos.PerformLayout();
            this.gbObservaciones.ResumeLayout(false);
            this.gbObservaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquElec_Costos)).EndInit();
            this.tbpRecojer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCli_AutRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTaller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label lblCURP;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblTipoEquipo;
        private System.Windows.Forms.ComboBox cmbTipoEquipo;
        private System.Windows.Forms.Button btnNuevoTipoEquipo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TabControl tbcEquipoElectronico;
        private System.Windows.Forms.TabPage tbpCostos;
        private System.Windows.Forms.TabPage tbpRecojer;
        private System.Windows.Forms.TextBox txtCos_Monto;
        private System.Windows.Forms.ComboBox cmbCos_TipoCosto;
        private System.Windows.Forms.Label lblTipoMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.DataGridView dgvEquElec_Costos;
        private System.Windows.Forms.Button btnMonto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgCli_AutRec;
        private System.Windows.Forms.ErrorProvider epTaller;
        private System.Windows.Forms.GroupBox gbObservaciones;
        private System.Windows.Forms.TextBox txtCos_Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCCURP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCCorreo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtgCEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRegEqui_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRegEqui_TipoMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRegEqui_PoCobrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRegEqui_Cobrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRegEqui_Observacion;
        private System.Windows.Forms.DataGridViewImageColumn clRegEqui_ButtonBorrar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}