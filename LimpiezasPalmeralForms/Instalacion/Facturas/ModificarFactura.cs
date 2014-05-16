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

namespace LimpiezasPalmeralForms.Instalacion.Facturas
{
    public partial class ModificarFactura : Form
    {
        public ModificarFactura(string id)
        {
            InitializeComponent();
            MostrarCampos(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarCampos(string id)
        {
            FacturaCEN factcen = new FacturaCEN();
            FacturaEN factura = factcen.ObtenerFactura(id);
            id_box.Text = id;
            horas_box.Text = factura.Horas.ToString();
            precio_hora_box.Text = factura.PrecioHora.ToString();
            comboBox_inst.Text = factura.Instalacion.Id;
            fecha_box.Text = factura.Fecha.ToString();
            total_box.Text = factura.Total.ToString();

            InstalacionCEN instcen = new InstalacionCEN();
            InstalacionEN inst = instcen.ObtenerInstalacion(factura.Instalacion.Id);
            cliente_box.Text = inst.Cliente.Nif;

            id_box.Enabled = false;
            fecha_box.Enabled = false;
            total_box.Enabled = false;
            cliente_box.Enabled = false;
        }

        private void ModificarFactura_Load(object sender, EventArgs e)
        {
            
        }

        private void ulti_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (horas_box.Text != "" && precio_hora_box.Text != "")
            {
                FacturaCEN editada = new FacturaCEN();
                float horas = float.Parse(horas_box.Text);
                float precio_h = float.Parse(precio_hora_box.Text);
                float total = horas * precio_h;
                DateTime dt = Convert.ToDateTime(fecha_box.Text);
                editada.Editar(id_box.Text, horas, precio_h, dt, total);

                this.Close();
            }

            else
            {
                MessageBox.Show("Existen campos vacíos");
            }
        }

        private void horas_box_TextChanged(object sender, EventArgs e)
        {
            if (horas_box.Text != "" && precio_hora_box.Text != "")
            {
                total_box.Text = (float.Parse(horas_box.Text) * float.Parse(precio_hora_box.Text)).ToString();
            }
        }

        private void precio_hora_box_TextChanged(object sender, EventArgs e)
        {
            if (horas_box.Text != "" && precio_hora_box.Text != "")
            {
                total_box.Text = (float.Parse(horas_box.Text) * float.Parse(precio_hora_box.Text)).ToString();
            }
        }
    }
}
