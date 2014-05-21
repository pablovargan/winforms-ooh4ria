using LimpiezasPalmeralForms.Producto;
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

namespace LimpiezasPalmeralForms.Producto
{
    public partial class ConsultarProducto : Form
    {
        DataGridView grid;
        public ConsultarProducto(DataGridView productoSelected)
        {
            InitializeComponent();
            desactivarCampos();

            grid = productoSelected;
            obtenerDatosProducto(productoSelected);
        }
        public void desactivarCampos()
        {
            textBoxId.Enabled = false;
            textBoxNombre.Enabled = false;
            textBoxDescripcion.Enabled = false;
            numericStock.Enabled = false;
            pictureBoxImagen.Enabled = false;
            //buttonEscogerImagen.Enabled = false;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void obtenerDatosProducto(DataGridView productoSelected)
        {
            ProductoCEN producto = new ProductoCEN();
            string id = productoSelected.SelectedRows[0].Cells[0].Value.ToString();
            ProductoEN p = producto.ObtenerProducto(id);

            textBoxId.Text = p.Id;
            textBoxNombre.Text = p.Nombre;
            textBoxDescripcion.Text = p.Descripcion;
            numericStock.Value = p.Stock;
            pictureBoxImagen.ImageLocation = p.Foto;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarProducto ac = new EditarProducto(grid) { Owner = this };
            ac.Owner = this;
            ac.StartPosition = FormStartPosition.CenterParent;
            ac.ShowDialog(); 
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string id = textBoxId.Text;
            ProductoCEN producto = new ProductoCEN();
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
