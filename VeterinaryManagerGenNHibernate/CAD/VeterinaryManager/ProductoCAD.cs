
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
public partial class ProductoCAD : BasicCAD, IProductoCAD
{
public ProductoCAD() : base ()
{
}

public ProductoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProductoEN ReadOIDDefault (int id)
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}


public int Nuevo_producto (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (producto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return producto.Id;
}

public void Modify (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), producto.Id);

                productoEN.Nombre = producto.Nombre;


                productoEN.Descripcion = producto.Descripcion;


                productoEN.Precio = producto.Precio;


                productoEN.Stock = producto.Stock;

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
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
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), id);
                session.Delete (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public ProductoEN ReadOID (int id)
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProductoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProductoEN>();
                else
                        result = session.CreateCriteria (typeof(ProductoEN)).List<ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
