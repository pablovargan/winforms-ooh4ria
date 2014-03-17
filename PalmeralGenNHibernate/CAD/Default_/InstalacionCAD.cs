
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
                //String sql = @"FROM InstalacionEN self where FROM InstalacionEN AS ins WHERE ins.p_cliente = :p_cliente";
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
}
}
