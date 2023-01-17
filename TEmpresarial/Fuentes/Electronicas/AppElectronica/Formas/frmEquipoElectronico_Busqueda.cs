using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ent = Electronica_Entidades;
using RN = Electronica_ReglasNegocio;

namespace Aplicacion_Electronica.Formas
{
    public partial class frmEquipoElectronico_Busqueda : Form
    {
        public frmEquipoElectronico_Busqueda()
        {
            InitializeComponent();
        }

        public ent.entTaller itemModificar { get; set; }

        private void llenaCatalogos()
        {
            List<ent.entCatalogoSencillo> lstTipoEquipo = null;
            List<ent.entCatalogoSencillo> lstCB = null;
            try
            {
                lstCB = new List<ent.entCatalogoSencillo>();
                lstCB.Add(new ent.entCatalogoSencillo(-1, "-1", "N/A", "-1 :: Seleccione una Opción", true, string.Format("{0} :: {1}", "-1", "Seleccione una Opción"), -1));
                lstTipoEquipo = RN.mCatalogos.consultaCatalogoTipoEquipo();

                lstTipoEquipo.ForEach(item =>
                {
                    lstCB.Add(new ent.entCatalogoSencillo(item.nID, item.sID, item.sAcronimo, item.sDescripcion, item.bEstado, string.Format("{0:00} :: {1}", item.nID, item.sDescripcion), item.nID));
                });

                cmbTipoEquipo.Items.Clear();
                lstCB.ForEach(item =>
                {
                    cmbTipoEquipo.Items.Add(item);
                });
                cmbTipoEquipo.SelectedIndex = 0;
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
            { }
        }

        private void frmEquipoElectronico_Busqueda_Load(object sender, EventArgs e)
        {
            llenaCatalogos();
        }

        private void btnCli_Buscar_Click(object sender, EventArgs e)
        {
            Formas.frmCliente_Busqueda pantCientesBusqueda = null;

            pantCientesBusqueda = new Formas.frmCliente_Busqueda();
            if (txtCli_ID.Text.Trim() != "") pantCientesBusqueda.nIDCliente = int.Parse(txtCli_ID.Text.Trim());
            pantCientesBusqueda.RealizarBusquedaClientes();
            if (pantCientesBusqueda.ShowDialog() == DialogResult.OK)
            {
                txtCli_ID.Text = pantCientesBusqueda.itemModificar.nId.ToString();
                lblCli_Dato.Text = string.Format("{0} :: {1} :: {2}", pantCientesBusqueda.itemModificar.sNombreCompleto, pantCientesBusqueda.itemModificar.sRFC, pantCientesBusqueda.itemModificar.sCURP);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<ent.entTaller> lstTaller = null;
            ent.entCatalogoSencillo itemTipoEquipo = null;
            try
            {
                itemTipoEquipo = (ent.entCatalogoSencillo) cmbTipoEquipo.SelectedItem;

                lstTaller = RN.mTaller.EquipoConsulta(txtCli_ID.Text.Trim(), itemTipoEquipo.Value.ToString(), txtMarca.Text.Trim(), txtNumSerie.Text.Trim());

                dgvTal_Encontrados.AutoGenerateColumns = false;
                dgvTal_Encontrados.DataSource = lstTaller;
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
            { }
        }
        
        private void dgvTal_Encontrados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                itemModificar = ((ent.entTaller)dgvTal_Encontrados.Rows[e.RowIndex].DataBoundItem);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
