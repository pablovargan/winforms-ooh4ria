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

namespace LimpiezasPalmeralForms.Cliente
{
    public partial class ConsultarEditarCliente : Form
    {
        public ConsultarEditarCliente(DataGridView dataGridViewCliente, bool editar)
        {
            InitializeComponent();
            ClienteCEN clienteMostrar = new ClienteCEN();
            pintarDatosCliente((ClienteEN)clienteMostrar.ObtenerCliente(dataGridViewCliente.SelectedRows[0].Cells[0].Value.ToString()));
            buttonCancelar.Hide();
            if (editar) activarCampos();
        }

        private IList<InstalacionClienteGV> modificarFV(IList<InstalacionEN> lista)
        {
            IList<InstalacionClienteGV> listaFiltrada = new List<InstalacionClienteGV>();

            foreach (InstalacionEN i in lista)
            {
                if (i.Cliente.Nif == textBoxNIF.Text)
                {
                    listaFiltrada.Add(new InstalacionClienteGV()
                    {
                        Nombre = i.Nombre,
                        Direccion = i.Direccion,
                        Localidad = i.Localidad, 
                        Provincia = i.Provincia, 
                        CP = i.CodigoPostal,
                        Pais = i.Pais,
                        Telefono = i.Telefono
                    });
                }
            }

            return listaFiltrada;
        }

        private void pintarInstalaciones()
        {
            IList<InstalacionClienteGV> listaFiltrada = new List<InstalacionClienteGV>();
            IList<InstalacionEN> lista = new List<InstalacionEN>();
            InstalacionCEN instalacion = new InstalacionCEN();
            lista = instalacion.ObtenerTodas(0, 0);
            listaFiltrada = modificarFV(lista);
            dataGridViewInstalaciones.DataSource = listaFiltrada;
        }

        private void pintarDatosCliente(ClienteEN cliente)
        {
            textBoxNIF.Text = cliente.Nif;
            textBoxNombre.Text = cliente.Nombre;   
            textBoxEmail.Text = cliente.Email;
            textBoxDireccion.Text = cliente.Direccion;
            textBoxLocalidad.Text = cliente.Localidad;
            textBoxProvincia.Text = cliente.Provincia;
            textBoxCP.Text = cliente.CodigoPostal;
            textBoxPais.Text = cliente.Pais;
            textBoxTelefono.Text = cliente.Telefono;
            textBoxDescripcion.Text = cliente.Descripcion;
            pintarInstalaciones();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteCEN clienteEditar= new ClienteCEN();
            clienteEditar.Editar(textBoxNIF.Text, textBoxNombre.Text, textBoxDescripcion.Text,
                textBoxEmail.Text, textBoxLocalidad.Text, textBoxProvincia.Text, textBoxPais.Text,
                textBoxDireccion.Text, textBoxCP.Text, textBoxTelefono.Text);
            this.Close();

        }

        private void activarCampos()
        {
            this.Text = "Editar Cliente";
            textBoxNombre.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxDireccion.Enabled = true;
            textBoxLocalidad.Enabled = true;
            textBoxProvincia.Enabled = true;
            textBoxCP.Enabled = true;
            textBoxPais.Enabled = true;
            textBoxTelefono.Enabled = true;
            textBoxDescripcion.Enabled = true;
            buttonEditar.Hide();
            buttonCancelar.Show();
            buttonAceptar.Text = "Guardar";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activarCampos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class InstalacionClienteGV
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string CP { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
    }
}
