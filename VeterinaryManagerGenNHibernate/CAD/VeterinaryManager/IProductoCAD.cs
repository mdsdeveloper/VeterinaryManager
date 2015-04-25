
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (int id);

int Nuevo_producto (ProductoEN producto);

void Modify (ProductoEN producto);


void Destroy (int id);


ProductoEN ReadOID (int id);


System.Collections.Generic.IList<ProductoEN> ReadAll (int first, int size);
}
}
