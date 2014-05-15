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
            this.Load += PantallaFacturas_Load;
        }

        private void PantallaFacturas_Load(object sender, EventArgs e)
        {
            LoadFiltro();
        }

        public void LoadFiltro()
        {
            IList<string> busqueda = new List<string>();
            busqueda.Add("Todas las facturas");
            busqueda.Add("Facturas por instalación");
            busqueda.Add("Facturas por año");
            busqueda.Add("Facturas por mes/año");
            comboBox1.DataSource = busqueda;
            LoadSeleccion();
        }

        public void LoadSeleccion()
        {

        }

        private Boolean ProvinciaRepetida(IList<string> lista, string prov)
        {
            foreach (string dato in lista)
            {
                if (dato == prov)
                {
                    return true;
                }
            }

            return false;
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
                //IList<FacturaEN> facturas = _factura.
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInstalacion(comboBox1.Text);
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
