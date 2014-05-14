
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
public partial class ProductoCAD : BasicCAD, IProductoCAD
{
public ProductoCAD() : base ()
{
}

public ProductoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProductoEN ReadOIDDefault (string id)
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}


public string Crear (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (producto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return producto.Id;
}

public void Editar (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), producto.Id);

                productoEN.Nombre = producto.Nombre;


                productoEN.Descripcion = producto.Descripcion;


                productoEN.Stock = producto.Stock;


                productoEN.Foto = producto.Foto;

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
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
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), id);
                session.Delete (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ProductoEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProductoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProductoEN>();
                else
                        result = session.CreateCriteria (typeof(ProductoEN)).List<ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ProductoEN> BuscarPorNombre (string p_nombre)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where FROM ProductoEN AS prod WHERE prod.Nombre LIKE CONCAT('%', :p_nombre , '%')";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENbuscarPorNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<PalmeralGenNHibernate.EN.Default_.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ProductoEN> BuscarPorStock (int p_stock)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where FROM ProductoEN AS prod WHERE prod.Stock <= :p_stock";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENbuscarPorStockHQL");
                query.SetParameter ("p_stock", p_stock);

                result = query.List<PalmeralGenNHibernate.EN.Default_.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public ProductoEN ObtenerProducto (string id)
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}

public void Relationer_linea (string p_producto, System.Collections.Generic.IList<int> p_lineapedido)
{
        PalmeralGenNHibernate.EN.Default_.ProductoEN productoEN = null;
        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Load (typeof(ProductoEN), p_producto);
                PalmeralGenNHibernate.EN.Default_.LineaPedidoEN lineaENAux = null;
                if (productoEN.Linea == null) {
                        productoEN.Linea = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN>();
                }

                foreach (int item in p_lineapedido) {
                        lineaENAux = new PalmeralGenNHibernate.EN.Default_.LineaPedidoEN ();
                        lineaENAux = (PalmeralGenNHibernate.EN.Default_.LineaPedidoEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.LineaPedidoEN), item);
                        lineaENAux.Productos = productoEN;

                        productoEN.Linea.Add (lineaENAux);
                }


                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Unrelationer_linea (string p_producto, System.Collections.Generic.IList<int> p_lineapedido)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.ProductoEN productoEN = null;
                productoEN = (ProductoEN)session.Load (typeof(ProductoEN), p_producto);

                PalmeralGenNHibernate.EN.Default_.LineaPedidoEN lineaENAux = null;
                if (productoEN.Linea != null) {
                        foreach (int item in p_lineapedido) {
                                lineaENAux = (PalmeralGenNHibernate.EN.Default_.LineaPedidoEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.LineaPedidoEN), item);
                                if (productoEN.Linea.Contains (lineaENAux) == true) {
                                        productoEN.Linea.Remove (lineaENAux);
                                        lineaENAux.Productos = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_lineapedido you are trying to unrelationer, doesn't exist in ProductoEN");
                        }
                }

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
