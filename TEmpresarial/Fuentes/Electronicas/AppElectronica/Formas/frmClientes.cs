using System;
using System.Windows.Forms;
using mRN = Electronica_ReglasNegocio;

namespace Aplicacion_Electronica.Formas
{
    public partial class frmClientes : Form
    {
        public frmClientes(string sTituloPantalla, Electronica_Entidades.enumTextos.AccionPantalla accionpant)
        {
            InitializeComponent();
            this.Text = sTituloPantalla;
            accionPant = accionpant;
            btnGuardar.Text = "";
            if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Alta)
            {
                this.btnGuardar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Agregar;
                this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Cambios)
            {
                this.btnGuardar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Actualizar;
                this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Bajas)
            {
                this.btnGuardar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Borrar;
                this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
        }

        public Electronica_Entidades.enumTextos.AccionPantalla accionPant { get; set; }
        public Electronica_Entidades.entCliente itemAlterar { get; set; }

        private void Limpiar()
        {
            txtCli_Apellido1.Text = "";
            txtCli_Apellido2.Text = "";
            txtCli_Nombre.Text = "";
            txtCli_CURP.Text = "";
            txtCli_RFC.Text = "";
            txtCli_Telefono.Text = "";
            txtCli_Correo.Text = "";
            txtCli_Direccion.Text = "";

            txtCli_AutRecID.Text = "";
            txtCli_AutRecApellido1.Text = "";
            txtCli_AutRecApellido2.Text = "";
            dtgCli_AutRec.DataSource = null;

        }
        private void LlenaDatos()
        {
            txtCli_Apellido1.Text = itemAlterar.sApellido1.Trim();
            txtCli_Apellido2.Text = itemAlterar.sApellido2.Trim();
            txtCli_Nombre.Text = itemAlterar.sNombre.Trim();
            txtCli_CURP.Text = itemAlterar.sCURP.Trim();
            txtCli_RFC.Text = itemAlterar.sRFC.Trim();
            txtCli_Telefono.Text = itemAlterar.sTelefono.Trim();
            txtCli_Correo.Text = itemAlterar.sCorreo.Trim();
            txtCli_Direccion.Text = itemAlterar.sDireccion.Trim();
            ckbCli_Estado.Checked = itemAlterar.bEstdo;
            LlenaAutorizados();
        }
        private void LlenaAutorizados()
        {
            dtgCli_AutRec.DataSource = itemAlterar.lstAutorizados;
        }
        private void EstadoComponentes(bool bolEstado)
        {
            txtCli_Apellido1.ReadOnly = bolEstado;
            txtCli_Apellido2.ReadOnly = bolEstado;
            txtCli_Nombre.ReadOnly = bolEstado;
            txtCli_CURP.ReadOnly = bolEstado;
            txtCli_RFC.ReadOnly = bolEstado;
            txtCli_Telefono.ReadOnly = bolEstado;
            txtCli_Correo.ReadOnly = bolEstado;
            txtCli_Direccion.ReadOnly = bolEstado;
        }
        private void validaCampos()
        {
            epClientes.Clear();
            if (txtCli_Apellido1.Text.Trim() == "") epClientes.SetError(txtCli_Apellido1, "Favor de especificar Apellido Paterno.");
            if (txtCli_Apellido2.Text.Trim() == "") epClientes.SetError(txtCli_Apellido2, "Favor de especificar Apellido Materno.");
            if (txtCli_Nombre.Text.Trim() == "") epClientes.SetError(txtCli_Nombre, "Favor de especificar Nombre.");
            if (txtCli_RFC.Text.Trim() == "") epClientes.SetError(txtCli_RFC, "Favor de especificar RFC.");
            if (txtCli_Telefono.Text.Trim() == "") epClientes.SetError(txtCli_Telefono, "Favor de especificar Telefono.");
        }

        private void frmClientes_Load(object sender, EventArgs e)
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

        private void btnCli_Limpiar_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (epClientes.GetError(txtCli_Apellido1).Trim() != "" || epClientes.GetError(txtCli_Apellido2).Trim() != "" ||
                  epClientes.GetError(txtCli_Nombre).Trim() != "" || epClientes.GetError(txtCli_RFC).Trim() != "" ||
                  epClientes.GetError(txtCli_Telefono).Trim() != "")
                    throw new ApplicationException("Favor de validar los campos con una alerta de color rojo");

                switch (accionPant)
                {
                    case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:
                        mRN.mCliente.ActualizaCliente(itemAlterar.nId, itemAlterar.sApellido1, itemAlterar.sApellido2, itemAlterar.sNombre, itemAlterar.sCURP, itemAlterar.sRFC, itemAlterar.sTelefono, itemAlterar.sCorreo, itemAlterar.sDireccion, ckbCli_Estado.Checked);
                        break;
                    case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
                        mRN.mCliente.ActualizaCliente(itemAlterar.nId, txtCli_Apellido1.Text.Trim(), txtCli_Apellido2.Text.Trim(), txtCli_Nombre.Text.Trim(), txtCli_CURP.Text.Trim().ToUpper(), txtCli_RFC.Text.Trim().ToUpper(), txtCli_Telefono.Text.Trim(), txtCli_Correo.Text.Trim(), txtCli_Direccion.Text.Trim(), ckbCli_Estado.Checked);
                        break;
                    case Electronica_Entidades.enumTextos.AccionPantalla.Alta:
                        mRN.mCliente.AltaCliente(txtCli_Apellido1.Text.Trim(), txtCli_Apellido2.Text.Trim(), txtCli_Nombre.Text.Trim(), txtCli_CURP.Text.Trim().ToUpper(), txtCli_RFC.Text.Trim().ToUpper(), txtCli_Telefono.Text.Trim(), txtCli_Correo.Text.Trim(), txtCli_Direccion.Text.Trim(), true);
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

        private void btnCli_Buscar_Click(object sender, EventArgs e)
        {
            frmCliente_Busqueda frmSerchCliente = null;

            frmSerchCliente = new frmCliente_Busqueda();
            frmSerchCliente.nIDCliente = null;
            if (txtCli_AutRecID.Text.Trim() != "") frmSerchCliente.nIDCliente = int.Parse(txtCli_AutRecID.Text.Trim());
            frmSerchCliente.sApellido1 = txtCli_AutRecApellido1.Text.Trim();
            frmSerchCliente.sApellido2 = txtCli_AutRecApellido2.Text.Trim();
            frmSerchCliente.sNombre = "";

            frmSerchCliente.RealizarBusquedaClientes();
            if (frmSerchCliente.ShowDialog() == DialogResult.OK)
            {
                if (itemAlterar == null || itemAlterar.lstAutorizados == null) itemAlterar = new Electronica_Entidades.entCliente();
                itemAlterar.lstAutorizados.Add(frmSerchCliente.itemModificar);
                LlenaAutorizados();
            }
        }

        private void txtCli_Apellido1_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
        private void txtCli_Apellido2_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
        private void txtCli_Nombre_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
        private void txtCli_RFC_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
        private void txtCli_Telefono_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
    }
}
