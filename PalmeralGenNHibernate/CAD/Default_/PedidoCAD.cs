
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
public partial class PedidoCAD : BasicCAD, IPedidoCAD
{
public PedidoCAD() : base ()
{
}

public PedidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PedidoEN ReadOIDDefault (string id)
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}


public string Crear (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                if (pedido.Lineas != null) {
                        foreach (PalmeralGenNHibernate.EN.Default_.LineaPedidoEN item in pedido.Lineas) {
                                item.Pedido = pedido;
                                session.Save (item);
                        }
                }
                if (pedido.Proveedor != null) {
                        pedido.Proveedor = (PalmeralGenNHibernate.EN.Default_.ProveedorEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.ProveedorEN), pedido.Proveedor.Id);

                        pedido.Proveedor.Pedido.Add (pedido);
                }

                session.Save (pedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedido.Id;
}

public string New_ (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                if (pedido.Lineas != null) {
                        foreach (PalmeralGenNHibernate.EN.Default_.LineaPedidoEN item in pedido.Lineas) {
                                item.Pedido = pedido;
                                session.Save (item);
                        }
                }
                if (pedido.Proveedor != null) {
                        pedido.Proveedor = (PalmeralGenNHibernate.EN.Default_.ProveedorEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.ProveedorEN), pedido.Proveedor.Id);

                        pedido.Proveedor.Pedido.Add (pedido);
                }

                session.Save (pedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedido.Id;
}

public void Editar (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), pedido.Id);

                pedidoEN.Fecha = pedido.Fecha;


                pedidoEN.Estado = pedido.Estado;


                pedidoEN.TipoPago = pedido.TipoPago;

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), id);
                session.Delete (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<PedidoEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PedidoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PedidoEN>();
                else
                        result = session.CreateCriteria (typeof(PedidoEN)).List<PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPedidoPorAnyo (string p_anyo)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoEN self where FROM PedidoEN AS ped WHERE year(ped.Fecha) LIKE CONTAT('%', :p_anyo , '%')";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoENbuscarPedidoPorAnyoHQL");
                query.SetParameter ("p_anyo", p_anyo);

                result = query.List<PalmeralGenNHibernate.EN.Default_.PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPedidoPorMesAnyo (string p_mes, string p_anyo)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoEN self where FROM PedidoEN AS ped WHERE month(ped.Fecha) LIKE CONTAT('%', :p_mes, '%') AND year(ped.Fecha) LIKE CONTAT('%', :p_anyo, '%')";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoENbuscarPedidoPorMesAnyoHQL");
                query.SetParameter ("p_mes", p_mes);
                query.SetParameter ("p_anyo", p_anyo);

                result = query.List<PalmeralGenNHibernate.EN.Default_.PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPedidoPorProveedor (string p_proveedor)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoEN self where FROM PedidoEN AS ped WHERE ped.Proveedor = :p_proveedor";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoENbuscarPedidoPorProveedorHQL");
                query.SetParameter ("p_proveedor", p_proveedor);

                result = query.List<PalmeralGenNHibernate.EN.Default_.PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public PedidoEN ObtenerPedido (string id)
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPorEstado (string p_estado)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoEN self where FROM PedidoEN AS ped WHERE ped.Estado = :p_estado";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoENbuscarPorEstadoHQL");
                query.SetParameter ("p_estado", p_estado);

                result = query.List<PalmeralGenNHibernate.EN.Default_.PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPorTipoPago (string p_tipoPago)
{
        System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoEN self where FROM PedidoEN AS ped WHERE ped.TipoPago  = :p_tipoPago";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoENbuscarPorTipoPagoHQL");
                query.SetParameter ("p_tipoPago", p_tipoPago);

                result = query.List<PalmeralGenNHibernate.EN.Default_.PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Relationer_lineas (string p_pedido, System.Collections.Generic.IList<int> p_lineapedido)
{
        PalmeralGenNHibernate.EN.Default_.PedidoEN pedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_pedido);
                PalmeralGenNHibernate.EN.Default_.LineaPedidoEN lineasENAux = null;
                if (pedidoEN.Lineas == null) {
                        pedidoEN.Lineas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN>();
                }

                foreach (int item in p_lineapedido) {
                        lineasENAux = new PalmeralGenNHibernate.EN.Default_.LineaPedidoEN ();
                        lineasENAux = (PalmeralGenNHibernate.EN.Default_.LineaPedidoEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.LineaPedidoEN), item);
                        lineasENAux.Pedido = pedidoEN;

                        pedidoEN.Lineas.Add (lineasENAux);
                }


                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Relationer_proveedor (string p_pedido, string p_proveedor)
{
        PalmeralGenNHibernate.EN.Default_.PedidoEN pedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_pedido);
                pedidoEN.Proveedor = (PalmeralGenNHibernate.EN.Default_.ProveedorEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.ProveedorEN), p_proveedor);

                pedidoEN.Proveedor.Pedido.Add (pedidoEN);



                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Unrelationer_lineas (string p_pedido, System.Collections.Generic.IList<int> p_lineapedido)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.PedidoEN pedidoEN = null;
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_pedido);

                PalmeralGenNHibernate.EN.Default_.LineaPedidoEN lineasENAux = null;
                if (pedidoEN.Lineas != null) {
                        foreach (int item in p_lineapedido) {
                                lineasENAux = (PalmeralGenNHibernate.EN.Default_.LineaPedidoEN)session.Load (typeof(PalmeralGenNHibernate.EN.Default_.LineaPedidoEN), item);
                                if (pedidoEN.Lineas.Contains (lineasENAux) == true) {
                                        pedidoEN.Lineas.Remove (lineasENAux);
                                        lineasENAux.Pedido = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_lineapedido you are trying to unrelationer, doesn't exist in PedidoEN");
                        }
                }

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Unrelationer_proveedor (string p_pedido, string p_proveedor)
{
        try
        {
                SessionInitializeTransaction ();
                PalmeralGenNHibernate.EN.Default_.PedidoEN pedidoEN = null;
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_pedido);

                if (pedidoEN.Proveedor.Id == p_proveedor) {
                        pedidoEN.Proveedor = null;
                }
                else
                        throw new ModelException ("The identifier " + p_proveedor + " in p_proveedor you are trying to unrelationer, doesn't exist in PedidoEN");

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is PalmeralGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new PalmeralGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
