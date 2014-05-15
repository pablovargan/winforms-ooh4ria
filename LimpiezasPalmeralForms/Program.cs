using NHibernate.Cfg;
using LimpiezasPalmeralForms.Principal;
using NHibernate.Tool.hbm2ddl;
using PalmeralGenNHibernate.EN.Default_;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimpiezasPalmeralForms.Pedidos;


namespace LimpiezasPalmeralForms
{
    public static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            bool activo;
            System.Threading.Mutex m = new System.Threading.Mutex(true, "LimpiezasPalmeralForms", out activo);

            if (!activo)
            {
                MessageBox.Show("Ya se ha iniciado la aplicación");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                try
                {

                    // Application.Run(new Login());

                    //Application.Run(new Login());

                    Application.Run(new PantallaPrincipal());
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message.ToString() + '\n' + ex.StackTrace);
                }
            }
            // Se libera la exclusión mutua
            m.ReleaseMutex();
        }
    }
}
