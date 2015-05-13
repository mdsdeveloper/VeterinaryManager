
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface ITratamientosCAD
{
TratamientosEN ReadOIDDefault (string id);

string Nuevo_tratamiento (TratamientosEN tratamientos);

void Modify (TratamientosEN tratamientos);


void Destroy (string id);


TratamientosEN ReadOID (string id);


System.Collections.Generic.IList<TratamientosEN> ReadAll (int first, int size);


System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> Dame_todos ();


void Add_animal (string p_Tratamientos_OID, string p_animales_OID);
}
}
