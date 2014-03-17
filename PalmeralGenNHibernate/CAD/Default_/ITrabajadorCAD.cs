
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface ITrabajadorCAD
{
TrabajadorEN ReadOIDDefault (string nif);

string Crear (TrabajadorEN trabajador);

void Editar (TrabajadorEN trabajador);


void Eliminar (string nif);


System.Collections.Generic.IList<TrabajadorEN> ObtenerTodos (int first, int size);


TrabajadorEN ObtenerTrabajador (string nif);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorLocalidad (string p_localidad);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorProvincia (string p_provincia);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorTipo (PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum p_tipoEmpleo);
}
}
