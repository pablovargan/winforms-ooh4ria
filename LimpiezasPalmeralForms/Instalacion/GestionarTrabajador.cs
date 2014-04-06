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
    public partial class GestionarTrabajador : Form
    {
        public GestionarTrabajador()
        {
            InitializeComponent();
        }

        private void GestionarTrabajador_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox_inst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GestionarTrabajador_Load_1(object sender, EventArgs e)
        {
            LoadInstalacion();
        }

        private void LoadInstalacion()
        {
            IList<InstalacionEN> instalaciones = new List<InstalacionEN>();
            instalaciones = new InstalacionCEN().ObtenerTodas(0, 0);

            IList<string> nombre_inst = new List<string>();

            foreach (InstalacionEN inst in instalaciones)
            {
                nombre_inst.Add(inst.Id);
            }

            comboBox_inst.DataSource = nombre_inst;
            LoadTrabajador(instalaciones.First<InstalacionEN>().Id);
        }

        private void LoadTrabajador(string id_inst)
        {
            IList<TrabajadorEN> trabajadores = new List<TrabajadorEN>();
            trabajadores = new TrabajadorCEN().ObtenerTodos(0, 0);

            IList<string> nombre_trab = new List<string>();

            foreach (TrabajadorEN trab in trabajadores)
            {
                nombre_trab.Add(trab.Nif);
            }

            comboBox_trab.DataSource = nombre_trab;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
