﻿using System;
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
            Buscador.KeyUp += new KeyEventHandler(BuscarNominas);
            Premisa.TextChanged += new EventHandler(BuscarNominas);
            Premisa.SelectedIndex = 0;
        }

        public void Grid_Load(object sender, EventArgs e)
        {
            try
            {
                NominaCEN nomina = new NominaCEN();
                IList<NominaEN> lista = new List<NominaEN>();
                lista = nomina.ObtenerTodas(0, 0);
                Mostrar.DataSource = Convertir_NominaGW(lista);
                ComprobarLista(lista);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }  
        }

        private void ComprobarLista(IList<NominaEN> lista)
        {
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

        private List<NominaGV> Convertir_NominaGW(IList<NominaEN> lista)
        {
            List<NominaGV> l = new List<NominaGV>();

            foreach (NominaEN t in lista)
            {
                TrabajadorCEN trab = new TrabajadorCEN();

                l.Add(new NominaGV()
                {
                    Id = t.Id,
                    ParteFija = t.ParteFija,
                    ParteVariable = t.ParteVariable,
                    Fecha = t.Fecha.ToString(),
                    Horas = t.Horas,
                    DNI_Trabajador = trab.ObtenerTrabajador(t.Trabajador.Nif).Nif,
                    Total = t.Total
                });
            }
            return l;
        }

        private void BuscarNominas(object sender, EventArgs e)
        {
            NominaCEN nomina = new NominaCEN();
            IList<NominaEN> lista = new List<NominaEN>();

            if (Premisa.Text.Equals("Trabajador"))
            {
                if (Buscador.Text.Length == 9)
                {
                    try
                    {
                        TrabajadorCEN trabajador = new TrabajadorCEN();
                        TrabajadorEN t = new TrabajadorEN();
                        t = trabajador.ObtenerTrabajador(Buscador.Text);
                        lista = nomina.ObtenerTodas(0, 0);
                        IList<NominaEN> listabuena = new List<NominaEN>();
                        foreach (NominaEN n in lista)
                        {
                            if (n.Trabajador.Nif.Equals(t.Nif))
                            {
                                listabuena.Add(n);
                            }
                        }
                        Mostrar.DataSource = Convertir_NominaGW(listabuena);
                        ComprobarLista(lista);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else
                {
                    lista = nomina.ObtenerTodas(0, 0);
                    Mostrar.DataSource = Convertir_NominaGW(lista);
                    ComprobarLista(lista);
                } 
            }
            else if (Premisa.Text.Equals("Fecha"))
            {

            }
            else if (Premisa.Text.Equals("Parte Fija"))
            {
                try
                {
                    float solucion;
                    bool convertido = float.TryParse(Buscador.Text, out solucion);

                    if (convertido == false && Buscador.Text.Length!=0)
                    {
                        MessageBox.Show("Porfavor inserte un sueldo númerico");
                    }
                    else if(Buscador.Text.Length==0)
                    {
                        lista = nomina.ObtenerTodas(0, 0);
                        Mostrar.DataSource = Convertir_NominaGW(lista);
                        ComprobarLista(lista);
                    }
                    else
                    {
                        lista = nomina.BuscarPorParteFija(solucion);
                        Mostrar.DataSource = Convertir_NominaGW(lista);
                        ComprobarLista(lista);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

            }
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            CrearNomina pantalla_nomina = new CrearNomina();
            pantalla_nomina.Owner = this;
            pantalla_nomina.Deactivate += new EventHandler(Grid_Load);
            pantalla_nomina.Show();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                NominaGV Nomina = new NominaGV();
                Nomina = (NominaGV)Mostrar.CurrentRow.DataBoundItem;
                ConsultarEditarNominas consulta = new ConsultarEditarNominas(Nomina.Id, Nomina.DNI_Trabajador, false);
                consulta.Owner = this;
                consulta.Deactivate += new EventHandler(Grid_Load);
                consulta.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            NominaCEN nomina = new NominaCEN();
            NominaGV n = (NominaGV)Mostrar.CurrentRow.DataBoundItem;

            ConsultarEditarNominas pantalla_nomina = new ConsultarEditarNominas(n.Id, n.DNI_Trabajador, true);
            pantalla_nomina.Owner = this;
            pantalla_nomina.Deactivate += new EventHandler(Grid_Load);
            pantalla_nomina.Show();
        }
    }
    public class NominaGV
    {
        public string Id { set; get; }
        public float ParteFija { set; get; }
        public float Horas { set; get; }
        public float ParteVariable { set; get; }
        public string Fecha { set; get; }
        public float Total { set; get; }
        public string DNI_Trabajador { set; get; }
    }
}
