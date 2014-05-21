
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
public partial class CopiaSeguridadCAD : BasicCAD, ICopiaSeguridadCAD
{
public CopiaSeguridadCAD() : base ()
{
}

public CopiaSeguridadCAD(ISession sessionAux) : base (sessionAux)
{
}



public CopiaSeguridadEN ReadOIDDefault (string id)
{
        CopiaSeguridadEN copiaSeguridadEN = null;

        try
        {
                SessionInitializeTransaction ();
                copiaSeguridadEN = (CopiaSeguridadEN)session.Get (typeof(CopiaSeguridadEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in CopiaSeguridadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return copiaSeguridadEN;
}


public string Crear (CopiaSeguridadEN copiaSeguridad)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (copiaSeguridad);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in CopiaSeguridadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return copiaSeguridad.Id;
}

public void Editar (CopiaSeguridadEN copiaSeguridad)
{
        try
        {
                SessionInitializeTransaction ();
                CopiaSeguridadEN copiaSeguridadEN = (CopiaSeguridadEN)session.Load (typeof(CopiaSeguridadEN), copiaSeguridad.Id);

                copiaSeguridadEN.Fecha = copiaSeguridad.Fecha;


                copiaSeguridadEN.Ruta = copiaSeguridad.Ruta;

                session.Update (copiaSeguridadEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in CopiaSeguridadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (string id)
{
        try
        {
                SessionInitializeTransaction ();
                CopiaSeguridadEN copiaSeguridadEN = (CopiaSeguridadEN)session.Load (typeof(CopiaSeguridadEN), id);
                session.Delete (copiaSeguridadEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in CopiaSeguridadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<CopiaSeguridadEN> ObtenerTodas (int first, int size)
{
        System.Collections.Generic.IList<CopiaSeguridadEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CopiaSeguridadEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CopiaSeguridadEN>();
                else
                        result = session.CreateCriteria (typeof(CopiaSeguridadEN)).List<CopiaSeguridadEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in CopiaSeguridadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public CopiaSeguridadEN ObtenerPorOID (string id)
{
        CopiaSeguridadEN copiaSeguridadEN = null;

        try
        {
                SessionInitializeTransaction ();
                copiaSeguridadEN = (CopiaSeguridadEN)session.Get (typeof(CopiaSeguridadEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in CopiaSeguridadCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return copiaSeguridadEN;
}
}
}
