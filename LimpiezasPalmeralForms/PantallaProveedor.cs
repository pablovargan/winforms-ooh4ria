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

        public PantallaProveedor()
        {
            InitializeComponent();
            _proveedor = new ProveedorCEN();
            this.Load += new EventHandler(GridProveedor_Load); 
        }

        private void GridProveedor_Load(object sender, EventArgs e)
        {
            proveedorGrid.DataSource = _proveedor.ObtenerTodos(0,0);
        }

        private void AltaProveedor_Click(object sender, EventArgs e)
        {
            AltaProveedor ap = new AltaProveedor() { Owner = this };
            ap.Show();
            // Cuando se pierda el foco de la pantalla cargará el grid de nuevo
            ap.Deactivate += GridProveedor_Load;
        }



    }
}
