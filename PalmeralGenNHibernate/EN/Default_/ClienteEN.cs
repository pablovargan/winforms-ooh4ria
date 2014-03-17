
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class ClienteEN
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

private string descripcion;

/**
 *
 */

private string email;

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

private System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.InstalacionEN> instalaciones;





public virtual string Nif {
        get { return nif; } set { nif = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
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


public virtual System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.InstalacionEN> Instalaciones {
        get { return instalaciones; } set { instalaciones = value;  }
}





public ClienteEN()
{
        instalaciones = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.InstalacionEN>();
}



public ClienteEN(string nif, string nombre, string descripcion, string email, string localidad, string provincia, string pais, string direccion, string codigoPostal, string telefono, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.InstalacionEN> instalaciones)
{
        this.init (nif, nombre, descripcion, email, localidad, provincia, pais, direccion, codigoPostal, telefono, instalaciones);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.Nif, cliente.Nombre, cliente.Descripcion, cliente.Email, cliente.Localidad, cliente.Provincia, cliente.Pais, cliente.Direccion, cliente.CodigoPostal, cliente.Telefono, cliente.Instalaciones);
}

private void init (string nif, string nombre, string descripcion, string email, string localidad, string provincia, string pais, string direccion, string codigoPostal, string telefono, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.InstalacionEN> instalaciones)
{
        this.Nif = nif;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Email = email;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Pais = pais;

        this.Direccion = direccion;

        this.CodigoPostal = codigoPostal;

        this.Telefono = telefono;

        this.Instalaciones = instalaciones;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
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
