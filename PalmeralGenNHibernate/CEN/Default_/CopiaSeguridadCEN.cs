

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
public partial class CopiaSeguridadCEN
{
private ICopiaSeguridadCAD _ICopiaSeguridadCAD;

public CopiaSeguridadCEN()
{
        this._ICopiaSeguridadCAD = new CopiaSeguridadCAD ();
}

public CopiaSeguridadCEN(ICopiaSeguridadCAD _ICopiaSeguridadCAD)
{
        this._ICopiaSeguridadCAD = _ICopiaSeguridadCAD;
}

public ICopiaSeguridadCAD get_ICopiaSeguridadCAD ()
{
        return this._ICopiaSeguridadCAD;
}

public string Crear (string p_id, string p_fecha, string p_ruta)
{
        CopiaSeguridadEN copiaSeguridadEN = null;
        string oid;

        //Initialized CopiaSeguridadEN
        copiaSeguridadEN = new CopiaSeguridadEN ();
        copiaSeguridadEN.Id = p_id;

        copiaSeguridadEN.Fecha = p_fecha;

        copiaSeguridadEN.Ruta = p_ruta;

        //Call to CopiaSeguridadCAD

        oid = _ICopiaSeguridadCAD.Crear (copiaSeguridadEN);
        return oid;
}

public void Editar (string p_oid, string p_fecha, string p_ruta)
{
        CopiaSeguridadEN copiaSeguridadEN = null;

        //Initialized CopiaSeguridadEN
        copiaSeguridadEN = new CopiaSeguridadEN ();
        copiaSeguridadEN.Id = p_oid;
        copiaSeguridadEN.Fecha = p_fecha;
        copiaSeguridadEN.Ruta = p_ruta;
        //Call to CopiaSeguridadCAD

        _ICopiaSeguridadCAD.Editar (copiaSeguridadEN);
}

public void Eliminar (string id)
{
        _ICopiaSeguridadCAD.Eliminar (id);
}
}
}
