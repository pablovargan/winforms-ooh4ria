
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
public partial class NominaCAD : BasicCAD, INominaCAD
{
public NominaCAD() : base ()
{
}

public NominaCAD(ISession sessionAux) : base (sessionAux)
{
}



public NominaEN ReadOIDDefault (string id)
{
        NominaEN nominaEN = null;

        try
        {
                SessionInitializeTransaction ();
                nominaEN = (NominaEN)session.Get (typeof(NominaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return nominaEN;
}


public string Crear (NominaEN nomina)
{
        try
        {
                SessionInitializeTransaction ();
                if (nomina.Trabajador != null) {
                        nomina.Trabajador = (PalmeralGenNHibernate.EN.Default_.TrabajadorEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.TrabajadorEN), nomina.Trabajador.Nif);

                        nomina.Trabajador.Nominas.Add (nomina);
                }

                session.Save (nomina);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return nomina.Id;
}

public void Editar (NominaEN nomina)
{
        try
        {
                SessionInitializeTransaction ();
                NominaEN nominaEN = (NominaEN)session.Load (typeof(NominaEN), nomina.Id);

                nominaEN.ParteFija = nomina.ParteFija;


                nominaEN.ParteVariable = nomina.ParteVariable;


                nominaEN.Horas = nomina.Horas;


                nominaEN.Total = nomina.Total;


                nominaEN.Fecha = nomina.Fecha;

                session.Update (nominaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
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
                NominaEN nominaEN = (NominaEN)session.Load (typeof(NominaEN), id);
                session.Delete (nominaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<NominaEN> ObtenerTodas (int first, int size)
{
        System.Collections.Generic.IList<NominaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(NominaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<NominaEN>();
                else
                        result = session.CreateCriteria (typeof(NominaEN)).List<NominaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public NominaEN ObtenerNomina (string id)
{
        NominaEN nominaEN = null;

        try
        {
                SessionInitializeTransaction ();
                nominaEN = (NominaEN)session.Get (typeof(NominaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return nominaEN;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> ObtenerTodasNominasTrabajador (string p_trabajador)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM NominaEN self where FROM NominaEN AS nom WHERE nom.Trabajador = :p_trabajador";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("NominaENobtenerTodasNominasTrabajadorHQL");
                query.SetParameter ("p_trabajador", p_trabajador);

                result = query.List<PalmeralGenNHibernate.EN.Default_.NominaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> BuscarPorParteFija (float p_parteFija)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM NominaEN self where FROM NominaEN AS nom WHERE nom.ParteFija = :p_parteFija";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("NominaENbuscarPorParteFijaHQL");
                query.SetParameter ("p_parteFija", p_parteFija);

                result = query.List<PalmeralGenNHibernate.EN.Default_.NominaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> BuscarPorAnyo (string p_anyo)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM NominaEN self where FROM NominaEN AS nom WHERE year(nom.Fecha) = :p_anyo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("NominaENbuscarPorAnyoHQL");
                query.SetParameter ("p_anyo", p_anyo);

                result = query.List<PalmeralGenNHibernate.EN.Default_.NominaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> BuscarPorMesAnyo (string p_mes, string p_anyo)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM NominaEN self where FROM NominaEN AS nom WHERE month(nom.Fecha) = :p_mes AND year(nom.Fecha) = :p_anyo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("NominaENbuscarPorMesAnyoHQL");
                query.SetParameter ("p_mes", p_mes);
                query.SetParameter ("p_anyo", p_anyo);

                result = query.List<PalmeralGenNHibernate.EN.Default_.NominaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in NominaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
