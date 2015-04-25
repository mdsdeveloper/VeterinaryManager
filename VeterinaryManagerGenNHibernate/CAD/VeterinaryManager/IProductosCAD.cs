
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface IProductosCAD
{
ProductosEN ReadOIDDefault (int id);

int Nuevo_producto (ProductosEN productos);

void Modify (ProductosEN productos);


void Destroy (int id);


ProductosEN ReadOID (int id);


System.Collections.Generic.IList<ProductosEN> ReadAll (int first, int size);
}
}
