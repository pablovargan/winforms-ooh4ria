

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using PalmeralGenNHibernate.EN.Default_;
using PalmeralGenNHibernate.CAD.Default_;

namespace PalmeralGenNHibernate.CEN.Default_
{
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string Crear (string p_user, String p_password, string p_nif, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_codigoPostal, string p_pais, string p_localidad, string p_provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum p_tipo)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.User = p_user;

        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_password);

        usuarioEN.Nif = p_nif;

        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Direccion = p_direccion;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.CodigoPostal = p_codigoPostal;

        usuarioEN.Pais = p_pais;

        usuarioEN.Localidad = p_localidad;

        usuarioEN.Provincia = p_provincia;

        usuarioEN.Tipo = p_tipo;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.Crear (usuarioEN);
        return oid;
}

public void Editar (string p_oid, string p_user, String p_password, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_codigoPostal, string p_pais, string p_localidad, string p_provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum p_tipo)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nif = p_oid;
        usuarioEN.User = p_user;
        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_password);
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Direccion = p_direccion;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.CodigoPostal = p_codigoPostal;
        usuarioEN.Pais = p_pais;
        usuarioEN.Localidad = p_localidad;
        usuarioEN.Provincia = p_provincia;
        usuarioEN.Tipo = p_tipo;
        //Call to UsuarioCAD

        _IUsuarioCAD.Editar (usuarioEN);
}

public void Eliminar (string nif)
{
        _IUsuarioCAD.Eliminar (nif);
}

public UsuarioEN ObtenerUsuario (string nif)
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.ObtenerUsuario (nif);
        return usuarioEN;
}
}
}
