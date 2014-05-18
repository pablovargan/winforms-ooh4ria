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
using PalmeralGenNHibernate.Enumerated.Default_;

namespace LimpiezasPalmeralForms.Pedidos
{
    public partial class CrearPedido : Form
    {
        private ProveedorCEN _proveedorCEN;
        private ProveedorEN _proveedor;
        private List<ProveedorEN> _lproveedores;
        
        private ProductoCEN _productoCEN;
        private List<ProductoGV> _lproductos;
        private List<PedidoGV> _lproductosPedido;

        public CrearPedido()
        {
            InitializeComponent();
            _proveedorCEN = new ProveedorCEN();
            _lproveedores = new List<ProveedorEN>();

            contadoRB.Tag = TipoPagoEnum.Contado;
            pagareRB.Tag = TipoPagoEnum.Pagare;
            transferenciaRB.Tag = TipoPagoEnum.Transferencia;

            this.Load += CrearPedido_Load;
            filtroCB.SelectedIndex = 0;
            buscarTextBox.KeyUp += Grid_ProductosLoad;
        }

        private void CrearPedido_Load(object sender, EventArgs e)
        {
            _productoCEN = new ProductoCEN();
            _lproductos = new List<ProductoGV>();
            _lproductosPedido = new List<PedidoGV>();

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
            else
                agregarButton.Enabled = true;
            
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

        private void Crear_Click(object sender, EventArgs e)
        {
            PedidoCEN pedidoCEN = new PedidoCEN();
            LineaPedidoCEN lineaPedidoCEN = new LineaPedidoCEN();
            // Radiobox seleccionado con el tipo de enum
            var enumSeleccionado = (TipoPagoEnum)pedidoGB.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Tag;
            // Obtengo el numero de pedido a crear 
            int idPedido = pedidoCEN.ObtenerTodos(0, 0).Count + 1;
            // Linea de Pedido a insertar
            IList<LineaPedidoEN> lineaPedido = new List<LineaPedidoEN>();
            // Lista para relacionar las lineas con el pedido
            IList<int> idLineas = new List<int>();
            // Cojo la cantidad y el id de los productos del grid del pedido

            
            foreach (PedidoGV p in _lproductosPedido)
            {
                // Añado a la lista
                lineaPedido.Add(new LineaPedidoEN(Convert.ToInt32(p.Id), Convert.ToInt32(p.Cantidad), 
                    _productoCEN.get_IProductoCAD().ReadOIDDefault(p.Id), null));
                idLineas.Add(Convert.ToInt32(p.Id));
            }
            // Instancio y Creo el pedido
            var pFinal = new PedidoEN(idPedido.ToString(), DateTime.Today, EstadoPedidoEnum.Enviado, enumSeleccionado, lineaPedido, _proveedorCEN.get_IProveedorCAD().ReadOIDDefault(_proveedor.Id));
            pedidoCEN.Crear(pFinal.Id, pFinal.Fecha, pFinal.Estado, pFinal.TipoPago, pFinal.Lineas, pFinal.Proveedor.Id);
            // Relaciono las lineas con el pedido
            pedidoCEN.Relationer_lineas(idPedido.ToString(), idLineas);
            
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Proveedor_Selected(object sender, EventArgs e)
        {
            var prov = _lproveedores.First(p => p.Id == proveedorCB.Text);
            _proveedor = prov;

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
            var idSeleccionado = productosGrid.SelectedRows[0].Cells["Id"].Value.ToString();
            bool existe = false;
            for (int i = 0; i < _lproductosPedido.Count && !existe; i++)
            {
                if (_lproductosPedido[i].Id.Equals(idSeleccionado))
                {
                    _lproductosPedido[i].Cantidad += 1;
                    existe = true;
                }
            }

            if (!existe)
            {
                var productoSeleccionado = _lproductos.First(p => p.Id == idSeleccionado);
                _lproductosPedido.Add(new PedidoGV()
                {
                    Id = productoSeleccionado.Id,
                    Nombre = productoSeleccionado.Nombre,
                    Cantidad = 1
                });
            }

            BindingSource source = new BindingSource();
            source.DataSource = _lproductosPedido;
            pedidoGrid.DataSource = source;

            source.ResetBindings(false);

            if (_lproductosPedido.Count > 0)
            {
                eliminarButton.Enabled = true;
                crearButton.Enabled = true;
            }
        }

        private void EliminarLinea_Click(object sender, EventArgs e)
        {
            var idSeleccionado = pedidoGrid.SelectedRows[0].Cells["Id"].Value.ToString();
            System.Diagnostics.Debug.WriteLine(idSeleccionado);
            for (int i = 0; i < _lproductosPedido.Count; i++)
            {
                if (_lproductosPedido[i].Id.Equals(idSeleccionado))
                {
                    _lproductosPedido.RemoveAt(i);
                    if (_lproductosPedido.Count == 0)
                    {
                        eliminarButton.Enabled = false;
                        crearButton.Enabled = false;
                    }
                }
            }

            BindingSource source = new BindingSource();
            source.DataSource = _lproductosPedido;
            pedidoGrid.DataSource = source;

            source.ResetBindings(false);

        }
    }

    public class ProductoGV
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
    }

    public class PedidoGV
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}
