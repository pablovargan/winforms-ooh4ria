using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
using System;
using System.Collections;
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

            IList<InstalacionEN> lista = new List<InstalacionEN>();
            IList<InstalacionEN> lista2 = new List<InstalacionEN>();

            InstalacionCEN instalacion = new InstalacionCEN();
            lista = instalacion.ObtenerTodas(0, 0);
            foreach (InstalacionEN i in lista)
            {
                if (i.Cliente.Nif == cliente.Nif)
                {
                    lista2.Add(i);
                }
            }

            dataGridViewInstalaciones.DataSource = convertirGV(lista2);
        }

        private List<InstalacionGVDeleteCliente> convertirGV(IList<InstalacionEN> lista)
        {
            List<InstalacionGVDeleteCliente> instalaciones = new List<InstalacionGVDeleteCliente>();

            foreach (InstalacionEN i in lista)
            {
                instalaciones.Add(new InstalacionGVDeleteCliente()
                {
                    Nombre = i.Nombre,
                    Localidad = i.Localidad,
                    Provincia = i.Provincia,
                    Pais = i.Pais,
                    Direccion = i.Direccion,
                    CP = i.CodigoPostal,
                });
            }

            return instalaciones;
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
                eliminarInstalacionesCliente(textBoxNIF.Text);
                cliente.Eliminar(textBoxNIF.Text);
            }

            this.Close();
        }

        private void eliminarInstalacionesCliente(string nif)
        {
            IList<InstalacionEN> lista = new List<InstalacionEN>(); 
            InstalacionCEN instalacion = new InstalacionCEN();
            lista = instalacion.ObtenerTodas(0, 0);
            foreach (InstalacionEN i in lista)
            {
                if (i.Cliente.Nif == nif)
                {
                    instalacion.Eliminar(i.Id);
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class InstalacionGVDeleteCliente
    {
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Direccion { get; set; }
        public string CP { get; set; }
    }
}
