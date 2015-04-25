
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string dni);

string New_ (ClienteEN cliente);

void Modify (ClienteEN cliente);


void Destroy (string dni);


ClienteEN ReadOID (string dni);


System.Collections.Generic.IList<ClienteEN> ReadAll (int first, int size);


System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClienteEN> Dame_por_nombre (string p_nombre);
}
}
