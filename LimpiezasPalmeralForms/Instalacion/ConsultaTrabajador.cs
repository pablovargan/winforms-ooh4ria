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
        private TrabajadorCEN _trabajador;
        private IList<TrabajadorGV> _trabGV;

        public ConsultaTrabajador()
        {
            InitializeComponent();
            _trabajador = new TrabajadorCEN();
            _trabGV = new List<TrabajadorGV>();
            this.Load += GridConsulta_Load;
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

        private void GridConsulta_Load(object sender, EventArgs e)
        {
            if (_trabGV != null)
            {
                GridConsulta.DataSource = null;
                _trabGV.Clear();
                IList<TrabajadorEN> trabajadores = new List<TrabajadorEN>();
                JornadaFechaCEN _jornada = new JornadaFechaCEN();
                IList<JornadaFechaEN> jornadas = _jornada.ObtenerTodas(0, 0);

                foreach (JornadaFechaEN j in jornadas)
                {
                    if (j.Instalacion.Id == comboBox_instalaciones.Text)
                    {
                        trabajadores = j.Trabajadores;
                    }
                }

                foreach (TrabajadorEN i in trabajadores)
                {
                    _trabGV.Add(new TrabajadorGV()
                    {
                        Nif = i.Nif,
                        Nombre = i.Nombre,
                        Apellidos = i.Apellidos,
                        Direccion = i.Direccion,
                        Telefono = i.Telefono,
                        CP = i.CodigoPostal,
                        Pais = i.Pais,
                        Localidad = i.Localidad,
                        Provincia = i.Provincia,
                        Tipo = i.Tipo.ToString()
                    });
                }

                GridConsulta.DataSource = _trabGV;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
