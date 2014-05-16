using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimpiezasPalmeralForms.Servicios;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralForms
{
    public partial class InformeInstalacion : Form
    {
        InstalacionEN instalacion = new InstalacionEN();

        public InformeInstalacion(string id)
        {
            InitializeComponent();

            labelNombreEmpresa.Text = Constantes._NOMBREEMPRESA;
            labelFechaInforme.Text = DateTime.Now.ToString();
            labelCiudadInforme.Text = Constantes._CIUDADEMPRESA;

            InstalacionCEN _inst = new InstalacionCEN();
            InstalacionEN inst = _inst.ObtenerInstalacion(id);
            idBox.Text = inst.Id;
            nombreBox.Text = inst.Nombre;
            direccionBox.Text = inst.Direccion;
            localidadBox.Text = inst.Localidad;
            provinciaBox.Text = inst.Provincia;
            paisBox.Text = inst.Pais;
            codigoPostalBox.Text = inst.CodigoPostal;
            telefonoBox.Text = inst.Telefono;
            m2Box.Text = inst.MetrosCuadrados.ToString();
            clienteBox.Text = inst.Cliente.Nif;
            descripcionBox.Text = inst.Descripcion;

            idBox.Enabled = false;
            nombreBox.Enabled = false;
            direccionBox.Enabled = false;
            localidadBox.Enabled = false;
            provinciaBox.Enabled = false;
            paisBox.Enabled = false;
            codigoPostalBox.Enabled = false;
            telefonoBox.Enabled = false;
            m2Box.Enabled = false;
            clienteBox.Enabled = false;
            descripcionBox.Enabled = false;

            IList<TrabajadorEN> lista = new List<TrabajadorEN>();
            TrabajadorCEN trabajador = new TrabajadorCEN();
            lista = trabajador.ObtenerTodos(0, 0);
            gridInstalaciones.DataSource = lista;
        }

        private void InformeInstalacion_Load(object sender, EventArgs e)
        {

        }

        private void pintarCabeceraEmpresa()
        {
            
        }

        private void dataGridViewInstalaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
