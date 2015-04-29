
using System;

namespace VeterinaryManagerGenNHibernate.EN.VeterinaryManager
{
public partial class ClientesEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string apellido;

/**
 *
 */

private string email;

/**
 *
 */

private string telefono;

/**
 *
 */

private string direccion;

/**
 *
 */

private string dni;

/**
 *
 */

private System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CitasEN> citas;

/**
 *
 */

private Nullable<DateTime> fecha;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Apellido {
        get { return apellido; } set { apellido = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}


public virtual string Dni {
        get { return dni; } set { dni = value;  }
}


public virtual System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CitasEN> Citas {
        get { return citas; } set { citas = value;  }
}


public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}





public ClientesEN()
{
        citas = new System.Collections.Generic.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CitasEN>();
}



public ClientesEN(string dni, string nombre, string apellido, string email, string telefono, string direccion, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CitasEN> citas, Nullable<DateTime> fecha)
{
        this.init (dni, nombre, apellido, email, telefono, direccion, citas, fecha);
}


public ClientesEN(ClientesEN clientes)
{
        this.init (clientes.Dni, clientes.Nombre, clientes.Apellido, clientes.Email, clientes.Telefono, clientes.Direccion, clientes.Citas, clientes.Fecha);
}

private void init (string dni, string nombre, string apellido, string email, string telefono, string direccion, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.CitasEN> citas, Nullable<DateTime> fecha)
{
        this.Dni = dni;


        this.Nombre = nombre;

        this.Apellido = apellido;

        this.Email = email;

        this.Telefono = telefono;

        this.Direccion = direccion;

        this.Citas = citas;

        this.Fecha = fecha;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClientesEN t = obj as ClientesEN;
        if (t == null)
                return false;
        if (Dni.Equals (t.Dni))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Dni.GetHashCode ();
        return hash;
}
}
}
