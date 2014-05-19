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
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;





namespace LimpiezasPalmeralForms.Backup
{
    public partial class PantallaBackup : Form
    {
        int contador = 0;


        public PantallaBackup()
        {
            InitializeComponent();
            this.Load += new EventHandler(Grid_Load);
        }

        private void Grid_Load(object sender, EventArgs e)
        {

            CopiaSeguridadCEN cs = new CopiaSeguridadCEN();
            IList<CopiaSeguridadEN> lista = new List<CopiaSeguridadEN>();
            lista = cs.ObtenerTodas(0,0);

            dataGridViewCopiasSeguridad.DataSource = lista;

        }


        private string comprobarNombre(string nombre){
            if(File.Exists(@"d:\" + nombre + "-" + contador +".bak")){
                contador++;
                nombre = comprobarNombre(nombre);
            }
            return nombre;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //poner cursor de relojito mientras respalda

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                CopiaSeguridadCEN cs = new CopiaSeguridadCEN();



                //esto puede ser un método aparte de conexion a la base de datos-----------

                SqlConnection connect = new SqlConnection(@"Server=(local)\SQLEXPRESS; database=PalmeralGenNHibernate; integrated security=yes");
                connect.Open();
                //-------------------------------------------------------------------------

                //esto puede ser un método aparte para ejecutar comandos SQL---------------
                string nombre = "resp" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();

                nombre = comprobarNombre(nombre) + "-" + contador;

                SqlCommand command;
                command = new SqlCommand(@"backup database PalmeralGenNHibernate to disk ='d:\" + nombre + ".bak' with init,stats=10", connect);
                command.ExecuteNonQuery();
                //-------------------------------------------------------------------------

                connect.Close();




                //Añade la copia al datagrid
                cs.Crear(nombre, DateTime.Now.ToString(), "D:\\" + nombre + ".bak");
                MessageBox.Show("El Respaldo de la base de datos fue realizada satisfactoriamente", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Grid_Load(sender, e);


            }
            catch
            {
                MessageBox.Show("Debe existir un disco D:\\ secundario para realizar los respaldos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //poner cursor de relojito
            Cursor.Current = Cursors.WaitCursor;

            string fichero = dataGridViewCopiasSeguridad.SelectedRows[0].Cells[0].Value.ToString();

              

            try
            {
                if (File.Exists(@"D:\" + fichero + ".bak"))
                {
                    if (MessageBox.Show("¿Está seguro de restaurar?", "Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //esto puede ser un método aparte de conexion a la base de datos-----------

                        SqlConnection connect = new SqlConnection(@"Server=(local)\SQLEXPRESS; database=PalmeralGenNHibernate; integrated security=yes");
                        connect.Open();
                        //--------------------------------------------------------------------------

                        //esto puede ser un método aparte para ejecutar comandos SQL----------------
                        SqlCommand command;
		                command = new SqlCommand("use master", connect);
  		                command.ExecuteNonQuery();
                        command = new SqlCommand(@"restore database PalmeralGenNHibernate from disk = 'd:\" + fichero +".bak'", connect);
                        command.ExecuteNonQuery();
                        //--------------------------------------------------------------------------
                        connect.Close();

                        MessageBox.Show("Se ha restaurado la base de datos", "Restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(@"No haz hecho ningun respaldo anteriormente (o no está en la ruta correcta)", "Restauracion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }



        


    }
}
