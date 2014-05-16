
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class CopiaSeguridadEN
{
/**
 *
 */

private string id;

/**
 *
 */

private string fecha;

/**
 *
 */

private string ruta;





public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual string Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual string Ruta {
        get { return ruta; } set { ruta = value;  }
}





public CopiaSeguridadEN()
{
}



public CopiaSeguridadEN(string id, string fecha, string ruta)
{
        this.init (id, fecha, ruta);
}


public CopiaSeguridadEN(CopiaSeguridadEN copiaSeguridad)
{
        this.init (copiaSeguridad.Id, copiaSeguridad.Fecha, copiaSeguridad.Ruta);
}

private void init (string id, string fecha, string ruta)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Ruta = ruta;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CopiaSeguridadEN t = obj as CopiaSeguridadEN;
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
