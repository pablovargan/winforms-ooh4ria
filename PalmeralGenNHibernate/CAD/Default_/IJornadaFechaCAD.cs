
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface IJornadaFechaCAD
{
JornadaFechaEN ReadOIDDefault (int id);

int Crear (JornadaFechaEN jornadaFecha);

void Editar (JornadaFechaEN jornadaFecha);


void Eliminar (int id);


JornadaFechaEN ObtenerJornada (int id);


System.Collections.Generic.IList<JornadaFechaEN> ObtenerTodas (int first, int size);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> ReadFilter (Nullable<DateTime> p_fecha, string p_instalacion);
}
}
