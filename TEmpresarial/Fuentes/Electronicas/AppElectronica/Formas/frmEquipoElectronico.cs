using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ent = Electronica_Entidades;
using RN = Electronica_ReglasNegocio;

namespace AppElectronica.Formas
{
    public partial class frmEquipoElectronico : Form
    {
        public Electronica_Entidades.enumTextos.AccionPantalla accionPant { get; set; }
        public frmEquipoElectronico(string sTituloPantalla, Electronica_Entidades.enumTextos.AccionPantalla accionpant)
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

        public ent.entTaller itemAlterar { get; set; }

        public void llenaPantalla()
        {
            try
            {
                LlenaCatalogos();
                if (accionPant == ent.enumTextos.AccionPantalla.Alta)
                {
                    itemAlterar = new ent.entTaller(-1, -1, "", "", "", "", "", "", "", "", -1, "", "", "", "", 150, 0, 0, 0, "Alta de equipo");

                    itemAlterar.lstCostos.Add(new ent.entTallerCosto(3, "Por Cobrar", 9, "Evaluación", 1, 150, 0, 0, "Solo es una revisión", ent.enumTextos.AccionPantalla.Alta));
                }
                else if (accionPant == ent.enumTextos.AccionPantalla.Cambios)
                {
                    txtIDCliente.Text = itemAlterar.nIdCliente.ToString();

                    for (int nR = 0; nR < cmbTipoEquipo.Items.Count; nR++)
                    {
                        ent.entCatalogoSencillo itemCS = (ent.entCatalogoSencillo)cmbTipoEquipo.Items[nR];
                        if (itemCS.nID == itemAlterar.nIdTipoEquipo)
                        {
                            cmbTipoEquipo.SelectedIndex = nR;
                            break;
                        }
                    }

                    lblNombre.Text = itemAlterar.sClienteC;
                    lblRFC.Text = itemAlterar.sCli_RFC;
                    lblCURP.Text = itemAlterar.sCli_CURP;

                    txtMarca.Text = itemAlterar.sMarca;
                    txtNumSerie.Text = itemAlterar.sNumSerie;
                    txtObservaciones.Text = itemAlterar.sObservaciones;

                    itemAlterar.lstCostos = RN.mTaller.EquipoCostoConsulta(itemAlterar.nIdTaller);
                    itemAlterar.lstPersonasRecoge = RN.mCliente.ConsultaEquiposPersonasRecojer(itemAlterar.nIdCliente);
                }
                LlenaDataGridCostos();
                dtgCli_AutRec.AutoGenerateColumns = false;
                dtgCli_AutRec.DataSource = itemAlterar.lstPersonasRecoge;
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

        private void LlenaDataGridCostos()
        {
            List<ent.entTallerCosto> listLlenar = null;
            dgvEquElec_Costos.DataSource = null;
            listLlenar = new List<ent.entTallerCosto>();
            itemAlterar.lstCostos.ForEach(item =>
            {
                if (item.accionPantalla != ent.enumTextos.AccionPantalla.Elimina)
                {
                    listLlenar.Add(item);
                }
            });
            dgvEquElec_Costos.AutoGenerateColumns = false;
            dgvEquElec_Costos.DataSource = listLlenar;
        }

        private void LlenaCatalogos()
        {
            List<ent.entCatalogoSencillo> lstEstatus = null, lstTipoEquipo = null, lstTCos_PorCobrar = null, lstTCos_Cobrados = null;
            List<ent.entCatalogoSencillo> lstCB = null;
            try
            {
                lstEstatus = RN.mCatalogos.consultaCatalogoEstadosEquipo();
                lstTipoEquipo = RN.mCatalogos.consultaCatalogoTipoEquipo();
                lstTCos_PorCobrar = RN.mCatalogos.consultaCatalogoPorCobrar();
                lstTCos_Cobrados = RN.mCatalogos.consultaCatalogoCobrados();

                lstCB = new List<ent.entCatalogoSencillo>();
                lstCB.Add(new ent.entCatalogoSencillo(-1, "-1", "N/A", "-1 :: Seleccione una Opción", true, string.Format("{0} :: {1}", "-1", "Seleccione una Opción"), -1));

                lstTipoEquipo.ForEach(item =>
                {
                    lstCB.Add(new ent.entCatalogoSencillo(item.nID, item.sID, item.sAcronimo, item.sDescripcion, item.bEstado, string.Format("{0:00} :: {1}", item.nID, item.sDescripcion), item.nID));
                });
                LlenaCombos(cmbTipoEquipo, lstCB);

                lstCB = new List<ent.entCatalogoSencillo>();
                lstCB.Add(new ent.entCatalogoSencillo(-1, "-1", "N/A", "-1 :: Seleccione una Opción", true, string.Format("{0} :: {1}", "-1", "Seleccione una Opción"), -1));
                lstTCos_PorCobrar.ForEach(item =>
                {
                    lstCB.Add(new ent.entCatalogoSencillo(item.nID, item.sID, item.sAcronimo, item.sDescripcion, item.bEstado, string.Format("{0:00} :: {1}  - {2}", item.nID, item.sAcronimo, item.sDescripcion), item.nID));
                });
                lstTCos_Cobrados.ForEach(item =>
                {
                    lstCB.Add(new ent.entCatalogoSencillo(item.nID, item.sID, item.sAcronimo, item.sDescripcion, item.bEstado, string.Format("{0:00} :: {1}  - {2}", item.nID, item.sAcronimo, item.sDescripcion), item.nID));
                });
                LlenaCombos(cmbCos_TipoCosto, lstCB);

                lstCB = new List<ent.entCatalogoSencillo>();
                lstEstatus.ForEach(item =>
                {
                    lstCB.Add(new ent.entCatalogoSencillo(item.nID, item.sID, item.sAcronimo, item.sDescripcion, item.bEstado, string.Format("{0:00} :: {1}", item.nID, item.sDescripcion), item.nID));
                });
                LlenaCombos(cmbEstado, lstCB);
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

        private void LlenaCombos(ComboBox cmb, List<ent.entCatalogoSencillo> lstCat)
        {
            lstCat.ForEach(item =>
            {
                cmb.Items.Add(item);
            });
            cmb.SelectedIndex = 0;
        }

        private void frmEquipoElectronico_Load(object sender, EventArgs e) { }

        private void txtIDCliente_Leave(object sender, EventArgs e)
        {
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
        private void cmbTipoEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtMarca_Leave(object sender, EventArgs e)
        {

        }
        private void txtNumSerie_Leave(object sender, EventArgs e)
        {

        }
        private void txtObservaciones_Leave(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Formas.frmCliente_Busqueda pantCientesBusqueda = null;
            try
            {
                itemAlterar.lstPersonasRecoge = new List<ent.entCliente>();
                pantCientesBusqueda = new Formas.frmCliente_Busqueda();
                if (txtIDCliente.Text.Trim() != "") pantCientesBusqueda.nIDCliente = int.Parse(txtIDCliente.Text.Trim());
                pantCientesBusqueda.RealizarBusquedaClientes();
                if (pantCientesBusqueda.ShowDialog() == DialogResult.OK)
                {
                    txtIDCliente.Text = pantCientesBusqueda.itemModificar.nId.ToString();
                    lblNombre.Text = pantCientesBusqueda.itemModificar.sNombreCompleto;
                    lblRFC.Text = pantCientesBusqueda.itemModificar.sRFC;
                    lblCURP.Text = pantCientesBusqueda.itemModificar.sCURP;


                    itemAlterar.nIdCliente = pantCientesBusqueda.itemModificar.nId;
                    itemAlterar.sCli_Apellido1 = pantCientesBusqueda.itemModificar.sApellido1;
                    itemAlterar.sCli_Apellido2 = pantCientesBusqueda.itemModificar.sApellido2;
                    itemAlterar.sCli_Nombre = pantCientesBusqueda.itemModificar.sNombre;
                    itemAlterar.sCli_RFC = pantCientesBusqueda.itemModificar.sRFC;
                    itemAlterar.sCli_CURP = pantCientesBusqueda.itemModificar.sCURP;
                    itemAlterar.sCli_Correo = pantCientesBusqueda.itemModificar.sCorreo;
                    itemAlterar.sCli_Telefono = pantCientesBusqueda.itemModificar.sTelefono;
                    itemAlterar.lstPersonasRecoge = RN.mCliente.ConsultaEquiposPersonasRecojer(pantCientesBusqueda.itemModificar.nId);
                }

                dtgCli_AutRec.DataSource = null;
                dtgCli_AutRec.AutoGenerateColumns = false;
                dtgCli_AutRec.DataSource = itemAlterar.lstPersonasRecoge;
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

        private void btnNuevoTipoEquipo_Click(object sender, EventArgs e)
        {
            Formas.frmCatalogos pantCatalogos = null;

            pantCatalogos = new Formas.frmCatalogos();
            pantCatalogos.ConsultaCatalogo(2);
            //pantCatalogos.MdiParent = (mdiInicio) this.Parent.Parent;
            if (pantCatalogos.ShowDialog() == DialogResult.OK)
            {
                LlenaCatalogos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ent.entCatalogoSencillo itemC = null;
            try
            {
                itemC = (ent.entCatalogoSencillo)cmbTipoEquipo.SelectedItem;

                itemAlterar.sMarca = txtMarca.Text.Trim();
                itemAlterar.sNumSerie = txtNumSerie.Text.Trim();
                itemAlterar.sObservaciones = txtObservaciones.Text.Trim();
                itemAlterar.nIdTipoEquipo = itemC.nID;
                itemAlterar.nEstatus = 1;
                itemAlterar.sEstatus = "En taller";

                if (accionPant == ent.enumTextos.AccionPantalla.Alta)
                {
                    RN.mTaller.EquipoAlta(itemAlterar);
                }
                else if (accionPant == ent.enumTextos.AccionPantalla.Cambios)
                {
                    RN.mTaller.EquipoActualiza(itemAlterar);
                }
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

        private void btnMonto_Click(object sender, EventArgs e)
        {
            ent.entCatalogoSencillo itemCB = null;
            int nIdTabla = 0;
            decimal dPorCobrar = 0, dCobrado = 0;
            try
            {
                itemCB = (ent.entCatalogoSencillo)cmbCos_TipoCosto.SelectedItem;
                nIdTabla = int.Parse(itemCB.sID);
                switch (nIdTabla)
                {
                    case 3:
                        dPorCobrar = decimal.Parse(txtCos_Monto.Text.Trim());
                        break;
                    case 4:
                        dCobrado = decimal.Parse(txtCos_Monto.Text.Trim());
                        break;
                }

                itemAlterar.lstCostos.Add(new ent.entTallerCosto(nIdTabla, itemCB.sAcronimo, itemCB.nID, itemCB.sDescripcion, -1, dPorCobrar, dCobrado, 0, txtCos_Observaciones.Text.Trim(), ent.enumTextos.AccionPantalla.Alta));

                LlenaDataGridCostos();
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
        private void dgvEquElec_Costos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ent.entTallerCosto itemTC = null;
            int nId = 0, nIdTipoCosto = 0;
            decimal mCobrado = 0, mPorCobrar = 0;
            if (dgvEquElec_Costos.Columns[e.ColumnIndex].Name == "clRegEqui_ButtonBorrar")
            {
                itemTC = (Electronica_Entidades.entTallerCosto)dgvEquElec_Costos.Rows[e.RowIndex].DataBoundItem;

                nId = itemTC.nIDCosto;
                nIdTipoCosto = itemTC.nIdTipoCosto;
                mCobrado = itemTC.mCobrado;
                mPorCobrar = itemTC.mPorCobrar;
            
                itemAlterar.lstCostos.ForEach(item =>
                {
                    if (item.nIDCosto == nId && item.nIdTipoCosto == nIdTipoCosto && item.mCobrado == mCobrado && item.mPorCobrar == mPorCobrar)
                    {
                        item.accionPantalla = ent.enumTextos.AccionPantalla.Elimina;
                    }
                });

                LlenaDataGridCostos();
            }
        }
    }
}
