
using System;

namespace VeterinaryManagerGenNHibernate.EN.VeterinaryManager
{
public partial class ProductoEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private string descripcion;

/**
 *
 */

private float precio;

/**
 *
 */

private int stock;

/**
 *
 */

private int id;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}


public virtual float Precio {
        get { return precio; } set { precio = value;  }
}


public virtual int Stock {
        get { return stock; } set { stock = value;  }
}


public virtual int Id {
        get { return id; } set { id = value;  }
}





public ProductoEN()
{
}



public ProductoEN(int id, string nombre, string descripcion, float precio, int stock)
{
        this.init (id, nombre, descripcion, precio, stock);
}


public ProductoEN(ProductoEN producto)
{
        this.init (producto.Id, producto.Nombre, producto.Descripcion, producto.Precio, producto.Stock);
}

private void init (int id, string nombre, string descripcion, float precio, int stock)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Precio = precio;

        this.Stock = stock;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
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
