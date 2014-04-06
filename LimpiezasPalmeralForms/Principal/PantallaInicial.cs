using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
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
    public partial class PantallaInicial : Form
    {
        public PantallaInicial()
        {
            InitializeComponent();
            this.Load += new EventHandler(Grid_Load);
            textBoxStock.KeyUp += new KeyEventHandler(Buscar_Articulos);

        }

        private void Buscar_Articulos(object sender, KeyEventArgs e)
        { 
            ProductoCEN producto = new ProductoCEN();
            IList<ProductoEN> lista;
            if ( textBoxStock.Text == "")
            {
                lista = producto.BuscarPorStock(0);
                dataGridViewStock.DataSource = lista;
            }
            else
            {
                lista = producto.BuscarPorStock(Convert.ToInt32(textBoxStock.Text));
                dataGridViewStock.DataSource = lista;
            }
 

        }



        private void Grid_Load(object sender, EventArgs e)
        {
            ProductoCEN producto = new ProductoCEN();
            IList<ProductoEN> lista;
            lista = producto.BuscarPorStock(5);
            dataGridViewStock.DataSource = lista;

        }

        private void PantallaInicial_Load(object sender, EventArgs e)
        {

        }


    }
}
