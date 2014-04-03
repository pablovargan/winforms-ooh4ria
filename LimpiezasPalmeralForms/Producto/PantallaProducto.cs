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
        public PantallaProducto()
        {
            InitializeComponent();
            this.Load += new EventHandler(Grid_Load);
            this.Load += new EventHandler(Grid_Load);
            // Mostrar.LostFocus += new EventHandler(Desactivar_Botones);
            textBoxBuscar.KeyUp += new KeyEventHandler(Buscar_Productos);
            comboBoxFiltro.SelectedIndex = 0;
            //Eliminar.Click += new EventHandler(Grid_Load);
        }
        private void Buscar_Productos(object sender, EventArgs e)
        {
            ProductoCEN producto = new ProductoCEN();
            IList<ProductoEN> lista = new List<ProductoEN>();
            if (comboBoxFiltro.Text == "" || textBoxBuscar.Text == "")
            {
                Grid_Load(sender, e);
            }
            else if (comboBoxFiltro.Text == "Nombre")
            {
                lista = producto.BuscarPorNombre(textBoxBuscar.Text);
                dataGridViewProducto.DataSource = lista;

            }
            else if (comboBoxFiltro.Text == "Id")
            {
                lista.Add(producto.ObtenerProducto(textBoxBuscar.Text));
                dataGridViewProducto.DataSource = lista;
            }
            else if (comboBoxFiltro.Text == "Stock")
            {
                int stock;
                stock = Convert.ToInt32(textBoxBuscar.Text);
                lista = producto.BuscarPorStock(stock);
                dataGridViewProducto.DataSource = lista;
            }
        }
        private void Grid_Load(object sender, EventArgs e)
        {
            ProductoCEN producto = new ProductoCEN();
            List<ProductoGV> productoGV = new List<ProductoGV>();
            IList<ProductoEN> lista;
            lista = producto.ObtenerTodos(0, 0);
            foreach (ProductoEN p in lista)
            {
                //PictureBox i = new PictureBox();
                //i.ImageLocation = p.Foto;
                //i.AutoSize = true;
                //i.SizeMode = PictureBoxSizeMode.StretchImage;
                productoGV.Add(new ProductoGV()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    //Descripcion = p.Descripcion,
                    Stock = p.Stock,
                    //Foto = p.Foto,
                    //imagen = null
                });
                //DataGridViewImageColumn img = new DataGridViewImageColumn();
                //Image image = Image.FromFile(p.Foto);
                //img.Image = image;
                //dataGridViewProducto.Columns.Add(img);
            }
            dataGridViewProducto.DataSource = productoGV;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            AltaProducto ac = new AltaProducto() { Owner = this };
            ac.Owner = this;
            ac.Deactivate += new EventHandler(Grid_Load);
            ac.StartPosition = FormStartPosition.CenterParent;
            ac.ShowDialog();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_Click(object sender, EventArgs e)
        {
            textBoxBuscar.Text = "";
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            Grid_Load(sender, e);
        }
    }
    public class ProductoGV
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        //public string Descripcion { get; set; }
        public int Stock { get; set; }
        //public string Foto { get; set; }
        //public Image imagen { get; set; }
    }
}
