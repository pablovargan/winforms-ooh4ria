
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
public partial class LineaPedidoCAD : BasicCAD, ILineaPedidoCAD
{
public LineaPedidoCAD() : base ()
{
}

public LineaPedidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public LineaPedidoEN ReadOIDDefault (int id)
{
        LineaPedidoEN lineaPedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaPedidoEN = (LineaPedidoEN)session.Get (typeof(LineaPedidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoEN;
}


public int Crear (LineaPedidoEN lineaPedido)
{
        try
        {
                SessionInitializeTransaction ();
                if (lineaPedido.Pedido != null) {
                        lineaPedido.Pedido = (PalmeralGenNHibernate.EN.Default_.PedidoEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.PedidoEN), lineaPedido.Pedido.Id);

                        lineaPedido.Pedido.Lineas.Add (lineaPedido);
                }

                session.Save (lineaPedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedido.Id;
}

public void Editar (LineaPedidoEN lineaPedido)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoEN lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), lineaPedido.Id);

                lineaPedidoEN.Cantidad = lineaPedido.Cantidad;

                session.Update (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
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
                LineaPedidoEN lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), id);
                session.Delete (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public LineaPedidoEN ObtenerLinea (int id)
{
        LineaPedidoEN lineaPedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaPedidoEN = (LineaPedidoEN)session.Get (typeof(LineaPedidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoEN;
}


public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> ObtenerLineasDePedido (string p_pedido)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LineaPedidoEN self where FROM LineaPedidoEN AS l WHERE l.Pedido LIKE CONCAT('%', :p_pedido , '%')";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LineaPedidoENobtenerLineasDePedidoHQL");
                query.SetParameter ("p_pedido", p_pedido);

                result = query.List<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void Relationer_pedido (int p_lineapedido, string p_pedido)
{
        PalmeralGenNHibernate.EN.Default_.LineaPedidoEN lineaPedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), p_lineapedido);
                lineaPedidoEN.Pedido = (PalmeralGenNHibernate.EN.Default_.PedidoEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.PedidoEN), p_pedido);

                lineaPedidoEN.Pedido.Lineas.Add (lineaPedidoEN);



                session.Update (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Relationer_productos (int p_lineapedido, string p_producto)
{
        PalmeralGenNHibernate.EN.Default_.LineaPedidoEN lineaPedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), p_lineapedido);
                lineaPedidoEN.Productos = (PalmeralGenNHibernate.EN.Default_.ProductoEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.ProductoEN), p_producto);

                lineaPedidoEN.Productos.Linea.Add (lineaPedidoEN);



                session.Update (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Unrelationer_pedido (int p_lineapedido, string p_pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.LineaPedidoEN lineaPedidoEN = null;
                lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), p_lineapedido);

                if (lineaPedidoEN.Pedido.Id == p_pedido) {
                        lineaPedidoEN.Pedido = null;
                }
                else
                        throw new ModelException ("The identifier " + p_pedido + " in p_pedido you are trying to unrelationer, doesn't exist in LineaPedidoEN");

                session.Update (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Unrelationer_productos (int p_lineapedido, string p_producto)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.LineaPedidoEN lineaPedidoEN = null;
                lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), p_lineapedido);

                if (lineaPedidoEN.Productos.Id == p_producto) {
                        lineaPedidoEN.Productos = null;
                }
                else
                        throw new ModelException ("The identifier " + p_producto + " in p_producto you are trying to unrelationer, doesn't exist in LineaPedidoEN");

                session.Update (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
