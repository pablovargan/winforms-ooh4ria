
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface INominaCAD
{
NominaEN ReadOIDDefault (string id);

string Crear (NominaEN nomina);

void Editar (NominaEN nomina);


void Eliminar (string id);


System.Collections.Generic.IList<NominaEN> ObtenerTodas (int first, int size);


NominaEN ObtenerNomina (string id);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> ObtenerTodasNominasTrabajador (string p_trabajador);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> BuscarPorParteFija (float p_parteFija);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> BuscarPorAnyo (string p_anyo);


System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> BuscarPorMesAnyo (string p_mes, string p_anyo);
}
}
