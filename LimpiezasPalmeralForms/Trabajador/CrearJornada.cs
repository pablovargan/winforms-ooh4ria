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
                IList<JGV> listajornadas = convertirJornadaGV(listaJ);
                Jornada.DataSource = listajornadas;

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
                    DNI = t.Nif,
                    Localidad = t.Localidad
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
                    Id = i.Id,
                    Nombre = i.Nombre,
                    Localidad = i.Localidad
                });
            }

            return l;
        }

        private IList<JGV> convertirJornadaGV(IList<JornadaFechaEN> lista)
        {
            IList<JGV> l = new List<JGV>();

            foreach (JornadaFechaEN j in lista)
            {
                InstalacionCEN ins = new InstalacionCEN();
                TrabajadorCEN tra = new TrabajadorCEN();
                TrabajadorEN t = new TrabajadorEN();
                JornadaFechaCEN jor = new JornadaFechaCEN();

                l.Add(new JGV()
                {
                    Id = jor.ObtenerJornada(j.Id).Id.ToString(),
                    Fecha = jor.ObtenerJornada(j.Id).Fecha.ToString(),
                    NombreI = ins.ObtenerInstalacion(j.Instalacion.Id).Nombre
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
            lista.Add(jornada.Crear(FechaBox.Value, instalacion.Id));
            trabajador.Relationer_jornadas(t.DNI, lista);
            Cancelar.Text = "Cerrar";
            Grid_Load(sender, e);
        }

        private void Jornada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class TGV
    {
        public string Nombre { set; get; }
        public string DNI { set; get; }
        public string Localidad { set; get; }
    }
    public class IGV
    {
        public string Id { set; get; }
        public string Nombre { set; get; }
        public string Localidad { set; get; }
    }
    public class JGV
    {
        public string Id { set; get; }
        public string Fecha { set; get; }
        public string NombreI { set; get; }
    }
}
