namespace AppElectronica.Formas
{
    partial class frmClientes
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
            this.tcClientes = new System.Windows.Forms.TabControl();
            this.tpCli_Contacto = new System.Windows.Forms.TabPage();
            this.txtCli_Direccion = new System.Windows.Forms.TextBox();
            this.lblCli_Telefono = new System.Windows.Forms.Label();
            this.lblCli_Direccion = new System.Windows.Forms.Label();
            this.txtCli_Telefono = new System.Windows.Forms.TextBox();
            this.lblCli_Correo = new System.Windows.Forms.Label();
            this.txtCli_Correo = new System.Windows.Forms.TextBox();
            this.tpCli_Relacion = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCli_AutRecApellido2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCli_AutRecApellido1 = new System.Windows.Forms.TextBox();
            this.gbCli_AutRecID = new System.Windows.Forms.GroupBox();
            this.txtCli_AutRecID = new System.Windows.Forms.TextBox();
            this.btnCli_Buscar = new System.Windows.Forms.Button();
            this.dtgCli_AutRec = new System.Windows.Forms.DataGridView();
            this.lblCli_RFC = new System.Windows.Forms.Label();
            this.txtCli_RFC = new System.Windows.Forms.TextBox();
            this.txtCli_Nombre = new System.Windows.Forms.TextBox();
            this.lblCli_CURP = new System.Windows.Forms.Label();
            this.lblCli_nombre = new System.Windows.Forms.Label();
            this.txtCli_CURP = new System.Windows.Forms.TextBox();
            this.lblCli_apellido1 = new System.Windows.Forms.Label();
            this.txtCli_Apellido2 = new System.Windows.Forms.TextBox();
            this.lblCli_apellido2 = new System.Windows.Forms.Label();
            this.txtCli_Apellido1 = new System.Windows.Forms.TextBox();
            this.epClientes = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCli_Limpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ckbCli_Estado = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tcClientes.SuspendLayout();
            this.tpCli_Contacto.SuspendLayout();
            this.tpCli_Relacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCli_AutRecID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCli_AutRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tcClientes
            // 
            this.tcClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcClientes.Controls.Add(this.tpCli_Contacto);
            this.tcClientes.Controls.Add(this.tpCli_Relacion);
            this.tcClientes.Location = new System.Drawing.Point(7, 109);
            this.tcClientes.Name = "tcClientes";
            this.tcClientes.SelectedIndex = 0;
            this.tcClientes.Size = new System.Drawing.Size(478, 156);
            this.tcClientes.TabIndex = 35;
            // 
            // tpCli_Contacto
            // 
            this.tpCli_Contacto.Controls.Add(this.txtCli_Direccion);
            this.tpCli_Contacto.Controls.Add(this.lblCli_Telefono);
            this.tpCli_Contacto.Controls.Add(this.lblCli_Direccion);
            this.tpCli_Contacto.Controls.Add(this.txtCli_Telefono);
            this.tpCli_Contacto.Controls.Add(this.lblCli_Correo);
            this.tpCli_Contacto.Controls.Add(this.txtCli_Correo);
            this.tpCli_Contacto.Location = new System.Drawing.Point(4, 22);
            this.tpCli_Contacto.Name = "tpCli_Contacto";
            this.tpCli_Contacto.Padding = new System.Windows.Forms.Padding(3);
            this.tpCli_Contacto.Size = new System.Drawing.Size(470, 130);
            this.tpCli_Contacto.TabIndex = 0;
            this.tpCli_Contacto.Text = "Datos de contacto";
            this.tpCli_Contacto.UseVisualStyleBackColor = true;
            // 
            // txtCli_Direccion
            // 
            this.txtCli_Direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCli_Direccion.Location = new System.Drawing.Point(106, 42);
            this.txtCli_Direccion.Multiline = true;
            this.txtCli_Direccion.Name = "txtCli_Direccion";
            this.txtCli_Direccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCli_Direccion.Size = new System.Drawing.Size(358, 82);
            this.txtCli_Direccion.TabIndex = 32;
            // 
            // lblCli_Telefono
            // 
            this.lblCli_Telefono.Location = new System.Drawing.Point(3, 13);
            this.lblCli_Telefono.Name = "lblCli_Telefono";
            this.lblCli_Telefono.Size = new System.Drawing.Size(97, 19);
            this.lblCli_Telefono.TabIndex = 24;
            this.lblCli_Telefono.Text = "Telefono:";
            this.lblCli_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCli_Direccion
            // 
            this.lblCli_Direccion.Location = new System.Drawing.Point(3, 42);
            this.lblCli_Direccion.Name = "lblCli_Direccion";
            this.lblCli_Direccion.Size = new System.Drawing.Size(97, 16);
            this.lblCli_Direccion.TabIndex = 32;
            this.lblCli_Direccion.Text = "Dirección:";
            this.lblCli_Direccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCli_Telefono
            // 
            this.txtCli_Telefono.Location = new System.Drawing.Point(106, 12);
            this.txtCli_Telefono.Name = "txtCli_Telefono";
            this.txtCli_Telefono.Size = new System.Drawing.Size(101, 20);
            this.txtCli_Telefono.TabIndex = 30;
            this.txtCli_Telefono.TextChanged += new System.EventHandler(this.txtCli_Telefono_TextChanged);
            // 
            // lblCli_Correo
            // 
            this.lblCli_Correo.Location = new System.Drawing.Point(224, 15);
            this.lblCli_Correo.Name = "lblCli_Correo";
            this.lblCli_Correo.Size = new System.Drawing.Size(48, 19);
            this.lblCli_Correo.TabIndex = 26;
            this.lblCli_Correo.Text = "Correo:";
            this.lblCli_Correo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCli_Correo
            // 
            this.txtCli_Correo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCli_Correo.Location = new System.Drawing.Point(278, 14);
            this.txtCli_Correo.Name = "txtCli_Correo";
            this.txtCli_Correo.Size = new System.Drawing.Size(186, 20);
            this.txtCli_Correo.TabIndex = 31;
            // 
            // tpCli_Relacion
            // 
            this.tpCli_Relacion.Controls.Add(this.groupBox2);
            this.tpCli_Relacion.Controls.Add(this.groupBox1);
            this.tpCli_Relacion.Controls.Add(this.gbCli_AutRecID);
            this.tpCli_Relacion.Controls.Add(this.btnCli_Buscar);
            this.tpCli_Relacion.Controls.Add(this.dtgCli_AutRec);
            this.tpCli_Relacion.Location = new System.Drawing.Point(4, 22);
            this.tpCli_Relacion.Name = "tpCli_Relacion";
            this.tpCli_Relacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpCli_Relacion.Size = new System.Drawing.Size(470, 130);
            this.tpCli_Relacion.TabIndex = 1;
            this.tpCli_Relacion.Text = "Autorizados a recoger";
            this.tpCli_Relacion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCli_AutRecApellido2);
            this.groupBox2.Location = new System.Drawing.Point(207, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 42);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apellido Materno";
            // 
            // txtCli_AutRecApellido2
            // 
            this.txtCli_AutRecApellido2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCli_AutRecApellido2.Location = new System.Drawing.Point(6, 15);
            this.txtCli_AutRecApellido2.Name = "txtCli_AutRecApellido2";
            this.txtCli_AutRecApellido2.Size = new System.Drawing.Size(108, 20);
            this.txtCli_AutRecApellido2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCli_AutRecApellido1);
            this.groupBox1.Location = new System.Drawing.Point(81, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 42);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apellido Paterno";
            // 
            // txtCli_AutRecApellido1
            // 
            this.txtCli_AutRecApellido1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCli_AutRecApellido1.Location = new System.Drawing.Point(6, 15);
            this.txtCli_AutRecApellido1.Name = "txtCli_AutRecApellido1";
            this.txtCli_AutRecApellido1.Size = new System.Drawing.Size(108, 20);
            this.txtCli_AutRecApellido1.TabIndex = 0;
            // 
            // gbCli_AutRecID
            // 
            this.gbCli_AutRecID.Controls.Add(this.txtCli_AutRecID);
            this.gbCli_AutRecID.Location = new System.Drawing.Point(7, 3);
            this.gbCli_AutRecID.Name = "gbCli_AutRecID";
            this.gbCli_AutRecID.Size = new System.Drawing.Size(68, 42);
            this.gbCli_AutRecID.TabIndex = 2;
            this.gbCli_AutRecID.TabStop = false;
            this.gbCli_AutRecID.Text = "ID Cliente";
            // 
            // txtCli_AutRecID
            // 
            this.txtCli_AutRecID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCli_AutRecID.Location = new System.Drawing.Point(6, 15);
            this.txtCli_AutRecID.Name = "txtCli_AutRecID";
            this.txtCli_AutRecID.Size = new System.Drawing.Size(56, 20);
            this.txtCli_AutRecID.TabIndex = 0;
            // 
            // btnCli_Buscar
            // 
            this.btnCli_Buscar.BackgroundImage = global::AppElectronica.Properties.Resources.Buscar;
            this.btnCli_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCli_Buscar.Location = new System.Drawing.Point(409, 16);
            this.btnCli_Buscar.Name = "btnCli_Buscar";
            this.btnCli_Buscar.Size = new System.Drawing.Size(30, 23);
            this.btnCli_Buscar.TabIndex = 1;
            this.btnCli_Buscar.UseVisualStyleBackColor = true;
            this.btnCli_Buscar.Click += new System.EventHandler(this.btnCli_Buscar_Click);
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
            this.Id,
            this.Nombre,
            this.RFC,
            this.Eliminar});
            this.dtgCli_AutRec.Location = new System.Drawing.Point(7, 51);
            this.dtgCli_AutRec.MultiSelect = false;
            this.dtgCli_AutRec.Name = "dtgCli_AutRec";
            this.dtgCli_AutRec.RowHeadersVisible = false;
            this.dtgCli_AutRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCli_AutRec.ShowCellErrors = false;
            this.dtgCli_AutRec.ShowCellToolTips = false;
            this.dtgCli_AutRec.ShowEditingIcon = false;
            this.dtgCli_AutRec.ShowRowErrors = false;
            this.dtgCli_AutRec.Size = new System.Drawing.Size(457, 73);
            this.dtgCli_AutRec.TabIndex = 0;
            this.dtgCli_AutRec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCli_AutRec_CellClick);
            // 
            // lblCli_RFC
            // 
            this.lblCli_RFC.Location = new System.Drawing.Point(274, 86);
            this.lblCli_RFC.Name = "lblCli_RFC";
            this.lblCli_RFC.Size = new System.Drawing.Size(72, 20);
            this.lblCli_RFC.TabIndex = 33;
            this.lblCli_RFC.Text = "RFC: ";
            this.lblCli_RFC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCli_RFC
            // 
            this.txtCli_RFC.Location = new System.Drawing.Point(352, 87);
            this.txtCli_RFC.Name = "txtCli_RFC";
            this.txtCli_RFC.Size = new System.Drawing.Size(98, 20);
            this.txtCli_RFC.TabIndex = 34;
            this.txtCli_RFC.TextChanged += new System.EventHandler(this.txtCli_RFC_TextChanged);
            // 
            // txtCli_Nombre
            // 
            this.txtCli_Nombre.Location = new System.Drawing.Point(121, 60);
            this.txtCli_Nombre.Name = "txtCli_Nombre";
            this.txtCli_Nombre.Size = new System.Drawing.Size(225, 20);
            this.txtCli_Nombre.TabIndex = 31;
            this.txtCli_Nombre.TextChanged += new System.EventHandler(this.txtCli_Nombre_TextChanged);
            // 
            // lblCli_CURP
            // 
            this.lblCli_CURP.Location = new System.Drawing.Point(12, 85);
            this.lblCli_CURP.Name = "lblCli_CURP";
            this.lblCli_CURP.Size = new System.Drawing.Size(103, 20);
            this.lblCli_CURP.TabIndex = 28;
            this.lblCli_CURP.Text = "CURP: ";
            this.lblCli_CURP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCli_nombre
            // 
            this.lblCli_nombre.Location = new System.Drawing.Point(12, 60);
            this.lblCli_nombre.Name = "lblCli_nombre";
            this.lblCli_nombre.Size = new System.Drawing.Size(103, 20);
            this.lblCli_nombre.TabIndex = 25;
            this.lblCli_nombre.Text = "Nombre: ";
            this.lblCli_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCli_CURP
            // 
            this.txtCli_CURP.Location = new System.Drawing.Point(121, 86);
            this.txtCli_CURP.Name = "txtCli_CURP";
            this.txtCli_CURP.Size = new System.Drawing.Size(150, 20);
            this.txtCli_CURP.TabIndex = 32;
            // 
            // lblCli_apellido1
            // 
            this.lblCli_apellido1.Location = new System.Drawing.Point(12, 9);
            this.lblCli_apellido1.Name = "lblCli_apellido1";
            this.lblCli_apellido1.Size = new System.Drawing.Size(103, 17);
            this.lblCli_apellido1.TabIndex = 26;
            this.lblCli_apellido1.Text = "Apellido Paterno:";
            this.lblCli_apellido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCli_Apellido2
            // 
            this.txtCli_Apellido2.Location = new System.Drawing.Point(121, 34);
            this.txtCli_Apellido2.Name = "txtCli_Apellido2";
            this.txtCli_Apellido2.Size = new System.Drawing.Size(225, 20);
            this.txtCli_Apellido2.TabIndex = 30;
            this.txtCli_Apellido2.TextChanged += new System.EventHandler(this.txtCli_Apellido2_TextChanged);
            // 
            // lblCli_apellido2
            // 
            this.lblCli_apellido2.Location = new System.Drawing.Point(12, 35);
            this.lblCli_apellido2.Name = "lblCli_apellido2";
            this.lblCli_apellido2.Size = new System.Drawing.Size(103, 17);
            this.lblCli_apellido2.TabIndex = 27;
            this.lblCli_apellido2.Text = "Apellido Materno:";
            this.lblCli_apellido2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCli_Apellido1
            // 
            this.txtCli_Apellido1.Location = new System.Drawing.Point(121, 8);
            this.txtCli_Apellido1.Name = "txtCli_Apellido1";
            this.txtCli_Apellido1.Size = new System.Drawing.Size(225, 20);
            this.txtCli_Apellido1.TabIndex = 29;
            this.txtCli_Apellido1.TextChanged += new System.EventHandler(this.txtCli_Apellido1_TextChanged);
            // 
            // epClientes
            // 
            this.epClientes.ContainerControl = this;
            // 
            // btnCli_Limpiar
            // 
            this.btnCli_Limpiar.BackgroundImage = global::AppElectronica.Properties.Resources.Limpiar;
            this.btnCli_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCli_Limpiar.Location = new System.Drawing.Point(454, 12);
            this.btnCli_Limpiar.Name = "btnCli_Limpiar";
            this.btnCli_Limpiar.Size = new System.Drawing.Size(36, 23);
            this.btnCli_Limpiar.TabIndex = 36;
            this.btnCli_Limpiar.UseVisualStyleBackColor = true;
            this.btnCli_Limpiar.Click += new System.EventHandler(this.btnCli_Limpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(414, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(36, 23);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ckbCli_Estado
            // 
            this.ckbCli_Estado.AutoSize = true;
            this.ckbCli_Estado.Location = new System.Drawing.Point(420, 111);
            this.ckbCli_Estado.Name = "ckbCli_Estado";
            this.ckbCli_Estado.Size = new System.Drawing.Size(56, 17);
            this.ckbCli_Estado.TabIndex = 38;
            this.ckbCli_Estado.Text = "Activo";
            this.ckbCli_Estado.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "nId";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 43;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "sNombreCompleto";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 69;
            // 
            // RFC
            // 
            this.RFC.DataPropertyName = "sRFC";
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            this.RFC.Width = 53;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Eliminar.HeaderText = "Borrar";
            this.Eliminar.Image = global::AppElectronica.Properties.Resources.Borrar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Width = 41;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 277);
            this.Controls.Add(this.ckbCli_Estado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCli_Limpiar);
            this.Controls.Add(this.tcClientes);
            this.Controls.Add(this.lblCli_RFC);
            this.Controls.Add(this.txtCli_RFC);
            this.Controls.Add(this.txtCli_Nombre);
            this.Controls.Add(this.lblCli_CURP);
            this.Controls.Add(this.lblCli_nombre);
            this.Controls.Add(this.txtCli_CURP);
            this.Controls.Add(this.lblCli_apellido1);
            this.Controls.Add(this.txtCli_Apellido2);
            this.Controls.Add(this.lblCli_apellido2);
            this.Controls.Add(this.txtCli_Apellido1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.tcClientes.ResumeLayout(false);
            this.tpCli_Contacto.ResumeLayout(false);
            this.tpCli_Contacto.PerformLayout();
            this.tpCli_Relacion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCli_AutRecID.ResumeLayout(false);
            this.gbCli_AutRecID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCli_AutRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcClientes;
        private System.Windows.Forms.TabPage tpCli_Contacto;
        private System.Windows.Forms.TextBox txtCli_Direccion;
        private System.Windows.Forms.Label lblCli_Telefono;
        private System.Windows.Forms.Label lblCli_Direccion;
        private System.Windows.Forms.TextBox txtCli_Telefono;
        private System.Windows.Forms.Label lblCli_Correo;
        private System.Windows.Forms.TextBox txtCli_Correo;
        private System.Windows.Forms.TabPage tpCli_Relacion;
        private System.Windows.Forms.Label lblCli_RFC;
        private System.Windows.Forms.TextBox txtCli_RFC;
        private System.Windows.Forms.TextBox txtCli_Nombre;
        private System.Windows.Forms.Label lblCli_CURP;
        private System.Windows.Forms.Label lblCli_nombre;
        private System.Windows.Forms.TextBox txtCli_CURP;
        private System.Windows.Forms.Label lblCli_apellido1;
        private System.Windows.Forms.TextBox txtCli_Apellido2;
        private System.Windows.Forms.Label lblCli_apellido2;
        private System.Windows.Forms.TextBox txtCli_Apellido1;
        private System.Windows.Forms.ErrorProvider epClientes;
        private System.Windows.Forms.Button btnCli_Limpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox ckbCli_Estado;
        private System.Windows.Forms.Button btnCli_Buscar;
        private System.Windows.Forms.DataGridView dtgCli_AutRec;
        private System.Windows.Forms.GroupBox gbCli_AutRecID;
        private System.Windows.Forms.TextBox txtCli_AutRecID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCli_AutRecApellido2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCli_AutRecApellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}