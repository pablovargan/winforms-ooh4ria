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
        public ConsultarEditarNominas(string id, bool editar)
        {
            RellenarCampos(id);
            if (editar)
            {
                ActivarCampos();
            }
            InitializeComponent();
        }

        public void RellenarCampos(string id)
        {
            NominaCEN nomina = new NominaCEN();
            NominaEN n = new NominaEN();
            n = nomina.ObtenerNomina(id);
            IDBox.Text = n.Id;
            ParteFijaBox.Text = n.ParteFija.ToString();
            ParteVariableBox.Text = n.ParteVariable.ToString();
            HorasBox.Text = n.Horas.ToString();
            TotalBox.Text = n.Total.ToString();
            DateTime f = new DateTime();
            f = n.Fecha;
            //Mes_Box.Text = n.Fecha.Month;
            Anyo_Box.Enabled = true;
            TrabajadorBox.Text = n.Trabajador.Nombre;

        }

        public void ActivarCampos()
        {
            ParteFijaBox.Enabled = true;
            ParteVariableBox.Enabled = true;
            HorasBox.Enabled = true;
            TotalBox.Enabled = true;
            Mes_Box.Enabled = true;
            Anyo_Box.Enabled = true;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            NominaCEN nomina = new NominaCEN();

            if(ParteFijaBox.Text.Length!=0 && ParteVariableBox.Text.Length!=0 && 
                HorasBox.Text.Length!=0 && TotalBox.Text.Length!=0 && Mes_Box.Text.Length!=0 && Anyo_Box.Text.Length!=0)
            {
                float f = ComprobarFloat(ParteFijaBox.Text);
                float v = ComprobarFloat(ParteVariable.Text);
                float h = ComprobarFloat(HorasBox.Text);
                float t = ComprobarFloat(TotalBox.Text);
                int anyo, mes;
                Int32.TryParse(Anyo_Box.Text, out anyo);
                Int32.TryParse(Mes_Box.Text, out mes);
                DateTime fecha = new DateTime(anyo, mes, 1, 0, 0, 0);
                nomina.Editar(IDBox.Text, f, v, h, t, fecha);
            }
            this.Close();
        }

        private float ComprobarFloat(string entrada)
        {
            float solucion;
            bool convertido = float.TryParse(entrada, out solucion);

            if (convertido == false)
            {
                MessageBox.Show(Constantes._ERRORNOMINA);
            }

            return solucion;
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            ActivarCampos();
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
