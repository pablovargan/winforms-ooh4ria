using PalmeralGenNHibernate.CEN.Default_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms.Producto
{
    public partial class AltaProducto : Form
    {
        public AltaProducto()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ProductoCEN producto = new ProductoCEN();

            if (!string.IsNullOrWhiteSpace(textBoxId.Text as string))
            {
                try
                {
                    int stock = Convert.ToInt32(numericStock.Text);
                    producto.Crear(textBoxId.Text,textBoxNombre.Text,textBoxDescripcion.Text, stock, "");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Constantes._ERRORCREARPRODUCTO);
                }
            }
            else
                MessageBox.Show(Constantes._ERRORIDPRODUCTO);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
