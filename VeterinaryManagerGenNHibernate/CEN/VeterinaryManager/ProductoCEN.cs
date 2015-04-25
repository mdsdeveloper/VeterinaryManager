

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;
using VeterinaryManagerGenNHibernate.CAD.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CEN.VeterinaryManager
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

public int Nuevo_producto (string p_nombre, string p_descripcion, float p_precio, int p_stock, int p_id)
{
        ProductoEN productoEN = null;
        int oid;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Nombre = p_nombre;

        productoEN.Descripcion = p_descripcion;

        productoEN.Precio = p_precio;

        productoEN.Stock = p_stock;

        productoEN.Id = p_id;

        //Call to ProductoCAD

        oid = _IProductoCAD.Nuevo_producto (productoEN);
        return oid;
}

public void Modify (int p_Producto_OID, string p_nombre, string p_descripcion, float p_precio, int p_stock)
{
        ProductoEN productoEN = null;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Id = p_Producto_OID;
        productoEN.Nombre = p_nombre;
        productoEN.Descripcion = p_descripcion;
        productoEN.Precio = p_precio;
        productoEN.Stock = p_stock;
        //Call to ProductoCAD

        _IProductoCAD.Modify (productoEN);
}

public void Destroy (int id)
{
        _IProductoCAD.Destroy (id);
}

public ProductoEN ReadOID (int id)
{
        ProductoEN productoEN = null;

        productoEN = _IProductoCAD.ReadOID (id);
        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> list = null;

        list = _IProductoCAD.ReadAll (first, size);
        return list;
}
}
}
