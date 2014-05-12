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
using LimpiezasPalmeralForms.Proveedor;

namespace LimpiezasPalmeralForms
{
    public partial class AltaProveedor : Form
    {
        protected ProveedorCEN _proveedor;
        public AltaProveedor()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            var _proveedor = new ProveedorCEN();
            if(!string.IsNullOrWhiteSpace(nifBox.Text as string))
            {
                try
                {
                    _proveedor.Crear(nifBox.Text, nombreBox.Text, telefonoBox.Text, direccionBox.Text, localidadBox.Text, provinciaBox.Text,
                    telefonoBox.Text, emailBox.Text, codigoPostalBox.Text, descripcionBox.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Constantes._ERRORCREAR);
                }
            }
            else
                MessageBox.Show(Constantes._ERRORNIF);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
