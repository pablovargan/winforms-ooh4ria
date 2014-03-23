using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }


        private void cliente_Click(object sender, EventArgs e)
        {
            PantallaCliente cli = new PantallaCliente();
            cli.MdiParent = this;
            cli.Show();
        }

        private void instalacion_Click(object sender, EventArgs e)
        {
            PantallaInstalacion inst = new PantallaInstalacion();
            inst.MdiParent = this;
            inst.Show();
        }

        private void producto_Click(object sender, EventArgs e)
        {
            PantallaProducto prod = new PantallaProducto();
            prod.MdiParent = this;
            prod.Show();
        }

        private void proveedor_Click(object sender, EventArgs e)
        {
            PantallaProveedor prov = new PantallaProveedor();
            prov.MdiParent = this;
            prov.Show();
        }

        private void trabajador_Click(object sender, EventArgs e)
        {
            PantallaTrabajador trab = new PantallaTrabajador();
            trab.MdiParent = this;
            trab.Show();
        }
    }
}
