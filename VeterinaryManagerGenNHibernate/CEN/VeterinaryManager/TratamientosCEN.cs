

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
public partial class TratamientosCEN
{
private ITratamientosCAD _ITratamientosCAD;

public TratamientosCEN()
{
        this._ITratamientosCAD = new TratamientosCAD ();
}

public TratamientosCEN(ITratamientosCAD _ITratamientosCAD)
{
        this._ITratamientosCAD = _ITratamientosCAD;
}

public ITratamientosCAD get_ITratamientosCAD ()
{
        return this._ITratamientosCAD;
}

public string Nuevo_tratamiento (string p_nombre, float p_precio, string p_fecha_inicio, string p_fecha_fin, string p_id)
{
        TratamientosEN tratamientosEN = null;
        string oid;

        //Initialized TratamientosEN
        tratamientosEN = new TratamientosEN ();
        tratamientosEN.Nombre = p_nombre;

        tratamientosEN.Precio = p_precio;

        tratamientosEN.Fecha_inicio = p_fecha_inicio;

        tratamientosEN.Fecha_fin = p_fecha_fin;

        tratamientosEN.Id = p_id;

        //Call to TratamientosCAD

        oid = _ITratamientosCAD.Nuevo_tratamiento (tratamientosEN);
        return oid;
}

public void Modify (string p_Tratamientos_OID, string p_nombre, float p_precio, string p_fecha_inicio, string p_fecha_fin)
{
        TratamientosEN tratamientosEN = null;

        //Initialized TratamientosEN
        tratamientosEN = new TratamientosEN ();
        tratamientosEN.Id = p_Tratamientos_OID;
        tratamientosEN.Nombre = p_nombre;
        tratamientosEN.Precio = p_precio;
        tratamientosEN.Fecha_inicio = p_fecha_inicio;
        tratamientosEN.Fecha_fin = p_fecha_fin;
        //Call to TratamientosCAD

        _ITratamientosCAD.Modify (tratamientosEN);
}

public void Destroy (string id)
{
        _ITratamientosCAD.Destroy (id);
}

public TratamientosEN ReadOID (string id)
{
        TratamientosEN tratamientosEN = null;

        tratamientosEN = _ITratamientosCAD.ReadOID (id);
        return tratamientosEN;
}

public System.Collections.Generic.IList<TratamientosEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TratamientosEN> list = null;

        list = _ITratamientosCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> Dame_todos ()
{
        return _ITratamientosCAD.Dame_todos ();
}
public void Add_animal (string p_Tratamientos_OID, string p_animales_OID)
{
        //Call to TratamientosCAD

        _ITratamientosCAD.Add_animal (p_Tratamientos_OID, p_animales_OID);
}
}
}
