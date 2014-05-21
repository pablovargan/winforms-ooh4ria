using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralForms
{
    public partial class ConsultarInstalacion : Form
    {
        public ConsultarInstalacion(string id)
        {
            InitializeComponent();
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

            TrabajadorCEN _trab = new TrabajadorCEN();
            IList<TrabajadorEN> trab = _trab.ObtenerTodos(0, 0);
            gridTrabajadores.DataSource = trab;
        }

        private void ConsultarInstalacion_Load(object sender, EventArgs e)
        {

        }

        private void nifBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
