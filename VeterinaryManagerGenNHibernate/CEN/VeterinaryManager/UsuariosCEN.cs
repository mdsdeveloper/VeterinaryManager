

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
public partial class UsuariosCEN
{
private IUsuariosCAD _IUsuariosCAD;

public UsuariosCEN()
{
        this._IUsuariosCAD = new UsuariosCAD ();
}

public UsuariosCEN(IUsuariosCAD _IUsuariosCAD)
{
        this._IUsuariosCAD = _IUsuariosCAD;
}

public IUsuariosCAD get_IUsuariosCAD ()
{
        return this._IUsuariosCAD;
}

public string Nuevo_usuario (string p_nombre, string p_contraseña)
{
        UsuariosEN usuariosEN = null;
        string oid;

        //Initialized UsuariosEN
        usuariosEN = new UsuariosEN ();
        usuariosEN.Nombre = p_nombre;

        usuariosEN.Contraseña = p_contraseña;

        //Call to UsuariosCAD

        oid = _IUsuariosCAD.Nuevo_usuario (usuariosEN);
        return oid;
}

public void Modify (string p_Usuarios_OID, string p_nombre)
{
        UsuariosEN usuariosEN = null;

        //Initialized UsuariosEN
        usuariosEN = new UsuariosEN ();
        usuariosEN.Contraseña = p_Usuarios_OID;
        usuariosEN.Nombre = p_nombre;
        //Call to UsuariosCAD

        _IUsuariosCAD.Modify (usuariosEN);
}

public void Destroy (string contraseña)
{
        _IUsuariosCAD.Destroy (contraseña);
}

public UsuariosEN ReadOID (string contraseña)
{
        UsuariosEN usuariosEN = null;

        usuariosEN = _IUsuariosCAD.ReadOID (contraseña);
        return usuariosEN;
}

public System.Collections.Generic.IList<UsuariosEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuariosEN> list = null;

        list = _IUsuariosCAD.ReadAll (first, size);
        return list;
}
}
}
