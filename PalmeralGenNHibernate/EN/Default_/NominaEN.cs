
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class NominaEN
{
/**
 *
 */

private string id;

/**
 *
 */

private float parteFija;

/**
 *
 */

private float parteVariable;

/**
 *
 */

private float horas;

/**
 *
 */

private float total;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private PalmeralGenNHibernate.EN.Default_.TrabajadorEN trabajador;





public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual float ParteFija {
        get { return parteFija; } set { parteFija = value;  }
}


public virtual float ParteVariable {
        get { return parteVariable; } set { parteVariable = value;  }
}


public virtual float Horas {
        get { return horas; } set { horas = value;  }
}


public virtual float Total {
        get { return total; } set { total = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual PalmeralGenNHibernate.EN.Default_.TrabajadorEN Trabajador {
        get { return trabajador; } set { trabajador = value;  }
}





public NominaEN()
{
}



public NominaEN(string id, float parteFija, float parteVariable, float horas, float total, Nullable<DateTime> fecha, PalmeralGenNHibernate.EN.Default_.TrabajadorEN trabajador)
{
        this.init (id, parteFija, parteVariable, horas, total, fecha, trabajador);
}


public NominaEN(NominaEN nomina)
{
        this.init (nomina.Id, nomina.ParteFija, nomina.ParteVariable, nomina.Horas, nomina.Total, nomina.Fecha, nomina.Trabajador);
}

private void init (string id, float parteFija, float parteVariable, float horas, float total, Nullable<DateTime> fecha, PalmeralGenNHibernate.EN.Default_.TrabajadorEN trabajador)
{
        this.Id = id;


        this.ParteFija = parteFija;

        this.ParteVariable = parteVariable;

        this.Horas = horas;

        this.Total = total;

        this.Fecha = fecha;

        this.Trabajador = trabajador;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NominaEN t = obj as NominaEN;
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
