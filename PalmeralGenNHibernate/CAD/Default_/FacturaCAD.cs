
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
public partial class FacturaCAD : BasicCAD, IFacturaCAD
{
public FacturaCAD() : base ()
{
}

public FacturaCAD(ISession sessionAux) : base (sessionAux)
{
}



public FacturaEN ReadOIDDefault (string id)
{
        FacturaEN facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                facturaEN = (FacturaEN)session.Get (typeof(FacturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return facturaEN;
}


public string Crear (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                if (factura.Instalacion != null) {
                        factura.Instalacion = (PalmeralGenNHibernate.EN.Default_.InstalacionEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.InstalacionEN), factura.Instalacion.Id);

                        factura.Instalacion.Facturas.Add (factura);
                }

                session.Save (factura);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return factura.Id;
}

public void Editar (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                FacturaEN facturaEN = (FacturaEN)session.Load (typeof(FacturaEN), factura.Id);

                facturaEN.Horas = factura.Horas;


                facturaEN.PrecioHora = factura.PrecioHora;


                facturaEN.Fecha = factura.Fecha;


                facturaEN.Total = factura.Total;

                session.Update (facturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
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
                FacturaEN facturaEN = (FacturaEN)session.Load (typeof(FacturaEN), id);
                session.Delete (facturaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> ObtenerFacturasInstalacion (string p_instalacion)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM FacturaEN self where FROM FacturaEN AS fac WHERE fac.p_instalacion = :p_instalacion";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("FacturaENobtenerFacturasInstalacionHQL");
                query.SetParameter ("p_instalacion", p_instalacion);

                result = query.List<PalmeralGenNHibernate.EN.Default_.FacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public FacturaEN ObtenerFactura (string id)
{
        FacturaEN facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                facturaEN = (FacturaEN)session.Get (typeof(FacturaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> ObtenterTodas (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(FacturaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<FacturaEN>();
                else
                        result = session.CreateCriteria (typeof(FacturaEN)).List<FacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> ObtenerPorAnyo (string p_anyo)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM FacturaEN self where FROM FacturaEN AS fac WHERE year(fac.fecha) = :p_anyo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("FacturaENobtenerPorAnyoHQL");
                query.SetParameter ("p_anyo", p_anyo);

                result = query.List<PalmeralGenNHibernate.EN.Default_.FacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> ObtenerPorMesAnyo (string p_mes, string p_anyo)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM FacturaEN self where FROM FacturaEN AS fac WHERE month(fac.fecha) = :p_mes AND year(fac.fecha) = :p_anyo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("FacturaENobtenerPorMesAnyoHQL");
                query.SetParameter ("p_mes", p_mes);
                query.SetParameter ("p_anyo", p_anyo);

                result = query.List<PalmeralGenNHibernate.EN.Default_.FacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in FacturaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
