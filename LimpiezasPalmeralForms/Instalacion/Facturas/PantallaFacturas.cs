using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralForms.Instalacion.Facturas
{
    public partial class PantallaFacturas : Form
    {
        FacturaCEN _factura;
        IList<FacturaGV> _factGV;

        public PantallaFacturas()
        {
            InitializeComponent();
            _factura = new FacturaCEN();
            _factGV = new List<FacturaGV>();
            this.Load += facturaGrid_Load;
        }

        private void PantallaFacturas_Load(object sender, EventArgs e)
        {
            LoadFiltro();
        }

        public void LoadFiltro()
        {
            IList<string> filtro = new List<string>();
            filtro.Add("Todas las facturas");
            filtro.Add("Facturas por instalación");
            filtro.Add("Facturas por año");
            comboBox1.DataSource = filtro;
            LoadSeleccion("Todas las facturas");
        }

        public void LoadSeleccion(string filtro)
        {
            IList<string> select = new List<string>();

            if (filtro == "Todas las facturas")
            {
                select.Add("Todas las facturas");
            }

            else if (filtro == "Facturas por instalación")
            {
                IList<InstalacionEN> instalaciones = new List<InstalacionEN>();
                instalaciones = new InstalacionCEN().ObtenerTodas(0, 0);

                foreach (InstalacionEN instalacion in instalaciones)
                {
                    select.Add(instalacion.Id);
                }
            }

            else if (filtro == "Facturas por año")
            {
                for (int i = 2014; i >= 1990; i--)
                {
                    select.Add(i.ToString());
                }
            }

            comboBox2.DataSource = select;
        }

        private void facturaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facturaGrid_Load(object sender, EventArgs e)
        {
            if (_factGV != null)
            {
                facturaGrid.DataSource = null;
                _factGV.Clear();
                
                // Todas las facturas.
                if(comboBox1.Text == "Todas las facturas") {
                    IList<FacturaEN> facturas = _factura.ObtenterTodas(0, 0);

                    foreach (FacturaEN f in facturas)
                    {
                        _factGV.Add(new FacturaGV()
                        {
                            id = f.Id,
                            horas = f.Horas,
                            precio_hora = f.PrecioHora,
                            fecha = f.Fecha,
                            total = f.Total,
                            instalacion = f.Instalacion.Id
                        });
                    }
                }
                
                // Facturas por instalación.
                else if (comboBox1.Text == "Facturas por instalación")
                {
                    IList<FacturaEN> facturas = _factura.ObtenerFacturasInstalacion(comboBox2.Text);

                    foreach (FacturaEN f in facturas)
                    {
                        _factGV.Add(new FacturaGV()
                        {
                            id = f.Id,
                            horas = f.Horas,
                            precio_hora = f.PrecioHora,
                            fecha = f.Fecha,
                            total = f.Total,
                            instalacion = f.Instalacion.Id
                        });
                    }
                }

                // Facturas por año.
                else if (comboBox1.Text == "Facturas por año")
                {
                    IList<FacturaEN> facturas = _factura.ObtenerPorAnyo(comboBox2.Text);

                    foreach (FacturaEN f in facturas)
                    {
                        _factGV.Add(new FacturaGV()
                        {
                            id = f.Id,
                            horas = f.Horas,
                            precio_hora = f.PrecioHora,
                            fecha = f.Fecha,
                            total = f.Total,
                            instalacion = f.Instalacion.Id
                        });
                    }
                }
            }

            facturaGrid.DataSource = _factGV;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            facturaGrid_Load(sender,e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSeleccion(comboBox1.Text);
            facturaGrid_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearFactura crear = new CrearFactura() { Owner = this };
            crear.Owner = this;
            crear.Deactivate += new EventHandler(facturaGrid_Load);
            crear.Show();
        }

    }

    public class FacturaGV
    {
        public string id { get; set; }
        public float horas { get; set; }
        public float precio_hora { get; set; }
        public Nullable<DateTime> fecha { get; set; }
        public float total { get; set; }
        public string instalacion { get; set; }
    }
}
