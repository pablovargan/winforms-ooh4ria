using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;




namespace LimpiezasPalmeralForms.Backup
{
    public partial class PantallaBackup : Form
    {



        public PantallaBackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             //poner cursor de relojito mintras respalda
             Cursor.Current = Cursors.WaitCursor;


            //esto puede ser un método aparte de conexion a la base de datos-----------

            SqlConnection connect = new SqlConnection(@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");
            connect.Open();
            //-------------------------------------------------------------------------

            //esto puede ser un método aparte para ejecutar comandos SQL---------------
            SqlCommand command;
            command = new SqlCommand(@"backup database PalmeralGenNHibernate to disk ='c:\resp.bak' with init,stats=10", connect);
            command.ExecuteNonQuery();
            //-------------------------------------------------------------------------

            connect.Close();

            MessageBox.Show("El Respaldo de la base de datos fue realizado satisfactoriamente", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        


    }
}
