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
            UsuarioCEN usuario = new UsuarioCEN();
            UsuarioEN usuarioEN = usuario.ObtenerPorUsuario(textBoxUsuario.Text);

            if (usuarioEN != null && usuarioEN.Password != null)
            {
                if (usuarioEN.Password == textBoxPass.Text)
                {
                    PantallaPrincipal p = new PantallaPrincipal() { Owner = this };
                    p.ShowDialog();
                    textBoxUsuario.Text = "";
                    textBoxPass.Text = "";
                }
                else
                {
                    DialogResult error = MessageBox.Show(Constantes._ERRORLOGINPASS, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult error = MessageBox.Show(Constantes._ERRORLOGINUSER, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
