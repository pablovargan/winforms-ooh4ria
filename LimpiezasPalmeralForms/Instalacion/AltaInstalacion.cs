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

            if (!string.IsNullOrWhiteSpace(id_box.Text as string))
            {
                try
                {
                    float m2_b = (float)Convert.ToDouble(m2_box.Text); // Cast.
                    _instalacion.Crear(id_box.Text,nombre_box.Text,desc_box.Text,loc_box.Text,prov_box.Text,pais_box.Text,dir_box.Text,
                        cp_box.Text,tlfno_box.Text,m2_b,cliente_box.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Constantes._ERRORINSTALACION);
                }
            }
            else
                MessageBox.Show(Constantes._ERRORIDINST);
        }
    }
}
