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
using LimpiezasPalmeralForms.Trabajador;
using LimpiezasPalmeralForms.Trabajador.Nóminas;

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
                Mostrar.DataSource = Convertir_NominaGW(lista);
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
        private List<NominaGV> Convertir_NominaGW(IList<NominaEN> lista)
        {
            List<NominaGV> l = new List<NominaGV>();

            foreach (NominaEN t in lista)
            {
                l.Add(new NominaGV()
                {
                    Id = t.Id,
                    ParteFija = t.ParteFija,
                    ParteVariable = t.ParteVariable,
                    fecha = t.Fecha.ToString(),
                    Horas = t.Horas,
                    NombreTrabajador = t.Trabajador.Nombre,
                    Total = t.Total
                });
            }
            return l;
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            CrearNomina pantalla_nomina = new CrearNomina();
            pantalla_nomina.Owner = this;
            pantalla_nomina.Deactivate += new EventHandler(Grid_Load);
            pantalla_nomina.Show();
        }
    }
    public class NominaGV
    {
        public string Id { set; get; }
        public float ParteFija { set; get; }
        public float ParteVariable { set; get; }
        public float Horas { set; get; }
        public string fecha { set; get; }
        public float Total { set; get; }
        public string NombreTrabajador { set; get; }
    }
}
