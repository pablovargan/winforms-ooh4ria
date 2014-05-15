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

namespace LimpiezasPalmeralForms.Trabajador
{
    public partial class ConsultarEditarTrabajador : Form
    {
        public ConsultarEditarTrabajador(string id, bool editar)
        {
            InitializeComponent();
            MostrarCampos(id);
            //CargarNominas(id);
            if (editar)
            {
                activarCampos();
            } 
        }

        private void MostrarCampos(string id){

            TrabajadorCEN trabajador = new TrabajadorCEN();
            TrabajadorEN mostrar= trabajador.ObtenerTrabajador(id);
            NifBox.Text = mostrar.Nif;
            NombreBox.Text = mostrar.Nombre;
            ApellidosBox.Text = mostrar.Apellidos;
            DireccionBox.Text = mostrar.Direccion;
            CpBox.Text = mostrar.CodigoPostal;
            LocalidadBox.Text = mostrar.Localidad;
            ProvinciaBox.Text = mostrar.Provincia;
            PaisBox.Text = mostrar.Pais;
            TelefonoBox.Text = mostrar.Telefono;
            TipoBox.Text = mostrar.Tipo.ToString();
            Editar.Visible = true;
            Cancelar.Visible = false;
        }
        private void activarCampos()
        {
            this.Text = "Editar Trabajador";
            NombreBox.Enabled = true;
            ApellidosBox.Enabled = true;
            DireccionBox.Enabled = true;
            CpBox.Enabled = true;
            LocalidadBox.Enabled = true;
            ProvinciaBox.Enabled = true;
            PaisBox.Enabled = true;
            TelefonoBox.Enabled = true;
            TipoBox.Enabled = true;
            Aceptar.Text = "Guardar";
            Cancelar.Visible = true;
            Editar.Visible = false;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if ( NombreBox.Text.Length != 0 && ApellidosBox.Text.Length != 0 && DireccionBox.Text.Length != 0 &&
                TelefonoBox.Text.Length != 0 && CpBox.Text.Length != 0 && PaisBox.Text.Length != 0 && LocalidadBox.Text.Length != 0 &&
                ProvinciaBox.Text.Length != 0 && TipoBox.Text.Length != 0)
            {
                TrabajadorCEN trabajadorEditar = new TrabajadorCEN();
                if (TipoBox.Text.Equals("Empleado"))
                {
                    trabajadorEditar.Editar(NifBox.Text, NombreBox.Text, ApellidosBox.Text, DireccionBox.Text, TelefonoBox.Text,
                     CpBox.Text, PaisBox.Text, LocalidadBox.Text, ProvinciaBox.Text, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);

                }
                else
                {
                    trabajadorEditar.Editar(NifBox.Text, NombreBox.Text, ApellidosBox.Text, DireccionBox.Text, TelefonoBox.Text,
                    CpBox.Text, PaisBox.Text, LocalidadBox.Text, ProvinciaBox.Text, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Cooperativista);

                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Existen campos vacios");
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();

            DialogResult dr = MessageBox.Show("¿Desea eliminar el trabajador " + NombreBox.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                trabajador.Eliminar(NifBox.Text);
                this.Close();
            }
        }

        private void CargarNominas(string id)
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();
            IList<NominaEN> lista;
            TrabajadorEN t = trabajador.ObtenerTrabajador(id);
            if (t.Nominas.Count != 0)
            {
                lista = t.Nominas;
                nominas.DataSource = Convertir_NominaGW(lista);
            } 
        }

        private List<NominaGV> Convertir_NominaGW(IList<NominaEN> lista)
        {
            List<NominaGV> l = new List<NominaGV>();

            foreach (NominaEN t in lista)
            {
                l.Add(new NominaGV()
                {
                    ParteFija = t.ParteFija,
                    ParteVariable = t.ParteVariable,
                    fecha = t.Fecha.ToString(),
                    Horas = t.Horas,
                    Total = t.Total
                });
            }
            return l;
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            activarCampos();
        }     
    }
    public class NominaGV
    {
        public float ParteFija { set; get; }
        public float ParteVariable { set; get; }
        public float Horas { set; get; }
        public string fecha { set; get; }
        public float Total { set; get; }
    }
}
