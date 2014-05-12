using System;
using System.Collections.Generic;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms.Producto
{
    public partial class EditarProducto : Form
    {
        private ProductoCEN producto;
        private ProductoEN p;
        public EditarProducto(DataGridView productoSelected)
        {
            InitializeComponent();
            producto = new ProductoCEN();

            obtenerDatosProducto(productoSelected);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int stock = Decimal.ToInt32(numericStock.Value);
            producto.Editar(textBoxId.Text, textBoxNombre.Text, textBoxDescripcion.Text, stock, pictureBoxImagen.ImageLocation);
            MessageBox.Show("Los cambios han sido guardados");
            this.Close();
        }
        private void obtenerDatosProducto(DataGridView productoSelected)
        {
            string id = productoSelected.SelectedRows[0].Cells[0].Value.ToString();
            p = producto.ObtenerProducto(id);

            textBoxId.Text = p.Id;
            textBoxId.Enabled = false;
            textBoxNombre.Text = p.Nombre;
            textBoxDescripcion.Text = p.Descripcion;
            numericStock.Value = p.Stock;
            pictureBoxImagen.ImageLocation = p.Foto;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            DialogResult confirmar = MessageBox.Show("¿Desea eliminar el producto " + id + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                producto.Eliminar(id);
                MessageBox.Show("El producto " + id + " ha sido eliminado");
            }
            this.Close();
        }
    }
}
