using LimpiezasPalmeralForms.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms
{
    public partial class PantallaCliente : Form
    {
        public PantallaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaCliente ac = new AltaCliente() { Owner = this };
            ac.Show();
            // Cuando se pierda el foco de la pantalla cargará el grid de nuevo
            //ac.Deactivate += GridClient
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
