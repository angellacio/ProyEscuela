namespace Aplicacion_Electronica
{
    partial class mdiInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mCli_Altas = new System.Windows.Forms.ToolStripMenuItem();
            this.mCli_Cambios = new System.Windows.Forms.ToolStripMenuItem();
            this.mCli_Bajas = new System.Windows.Forms.ToolStripMenuItem();
            this.mEquipoElectro = new System.Windows.Forms.ToolStripMenuItem();
            this.mEqui_Entradas = new System.Windows.Forms.ToolStripMenuItem();
            this.mEqui_Salidas = new System.Windows.Forms.ToolStripMenuItem();
            this.mReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.mRep_Recoje = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeg_Altas = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeg_Cambios = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeg_Bajas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.mVen_Cascada = new System.Windows.Forms.ToolStripMenuItem();
            this.mVen_Vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mVen_Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mVen_CerrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.mSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.tslUsuario,
            this.tslNombre});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCliente,
            this.mEquipoElectro,
            this.mReporte,
            this.mSeguridad,
            this.toolStripMenuItem1,
            this.mVentana,
            this.mSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mVentana;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "msAplicacion";
            // 
            // mCliente
            // 
            this.mCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCli_Altas,
            this.mCli_Cambios,
            this.mCli_Bajas});
            this.mCliente.Name = "mCliente";
            this.mCliente.Size = new System.Drawing.Size(61, 20);
            this.mCliente.Text = "Clientes";
            // 
            // mCli_Altas
            // 
            this.mCli_Altas.Image = global::Aplicacion_Electronica.Properties.Resources.Agregar;
            this.mCli_Altas.Name = "mCli_Altas";
            this.mCli_Altas.Size = new System.Drawing.Size(121, 22);
            this.mCli_Altas.Text = "Altas";
            this.mCli_Altas.Click += new System.EventHandler(this.mCli_Altas_Click);
            // 
            // mCli_Cambios
            // 
            this.mCli_Cambios.Name = "mCli_Cambios";
            this.mCli_Cambios.Size = new System.Drawing.Size(121, 22);
            this.mCli_Cambios.Text = "Cambios";
            this.mCli_Cambios.Click += new System.EventHandler(this.mCli_Cambios_Click);
            // 
            // mCli_Bajas
            // 
            this.mCli_Bajas.Image = global::Aplicacion_Electronica.Properties.Resources.Borrar;
            this.mCli_Bajas.Name = "mCli_Bajas";
            this.mCli_Bajas.Size = new System.Drawing.Size(121, 22);
            this.mCli_Bajas.Text = "Bajas";
            this.mCli_Bajas.Click += new System.EventHandler(this.mCli_Bajas_Click);
            // 
            // mEquipoElectro
            // 
            this.mEquipoElectro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEqui_Entradas,
            this.mEqui_Salidas});
            this.mEquipoElectro.Name = "mEquipoElectro";
            this.mEquipoElectro.Size = new System.Drawing.Size(128, 20);
            this.mEquipoElectro.Text = "Equipos electronicos";
            // 
            // mEqui_Entradas
            // 
            this.mEqui_Entradas.Image = global::Aplicacion_Electronica.Properties.Resources.Agregar;
            this.mEqui_Entradas.Name = "mEqui_Entradas";
            this.mEqui_Entradas.Size = new System.Drawing.Size(114, 22);
            this.mEqui_Entradas.Text = "Entrada";
            this.mEqui_Entradas.Click += new System.EventHandler(this.mEqui_Entradas_Click);
            // 
            // mEqui_Salidas
            // 
            this.mEqui_Salidas.Image = global::Aplicacion_Electronica.Properties.Resources.Borrar;
            this.mEqui_Salidas.Name = "mEqui_Salidas";
            this.mEqui_Salidas.Size = new System.Drawing.Size(114, 22);
            this.mEqui_Salidas.Text = "Salida";
            this.mEqui_Salidas.Click += new System.EventHandler(this.mEqui_Salidas_Click);
            // 
            // mReporte
            // 
            this.mReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRep_Recoje});
            this.mReporte.Name = "mReporte";
            this.mReporte.Size = new System.Drawing.Size(65, 20);
            this.mReporte.Text = "Reportes";
            // 
            // mRep_Recoje
            // 
            this.mRep_Recoje.Name = "mRep_Recoje";
            this.mRep_Recoje.Size = new System.Drawing.Size(156, 22);
            this.mRep_Recoje.Text = "Clientes equipo";
            this.mRep_Recoje.Click += new System.EventHandler(this.mRep_Recoje_Click);
            // 
            // mSeguridad
            // 
            this.mSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSeg_Altas,
            this.mSeg_Cambios,
            this.mSeg_Bajas});
            this.mSeguridad.Name = "mSeguridad";
            this.mSeguridad.Size = new System.Drawing.Size(72, 20);
            this.mSeguridad.Text = "Seguridad";
            // 
            // mSeg_Altas
            // 
            this.mSeg_Altas.Image = global::Aplicacion_Electronica.Properties.Resources.Agregar;
            this.mSeg_Altas.Name = "mSeg_Altas";
            this.mSeg_Altas.Size = new System.Drawing.Size(121, 22);
            this.mSeg_Altas.Text = "Altas";
            this.mSeg_Altas.Click += new System.EventHandler(this.mSeg_Altas_Click);
            // 
            // mSeg_Cambios
            // 
            this.mSeg_Cambios.Name = "mSeg_Cambios";
            this.mSeg_Cambios.Size = new System.Drawing.Size(121, 22);
            this.mSeg_Cambios.Text = "Cambios";
            this.mSeg_Cambios.Click += new System.EventHandler(this.mSeg_Cambios_Click);
            // 
            // mSeg_Bajas
            // 
            this.mSeg_Bajas.Image = global::Aplicacion_Electronica.Properties.Resources.Borrar;
            this.mSeg_Bajas.Name = "mSeg_Bajas";
            this.mSeg_Bajas.Size = new System.Drawing.Size(121, 22);
            this.mSeg_Bajas.Text = "Bajas";
            this.mSeg_Bajas.Click += new System.EventHandler(this.mSeg_Bajas_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // mVentana
            // 
            this.mVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mVen_Cascada,
            this.mVen_Vertical,
            this.mVen_Horizontal,
            this.mVen_CerrarTodo});
            this.mVentana.Name = "mVentana";
            this.mVentana.Size = new System.Drawing.Size(66, 20);
            this.mVentana.Text = "&Ventanas";
            // 
            // mVen_Cascada
            // 
            this.mVen_Cascada.Name = "mVen_Cascada";
            this.mVen_Cascada.Size = new System.Drawing.Size(175, 22);
            this.mVen_Cascada.Text = "&Cascada";
            this.mVen_Cascada.Click += new System.EventHandler(this.mVen_Cascada_Click);
            // 
            // mVen_Vertical
            // 
            this.mVen_Vertical.Name = "mVen_Vertical";
            this.mVen_Vertical.Size = new System.Drawing.Size(175, 22);
            this.mVen_Vertical.Text = "Mosaico &vertical";
            this.mVen_Vertical.Click += new System.EventHandler(this.mVen_Vertical_Click);
            // 
            // mVen_Horizontal
            // 
            this.mVen_Horizontal.Name = "mVen_Horizontal";
            this.mVen_Horizontal.Size = new System.Drawing.Size(175, 22);
            this.mVen_Horizontal.Text = "Mosaico &horizontal";
            this.mVen_Horizontal.Click += new System.EventHandler(this.mVen_Horizontal_Click);
            // 
            // mVen_CerrarTodo
            // 
            this.mVen_CerrarTodo.Name = "mVen_CerrarTodo";
            this.mVen_CerrarTodo.Size = new System.Drawing.Size(175, 22);
            this.mVen_CerrarTodo.Text = "C&errar todo";
            this.mVen_CerrarTodo.Click += new System.EventHandler(this.mVen_CerrarTodo_Click);
            // 
            // mSalir
            // 
            this.mSalir.Name = "mSalir";
            this.mSalir.Size = new System.Drawing.Size(41, 20);
            this.mSalir.Text = "Salir";
            this.mSalir.Click += new System.EventHandler(this.mSalir_Click);
            // 
            // tslUsuario
            // 
            this.tslUsuario.Name = "tslUsuario";
            this.tslUsuario.Size = new System.Drawing.Size(47, 17);
            this.tslUsuario.Text = "Usuario";
            // 
            // tslNombre
            // 
            this.tslNombre.Name = "tslNombre";
            this.tslNombre.Size = new System.Drawing.Size(51, 17);
            this.tslNombre.Text = "Nombre";
            // 
            // mdiInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "mdiInicio";
            this.Text = "¡¡¡¡¡¡ Electronica EUGENIO !!!!!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mdiInicio_FormClosing);
            this.Load += new System.EventHandler(this.mdiInicio_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mCliente;
        private System.Windows.Forms.ToolStripMenuItem mCli_Altas;
        private System.Windows.Forms.ToolStripMenuItem mCli_Cambios;
        private System.Windows.Forms.ToolStripMenuItem mCli_Bajas;
        private System.Windows.Forms.ToolStripMenuItem mEquipoElectro;
        private System.Windows.Forms.ToolStripMenuItem mEqui_Entradas;
        private System.Windows.Forms.ToolStripMenuItem mEqui_Salidas;
        private System.Windows.Forms.ToolStripMenuItem mReporte;
        private System.Windows.Forms.ToolStripMenuItem mRep_Recoje;
        private System.Windows.Forms.ToolStripMenuItem mSeguridad;
        private System.Windows.Forms.ToolStripMenuItem mSeg_Altas;
        private System.Windows.Forms.ToolStripMenuItem mSeg_Cambios;
        private System.Windows.Forms.ToolStripMenuItem mSeg_Bajas;
        private System.Windows.Forms.ToolStripMenuItem mSalir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mVentana;
        private System.Windows.Forms.ToolStripMenuItem mVen_Cascada;
        private System.Windows.Forms.ToolStripMenuItem mVen_Vertical;
        private System.Windows.Forms.ToolStripMenuItem mVen_Horizontal;
        private System.Windows.Forms.ToolStripMenuItem mVen_CerrarTodo;
        private System.Windows.Forms.ToolStripStatusLabel tslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tslNombre;
    }
}



