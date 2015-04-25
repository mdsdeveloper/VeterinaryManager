

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
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string Nuevo_usuario (string p_nombre, string p_contraseña)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nombre = p_nombre;

        usuarioEN.Contraseña = p_contraseña;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.Nuevo_usuario (usuarioEN);
        return oid;
}

public void Modify (string p_Usuario_OID, string p_nombre)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Contraseña = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (string contraseña)
{
        _IUsuarioCAD.Destroy (contraseña);
}

public UsuarioEN ReadOID (string contraseña)
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.ReadOID (contraseña);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.ReadAll (first, size);
        return list;
}
}
}
