using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mRN = Electronica_ReglasNegocio;

namespace AppElectronica
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void validaCampos()
        {
            epValidaCampos.Clear();
            if (txtUsuario.Text.Trim() == "") epValidaCampos.SetError(txtUsuario, "Favor de especificar un usuario.");
            if (txtContrasenia.Text.Trim() == "") epValidaCampos.SetError(txtContrasenia, "Favor de especificar una contraseña.");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Electronica_Entidades.entSeguridad itemSeg = null;
            try
            {
                validaCampos();
                if (epValidaCampos.GetError(txtUsuario).Trim() == "" && epValidaCampos.GetError(txtContrasenia).Trim() == "")
                {
                    itemSeg = mRN.mUsuarios.validaCredenciales(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim());
                    
                    mdiInicio frmMenu = new mdiInicio();
                    frmMenu.itemSeg = itemSeg;
                    frmMenu.Show();

                    this.Visible = false;
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, null);
            }
        }
    }
}
