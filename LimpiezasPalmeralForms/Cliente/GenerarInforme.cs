using System;
using System.Windows.Forms;
using LimpiezasPalmeralForms.Servicios;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralForms.Cliente
{
    public partial class GenerarInforme : Form
    {
        string nif;
        public GenerarInforme(string nif_informe)
        {
            InitializeComponent();
            nif = nif_informe;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteCEN clienteCEN = new ClienteCEN();
            ClienteEN cliente = clienteCEN.ObtenerCliente(nif);
            GeneradorPDF pdf = new GeneradorPDF();
            pdf.pdfCliente(cliente);

        }
    }
}
