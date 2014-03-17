
using System;

namespace PalmeralGenNHibernate.EN.Default_
{
public partial class PedidoEN
{
/**
 *
 */

private string id;

/**
 *
 */

private Nullable<DateTime> fecha;

/**
 *
 */

private PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum estado;

/**
 *
 */

private PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum tipoPago;

/**
 *
 */

private System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> lineas;

/**
 *
 */

private PalmeralGenNHibernate.EN.Default_.ProveedorEN proveedor;





public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum Estado {
        get { return estado; } set { estado = value;  }
}


public virtual PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum TipoPago {
        get { return tipoPago; } set { tipoPago = value;  }
}


public virtual System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> Lineas {
        get { return lineas; } set { lineas = value;  }
}


public virtual PalmeralGenNHibernate.EN.Default_.ProveedorEN Proveedor {
        get { return proveedor; } set { proveedor = value;  }
}





public PedidoEN()
{
        lineas = new System.Collections.Generic.List<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN>();
}



public PedidoEN(string id, Nullable<DateTime> fecha, PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum estado, PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum tipoPago, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> lineas, PalmeralGenNHibernate.EN.Default_.ProveedorEN proveedor)
{
        this.init (id, fecha, estado, tipoPago, lineas, proveedor);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (pedido.Id, pedido.Fecha, pedido.Estado, pedido.TipoPago, pedido.Lineas, pedido.Proveedor);
}

private void init (string id, Nullable<DateTime> fecha, PalmeralGenNHibernate.Enumerated.Default_.EstadoPedidoEnum estado, PalmeralGenNHibernate.Enumerated.Default_.TipoPagoEnum tipoPago, System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.LineaPedidoEN> lineas, PalmeralGenNHibernate.EN.Default_.ProveedorEN proveedor)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Estado = estado;

        this.TipoPago = tipoPago;

        this.Lineas = lineas;

        this.Proveedor = proveedor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
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
