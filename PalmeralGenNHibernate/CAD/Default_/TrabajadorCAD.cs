
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
                //String sql = @"FROM TrabajadorEN self where FROM TrabajadorEN AS trab WHERE trab.Localidad LIKE CONCAT('%', :p_localidad , '%')";
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
                //String sql = @"FROM TrabajadorEN self where FROM TrabajadorEN AS trab WHERE trab.Provincia LIKE CONCAT('%', :p_provincia , '%')";
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
                //String sql = @"FROM TrabajadorEN self where FROM TrabajadorEN AS trab WHERE trab.Tipo LIKE CONCAT('%', :p_tipoEmpleo , '%')";
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
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorNombre (string p_nombre)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TrabajadorEN self where FROM TrabajadorEN AS trab WHERE trab.Nombre LIKE CONCAT('%', :p_nombre , '%')";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TrabajadorENbuscarPorNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

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
public void Relationer_jornadas (string p_trabajador, System.Collections.Generic.IList<int> p_jornadafecha)
{
        PalmeralGenNHibernate.EN.Default_.TrabajadorEN trabajadorEN = null;
        try
        {
                SessionInitializeTransaction ();
                trabajadorEN = (TrabajadorEN)session.Load (typeof(TrabajadorEN), p_trabajador);
                PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadasENAux = null;
                if (trabajadorEN.Jornadas == null) {
                        trabajadorEN.Jornadas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN>();
                }

                foreach (int item in p_jornadafecha) {
                        jornadasENAux = new PalmeralGenNHibernate.EN.Default_.JornadaFechaEN ();
                        jornadasENAux = (PalmeralGenNHibernate.EN.Default_.JornadaFechaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.JornadaFechaEN), item);
                        jornadasENAux.Trabajadores.Add (trabajadorEN);

                        trabajadorEN.Jornadas.Add (jornadasENAux);
                }


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

public void Relationer_nominas (string p_trabajador, System.Collections.Generic.IList<string> p_nomina)
{
        PalmeralGenNHibernate.EN.Default_.TrabajadorEN trabajadorEN = null;
        try
        {
                SessionInitializeTransaction ();
                trabajadorEN = (TrabajadorEN)session.Load (typeof(TrabajadorEN), p_trabajador);
                PalmeralGenNHibernate.EN.Default_.NominaEN nominasENAux = null;
                if (trabajadorEN.Nominas == null) {
                        trabajadorEN.Nominas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.NominaEN>();
                }

                foreach (string item in p_nomina) {
                        nominasENAux = new PalmeralGenNHibernate.EN.Default_.NominaEN ();
                        nominasENAux = (PalmeralGenNHibernate.EN.Default_.NominaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.NominaEN), item);
                        nominasENAux.Trabajador = trabajadorEN;

                        trabajadorEN.Nominas.Add (nominasENAux);
                }


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

public void Unrelationer_jornadas (string p_trabajador, System.Collections.Generic.IList<int> p_jornadafecha)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.TrabajadorEN trabajadorEN = null;
                trabajadorEN = (TrabajadorEN)session.Load (typeof(TrabajadorEN), p_trabajador);

                PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadasENAux = null;
                if (trabajadorEN.Jornadas != null) {
                        foreach (int item in p_jornadafecha) {
                                jornadasENAux = (PalmeralGenNHibernate.EN.Default_.JornadaFechaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.JornadaFechaEN), item);
                                if (trabajadorEN.Jornadas.Contains (jornadasENAux) == true) {
                                        trabajadorEN.Jornadas.Remove (jornadasENAux);
                                        jornadasENAux.Trabajadores.Remove (trabajadorEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_jornadafecha you are trying to unrelationer, doesn't exist in TrabajadorEN");
                        }
                }

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
public void Unrelationer_nominas (string p_trabajador, System.Collections.Generic.IList<string> p_nomina)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.TrabajadorEN trabajadorEN = null;
                trabajadorEN = (TrabajadorEN)session.Load (typeof(TrabajadorEN), p_trabajador);

                PalmeralGenNHibernate.EN.Default_.NominaEN nominasENAux = null;
                if (trabajadorEN.Nominas != null) {
                        foreach (string item in p_nomina) {
                                nominasENAux = (PalmeralGenNHibernate.EN.Default_.NominaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.NominaEN), item);
                                if (trabajadorEN.Nominas.Contains (nominasENAux) == true) {
                                        trabajadorEN.Nominas.Remove (nominasENAux);
                                        nominasENAux.Trabajador = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_nomina you are trying to unrelationer, doesn't exist in TrabajadorEN");
                        }
                }

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
}
}
