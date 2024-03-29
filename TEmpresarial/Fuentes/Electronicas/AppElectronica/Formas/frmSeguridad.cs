﻿using System;
using System.Windows.Forms;
using mRN = Electronica_ReglasNegocio;

namespace AppElectronica.Formas
{
    public partial class frmSeguridad : Form
    {
        public frmSeguridad(string sTituloPantalla, Electronica_Entidades.enumTextos.AccionPantalla accionpant)
        {
            InitializeComponent();
            this.Text = sTituloPantalla;
            accionPant = accionpant;
            btnSeg_Guardar.Text = "";
            if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Alta)
            {
                this.btnSeg_Guardar.BackgroundImage = global::AppElectronica.Properties.Resources.Agregar;
                this.btnSeg_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Cambios)
            {
                this.btnSeg_Guardar.BackgroundImage = global::AppElectronica.Properties.Resources.Actualizar;
                this.btnSeg_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            //else if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Bajas)
            //{
            //    this.btnSeg_Guardar.BackgroundImage = global::AppElectronica.Properties.Resources.Borrar;
            //    this.btnSeg_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //}
        }

        public Electronica_Entidades.enumTextos.AccionPantalla accionPant { get; set; }
        public Electronica_Entidades.entSeguridad itemAlterar { get; set; }

        private void Limpiar()
        {
            txtSeg_Apellido1.Text = "";
            txtSeg_Apellido2.Text = "";
            txtSeg_Nombre.Text = "";
            txtSeg_Usuario.Text = "";
            txtSeg_Contrasenia.Text = "";
            ckbSeg_Estado.Checked = false;
        }
        private void LlenaDatos()
        {
            txtSeg_Apellido1.Text = itemAlterar.sApellido1.Trim();
            txtSeg_Apellido2.Text = itemAlterar.sApellido2.Trim();
            txtSeg_Nombre.Text = itemAlterar.sNombre.Trim();
            txtSeg_Usuario.Text = itemAlterar.sUsuario.Trim();
            txtSeg_Contrasenia.Text = itemAlterar.sContrasenia.Trim();
            ckbSeg_Estado.Checked = itemAlterar.bEstado;
        }
        private void EstadoComponentes() // bool bolEstado)
        {
            txtSeg_Apellido1.ReadOnly = !itemAlterar.bEstado; // bolEstado;
            txtSeg_Apellido2.ReadOnly = !itemAlterar.bEstado; // bolEstado;
            txtSeg_Nombre.ReadOnly = !itemAlterar.bEstado; // bolEstado;
            txtSeg_Usuario.ReadOnly = !itemAlterar.bEstado; // bolEstado;
            txtSeg_Contrasenia.ReadOnly = !itemAlterar.bEstado; // bolEstado;
            //ckbSeg_Estado.Enabled = itemAlterar.bEstado; // bolEstado;
        }
        private void validaCampos()
        {
            epSeguridad.Clear();
            if (txtSeg_Apellido1.Text.Trim() == "") epSeguridad.SetError(txtSeg_Apellido1, "Favor de especificar Apellido Paterno.");
            if (txtSeg_Nombre.Text.Trim() == "") epSeguridad.SetError(txtSeg_Nombre, "Favor de especificar Nombre.");
            if (txtSeg_Usuario.Text.Trim() == "") epSeguridad.SetError(txtSeg_Usuario, "Favor de especificar Usuario.");
            if (txtSeg_Contrasenia.Text.Trim() == "") epSeguridad.SetError(txtSeg_Contrasenia, "Favor de especificar Contraseña.");
        }

        private void frmSeguridad_Load(object sender, EventArgs e)
        {
            Limpiar();
            if (accionPant == Electronica_Entidades.enumTextos.AccionPantalla.Cambios)
            {
                LlenaDatos();
            }
            else
            {
                itemAlterar = new Electronica_Entidades.entSeguridad() { bEstado = true };
            }
            //switch (accionPant)
            //{
            //    case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:
            //        LlenaDatos();
            //        break;
            //    case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
            //        LlenaDatos();        
            //        EstadoComponentes(false);
            //        break;
            //    case Electronica_Entidades.enumTextos.AccionPantalla.Alta:
            //        EstadoComponentes(false);
            //        break;
            //}

            EstadoComponentes(); // true);
            validaCampos();
        }

        private void btnSeg_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LlenaDatos();
            //switch (accionPant)
            //{
            //    case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:
            //        LlenaDatos();
            //        break;
            //    case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
            //        LlenaDatos();
            //        break;
            //}
        }

        private void btnSeg_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (epSeguridad.GetError(txtSeg_Apellido1).Trim() != "" || epSeguridad.GetError(txtSeg_Nombre).Trim() != "" ||
                    epSeguridad.GetError(txtSeg_Usuario).Trim() != "" || epSeguridad.GetError(txtSeg_Contrasenia).Trim() != "")
                    throw new ApplicationException("Favor de validar los campos con una alerta de color rojo");

                
                switch (accionPant)
                {
                    //case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:
                    //    mRN.mUsuarios.ActualizaUsuario(itemAlterar.nId, itemAlterar.sApellido1, itemAlterar.sApellido2, itemAlterar.sNombre, itemAlterar.sUsuario, itemAlterar.sContrasenia, ckbSeg_Estado.Checked);
                    //    break;
                    case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
                        mRN.mUsuarios.ActualizaUsuario(itemAlterar.nId, txtSeg_Apellido1.Text.Trim(), txtSeg_Apellido2.Text.Trim(), txtSeg_Nombre.Text.Trim(), txtSeg_Usuario.Text.Trim(), txtSeg_Contrasenia.Text.Trim(), ckbSeg_Estado.Checked);
                        break;
                    case Electronica_Entidades.enumTextos.AccionPantalla.Alta:
                        mRN.mUsuarios.AltaUsuario(txtSeg_Apellido1.Text.Trim(), txtSeg_Apellido2.Text.Trim(), txtSeg_Nombre.Text.Trim(), txtSeg_Usuario.Text.Trim(), txtSeg_Contrasenia.Text.Trim(), true);
                        break;
                }

                MessageBox.Show("La operación fue realizada satisfactoriamente.", "Operacion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Validacion de campos.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
        }

        private void txtSeg_Apellido1_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
        private void txtSeg_Apellido2_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
        private void txtSeg_Nombre_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
        private void txtSeg_Usuario_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
        private void txtSeg_Contrasenia_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
    }
}
