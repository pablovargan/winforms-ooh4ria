

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using PalmeralGenNHibernate.EN.Default_;
using PalmeralGenNHibernate.CAD.Default_;

namespace PalmeralGenNHibernate.CEN.Default_
{
public partial class PedidoCEN
{
private IPedidoCAD _IPedidoCAD;

public PedidoCEN()
{
        this._IPedidoCAD = new PedidoCAD ();
}

public PedidoCEN(IPedidoCAD _IPedidoCAD)
{
        this._IPedidoCAD = _IPedidoCAD;
}

public IPedidoCAD get_IPedidoCAD ()
{
        return this._IPedidoCAD;
}

public string Crear (string p_id, Nullable<DateTime> p_fecha, PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum p_estado, PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum p_tipoPago, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> p_lineas, string p_proveedor)
{
        PedidoEN pedidoEN = null;
        string oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_id;

        pedidoEN.Fecha = p_fecha;

        pedidoEN.Estado = p_estado;

        pedidoEN.TipoPago = p_tipoPago;

        pedidoEN.Lineas = p_lineas;


        if (p_proveedor != null) {
                pedidoEN.Proveedor = new PalmeralGenNHibernate.EN.Default_.ProveedorEN ();
                pedidoEN.Proveedor.Id = p_proveedor;
        }

        //Call to PedidoCAD

        oid = _IPedidoCAD.Crear (pedidoEN);
        return oid;
}

public string New_ (string p_id, Nullable<DateTime> p_fecha, PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum p_estado, PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum p_tipoPago, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> p_lineas, string p_proveedor)
{
        PedidoEN pedidoEN = null;
        string oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_id;

        pedidoEN.Fecha = p_fecha;

        pedidoEN.Estado = p_estado;

        pedidoEN.TipoPago = p_tipoPago;

        pedidoEN.Lineas = p_lineas;


        if (p_proveedor != null) {
                pedidoEN.Proveedor = new PalmeralGenNHibernate.EN.Default_.ProveedorEN ();
                pedidoEN.Proveedor.Id = p_proveedor;
        }

        //Call to PedidoCAD

        oid = _IPedidoCAD.New_ (pedidoEN);
        return oid;
}

public void Editar (string p_oid, Nullable<DateTime> p_fecha, PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum p_estado, PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum p_tipoPago)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_oid;
        pedidoEN.Fecha = p_fecha;
        pedidoEN.Estado = p_estado;
        pedidoEN.TipoPago = p_tipoPago;
        //Call to PedidoCAD

        _IPedidoCAD.Editar (pedidoEN);
}

public void Eliminar (string id)
{
        _IPedidoCAD.Eliminar (id);
}

public System.Collections.Generic.IList<PedidoEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> list = null;

        list = _IPedidoCAD.ObtenerTodos (first, size);
        return list;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPedidoPorAnyo (string p_anyo)
{
        return _IPedidoCAD.BuscarPedidoPorAnyo (p_anyo);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPedidoPorMesAnyo (string p_mes, string p_anyo)
{
        return _IPedidoCAD.BuscarPedidoPorMesAnyo (p_mes, p_anyo);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPedidoPorProveedor (string p_proveedor)
{
        return _IPedidoCAD.BuscarPedidoPorProveedor (p_proveedor);
}
public PedidoEN ObtenerPedido (string id)
{
        PedidoEN pedidoEN = null;

        pedidoEN = _IPedidoCAD.ObtenerPedido (id);
        return pedidoEN;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPorEstado (string p_estado)
{
        return _IPedidoCAD.BuscarPorEstado (p_estado);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPorTipoPago (string p_tipoPago)
{
        return _IPedidoCAD.BuscarPorTipoPago (p_tipoPago);
}
public void Relationer_lineas (string p_pedido, System.Collections.Generic.IList<int> p_lineapedido)
{
        //Call to PedidoCAD

        _IPedidoCAD.Relationer_lineas (p_pedido, p_lineapedido);
}
public void Relationer_proveedor (string p_pedido, string p_proveedor)
{
        //Call to PedidoCAD

        _IPedidoCAD.Relationer_proveedor (p_pedido, p_proveedor);
}
public void Unrelationer_lineas (string p_pedido, System.Collections.Generic.IList<int> p_lineapedido)
{
        //Call to PedidoCAD

        _IPedidoCAD.Unrelationer_lineas (p_pedido, p_lineapedido);
}
public void Unrelationer_proveedor (string p_pedido, string p_proveedor)
{
        //Call to PedidoCAD

        _IPedidoCAD.Unrelationer_proveedor (p_pedido, p_proveedor);
}
}
}
