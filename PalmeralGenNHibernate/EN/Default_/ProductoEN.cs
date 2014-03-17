
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class ProductoEN
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

private int stock;

/**
 *
 */

private string foto;

/**
 *
 */

private System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> linea;





public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual int Stock {
        get { return stock; } set { stock = value;  }
}


public virtual string Foto {
        get { return foto; } set { foto = value;  }
}


public virtual System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> Linea {
        get { return linea; } set { linea = value;  }
}





public ProductoEN()
{
        linea = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN>();
}



public ProductoEN(string id, string nombre, string descripcion, int stock, string foto, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> linea)
{
        this.init (id, nombre, descripcion, stock, foto, linea);
}


public ProductoEN(ProductoEN producto)
{
        this.init (producto.Id, producto.Nombre, producto.Descripcion, producto.Stock, producto.Foto, producto.Linea);
}

private void init (string id, string nombre, string descripcion, int stock, string foto, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> linea)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Stock = stock;

        this.Foto = foto;

        this.Linea = linea;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
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
