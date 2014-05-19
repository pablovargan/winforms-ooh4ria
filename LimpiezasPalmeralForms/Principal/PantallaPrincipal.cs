using System;
using System.Collections.Generic;
using LimpiezasPalmeralForms.Principal;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimpiezasPalmeralForms.Proveedor.Pedidos;
using LimpiezasPalmeralForms.Trabajador.Nóminas;
using LimpiezasPalmeralForms.Backup;
using LimpiezasPalmeralForms.Instalacion.Facturas;

namespace LimpiezasPalmeralForms
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            inicioToolStripMenuItem.ForeColor = Color.Blue;
            PantallaInicial ini = new PantallaInicial() { MdiParent = this };
            ini.Show();
            ini.WindowState = FormWindowState.Maximized;
        }

        public void colorearMenu()
        {
            inicioToolStripMenuItem.ForeColor = Color.Black;
            clienteToolStripMenuItem.ForeColor = Color.Black;
            instalaciónToolStripMenuItem.ForeColor = Color.Black;
            productoToolStripMenuItem.ForeColor = Color.Black;
            proveedorToolStripMenuItem.ForeColor = Color.Black;
            trabajadorToolStripMenuItem.ForeColor = Color.Black;
            nóminasToolStripMenuItem.ForeColor = Color.Black;
            backupsToolStripMenuItem.ForeColor = Color.Black;
            facturasToolStripMenuItem.ForeColor = Color.Black;
            pedidosToolStripMenuItem1.ForeColor = Color.Black;

        }


        private void cliente_Click(object sender, EventArgs e)
        {
            colorearMenu();
            clienteToolStripMenuItem.ForeColor = Color.Blue;
            PantallaCliente cli = new PantallaCliente() { MdiParent = this };
            cli.Show();
            cli.WindowState = FormWindowState.Maximized;

        }

        private void instalacion_Click(object sender, EventArgs e)
        {
            colorearMenu();
            instalaciónToolStripMenuItem.ForeColor = Color.Blue;
            PantallaInstalacion inst = new PantallaInstalacion() { MdiParent = this };
            inst.Show();
            inst.WindowState = FormWindowState.Maximized;

        }

        private void producto_Click(object sender, EventArgs e)
        {
            colorearMenu();
            productoToolStripMenuItem.ForeColor = Color.Blue;
            PantallaProducto prod = new PantallaProducto() { MdiParent = this };
            prod.Show();
            prod.WindowState = FormWindowState.Maximized;
        }

        private void proveedor_Click(object sender, EventArgs e)
        {
            colorearMenu();
            proveedorToolStripMenuItem.ForeColor = Color.Blue;
            PantallaProveedor prov = new PantallaProveedor() { MdiParent = this };
            prov.Show();
            prov.WindowState = FormWindowState.Maximized;
        }

        private void trabajador_Click(object sender, EventArgs e)
        {
            colorearMenu();
            trabajadorToolStripMenuItem.ForeColor = Color.Blue;                    
            PantallaTrabajador trab = new PantallaTrabajador() { MdiParent = this };
            trab.Show();
            trab.WindowState = FormWindowState.Maximized;

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorearMenu();
            inicioToolStripMenuItem.ForeColor = Color.Blue;
            PantallaInicial ini2 = new PantallaInicial() { MdiParent = this };
            ini2.Grid_Load(sender, e);
            ini2.Show();
            ini2.WindowState = FormWindowState.Maximized;
            
        }

        private void pedidos_Click(object sender, EventArgs e)
        {
            colorearMenu();
            pedidosToolStripMenuItem1.ForeColor = Color.Blue;

            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form is PantallaPedidos)
            //    {
            //        form.Activate();
            //        form.WindowState = FormWindowState.Maximized;
            //        return;
            //    }
            //}
            PantallaPedidos prov = new PantallaPedidos() { MdiParent = this };
            prov.Show();
            prov.WindowState = FormWindowState.Maximized;
        }

        private void backupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorearMenu();
            backupsToolStripMenuItem.ForeColor = Color.Blue;
            PantallaBackup back = new PantallaBackup() { MdiParent = this };
            back.Show();
            back.WindowState = FormWindowState.Maximized;

        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nóminasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorearMenu();
            nóminasToolStripMenuItem.ForeColor = Color.Blue;
            PantallaNominas nomi = new PantallaNominas() { MdiParent = this };
            nomi.Show();
            nomi.WindowState = FormWindowState.Maximized;            
        }


        private void facturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            colorearMenu();
            facturasToolStripMenuItem.ForeColor = Color.Blue;
            PantallaFacturas fac = new PantallaFacturas() { MdiParent = this };
            fac.Show();
            fac.WindowState = FormWindowState.Maximized; 
        }   
    }
}
