using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
using PalmeralGenNHibernate.CAD.Default_;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalmeralGenNHibernate.Enumerated.Default_;

namespace LimpiezasPalmeralForms.Pedidos
{
    public partial class ConsultarPedido : Form
    {
        public string IdPedido { get; set; }
        public string IdProveedor { get; set; }

        public ConsultarPedido()
        {
            InitializeComponent();

            estadoCB.DataSource = Enum.GetValues(typeof(EstadoPedidoEnum));
            this.Load += Form_Load;
        }

        private void Form_Load(object sender, EventArgs e)
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
            for(int i = 0; i < estados.Length; i++)
            {
                if(estados[i].Equals(pedido.Estado.ToString()))
                    estadoCB.SelectedIndex = i;
            }
            // Obtengo el pedido para mostrarlo entero 
        }


        private void Actualizar_Click(object sender, EventArgs e)
        {
            estadoCB.Enabled = true;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (estadoCB.Enabled)
            {
                var estado = (EstadoPedidoEnum) Enum.Parse(estadoCB.SelectedValue, EstadoPedidoEnum);

            }
        
            this.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
    class LineasGV
    {
        public int Id { get; set; }
    }
}
