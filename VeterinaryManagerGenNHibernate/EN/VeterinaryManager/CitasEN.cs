
using System;

namespace VeterinaryManagerGenNHibernate.EN.VeterinaryManager
{
public partial class CitasEN
{
/**
 *
 */

private string fecha;

/**
 *
 */

private string hora;

/**
 *
 */

private int id;

/**
 *
 */

private VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN clientes;





public virtual string Fecha {
        get { return fecha; } set { fecha = value;  }
}


public virtual string Hora {
        get { return hora; } set { hora = value;  }
}


public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN Clientes {
        get { return clientes; } set { clientes = value;  }
}





public CitasEN()
{
}



public CitasEN(int id, string fecha, string hora, VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN clientes)
{
        this.init (id, fecha, hora, clientes);
}


public CitasEN(CitasEN citas)
{
        this.init (citas.Id, citas.Fecha, citas.Hora, citas.Clientes);
}

private void init (int id, string fecha, string hora, VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN clientes)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Hora = hora;

        this.Clientes = clientes;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CitasEN t = obj as CitasEN;
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
