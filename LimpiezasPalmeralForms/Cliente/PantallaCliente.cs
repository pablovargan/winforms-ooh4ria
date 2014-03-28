using LimpiezasPalmeralForms.Cliente;
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

namespace LimpiezasPalmeralForms
{
    public partial class PantallaCliente : Form
    {
        public PantallaCliente()
        {
            InitializeComponent();
            this.Load += new EventHandler(Grid_Load);
            this.Load += new EventHandler(Grid_Load);
            // Mostrar.LostFocus += new EventHandler(Desactivar_Botones);
            textBoxBuscar.KeyUp += new KeyEventHandler(Buscar_Clientes);
            comboBoxFiltro.SelectedIndex = 0;
            //Eliminar.Click += new EventHandler(Grid_Load);
        }

        private void Buscar_Clientes(object sender, EventArgs e)
        {
            ClienteCEN cliente = new ClienteCEN();
            IList<ClienteEN> lista = new List<ClienteEN>();
            if (comboBoxFiltro.Text == "" || textBoxBuscar.Text == "")
            {
                Grid_Load(sender, e);
            }
            else if (comboBoxFiltro.Text == "Nombre")
            {
                lista = cliente.BuscarPorNombre(textBoxBuscar.Text);
                dataGridViewCliente.DataSource = lista;

            }
            else if (comboBoxFiltro.Text == "NIF")
            {
                lista.Add(cliente.ObtenerCliente(textBoxBuscar.Text));
                dataGridViewCliente.DataSource = lista;
            }
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            ClienteCEN cliente = new ClienteCEN();
            IList<ClienteEN> lista;
            lista = cliente.ObtenerTodos(0, 0);
            dataGridViewCliente.DataSource = lista;

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

        private void textBoxBuscar_Click(object sender, EventArgs e)
        {
            textBoxBuscar.Text = "";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            /* 
             
            ClienteCEN cliente = new ClienteCEN();
            ClienteEN clienteEliminado = (ClienteEN)dataGridViewCliente.CurrentRow.DataBoundItem;
            MessageBox.Show(clienteEliminado.Nif);
            cliente.Eliminar(clienteEliminado.Nif);
            Grid_Load(sender, e);
             
             */
        }
    }
}
