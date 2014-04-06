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

namespace LimpiezasPalmeralForms
{
    public partial class PantallaTrabajador : Form
    {
        public PantallaTrabajador()
        {
            InitializeComponent();
            this.Load += new EventHandler(Grid_Load);
            this.Load += new EventHandler(Grid_Load);
           // Mostrar.LostFocus += new EventHandler(Desactivar_Botones);
            Buscador.KeyUp += new KeyEventHandler(Buscar_Trabajadores);
            Buscador.Click += new EventHandler(Grid_Load);
            Eliminar.Click += new EventHandler(Grid_Load);
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
            else
            {
                
                
            }
            Mostrar.ClearSelection();

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
            if (Mostrar.SelectedRows == null)
            {
                MessageBox.Show("Seleccion el trabajador que desee eliminar");
            }
            else
            {
                TrabajadorCEN trabajador = new TrabajadorCEN();
                TrabajadorGV trabajador_eliminar = (TrabajadorGV)Mostrar.CurrentRow.DataBoundItem;
                MessageBox.Show("Desea eliminar: " + trabajador_eliminar.Nombre);
                trabajador.Eliminar(trabajador_eliminar.Nif);
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

        }

        private void Mostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Eliminar.Enabled = true;
            Modificar.Enabled = true;
        }
        private void Desactivar_Botones(object sender, EventArgs e)
        {
            Eliminar.Enabled = false;
            Modificar.Enabled = false;
        }

        private void Buscador_Click(object sender, EventArgs e)
        {
            Buscador.Text = "";
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