using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Proveedores
using PalmeralGenNHibernate.EN.Default_;
using PalmeralGenNHibernate.CEN.Default_;

namespace LimpiezasPalmeralForms.Pedidos
{
    public partial class CrearPedido : Form
    {
        private ProveedorCEN _proveedorCEN;
        private List<ProveedorEN> _lproveedores;
        
        private ProductoCEN _productoCEN;
        private List<ProductoGV> _lproductos;

        private List<LineaPedidoEN> _lpedidos;
        public CrearPedido()
        {
            InitializeComponent();
            _proveedorCEN = new ProveedorCEN();
            _lproveedores = new List<ProveedorEN>();

            this.Load += CrearPedido_Load;
            filtroCB.SelectedIndex = 0;
            buscarTextBox.KeyUp += Grid_ProductosLoad;
        }

        private void CrearPedido_Load(object sender, EventArgs e)
        {
            _productoCEN = new ProductoCEN();
            _lproductos = new List<ProductoGV>();

            if (proveedorCB != null)
            {
                foreach (ProveedorEN p in _proveedorCEN.ObtenerTodos(0, 0))
                {
                    proveedorCB.Items.Add(p.Id);
                    _lproveedores.Add(p);
                }
            }
            fechaBox.Text = DateTime.Today.ToString("d");
            datosLabel.Text = string.Empty;
        }

        private void Grid_ProductosLoad(object sender, KeyEventArgs e)
        {
            _lproductos.Clear();
            productosGrid.DataSource = null;
            if (buscarTextBox.Text == "")
            {
                GridProductos_All();
            }
            else
            {
                if (filtroCB.Text.ToString().Equals("Nombre"))
                {
                    foreach (ProductoEN p in _productoCEN.BuscarPorNombre(buscarTextBox.Text))
                    {
                        _lproductos.Add(new ProductoGV()
                        {
                            Id = p.Id,
                            Nombre = p.Nombre,
                            Stock = p.Stock
                        });
                    }
                    productosGrid.DataSource = _lproductos;
                }
                else if (filtroCB.Text.ToString().Equals("Stock"))
                {
                    foreach (ProductoEN p in _productoCEN.BuscarPorStock(Convert.ToInt32(buscarTextBox.Text)))
                    {
                        _lproductos.Add(new ProductoGV()
                        {
                            Id = p.Id,
                            Nombre = p.Nombre,
                            Stock = p.Stock
                        });
                    }
                    productosGrid.DataSource = _lproductos;
                }
                else
                {
                    var pr = _productoCEN.ObtenerProducto(buscarTextBox.Text.ToString());
                    if (pr != null)
                    {
                        _lproductos.Add(new ProductoGV()
                        {
                            Id = pr.Id,
                            Nombre = pr.Nombre,
                            Stock = pr.Stock
                        });
                    }
                    productosGrid.DataSource = _lproductos;
                }
            }

            if (productosGrid.Rows.Count == 0)
                agregarButton.Enabled = false;
        }

        private void GridProductos_All()
        {
            foreach (ProductoEN p in _productoCEN.ObtenerTodos(0, 0))
            {
                _lproductos.Add(new ProductoGV()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Stock = p.Stock
                });
            }
        }

        private void Alta_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Proveedor_Selected(object sender, EventArgs e)
        {
            var prov = _lproveedores.First(p => p.Id == proveedorCB.Text);
            datosLabel.Text = String.Format("{0} - {1}{2}{3}{4}{5} {6}{7}{8} - {9}{10}",
                prov.Nombre, prov.Email, Environment.NewLine,
                prov.Direccion, Environment.NewLine,
                prov.CodigoPostal, prov.Localidad, Environment.NewLine,
                prov.Provincia, prov.Pais, Environment.NewLine);

            busquedaBox.Enabled = true;
            pedidoGB.Enabled = true;

            _lproductos.Clear();
            productosGrid.DataSource = null;
            GridProductos_All();
            productosGrid.DataSource = _lproductos;
        }

        private void Buscador_Click(object sender, EventArgs e)
        {
            buscarTextBox.Clear();
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            var columnaSeleccionada = productosGrid.SelectedRows[0].Cells["Id"].Value.ToString();
            //_lpedidos.Add()
        }
    }

    public class ProductoGV
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
    }
}
