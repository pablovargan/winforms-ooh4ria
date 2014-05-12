
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface IProveedorCAD
{
ProveedorEN ReadOIDDefault (string id);

string Crear (ProveedorEN proveedor);

void Editar (ProveedorEN proveedor);


void Eliminar (string id);


System.Collections.Generic.IList<ProveedorEN> ObtenerTodos (int first, int size);


ProveedorEN ObtenerProveedor (string id);


void Relationer_pedido (string p_proveedor, System.Collections.Generic.IList<string> p_pedido);

void Unrelationer_pedido (string p_proveedor, System.Collections.Generic.IList<string> p_pedido);
}
}
