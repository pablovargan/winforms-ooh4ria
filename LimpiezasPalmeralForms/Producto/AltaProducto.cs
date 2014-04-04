using PalmeralGenNHibernate.CEN.Default_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                    int stock = 0;
                    stock = Convert.ToInt32(numericStock.Text);
                    if(pictureBoxImagen.ImageLocation == null)
                    {
                        pictureBoxImagen.ImageLocation = "";
                    }
                    producto.Crear(textBoxId.Text,textBoxNombre.Text,textBoxDescripcion.Text, stock, pictureBoxImagen.ImageLocation);
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
