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
    public partial class ConsultarEditarNominas : Form
    {
        public ConsultarEditarNominas(string id, string traId, bool editar)
        {
            InitializeComponent();
            ParteFijaBox.TextChanged += new EventHandler(CalcularTotal);
            ParteVariableBox.TextChanged += new EventHandler(CalcularTotal);
            TrabajadorCEN trabajador = new TrabajadorCEN();
            IList<TrabajadorEN> lista = new List<TrabajadorEN>();
            lista = trabajador.ObtenerTodos(0, 0);
            if (lista.Contains(trabajador.ObtenerTrabajador(traId)))
            {
                if (trabajador.ObtenerTrabajador(traId).Tipo.Equals(PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Cooperativista))
                {
                    RellenarCampos(id, true);
                    if (editar)
                    {
                        ActivarCampos(true);
                    }
                }
                else
                {
                    RellenarCampos(id, false);
                    if (editar)
                    {
                        ActivarCampos(false);
                    }
                }
            }
        }

        private void CalcularTotal(object sender, EventArgs e)
        {
            float d1, d2;
            if (ParteFijaBox.Text.Length != 0)
            {
                d1 = ComprobarFloat(ParteFijaBox.Text);
            }
            else
            {
                d1 = 0;
            }
            if (ParteVariableBox.Text.Length != 0)
            {
                d2 = ComprobarFloat(ParteVariableBox.Text);
            }
            else
            {
                d2 = 0;
            }
            TotalBox.Text = (d1 + d2).ToString();
        }
        public void RellenarCampos(string id, bool cope)
        {
            NominaCEN nomina = new NominaCEN();
            TrabajadorCEN t = new TrabajadorCEN();
            NominaEN n = new NominaEN();
            n = nomina.ObtenerNomina(id);
            IDBox.Text = id;
            ParteFijaBox.Text = n.ParteFija.ToString();
            if (cope)
            {
                ParteVariable.Visible = true;
                ParteVariableBox.Visible = true;
                ParteVariableBox.Text = n.ParteVariable.ToString();
            }
            HorasBox.Text = n.Horas.ToString();
            TotalBox.Text = n.Total.ToString();
            Mes_Box.Visible = false;
            Anyo_Box.Visible = false;
            //DateTime? f = new DateTime();
            //f = n.Fecha;
            //Mes_Box.SelectedIndex = fecha.
            Fecha1.Visible = false;
            Fecha2.Visible = false;
            fecha.Visible = true;
            fechaBox.Visible = true;
            fechaBox.Text = n.Fecha.ToString();
            TrabajadorBox.Text = t.ObtenerTrabajador(n.Trabajador.Nif).Nif;
        }

        public void ActivarCampos(bool cope)
        {
            ParteFijaBox.Enabled = true;
            if (cope)
            {
                ParteVariableBox.Enabled = true;
            }
            HorasBox.Enabled = true;
            Mes_Box.Enabled = true;
            Anyo_Box.Enabled = true;
            Mes_Box.Visible = true;
            Anyo_Box.Visible = true;
            Fecha1.Visible = true;
            Fecha2.Visible = true;
            fecha.Visible = false;
            fechaBox.Visible = false;
            Editar.Visible = false;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            NominaCEN nomina = new NominaCEN();

            if(HorasBox.Text.Length!=0 && TotalBox.Text.Length!=0 && Mes_Box.Text.Length!=0 && Anyo_Box.Text.Length!=0)
            {
                try
                {
                    float f, v;
                    if (ParteFijaBox.Text.Length != 0)
                    {
                        f = ComprobarFloat(ParteFijaBox.Text);
                    }
                    else
                    {
                        f = 0;
                    }
                    if (ParteVariableBox.Text.Length != 0)
                    {
                        v = ComprobarFloat(ParteVariableBox.Text);
                    }
                    else
                    {
                        v = 0;
                    }
                    
                    float h = ComprobarFloat(HorasBox.Text);
                    float t = ComprobarFloat(TotalBox.Text);
                    int anyo, mes;
                    Int32.TryParse(Anyo_Box.Text, out anyo);
                    string smes = BuscarMes(Mes_Box.Text);
                    Int32.TryParse(smes, out mes);
                    DateTime fecha = new DateTime(anyo, mes, 1, 0, 0, 0);
                    nomina.Editar(IDBox.Text, f, v, h, t, fecha);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            this.Close();
        }

        private float ComprobarFloat(string entrada)
        {
            float solucion;
            bool convertido = float.TryParse(entrada, out solucion);

            if (convertido == false)
            {
                MessageBox.Show("Porfavor introduce un dato numérico");
            }

            return solucion;
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            TrabajadorCEN trabajador = new TrabajadorCEN();
            IList<TrabajadorEN> lista = new List<TrabajadorEN>();
            lista = trabajador.ObtenerTodos(0, 0);
            if (lista.Contains(trabajador.ObtenerTrabajador(TrabajadorBox.Text)))
            {
                if (trabajador.ObtenerTrabajador(TrabajadorBox.Text).Tipo.Equals(PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Cooperativista))
                {
                    ActivarCampos(true);
                }
                else
                {
                    ActivarCampos(false);
                }
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string BuscarMes(string mes)
        {
            string solucion = "";

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
