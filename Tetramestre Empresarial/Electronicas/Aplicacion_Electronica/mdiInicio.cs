using System;
using System.Windows.Forms;

namespace Aplicacion_Electronica
{
    public partial class mdiInicio : Form
    {
        public mdiInicio()
        {
            InitializeComponent();
        }

        public Electronica_Entidades.entSeguridad itemSeg { get;set; }

        private void mdiInicio_Load(object sender, EventArgs e)
        {
            tslUsuario.Text = itemSeg.sUsuario;
            tslNombre.Text = itemSeg.sNombreCompleto;
        }

        private void MuestraPantalla(int nPantalla)
        {
            Formas.frmClientes pantCientes = null;
            Formas.frmCliente_Busqueda pantCientesBusqueda = null;
            Formas.frmEquipoElectronico pantEquipoElectronico = null;
            Formas.frmEquipoElectronico_Busqueda pantEquipoElectronicoBusqueda = null;
            Formas.frmSeguridad pantSeguridad = null;
            Formas.frmSeguridad_Busqueda pantSeguridadBusqueda = null;
            Formas.frmReporte_ClienteEquipo pantRepClienteEquipo = null;

            switch (nPantalla)
            {
                case 1:
                    pantCientes = new Formas.frmClientes("Alta de nuevo cliente.", Electronica_Entidades.enumTextos.AccionPantalla.Alta);
                    pantCientes.MdiParent = this;
                    pantCientes.Show();
                    break;
                case 2:
                case 3:
                    pantCientesBusqueda = new Formas.frmCliente_Busqueda();
                    if (pantCientesBusqueda.ShowDialog() == DialogResult.OK)
                    {
                        if (nPantalla == 2) pantCientes = new Formas.frmClientes(string.Format("Modificar el cliente {0} - {1}.", pantCientesBusqueda.itemModificar.nId, pantCientesBusqueda.itemModificar.sNombreCompleto), Electronica_Entidades.enumTextos.AccionPantalla.Cambios);
                        else pantCientes = new Formas.frmClientes(string.Format("Elimina el cliente {0} - {1}.", pantCientesBusqueda.itemModificar.nId, pantCientesBusqueda.itemModificar.sNombreCompleto), Electronica_Entidades.enumTextos.AccionPantalla.Bajas);

                        pantCientes.itemAlterar = pantCientesBusqueda.itemModificar;
                        pantCientes.MdiParent = this;
                        pantCientes.Show();
                    }
                    break;
                case 10:
                    pantEquipoElectronico = new Formas.frmEquipoElectronico("Registro de entrada para equipo electrónico.", Electronica_Entidades.enumTextos.AccionPantalla.Alta);
                    pantEquipoElectronico.MdiParent = this;
                    pantEquipoElectronico.Show();
                    break;
                case 11:
                    pantEquipoElectronicoBusqueda = new Formas.frmEquipoElectronico_Busqueda();
                    if (pantEquipoElectronicoBusqueda.ShowDialog() == DialogResult.OK)
                    {
                        pantEquipoElectronico = new Formas.frmEquipoElectronico(string.Format("Salida de equipo electronico. Cliente: {0}, equipo {1}", "", ""), Electronica_Entidades.enumTextos.AccionPantalla.Bajas);
                        pantEquipoElectronico.itemAlterar = pantEquipoElectronicoBusqueda.itemModificar;
                        pantEquipoElectronico.MdiParent = this;
                        pantEquipoElectronico.Show();
                    }
                    break;
                case 20:
                    pantRepClienteEquipo = new Formas.frmReporte_ClienteEquipo();
                    pantRepClienteEquipo.MdiParent = this;
                    pantRepClienteEquipo.Show();
                    break;
                case 30:
                    pantSeguridad = new Formas.frmSeguridad("Alta de nuevo usuario.", Electronica_Entidades.enumTextos.AccionPantalla.Alta);
                    pantSeguridad.MdiParent = this;
                    pantSeguridad.Show();
                    break;
                case 31:
                case 32:
                    pantSeguridadBusqueda = new Formas.frmSeguridad_Busqueda();
                    if (pantSeguridadBusqueda.ShowDialog() == DialogResult.OK)
                    {
                        if (nPantalla == 31) pantSeguridad = new Formas.frmSeguridad(string.Format("Modificar el usuario {0} - {1}.", pantSeguridadBusqueda.itemModificar.nId, pantSeguridadBusqueda.itemModificar.sNombreCompleto), Electronica_Entidades.enumTextos.AccionPantalla.Cambios);
                        else pantSeguridad = new Formas.frmSeguridad(string.Format("Elimina el usuario {0} - {1}.", pantSeguridadBusqueda.itemModificar.nId, pantSeguridadBusqueda.itemModificar.sNombreCompleto), Electronica_Entidades.enumTextos.AccionPantalla.Bajas);

                        pantSeguridad.itemAlterar = pantSeguridadBusqueda.itemModificar;
                        pantSeguridad.MdiParent = this;
                        pantSeguridad.Show();
                    }
                    break;
            }
        }

        private void mCli_Altas_Click(object sender, EventArgs e)
        {
            MuestraPantalla(1);
        }
        private void mCli_Cambios_Click(object sender, EventArgs e)
        {
            MuestraPantalla(2);
        }
        private void mCli_Bajas_Click(object sender, EventArgs e)
        {
            MuestraPantalla(3);
        }

        private void mEqui_Entradas_Click(object sender, EventArgs e)
        {
            MuestraPantalla(10);
        }
        private void mEqui_Salidas_Click(object sender, EventArgs e)
        {
            MuestraPantalla(11);
        }

        private void mRep_Recoje_Click(object sender, EventArgs e)
        {
            MuestraPantalla(20);
        }
        private void mSeg_Altas_Click(object sender, EventArgs e)
        {
            MuestraPantalla(30);
        }
        private void mSeg_Cambios_Click(object sender, EventArgs e)
        {
            MuestraPantalla(31);
        }
        private void mSeg_Bajas_Click(object sender, EventArgs e)
        {
            MuestraPantalla(32);
        }

        private void mVen_Cascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void mVen_Vertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void mVen_Horizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void mVen_CerrarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mdiInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            Application.Exit();
        }
    }
}
