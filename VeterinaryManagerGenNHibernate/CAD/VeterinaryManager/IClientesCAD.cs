
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface IClientesCAD
{
ClientesEN ReadOIDDefault (string dni);

string Nuevo_cliente (ClientesEN clientes);

void Modify (ClientesEN clientes);


void Destroy (string dni);


ClientesEN ReadOID (string dni);


System.Collections.Generic.IList<ClientesEN> ReadAll (int first, int size);


System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN> Dame_por_nombre (string p_nombre);


System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN> Dame_por_citas (Nullable<DateTime> p_fecha);
}
}
