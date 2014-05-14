
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

public void Relationer_instalacion (int p_jornadafecha, string p_instalacion)
{
        PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadaFechaEN = null;
        try
        {
                SessionInitializeTransaction ();
                jornadaFechaEN = (JornadaFechaEN)session.Load (typeof(JornadaFechaEN), p_jornadafecha);
                jornadaFechaEN.Instalacion = (PalmeralGenNHibernate.EN.Default_.InstalacionEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.InstalacionEN), p_instalacion);

                jornadaFechaEN.Instalacion.Jornadas.Add (jornadaFechaEN);



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

public void Relationer_trabajadores (int p_jornadafecha, System.Collections.Generic.IList<string> p_trabajador)
{
        PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadaFechaEN = null;
        try
        {
                SessionInitializeTransaction ();
                jornadaFechaEN = (JornadaFechaEN)session.Load (typeof(JornadaFechaEN), p_jornadafecha);
                PalmeralGenNHibernate.EN.Default_.TrabajadorEN trabajadoresENAux = null;
                if (jornadaFechaEN.Trabajadores == null) {
                        jornadaFechaEN.Trabajadores = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.TrabajadorEN>();
                }

                foreach (string item in p_trabajador) {
                        trabajadoresENAux = new PalmeralGenNHibernate.EN.Default_.TrabajadorEN ();
                        trabajadoresENAux = (PalmeralGenNHibernate.EN.Default_.TrabajadorEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.TrabajadorEN), item);
                        trabajadoresENAux.Jornadas.Add (jornadaFechaEN);

                        jornadaFechaEN.Trabajadores.Add (trabajadoresENAux);
                }


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

public void Unrelationer_instalacion (int p_jornadafecha, string p_instalacion)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadaFechaEN = null;
                jornadaFechaEN = (JornadaFechaEN)session.Load (typeof(JornadaFechaEN), p_jornadafecha);

                if (jornadaFechaEN.Instalacion.Id == p_instalacion) {
                        jornadaFechaEN.Instalacion = null;
                }
                else
                        throw new ModelException ("The identifier " + p_instalacion + " in p_instalacion you are trying to unrelationer, doesn't exist in JornadaFechaEN");

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
public void Unrelationer_trabajadores (int p_jornadafecha, System.Collections.Generic.IList<string> p_trabajador)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadaFechaEN = null;
                jornadaFechaEN = (JornadaFechaEN)session.Load (typeof(JornadaFechaEN), p_jornadafecha);

                PalmeralGenNHibernate.EN.Default_.TrabajadorEN trabajadoresENAux = null;
                if (jornadaFechaEN.Trabajadores != null) {
                        foreach (string item in p_trabajador) {
                                trabajadoresENAux = (PalmeralGenNHibernate.EN.Default_.TrabajadorEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.TrabajadorEN), item);
                                if (jornadaFechaEN.Trabajadores.Contains (trabajadoresENAux) == true) {
                                        jornadaFechaEN.Trabajadores.Remove (trabajadoresENAux);
                                        trabajadoresENAux.Jornadas.Remove (jornadaFechaEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_trabajador you are trying to unrelationer, doesn't exist in JornadaFechaEN");
                        }
                }

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
}
}
