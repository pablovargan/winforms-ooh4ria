using LimpiezasPalmeralForms.Producto;
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
    public partial class PantallaProducto : Form
    {
        private IList<ProductoEN> lista;
        ProductoCEN producto;
        public PantallaProducto()
        {
            InitializeComponent();
            producto = new ProductoCEN();
            lista = new List<ProductoEN>();

            lista = producto.ObtenerTodos(0, 0);
            this.Load += new EventHandler(Grid_Load);

            textBoxBuscar.KeyUp += new KeyEventHandler(Buscar_Productos);
            comboBoxFiltro.SelectedIndex = 0;
        }
        private void Buscar_Productos(object sender, EventArgs e)
        {
            if (comboBoxFiltro.Text == "" || textBoxBuscar.Text == "")
            {
                recargarGrid(sender,e);
            }
            else if (comboBoxFiltro.Text == "Nombre")
            {
                lista = new List<ProductoEN>();
                lista = producto.BuscarPorNombre(textBoxBuscar.Text);
                Grid_Load(sender, e);
                //dataGridViewProducto.DataSource = lista;
            }
            else if (comboBoxFiltro.Text == "Id")
            {
                lista = new List<ProductoEN>();
                ProductoEN p = producto.ObtenerProducto(textBoxBuscar.Text);
                if (p == null)
                {
                    List<ProductoGV> productoGV = new List<ProductoGV>();
                    dataGridViewProducto.DataSource = productoGV;
                }
                else
                {
                    lista.Add(p);
                    Grid_Load(sender, e);
                }
                //dataGridViewProducto.DataSource = lista;
            }
            else if (comboBoxFiltro.Text == "Stock")
            {
                int stock;
                lista = new List<ProductoEN>();
                stock = Convert.ToInt32(textBoxBuscar.Text);
                lista = producto.BuscarPorStock(stock);
                //dataGridViewProducto.DataSource = lista;
                Grid_Load(sender, e);
            }
        }
        private void Grid_Load(object sender, EventArgs e)
        {
            List<ProductoGV> productoGV = new List<ProductoGV>();

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
            dataGridViewProducto.DataSource = productoGV;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            AltaProducto ac = new AltaProducto() { Owner = this };
            ac.Owner = this;
            ac.Deactivate += new EventHandler(recargarGrid);
            ac.StartPosition = FormStartPosition.CenterParent;
            ac.ShowDialog();
        }
        private void recargarGrid(object sender, EventArgs e)
        {
            lista = producto.ObtenerTodos(0, 0);
            Grid_Load(sender, e);
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProducto consulta = new ConsultarProducto(dataGridViewProducto) { Owner = this };
            consulta.Owner = this;
            consulta.Deactivate += new EventHandler(recargarGrid);
            consulta.StartPosition = FormStartPosition.CenterParent;
            consulta.ShowDialog();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarProducto editar = new EditarProducto(dataGridViewProducto) { Owner = this };
            editar.Owner = this;
            editar.Deactivate += new EventHandler(recargarGrid);
            editar.StartPosition = FormStartPosition.CenterParent;
            editar.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string id = dataGridViewProducto.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult confirmar = MessageBox.Show("¿Desea eliminar el producto " + id + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(confirmar == DialogResult.Yes)
            {
                producto.Eliminar(id);

                MessageBox.Show("El producto " + id +" ha sido eliminado");
            }
            recargarGrid(sender,e);
        }

        private void textBoxBuscar_Click(object sender, EventArgs e)
        {
            textBoxBuscar.Text = "";
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            Grid_Load(sender, e);
        }

        private void buttonReducirStock_Click(object sender, EventArgs e)
        {
            ReducirStock reducir = new ReducirStock(dataGridViewProducto) { Owner = this };
            reducir.Owner = this;
            reducir.Deactivate += new EventHandler(recargarGrid);
            reducir.StartPosition = FormStartPosition.CenterParent;
            reducir.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncrementarStock incrementar = new IncrementarStock(dataGridViewProducto) { Owner = this };
            incrementar.Owner = this;
            incrementar.Deactivate += new EventHandler(recargarGrid);
            incrementar.StartPosition = FormStartPosition.CenterParent;
            incrementar.ShowDialog();
        }
    }
    public class ProductoGV
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        //public string Foto { get; set; }
        //public Image imagen { get; set; }
    }
}
