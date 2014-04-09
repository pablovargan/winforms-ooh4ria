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

namespace LimpiezasPalmeralForms
{
    public partial class PantallaTrabajador : Form
    {
        public PantallaTrabajador()
        {
            InitializeComponent();
            this.Load += new EventHandler(Grid_Load);
            this.Load += new EventHandler(Grid_Load);
            Buscador.KeyUp += new KeyEventHandler(Buscar_Trabajadores);
            Buscador.Click += new EventHandler(Grid_Load);
            Eliminar.Click += new EventHandler(Grid_Load);
            Premisa.SelectedIndex = 0;
        }

        private List<TrabajadorGV> Convertir_TrabajadorGW(IList<TrabajadorEN> lista)
        {
            List<TrabajadorGV> l = new List<TrabajadorGV>();

            foreach (TrabajadorEN t in lista)
            {
                l.Add(new TrabajadorGV()
                {
                    Apellidos = t.Apellidos,
                    Nif = t.Nif,
                    Nombre = t.Nombre,
                    Provincia = t.Provincia,
                    Localidad = t.Localidad,
                    CP = t.CodigoPostal,
                    Direccion = t.Direccion,
                    Pais = t.Pais,
                    Telefono = t.Telefono,
                    Tipo = t.Tipo.ToString()
                });
            }
            return l;
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();
            IList<TrabajadorEN> lista;
            lista=trabajador.ObtenerTodos(0, 0);
            Mostrar.DataSource = Convertir_TrabajadorGW(lista);

        }

        private void Buscar_Trabajadores(object sender, EventArgs e)
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();
            IList<TrabajadorEN> lista;
            if (Premisa.Text == "" || Buscador.Text == "")
            {
                lista = trabajador.ObtenerTodos(0, 0);
                Mostrar.DataSource = Convertir_TrabajadorGW(lista);
            }
            if (Premisa.Text.Equals("Provincia"))
            { 
                lista=trabajador.BuscarPorProvincia(Buscador.Text);
                Mostrar.DataSource = Convertir_TrabajadorGW(lista);
            }
            else if (Premisa.Text.Equals("Localidad"))
            {
                lista = trabajador.BuscarPorLocalidad(Buscador.Text);
                Mostrar.DataSource = Convertir_TrabajadorGW(lista);
            }
            else if (Premisa.Text.Equals("Nombre"))
            {
                lista = trabajador.BuscarPorNombre(Buscador.Text);
                Mostrar.DataSource = Convertir_TrabajadorGW(lista);   
            }
            else
            {
                //buscar por tipo
            }
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            CrearTrabajador pantalla_trabajador = new CrearTrabajador();
            pantalla_trabajador.Owner = this;
            pantalla_trabajador.Deactivate += new EventHandler(Grid_Load);
            pantalla_trabajador.Show();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            /*if (Mostrar.SelectedRows == null)
            {
                MessageBox.Show("Seleccion el trabajador que desee eliminar");
            }
            else
            {
                TrabajadorCEN trabajador = new TrabajadorCEN();
                TrabajadorGV trabajador_eliminar = (TrabajadorGV)Mostrar.CurrentRow.DataBoundItem;
                MessageBox.Show("Desea eliminar: " + trabajador_eliminar.Nombre);
                trabajador.Eliminar(trabajador_eliminar.Nif);
            }*/
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (Mostrar.SelectedRows == null)
            {
                MessageBox.Show("Seleccion el trabajador que desee consultar");
            }
            else
            {     
                TrabajadorCEN trabajador = new TrabajadorCEN();
                TrabajadorGV trabajador_modificar = (TrabajadorGV)Mostrar.CurrentRow.DataBoundItem;
                try
                {
                    ConsultarEditarTrabajador consulta = new ConsultarEditarTrabajador(trabajador_modificar.Nif, false);
                    consulta.Owner = this;
                    consulta.Deactivate += new EventHandler(Grid_Load);
                    consulta.Show();
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

        private void Buscador_Click(object sender, EventArgs e)
        {
            Buscador.Text = "";
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Mostrar.SelectedRows == null)
            {
                MessageBox.Show("Seleccion el trabajador que desee modificar");
            }
            else
            {
                TrabajadorCEN trabajador = new TrabajadorCEN();
                TrabajadorGV trabajador_modificar = (TrabajadorGV)Mostrar.CurrentRow.DataBoundItem;
                ConsultarEditarTrabajador consulta = new ConsultarEditarTrabajador(trabajador_modificar.Nif, true);
                consulta.Owner = this;
                consulta.Deactivate += new EventHandler(Grid_Load);
                consulta.Show();
            }
        }
    }

    public class TrabajadorGV
    {
        public string Nombre { set; get; }
        public string Nif { set; get; }
        public string Apellidos { set; get; }
        public string Provincia { set; get; }
        public string Localidad { set; get; }
        public string CP { set; get; }
        public string Direccion { set; get; }
        public string Pais { set; get; }
        public string Telefono { set; get; }
        public string Tipo { set; get; }
    }
}
