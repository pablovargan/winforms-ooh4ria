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
            this.Load += new EventHandler(GridInstalacion_Load);
            textBox_buscar.KeyUp += new KeyEventHandler(buscarInstalaciones);
            textBox_buscar.Click += new EventHandler(GridInstalacion_Load);
            buttonEliminar.Click += new EventHandler(GridInstalacion_Load);
        }

        private void GridInstalacion_Load(object sender, EventArgs e)
        {
            InstalacionCEN instCEN = new InstalacionCEN();
            IList<InstalacionEN> lista;
            lista = instCEN.ObtenerTodas(0, 0);
            instalacionGrid.DataSource = convertirGV(lista);
        }

        private void AltaInstalacion_Click(object sender, EventArgs e)
        {
            AltaInstalacion alta = new AltaInstalacion() { Owner = this };
            alta.Owner = this;
            alta.Deactivate += new EventHandler(GridInstalacion_Load);
            alta.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox_buscar.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GridInstalacion_Load(sender, e);
        }

        private void buscarInstalaciones(object sender, EventArgs e)
        {
            InstalacionCEN instCEN = new InstalacionCEN();
            IList<InstalacionEN> lista = new List<InstalacionEN>();

            if (comboBox1.Text == "" || textBox_buscar.Text == "")
            {
                lista = instCEN.ObtenerTodas(0, 0);
                instalacionGrid.DataSource = convertirGV(lista);
            }

            if (comboBox1.Text.Equals("ID"))
            {
                GridID(instCEN, lista);
            }

            else if (comboBox1.Text.Equals("Nombre"))
            {
                GridNombre(instCEN, lista);
            }

            else if (comboBox1.Text.Equals("Localidad"))
            {
                GridLocalidad(instCEN, lista);
            }

            else if (comboBox1.Text.Equals("Provincia"))
            {
                GridProvincia(instCEN, lista);
            }

            instalacionGrid.ClearSelection();
        }

        public void GridID(InstalacionCEN instCEN, IList<InstalacionEN> lista)
        {
            InstalacionEN instalacion = instCEN.ObtenerInstalacion(textBox_buscar.Text);

            if (instalacion == null)
            {
                List<InstalacionGV> vacia = new List<InstalacionGV>();
                instalacionGrid.DataSource = vacia;
            }

            else
            {
                lista.Add(instalacion);
                instalacionGrid.DataSource = convertirGV(lista);
            }
        }

        public void GridNombre(InstalacionCEN instCEN, IList<InstalacionEN> lista)
        {
            IList<InstalacionEN> todas = instCEN.ObtenerTodas(0, 0);

            foreach (InstalacionEN i in todas)
            {
                if (i.Nombre.Equals(textBox_buscar.Text))
                {
                    lista.Add(i);
                }
            }

            if (lista.Count == 0)
            {
                List<InstalacionGV> vacia = new List<InstalacionGV>();
                instalacionGrid.DataSource = vacia;
            }

            else
            {
                instalacionGrid.DataSource = convertirGV(lista);
            }
        }

        public void GridLocalidad(InstalacionCEN instCEN, IList<InstalacionEN> lista)
        {
            IList<InstalacionEN> todas = instCEN.ObtenerTodas(0, 0);

            foreach (InstalacionEN i in todas)
            {
                if (i.Localidad.Equals(textBox_buscar.Text))
                {
                    lista.Add(i);
                }
            }

            if (lista.Count == 0)
            {
                List<InstalacionGV> vacia = new List<InstalacionGV>();
                instalacionGrid.DataSource = vacia;
            }

            else
            {
                instalacionGrid.DataSource = convertirGV(lista);
            }
        }

        public void GridProvincia(InstalacionCEN instCEN, IList<InstalacionEN> lista)
        {
            IList<InstalacionEN> todas = instCEN.ObtenerTodas(0, 0);

            foreach (InstalacionEN i in todas)
            {
                if (i.Provincia.Equals(textBox_buscar.Text))
                {
                    lista.Add(i);
                }
            }

            if (lista.Count == 0)
            {
                List<InstalacionGV> vacia = new List<InstalacionGV>();
                instalacionGrid.DataSource = vacia;
            }

            else
            {
                instalacionGrid.DataSource = convertirGV(lista);
            }
        }

        private List<InstalacionGV> convertirGV(IList<InstalacionEN> lista)
        {
            List<InstalacionGV> instalaciones = new List<InstalacionGV>();

            foreach (InstalacionEN i in lista)
            {
                instalaciones.Add(new InstalacionGV()
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

            return instalaciones;
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
            
        }

        private void PantallaInstalacion_Load(object sender, EventArgs e)
        {
            IList<string> busqueda = new List<string>();
            busqueda.Add("ID");
            busqueda.Add("Nombre");
            busqueda.Add("Localidad");
            busqueda.Add("Provincia");
            comboBox1.DataSource = busqueda;
        }

        private void textBox_buscar_Click(object sender, EventArgs e)
        {
            textBox_buscar.Text = "";
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            GridInstalacion_Load(sender, e); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            FacturaCEN _fact = new FacturaCEN();
            InstalacionCEN instalacion = new InstalacionCEN();
            InstalacionGV instgv = (InstalacionGV)instalacionGrid.CurrentRow.DataBoundItem;
            IList<FacturaEN> facturas = _fact.ObtenerFacturasInstalacion(instgv.ID); //new List<string>();
            IList<string> id_facturas = new List<string>();

            foreach (FacturaEN f in facturas)
            {
                id_facturas.Add(f.Id);
            }

            instalacion.Unrelationer_facturas(instgv.ID,id_facturas);

            foreach (string s in id_facturas)
            {
                _fact.Eliminar(s);
            }       

            DialogResult dr = MessageBox.Show("¿Desea eliminar la instalación ID " + instgv.ID + ": " + instgv.Nombre + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes) 
            {
                instalacion.Eliminar(instgv.ID);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (instalacionGrid.SelectedRows == null)
            {
                MessageBox.Show("Seleccione la instalación que desee modificar");
            }

            else
            {
                InstalacionCEN instalacion = new InstalacionCEN();
                InstalacionGV inst_modificar = (InstalacionGV)instalacionGrid.CurrentRow.DataBoundItem;
                EditarInstalacion editar = new EditarInstalacion(inst_modificar.ID, true);
                editar.Owner = this;
                editar.Deactivate += new EventHandler(GridInstalacion_Load);
                editar.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_inst_Click(object sender, EventArgs e)
        {
            if (instalacionGrid.SelectedRows == null)
            {
                MessageBox.Show("Seleccione la instalación que desee modificar");
            }

            else
            {
                InstalacionCEN instalacion = new InstalacionCEN();
                InstalacionGV inst = (InstalacionGV)instalacionGrid.CurrentRow.DataBoundItem;
                ConsultarInstalacion consultar = new ConsultarInstalacion(inst.ID);
                consultar.Owner = this;
                consultar.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (instalacionGrid.SelectedRows == null)
            {
                MessageBox.Show("Seleccione la instalación que desee modificar");
            }

            else
            {
                InstalacionCEN instalacion = new InstalacionCEN();
                InstalacionGV inst = (InstalacionGV)instalacionGrid.CurrentRow.DataBoundItem;
                InformeInstalacion informe = new InformeInstalacion(inst.ID);
                informe.Owner = this;
                informe.Show();
            }
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
