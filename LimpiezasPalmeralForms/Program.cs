using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using PalmeralGenNHibernate.EN.Default_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                InitializeDB.CreateDB.Create("PalmeralGenNHibernate", "nhibernateUser", "nhibernatePass");
                var cfg = new Configuration();
                cfg.Configure();
                cfg.AddAssembly(typeof(ProductoEN).Assembly);
                new SchemaExport(cfg).Execute(true, true, false);
                InitializeDB.CreateDB.InitializeData();
            }
            catch(Exception e)
            {
                System.Console.WriteLine (e.Message.ToString () + '\n' + e.StackTrace);
            }
            finally
            {
                Application.Run(new PantallaPrincipal());
            }
        }
    }
}
