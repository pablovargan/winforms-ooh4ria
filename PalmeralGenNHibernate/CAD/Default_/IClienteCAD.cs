
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string nif);

string Crear (ClienteEN cliente);

void Editar (ClienteEN cliente);


void Eliminar (string nif);


System.Collections.Generic.IList<ClienteEN> ObtenerTodos (int first, int size);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ClienteEN> BuscarPorNombre (string p_nombre);


ClienteEN ObtenerCliente (string nif);
}
}
