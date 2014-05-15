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
                    select.Add(instalacion.Nombre);
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
                //IList<FacturaEN> facturas = _factura.
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSeleccion(comboBox1.Text);
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
