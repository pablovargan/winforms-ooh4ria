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

        public void colorearMenu()
        {
            clienteToolStripMenuItem.ForeColor = Color.Black;
            instalaciónToolStripMenuItem.ForeColor = Color.Black;
            productoToolStripMenuItem.ForeColor = Color.Black;
            proveedorToolStripMenuItem.ForeColor = Color.Black;
            trabajadorToolStripMenuItem.ForeColor = Color.Black;
        }


        private void cliente_Click(object sender, EventArgs e)
        {
            colorearMenu();
            clienteToolStripMenuItem.ForeColor = Color.Blue;
            foreach (Form form in Application.OpenForms)
            {
                if (form is PantallaCliente)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            PantallaCliente cli = new PantallaCliente() { MdiParent = this };
            cli.Show();
            cli.WindowState = FormWindowState.Maximized;

        }

        private void instalacion_Click(object sender, EventArgs e)
        {
            colorearMenu();
            instalaciónToolStripMenuItem.ForeColor = Color.Blue;
            foreach (Form form in Application.OpenForms)
            {
                if (form is PantallaInstalacion)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            PantallaInstalacion inst = new PantallaInstalacion() { MdiParent = this };
            inst.Show();
            inst.WindowState = FormWindowState.Maximized;

        }

        private void producto_Click(object sender, EventArgs e)
        {
            colorearMenu();
            productoToolStripMenuItem.ForeColor = Color.Blue;

            foreach (Form form in Application.OpenForms)
            {
                if (form is PantallaProducto)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            PantallaProducto prod = new PantallaProducto() { MdiParent = this };
            prod.Show();
            prod.WindowState = FormWindowState.Maximized;
        }

        private void proveedor_Click(object sender, EventArgs e)
        {
            colorearMenu();
            proveedorToolStripMenuItem.ForeColor = Color.Blue;
            foreach (Form form in Application.OpenForms)
            {
                if (form is PantallaProveedor)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            PantallaProveedor prov = new PantallaProveedor() { MdiParent = this };
            prov.Show();
            prov.WindowState = FormWindowState.Maximized;
           // this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void trabajador_Click(object sender, EventArgs e)
        {
            colorearMenu();
            trabajadorToolStripMenuItem.ForeColor = Color.Blue;

            foreach (Form form in Application.OpenForms)
            {
                if (form is CrearTrabajador)
                {
                    form.Activate();
                    form.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
                    
            PantallaTrabajador trab = new PantallaTrabajador() { MdiParent = this };
            trab.Show();
            trab.WindowState = FormWindowState.Maximized;

        }
    }
}
