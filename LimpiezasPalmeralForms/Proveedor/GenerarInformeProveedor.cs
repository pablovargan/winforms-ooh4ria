using LimpiezasPalmeralForms.Servicios;
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

namespace LimpiezasPalmeralForms.Proveedor
{

    public partial class GenerarInformeProveedor : Form
    {
        public string Nif { get; set; }

        public GenerarInformeProveedor()
        {
            InitializeComponent();
            this.Load += Form_Load;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // EmpresaGB
            labelNombreEmpresa.Text = Constantes._NOMBREEMPRESA;
            labelFechaInforme.Text = DateTime.Now.ToString();
            labelCiudadInforme.Text = Constantes._CIUDADEMPRESA;
            // ProveedorGB
            ProveedorEN p = new ProveedorCEN().ObtenerProveedor(Nif);
            if (p != null)
            {
                nifBox.Text = p.Id;
                nombreBox.Text = p.Nombre;
                emailBox.Text = p.Email;
                direccionBox.Text = p.Direccion;
                localidadBox.Text = p.Localidad;
                provinciaBox.Text = p.Provincia;
                telefonoBox.Text = p.Telefono;
                codigoPostalBox.Text = p.CodigoPostal;
                paisBox.Text = p.Pais;
                descripcionBox.Text = p.Descripcion;
            }
            // Pedidos
            PedidoCEN pedidoCEN = new PedidoCEN();
            ProveedorCEN proveedorCEN = new ProveedorCEN();
            var listaFiltrada = new List<PedidoGV>();
            foreach (var pedido in pedidoCEN.ObtenerTodos(0, 0))
            {
                if (p.Equals(pedido.Proveedor))
                {
                    listaFiltrada.Add(new PedidoGV()
                    {
                        Id = pedido.Id,
                        Fecha = pedido.Fecha,
                        Estado = pedido.Estado.ToString(),
                        TipoPago = pedido.TipoPago.ToString()
                    });
                }
            }
            instalacionesGridView.DataSource = listaFiltrada;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarInforme_Click(object sender, EventArgs e)
        {
            ProveedorEN proveedor = new ProveedorCEN().ObtenerProveedor(Nif);
            GeneradorPDF pdf = new GeneradorPDF();
            pdf.pdfProveedor(proveedor);
            this.Close();
        }
    }


    public class PedidoGV
    {
        public string Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }
        public string TipoPago { get; set; }
    }
}
