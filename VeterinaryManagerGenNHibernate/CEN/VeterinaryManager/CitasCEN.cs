

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
public partial class CitasCEN
{
private ICitasCAD _ICitasCAD;

public CitasCEN()
{
        this._ICitasCAD = new CitasCAD ();
}

public CitasCEN(ICitasCAD _ICitasCAD)
{
        this._ICitasCAD = _ICitasCAD;
}

public ICitasCAD get_ICitasCAD ()
{
        return this._ICitasCAD;
}

public int Nueva_cita (Nullable<DateTime> p_fecha, string p_hora, int p_id)
{
        CitasEN citasEN = null;
        int oid;

        //Initialized CitasEN
        citasEN = new CitasEN ();
        citasEN.Fecha = p_fecha;

        citasEN.Hora = p_hora;

        citasEN.Id = p_id;

        //Call to CitasCAD

        oid = _ICitasCAD.Nueva_cita (citasEN);
        return oid;
}

public void Modify (int p_Citas_OID, Nullable<DateTime> p_fecha, string p_hora)
{
        CitasEN citasEN = null;

        //Initialized CitasEN
        citasEN = new CitasEN ();
        citasEN.Id = p_Citas_OID;
        citasEN.Fecha = p_fecha;
        citasEN.Hora = p_hora;
        //Call to CitasCAD

        _ICitasCAD.Modify (citasEN);
}

public void Destroy (int id)
{
        _ICitasCAD.Destroy (id);
}

public CitasEN ReadOID (int id)
{
        CitasEN citasEN = null;

        citasEN = _ICitasCAD.ReadOID (id);
        return citasEN;
}

public System.Collections.Generic.IList<CitasEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CitasEN> list = null;

        list = _ICitasCAD.ReadAll (first, size);
        return list;
}
}
}
