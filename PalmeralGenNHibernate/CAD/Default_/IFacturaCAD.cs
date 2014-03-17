
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface IFacturaCAD
{
FacturaEN ReadOIDDefault (string id);

string Crear (FacturaEN factura);

void Editar (FacturaEN factura);


void Eliminar (string id);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> ObtenerFacturasInstalacion (string p_instalacion);


FacturaEN ObtenerFactura (string id);


System.Collections.Generic.IList<FacturaEN> ObtenterTodas (int first, int size);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> ObtenerPorAnyo (string p_anyo);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> ObtenerPorMesAnyo (string p_mes, string p_anyo);
}
}
