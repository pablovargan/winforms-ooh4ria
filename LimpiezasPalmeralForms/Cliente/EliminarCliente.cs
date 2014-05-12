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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente(ClienteEN cliente)
        {
            InitializeComponent();
            pintarDatos(cliente);
        }

        private void pintarDatos(ClienteEN cliente)
        {
            textBoxNombre.Text = cliente.Nombre.ToString();
            textBoxNIF.Text = cliente.Nif.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Estás seguro que deseas eliminar el cliente con NIF: " +
            textBoxNIF.Text + " y nombre: " + textBoxNombre.Text + " y todas sus instalaciones ?";
            string titulo = "Eliminando Cliente";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado;

            ClienteCEN cliente = new ClienteCEN();
            resultado = MessageBox.Show(mensaje, titulo, botones);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                eliminarInstalacionesCliente((ClienteEN)cliente.ObtenerCliente(textBoxNIF.Text));
               // cliente.Eliminar(textBoxNIF.Text);
            }
        }

        private void eliminarInstalacionesCliente(ClienteEN cliente)
        {
            IList<InstalacionEN> lista = new List<InstalacionEN>(); 
            InstalacionCEN instalacion = new InstalacionCEN();
            lista = instalacion.ObtenerTodas(0, 0);
            foreach (InstalacionEN i in lista)
            {
                if (i.Cliente.Nif == textBoxNIF.Text)
                {
                   // instalacion.Eliminar(i.Id);
                }
            }
        }

    }
}
