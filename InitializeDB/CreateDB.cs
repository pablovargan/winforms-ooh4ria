
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
                clienteCEN.Crear ("11111111A", "Juan", "Cliente 1", "pepe@gmail.com", "Aspe", "Alicante", "España", "Calle de Pepe", "03680", "123456789");
                ClienteCEN clienteCEN2 = new ClienteCEN();
                clienteCEN.Crear ("22222222B", "Oscar", "Cliente 2", "pepe@gmail.com", "Aspe", "Alicante", "España", "Calle de Pepe", "03680", "123456789");
                ClienteCEN clienteCEN3 = new ClienteCEN();
                clienteCEN.Crear ("33333333C", "Antonio", "Cliente 3", "pepe@gmail.com", "Aspe", "Alicante", "España", "Calle de Pepe", "03680", "123456789");
                ClienteCEN clienteCEN4 = new ClienteCEN();
                clienteCEN.Crear("44444444D", "Pablo", "Cliente 4", "pepe@gmail.com", "Aspe", "Alicante", "España", "Calle de Pepe", "03680", "123456789");

                ProductoCEN productoCEN = new ProductoCEN ();
                productoCEN.Crear ("1", "lejia", "Limpialo todo", 5, "foto.com");
                productoCEN.Crear ("2", "lejia", "Limpialo todo", 5, "foto.com");
                ProveedorCEN proveedorCEN = new ProveedorCEN ();
                proveedorCEN.Crear ("1", "Proveedor 1", "123456789", "Calle", "Aspe", "Alicante", "09080", "email@gmail.com", "España", "oooo que chulo");
                proveedorCEN.Crear("2", "Proveedor 1", "123456789", "Calle", "Aspe", "Alicante", "09080", "email@gmail.com", "Espa�a", "oooo que chulo");
                proveedorCEN.Crear("3", "Proveedor 1", "123456789", "Calle", "Aspe", "Alicante", "09080", "email@gmail.com", "Espa�a", "oooo que chulo");
                TrabajadorCEN trabajadorCEN = new TrabajadorCEN ();
                trabajadorCEN.Crear ("11111111A", "Trabajador 1", "Apellidos trabajador1", "Calle del trabajador1", "123456789", "00440", "Espa�a", "Asspen", "Alicante", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Cooperativista);
                trabajadorCEN.Crear ("22222222B", "Trabajador 2", "Apellidos trabajador2", "Calle del trabajador2", "234552345", "00442", "Espa�a", "Villena", "AxoWorld", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);
                trabajadorCEN.Crear ("33333333C", "Trabajador 3", "Apellidos trabajador3", "Calle del trabajador3", "235254534", "00443", "Francia", "Buxusua", "Buxusue", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);
                trabajadorCEN.Crear ("44444444D", "Trabajador 4", "Apellidos trabajador4", "Calle del trabajador4", "623452345", "00444", "Espa�a", "de por ahi", "Perdio", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);

                IList<LineaPedidoEN> lineas = new List<LineaPedidoEN>();
                lineas.Add (new LineaPedidoEN (1, 5, productoCEN.get_IProductoCAD ().ReadOIDDefault ("1"), null));
                lineas.Add (new LineaPedidoEN (2, 4, productoCEN.get_IProductoCAD ().ReadOIDDefault ("2"), null));

                IList<PedidoEN> pedidos = new List<PedidoEN>();
                pedidos.Add(new PedidoEN("1", DateTime.Today, PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum.Enviado, PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum.Contado,lineas,proveedorCEN.get_IProveedorCAD().ReadOIDDefault("1")));

                PedidoCEN pedido = new PedidoCEN();
                pedido.Crear(pedidos[0].Id, pedidos[0].Fecha, pedidos[0].Estado, pedidos[0].TipoPago, pedidos[0].Lineas, pedidos[0].Proveedor.Id);

                IList<InstalacionEN> instalaciones = new List<InstalacionEN>();

                InstalacionCEN instalacion = new InstalacionCEN();

                instalacion.Crear("1", "insta", "descr", "alicante", "alicante", "españa", "calle", "03009", "666666", 15 , "11111111A");
                instalacion.Crear("2", "insta2", "descr2", "elche", "alicante", "españa", "calle", "03008", "666667", 15, "22222222B");
                instalacion.Crear("3", "insta3", "descr3", "mislata", "valencia", "españa", "calle", "03509", "666566", 15, "33333333C");
                instalacion.Crear("4", "insta4", "descr4", "alcora", "castellon", "españa", "calle", "03409", "663366", 15, "44444444D");

                IList<TrabajadorEN> trabajadores = new List<TrabajadorEN>(); trabajadores.Add(new TrabajadorEN("000000", "d", "a", "calle", "telefono", "00", "e", "a", "a", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado, null, null));

                JornadaFechaCEN j = new JornadaFechaCEN(); 
                IList<JornadaFechaEN> jornadas = new List<JornadaFechaEN>(); jornadas.Add(new JornadaFechaEN(1, DateTime.Now, trabajadores, instalacion.ObtenerInstalacion("1")));

                //IList<JornadaFechaEN> jor = j.ReadFilter(DateTime.Now, "1");
                //Console.WriteLine(jor.Count == 0 ? jor[0].Trabajadores.ToString() : "Esta vacia");
            
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
