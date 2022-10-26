using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Electronica
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
            Electronica_AccesoBD.manejoSeguridad valida = null;
            Electronica_Entidades.entSeguridad itemSeg = null;
            try
            {
                valida = new Electronica_AccesoBD.manejoSeguridad();
                validaCampos();
                if (epValidaCampos.GetError(txtUsuario).Trim() == "" && epValidaCampos.GetError(txtContrasenia).Trim() == "")
                {
                    itemSeg = valida.validaCredenciales(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim());
                    
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
            finally
            {
                valida.Finaliza();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }
    }
}
