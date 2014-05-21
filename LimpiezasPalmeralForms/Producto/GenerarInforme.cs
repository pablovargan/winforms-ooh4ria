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
using LimpiezasPalmeralForms.Servicios;

namespace LimpiezasPalmeralForms.Producto
{
    public partial class GenerarInforme : Form
    {
        ProductoEN producto = new ProductoEN();
        public GenerarInforme(string id)
        {
            InitializeComponent();
            ProductoCEN productoCEN = new ProductoCEN();
            producto = productoCEN.ObtenerProducto(id);
            desactivarCampos();
            pintarCabeceraEmpresa();
            pintarDatosProducto();
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

        private void pintarDatosProducto()
        {
            textBoxId.Text = producto.Id;
            textBoxNombre.Text = producto.Nombre;
            textBoxDescripcion.Text = producto.Descripcion;
            numericStock.Value = producto.Stock;
            pictureBoxImagen.ImageLocation = producto.Foto;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pintarCabeceraEmpresa()
        {
            labelNombreEmpresa.Text = Constantes._NOMBREEMPRESA;
            labelFechaInforme.Text = DateTime.Now.ToString();
            labelCiudadInforme.Text = Constantes._CIUDADEMPRESA;

        }

        private void buttonGenerarPDF_Click(object sender, EventArgs e)
        {
            GeneradorPDF pdf = new GeneradorPDF();
            pdf.pdfProducto(producto);
            this.Close();
        }
    }
}
