
using System;

namespace VeterinaryManagerGenNHibernate.EN.VeterinaryManager
{
public partial class UsuarioEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string contraseña;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Contraseña {
        get { return contraseña; } set { contraseña = value;  }
}





public UsuarioEN()
{
}



public UsuarioEN(string contraseña, string nombre)
{
        this.init (contraseña, nombre);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Contraseña, usuario.Nombre);
}

private void init (string contraseña, string nombre)
{
        this.Contraseña = contraseña;


        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Contraseña.Equals (t.Contraseña))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Contraseña.GetHashCode ();
        return hash;
}
}
}
