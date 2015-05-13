
using System;

namespace VeterinaryManagerGenNHibernate.EN.VeterinaryManager
{
public partial class AnimalesEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string id;

/**
 *
 */

private VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN clientes;

/**
 *
 */

private string categoria;

/**
 *
 */

private string raza;

/**
 *
 */

private string sexo;

/**
 *
 */

private string color;

/**
 *
 */

private string observaciones;

/**
 *
 */

private int edad;

/**
 *
 */

private System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> tratamientos;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Id {
        get { return id; } set { id = value;  }
}


public virtual VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN Clientes {
        get { return clientes; } set { clientes = value;  }
}


public virtual string Categoria {
        get { return categoria; } set { categoria = value;  }
}


public virtual string Raza {
        get { return raza; } set { raza = value;  }
}


public virtual string Sexo {
        get { return sexo; } set { sexo = value;  }
}


public virtual string Color {
        get { return color; } set { color = value;  }
}


public virtual string Observaciones {
        get { return observaciones; } set { observaciones = value;  }
}


public virtual int Edad {
        get { return edad; } set { edad = value;  }
}


public virtual System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> Tratamientos {
        get { return tratamientos; } set { tratamientos = value;  }
}





public AnimalesEN()
{
        tratamientos = new System.Collections.Generic.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN>();
}



public AnimalesEN(string id, string nombre, VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN clientes, string categoria, string raza, string sexo, string color, string observaciones, int edad, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> tratamientos)
{
        this.init (id, nombre, clientes, categoria, raza, sexo, color, observaciones, edad, tratamientos);
}


public AnimalesEN(AnimalesEN animales)
{
        this.init (animales.Id, animales.Nombre, animales.Clientes, animales.Categoria, animales.Raza, animales.Sexo, animales.Color, animales.Observaciones, animales.Edad, animales.Tratamientos);
}

private void init (string id, string nombre, VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN clientes, string categoria, string raza, string sexo, string color, string observaciones, int edad, System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> tratamientos)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Clientes = clientes;

        this.Categoria = categoria;

        this.Raza = raza;

        this.Sexo = sexo;

        this.Color = color;

        this.Observaciones = observaciones;

        this.Edad = edad;

        this.Tratamientos = tratamientos;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AnimalesEN t = obj as AnimalesEN;
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
