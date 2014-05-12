
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
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (string nif)
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), nif);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}


public string Crear (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.Nif;
}

public void Editar (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Nif);

                usuarioEN.User = usuario.User;


                usuarioEN.Password = usuario.Password;


                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Apellidos = usuario.Apellidos;


                usuarioEN.Direccion = usuario.Direccion;


                usuarioEN.Telefono = usuario.Telefono;


                usuarioEN.CodigoPostal = usuario.CodigoPostal;


                usuarioEN.Pais = usuario.Pais;


                usuarioEN.Localidad = usuario.Localidad;


                usuarioEN.Provincia = usuario.Provincia;


                usuarioEN.Tipo = usuario.Tipo;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), nif);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public UsuarioEN ObtenerUsuario (string nif)
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), nif);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public PalmeralGenNHibernate.EN.Default_.UsuarioEN ObtenerPorUsuario (string p_user)
{
        PalmeralGenNHibernate.EN.Default_.UsuarioEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where FROM UsuarioEN AS us where us.User = :p_user";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENobtenerPorUsuarioHQL");
                query.SetParameter ("p_user", p_user);


                result = query.UniqueResult<PalmeralGenNHibernate.EN.Default_.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Relationer_jornadas (string p_usuario, System.Collections.Generic.IList<int> p_jornadafecha)
{
        PalmeralGenNHibernate.EN.Default_.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_usuario);
                PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadasENAux = null;
                if (usuarioEN.Jornadas == null) {
                        usuarioEN.Jornadas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN>();
                }

                foreach (int item in p_jornadafecha) {
                        jornadasENAux = new PalmeralGenNHibernate.EN.Default_.JornadaFechaEN ();
                        jornadasENAux = (PalmeralGenNHibernate.EN.Default_.JornadaFechaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.JornadaFechaEN), item);
                        jornadasENAux.Trabajadores.Add (usuarioEN);

                        usuarioEN.Jornadas.Add (jornadasENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Relationer_nominas (string p_usuario, System.Collections.Generic.IList<string> p_nomina)
{
        PalmeralGenNHibernate.EN.Default_.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_usuario);
                PalmeralGenNHibernate.EN.Default_.NominaEN nominasENAux = null;
                if (usuarioEN.Nominas == null) {
                        usuarioEN.Nominas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.NominaEN>();
                }

                foreach (string item in p_nomina) {
                        nominasENAux = new PalmeralGenNHibernate.EN.Default_.NominaEN ();
                        nominasENAux = (PalmeralGenNHibernate.EN.Default_.NominaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.NominaEN), item);
                        nominasENAux.Trabajador = usuarioEN;

                        usuarioEN.Nominas.Add (nominasENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Unrelationer_jornadas (string p_usuario, System.Collections.Generic.IList<int> p_jornadafecha)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.UsuarioEN usuarioEN = null;
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_usuario);

                PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadasENAux = null;
                if (usuarioEN.Jornadas != null) {
                        foreach (int item in p_jornadafecha) {
                                jornadasENAux = (PalmeralGenNHibernate.EN.Default_.JornadaFechaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.JornadaFechaEN), item);
                                if (usuarioEN.Jornadas.Contains (jornadasENAux) == true) {
                                        usuarioEN.Jornadas.Remove (jornadasENAux);
                                        jornadasENAux.Trabajadores.Remove (usuarioEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_jornadafecha you are trying to unrelationer, doesn't exist in UsuarioEN");
                        }
                }

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Unrelationer_nominas (string p_usuario, System.Collections.Generic.IList<string> p_nomina)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.UsuarioEN usuarioEN = null;
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_usuario);

                PalmeralGenNHibernate.EN.Default_.NominaEN nominasENAux = null;
                if (usuarioEN.Nominas != null) {
                        foreach (string item in p_nomina) {
                                nominasENAux = (PalmeralGenNHibernate.EN.Default_.NominaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.NominaEN), item);
                                if (usuarioEN.Nominas.Contains (nominasENAux) == true) {
                                        usuarioEN.Nominas.Remove (nominasENAux);
                                        nominasENAux.Trabajador = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_nomina you are trying to unrelationer, doesn't exist in UsuarioEN");
                        }
                }

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
