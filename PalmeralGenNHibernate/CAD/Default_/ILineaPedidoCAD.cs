
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int id);

int Crear (LineaPedidoEN lineaPedido);

void Editar (LineaPedidoEN lineaPedido);


void Eliminar (int id);


LineaPedidoEN ObtenerLinea (int id);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> ObtenerLineasDePedido (string p_pedido);


void Relationer_pedido (int p_lineapedido, string p_pedido);

void Relationer_productos (int p_lineapedido, string p_producto);

void Unrelationer_pedido (int p_lineapedido, string p_pedido);

void Unrelationer_productos (int p_lineapedido, string p_producto);
}
}
