

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
public partial class InstalacionCEN
{
private IInstalacionCAD _IInstalacionCAD;

public InstalacionCEN()
{
        this._IInstalacionCAD = new InstalacionCAD ();
}

public InstalacionCEN(IInstalacionCAD _IInstalacionCAD)
{
        this._IInstalacionCAD = _IInstalacionCAD;
}

public IInstalacionCAD get_IInstalacionCAD ()
{
        return this._IInstalacionCAD;
}

public string Crear (string p_id, string p_nombre, string p_descripcion, string p_localidad, string p_provincia, string p_pais, string p_direccion, string p_codigoPostal, string p_telefono, float p_metrosCuadrados, string p_cliente)
{
        InstalacionEN instalacionEN = null;
        string oid;

        //Initialized InstalacionEN
        instalacionEN = new InstalacionEN ();
        instalacionEN.Id = p_id;

        instalacionEN.Nombre = p_nombre;

        instalacionEN.Descripcion = p_descripcion;

        instalacionEN.Localidad = p_localidad;

        instalacionEN.Provincia = p_provincia;

        instalacionEN.Pais = p_pais;

        instalacionEN.Direccion = p_direccion;

        instalacionEN.CodigoPostal = p_codigoPostal;

        instalacionEN.Telefono = p_telefono;

        instalacionEN.MetrosCuadrados = p_metrosCuadrados;


        if (p_cliente != null) {
                instalacionEN.Cliente = new PalmeralGenNHibernate.EN.Default_.ClienteEN ();
                instalacionEN.Cliente.Nif = p_cliente;
        }

        //Call to InstalacionCAD

        oid = _IInstalacionCAD.Crear (instalacionEN);
        return oid;
}

public void Editar (string p_oid, string p_nombre, string p_descripcion, string p_localidad, string p_provincia, string p_pais, string p_direccion, string p_codigoPostal, string p_telefono, float p_metrosCuadrados)
{
        InstalacionEN instalacionEN = null;

        //Initialized InstalacionEN
        instalacionEN = new InstalacionEN ();
        instalacionEN.Id = p_oid;
        instalacionEN.Nombre = p_nombre;
        instalacionEN.Descripcion = p_descripcion;
        instalacionEN.Localidad = p_localidad;
        instalacionEN.Provincia = p_provincia;
        instalacionEN.Pais = p_pais;
        instalacionEN.Direccion = p_direccion;
        instalacionEN.CodigoPostal = p_codigoPostal;
        instalacionEN.Telefono = p_telefono;
        instalacionEN.MetrosCuadrados = p_metrosCuadrados;
        //Call to InstalacionCAD

        _IInstalacionCAD.Editar (instalacionEN);
}

public void Eliminar (string id)
{
        _IInstalacionCAD.Eliminar (id);
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.InstalacionEN> BuscarInstalacionesCliente (string p_cliente)
{
        return _IInstalacionCAD.BuscarInstalacionesCliente (p_cliente);
}
public InstalacionEN ObtenerInstalacion (string id)
{
        InstalacionEN instalacionEN = null;

        instalacionEN = _IInstalacionCAD.ObtenerInstalacion (id);
        return instalacionEN;
}

public System.Collections.Generic.IList<InstalacionEN> ObtenerTodas (int first, int size)
{
        System.Collections.Generic.IList<InstalacionEN> list = null;

        list = _IInstalacionCAD.ObtenerTodas (first, size);
        return list;
}
}
}
