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

namespace LimpiezasPalmeralForms.Proveedor
{
    public partial class EditarProveedor : Form
    {
        private ProveedorCEN _proveedor;
        public string Nif { get; set; }
        public EditarProveedor()
        {
            InitializeComponent();
            _proveedor = new ProveedorCEN();
            this.Load += EditarProveedor_Load;
        }

        private void EditarProveedor_Load(object sender, EventArgs e)
        {
            ProveedorEN p = _proveedor.ObtenerProveedor(Nif);
            if (p != null)
            {
                nifBox.Text = p.Id;
                nombreBox.Text = p.Nombre;
                emailBox.Text = p.Email;
                direccionBox.Text = p.Direccion;
                localidadBox.Text = p.Localidad;
                provinciaBox.Text = p.Provincia;
                telefonoBox.Text = p.Telefono;
                codigoPostalBox.Text = p.CodigoPostal;
                paisBox.Text = p.Pais;
                descripcionBox.Text = p.Descripcion;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            _proveedor.Editar(nifBox.Text, nombreBox.Text, telefonoBox.Text, direccionBox.Text, localidadBox.Text,
                    provinciaBox.Text, codigoPostalBox.Text, emailBox.Text, paisBox.Text, descripcionBox.Text);

            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
