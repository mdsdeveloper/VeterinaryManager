
using System;

namespace VeterinaryManagerGenNHibernate.EN.VeterinaryManager
{
public partial class ServicioEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string tipo;

/**
 *
 */

private string fecha;

/**
 *
 */

private int id;

/**
 *
 */

private System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN> cobros;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Tipo {
        get { return tipo; } set { tipo = value;  }
}


public virtual string Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN> Cobros {
        get { return cobros; } set { cobros = value;  }
}





public ServicioEN()
{
        cobros = new System.Collections.Generic.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN>();
}



public ServicioEN(int id, string nombre, string tipo, string fecha, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN> cobros)
{
        this.init (id, nombre, tipo, fecha, cobros);
}


public ServicioEN(ServicioEN servicio)
{
        this.init (servicio.Id, servicio.Nombre, servicio.Tipo, servicio.Fecha, servicio.Cobros);
}

private void init (int id, string nombre, string tipo, string fecha, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CobrosEN> cobros)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Tipo = tipo;

        this.Fecha = fecha;

        this.Cobros = cobros;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ServicioEN t = obj as ServicioEN;
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
