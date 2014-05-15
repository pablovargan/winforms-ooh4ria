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
    public partial class EditarInstalacion : Form
    {
        public EditarInstalacion(string id, bool editar)
        {
            InitializeComponent();
            MostrarCampos(id);
        }

        private void MostrarCampos(string id)
        {
            InstalacionCEN instalacion = new InstalacionCEN();
            InstalacionEN mostrar = instalacion.ObtenerInstalacion(id);
            id_box.Text = id;
            id_box.Enabled = false;
            nombre_box.Text = mostrar.Nombre;
            desc_box.Text = mostrar.Descripcion;
            dir_box.Text = mostrar.Direccion;
            loc_box.Text = mostrar.Localidad;
            prov_box.Text = mostrar.Provincia;
            pais_box.Text = mostrar.Pais;
            cp_box.Text = mostrar.CodigoPostal;
            tlfno_box.Text = mostrar.Telefono;
            m2_box.Text = mostrar.MetrosCuadrados.ToString();
            cliente_comboBox.Text = mostrar.Cliente.Nif;
            cliente_comboBox.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarInstalacion_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(nombre_box.Text.Length != 0 && desc_box.Text.Length != 0 && dir_box.Text.Length != 0 && loc_box.Text.Length != 0 && prov_box.Text.Length != 0
                && pais_box.Text.Length != 0 && cp_box.Text.Length != 0 && tlfno_box.Text.Length != 0 && m2_box.Text.Length != 0)
            {
                InstalacionCEN editada = new InstalacionCEN();
                ClienteCEN cliente = new ClienteCEN();
                float m2_b = (float)Convert.ToDouble(m2_box.Text); // Cast.
                editada.Editar(id_box.Text, nombre_box.Text, desc_box.Text, loc_box.Text, prov_box.Text, pais_box.Text, dir_box.Text, cp_box.Text, 
                    tlfno_box.Text, m2_b);

                this.Close();
            }

            else
            {
                MessageBox.Show("Existen campos vacíos");
            }
        }
    }
}
