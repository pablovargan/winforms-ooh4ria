using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms.Trabajador
{
    public partial class CrearJornada : Form
    {
        public CrearJornada()
        {
            InitializeComponent();
            this.Load += new EventHandler(Grid_Load);
            FechaBox.MinDate = DateTime.Now;
        }

        public void Grid_Load(object sender, EventArgs e)
        {
            try
            {
                TrabajadorCEN trabajador = new TrabajadorCEN();
                IList<TrabajadorEN> listaT = trabajador.ObtenerTodos(0, 0);
                Trabajadores.DataSource = convertirTrabajadorGV(listaT);

                InstalacionCEN instalacion = new InstalacionCEN();
                IList<InstalacionEN> listaI = instalacion.ObtenerTodas(0, 0);
                Instalaciones.DataSource = convertirInstalacionGV(listaI);

                JornadaFechaCEN jornada = new JornadaFechaCEN();
                IList<JornadaFechaEN> listaJ = jornada.ObtenerTodas(0, 0);
                Jornada.DataSource = listaJ;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private IList<TGV> convertirTrabajadorGV(IList<TrabajadorEN> lista)
        {
            IList<TGV> l = new List<TGV>();

            foreach (TrabajadorEN t in lista)
            {
                l.Add(new TGV()
                {
                    Nombre = t.Nombre,
                    DNI = t.Nif
                });
            }

            return l;

        }
        private IList<IGV> convertirInstalacionGV(IList<InstalacionEN> lista)
        {
            IList<IGV> l = new List<IGV>();

            foreach (InstalacionEN i in lista)
            {
                l.Add(new IGV()
                {
                    id = i.Id,
                    Nombre = i.Nombre,
                    Localidad = i.Localidad
                });
            }

            return l;

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            JornadaFechaCEN jornada = new JornadaFechaCEN();
            TrabajadorCEN trabajador = new TrabajadorCEN();

            IGV instalacion = (IGV)Instalaciones.CurrentRow.DataBoundItem;
            TGV t = (TGV)Trabajadores.CurrentRow.DataBoundItem;
            IList<int> lista = new List<int>();
            lista.Add(jornada.Crear(FechaBox.Value, instalacion.id));
            trabajador.Relationer_jornadas(t.DNI, lista);

            Cancelar.Text = "Cerrar";
            Grid_Load(sender, e);
        }
    }

    public class TGV
    {
        public string Nombre { set; get; }
        public string DNI { set; get; }
    }
    public class IGV
    {
        public string id { set; get; }
        public string Nombre { set; get; }
        public string Localidad { set; get; }
    }
}
