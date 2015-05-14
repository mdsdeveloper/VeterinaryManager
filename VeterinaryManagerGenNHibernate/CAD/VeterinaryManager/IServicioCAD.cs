
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface IServicioCAD
{
ServicioEN ReadOIDDefault (int id);

int Nuevo_servicio (ServicioEN servicio);

void Modify (ServicioEN servicio);


void Destroy (int id);


ServicioEN ReadOID (int id);


System.Collections.Generic.IList<ServicioEN> ReadAll (int first, int size);


System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN> Dame_todos ();
}
}
