
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class LineaPedidoEN
{
/**
 *
 */

private int id;

/**
 *
 */

private int cantidad;

/**
 *
 */

private PalmeralGenNHibernate.EN.Default_.ProductoEN productos;

/**
 *
 */

private PalmeralGenNHibernate.EN.Default_.PedidoEN pedido;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}


public virtual PalmeralGenNHibernate.EN.Default_.ProductoEN Productos {
        get { return productos; } set { productos = value;  }
}


public virtual PalmeralGenNHibernate.EN.Default_.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int id, int cantidad, PalmeralGenNHibernate.EN.Default_.ProductoEN productos, PalmeralGenNHibernate.EN.Default_.PedidoEN pedido)
{
        this.init (id, cantidad, productos, pedido);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (lineaPedido.Id, lineaPedido.Cantidad, lineaPedido.Productos, lineaPedido.Pedido);
}

private void init (int id, int cantidad, PalmeralGenNHibernate.EN.Default_.ProductoEN productos, PalmeralGenNHibernate.EN.Default_.PedidoEN pedido)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Productos = productos;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
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
