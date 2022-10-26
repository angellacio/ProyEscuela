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
        public Boolean bolEstado
        {
            get { return ckbCliBus_Activo.Checked; }
            set { ckbCliBus_Activo.Checked = value; }
        }

        public void RealizarBusquedaClientes()
        {
            List<Electronica_Entidades.entClientes> lstClientes = new List<Electronica_Entidades.entClientes>()
            {
                new Electronica_Entidades.entClientes() { nId = 1, sApellido1 = "RAMIREZ", sApellido2 = "MANCERA", sNombre = "ANGEL", sCURP="RAMA821207HDFMNN01", sRFC="RAMA821207DS9", sTelefono="5536413068", sCorreo="angel.ramirez.mancera@gmail.com", sDireccion="Mi casa", bEstdo = true },
                new Electronica_Entidades.entClientes() { nId = 2, sApellido1 = "MONRREAL", sApellido2 = "BOTELLO", sNombre = "OLADERMIS ISABEL", sCURP="MOBO830704MTAMNN03", sRFC="MOBO730804FJA", sTelefono="553985564", sCorreo="oladermis@gmail.com", sDireccion="", bEstdo = true }
            };

            dgvCli_Encontrados.AutoGenerateColumns = false;
            dgvCli_Encontrados.DataSource = lstClientes;
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
            itemModificar = new Electronica_Entidades.entClientes() { nId = 1, sApellido1 = "RAMIREZ", sApellido2 = "MANCERA", sNombre = "ANGEL", sCURP = "RAMA821207HDFMNN01", sRFC = "RAMA821207DS9", sTelefono = "5536413068", sCorreo = "angel.ramirez.mancera@gmail.com", sDireccion = "Mi casa", bEstdo = true };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
