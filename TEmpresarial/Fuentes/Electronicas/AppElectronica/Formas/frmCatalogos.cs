using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ent = Electronica_Entidades;
using RN = Electronica_ReglasNegocio;

namespace Aplicacion_Electronica.Formas
{
    public partial class frmCatalogos : Form
    {
        public frmCatalogos()
        {
            InitializeComponent();
            LlenaCatalogos();
            LimpiarComponentes();
        }

        int nIdTabla { get; set; }
        ent.entCatalogoSencillo itemModificar { get; set; }

        private void LlenaCatalogos()
        {
            List<ent.entCatalogoSencillo> lstTabla = null, lstCMB = null;
            try
            {
                lstCMB = new List<ent.entCatalogoSencillo>();
                lstTabla = RN.mCatalogos.consultaCatalogoTablas();

                lstCMB.Add(new ent.entCatalogoSencillo(-1, "-1", "", "Seleccione una Opción.", true, "-1 :: Seleccione una Opción.", -1));
                lstTabla.ForEach(itemC =>
                {
                    lstCMB.Add(new ent.entCatalogoSencillo(itemC.nID, itemC.sID, itemC.sAcronimo, itemC.sDescripcion, itemC.bEstado, string.Format("{0:00} :: {1}", itemC.nID, itemC.sDescripcion), itemC.nID));
                });


                cmbTabla.Items.Clear();
                lstCMB.ForEach(itemC =>
                {
                    cmbTabla.Items.Add(itemC);
                });
                cmbTabla.SelectedIndex = 0;
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

        private void validaCampos()
        {
            epCatalogos.Clear();
            if (txtDescripcion.Text.Trim() == "") epCatalogos.SetError(txtDescripcion, "Favor de especificar la DESCRIPCIÓN.");
        }

        private void LimpiarComponentes()
        {
            txtDescripcion.Text = "";
            ckbEstado.Checked = true;
            itemModificar = null;

            this.btnGuardar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Agregar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        public void ConsultaCatalogo(int IdTabla)
        {
            List<ent.entCatalogoSencillo> lstTabla = null;
            int nIndexTabla = 0;
            try
            {
                nIdTabla = IdTabla;
                for (int nR = 0; nR < cmbTabla.Items.Count; nR++)
                {
                    ent.entCatalogoSencillo itemCB = (ent.entCatalogoSencillo) cmbTabla.Items[nR];
                    if ((int)itemCB.Value == nIdTabla)
                    {
                        nIndexTabla = nR;
                        break;
                    }
                }
                cmbTabla.SelectedIndex = nIndexTabla;

                switch (nIdTabla)
                {
                    case 1:
                        lstTabla = RN.mCatalogos.consultaAllCatalogoEstadosEquipo();
                        break;
                    case 2:
                        lstTabla = RN.mCatalogos.consultaAllCatalogoTipoEquipo();
                        break;
                    case 3:
                        lstTabla = RN.mCatalogos.consultaAllCatalogoPorCobrar();
                        break;
                    case 4:
                        lstTabla = RN.mCatalogos.consultaAllCatalogoCobrados();
                        break;
                }

                dtgCatalogo.AutoGenerateColumns = false;
                dtgCatalogo.DataSource = lstTabla;
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

        private void frmCatalogos_Load(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();

            validaCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (epCatalogos.GetError(txtDescripcion).Trim() != "")
                    throw new ApplicationException("Favor de validar los campos con una alerta de color rojo");

                if (itemModificar == null)
                {
                    RN.mCatalogos.AltaCatalogo(nIdTabla, txtDescripcion.Text.Trim(), ckbEstado.Checked);
                }
                else
                {
                    RN.mCatalogos.ActualizaCatalogo(itemModificar.nID, nIdTabla, txtDescripcion.Text.Trim(), ckbEstado.Checked);
                }
                ConsultaCatalogo(nIdTabla);
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

        private void dtgCatalogo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                this.btnGuardar.BackgroundImage = global::Aplicacion_Electronica.Properties.Resources.Actualizar;
                this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

                itemModificar = ((ent.entCatalogoSencillo)dtgCatalogo.Rows[e.RowIndex].DataBoundItem);
                txtDescripcion.Text = itemModificar.sDescripcion;
                ckbEstado.Checked = itemModificar.bEstado;

                validaCampos();
            }
        }

        private void frmCatalogos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            validaCampos();
        }
    }
}
