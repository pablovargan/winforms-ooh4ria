

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
public partial class ProveedorCEN
{
private IProveedorCAD _IProveedorCAD;

public ProveedorCEN()
{
        this._IProveedorCAD = new ProveedorCAD ();
}

public ProveedorCEN(IProveedorCAD _IProveedorCAD)
{
        this._IProveedorCAD = _IProveedorCAD;
}

public IProveedorCAD get_IProveedorCAD ()
{
        return this._IProveedorCAD;
}

public string Crear (string p_id, string p_nombre, string p_telefono, string p_direccion, string p_localidad, string p_provincia, string p_codigoPostal, string p_email, string p_pais, string p_descripcion)
{
        ProveedorEN proveedorEN = null;
        string oid;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Id = p_id;

        proveedorEN.Nombre = p_nombre;

        proveedorEN.Telefono = p_telefono;

        proveedorEN.Direccion = p_direccion;

        proveedorEN.Localidad = p_localidad;

        proveedorEN.Provincia = p_provincia;

        proveedorEN.CodigoPostal = p_codigoPostal;

        proveedorEN.Email = p_email;

        proveedorEN.Pais = p_pais;

        proveedorEN.Descripcion = p_descripcion;

        //Call to ProveedorCAD

        oid = _IProveedorCAD.Crear (proveedorEN);
        return oid;
}

public void Editar (string p_oid, string p_nombre, string p_telefono, string p_direccion, string p_localidad, string p_provincia, string p_codigoPostal, string p_email, string p_pais, string p_descripcion)
{
        ProveedorEN proveedorEN = null;

        //Initialized ProveedorEN
        proveedorEN = new ProveedorEN ();
        proveedorEN.Id = p_oid;
        proveedorEN.Nombre = p_nombre;
        proveedorEN.Telefono = p_telefono;
        proveedorEN.Direccion = p_direccion;
        proveedorEN.Localidad = p_localidad;
        proveedorEN.Provincia = p_provincia;
        proveedorEN.CodigoPostal = p_codigoPostal;
        proveedorEN.Email = p_email;
        proveedorEN.Pais = p_pais;
        proveedorEN.Descripcion = p_descripcion;
        //Call to ProveedorCAD

        _IProveedorCAD.Editar (proveedorEN);
}

public void Eliminar (string id)
{
        _IProveedorCAD.Eliminar (id);
}

public System.Collections.Generic.IList<ProveedorEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<ProveedorEN> list = null;

        list = _IProveedorCAD.ObtenerTodos (first, size);
        return list;
}
public ProveedorEN ObtenerProveedor (string id)
{
        ProveedorEN proveedorEN = null;

        proveedorEN = _IProveedorCAD.ObtenerProveedor (id);
        return proveedorEN;
}
}
}
