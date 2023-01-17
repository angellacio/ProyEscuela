using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using mRN = Electronica_ReglasNegocio;

namespace AppElectronica.Formas
{
    public partial class frmSeguridad_Busqueda : Form
    {
        public frmSeguridad_Busqueda()
        {
            InitializeComponent();
        }

        public Electronica_Entidades.entSeguridad itemModificar { get; set; }
        public Nullable<int> nIDUsuario
        {
            get
            {
                Nullable<int> result = null;

                if (txtSegBus_IdCliente.Text.Trim() != "") result = int.Parse(txtSegBus_IdCliente.Text.Trim());

                return result;
            }
            set
            {
                txtSegBus_IdCliente.Text = "";
                if (value != null) txtSegBus_IdCliente.Text = string.Format("{0}", value);
            }
        }
        public string sApellido1
        {
            get { return txtSegBus_Apellido1.Text.Trim(); }
            set { txtSegBus_Apellido1.Text = value.Trim(); }
        }
        public string sApellido2
        {
            get { return txtSegBus_Apellido2.Text.Trim(); }
            set { txtSegBus_Apellido2.Text = value.Trim(); }
        }
        public string sNombre
        {
            get { return txtSegBus_Nombre.Text.Trim(); }
            set { txtSegBus_Nombre.Text = value.Trim(); }
        }
        public string sUsuario
        {
            get { return txtSegBus_Usuario.Text.Trim(); }
            set { txtSegBus_Usuario.Text = value.Trim(); }
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
            List<Electronica_Entidades.entSeguridad> lstClientes = null;
            try
            {
                lstClientes = mRN.mUsuarios.consultaUsuarios(nIDUsuario, sUsuario, sApellido1, sApellido2, sNombre, bolEstado);

                dgvSeg_Encontrados.AutoGenerateColumns = false;
                dgvSeg_Encontrados.DataSource = lstClientes;
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

        private void frmSeguridad_Busqueda_Load(object sender, EventArgs e)
        {

        }

        private void dgvSeg_Encontrados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                itemModificar = ((Electronica_Entidades.entSeguridad)dgvSeg_Encontrados.Rows[e.RowIndex].DataBoundItem);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSeg_Buscar_Click(object sender, EventArgs e)
        {
            RealizarBusquedaClientes();
        }

        private void dgvSeg_Encontrados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.ColumnIndex > 0 && e.RowIndex >= 0 && this.dgvSeg_Encontrados.Columns[e.ColumnIndex].Name == "clBus_Nombre")
            //{
            //    Color fondo = dgvSeg_Encontrados.DefaultCellStyle.BackColor;
            //    if (dgvSeg_Encontrados.CurrentRow.Index == e.RowIndex)
            //        fondo = dgvSeg_Encontrados.DefaultCellStyle.SelectionBackColor;
            //    e.Graphics.FillRectangle(new SolidBrush(fondo), e.CellBounds);
            //    e.Graphics.DrawRectangle(new Pen(Color.Silver), e.CellBounds);
            //    string[] palabras = sApellido1.Split(' ');
            //    int X = e.CellBounds.X, posicion = 0, carateresDesplegados = 0, Y = e.CellBounds.Y + 2;
            //    for (int i = 0; i < palabras.Length; i++)
            //    {
            //        posicion = e.Value.ToString().IndexOf(palabras[i], carateresDesplegados);
            //        string cadena1 = e.Value.ToString().Substring(carateresDesplegados, posicion - (carateresDesplegados));
            //        string cadena2 = e.Value.ToString().Substring(posicion, palabras[i].Length);
            //        TextRenderer.DrawText(e.Graphics, cadena1, e.CellStyle.Font, new Point(X, Y), Color.Black);
            //        Size sizeCadena = TextRenderer.MeasureText(cadena1, e.CellStyle.Font);
            //        X += sizeCadena.Width;
            //        TextRenderer.DrawText(e.Graphics, cadena2, new Font(e.CellStyle.Font, FontStyle.Bold), new Point(X, Y), Color.Black);
            //        sizeCadena = TextRenderer.MeasureText(cadena2, new Font(e.CellStyle.Font, FontStyle.Bold));
            //        X += sizeCadena.Width - 8;
            //        carateresDesplegados += cadena1.Length + cadena2.Length;
            //    }

            //    if (carateresDesplegados < e.Value.ToString().Length)
            //    {
            //        string cadena1 = e.Value.ToString().Substring(carateresDesplegados);
            //        TextRenderer.DrawText(e.Graphics, cadena1, e.CellStyle.Font, new Point(X,                    Y), Color.Black);
            //    }

            //    e.Handled = true;
            //}
        }
    }
}
