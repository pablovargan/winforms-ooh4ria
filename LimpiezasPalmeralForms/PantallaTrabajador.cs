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
            this.Load += new EventHandler(Grid_Load);
            this.GotFocus += new EventHandler(Grid_Load);
            Mostrar.LostFocus += new EventHandler(Desactivar_Botones);
        }

        private void Grid_Load(object sender, EventArgs e)
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
            TrabajadorCEN trabajador = new TrabajadorCEN();
            //trabajador=Mostrar.SelectedRows;

        }

        private void Modificar_Click(object sender, EventArgs e)
        {

        }

        private void Mostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Eliminar.Enabled = true;
            Modificar.Enabled = true;
        }
        private void Desactivar_Botones(object sender, EventArgs e)
        {
            Eliminar.Enabled = false;
            Modificar.Enabled = false;
        }
    }
}
