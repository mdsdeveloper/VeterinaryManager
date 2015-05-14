
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface ICobrosCAD
{
CobrosEN ReadOIDDefault (int id);

int Nuevo_cobro (CobrosEN cobros);

void Modify (CobrosEN cobros);


void Destroy (int id);
}
}
