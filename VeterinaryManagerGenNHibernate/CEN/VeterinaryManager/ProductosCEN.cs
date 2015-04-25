

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
public partial class ProductosCEN
{
private IProductosCAD _IProductosCAD;

public ProductosCEN()
{
        this._IProductosCAD = new ProductosCAD ();
}

public ProductosCEN(IProductosCAD _IProductosCAD)
{
        this._IProductosCAD = _IProductosCAD;
}

public IProductosCAD get_IProductosCAD ()
{
        return this._IProductosCAD;
}

public int Nuevo_producto (string p_nombre, string p_descripcion, float p_precio, int p_stock, int p_id)
{
        ProductosEN productosEN = null;
        int oid;

        //Initialized ProductosEN
        productosEN = new ProductosEN ();
        productosEN.Nombre = p_nombre;

        productosEN.Descripcion = p_descripcion;

        productosEN.Precio = p_precio;

        productosEN.Stock = p_stock;

        productosEN.Id = p_id;

        //Call to ProductosCAD

        oid = _IProductosCAD.Nuevo_producto (productosEN);
        return oid;
}

public void Modify (int p_Productos_OID, string p_nombre, string p_descripcion, float p_precio, int p_stock)
{
        ProductosEN productosEN = null;

        //Initialized ProductosEN
        productosEN = new ProductosEN ();
        productosEN.Id = p_Productos_OID;
        productosEN.Nombre = p_nombre;
        productosEN.Descripcion = p_descripcion;
        productosEN.Precio = p_precio;
        productosEN.Stock = p_stock;
        //Call to ProductosCAD

        _IProductosCAD.Modify (productosEN);
}

public void Destroy (int id)
{
        _IProductosCAD.Destroy (id);
}

public ProductosEN ReadOID (int id)
{
        ProductosEN productosEN = null;

        productosEN = _IProductosCAD.ReadOID (id);
        return productosEN;
}

public System.Collections.Generic.IList<ProductosEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ProductosEN> list = null;

        list = _IProductosCAD.ReadAll (first, size);
        return list;
}
}
}
