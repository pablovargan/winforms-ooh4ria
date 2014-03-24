
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface IPedidoCAD
{
PedidoEN ReadOIDDefault (string id);

string Crear (PedidoEN pedido);

string New_ (PedidoEN pedido);

void Editar (PedidoEN pedido);


void Eliminar (string id);


System.Collections.Generic.IList<PedidoEN> ObtenerTodos (int first, int size);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPedidoPorAnyo (string p_anyo);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPedidoPorMesAnyo (string p_mes, string p_anyo);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPedidoPorProveedor (string p_proveedor);


PedidoEN ObtenerPedido (string id);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPorEstado (string p_estado);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> BuscarPorTipoPago (string p_tipoPago);
}
}
