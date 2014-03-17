

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
public partial class NominaCEN
{
private INominaCAD _INominaCAD;

public NominaCEN()
{
        this._INominaCAD = new NominaCAD ();
}

public NominaCEN(INominaCAD _INominaCAD)
{
        this._INominaCAD = _INominaCAD;
}

public INominaCAD get_INominaCAD ()
{
        return this._INominaCAD;
}

public string Crear (string p_id, float p_parteFija, float p_parteVariable, float p_horas, float p_total, Nullable<DateTime> p_fecha, string p_trabajador)
{
        NominaEN nominaEN = null;
        string oid;

        //Initialized NominaEN
        nominaEN = new NominaEN ();
        nominaEN.Id = p_id;

        nominaEN.ParteFija = p_parteFija;

        nominaEN.ParteVariable = p_parteVariable;

        nominaEN.Horas = p_horas;

        nominaEN.Total = p_total;

        nominaEN.Fecha = p_fecha;


        if (p_trabajador != null) {
                nominaEN.Trabajador = new PalmeralGenNHibernate.EN.Default_.TrabajadorEN ();
                nominaEN.Trabajador.Nif = p_trabajador;
        }

        //Call to NominaCAD

        oid = _INominaCAD.Crear (nominaEN);
        return oid;
}

public void Editar (string p_oid, float p_parteFija, float p_parteVariable, float p_horas, float p_total, Nullable<DateTime> p_fecha)
{
        NominaEN nominaEN = null;

        //Initialized NominaEN
        nominaEN = new NominaEN ();
        nominaEN.Id = p_oid;
        nominaEN.ParteFija = p_parteFija;
        nominaEN.ParteVariable = p_parteVariable;
        nominaEN.Horas = p_horas;
        nominaEN.Total = p_total;
        nominaEN.Fecha = p_fecha;
        //Call to NominaCAD

        _INominaCAD.Editar (nominaEN);
}

public void Eliminar (string id)
{
        _INominaCAD.Eliminar (id);
}

public System.Collections.Generic.IList<NominaEN> ObtenerTodas (int first, int size)
{
        System.Collections.Generic.IList<NominaEN> list = null;

        list = _INominaCAD.ObtenerTodas (first, size);
        return list;
}
public NominaEN ObtenerNomina (string id)
{
        NominaEN nominaEN = null;

        nominaEN = _INominaCAD.ObtenerNomina (id);
        return nominaEN;
}

public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> ObtenerTodasNominasTrabajador (string p_trabajador)
{
        return _INominaCAD.ObtenerTodasNominasTrabajador (p_trabajador);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> BuscarPorParteFija (float p_parteFija)
{
        return _INominaCAD.BuscarPorParteFija (p_parteFija);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> BuscarPorAnyo (string p_anyo)
{
        return _INominaCAD.BuscarPorAnyo (p_anyo);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> BuscarPorMesAnyo (string p_mes, string p_anyo)
{
        return _INominaCAD.BuscarPorMesAnyo (p_mes, p_anyo);
}
}
}
