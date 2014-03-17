
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
}
}
