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
    public partial class PantallaTrabajador : Form
    {
        public PantallaTrabajador()
        {
            InitializeComponent();
            Grid_Load();
        }

        private void Grid_Load()
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();
            IList<TrabajadorEN> lista;
            lista=trabajador.ObtenerTodos(0, 0);
            Mostrar.DataSource = lista;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            CrearTrabajador pantalla_trabajador = new CrearTrabajador();
            pantalla_trabajador.Show();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
