
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
public partial class TrabajadorCAD : BasicCAD, ITrabajadorCAD
{
public TrabajadorCAD() : base ()
{
}

public TrabajadorCAD(ISession sessionAux) : base (sessionAux)
{
}



public TrabajadorEN ReadOIDDefault (string nif)
{
        TrabajadorEN trabajadorEN = null;

        try
        {
                SessionInitializeTransaction ();
                trabajadorEN = (TrabajadorEN)session.Get (typeof(TrabajadorEN), nif);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return trabajadorEN;
}


public string Crear (TrabajadorEN trabajador)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (trabajador);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return trabajador.Nif;
}

public void Editar (TrabajadorEN trabajador)
{
        try
        {
                SessionInitializeTransaction ();
                TrabajadorEN trabajadorEN = (TrabajadorEN)session.Load (typeof(TrabajadorEN), trabajador.Nif);

                trabajadorEN.Nombre = trabajador.Nombre;


                trabajadorEN.Apellidos = trabajador.Apellidos;


                trabajadorEN.Direccion = trabajador.Direccion;


                trabajadorEN.Telefono = trabajador.Telefono;


                trabajadorEN.CodigoPostal = trabajador.CodigoPostal;


                trabajadorEN.Pais = trabajador.Pais;


                trabajadorEN.Localidad = trabajador.Localidad;


                trabajadorEN.Provincia = trabajador.Provincia;


                trabajadorEN.Tipo = trabajador.Tipo;

                session.Update (trabajadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
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
                TrabajadorEN trabajadorEN = (TrabajadorEN)session.Load (typeof(TrabajadorEN), nif);
                session.Delete (trabajadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<TrabajadorEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<TrabajadorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TrabajadorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TrabajadorEN>();
                else
                        result = session.CreateCriteria (typeof(TrabajadorEN)).List<TrabajadorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public TrabajadorEN ObtenerTrabajador (string nif)
{
        TrabajadorEN trabajadorEN = null;

        try
        {
                SessionInitializeTransaction ();
                trabajadorEN = (TrabajadorEN)session.Get (typeof(TrabajadorEN), nif);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return trabajadorEN;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorLocalidad (string p_localidad)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TrabajadorEN self where FROM TrabajadorEN AS trab WHERE trab.Localidad = :p_localidad";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TrabajadorENbuscarPorLocalidadHQL");
                query.SetParameter ("p_localidad", p_localidad);

                result = query.List<PalmeralGenNHibernate.EN.Default_.TrabajadorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorProvincia (string p_provincia)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TrabajadorEN self where FROM TrabajadorEN AS trab WHERE trab.Provincia = :p_provincia";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TrabajadorENbuscarPorProvinciaHQL");
                query.SetParameter ("p_provincia", p_provincia);

                result = query.List<PalmeralGenNHibernate.EN.Default_.TrabajadorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorTipo (PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum p_tipoEmpleo)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TrabajadorEN self where FROM TrabajadorEN AS trab WHERE trab.Tipo = :p_tipoEmpleo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TrabajadorENbuscarPorTipoHQL");
                query.SetParameter ("p_tipoEmpleo", p_tipoEmpleo);

                result = query.List<PalmeralGenNHibernate.EN.Default_.TrabajadorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in TrabajadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
