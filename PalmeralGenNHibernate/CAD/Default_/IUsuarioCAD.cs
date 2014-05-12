
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
}
}
