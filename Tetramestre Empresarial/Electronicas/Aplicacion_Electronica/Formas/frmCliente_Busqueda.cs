using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aplicacion_Electronica.Formas
{
    public partial class frmCliente_Busqueda : Form
    {
        public frmCliente_Busqueda()
        {
            InitializeComponent();
        }

        public Electronica_Entidades.entClientes itemModificar { get; set; }

        public Nullable<int> nIDCliente
        {
            get
            {
                Nullable<int> result = null;

                if (txtCliBus_IdCliente.Text.Trim() != "") result = int.Parse(txtCliBus_IdCliente.Text.Trim());

                return result;
            }
            set
            {
                txtCliBus_IdCliente.Text = "";
                if (value != null) txtCliBus_IdCliente.Text = string.Format("{0}", value);
            }
        }
        public string sApellido1
        {
            get { return txtCliBus_Apellido1.Text.Trim(); }
            set { txtCliBus_Apellido1.Text = value.Trim(); }
        }
        public string sApellido2
        {
            get { return txtCliBus_Apellido2.Text.Trim(); }
            set { txtCliBus_Apellido2.Text = value.Trim(); }
        }
        public string sNombre
        {
            get { return txtCliBus_Nombre.Text.Trim(); }
            set { txtCliBus_Nombre.Text = value.Trim(); }
        }
        public string sRFC
        {
            get { return txtCliBus_RFC.Text.Trim(); }
            set { txtCliBus_RFC.Text = value.Trim(); }
        }
        public string sCURP
        {
            get { return txtCliBus_CURP.Text.Trim(); }
            set { txtCliBus_CURP.Text = value.Trim(); }
        }
        public Nullable<Boolean> bolEstado
        {
            get
            {
                Nullable<Boolean> bResult = null;

                if (rdbActivo.Checked) bResult = true;
                else if (rdbInactivo.Checked) bResult = false;

                return bResult;
            }
            set
            {
                rdbTodos.Checked = false;
                rdbInactivo.Checked = false;
                rdbActivo.Checked = false;

                if (value == null) rdbTodos.Checked = true;
                else if (value.Value == true) rdbActivo.Checked = true;
                else if (value.Value == false) rdbInactivo.Checked = true;
            }
        }

        public void RealizarBusquedaClientes()
        {
            Electronica_AccesoBD.manejoClientes datCliente = null;
            List<Electronica_Entidades.entClientes> lstClientes = null;
            try
            {
                datCliente = new Electronica_AccesoBD.manejoClientes();

                lstClientes = datCliente.ConsultaClientes(nIDCliente, sApellido1, sApellido2, sNombre, sRFC, sCURP, bolEstado);

                dgvCli_Encontrados.AutoGenerateColumns = false;
                dgvCli_Encontrados.DataSource = lstClientes;
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
                datCliente.Finaliza();
            }
        }

        private void frmCliente_Busqueda_Load(object sender, EventArgs e)
        {

        }

        private void btnCli_Buscar_Click(object sender, EventArgs e)
        {
            RealizarBusquedaClientes();
        }

        private void dgvCli_Encontrados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                itemModificar = ((Electronica_Entidades.entClientes)dgvCli_Encontrados.Rows[e.RowIndex].DataBoundItem);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
