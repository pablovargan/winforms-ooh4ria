

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
public partial class TrabajadorCEN
{
private ITrabajadorCAD _ITrabajadorCAD;

public TrabajadorCEN()
{
        this._ITrabajadorCAD = new TrabajadorCAD ();
}

public TrabajadorCEN(ITrabajadorCAD _ITrabajadorCAD)
{
        this._ITrabajadorCAD = _ITrabajadorCAD;
}

public ITrabajadorCAD get_ITrabajadorCAD ()
{
        return this._ITrabajadorCAD;
}

public string Crear (string p_nif, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_codigoPostal, string p_pais, string p_localidad, string p_provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum p_tipo)
{
        TrabajadorEN trabajadorEN = null;
        string oid;

        //Initialized TrabajadorEN
        trabajadorEN = new TrabajadorEN ();
        trabajadorEN.Nif = p_nif;

        trabajadorEN.Nombre = p_nombre;

        trabajadorEN.Apellidos = p_apellidos;

        trabajadorEN.Direccion = p_direccion;

        trabajadorEN.Telefono = p_telefono;

        trabajadorEN.CodigoPostal = p_codigoPostal;

        trabajadorEN.Pais = p_pais;

        trabajadorEN.Localidad = p_localidad;

        trabajadorEN.Provincia = p_provincia;

        trabajadorEN.Tipo = p_tipo;

        //Call to TrabajadorCAD

        oid = _ITrabajadorCAD.Crear (trabajadorEN);
        return oid;
}

public void Editar (string p_oid, string p_nombre, string p_apellidos, string p_direccion, string p_telefono, string p_codigoPostal, string p_pais, string p_localidad, string p_provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum p_tipo)
{
        TrabajadorEN trabajadorEN = null;

        //Initialized TrabajadorEN
        trabajadorEN = new TrabajadorEN ();
        trabajadorEN.Nif = p_oid;
        trabajadorEN.Nombre = p_nombre;
        trabajadorEN.Apellidos = p_apellidos;
        trabajadorEN.Direccion = p_direccion;
        trabajadorEN.Telefono = p_telefono;
        trabajadorEN.CodigoPostal = p_codigoPostal;
        trabajadorEN.Pais = p_pais;
        trabajadorEN.Localidad = p_localidad;
        trabajadorEN.Provincia = p_provincia;
        trabajadorEN.Tipo = p_tipo;
        //Call to TrabajadorCAD

        _ITrabajadorCAD.Editar (trabajadorEN);
}

public void Eliminar (string nif)
{
        _ITrabajadorCAD.Eliminar (nif);
}

public System.Collections.Generic.IList<TrabajadorEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<TrabajadorEN> list = null;

        list = _ITrabajadorCAD.ObtenerTodos (first, size);
        return list;
}
public TrabajadorEN ObtenerTrabajador (string nif)
{
        TrabajadorEN trabajadorEN = null;

        trabajadorEN = _ITrabajadorCAD.ObtenerTrabajador (nif);
        return trabajadorEN;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorLocalidad (string p_localidad)
{
        return _ITrabajadorCAD.BuscarPorLocalidad (p_localidad);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorProvincia (string p_provincia)
{
        return _ITrabajadorCAD.BuscarPorProvincia (p_provincia);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorTipo (PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum p_tipoEmpleo)
{
        return _ITrabajadorCAD.BuscarPorTipo (p_tipoEmpleo);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> BuscarPorNombre (string p_nombre)
{
        return _ITrabajadorCAD.BuscarPorNombre (p_nombre);
}
public void AddInstalacion (string p_trabajador, System.Collections.Generic.IList<string> p_instalacion)
{
        //Call to TrabajadorCAD

        _ITrabajadorCAD.AddInstalacion (p_trabajador, p_instalacion);
}
public void DeleteInstalacion (string p_trabajador, System.Collections.Generic.IList<string> p_instalacion)
{
        //Call to TrabajadorCAD

        _ITrabajadorCAD.DeleteInstalacion (p_trabajador, p_instalacion);
}
}
}
