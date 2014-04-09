using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Proveedor
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralForms.Proveedor
{
    public partial class ConsultaProveedor : Form
    {
        private ProveedorCEN _proveedor;
        public string Nif { get; set; }

        public ConsultaProveedor()
        {
            InitializeComponent();
            _proveedor = new ProveedorCEN();
            this.Load += ConsultaProveedor_Load;
        }

        void ConsultaProveedor_Load(object sender, EventArgs e)
        {
            ProveedorEN p = _proveedor.ObtenerProveedor(Nif);
            if(p != null)
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

        private void Editar_Click(object sender, EventArgs e)
        {
            // TODO 
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
