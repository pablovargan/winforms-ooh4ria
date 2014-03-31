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
    public partial class AltaInstalacion : Form
    {
        public AltaInstalacion()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alta_Click(object sender, EventArgs e)
        {
            var _instalacion = new InstalacionCEN();
            
            string id = (new ClienteCEN().ObtenerTodos(0, 0).Count + 1).ToString(); // Número de clientes + 1. Obtención del siguiente ID.
            float m2_b = (float)Convert.ToDouble(m2_box.Text); // Cast.
            _instalacion.Crear(id,nombre_box.Text,desc_box.Text,loc_box.Text,prov_box.Text,pais_box.Text,dir_box.Text,
                cp_box.Text,tlfno_box.Text,m2_b,cliente_comboBox.Text);
            this.Close();
        }

        private void AltaInstalacion_Load(object sender, EventArgs e)
        {
            IList<ClienteEN> clientes = new ClienteCEN().ObtenerTodos(0, 0);
            IList<string> nifs;
            int tam = clientes.Count;

            for (int i = 0; i < tam; i++)
            {
                nifs[i] = clientes[i].Nif;
            }

            cliente_comboBox.DataSource = nifs;
            cliente_comboBox.DisplayMember = "NIF";
            cliente_comboBox.ValueMember = "NIF";
        }
    }
}
