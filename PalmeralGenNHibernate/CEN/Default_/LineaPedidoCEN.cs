

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
public partial class LineaPedidoCEN
{
private ILineaPedidoCAD _ILineaPedidoCAD;

public LineaPedidoCEN()
{
        this._ILineaPedidoCAD = new LineaPedidoCAD ();
}

public LineaPedidoCEN(ILineaPedidoCAD _ILineaPedidoCAD)
{
        this._ILineaPedidoCAD = _ILineaPedidoCAD;
}

public ILineaPedidoCAD get_ILineaPedidoCAD ()
{
        return this._ILineaPedidoCAD;
}

public int Crear (int p_cantidad, string p_pedido)
{
        LineaPedidoEN lineaPedidoEN = null;
        int oid;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Cantidad = p_cantidad;


        if (p_pedido != null) {
                lineaPedidoEN.Pedido = new PalmeralGenNHibernate.EN.Default_.PedidoEN ();
                lineaPedidoEN.Pedido.Id = p_pedido;
        }

        //Call to LineaPedidoCAD

        oid = _ILineaPedidoCAD.Crear (lineaPedidoEN);
        return oid;
}

public void Editar (int p_oid, int p_cantidad)
{
        LineaPedidoEN lineaPedidoEN = null;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Id = p_oid;
        lineaPedidoEN.Cantidad = p_cantidad;
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.Editar (lineaPedidoEN);
}

public void Eliminar (int id)
{
        _ILineaPedidoCAD.Eliminar (id);
}

public LineaPedidoEN ObtenerLinea (int id)
{
        LineaPedidoEN lineaPedidoEN = null;

        lineaPedidoEN = _ILineaPedidoCAD.ObtenerLinea (id);
        return lineaPedidoEN;
}

public System.Collections.Generic.IList<LineaPedidoEN> ObtenerTodasLineas (int first, int size)
{
        System.Collections.Generic.IList<LineaPedidoEN> list = null;

        list = _ILineaPedidoCAD.ObtenerTodasLineas (first, size);
        return list;
}
public void Relationer_pedido (int p_lineapedido, string p_pedido)
{
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.Relationer_pedido (p_lineapedido, p_pedido);
}
public void Relationer_productos (int p_lineapedido, string p_producto)
{
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.Relationer_productos (p_lineapedido, p_producto);
}
public void Unrelationer_pedido (int p_lineapedido, string p_pedido)
{
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.Unrelationer_pedido (p_lineapedido, p_pedido);
}
public void Unrelationer_productos (int p_lineapedido, string p_producto)
{
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.Unrelationer_productos (p_lineapedido, p_producto);
}
}
}
