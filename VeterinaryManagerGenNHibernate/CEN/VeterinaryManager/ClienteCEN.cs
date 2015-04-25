

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
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public string New_ (string p_nombre, string p_apellido, string p_sexo, string p_telefono, string p_direccion, string p_dni)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Nombre = p_nombre;

        clienteEN.Apellido = p_apellido;

        clienteEN.Sexo = p_sexo;

        clienteEN.Telefono = p_telefono;

        clienteEN.Direccion = p_direccion;

        clienteEN.Dni = p_dni;

        //Call to ClienteCAD

        oid = _IClienteCAD.New_ (clienteEN);
        return oid;
}

public void Modify (string p_Cliente_OID, string p_nombre, string p_apellido, string p_sexo, string p_telefono, string p_direccion)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.Dni = p_Cliente_OID;
        clienteEN.Nombre = p_nombre;
        clienteEN.Apellido = p_apellido;
        clienteEN.Sexo = p_sexo;
        clienteEN.Telefono = p_telefono;
        clienteEN.Direccion = p_direccion;
        //Call to ClienteCAD

        _IClienteCAD.Modify (clienteEN);
}

public void Destroy (string dni)
{
        _IClienteCAD.Destroy (dni);
}

public ClienteEN ReadOID (string dni)
{
        ClienteEN clienteEN = null;

        clienteEN = _IClienteCAD.ReadOID (dni);
        return clienteEN;
}

public System.Collections.Generic.IList<ClienteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> list = null;

        list = _IClienteCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClienteEN> Dame_por_nombre (string p_nombre)
{
        return _IClienteCAD.Dame_por_nombre (p_nombre);
}
}
}
