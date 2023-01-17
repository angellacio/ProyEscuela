namespace AppElectronica.Formas
{
    partial class frmSeguridad
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
            this.lblSeg_Contrasenia = new System.Windows.Forms.Label();
            this.txtSeg_Contrasenia = new System.Windows.Forms.TextBox();
            this.txtSeg_Nombre = new System.Windows.Forms.TextBox();
            this.lblSeg_Usuario = new System.Windows.Forms.Label();
            this.lblSeg_nombre = new System.Windows.Forms.Label();
            this.txtSeg_Usuario = new System.Windows.Forms.TextBox();
            this.lblSeg_apellido1 = new System.Windows.Forms.Label();
            this.txtSeg_Apellido2 = new System.Windows.Forms.TextBox();
            this.lblSeg_apellido2 = new System.Windows.Forms.Label();
            this.txtSeg_Apellido1 = new System.Windows.Forms.TextBox();
            this.ckbSeg_Estado = new System.Windows.Forms.CheckBox();
            this.epSeguridad = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSeg_Guardar = new System.Windows.Forms.Button();
            this.btnSeg_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epSeguridad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeg_Contrasenia
            // 
            this.lblSeg_Contrasenia.Location = new System.Drawing.Point(244, 86);
            this.lblSeg_Contrasenia.Name = "lblSeg_Contrasenia";
            this.lblSeg_Contrasenia.Size = new System.Drawing.Size(72, 20);
            this.lblSeg_Contrasenia.TabIndex = 31;
            this.lblSeg_Contrasenia.Text = "Contraseña:";
            this.lblSeg_Contrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSeg_Contrasenia
            // 
            this.txtSeg_Contrasenia.Location = new System.Drawing.Point(322, 87);
            this.txtSeg_Contrasenia.MaxLength = 16;
            this.txtSeg_Contrasenia.Name = "txtSeg_Contrasenia";
            this.txtSeg_Contrasenia.PasswordChar = '*';
            this.txtSeg_Contrasenia.Size = new System.Drawing.Size(128, 20);
            this.txtSeg_Contrasenia.TabIndex = 50;
            this.txtSeg_Contrasenia.TextChanged += new System.EventHandler(this.txtSeg_Contrasenia_TextChanged);
            // 
            // txtSeg_Nombre
            // 
            this.txtSeg_Nombre.Location = new System.Drawing.Point(121, 60);
            this.txtSeg_Nombre.MaxLength = 250;
            this.txtSeg_Nombre.Name = "txtSeg_Nombre";
            this.txtSeg_Nombre.Size = new System.Drawing.Size(205, 20);
            this.txtSeg_Nombre.TabIndex = 30;
            this.txtSeg_Nombre.TextChanged += new System.EventHandler(this.txtSeg_Nombre_TextChanged);
            // 
            // lblSeg_Usuario
            // 
            this.lblSeg_Usuario.Location = new System.Drawing.Point(12, 85);
            this.lblSeg_Usuario.Name = "lblSeg_Usuario";
            this.lblSeg_Usuario.Size = new System.Drawing.Size(103, 20);
            this.lblSeg_Usuario.TabIndex = 26;
            this.lblSeg_Usuario.Text = "Usuario: ";
            this.lblSeg_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeg_nombre
            // 
            this.lblSeg_nombre.Location = new System.Drawing.Point(12, 60);
            this.lblSeg_nombre.Name = "lblSeg_nombre";
            this.lblSeg_nombre.Size = new System.Drawing.Size(103, 20);
            this.lblSeg_nombre.TabIndex = 23;
            this.lblSeg_nombre.Text = "Nombre: ";
            this.lblSeg_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSeg_Usuario
            // 
            this.txtSeg_Usuario.Location = new System.Drawing.Point(121, 86);
            this.txtSeg_Usuario.MaxLength = 8;
            this.txtSeg_Usuario.Name = "txtSeg_Usuario";
            this.txtSeg_Usuario.Size = new System.Drawing.Size(117, 20);
            this.txtSeg_Usuario.TabIndex = 40;
            this.txtSeg_Usuario.TextChanged += new System.EventHandler(this.txtSeg_Usuario_TextChanged);
            // 
            // lblSeg_apellido1
            // 
            this.lblSeg_apellido1.Location = new System.Drawing.Point(12, 9);
            this.lblSeg_apellido1.Name = "lblSeg_apellido1";
            this.lblSeg_apellido1.Size = new System.Drawing.Size(103, 17);
            this.lblSeg_apellido1.TabIndex = 24;
            this.lblSeg_apellido1.Text = "Apellido Paterno:";
            this.lblSeg_apellido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSeg_Apellido2
            // 
            this.txtSeg_Apellido2.Location = new System.Drawing.Point(121, 34);
            this.txtSeg_Apellido2.MaxLength = 150;
            this.txtSeg_Apellido2.Name = "txtSeg_Apellido2";
            this.txtSeg_Apellido2.Size = new System.Drawing.Size(195, 20);
            this.txtSeg_Apellido2.TabIndex = 20;
            this.txtSeg_Apellido2.TextChanged += new System.EventHandler(this.txtSeg_Apellido2_TextChanged);
            // 
            // lblSeg_apellido2
            // 
            this.lblSeg_apellido2.Location = new System.Drawing.Point(12, 35);
            this.lblSeg_apellido2.Name = "lblSeg_apellido2";
            this.lblSeg_apellido2.Size = new System.Drawing.Size(103, 17);
            this.lblSeg_apellido2.TabIndex = 25;
            this.lblSeg_apellido2.Text = "Apellido Materno:";
            this.lblSeg_apellido2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSeg_Apellido1
            // 
            this.txtSeg_Apellido1.Location = new System.Drawing.Point(121, 8);
            this.txtSeg_Apellido1.MaxLength = 150;
            this.txtSeg_Apellido1.Name = "txtSeg_Apellido1";
            this.txtSeg_Apellido1.Size = new System.Drawing.Size(195, 20);
            this.txtSeg_Apellido1.TabIndex = 10;
            this.txtSeg_Apellido1.TextChanged += new System.EventHandler(this.txtSeg_Apellido1_TextChanged);
            // 
            // ckbSeg_Estado
            // 
            this.ckbSeg_Estado.AutoSize = true;
            this.ckbSeg_Estado.Checked = true;
            this.ckbSeg_Estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSeg_Estado.Location = new System.Drawing.Point(364, 64);
            this.ckbSeg_Estado.Name = "ckbSeg_Estado";
            this.ckbSeg_Estado.Size = new System.Drawing.Size(56, 17);
            this.ckbSeg_Estado.TabIndex = 80;
            this.ckbSeg_Estado.Text = "Activo";
            this.ckbSeg_Estado.UseVisualStyleBackColor = true;
            // 
            // epSeguridad
            // 
            this.epSeguridad.ContainerControl = this;
            // 
            // btnSeg_Guardar
            // 
            this.btnSeg_Guardar.Location = new System.Drawing.Point(372, 6);
            this.btnSeg_Guardar.Name = "btnSeg_Guardar";
            this.btnSeg_Guardar.Size = new System.Drawing.Size(36, 23);
            this.btnSeg_Guardar.TabIndex = 82;
            this.btnSeg_Guardar.Text = "Guardar...";
            this.btnSeg_Guardar.UseVisualStyleBackColor = true;
            this.btnSeg_Guardar.Click += new System.EventHandler(this.btnSeg_Guardar_Click);
            // 
            // btnSeg_Limpiar
            // 
            this.btnSeg_Limpiar.BackgroundImage = global::AppElectronica.Properties.Resources.Limpiar;
            this.btnSeg_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeg_Limpiar.Location = new System.Drawing.Point(414, 5);
            this.btnSeg_Limpiar.Name = "btnSeg_Limpiar";
            this.btnSeg_Limpiar.Size = new System.Drawing.Size(36, 23);
            this.btnSeg_Limpiar.TabIndex = 81;
            this.btnSeg_Limpiar.UseVisualStyleBackColor = true;
            this.btnSeg_Limpiar.Click += new System.EventHandler(this.btnSeg_Limpiar_Click);
            // 
            // frmSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 115);
            this.Controls.Add(this.btnSeg_Guardar);
            this.Controls.Add(this.btnSeg_Limpiar);
            this.Controls.Add(this.ckbSeg_Estado);
            this.Controls.Add(this.lblSeg_Contrasenia);
            this.Controls.Add(this.txtSeg_Contrasenia);
            this.Controls.Add(this.txtSeg_Nombre);
            this.Controls.Add(this.lblSeg_Usuario);
            this.Controls.Add(this.lblSeg_nombre);
            this.Controls.Add(this.txtSeg_Usuario);
            this.Controls.Add(this.lblSeg_apellido1);
            this.Controls.Add(this.txtSeg_Apellido2);
            this.Controls.Add(this.lblSeg_apellido2);
            this.Controls.Add(this.txtSeg_Apellido1);
            this.Name = "frmSeguridad";
            this.Text = "frmSeguridad";
            this.Load += new System.EventHandler(this.frmSeguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epSeguridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeg_Contrasenia;
        private System.Windows.Forms.TextBox txtSeg_Contrasenia;
        private System.Windows.Forms.TextBox txtSeg_Nombre;
        private System.Windows.Forms.Label lblSeg_Usuario;
        private System.Windows.Forms.Label lblSeg_nombre;
        private System.Windows.Forms.TextBox txtSeg_Usuario;
        private System.Windows.Forms.Label lblSeg_apellido1;
        private System.Windows.Forms.TextBox txtSeg_Apellido2;
        private System.Windows.Forms.Label lblSeg_apellido2;
        private System.Windows.Forms.TextBox txtSeg_Apellido1;
        private System.Windows.Forms.CheckBox ckbSeg_Estado;
        private System.Windows.Forms.Button btnSeg_Limpiar;
        private System.Windows.Forms.Button btnSeg_Guardar;
        private System.Windows.Forms.ErrorProvider epSeguridad;
    }
}