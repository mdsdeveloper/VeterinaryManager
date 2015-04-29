

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
public partial class ClientesCEN
{
private IClientesCAD _IClientesCAD;

public ClientesCEN()
{
        this._IClientesCAD = new ClientesCAD ();
}

public ClientesCEN(IClientesCAD _IClientesCAD)
{
        this._IClientesCAD = _IClientesCAD;
}

public IClientesCAD get_IClientesCAD ()
{
        return this._IClientesCAD;
}

public string Nuevo_cliente (string p_nombre, string p_apellido, string p_dni, string p_telefono, string p_direccion, string p_email, Nullable<DateTime> p_fecha)
{
        ClientesEN clientesEN = null;
        string oid;

        //Initialized ClientesEN
        clientesEN = new ClientesEN ();
        clientesEN.Nombre = p_nombre;

        clientesEN.Apellido = p_apellido;

        clientesEN.Dni = p_dni;

        clientesEN.Telefono = p_telefono;

        clientesEN.Direccion = p_direccion;

        clientesEN.Email = p_email;

        clientesEN.Fecha = p_fecha;

        //Call to ClientesCAD

        oid = _IClientesCAD.Nuevo_cliente (clientesEN);
        return oid;
}

public void Modify (string p_Clientes_OID, string p_nombre, string p_apellido, string p_email, string p_telefono, string p_direccion, Nullable<DateTime> p_fecha)
{
        ClientesEN clientesEN = null;

        //Initialized ClientesEN
        clientesEN = new ClientesEN ();
        clientesEN.Dni = p_Clientes_OID;
        clientesEN.Nombre = p_nombre;
        clientesEN.Apellido = p_apellido;
        clientesEN.Email = p_email;
        clientesEN.Telefono = p_telefono;
        clientesEN.Direccion = p_direccion;
        clientesEN.Fecha = p_fecha;
        //Call to ClientesCAD

        _IClientesCAD.Modify (clientesEN);
}

public void Destroy (string dni)
{
        _IClientesCAD.Destroy (dni);
}

public ClientesEN ReadOID (string dni)
{
        ClientesEN clientesEN = null;

        clientesEN = _IClientesCAD.ReadOID (dni);
        return clientesEN;
}

public System.Collections.Generic.IList<ClientesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ClientesEN> list = null;

        list = _IClientesCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN> Dame_por_nombre (string p_nombre)
{
        return _IClientesCAD.Dame_por_nombre (p_nombre);
}
public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN> Dame_por_citas (Nullable<DateTime> p_fecha)
{
        return _IClientesCAD.Dame_por_citas (p_fecha);
}
}
}
