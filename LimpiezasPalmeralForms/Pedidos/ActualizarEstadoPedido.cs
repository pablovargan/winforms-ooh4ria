using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
using PalmeralGenNHibernate.Enumerated.Default_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms.Pedidos
{
    public partial class ActualizarEstadoPedido : Form
    {
        public string IdPedido { get; set; }
        public string IdProveedor { get; set; }

        public ActualizarEstadoPedido()
        {
            InitializeComponent();
            estadoCB.DataSource = Enum.GetValues(typeof(EstadoPedidoEnum));
            this.Load += GroupBox_Load;
        }

        private void GroupBox_Load(object sender, EventArgs e)
        {
            ProveedorCEN proveedorCEN = new ProveedorCEN();
            var proveedor = proveedorCEN.ObtenerProveedor(IdProveedor);
            // Lo pinto en el form
            datosLabel.Text = String.Format("{0} - {1}{2}{3}{4}{5} {6}{7}{8} - {9}{10}",
                proveedor.Nombre, proveedor.Email, Environment.NewLine,
                proveedor.Direccion, Environment.NewLine,
                proveedor.CodigoPostal, proveedor.Localidad, Environment.NewLine,
                proveedor.Provincia, proveedor.Pais, Environment.NewLine);
            PedidoCEN pedidoCEN = new PedidoCEN();
            var pedido = pedidoCEN.ObtenerPedido(IdPedido);
            // Pinto la fecha, tipo de pago y el enum
            fechaBox.Text = pedido.Fecha.ToString();
            pagoBox.Text = pedido.TipoPago.ToString();
            string[] estados = { "Pendiente", "Enviado", "Recibido", "Cancelado" };
            for (int i = 0; i < estados.Length; i++)
            {
                if (estados[i].Equals(pedido.Estado.ToString()))
                    estadoCB.SelectedIndex = i;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            var enumSelected = (EstadoPedidoEnum)Enum.Parse(typeof(EstadoPedidoEnum), estadoCB.SelectedValue.ToString());
            if (enumSelected.Equals(EstadoPedidoEnum.Recibido))
            {
                // Aumentamos el stock de todos los productos del pedido
                LineaPedidoCEN lineaPedidoCEN = new LineaPedidoCEN();
                ProductoCEN productoCEN = new ProductoCEN();
                var l = new List<LineasGV>();
                foreach (LineaPedidoEN linea in lineaPedidoCEN.ObtenerLineasDePedido(IdPedido))
                {
                    var producto = new ProductoCEN().ObtenerProducto(linea.Productos.Id);
                    productoCEN.Editar(producto.Id, producto.Nombre, producto.Descripcion,
                        producto.Stock + linea.Cantidad, producto.Foto);
                }
            }
            var pedido = new PedidoCEN().ObtenerPedido(IdPedido);
            new PedidoCEN().Editar(IdPedido, pedido.Fecha, enumSelected, pedido.TipoPago);

            this.Close();
        }
    }
}
