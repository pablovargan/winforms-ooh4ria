
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class JornadaFechaEN
{
/**
 *
 */

private int id;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> trabajadores;

/**
 *
 */

private PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacion;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> Trabajadores {
        get { return trabajadores; } set { trabajadores = value;  }
}


public virtual PalmeralGenNHibernate.EN.Default_.InstalacionEN Instalacion {
        get { return instalacion; } set { instalacion = value;  }
}





public JornadaFechaEN()
{
        trabajadores = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.TrabajadorEN>();
}



public JornadaFechaEN(int id, Nullable<DateTime> fecha, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> trabajadores, PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacion)
{
        this.init (id, fecha, trabajadores, instalacion);
}


public JornadaFechaEN(JornadaFechaEN jornadaFecha)
{
        this.init (jornadaFecha.Id, jornadaFecha.Fecha, jornadaFecha.Trabajadores, jornadaFecha.Instalacion);
}

private void init (int id, Nullable<DateTime> fecha, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.TrabajadorEN> trabajadores, PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacion)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Trabajadores = trabajadores;

        this.Instalacion = instalacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        JornadaFechaEN t = obj as JornadaFechaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
