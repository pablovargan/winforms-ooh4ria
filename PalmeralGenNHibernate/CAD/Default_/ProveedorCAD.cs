
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
public partial class ProveedorCAD : BasicCAD, IProveedorCAD
{
public ProveedorCAD() : base ()
{
}

public ProveedorCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProveedorEN ReadOIDDefault (string id)
{
        ProveedorEN proveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                proveedorEN = (ProveedorEN)session.Get (typeof(ProveedorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return proveedorEN;
}


public string Crear (ProveedorEN proveedor)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (proveedor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return proveedor.Id;
}

public void Editar (ProveedorEN proveedor)
{
        try
        {
                SessionInitializeTransaction ();
                ProveedorEN proveedorEN = (ProveedorEN)session.Load (typeof(ProveedorEN), proveedor.Id);

                proveedorEN.Nombre = proveedor.Nombre;


                proveedorEN.Telefono = proveedor.Telefono;


                proveedorEN.Direccion = proveedor.Direccion;


                proveedorEN.Localidad = proveedor.Localidad;


                proveedorEN.Provincia = proveedor.Provincia;


                proveedorEN.CodigoPostal = proveedor.CodigoPostal;


                proveedorEN.Email = proveedor.Email;


                proveedorEN.Pais = proveedor.Pais;


                proveedorEN.Descripcion = proveedor.Descripcion;

                session.Update (proveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
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
                ProveedorEN proveedorEN = (ProveedorEN)session.Load (typeof(ProveedorEN), id);
                session.Delete (proveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ProveedorEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<ProveedorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProveedorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProveedorEN>();
                else
                        result = session.CreateCriteria (typeof(ProveedorEN)).List<ProveedorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public ProveedorEN ObtenerProveedor (string id)
{
        ProveedorEN proveedorEN = null;

        try
        {
                SessionInitializeTransaction ();
                proveedorEN = (ProveedorEN)session.Get (typeof(ProveedorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return proveedorEN;
}

public void Relationer_pedido (string p_proveedor, System.Collections.Generic.IList<string> p_pedido)
{
        PalmeralGenNHibernate.EN.Default_.ProveedorEN proveedorEN = null;
        try
        {
                SessionInitializeTransaction ();
                proveedorEN = (ProveedorEN)session.Load (typeof(ProveedorEN), p_proveedor);
                PalmeralGenNHibernate.EN.Default_.PedidoEN pedidoENAux = null;
                if (proveedorEN.Pedido == null) {
                        proveedorEN.Pedido = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.PedidoEN>();
                }

                foreach (string item in p_pedido) {
                        pedidoENAux = new PalmeralGenNHibernate.EN.Default_.PedidoEN ();
                        pedidoENAux = (PalmeralGenNHibernate.EN.Default_.PedidoEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.PedidoEN), item);
                        pedidoENAux.Proveedor = proveedorEN;

                        proveedorEN.Pedido.Add (pedidoENAux);
                }


                session.Update (proveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Unrelationer_pedido (string p_proveedor, System.Collections.Generic.IList<string> p_pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.ProveedorEN proveedorEN = null;
                proveedorEN = (ProveedorEN)session.Load (typeof(ProveedorEN), p_proveedor);

                PalmeralGenNHibernate.EN.Default_.PedidoEN pedidoENAux = null;
                if (proveedorEN.Pedido != null) {
                        foreach (string item in p_pedido) {
                                pedidoENAux = (PalmeralGenNHibernate.EN.Default_.PedidoEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.PedidoEN), item);
                                if (proveedorEN.Pedido.Contains (pedidoENAux) == true) {
                                        proveedorEN.Pedido.Remove (pedidoENAux);
                                        pedidoENAux.Proveedor = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_pedido you are trying to unrelationer, doesn't exist in ProveedorEN");
                        }
                }

                session.Update (proveedorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProveedorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
