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
    public partial class ConsultaTrabajador : Form
    {
        public ConsultaTrabajador()
        {
            InitializeComponent();
        }

        private void ConsultaTrabajador_Load(object sender, EventArgs e)
        {
            LoadProvincia();
        }

        public void LoadProvincia()
        {
            IList<InstalacionEN> instalaciones = new List<InstalacionEN>();
            instalaciones = new InstalacionCEN().ObtenerTodas(0, 0);
            IList<string> prov_inst = new List<string>();

            foreach (InstalacionEN instalacion in instalaciones)
            {
                if (!this.ProvinciaRepetida(prov_inst, instalacion.Provincia)) // Provincia no repetida. Evita duplicados en el combobox.
                {
                    prov_inst.Add(instalacion.Provincia);
                }
            }

            comboBox_provincia.DataSource = prov_inst;
            LoadInstalacion(instalaciones.First<InstalacionEN>().Provincia); // Cargamos el combobox con la primera provincia.
        }

        public void LoadInstalacion(string prov)
        {
            IList<InstalacionEN> instalaciones = new List<InstalacionEN>();
            instalaciones = new InstalacionCEN().ObtenerTodas(0, 0);
            IList<string> nombres_inst = new List<string>();

            foreach (InstalacionEN instalacion in instalaciones)
            {
                if (instalacion.Provincia == comboBox_provincia.Text)
                {
                    nombres_inst.Add(instalacion.Nombre);
                }
            }

            comboBox_instalaciones.DataSource = nombres_inst;
        }

        private Boolean ProvinciaRepetida(IList<string> lista, string prov) 
        {
            foreach (string dato in lista)
            {
                if (dato == prov)
                {
                    return true;
                }
            }

            return false;
        }

        private void gridConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_instalaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInstalacion(comboBox_provincia.Text);
        }
    }
}
