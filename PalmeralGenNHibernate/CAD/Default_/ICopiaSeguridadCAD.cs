
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface ICopiaSeguridadCAD
{
CopiaSeguridadEN ReadOIDDefault (string id);

string Crear (CopiaSeguridadEN copiaSeguridad);

void Editar (CopiaSeguridadEN copiaSeguridad);


void Eliminar (string id);


System.Collections.Generic.IList<CopiaSeguridadEN> ObtenerTodas (int first, int size);


CopiaSeguridadEN ObtenerPorOID (string id);
}
}
