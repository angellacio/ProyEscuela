using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Electronica.Formas
{
    public partial class frmEquipoElectronico : Form
    {
        public Electronica_Entidades.enumTextos.AccionPantalla accionPant { get; set; }
        public frmEquipoElectronico(string sTituloPantalla, Electronica_Entidades.enumTextos.AccionPantalla accionpant)
        {
            InitializeComponent();

            this.Text = sTituloPantalla;
            accionPant = accionpant;
        }

        public object itemAlterar { get; set; }

        public void LlenaTipoCosto()
        {
            List<Electronica_Entidades.entCatalogoSencillo> lstTCos_Costo = null, lstTCos_Abonos = null;

            lstTCos_Costo = new List<Electronica_Entidades.entCatalogoSencillo>()
            {
                new Electronica_Entidades.entCatalogoSencillo(){ nID = 1, sID = "1", sAcronimo = "Costo", sDescripcion = "Evaluación", bEstado = true  },
                new Electronica_Entidades.entCatalogoSencillo(){ nID = 2, sID = "1", sAcronimo = "Costo", sDescripcion = "Cotización", bEstado = true  },
                new Electronica_Entidades.entCatalogoSencillo(){ nID = 3, sID = "1", sAcronimo = "Costo", sDescripcion = "Costo", bEstado = true  }
            };

            lstTCos_Abonos = new List<Electronica_Entidades.entCatalogoSencillo>()
            {
                new Electronica_Entidades.entCatalogoSencillo(){ nID = 1, sID = "2", sAcronimo = "Abono", sDescripcion = "Abono", bEstado = true  },
                new Electronica_Entidades.entCatalogoSencillo(){ nID = 2, sID = "2", sAcronimo = "Abono", sDescripcion = "Monto descuento", bEstado = true  }
            };

            cmbCos_TipoCosto.Items.Clear();
            cmbCos_TipoCosto.Items.Add(string.Format("-1 :: Seleccione una Opción"));
            lstTCos_Costo.ForEach(itemC =>
            {
                cmbCos_TipoCosto.Items.Add(string.Format("{0:00} :: {1}  - {2}", itemC.nID, itemC.sAcronimo, itemC.sDescripcion));
            });
            lstTCos_Abonos.ForEach(itemA =>
            {
                cmbCos_TipoCosto.Items.Add(string.Format("{0:00} :: {1} - {2}", itemA.nID, itemA.sAcronimo, itemA.sDescripcion));
            });
            cmbCos_TipoCosto.SelectedIndex = 0;
        }

        private void frmEquipoElectronico_Load(object sender, EventArgs e)
        {
            LlenaTipoCosto();
        }
        
        private void txtIDCliente_Leave(object sender, EventArgs e)
        {

        }
    }
}
