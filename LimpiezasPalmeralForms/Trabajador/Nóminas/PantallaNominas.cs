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

namespace LimpiezasPalmeralForms.Trabajador.Nóminas
{
    public partial class PantallaNominas : Form
    {
        public PantallaNominas()
        {
            InitializeComponent();
            this.Load += new EventHandler(Grid_Load);
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            try
            {
                NominaCEN nomina = new NominaCEN();
                IList<NominaEN> lista;
                lista = nomina.ObtenerTodas(0, 0);
                Mostrar.DataSource = lista;
                if (lista.Count == 0)
                {
                    Consultar.Enabled = false;
                    Editar.Enabled = false;
                }
                else
                {
                    Consultar.Enabled = true;
                    Editar.Enabled = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }  
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            CrearNomina pantalla_nomina = new CrearNomina();
            pantalla_nomina.Owner = this;
            pantalla_nomina.Deactivate += new EventHandler(Grid_Load);
            pantalla_nomina.Show();
        }
    }
}
