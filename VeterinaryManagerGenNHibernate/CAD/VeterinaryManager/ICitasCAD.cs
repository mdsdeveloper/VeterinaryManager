
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface ICitasCAD
{
CitasEN ReadOIDDefault (int id);

int Nueva_cita (CitasEN citas);

void Modify (CitasEN citas);


void Destroy (int id);


CitasEN ReadOID (int id);


System.Collections.Generic.IList<CitasEN> ReadAll (int first, int size);
}
}
