using System;
using System.Windows.Forms;
using LimpiezasPalmeralForms.Servicios;

namespace LimpiezasPalmeralForms.Cliente
{
    public partial class GenerarInforme : Form
    {
        public GenerarInforme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneradorPDF pdf = new GeneradorPDF("Cliente", "1111");

        }
    }
}
