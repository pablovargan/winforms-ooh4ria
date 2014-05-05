using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms.Principal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            String usuario = "judas";
            String pass = "judas";

            if(textBoxUsuario.Text == usuario && textBoxPass.Text == pass)
            {
                PantallaPrincipal p = new PantallaPrincipal() { Owner = this };
                p.Owner = this;
                p.StartPosition = FormStartPosition.CenterParent;
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña no es correcto");
            }
        }
    }
}
