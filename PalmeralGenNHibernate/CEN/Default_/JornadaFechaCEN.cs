

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
public partial class JornadaFechaCEN
{
private IJornadaFechaCAD _IJornadaFechaCAD;

public JornadaFechaCEN()
{
        this._IJornadaFechaCAD = new JornadaFechaCAD ();
}

public JornadaFechaCEN(IJornadaFechaCAD _IJornadaFechaCAD)
{
        this._IJornadaFechaCAD = _IJornadaFechaCAD;
}

public IJornadaFechaCAD get_IJornadaFechaCAD ()
{
        return this._IJornadaFechaCAD;
}

public int Crear (Nullable<DateTime> p_fecha, string p_instalacion)
{
        JornadaFechaEN jornadaFechaEN = null;
        int oid;

        //Initialized JornadaFechaEN
        jornadaFechaEN = new JornadaFechaEN ();
        jornadaFechaEN.Fecha = p_fecha;


        if (p_instalacion != null) {
                jornadaFechaEN.Instalacion = new PalmeralGenNHibernate.EN.Default_.InstalacionEN ();
                jornadaFechaEN.Instalacion.Id = p_instalacion;
        }

        //Call to JornadaFechaCAD

        oid = _IJornadaFechaCAD.Crear (jornadaFechaEN);
        return oid;
}

public void Editar (int p_oid, Nullable<DateTime> p_fecha)
{
        JornadaFechaEN jornadaFechaEN = null;

        //Initialized JornadaFechaEN
        jornadaFechaEN = new JornadaFechaEN ();
        jornadaFechaEN.Id = p_oid;
        jornadaFechaEN.Fecha = p_fecha;
        //Call to JornadaFechaCAD

        _IJornadaFechaCAD.Editar (jornadaFechaEN);
}

public void Eliminar (int id)
{
        _IJornadaFechaCAD.Eliminar (id);
}

public JornadaFechaEN ObtenerJornada (int id)
{
        JornadaFechaEN jornadaFechaEN = null;

        jornadaFechaEN = _IJornadaFechaCAD.ObtenerJornada (id);
        return jornadaFechaEN;
}

public System.Collections.Generic.IList<JornadaFechaEN> ObtenerTodas (int first, int size)
{
        System.Collections.Generic.IList<JornadaFechaEN> list = null;

        list = _IJornadaFechaCAD.ObtenerTodas (first, size);
        return list;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> ReadFilter (Nullable<DateTime> p_fecha, string p_instalacion)
{
        return _IJornadaFechaCAD.ReadFilter (p_fecha, p_instalacion);
}
}
}
