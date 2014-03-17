
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (string id);

string Crear (ProductoEN producto);

void Editar (ProductoEN producto);


void Eliminar (string id);


System.Collections.Generic.IList<ProductoEN> ObtenerTodos (int first, int size);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ProductoEN> BuscarPorNombre (string p_nombre);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ProductoEN> BuscarPorStock (int p_stock);


ProductoEN ObtenerProducto (string id);
}
}
