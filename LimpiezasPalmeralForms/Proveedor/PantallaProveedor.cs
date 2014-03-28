using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Proveedor
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralForms
{
    public partial class PantallaProveedor : Form
    {
        private ProveedorCEN _proveedor;
        private List<ProveedorGV> _provGD;

        public PantallaProveedor()
        {
            InitializeComponent();
            _proveedor = new ProveedorCEN();
            _provGD = new List<ProveedorGV>();
            this.Load += GridProveedor_Load;
        }

        private void GridProveedor_Load(object sender, EventArgs e)
        {
            if(_provGD != null)
            {
                proveedorGrid.DataSource = null;
                _provGD.Clear();
                foreach (ProveedorEN p in _proveedor.ObtenerTodos(0, 0))
                {
                    _provGD.Add(new ProveedorGV()
                    {
                        NIF = p.Id,
                        Nombre = p.Nombre,
                        Email = p.Email,
                        Direccion = p.Direccion,
                        Localidad = p.Localidad,
                        Provincia = p.Provincia,
                        Telefono = p.Telefono,
                        CodigoPostal = p.CodigoPostal,
                        Pais = p.Pais
                    });
                }
                proveedorGrid.DataSource = _provGD;
            } 
        }

        private void AltaProveedor_Click(object sender, EventArgs e)
        {
            AltaProveedor ap = new AltaProveedor() { Owner = this };
            ap.Show();
            ap.Deactivate += GridProveedor_Load;
        }

        private void Buscador_Click(object sender, EventArgs e)
        {
            busquedaBox.Clear();
            busquedaBox.TextChanged += GridProveedor_Load;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(busquedaBox.Text as string))
            {
                if(_provGD != null )
                {
                    proveedorGrid.DataSource = null;
                    ProveedorEN p = _proveedor.ObtenerProveedor(busquedaBox.Text);
                    if (p != null)
                    {
                        _provGD.Clear();
                        _provGD.Add(new ProveedorGV()
                        {
                            NIF = p.Id,
                            Nombre = p.Nombre,
                            Email = p.Email,
                            Direccion = p.Direccion,
                            Localidad = p.Localidad,
                            Provincia = p.Provincia,
                            Telefono = p.Telefono,
                            CodigoPostal = p.CodigoPostal,
                            Pais = p.Pais
                        });
                        proveedorGrid.DataSource = _provGD;
                    }
                }
            }
        }
    }

    public class ProveedorGV
    {
        public string NIF { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Telefono { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
    }
}
