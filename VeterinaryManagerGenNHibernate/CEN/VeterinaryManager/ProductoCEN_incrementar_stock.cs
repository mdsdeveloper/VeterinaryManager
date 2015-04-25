
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
public void Incrementar_stock (int p_oid, int p_cantidad)
{
        /*PROTECTED REGION ID(VeterinaryManagerGenNHibernate.CEN.VeterinaryManager_Producto_incrementar_stock) ENABLED START*/

    ProductoEN productoEN = null;
    try
    {
        if (p_cantidad != null)
        {
            productoEN = _IProductoCAD.ReadOID(p_oid);
            productoEN.Stock += p_cantidad;
            _IProductoCAD.Modify(productoEN);
        }
    }catch(Exception ex)
    {
        ex.Message.ToString();
    }
      //  throw new NotImplementedException ("Method Incrementar_stock() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
