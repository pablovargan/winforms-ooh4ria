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

namespace LimpiezasPalmeralForms.Trabajador.Nóminas
{
    public partial class CrearNomina : Form
    {
        public CrearNomina()
        {
            InitializeComponent();
            this.Load += new EventHandler(CrearNomina_Load);
            Trabajadores.TextChanged += new EventHandler(Trabajadores_Changed);
        }

        private void Trabajadores_Changed(object sender, EventArgs e)
        {
            TrabajadorCEN tra = new TrabajadorCEN();
            IList<TrabajadorEN> trabajador = new List<TrabajadorEN>();
            trabajador = tra.ObtenerTodos(0, 0);

            if(trabajador.Contains(tra.ObtenerTrabajador(Trabajadores.SelectedItem.ToString())))
            {
                if (tra.ObtenerTrabajador(Trabajadores.SelectedItem.ToString()).Tipo.Equals(PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Cooperativista))
                {
                    Variable.Visible = true;
                    Variable_Box.Visible = true;
                    Fija.Visible = true;
                    Fija_Box.Visible = true;
                    Horas.Visible = true;
                    Horas_Box.Visible = true;
                    Total.Visible = true;
                    Total_Box.Visible = true;
                    Fecha1.Visible = true;
                    Fecha2.Visible = true;
                    Mes_Box.Visible = true;
                    Anyo_Box.Visible = true;
                    Crear.Enabled = true;
                }
                else if (tra.ObtenerTrabajador(Trabajadores.SelectedItem.ToString()).Tipo.Equals(PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado))
                {
                    Variable.Visible = false;
                    Variable_Box.Visible = false;
                    Fija_Box.Visible = true;
                    Fija.Visible = true;
                    Horas.Visible = true;
                    Horas_Box.Visible = true;
                    Total.Visible = true;
                    Total_Box.Visible = true;
                    Fecha1.Visible = true;
                    Fecha2.Visible = true;
                    Mes_Box.Visible = true;
                    Anyo_Box.Visible = true;
                    Crear.Enabled = true;
                }
            }
            else
            {
                Variable.Visible = false;
                Variable_Box.Visible = false;
                Fija.Visible = false;
                Fija_Box.Visible = false;
                Horas.Visible = false;
                Horas_Box.Visible = false;
                Total.Visible = false;
                Total_Box.Visible = false;
                Fecha1.Visible = false;
                Fecha2.Visible = false;
                Mes_Box.Visible = false;
                Anyo_Box.Visible = false;
                Crear.Enabled = false;
            }
        }

        private void CrearNomina_Load(object sender, EventArgs e)
        {
            IList<TrabajadorEN> trabajador = new List<TrabajadorEN>();
            trabajador = new TrabajadorCEN().ObtenerTodos(0, 0);
            IList<string> nifs = new List<string>();
            int tam = trabajador.Count;

            Variable.Visible = false;
            Variable_Box.Visible = false;
            Fija.Visible = false;
            Fija_Box.Visible = false;
            Horas.Visible = false;
            Horas_Box.Visible = false;
            Total.Visible = false;
            Total_Box.Visible = false;
            Fecha1.Visible = false;
            Fecha2.Visible = false;
            Mes_Box.Visible = false;
            Anyo_Box.Visible = false;
            Crear.Enabled = false;

            nifs.Add("Seleccione un Trabajdor");

            foreach (TrabajadorEN t in trabajador)
            {
                nifs.Add(t.Nif);
            }

            Trabajadores.DataSource = nifs;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            NominaCEN nomina = new NominaCEN();
            TrabajadorCEN t = new TrabajadorCEN();
            TrabajadorEN trabajador = t.ObtenerTrabajador(Trabajadores.SelectedItem.ToString());

            try
            {
                string mes = BuscarMes(Mes_Box.Text);
                float fijo = ComprobarFloat(Fija_Box.Text);
                float variable = ComprobarFloat(Variable_Box.Text);
                float horas = ComprobarFloat(Horas_Box.Text);
                float total = ComprobarFloat(Total_Box.Text);
                int anyo, int_mes;
                Int32.TryParse(Anyo_Box.Text, out anyo);
                Int32.TryParse(mes, out int_mes);
                DateTime fecha = new DateTime(anyo, int_mes, 1, 0, 0, 0);

                if (nomina.ObtenerNomina(trabajador.Nif + "_" + mes + "_" + Anyo_Box.Text) == null)
                {
                    nomina.Crear(trabajador.Nif + "_" + mes + "_" + Anyo_Box.Text, fijo, variable,
                        horas, total, fecha, trabajador.Nif);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La nomina ya existe");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("La nomina no se pudo crear" + exp.Message);
            }
        }

        private float ComprobarFloat(string entrada)
        {
            float solucion;
            bool convertido= float.TryParse(entrada, out solucion);

            if(convertido==false){
                MessageBox.Show("La nomina no se ha podido crear");
            }

            return solucion;
        }

        private string BuscarMes(string mes)
        {
            string solucion="";

            switch (mes)
            {
                case "Enero": solucion = "01";
                    break;
                case "Febrero": solucion = "02";
                    break;
                case "Marzo": solucion = "03";
                    break;
                case "Abril": solucion = "04";
                    break;
                case "Mayo": solucion = "05";
                    break;
                case "Junio": solucion = "06";
                    break;
                case "Julio": solucion = "07";
                    break;
                case "Agosto": solucion = "08";
                    break;
                case "Septiembre": solucion = "09";
                    break;
                case "Octubre": solucion = "10";
                    break;
                case "Noviembre": solucion = "11";
                    break;
                case "Diciembre": solucion = "12";
                    break;

            }
            return solucion;
        }
    }
}
