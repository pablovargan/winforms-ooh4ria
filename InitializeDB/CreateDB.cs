
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using PalmeralGenNHibernate.EN.Default_;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.CAD.Default_;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                /*List<PalmeralGenNHibernate.EN.Mediaplayer.MusicTrackEN> musicTracks = new List<PalmeralGenNHibernate.EN.Mediaplayer.MusicTrackEN>();
                 * PalmeralGenNHibernate.EN.Mediaplayer.UserEN userEN = new PalmeralGenNHibernate.EN.Mediaplayer.UserEN();
                 * PalmeralGenNHibernate.EN.Mediaplayer.ArtistEN artistEN = new PalmeralGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * PalmeralGenNHibernate.EN.Mediaplayer.MusicTrackEN musicTrackEN = new PalmeralGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * PalmeralGenNHibernate.CEN.Mediaplayer.ArtistCEN artistCEN = new PalmeralGenNHibernate.CEN.Mediaplayer.ArtistCEN();
                 * PalmeralGenNHibernate.CEN.Mediaplayer.UserCEN userCEN = new PalmeralGenNHibernate.CEN.Mediaplayer.UserCEN();
                 * PalmeralGenNHibernate.CEN.Mediaplayer.MusicTrackCEN musicTrackCEN = new PalmeralGenNHibernate.CEN.Mediaplayer.MusicTrackCEN();
                 * PalmeralGenNHibernate.CEN.Mediaplayer.PlayListCEN playListCEN = new PalmeralGenNHibernate.CEN.Mediaplayer.PlayListCEN();
                 *
                 *              //Add Users
                 * userEN.Email = "user@user.com";
                 * userEN.Name = "user";
                 * userEN.Surname = "userSurname";
                 * userEN.Password = "user";
                 * userCEN.New_(userEN.Name, userEN.Surname, userEN.Email, userEN.Password);
                 *
                 * //Add Music Track1
                 * musicTrackEN.Id = "http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "Beer Beer Beer Beer Beer Beer ..";
                 * musicTrackEN.Name = "Beer Beer Beer";
                 * musicTrackEN.Company = "Company";
                 * musicTrackEN.Cover = "http://www.tomasabraham.com.ar/cajadig/2007/images/nro18-2/beer1.jpg";
                 * musicTrackEN.Price = 20;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 200;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 * musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Define Album
                 * //PalmeralGenNHibernate.CEN.Mediaplayer.AlbumCEN albumCEN = new PalmeralGenNHibernate.CEN.Mediaplayer.AlbumCEN();
                 * //albumCEN.New_("Album 1", "This is a Album 1", artists, musicTracks);*/

                ClienteCEN clienteCEN = new ClienteCEN ();
                clienteCEN.Crear ("11111111A", "Juan", "Cliente 1", "juan@gmail.com", "Aspe", "Alicante", "España", "Calle de Juan", "03680", "666332211");
                clienteCEN.Crear ("22222222B", "Pepe", "Cliente 2", "pepe@gmail.com", "Elche", "Alicante", "España", "Calle de Pepe", "03682", "666778899");
                clienteCEN.Crear ("33333333C", "Paco", "Cliente 3", "paco@gmail.com", "Elda", "Alicante", "España", "Calle de Paco", "03681", "666554433");

                ProductoCEN productoCEN = new ProductoCEN ();
                productoCEN.Crear ("1", "lejia", "Limpialo todo", 5, "foto.com");
                productoCEN.Crear ("2", "lejia", "Limpialo todo", 5, "foto.com");
                ProveedorCEN proveedorCEN = new ProveedorCEN ();
                proveedorCEN.Crear ("1", "Proveedor 1", "123456789", "Calle", "Aspe", "Alicante", "09080", "email@gmail.com", "España", "oooo que chulo");

                TrabajadorCEN trabajadorCEN = new TrabajadorCEN ();
                trabajadorCEN.Crear ("55555555A", "Dani", "Valero Clavel", "Calle del trabajador", "123456789", "00440", "España", "Elche", "Alicante", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);
                trabajadorCEN.Crear ("66666666B", "Victor", "Vives Boix", "Calle del trabajador", "123456789", "00440", "España", "Elche", "Alicante", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Cooperativista);
                trabajadorCEN.Crear ("77777777C", "Alberto", "Martinez Martinez", "Calle del trabajador", "123456789", "00440", "España", "Villena", "Alicante", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);
                trabajadorCEN.Crear ("88888888D", "Hector", "Martinez Matias", "Calle del trabajador", "123456789", "00440", "España", "Alicante", "Alicante", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);

                IList<LineaPedidoEN> lineas = new List<LineaPedidoEN>();
                lineas.Add (new LineaPedidoEN (1, 5, productoCEN.get_IProductoCAD ().ReadOIDDefault ("1"), null));
                lineas.Add (new LineaPedidoEN (2, 4, productoCEN.get_IProductoCAD ().ReadOIDDefault ("2"), null));



                IList<PedidoEN> pedidos = new List<PedidoEN>();
                pedidos.Add (new PedidoEN ("1", DateTime.Today, PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum.Enviado, PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum.Contado, lineas, proveedorCEN.get_IProveedorCAD ().ReadOIDDefault ("1")));

                PedidoCEN pedido = new PedidoCEN ();
                pedido.Crear (pedidos [0].Id, pedidos [0].Fecha, pedidos [0].Estado, pedidos [0].TipoPago, pedidos [0].Lineas, pedidos [0].Proveedor.Id);

                InstalacionCEN instalacionCEN = new InstalacionCEN();
                instalacionCEN.Crear("1","Colegio 1","Colegio 1","Elche","Alicante","España","Calle 1","03200","666778899",405,"11111111A");
                instalacionCEN.Crear("2", "Colegio 2", "Colegio 2", "Alicante", "Alicante", "España", "Calle 2", "03202", "666778899", 612, "11111111A");
                instalacionCEN.Crear("3", "Colegio 3", "Colegio 3", "Manises", "Valencia", "España", "Calle 3", "03203", "666778899", 234, "22222222B");
                instalacionCEN.Crear("4", "Colegio 4", "Colegio 4", "Alcora", "Castellón", "España", "Calle 4", "03204", "666554422", 754, "33333333C");

                IList<string> listaTrabajadores = new List<string>();
                listaTrabajadores.Add("11111111A");
                InstalacionEN _ins = instalacionCEN.ObtenerInstalacion("1");
                
                UsuarioCEN usuarioCEN = new UsuarioCEN();
                usuarioCEN.Crear("Secretaria", "secretaria", "00000001R", "Secretaria", "Apellidos trabajador", "Calle del trabajador", "123456789", "00440", "España", "Asspen", "Alicante", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Cooperativista);

                FacturaCEN facturaCEN = new FacturaCEN();
                facturaCEN.Crear("1", 200, 8, DateTime.Today, 1600, "1");
                facturaCEN.Crear("2", 220, 8, DateTime.Today, 1760, "2");
                facturaCEN.Crear("3", 310, 8, DateTime.Today, 2480, "3");
                facturaCEN.Crear("4", 300, 8, DateTime.Today, 2400, "1");
                facturaCEN.Crear("5", 100, 8, DateTime.Today, 800, "2");
                facturaCEN.Crear("6", 120, 8, DateTime.Today, 960, "2");
                facturaCEN.Crear("7", 230, 8, DateTime.Today, 1840, "1");
                facturaCEN.Crear("8", 240, 8, DateTime.Today, 1920, "3");
                facturaCEN.Crear("9", 170, 8, DateTime.Today, 2160, "1");

                NominaCEN nominaCEN = new NominaCEN();
                DateTime fecha = new DateTime(2008, 5, 1, 2, 2, 2);
            
                
                nominaCEN.Crear("1", 5, 5, 5, 5, fecha, "77777777C");
                 NominaEN nomina = nominaCEN.ObtenerNomina("1");


            

            /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
