
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


void Relationer_cliente (string p_instalacion, string p_cliente);

void Relationer_facturas (string p_instalacion, System.Collections.Generic.IList<string> p_factura);

void Relationer_jornadas (string p_instalacion, System.Collections.Generic.IList<int> p_jornadafecha);

void Unrelationer_cliente (string p_instalacion, string p_cliente);

void Unrelationer_facturas (string p_instalacion, System.Collections.Generic.IList<string> p_factura);

void Unrelationer_jornadas (string p_instalacion, System.Collections.Generic.IList<int> p_jornadafecha);
}
}
