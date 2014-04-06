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
    public partial class PantallaInstalacion : Form
    {
        private InstalacionCEN _instalacion;
        private List<InstalacionGV> _instGV;

        public PantallaInstalacion()
        {
            InitializeComponent();
            _instalacion = new InstalacionCEN();
            _instGV = new List<InstalacionGV>();
            this.Load += GridInstalacion_Load;
        }

        private void GridInstalacion_Load(object sender, EventArgs e)
        {
            if (_instGV != null)
            {
                instalacionGrid.DataSource = null;
                _instGV.Clear();

                foreach (InstalacionEN i in _instalacion.ObtenerTodas(0, 0))
                {
                    _instGV.Add(new InstalacionGV()
                    {
                        ID = i.Id,
                        Nombre = i.Nombre,
                        Descripcion = i.Descripcion,
                        Localidad = i.Localidad,
                        Provincia = i.Provincia,
                        Pais = i.Pais,
                        Direccion = i.Direccion,
                        CP = i.CodigoPostal,
                        Telefono = i.Telefono,
                        Metros = i.MetrosCuadrados,
                        Cliente = i.Cliente.Nif
                    });
                }

                instalacionGrid.DataSource = _instGV;
            }
        }

        private void AltaInstalacion_Click(object sender, EventArgs e)
        {
            AltaInstalacion alta = new AltaInstalacion() { Owner = this };
            alta.Owner = this;
            alta.Deactivate += new EventHandler(GridInstalacion_Load);
            alta.Show();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void GridInstalacion_Load(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_consulta_Click(object sender, EventArgs e)
        {
            ConsultaTrabajador consulta = new ConsultaTrabajador();
            consulta.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GestionarTrabajador gestionar = new GestionarTrabajador();
            gestionar.Show();
        }

        private void PantallaInstalacion_Load(object sender, EventArgs e)
        {

        }
    }

    public class InstalacionGV {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; } 
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Direccion { get; set; }
        public string CP { get; set; }
        public string Telefono { get; set; } 
        public float Metros { get; set; } 
        public string Cliente { get; set; }
    }
}
