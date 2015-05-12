
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface IAnimalesCAD
{
AnimalesEN ReadOIDDefault (string id);

string Nuevo_animal (AnimalesEN animales);

AnimalesEN ReadOID (string id);


void Modify (AnimalesEN animales);


void Destroy (string id);


System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> Dame_por_nombre (string p_nombre);


System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> Dame_por_raza (string p_raza);


System.Collections.Generic.IList<AnimalesEN> ReadAll (int first, int size);


System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> Dame_todos ();


void Add_cliente (string p_Animales_OID, string p_clientes_OID);
}
}
