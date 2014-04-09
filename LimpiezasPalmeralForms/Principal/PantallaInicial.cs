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
            numericStock.Value = 5;
            this.Load += new EventHandler(Grid_Load);
            numericStock.TextChanged += new EventHandler(Grid_Load);
            numericStock.KeyUp += new KeyEventHandler(Grid_Load);
        }



        public void Grid_Load(object sender, EventArgs e)
        {
            ProductoCEN producto = new ProductoCEN();
            List<ProductoGV> productoGV = new List<ProductoGV>();
            IList<ProductoEN> lista;
            if (numericStock.Text == "")
            {
                dataGridViewStock.DataSource = productoGV;
            }
            else
            {
                lista = producto.BuscarPorStock(Convert.ToInt32(numericStock.Text));
                foreach (ProductoEN p in lista)
                {
                    productoGV.Add(new ProductoGV()
                    {
                        Id = p.Id,
                        Nombre = p.Nombre,
                        Descripcion = p.Descripcion,
                        Stock = p.Stock,
                    });
                }
                dataGridViewStock.DataSource = productoGV;
            }
        }
    }
}
