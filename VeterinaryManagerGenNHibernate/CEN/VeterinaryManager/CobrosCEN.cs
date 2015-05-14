

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
public partial class CobrosCEN
{
private ICobrosCAD _ICobrosCAD;

public CobrosCEN()
{
        this._ICobrosCAD = new CobrosCAD ();
}

public CobrosCEN(ICobrosCAD _ICobrosCAD)
{
        this._ICobrosCAD = _ICobrosCAD;
}

public ICobrosCAD get_ICobrosCAD ()
{
        return this._ICobrosCAD;
}

public int Nuevo_cobro (string p_descripcion, string p_fecha, float p_precio)
{
        CobrosEN cobrosEN = null;
        int oid;

        //Initialized CobrosEN
        cobrosEN = new CobrosEN ();
        cobrosEN.Descripcion = p_descripcion;

        cobrosEN.Fecha = p_fecha;

        cobrosEN.Precio = p_precio;

        //Call to CobrosCAD

        oid = _ICobrosCAD.Nuevo_cobro (cobrosEN);
        return oid;
}

public void Modify (int p_Cobros_OID, string p_descripcion, string p_fecha, float p_precio)
{
        CobrosEN cobrosEN = null;

        //Initialized CobrosEN
        cobrosEN = new CobrosEN ();
        cobrosEN.Id = p_Cobros_OID;
        cobrosEN.Descripcion = p_descripcion;
        cobrosEN.Fecha = p_fecha;
        cobrosEN.Precio = p_precio;
        //Call to CobrosCAD

        _ICobrosCAD.Modify (cobrosEN);
}

public void Destroy (int id)
{
        _ICobrosCAD.Destroy (id);
}
}
}
