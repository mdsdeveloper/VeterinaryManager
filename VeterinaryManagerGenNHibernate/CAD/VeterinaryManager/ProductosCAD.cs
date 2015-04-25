
using System;
using System.Text;
using VeterinaryManagerGenNHibernate.CEN.VeterinaryManager;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;
using VeterinaryManagerGenNHibernate.Exceptions;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial class ProductosCAD : BasicCAD, IProductosCAD
{
public ProductosCAD() : base ()
{
}

public ProductosCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProductosEN ReadOIDDefault (int id)
{
        ProductosEN productosEN = null;

        try
        {
                SessionInitializeTransaction ();
                productosEN = (ProductosEN)session.Get (typeof(ProductosEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productosEN;
}


public int Nuevo_producto (ProductosEN productos)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (productos);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productos.Id;
}

public void Modify (ProductosEN productos)
{
        try
        {
                SessionInitializeTransaction ();
                ProductosEN productosEN = (ProductosEN)session.Load (typeof(ProductosEN), productos.Id);

                productosEN.Nombre = productos.Nombre;


                productosEN.Descripcion = productos.Descripcion;


                productosEN.Precio = productos.Precio;


                productosEN.Stock = productos.Stock;

                session.Update (productosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id)
{
        try
        {
                SessionInitializeTransaction ();
                ProductosEN productosEN = (ProductosEN)session.Load (typeof(ProductosEN), id);
                session.Delete (productosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public ProductosEN ReadOID (int id)
{
        ProductosEN productosEN = null;

        try
        {
                SessionInitializeTransaction ();
                productosEN = (ProductosEN)session.Get (typeof(ProductosEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productosEN;
}

public System.Collections.Generic.IList<ProductosEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ProductosEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProductosEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProductosEN>();
                else
                        result = session.CreateCriteria (typeof(ProductosEN)).List<ProductosEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
