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

namespace LimpiezasPalmeralForms
{
    public partial class PantallaProveedor : Form
    {
        private ProveedorCEN _proveedor;

        public PantallaProveedor()
        {
            InitializeComponent();
            _proveedor = new ProveedorCEN();
        }

        private void altaProveedor_click(object sender, EventArgs e)
        {
            _proveedor.Crear(dniBox.Text, nombreBox.Text, telefonoBox.Text, direccionBox.Text, localidadBox.Text, provinciaBox.Text,
                codigoPostalBox.Text, emailBox.Text, paisBox.Text, descripcionBox.Text);
        }
        

    }
}
