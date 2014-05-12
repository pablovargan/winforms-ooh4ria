using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;
using System.Windows.Forms;

namespace LimpiezasPalmeralForms.Proveedor
{
    class ProveedorPadre
    {
        public ProveedorCEN Proveedor { get; private set; }

        public ProveedorPadre()
        {
            Proveedor = new ProveedorCEN();
        }

        protected virtual void Proveedor_Load(object sender, EventArgs e) { }

        public static void EnableDisableTB(Control container, bool mode)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).ReadOnly = mode;
                else if(c is GroupBox)
                    EnableDisableTB(container, mode);
            }
        }

    }
}
