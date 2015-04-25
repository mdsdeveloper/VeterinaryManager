
using System;

namespace VeterinaryManagerGenNHibernate.EN.VeterinaryManager
{
public partial class ClienteEN
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

private string sexo;

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





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Apellido {
        get { return apellido; } set { apellido = value;  }
}


public virtual string Sexo {
        get { return sexo; } set { sexo = value;  }
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





public ClienteEN()
{
}



public ClienteEN(string dni, string nombre, string apellido, string sexo, string telefono, string direccion)
{
        this.init (dni, nombre, apellido, sexo, telefono, direccion);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.Dni, cliente.Nombre, cliente.Apellido, cliente.Sexo, cliente.Telefono, cliente.Direccion);
}

private void init (string dni, string nombre, string apellido, string sexo, string telefono, string direccion)
{
        this.Dni = dni;


        this.Nombre = nombre;

        this.Apellido = apellido;

        this.Sexo = sexo;

        this.Telefono = telefono;

        this.Direccion = direccion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
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
