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

        private void Crear_Click(object sender, EventArgs e)
        {
            //Crear trabajador
            TrabajadorCEN trabajador = new TrabajadorCEN();

            if (NIF.Text.Length != 0 && Nombre.Text.Length != 0 && Apellidos.Text.Length != 0 && Direccion.Text.Length != 0 &&
                Telefono.Text.Length != 0 && CP.Text.Length != 0 && Pais.Text.Length != 0 && Localidad.Text.Length != 0 &&
                Provincia.Text.Length != 0 && Tipo.Text.Length != 0)
            {
                try
                {
                    if (Tipo.SelectedItem.ToString().Equals("Cooperativista"))
                    {
                        trabajador.Crear(NIF.Text, Nombre.Text, Apellidos.Text, Direccion.Text, Telefono.Text,
                            CP.Text, Pais.Text, Localidad.Text, Provincia.Text, TipoEmpleoEnum.Cooperativista);
                    }
                    else
                    {
                        trabajador.Crear(NIF.Text, Nombre.Text, Apellidos.Text, Direccion.Text, Telefono.Text,
                            CP.Text, Pais.Text, Localidad.Text, Provincia.Text, TipoEmpleoEnum.Empleado);
                    }
                    //alert Creado correctamente
                    //MessageBox.Show("Trabajador creado correctamente");
                    this.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("El trabajador no se pudo crear");
                    //throw exp;
                }
            }
            else
            {
                //alert hay campos sin rellenar
                MessageBox.Show("Existen campos vacios");
            }
        
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //cerrar ventana
            this.Close();
        }
    }
}
