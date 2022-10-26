using System;
using System.Windows.Forms;

namespace Aplicacion_Electronica.Formas
{
    public partial class frmClientes : Form
    {
        public frmClientes(string sTituloPantalla, Electronica_Entidades.enumTextos.AccionPantalla accionpant)
        {
            InitializeComponent();
            this.Text = sTituloPantalla;
            accionPant = accionpant;
        }

        public Electronica_Entidades.enumTextos.AccionPantalla accionPant { get; set; }
        public Electronica_Entidades.entClientes itemAlterar { get; set; }

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
                    btnGuardar.Text = "Baja";
                    break;
                case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
                    LlenaDatos();
                    EstadoComponentes(false);
                    btnGuardar.Text = "Modificar";
                    break;
                case Electronica_Entidades.enumTextos.AccionPantalla.Alta:
                    EstadoComponentes(false);
                    btnGuardar.Text = "Alta";
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
            switch (accionPant)
            {
                case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:

                    break;
                case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:

                    break;
                case Electronica_Entidades.enumTextos.AccionPantalla.Alta:

                    break;
            }
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
                if (itemAlterar == null || itemAlterar.lstAutorizados == null) itemAlterar = new Electronica_Entidades.entClientes();
                itemAlterar.lstAutorizados.Add(frmSerchCliente.itemModificar);
                LlenaAutorizados();
            }
        }
    }
}
