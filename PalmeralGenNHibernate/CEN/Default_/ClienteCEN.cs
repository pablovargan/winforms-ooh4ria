

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
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public string Crear (string p_nif, string p_nombre, string p_descripcion, string p_email, string p_localidad, string p_provincia, string p_pais, string p_direccion, string p_codigoPostal, string p_telefono)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Nif = p_nif;

        clienteEN.Nombre = p_nombre;

        clienteEN.Descripcion = p_descripcion;

        clienteEN.Email = p_email;

        clienteEN.Localidad = p_localidad;

        clienteEN.Provincia = p_provincia;

        clienteEN.Pais = p_pais;

        clienteEN.Direccion = p_direccion;

        clienteEN.CodigoPostal = p_codigoPostal;

        clienteEN.Telefono = p_telefono;

        //Call to ClienteCAD

        oid = _IClienteCAD.Crear (clienteEN);
        return oid;
}

public void Editar (string p_oid, string p_nombre, string p_descripcion, string p_email, string p_localidad, string p_provincia, string p_pais, string p_direccion, string p_codigoPostal, string p_telefono)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Nif = p_oid;
        clienteEN.Nombre = p_nombre;
        clienteEN.Descripcion = p_descripcion;
        clienteEN.Email = p_email;
        clienteEN.Localidad = p_localidad;
        clienteEN.Provincia = p_provincia;
        clienteEN.Pais = p_pais;
        clienteEN.Direccion = p_direccion;
        clienteEN.CodigoPostal = p_codigoPostal;
        clienteEN.Telefono = p_telefono;
        //Call to ClienteCAD

        _IClienteCAD.Editar (clienteEN);
}

public void Eliminar (string nif)
{
        _IClienteCAD.Eliminar (nif);
}

public System.Collections.Generic.IList<ClienteEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> list = null;

        list = _IClienteCAD.ObtenerTodos (first, size);
        return list;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ClienteEN> BuscarPorNombre (string p_nombre)
{
        return _IClienteCAD.BuscarPorNombre (p_nombre);
}
public ClienteEN ObtenerCliente (string nif)
{
        ClienteEN clienteEN = null;

        clienteEN = _IClienteCAD.ObtenerCliente (nif);
        return clienteEN;
}
}
}
