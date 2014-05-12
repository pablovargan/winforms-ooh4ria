
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class InstalacionEN
{
/**
 *
 */

private string id;

/**
 *
 */

private string nombre;

/**
 *
 */

private string descripcion;

/**
 *
 */

private string localidad;

/**
 *
 */

private string provincia;

/**
 *
 */

private string pais;

/**
 *
 */

private string direccion;

/**
 *
 */

private string codigoPostal;

/**
 *
 */

private string telefono;

/**
 *
 */

private float metrosCuadrados;

/**
 *
 */

private PalmeralGenNHibernate.EN.Default_.ClienteEN cliente;

/**
 *
 */

private System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas;

/**
 *
 */

private System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> facturas;





public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}


public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}


public virtual string Pais {
        get { return pais; } set { pais = value;  }
}


public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}


public virtual string CodigoPostal {
        get { return codigoPostal; } set { codigoPostal = value;  }
}


public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual float MetrosCuadrados {
        get { return metrosCuadrados; } set { metrosCuadrados = value;  }
}


public virtual PalmeralGenNHibernate.EN.Default_.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}


public virtual System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> Jornadas {
        get { return jornadas; } set { jornadas = value;  }
}


public virtual System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> Facturas {
        get { return facturas; } set { facturas = value;  }
}





public InstalacionEN()
{
        jornadas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN>();
        facturas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.FacturaEN>();
}



public InstalacionEN(string id, string nombre, string descripcion, string localidad, string provincia, string pais, string direccion, string codigoPostal, string telefono, float metrosCuadrados, PalmeralGenNHibernate.EN.Default_.ClienteEN cliente, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> facturas)
{
        this.init (id, nombre, descripcion, localidad, provincia, pais, direccion, codigoPostal, telefono, metrosCuadrados, cliente, jornadas, facturas);
}


public InstalacionEN(InstalacionEN instalacion)
{
        this.init (instalacion.Id, instalacion.Nombre, instalacion.Descripcion, instalacion.Localidad, instalacion.Provincia, instalacion.Pais, instalacion.Direccion, instalacion.CodigoPostal, instalacion.Telefono, instalacion.MetrosCuadrados, instalacion.Cliente, instalacion.Jornadas, instalacion.Facturas);
}

private void init (string id, string nombre, string descripcion, string localidad, string provincia, string pais, string direccion, string codigoPostal, string telefono, float metrosCuadrados, PalmeralGenNHibernate.EN.Default_.ClienteEN cliente, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.FacturaEN> facturas)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Pais = pais;

        this.Direccion = direccion;

        this.CodigoPostal = codigoPostal;

        this.Telefono = telefono;

        this.MetrosCuadrados = metrosCuadrados;

        this.Cliente = cliente;

        this.Jornadas = jornadas;

        this.Facturas = facturas;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        InstalacionEN t = obj as InstalacionEN;
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
