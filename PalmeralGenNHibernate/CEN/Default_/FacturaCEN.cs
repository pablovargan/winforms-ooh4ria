

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
public partial class FacturaCEN
{
private IFacturaCAD _IFacturaCAD;

public FacturaCEN()
{
        this._IFacturaCAD = new FacturaCAD ();
}

public FacturaCEN(IFacturaCAD _IFacturaCAD)
{
        this._IFacturaCAD = _IFacturaCAD;
}

public IFacturaCAD get_IFacturaCAD ()
{
        return this._IFacturaCAD;
}

public string Crear (string p_id, float p_horas, float p_precioHora, Nullable<DateTime> p_fecha, float p_total, string p_instalacion)
{
        FacturaEN facturaEN = null;
        string oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_id;

        facturaEN.Horas = p_horas;

        facturaEN.PrecioHora = p_precioHora;

        facturaEN.Fecha = p_fecha;

        facturaEN.Total = p_total;


        if (p_instalacion != null) {
                facturaEN.Instalacion = new PalmeralGenNHibernate.EN.Default_.InstalacionEN ();
                facturaEN.Instalacion.Id = p_instalacion;
        }

        //Call to FacturaCAD

        oid = _IFacturaCAD.Crear (facturaEN);
        return oid;
}

public void Editar (string p_oid, float p_horas, float p_precioHora, Nullable<DateTime> p_fecha, float p_total)
{
        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_oid;
        facturaEN.Horas = p_horas;
        facturaEN.PrecioHora = p_precioHora;
        facturaEN.Fecha = p_fecha;
        facturaEN.Total = p_total;
        //Call to FacturaCAD

        _IFacturaCAD.Editar (facturaEN);
}

public void Eliminar (string id)
{
        _IFacturaCAD.Eliminar (id);
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> ObtenerFacturasInstalacion (string p_instalacion)
{
        return _IFacturaCAD.ObtenerFacturasInstalacion (p_instalacion);
}
public FacturaEN ObtenerFactura (string id)
{
        FacturaEN facturaEN = null;

        facturaEN = _IFacturaCAD.ObtenerFactura (id);
        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> ObtenterTodas (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> list = null;

        list = _IFacturaCAD.ObtenterTodas (first, size);
        return list;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> ObtenerPorAnyo (string p_anyo)
{
        return _IFacturaCAD.ObtenerPorAnyo (p_anyo);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> ObtenerPorMesAnyo (string p_mes, string p_anyo)
{
        return _IFacturaCAD.ObtenerPorMesAnyo (p_mes, p_anyo);
}
}
}
