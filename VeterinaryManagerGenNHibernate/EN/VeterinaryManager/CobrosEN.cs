
using System;

namespace VeterinaryManagerGenNHibernate.EN.VeterinaryManager
{
public partial class CobrosEN
{
/**
 *
 */

private string descripcion;

/**
 *
 */

private string fecha;

/**
 *
 */

private float precio;

/**
 *
 */

private int id;

/**
 *
 */

private System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> tratamientos;

/**
 *
 */

private System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN> servicio;





public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual string Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual float Precio {
        get { return precio; } set { precio = value;  }
}


public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> Tratamientos {
        get { return tratamientos; } set { tratamientos = value;  }
}


public virtual System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN> Servicio {
        get { return servicio; } set { servicio = value;  }
}





public CobrosEN()
{
        tratamientos = new System.Collections.Generic.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN>();
        servicio = new System.Collections.Generic.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN>();
}



public CobrosEN(int id, string descripcion, string fecha, float precio, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> tratamientos, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN> servicio)
{
        this.init (id, descripcion, fecha, precio, tratamientos, servicio);
}


public CobrosEN(CobrosEN cobros)
{
        this.init (cobros.Id, cobros.Descripcion, cobros.Fecha, cobros.Precio, cobros.Tratamientos, cobros.Servicio);
}

private void init (int id, string descripcion, string fecha, float precio, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> tratamientos, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN> servicio)
{
        this.Id = id;


        this.Descripcion = descripcion;

        this.Fecha = fecha;

        this.Precio = precio;

        this.Tratamientos = tratamientos;

        this.Servicio = servicio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CobrosEN t = obj as CobrosEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
