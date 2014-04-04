
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
public partial class JornadaFechaCAD : BasicCAD, IJornadaFechaCAD
{
public JornadaFechaCAD() : base ()
{
}

public JornadaFechaCAD(ISession sessionAux) : base (sessionAux)
{
}



public JornadaFechaEN ReadOIDDefault (int id)
{
        JornadaFechaEN jornadaFechaEN = null;

        try
        {
                SessionInitializeTransaction ();
                jornadaFechaEN = (JornadaFechaEN)session.Get (typeof(JornadaFechaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in JornadaFechaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return jornadaFechaEN;
}


public int Crear (JornadaFechaEN jornadaFecha)
{
        try
        {
                SessionInitializeTransaction ();
                if (jornadaFecha.Instalacion != null) {
                        jornadaFecha.Instalacion = (PalmeralGenNHibernate.EN.Default_.InstalacionEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.InstalacionEN), jornadaFecha.Instalacion.Id);

                        jornadaFecha.Instalacion.Jornadas.Add (jornadaFecha);
                }

                session.Save (jornadaFecha);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in JornadaFechaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return jornadaFecha.Id;
}

public void Editar (JornadaFechaEN jornadaFecha)
{
        try
        {
                SessionInitializeTransaction ();
                JornadaFechaEN jornadaFechaEN = (JornadaFechaEN)session.Load (typeof(JornadaFechaEN), jornadaFecha.Id);

                jornadaFechaEN.Fecha = jornadaFecha.Fecha;

                session.Update (jornadaFechaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in JornadaFechaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int id)
{
        try
        {
                SessionInitializeTransaction ();
                JornadaFechaEN jornadaFechaEN = (JornadaFechaEN)session.Load (typeof(JornadaFechaEN), id);
                session.Delete (jornadaFechaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in JornadaFechaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public JornadaFechaEN ObtenerJornada (int id)
{
        JornadaFechaEN jornadaFechaEN = null;

        try
        {
                SessionInitializeTransaction ();
                jornadaFechaEN = (JornadaFechaEN)session.Get (typeof(JornadaFechaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in JornadaFechaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return jornadaFechaEN;
}

public System.Collections.Generic.IList<JornadaFechaEN> ObtenerTodas (int first, int size)
{
        System.Collections.Generic.IList<JornadaFechaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(JornadaFechaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<JornadaFechaEN>();
                else
                        result = session.CreateCriteria (typeof(JornadaFechaEN)).List<JornadaFechaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in JornadaFechaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> ReadFilter (Nullable<DateTime> p_fecha, PalmeralGenNHibernate.EN.Default_.InstalacionEN p_instalacion)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM JornadaFechaEN self where FROM JornadaFechaEN AS jor WHERE jor.Fecha := p_fecha AND jor.Instalacion := p_instalacion";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("JornadaFechaENreadFilterHQL");
                query.SetParameter ("p_fecha", p_fecha);
                query.SetParameter ("p_instalacion", p_instalacion);

                result = query.List<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in JornadaFechaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
