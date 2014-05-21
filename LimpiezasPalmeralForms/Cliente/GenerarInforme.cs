using System;
using System.Windows.Forms;
using LimpiezasPalmeralForms.Servicios;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
using System.Collections.Generic;

namespace LimpiezasPalmeralForms.Cliente
{
    public partial class GenerarInforme : Form
    {
        ClienteEN cliente = new ClienteEN();
        String nifcliente;
   
        public GenerarInforme(string nif)
        {
            InitializeComponent();
            ClienteCEN clienteCEN = new ClienteCEN();
            cliente = clienteCEN.ObtenerCliente(nif);
            nifcliente = nif;
            pintarCabeceraEmpresa();
            pintarDatosCliente();
            pintarInstalaciones();
        }

        public GenerarInforme(ClienteEN cliente2)
        {
            InitializeComponent();
            nifcliente = cliente2.Nif;
            pintarCabeceraEmpresa();
            pintarDatosCliente(cliente2);
            pintarInstalaciones();
        }

        private void pintarCabeceraEmpresa()
        {
            labelNombreEmpresa.Text = Constantes._NOMBREEMPRESA;
            labelFechaInforme.Text = DateTime.Now.ToString();
            labelCiudadInforme.Text = Constantes._CIUDADEMPRESA;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteCEN clienteCEN = new ClienteCEN();
            ClienteEN clienteEnvio = clienteCEN.ObtenerCliente(nifcliente);
            GeneradorPDF pdf = new GeneradorPDF();
            pdf.pdfCliente(clienteEnvio);
            this.Close();
        }


        private void pintarDatosCliente()
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

        private void pintarDatosCliente(ClienteEN cliente2)
        {
            textBoxNIF.Text = cliente2.Nif;
            textBoxNombre.Text = cliente2.Nombre;
            textBoxEmail.Text = cliente2.Email;
            textBoxDireccion.Text = cliente2.Direccion;
            textBoxLocalidad.Text = cliente2.Localidad;
            textBoxProvincia.Text = cliente2.Provincia;
            textBoxCP.Text = cliente2.CodigoPostal;
            textBoxPais.Text = cliente2.Pais;
            textBoxTelefono.Text = cliente2.Telefono;
            textBoxDescripcion.Text = cliente2.Descripcion;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarInforme_Load(object sender, EventArgs e)
        {

        }

    }
}
