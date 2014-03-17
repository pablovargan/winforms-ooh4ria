
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class FacturaEN
{
/**
 *
 */

private string id;

/**
 *
 */

private float horas;

/**
 *
 */

private float precioHora;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private float total;

/**
 *
 */

private PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacion;





public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual float Horas {
        get { return horas; } set { horas = value;  }
}


public virtual float PrecioHora {
        get { return precioHora; } set { precioHora = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual float Total {
        get { return total; } set { total = value;  }
}


public virtual PalmeralGenNHibernate.EN.Default_.InstalacionEN Instalacion {
        get { return instalacion; } set { instalacion = value;  }
}





public FacturaEN()
{
}



public FacturaEN(string id, float horas, float precioHora, Nullable<DateTime> fecha, float total, PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacion)
{
        this.init (id, horas, precioHora, fecha, total, instalacion);
}


public FacturaEN(FacturaEN factura)
{
        this.init (factura.Id, factura.Horas, factura.PrecioHora, factura.Fecha, factura.Total, factura.Instalacion);
}

private void init (string id, float horas, float precioHora, Nullable<DateTime> fecha, float total, PalmeralGenNHibernate.EN.Default_.InstalacionEN instalacion)
{
        this.Id = id;


        this.Horas = horas;

        this.PrecioHora = precioHora;

        this.Fecha = fecha;

        this.Total = total;

        this.Instalacion = instalacion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
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
