
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
public void Decrementar_stock (int p_oid, int p_cantidad)
{
        /*PROTECTED REGION ID(VeterinaryManagerGenNHibernate.CEN.VeterinaryManager_Productos_decrementar_stock) ENABLED START*/
        ProductosEN productoEN = null;

        try
        {
                productoEN = _IProductosCAD.ReadOID (p_oid);
                if (p_cantidad != null) {
                        if (productoEN.Stock >= p_cantidad) {
                                productoEN.Stock -= p_cantidad;
                                _IProductosCAD.Modify (productoEN);
                                Console.WriteLine ("Se ha descontado correctamente");
                        }
                        else{
                                Console.WriteLine ("No hay productos");
                        }
                }
        }
        catch (Exception ex)
        {
                ex.Message.ToString ();
        }

        //    throw new NotImplementedException ("Method Decrementar_stock() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
