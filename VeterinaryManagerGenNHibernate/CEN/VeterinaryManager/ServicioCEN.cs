

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
public partial class ServicioCEN
{
private IServicioCAD _IServicioCAD;

public ServicioCEN()
{
        this._IServicioCAD = new ServicioCAD ();
}

public ServicioCEN(IServicioCAD _IServicioCAD)
{
        this._IServicioCAD = _IServicioCAD;
}

public IServicioCAD get_IServicioCAD ()
{
        return this._IServicioCAD;
}

public int Nuevo_servicio (string p_nombre, string p_tipo, string p_fecha)
{
        ServicioEN servicioEN = null;
        int oid;

        //Initialized ServicioEN
        servicioEN = new ServicioEN ();
        servicioEN.Nombre = p_nombre;

        servicioEN.Tipo = p_tipo;

        servicioEN.Fecha = p_fecha;

        //Call to ServicioCAD

        oid = _IServicioCAD.Nuevo_servicio (servicioEN);
        return oid;
}

public void Modify (int p_Servicio_OID, string p_nombre, string p_tipo, string p_fecha)
{
        ServicioEN servicioEN = null;

        //Initialized ServicioEN
        servicioEN = new ServicioEN ();
        servicioEN.Id = p_Servicio_OID;
        servicioEN.Nombre = p_nombre;
        servicioEN.Tipo = p_tipo;
        servicioEN.Fecha = p_fecha;
        //Call to ServicioCAD

        _IServicioCAD.Modify (servicioEN);
}

public void Destroy (int id)
{
        _IServicioCAD.Destroy (id);
}

public ServicioEN ReadOID (int id)
{
        ServicioEN servicioEN = null;

        servicioEN = _IServicioCAD.ReadOID (id);
        return servicioEN;
}

public System.Collections.Generic.IList<ServicioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ServicioEN> list = null;

        list = _IServicioCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN> Dame_todos ()
{
        return _IServicioCAD.Dame_todos ();
}
}
}
