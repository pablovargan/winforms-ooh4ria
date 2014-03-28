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
}
