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
using LimpiezasPalmeralForms.Servicios;
using LimpiezasPalmeralForms.Trabajador.Nóminas;

namespace LimpiezasPalmeralForms
{
    public partial class PantallaTrabajador : Form
    {
        public PantallaTrabajador()
        {
            InitializeComponent();
            this.Load += new EventHandler(Grid_Load);
            Buscador.KeyUp += new KeyEventHandler(Buscar_Trabajadores);
            Premisa.TextChanged += new EventHandler(Buscar_Trabajadores);
            BusquedaTipo.SelectedIndexChanged += new EventHandler(Buscar_Trabajadores);
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
            ComprobarLista(lista);
        }

        private void ComprobarLista(IList<TrabajadorEN> lista)
        {
            if (lista.Count == 0)
            {
                Consultar.Enabled = false;
                Editar.Enabled = false;
                Eliminar.Enabled = false;
            }
            else
            {
                Consultar.Enabled = true;
                Editar.Enabled = true;
                Eliminar.Enabled = true;
            }
        }

        private void Buscar_Trabajadores(object sender, EventArgs e)
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();
            IList<TrabajadorEN> lista;
            if (Premisa.Text == "" || Buscador.Text == "")
            {
                Buscador.Visible = true;
                BusquedaTipo.Visible = false;
                lista = trabajador.ObtenerTodos(0, 0);
                Mostrar.DataSource = Convertir_TrabajadorGW(lista);
                ComprobarLista(lista);
            }
            if (Premisa.Text.Equals("Provincia"))
            {
                Buscador.Visible = true;
                BusquedaTipo.Visible = false;
                lista=trabajador.BuscarPorProvincia(Buscador.Text);
                Mostrar.DataSource = Convertir_TrabajadorGW(lista);
                ComprobarLista(lista);
            }
            else if (Premisa.Text.Equals("Localidad"))
            {
                Buscador.Visible = true;
                BusquedaTipo.Visible = false;
                lista = trabajador.BuscarPorLocalidad(Buscador.Text);
                Mostrar.DataSource = Convertir_TrabajadorGW(lista);
                ComprobarLista(lista);
            }
            else if (Premisa.Text.Equals("Nombre"))
            {
                Buscador.Visible = true;
                BusquedaTipo.Visible = false;
                lista = trabajador.BuscarPorNombre(Buscador.Text);
                Mostrar.DataSource = Convertir_TrabajadorGW(lista);
                ComprobarLista(lista);
            }
            else if (Premisa.Text.Equals("Tipo"))
            {
                Buscador.Visible = false;
                BusquedaTipo.Visible = true;
                if (BusquedaTipo.SelectedIndex == 0)
                {
                    try {
                        lista = trabajador.BuscarPorTipo(PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Cooperativista);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                        throw exc;
                    }
                    
                    Mostrar.DataSource = Convertir_TrabajadorGW(lista);
                    ComprobarLista(lista);
                }
                else if (BusquedaTipo.SelectedIndex == 1)
                {
                    lista = trabajador.BuscarPorTipo(PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);
                    Mostrar.DataSource = Convertir_TrabajadorGW(lista);
                    ComprobarLista(lista);
                }
                else
                {
                    lista = trabajador.ObtenerTodos(0, 0);
                    Mostrar.DataSource = Convertir_TrabajadorGW(lista);
                    ComprobarLista(lista);
                }
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
            TrabajadorCEN trabajador = new TrabajadorCEN();
            TrabajadorGV trabajador_eliminar = (TrabajadorGV)Mostrar.CurrentRow.DataBoundItem;

            DialogResult dr = MessageBox.Show("¿Desea eliminar el trabajador " + trabajador_eliminar.Nombre + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                EliminarNominas(trabajador_eliminar.Nif);
                trabajador.Eliminar(trabajador_eliminar.Nif);
            }
            PantallaNominas pn = new PantallaNominas();
            pn.Grid_Load(sender, e);
        }

        private void EliminarNominas(string id)
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();
            TrabajadorEN t = new TrabajadorEN();
            NominaCEN nomina = new NominaCEN();
            IList<NominaEN> lista = new List<NominaEN>();
            t = trabajador.ObtenerTrabajador(id);
            lista = nomina.ObtenerTodas(0, 0);
            IList<NominaEN> listabuena = new List<NominaEN>();
            foreach (NominaEN n in lista)
            {
                if (n.Trabajador.Nif.Equals(t.Nif))
                {
                    nomina.Eliminar(n.Id);
                }
            }
        }

        private void Consultar_Click(object sender, EventArgs e)
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

        private void Buscador_Click(object sender, EventArgs e)
        {
            Buscador.Text = "";
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            
            TrabajadorCEN trabajador = new TrabajadorCEN();
            TrabajadorGV trabajador_modificar = (TrabajadorGV)Mostrar.CurrentRow.DataBoundItem;
            ConsultarEditarTrabajador consulta = new ConsultarEditarTrabajador(trabajador_modificar.Nif, true);
            consulta.Owner = this;
            consulta.Deactivate += new EventHandler(Grid_Load);
            consulta.Show();
        }

        private void GenerarInforme_Click(object sender, EventArgs e)
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();
            TrabajadorGV t = (TrabajadorGV)Mostrar.CurrentRow.DataBoundItem;
            TrabajadorEN generartrabajador = trabajador.ObtenerTrabajador(t.Nif);
            GeneradorPDF pdf = new GeneradorPDF();
            pdf.pdfTrabajador(generartrabajador);
        }

        private void GenerarListado_Click(object sender, EventArgs e)
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();
            IList<TrabajadorEN> generartrabajador = trabajador.ObtenerTodos(0,0);
            GeneradorPDF pdf = new GeneradorPDF();
            pdf.pdfTrabajadorListado(generartrabajador);
        }

        private void Asignar_Click(object sender, EventArgs e)
        {
            CrearJornada pantalla = new CrearJornada();
            pantalla.Owner = this;
            pantalla.Deactivate += new EventHandler(Grid_Load);
            pantalla.Show();
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
