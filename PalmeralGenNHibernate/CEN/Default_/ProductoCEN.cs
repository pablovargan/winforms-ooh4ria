

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using PalmeralGenNHibernate.EN.Default_;
using PalmeralGenNHibernate.CAD.Default_;

namespace PalmeralGenNHibernate.CEN.Default_
{
public partial class ProductoCEN
{
private IProductoCAD _IProductoCAD;

public ProductoCEN()
{
        this._IProductoCAD = new ProductoCAD ();
}

public ProductoCEN(IProductoCAD _IProductoCAD)
{
        this._IProductoCAD = _IProductoCAD;
}

public IProductoCAD get_IProductoCAD ()
{
        return this._IProductoCAD;
}

public string Crear (string p_id, string p_nombre, string p_descripcion, int p_stock, string p_foto)
{
        ProductoEN productoEN = null;
        string oid;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Id = p_id;

        productoEN.Nombre = p_nombre;

        productoEN.Descripcion = p_descripcion;

        productoEN.Stock = p_stock;

        productoEN.Foto = p_foto;

        //Call to ProductoCAD

        oid = _IProductoCAD.Crear (productoEN);
        return oid;
}

public void Editar (string p_oid, string p_nombre, string p_descripcion, int p_stock, string p_foto)
{
        ProductoEN productoEN = null;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Id = p_oid;
        productoEN.Nombre = p_nombre;
        productoEN.Descripcion = p_descripcion;
        productoEN.Stock = p_stock;
        productoEN.Foto = p_foto;
        //Call to ProductoCAD

        _IProductoCAD.Editar (productoEN);
}

public void Eliminar (string id)
{
        _IProductoCAD.Eliminar (id);
}

public System.Collections.Generic.IList<ProductoEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> list = null;

        list = _IProductoCAD.ObtenerTodos (first, size);
        return list;
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ProductoEN> BuscarPorNombre (string p_nombre)
{
        return _IProductoCAD.BuscarPorNombre (p_nombre);
}
public System.Collections.Generic.IList<PalmeralGenNHibernate.EN.Default_.ProductoEN> BuscarPorStock (int p_stock)
{
        return _IProductoCAD.BuscarPorStock (p_stock);
}
public ProductoEN ObtenerProducto (string id)
{
        ProductoEN productoEN = null;

        productoEN = _IProductoCAD.ObtenerProducto (id);
        return productoEN;
}
}
}
