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
                Provincia.Text.Length != 0 && Tipo1.Text.Length != 0)
            {
                if (NIF.Text.Length == 9)
                {
                    NumeroNif nf = new NumeroNif(NIF.Text);
                    if (nf.EsCorrecto)
                    {

                        try
                        {
                            if (Tipo1.SelectedItem.ToString().Equals("Cooperativista"))
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
                            MessageBox.Show(Constantes._ERRORTRABAJADOR);
                            throw exp;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Constantes._ERRORNIFFORMATO);
                    }
                }
                else
                {
                    MessageBox.Show(Constantes._ERRORNIFFORMATO);
                }
            }
            else
            {
                //alert hay campos sin rellenar
                MessageBox.Show(Constantes._ERRORCAMPOSVACIOS);
            }
        
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //cerrar ventana
            this.Close();
        }

        private void Tipo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pais_TextChanged(object sender, EventArgs e)
        {

        }

        private void Provincia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Localidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void CP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
