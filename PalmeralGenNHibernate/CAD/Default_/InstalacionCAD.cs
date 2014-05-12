
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
public partial class InstalacionCAD : BasicCAD, IInstalacionCAD
{
public InstalacionCAD() : base ()
{
}

public InstalacionCAD(ISession sessionAux) : base (sessionAux)
{
}



public InstalacionEN ReadOIDDefault (string id)
{
        InstalacionEN instalacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                instalacionEN = (InstalacionEN)session.Get (typeof(InstalacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return instalacionEN;
}


public string Crear (InstalacionEN instalacion)
{
        try
        {
                SessionInitializeTransaction ();
                if (instalacion.Cliente != null) {
                        instalacion.Cliente = (PalmeralGenNHibernate.EN.Default_.ClienteEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.ClienteEN), instalacion.Cliente.Nif);

                        instalacion.Cliente.Instalaciones.Add (instalacion);
                }

                session.Save (instalacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return instalacion.Id;
}

public void Editar (InstalacionEN instalacion)
{
        try
        {
                SessionInitializeTransaction ();
                InstalacionEN instalacionEN = (InstalacionEN)session.Load (typeof(InstalacionEN), instalacion.Id);

                instalacionEN.Nombre = instalacion.Nombre;


                instalacionEN.Descripcion = instalacion.Descripcion;


                instalacionEN.Localidad = instalacion.Localidad;


                instalacionEN.Provincia = instalacion.Provincia;


                instalacionEN.Pais = instalacion.Pais;


                instalacionEN.Direccion = instalacion.Direccion;


                instalacionEN.CodigoPostal = instalacion.CodigoPostal;


                instalacionEN.Telefono = instalacion.Telefono;


                instalacionEN.MetrosCuadrados = instalacion.MetrosCuadrados;

                session.Update (instalacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
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
                InstalacionEN instalacionEN = (InstalacionEN)session.Load (typeof(InstalacionEN), id);
                session.Delete (instalacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.InstalacionEN> BuscarInstalacionesCliente (string p_cliente)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.InstalacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM InstalacionEN self where FROM InstalacionEN AS ins WHERE ins.Cliente LIKE CONCAT('%', :p_cliente , '%')";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("InstalacionENbuscarInstalacionesClienteHQL");
                query.SetParameter ("p_cliente", p_cliente);

                result = query.List<PalmeralGenNHibernate.EN.Default_.InstalacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public InstalacionEN ObtenerInstalacion (string id)
{
        InstalacionEN instalacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                instalacionEN = (InstalacionEN)session.Get (typeof(InstalacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return instalacionEN;
}

public System.Collections.Generic.IList<InstalacionEN> ObtenerTodas (int first, int size)
{
        System.Collections.Generic.IList<InstalacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(InstalacionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<InstalacionEN>();
                else
                        result = session.CreateCriteria (typeof(InstalacionEN)).List<InstalacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void Relationer_cliente (string p_instalacion, string p_cliente)
{
        PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacionEN = null;
        try
        {
                SessionInitializeTransaction ();
                instalacionEN = (InstalacionEN)session.Load (typeof(InstalacionEN), p_instalacion);
                instalacionEN.Cliente = (PalmeralGenNHibernate.EN.Default_.ClienteEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.ClienteEN), p_cliente);

                instalacionEN.Cliente.Instalaciones.Add (instalacionEN);



                session.Update (instalacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Relationer_facturas (string p_instalacion, System.Collections.Generic.IList<string> p_factura)
{
        PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacionEN = null;
        try
        {
                SessionInitializeTransaction ();
                instalacionEN = (InstalacionEN)session.Load (typeof(InstalacionEN), p_instalacion);
                PalmeralGenNHibernate.EN.Default_.FacturaEN facturasENAux = null;
                if (instalacionEN.Facturas == null) {
                        instalacionEN.Facturas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.FacturaEN>();
                }

                foreach (string item in p_factura) {
                        facturasENAux = new PalmeralGenNHibernate.EN.Default_.FacturaEN ();
                        facturasENAux = (PalmeralGenNHibernate.EN.Default_.FacturaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.FacturaEN), item);
                        facturasENAux.Instalacion = instalacionEN;

                        instalacionEN.Facturas.Add (facturasENAux);
                }


                session.Update (instalacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Relationer_jornadas (string p_instalacion, System.Collections.Generic.IList<int> p_jornadafecha)
{
        PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacionEN = null;
        try
        {
                SessionInitializeTransaction ();
                instalacionEN = (InstalacionEN)session.Load (typeof(InstalacionEN), p_instalacion);
                PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadasENAux = null;
                if (instalacionEN.Jornadas == null) {
                        instalacionEN.Jornadas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN>();
                }

                foreach (int item in p_jornadafecha) {
                        jornadasENAux = new PalmeralGenNHibernate.EN.Default_.JornadaFechaEN ();
                        jornadasENAux = (PalmeralGenNHibernate.EN.Default_.JornadaFechaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.JornadaFechaEN), item);
                        jornadasENAux.Instalacion = instalacionEN;

                        instalacionEN.Jornadas.Add (jornadasENAux);
                }


                session.Update (instalacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Unrelationer_cliente (string p_instalacion, string p_cliente)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacionEN = null;
                instalacionEN = (InstalacionEN)session.Load (typeof(InstalacionEN), p_instalacion);

                if (instalacionEN.Cliente.Nif == p_cliente) {
                        instalacionEN.Cliente = null;
                }
                else
                        throw new ModelException ("The identifier " + p_cliente + " in p_cliente you are trying to unrelationer, doesn't exist in InstalacionEN");

                session.Update (instalacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Unrelationer_facturas (string p_instalacion, System.Collections.Generic.IList<string> p_factura)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacionEN = null;
                instalacionEN = (InstalacionEN)session.Load (typeof(InstalacionEN), p_instalacion);

                PalmeralGenNHibernate.EN.Default_.FacturaEN facturasENAux = null;
                if (instalacionEN.Facturas != null) {
                        foreach (string item in p_factura) {
                                facturasENAux = (PalmeralGenNHibernate.EN.Default_.FacturaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.FacturaEN), item);
                                if (instalacionEN.Facturas.Contains (facturasENAux) == true) {
                                        instalacionEN.Facturas.Remove (facturasENAux);
                                        facturasENAux.Instalacion = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_factura you are trying to unrelationer, doesn't exist in InstalacionEN");
                        }
                }

                session.Update (instalacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Unrelationer_jornadas (string p_instalacion, System.Collections.Generic.IList<int> p_jornadafecha)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacionEN = null;
                instalacionEN = (InstalacionEN)session.Load (typeof(InstalacionEN), p_instalacion);

                PalmeralGenNHibernate.EN.Default_.JornadaFechaEN jornadasENAux = null;
                if (instalacionEN.Jornadas != null) {
                        foreach (int item in p_jornadafecha) {
                                jornadasENAux = (PalmeralGenNHibernate.EN.Default_.JornadaFechaEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.JornadaFechaEN), item);
                                if (instalacionEN.Jornadas.Contains (jornadasENAux) == true) {
                                        instalacionEN.Jornadas.Remove (jornadasENAux);
                                        jornadasENAux.Instalacion = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_jornadafecha you are trying to unrelationer, doesn't exist in InstalacionEN");
                        }
                }

                session.Update (instalacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in InstalacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
