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
            textBoxBuscar.KeyUp += new KeyEventHandler(Buscar_Clientes);
            comboBoxFiltro.SelectedIndex = 0;
            //Eliminar.Click += new EventHandler(Grid_Load);
        }

        private void Buscar_Clientes(object sender, EventArgs e)
        {
            ClienteCEN cliente = new ClienteCEN();
            List<ClienteGV> clienteGV = new List<ClienteGV>();
            IList<ClienteEN> lista = new List<ClienteEN>();
            if (comboBoxFiltro.Text == "" || textBoxBuscar.Text == "")
            {
                Grid_Load(sender, e);
            }
            else if (comboBoxFiltro.Text == "Nombre")
            {
                lista = cliente.BuscarPorNombre(textBoxBuscar.Text);
                clienteGV = modificarFV(lista);
                dataGridViewCliente.DataSource = clienteGV;
            }
            else 
            {
                ClienteEN clienteBusqueda = cliente.ObtenerCliente(textBoxBuscar.Text);
                if (clienteBusqueda == null)
                {
                    List<ClienteGV> listaclienteGV = new List<ClienteGV>();
                    dataGridViewCliente.DataSource = listaclienteGV;
                }
                else
                {
                    lista.Add(clienteBusqueda);
                    clienteGV = modificarFV(lista);
                    dataGridViewCliente.DataSource = clienteGV;
                }
            }
        }

        private List<ClienteGV> modificarFV(IList<ClienteEN> lista)
        {
            List<ClienteGV> clienteGV = new List<ClienteGV>();

            foreach (ClienteEN c in lista)
            {
                clienteGV.Add(new ClienteGV()
                {
                    NIF = c.Nif,
                    Nombre = c.Nombre,
                    Email = c.Email,
                    Direccion = c.Direccion,
                    Localidad = c.Localidad,
                    Provincia = c.Provincia,
                    Telefono = c.Telefono,
                    CodigoPostal = c.CodigoPostal,
                    Pais = c.Pais
                });
            }
            return clienteGV;
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            ClienteCEN cliente = new ClienteCEN();
            List<ClienteGV> clienteGV = new List<ClienteGV>();
            IList<ClienteEN> lista;
            lista = cliente.ObtenerTodos(0, 0);
            clienteGV = modificarFV(lista);
            dataGridViewCliente.DataSource = clienteGV;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaCliente ac = new AltaCliente() { Owner = this };
            ac.Owner = this;
            ac.Deactivate += new EventHandler(Grid_Load);
            ac.Show();
            // Cuando se pierda el foco de la pantalla cargará el grid de nuevo
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConsultarEditarCliente cc = new ConsultarEditarCliente(dataGridViewCliente, false) { Owner = this };
            cc.Owner = this;
            cc.Deactivate += new EventHandler(Grid_Load);
            cc.Show();
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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ConsultarEditarCliente ec = new ConsultarEditarCliente(dataGridViewCliente, true) { Owner = this };
            ec.Owner = this;
            ec.Deactivate += new EventHandler(Grid_Load);
            ec.Show();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            Grid_Load(sender, e);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            GenerarInforme gi = new GenerarInforme();
            gi.Owner = this;
            gi.Deactivate += new EventHandler(Grid_Load);
            gi.Show();
        }
    }

    public class ClienteGV
    {
        public string NIF { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Telefono { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
    }
}
