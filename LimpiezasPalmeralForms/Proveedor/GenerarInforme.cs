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
    public partial class GenerarInforme : Form
    {
        private ProveedorCEN _proveedor;
        public string Nif { get; set; }
        public GenerarInforme()
        {
            InitializeComponent();
            _proveedor = new ProveedorCEN();
            this.Load += Form_Load;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            labelNombreEmpresa.Text = Constantes._NOMBREEMPRESA;
            labelFechaInforme.Text = DateTime.Now.ToString();
            labelCiudadInforme.Text = Constantes._CIUDADEMPRESA;

            ProveedorEN p = _proveedor.ObtenerProveedor(Nif);
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
            var listaFiltrada = new List<PedidoGV>();
            IList<PedidoEN> pedidos = new PedidoCEN().ObtenerTodos(0, 0);
            foreach (PedidoEN ped in pedidos)
            {
                if (p.Equals(ped.Proveedor))
                {
                    listaFiltrada.Add(new PedidoGV()
                    {
                        Id = ped.Id,
                        Fecha = ped.Fecha,
                        Estado = ped.Estado.ToString(),
                        TipoPago = ped.TipoPago.ToString()
                    });
                }
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
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
