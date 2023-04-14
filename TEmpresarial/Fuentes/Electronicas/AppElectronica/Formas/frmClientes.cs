using Electronica_Entidades;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using mRN = Electronica_ReglasNegocio;

namespace AppElectronica.Formas
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
                this.btnGuardar.BackgroundImage = global::AppElectronica.Properties.Resources.Agregar;
                this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Cambios)
            {
                this.btnGuardar.BackgroundImage = global::AppElectronica.Properties.Resources.Actualizar;
                this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            //else if (accionpant == Electronica_Entidades.enumTextos.AccionPantalla.Bajas)
            //{
            //    this.btnGuardar.BackgroundImage = global::AppElectronica.Properties.Resources.Borrar;
            //    this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //}
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

            List<entCliente> lstElimina = new List<entCliente>();

            if (itemAlterar != null && itemAlterar.lstAutorizados != null)
            {
                itemAlterar.lstAutorizados.ForEach(item =>
                {
                    if (item.apEstado == enumTextos.AccionPantalla.Elimina)
                    {
                        item.apEstado = enumTextos.AccionPantalla.Cambios;
                    }
                    else if (item.apEstado == enumTextos.AccionPantalla.Alta)
                    {
                        lstElimina.Add(item);
                    }
                });

                lstElimina.ForEach(item =>
                {
                    itemAlterar.lstAutorizados.Remove(item);
                });
            }
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
            ckbCli_Estado.Checked = itemAlterar.apEstado == Electronica_Entidades.enumTextos.AccionPantalla.Cambios;
            LlenaAutorizados();
        }
        private void LlenaAutorizados()
        {
            dtgCli_AutRec.AutoGenerateColumns = false;
            dtgCli_AutRec.Rows.Clear();
            itemAlterar.lstAutorizados.ForEach(item =>
            {
                if (item.apEstado != enumTextos.AccionPantalla.Elimina)
                {
                    dtgCli_AutRec.Rows.Add(item.nId, item.sNombreCompleto, item.sRFC);
                }
            });
        }
        private void EstadoComponentes()//bool bolEstado)
        {
            txtCli_Apellido1.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            txtCli_Apellido2.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            txtCli_Nombre.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            txtCli_CURP.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            txtCli_RFC.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            txtCli_Telefono.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            txtCli_Correo.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            txtCli_Direccion.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;

            txtCli_AutRecID.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            txtCli_AutRecApellido1.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            txtCli_AutRecApellido2.ReadOnly = itemAlterar.apEstado == enumTextos.AccionPantalla.Elimina;// bolEstado;
            btnCli_Buscar.Enabled = itemAlterar.apEstado != enumTextos.AccionPantalla.Elimina;// !bolEstado;
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
            if (accionPant == Electronica_Entidades.enumTextos.AccionPantalla.Cambios)
            {
                LlenaDatos();
            }
            else
            {
                itemAlterar = new Electronica_Entidades.entCliente() { apEstado = enumTextos.AccionPantalla.Alta };
            }
            EstadoComponentes();//true);
            //switch (accionPant)
            //{
            //    case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:
            //        LlenaDatos();
            //        break;
            //    case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
            //        EstadoComponentes(false);
            //        break;
            //    case Electronica_Entidades.enumTextos.AccionPantalla.Alta:
            //        EstadoComponentes(false);
            //        break;
            //}
            validaCampos();
        }

        private void btnCli_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LlenaDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nIdCliente = 0;
            try
            {
                if (epClientes.GetError(txtCli_Apellido1).Trim() != "" || epClientes.GetError(txtCli_Apellido2).Trim() != "" ||
                  epClientes.GetError(txtCli_Nombre).Trim() != "" || epClientes.GetError(txtCli_RFC).Trim() != "" ||
                  epClientes.GetError(txtCli_Telefono).Trim() != "")
                    throw new ApplicationException("Favor de validar los campos con una alerta de color rojo");

                switch (accionPant)
                {
                    //case Electronica_Entidades.enumTextos.AccionPantalla.Bajas:
                    //    mRN.mCliente.ActualizaCliente(itemAlterar.nId, itemAlterar.sApellido1, itemAlterar.sApellido2, itemAlterar.sNombre, itemAlterar.sCURP, itemAlterar.sRFC, itemAlterar.sTelefono, itemAlterar.sCorreo, itemAlterar.sDireccion, ckbCli_Estado.Checked);
                    //    break;
                    case Electronica_Entidades.enumTextos.AccionPantalla.Cambios:
                        nIdCliente = itemAlterar.nId;
                        mRN.mCliente.ActualizaCliente(nIdCliente, txtCli_Apellido1.Text.Trim(), txtCli_Apellido2.Text.Trim(), txtCli_Nombre.Text.Trim(), txtCli_CURP.Text.Trim().ToUpper(), txtCli_RFC.Text.Trim().ToUpper(), txtCli_Telefono.Text.Trim(), txtCli_Correo.Text.Trim(), txtCli_Direccion.Text.Trim(), ckbCli_Estado.Checked ? 2 : 3);
                        break;
                    case Electronica_Entidades.enumTextos.AccionPantalla.Alta:
                        nIdCliente = mRN.mCliente.AltaCliente(txtCli_Apellido1.Text.Trim(), txtCli_Apellido2.Text.Trim(), txtCli_Nombre.Text.Trim(), txtCli_CURP.Text.Trim().ToUpper(), txtCli_RFC.Text.Trim().ToUpper(), txtCli_Telefono.Text.Trim(), txtCli_Correo.Text.Trim(), txtCli_Direccion.Text.Trim(), 2);
                        break;
                }

                itemAlterar.lstAutorizados.ForEach(item =>
                {
                    if (item.apEstado == enumTextos.AccionPantalla.Alta)
                    {
                        mRN.mCliente.AltaPersonaRecoge(nIdCliente, item.nId);
                    }
                    else if (item.apEstado == enumTextos.AccionPantalla.Elimina)
                    {
                        mRN.mCliente.EliminalizaPersonaRecoge(nIdCliente, item.nId);
                    }
                });


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
        frmSerchCliente.itemModificar.apEstado = enumTextos.AccionPantalla.Alta;
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

private void dtgCli_AutRec_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (dtgCli_AutRec.Columns[e.ColumnIndex].Name == "Eliminar")
    {
        List<entCliente> lstElimina = new List<entCliente>();

        itemAlterar.lstAutorizados.ForEach(item =>
        {
            if (item.nId == int.Parse(dtgCli_AutRec.Rows[e.RowIndex].Cells["Id"].Value.ToString()))
            {
                if (item.apEstado == enumTextos.AccionPantalla.Cambios)
                {
                    item.apEstado = enumTextos.AccionPantalla.Elimina;
                }
                else if (item.apEstado == enumTextos.AccionPantalla.Alta)
                {
                    lstElimina.Add(item);
                }
            }
        });

        lstElimina.ForEach(item =>
        {
            itemAlterar.lstAutorizados.Remove(item);
        });

        LlenaAutorizados();
    }

}
    }
}
