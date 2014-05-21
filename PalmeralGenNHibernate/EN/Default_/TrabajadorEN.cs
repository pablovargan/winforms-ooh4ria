
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class TrabajadorEN
{
/**
 *
 */

private string nif;

/**
 *
 */

private string nombre;

/**
 *
 */

private string apellidos;

/**
 *
 */

private string direccion;

/**
 *
 */

private string telefono;

/**
 *
 */

private string codigoPostal;

/**
 *
 */

private string pais;

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

private PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum tipo;

/**
 *
 */

private System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> nominas;

/**
 *
 */

private System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas;





public virtual string Nif {
        get { return nif; } set { nif = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}


public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}


public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual string CodigoPostal {
        get { return codigoPostal; } set { codigoPostal = value;  }
}


public virtual string Pais {
        get { return pais; } set { pais = value;  }
}


public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}


public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}


public virtual PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}


public virtual System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> Nominas {
        get { return nominas; } set { nominas = value;  }
}


public virtual System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> Jornadas {
        get { return jornadas; } set { jornadas = value;  }
}





public TrabajadorEN()
{
        nominas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.NominaEN>();
        jornadas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN>();
}



public TrabajadorEN(string nif, string nombre, string apellidos, string direccion, string telefono, string codigoPostal, string pais, string localidad, string provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum tipo, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> nominas, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas)
{
        this.init (nif, nombre, apellidos, direccion, telefono, codigoPostal, pais, localidad, provincia, tipo, nominas, jornadas);
}


public TrabajadorEN(TrabajadorEN trabajador)
{
        this.init (trabajador.Nif, trabajador.Nombre, trabajador.Apellidos, trabajador.Direccion, trabajador.Telefono, trabajador.CodigoPostal, trabajador.Pais, trabajador.Localidad, trabajador.Provincia, trabajador.Tipo, trabajador.Nominas, trabajador.Jornadas);
}

private void init (string nif, string nombre, string apellidos, string direccion, string telefono, string codigoPostal, string pais, string localidad, string provincia, PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum tipo, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.NominaEN> nominas, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.JornadaFechaEN> jornadas)
{
        this.Nif = nif;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Direccion = direccion;

        this.Telefono = telefono;

        this.CodigoPostal = codigoPostal;

        this.Pais = pais;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Tipo = tipo;

        this.Nominas = nominas;

        this.Jornadas = jornadas;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TrabajadorEN t = obj as TrabajadorEN;
        if (t == null)
                return false;
        if (Nif.Equals (t.Nif))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nif.GetHashCode ();
        return hash;
}
}
}
