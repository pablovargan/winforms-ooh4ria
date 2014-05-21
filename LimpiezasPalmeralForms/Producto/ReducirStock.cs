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
    public partial class ReducirStock : Form
    {
        int stockProducto = 0;
        private ProductoCEN producto;
        private ProductoEN p;
        public ReducirStock(DataGridView productoSelected)
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
            if (Decimal.ToInt32(numericStock.Value) > stockProducto)
            {
                DialogResult error = MessageBox.Show(Constantes._ERRORREDUCIRSTOCK, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //si quiere reducir mas stock del que existe, mostramos mensaje de error
            else if (Decimal.ToInt32(numericStock.Value) == 0)
            {
                DialogResult error = MessageBox.Show("No se ha reducido el stock por que el valor introducido es 0 o no válido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int stockReducido = stockProducto - Decimal.ToInt32(numericStock.Value);
                producto.Editar(p.Id, p.Nombre, p.Descripcion, stockReducido, p.Foto);
                MessageBox.Show("El stock actual del producto " + p.Id + " es " + stockReducido);
                if(stockReducido == 0)
                {
                    DialogResult error = MessageBox.Show("¡ATENCION! ¡REPONGA STOCK LO ANTES POSIBLE!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
