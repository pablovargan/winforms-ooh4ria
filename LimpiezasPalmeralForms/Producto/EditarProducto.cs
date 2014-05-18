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
using System.IO;

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

        private void buttonEscogerImagen_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|Image files (*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string imagen;
                            imagen = openFileDialog1.FileName;
                            pictureBoxImagen.ImageLocation = imagen;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
