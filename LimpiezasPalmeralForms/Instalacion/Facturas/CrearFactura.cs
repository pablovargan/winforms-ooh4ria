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
    public partial class CrearFactura : Form
    {
        public CrearFactura()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearFactura_Load(object sender, EventArgs e)
        {
            InstalacionCEN instcen = new InstalacionCEN();
            IList<InstalacionEN> instalaciones = instcen.ObtenerTodas(0, 0);
            IList<string> combo = new List<string>();

            foreach (InstalacionEN i in instalaciones)
            {
                combo.Add(i.Id);
            }

            comboBox_inst.DataSource = combo;
            fecha_box.Enabled = false;
            fecha_box.Text = DateTime.UtcNow.ToString();
            total_box.Enabled = false;
            total_box.Text = "0";
            cliente_box.Enabled = false;
            cliente_box.Text = instcen.ObtenerInstalacion(comboBox_inst.Text).Cliente.Nif;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            var _factura = new FacturaCEN();
            string id = (new FacturaCEN().ObtenterTodas(0, 0).Count + 1).ToString();

            if (horas_box.Text != "" && precio_hora_box.Text != "")
            {            
                DateTime dt = Convert.ToDateTime(fecha_box.Text);
                float horas = float.Parse(horas_box.Text);
                float precio_h = float.Parse(precio_hora_box.Text);
                _factura.Crear(id, horas, precio_h, dt, (horas * precio_h), comboBox_inst.Text);
            }

            else
            {
                MessageBox.Show("Faltan campos por rellenar");
            }

            this.Close();
        }

        private void comboBox_inst_SelectedIndexChanged(object sender, EventArgs e)
        {
            InstalacionCEN instcen = new InstalacionCEN();
            cliente_box.Text = instcen.ObtenerInstalacion(comboBox_inst.Text).Cliente.Nif;
        }

        private void precio_hora_box_TextChanged(object sender, EventArgs e)
        {
            if(horas_box.Text != "" && precio_hora_box.Text != "") 
            {
                total_box.Text = (float.Parse(horas_box.Text) * float.Parse(precio_hora_box.Text)).ToString();
            }
        }

        private void horas_box_TextChanged(object sender, EventArgs e)
        {
            if (horas_box.Text != "" && precio_hora_box.Text != "")
            {
                total_box.Text = (float.Parse(horas_box.Text) * float.Parse(precio_hora_box.Text)).ToString();
            }
        }
    }
}
