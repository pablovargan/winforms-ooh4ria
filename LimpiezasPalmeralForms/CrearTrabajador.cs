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
using PalmeralGenNHibernate.Enumerated.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralForms
{
    public partial class CrearTrabajador : Form
    {
        public CrearTrabajador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear trabajador
            TrabajadorCEN trabajador = new TrabajadorCEN();

            String nif, nom, ape, dir, lo, pro, pa, tel, c;
            nif = NIF.Text;
            nom = Nombre.Text;
            ape = Apellidos.Text;
            dir = Direccion.Text;
            lo = Localidad.Text;
            c = CP.Text;
            pro = Provincia.Text;
            pa = Pais.Text;
            tel = Telefono.Text;
            try
            {
                //if (Tipo.SelectedItem.ToString().Equals("Cooperativista"))
                //{
                    trabajador.Crear(nif, nom, ape, dir, tel, c, pa, lo, pro, TipoEmpleoEnum.Cooperativista);
                //}
                //else
                //{
                //    trabajador.Crear(nif, nom, ape, dir, tel, c, pa, lo, pro, TipoEmpleoEnum.Empleado);
                //}
                TrabajadorEN t=trabajador.ObtenerTrabajador(nif);
                prueba.Text = t.Nif;
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }
    }
}
