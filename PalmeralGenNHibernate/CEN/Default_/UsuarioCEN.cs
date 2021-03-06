

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

public string Crear (string p_usuario, string p_contrasenya, string p_nif, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_codigoPostal, string p_pais, string p_localidad, string p_provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum p_tipo)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Usuario = p_usuario;

        usuarioEN.Contrasenya = p_contrasenya;

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

public void Editar (string p_oid, string p_usuario, string p_contrasenya, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_codigoPostal, string p_pais, string p_localidad, string p_provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum p_tipo)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nif = p_oid;
        usuarioEN.Usuario = p_usuario;
        usuarioEN.Contrasenya = p_contrasenya;
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

public PalmeralGenNHibernate.EN.Default_.UsuarioEN ObtenerPorPass (string p_pass)
{
        return _IUsuarioCAD.ObtenerPorPass (p_pass);
}
public PalmeralGenNHibernate.EN.Default_.UsuarioEN ObtenerPorUsuario (string p_user)
{
        return _IUsuarioCAD.ObtenerPorUsuario (p_user);
}
public void Relationer_jornadas (string p_usuario, System.Collections.Generic.IList<int> p_jornadafecha)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.Relationer_jornadas (p_usuario, p_jornadafecha);
}
public void Relationer_nominas (string p_usuario, System.Collections.Generic.IList<string> p_nomina)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.Relationer_nominas (p_usuario, p_nomina);
}
public void Unrelationer_jornadas (string p_usuario, System.Collections.Generic.IList<int> p_jornadafecha)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.Unrelationer_jornadas (p_usuario, p_jornadafecha);
}
public void Unrelationer_nominas (string p_usuario, System.Collections.Generic.IList<string> p_nomina)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.Unrelationer_nominas (p_usuario, p_nomina);
}
}
}
