
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface IInstalacionCAD
{
InstalacionEN ReadOIDDefault (string id);

string Crear (InstalacionEN instalacion);

void Editar (InstalacionEN instalacion);


void Eliminar (string id);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.InstalacionEN> BuscarInstalacionesCliente (string p_cliente);


InstalacionEN ObtenerInstalacion (string id);


System.Collections.Generic.IList<InstalacionEN> ObtenerTodas (int first, int size);
}
}
