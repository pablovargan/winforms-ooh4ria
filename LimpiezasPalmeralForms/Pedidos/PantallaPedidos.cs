using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Pedidos
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
using LimpiezasPalmeralForms.Pedidos;

namespace LimpiezasPalmeralForms.Proveedor.Pedidos
{
    public partial class PantallaPedidos : Form
    {
        private PedidoCEN _pedido;
        private List<PedidoGV> _pedGV;

        public PantallaPedidos()
        {
            InitializeComponent();
            _pedido = new PedidoCEN();
            _pedGV = new List<PedidoGV>();
            this.Load += GridPedido_Load;
        }

        private void GridPedido_Load(object sender, EventArgs e)
        {
            if (_pedGV != null)
            {
                pedidoGrid.DataSource = null;
                _pedGV.Clear();

                var todosPedidos = _pedido.ObtenerTodos(0, 0);
                //foreach (PedidoEN p in todosPedidos)
                foreach (PedidoEN p in _pedido.ObtenerTodos(0, 0))
                {
                    _pedGV.Add(new PedidoGV()
                    {
                        Id = p.Id,
                        Fecha = p.Fecha,
                        Estado = p.Estado,
                        TipoPago = p.TipoPago,
                        Proveedor = p.Proveedor.Id
                    });
                }
                if (_pedGV.Count == 0)
                    EnableDisableBT(this, false);
                else
                    EnableDisableBT(this, true);

                pedidoGrid.DataSource = _pedGV;
            }
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            CrearPedido cp = new CrearPedido() { Owner = this };
            cp.Show();
            cp.Deactivate += GridPedido_Load;
        }

        private void EnableDisableBT(Control container, bool mode)
        {
            foreach (Control c in container.Controls)
            {
                if (!c.Name.ToString().Equals("crearButton") && c is Button)
                    (c as Button).Enabled = mode;
                else if (c is GroupBox)
                    EnableDisableBT(c, mode);
            }
        }
    }

    public class PedidoGV
    {
        public string Id { get; set; }
        public DateTime? Fecha { get; set; }
        public PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum Estado { get; set; }
        public PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum TipoPago { get; set; }
        public string Proveedor { get; set; }
    }
}
