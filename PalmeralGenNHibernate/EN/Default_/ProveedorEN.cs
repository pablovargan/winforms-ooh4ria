
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class ProveedorEN
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

private string telefono;

/**
 *
 */

private string direccion;

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

private string codigoPostal;

/**
 *
 */

private string email;

/**
 *
 */

private string pais;

/**
 *
 */

private string descripcion;

/**
 *
 */

private System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> pedido;





public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}


public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}


public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}


public virtual string CodigoPostal {
        get { return codigoPostal; } set { codigoPostal = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual string Pais {
        get { return pais; } set { pais = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}





public ProveedorEN()
{
        pedido = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.PedidoEN>();
}



public ProveedorEN(string id, string nombre, string telefono, string direccion, string localidad, string provincia, string codigoPostal, string email, string pais, string descripcion, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> pedido)
{
        this.init (id, nombre, telefono, direccion, localidad, provincia, codigoPostal, email, pais, descripcion, pedido);
}


public ProveedorEN(ProveedorEN proveedor)
{
        this.init (proveedor.Id, proveedor.Nombre, proveedor.Telefono, proveedor.Direccion, proveedor.Localidad, proveedor.Provincia, proveedor.CodigoPostal, proveedor.Email, proveedor.Pais, proveedor.Descripcion, proveedor.Pedido);
}

private void init (string id, string nombre, string telefono, string direccion, string localidad, string provincia, string codigoPostal, string email, string pais, string descripcion, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.PedidoEN> pedido)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Telefono = telefono;

        this.Direccion = direccion;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.CodigoPostal = codigoPostal;

        this.Email = email;

        this.Pais = pais;

        this.Descripcion = descripcion;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProveedorEN t = obj as ProveedorEN;
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
