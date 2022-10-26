using System;
using System.Windows.Forms;

namespace Aplicacion_Electronica.Formas
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
                this.btnSeg_Guardar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Agregar;
                this.btnSeg_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Cambios)
            {
                this.btnSeg_Guardar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Actualizar;
                this.btnSeg_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Bajas)
            {
                this.btnSeg_Guardar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Borrar;
                this.btnSeg_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
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
        private void EstadoComponentes(bool bolEstado)
        {
            txtSeg_Apellido1.ReadOnly = bolEstado;
            txtSeg_Apellido2.ReadOnly = bolEstado;
            txtSeg_Nombre.ReadOnly = bolEstado;
            txtSeg_Usuario.ReadOnly = bolEstado;
            txtSeg_Contrasenia.ReadOnly = bolEstado;
            ckbSeg_Estado.Enabled = !bolEstado;
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
            EstadoComponentes(true);
            switch (accionPant)
            {
                case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:
                    LlenaDatos();
                    break;
                case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
                    LlenaDatos();
                    EstadoComponentes(false);
                    break;
                case Electronica_Entidades.enumTextos.AccionPantalla.Alta:
                    EstadoComponentes(false);
                    break;
            }
            validaCampos();
        }

        private void btnSeg_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            switch (accionPant)
            {
                case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:
                    LlenaDatos();
                    break;
                case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
                    LlenaDatos();
                    break;
            }
        }

        private void btnSeg_Guardar_Click(object sender, EventArgs e)
        {
            Electronica_AccesoBD.manejoSeguridad mSeg = null;
            try
            {
                mSeg = new Electronica_AccesoBD.manejoSeguridad();

                if (epSeguridad.GetError(txtSeg_Apellido1).Trim() != "" || epSeguridad.GetError(txtSeg_Nombre).Trim() != "" ||
                    epSeguridad.GetError(txtSeg_Usuario).Trim() != "" || epSeguridad.GetError(txtSeg_Contrasenia).Trim() != "")
                    throw new ApplicationException("Favor de validar los campos con una alerta de color rojo");

                
                switch (accionPant)
                {
                    case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:
                        mSeg.ActualizaUsuario(itemAlterar.nId, itemAlterar.sApellido1, itemAlterar.sApellido2, itemAlterar.sNombre, itemAlterar.sUsuario, itemAlterar.sContrasenia, false);
                        break;
                    case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
                        mSeg.ActualizaUsuario(itemAlterar.nId, txtSeg_Apellido1.Text.Trim(), txtSeg_Apellido2.Text.Trim(), txtSeg_Nombre.Text.Trim(), txtSeg_Usuario.Text.Trim(), txtSeg_Contrasenia.Text.Trim(), ckbSeg_Estado.Checked);
                        break;
                    case Electronica_Entidades.enumTextos.AccionPantalla.Alta:
                        mSeg.AltaUsuario(txtSeg_Apellido1.Text.Trim(), txtSeg_Apellido2.Text.Trim(), txtSeg_Nombre.Text.Trim(), txtSeg_Usuario.Text.Trim(), txtSeg_Contrasenia.Text.Trim(), true);
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
            finally
            {
                mSeg.Finaliza();
            }
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
