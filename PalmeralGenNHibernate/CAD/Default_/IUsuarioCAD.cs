
using System;
using PalmeralGenNHibernate.EN.Default_;

namespace PalmeralGenNHibernate.CAD.Default_
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string nif);

string Crear (UsuarioEN usuario);

void Editar (UsuarioEN usuario);


void Eliminar (string nif);


UsuarioEN ObtenerUsuario (string nif);


PalmeralGenNHibernate.EN.Default_.UsuarioEN ObtenerPorUsuario (string p_user);


void Relationer_jornadas (string p_usuario, System.Collections.Generic.IList<int> p_jornadafecha);

void Relationer_nominas (string p_usuario, System.Collections.Generic.IList<string> p_nomina);

void Unrelationer_jornadas (string p_usuario, System.Collections.Generic.IList<int> p_jornadafecha);

void Unrelationer_nominas (string p_usuario, System.Collections.Generic.IList<string> p_nomina);
}
}
