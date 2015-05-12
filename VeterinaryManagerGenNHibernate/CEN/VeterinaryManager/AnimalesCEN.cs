

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
public partial class AnimalesCEN
{
private IAnimalesCAD _IAnimalesCAD;

public AnimalesCEN()
{
        this._IAnimalesCAD = new AnimalesCAD ();
}

public AnimalesCEN(IAnimalesCAD _IAnimalesCAD)
{
        this._IAnimalesCAD = _IAnimalesCAD;
}

public IAnimalesCAD get_IAnimalesCAD ()
{
        return this._IAnimalesCAD;
}

public string Nuevo_animal (string p_nombre, string p_id, string p_categoria, string p_raza, string p_sexo, string p_color, string p_observaciones, int p_edad)
{
        AnimalesEN animalesEN = null;
        string oid;

        //Initialized AnimalesEN
        animalesEN = new AnimalesEN ();
        animalesEN.Nombre = p_nombre;

        animalesEN.Id = p_id;

        animalesEN.Categoria = p_categoria;

        animalesEN.Raza = p_raza;

        animalesEN.Sexo = p_sexo;

        animalesEN.Color = p_color;

        animalesEN.Observaciones = p_observaciones;

        animalesEN.Edad = p_edad;

        //Call to AnimalesCAD

        oid = _IAnimalesCAD.Nuevo_animal (animalesEN);
        return oid;
}

public AnimalesEN ReadOID (string id)
{
        AnimalesEN animalesEN = null;

        animalesEN = _IAnimalesCAD.ReadOID (id);
        return animalesEN;
}

public void Modify (string p_Animales_OID, string p_nombre, string p_categoria, string p_raza, string p_sexo, string p_color, string p_observaciones, int p_edad)
{
        AnimalesEN animalesEN = null;

        //Initialized AnimalesEN
        animalesEN = new AnimalesEN ();
        animalesEN.Id = p_Animales_OID;
        animalesEN.Nombre = p_nombre;
        animalesEN.Categoria = p_categoria;
        animalesEN.Raza = p_raza;
        animalesEN.Sexo = p_sexo;
        animalesEN.Color = p_color;
        animalesEN.Observaciones = p_observaciones;
        animalesEN.Edad = p_edad;
        //Call to AnimalesCAD

        _IAnimalesCAD.Modify (animalesEN);
}

public void Destroy (string id)
{
        _IAnimalesCAD.Destroy (id);
}

public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> Dame_por_nombre (string p_nombre)
{
        return _IAnimalesCAD.Dame_por_nombre (p_nombre);
}
public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> Dame_por_raza (string p_raza)
{
        return _IAnimalesCAD.Dame_por_raza (p_raza);
}
public System.Collections.Generic.IList<AnimalesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AnimalesEN> list = null;

        list = _IAnimalesCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> Dame_todos ()
{
        return _IAnimalesCAD.Dame_todos ();
}
public void Add_cliente (string p_Animales_OID, string p_clientes_OID)
{
        //Call to AnimalesCAD

        _IAnimalesCAD.Add_cliente (p_Animales_OID, p_clientes_OID);
}
}
}
