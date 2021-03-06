
using System;

namespace VeterinaryManagerGenNHibernate.EN.VeterinaryManager
{
public partial class TratamientosEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private float precio;

/**
 *
 */

private string fecha_inicio;

/**
 *
 */

private string fecha_fin;

/**
 *
 */

private string id;

/**
 *
 */

private VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN animales;

/**
 *
 */

private System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN> cobros;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual float Precio {
        get { return precio; } set { precio = value;  }
}


public virtual string Fecha_inicio {
        get { return fecha_inicio; } set { fecha_inicio = value;  }
}


public virtual string Fecha_fin {
        get { return fecha_fin; } set { fecha_fin = value;  }
}


public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN Animales {
        get { return animales; } set { animales = value;  }
}


public virtual System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN> Cobros {
        get { return cobros; } set { cobros = value;  }
}





public TratamientosEN()
{
        cobros = new System.Collections.Generic.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN>();
}



public TratamientosEN(string id, string nombre, float precio, string fecha_inicio, string fecha_fin, VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN animales, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN> cobros)
{
        this.init (id, nombre, precio, fecha_inicio, fecha_fin, animales, cobros);
}


public TratamientosEN(TratamientosEN tratamientos)
{
        this.init (tratamientos.Id, tratamientos.Nombre, tratamientos.Precio, tratamientos.Fecha_inicio, tratamientos.Fecha_fin, tratamientos.Animales, tratamientos.Cobros);
}

private void init (string id, string nombre, float precio, string fecha_inicio, string fecha_fin, VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN animales, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN> cobros)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Precio = precio;

        this.Fecha_inicio = fecha_inicio;

        this.Fecha_fin = fecha_fin;

        this.Animales = animales;

        this.Cobros = cobros;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TratamientosEN t = obj as TratamientosEN;
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
