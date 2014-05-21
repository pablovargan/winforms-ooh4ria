using PalmeralGenNHibernate.CEN.Default_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms.Cliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ClienteCEN cliente = new ClienteCEN();
            if (textBoxNIF.Text.Length != 9)
            {
                MessageBox.Show(Constantes._ERRORNIFFORMATO);
            }
            else if (!string.IsNullOrWhiteSpace(textBoxNIF.Text as string))
            {
                NumeroNif nf = new NumeroNif(textBoxNIF.Text);
                if (nf.EsCorrecto)
                {
                    try
                    {
                        cliente.Crear(textBoxNIF.Text, textBoxNombre.Text, textBoxDescripcion.Text,
                            textBoxEmail.Text, textBoxLocalidad.Text, textBoxProvincia.Text, textBoxPais.Text,
                            textBoxDireccion.Text, textBoxCP.Text, textBoxTelefono.Text);
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Constantes._ERRORCREAR);
                    }
                }
                else 
                {
                    MessageBox.Show(Constantes._ERRORNIFFORMATO);
                }
            }
            else
                MessageBox.Show(Constantes._ERRORNIF);
           
        }
    }
}
