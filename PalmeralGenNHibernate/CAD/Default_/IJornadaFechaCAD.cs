
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


void Relationer_instalacion (int p_jornadafecha, string p_instalacion);

void Relationer_trabajadores (int p_jornadafecha, System.Collections.Generic.IList<string> p_trabajador);

void Unrelationer_instalacion (int p_jornadafecha, string p_instalacion);

void Unrelationer_trabajadores (int p_jornadafecha, System.Collections.Generic.IList<string> p_trabajador);
}
}
