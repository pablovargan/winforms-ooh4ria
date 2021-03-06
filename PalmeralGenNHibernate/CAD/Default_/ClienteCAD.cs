
using System;
using System.Text;
using PalmeralGenNHibernate.CEN.Default_;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PalmeralGenNHibernate.EN.Default_;
using PalmeralGenNHibernate.Exceptions;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial class ClienteCAD : BasicCAD, IClienteCAD
{
public ClienteCAD() : base ()
{
}

public ClienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClienteEN ReadOIDDefault (string nif)
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), nif);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}


public string Crear (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cliente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cliente.Nif;
}

public void Editar (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), cliente.Nif);

                clienteEN.Nombre = cliente.Nombre;


                clienteEN.Descripcion = cliente.Descripcion;


                clienteEN.Email = cliente.Email;


                clienteEN.Localidad = cliente.Localidad;


                clienteEN.Provincia = cliente.Provincia;


                clienteEN.Pais = cliente.Pais;


                clienteEN.Direccion = cliente.Direccion;


                clienteEN.CodigoPostal = cliente.CodigoPostal;


                clienteEN.Telefono = cliente.Telefono;

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (string nif)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), nif);
                session.Delete (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ClienteEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ClienteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ClienteEN>();
                else
                        result = session.CreateCriteria (typeof(ClienteEN)).List<ClienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ClienteEN> BuscarPorNombre (string p_nombre)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ClienteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ClienteEN self where FROM ClienteEN AS cli WHERE cli.Nombre LIKE CONCAT('%', :p_nombre , '%')";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ClienteENbuscarPorNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<PalmeralGenNHibernate.EN.Default_.ClienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public ClienteEN ObtenerCliente (string nif)
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), nif);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}

public void Unrelationer_instalaciones (string p_cliente, System.Collections.Generic.IList<string> p_instalacion)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.ClienteEN clienteEN = null;
                clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), p_cliente);

                PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacionesENAux = null;
                if (clienteEN.Instalaciones != null) {
                        foreach (string item in p_instalacion) {
                                instalacionesENAux = (PalmeralGenNHibernate.EN.Default_.InstalacionEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.InstalacionEN), item);
                                if (clienteEN.Instalaciones.Contains (instalacionesENAux) == true) {
                                        clienteEN.Instalaciones.Remove (instalacionesENAux);
                                        instalacionesENAux.Cliente = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_instalacion you are trying to unrelationer, doesn't exist in ClienteEN");
                        }
                }

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Relationer_instalaciones (string p_cliente, System.Collections.Generic.IList<string> p_instalacion)
{
        PalmeralGenNHibernate.EN.Default_.ClienteEN clienteEN = null;
        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), p_cliente);
                PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacionesENAux = null;
                if (clienteEN.Instalaciones == null) {
                        clienteEN.Instalaciones = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.InstalacionEN>();
                }

                foreach (string item in p_instalacion) {
                        instalacionesENAux = new PalmeralGenNHibernate.EN.Default_.InstalacionEN ();
                        instalacionesENAux = (PalmeralGenNHibernate.EN.Default_.InstalacionEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.InstalacionEN), item);
                        instalacionesENAux.Cliente = clienteEN;

                        clienteEN.Instalaciones.Add (instalacionesENAux);
                }


                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
