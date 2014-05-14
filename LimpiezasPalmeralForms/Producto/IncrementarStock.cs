using System;
using System.Collections.Generic;
using System.ComponentModel;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms.Producto
{
    public partial class IncrementarStock : Form
    {
        int stockProducto = 0;
        private ProductoCEN producto;
        private ProductoEN p;
        public IncrementarStock(DataGridView productoSelected)
        {
            InitializeComponent();

            string id = productoSelected.SelectedRows[0].Cells[0].Value.ToString();
            //obtengo el stock del producto que quiere reducir el stock
            producto = new ProductoCEN();
            p = producto.ObtenerProducto(id);
            stockProducto = p.Stock;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //controlar si el valor es 0 o no valido
            if (Decimal.ToInt32(numericStock.Value) == 0)
            {
                DialogResult error = MessageBox.Show("No se ha incrementado el stock por que el valor introducido es 0 o no válido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int stockIncrementado = stockProducto + Decimal.ToInt32(numericStock.Value);
                producto.Editar(p.Id, p.Nombre, p.Descripcion, stockIncrementado, p.Foto);
                MessageBox.Show("El stock actual del producto " + p.Id + " es " + stockIncrementado);
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
