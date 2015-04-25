
using System;
using System.Text;
using VeterinaryManagerGenNHibernate.CEN.VeterinaryManager;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;
using VeterinaryManagerGenNHibernate.Exceptions;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial class UsuariosCAD : BasicCAD, IUsuariosCAD
{
public UsuariosCAD() : base ()
{
}

public UsuariosCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuariosEN ReadOIDDefault (string contraseña)
{
        UsuariosEN usuariosEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuariosEN = (UsuariosEN)session.Get (typeof(UsuariosEN), contraseña);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in UsuariosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuariosEN;
}


public string Nuevo_usuario (UsuariosEN usuarios)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuarios);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in UsuariosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarios.Contraseña;
}

public void Modify (UsuariosEN usuarios)
{
        try
        {
                SessionInitializeTransaction ();
                UsuariosEN usuariosEN = (UsuariosEN)session.Load (typeof(UsuariosEN), usuarios.Contraseña);

                usuariosEN.Nombre = usuarios.Nombre;

                session.Update (usuariosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in UsuariosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string contraseña)
{
        try
        {
                SessionInitializeTransaction ();
                UsuariosEN usuariosEN = (UsuariosEN)session.Load (typeof(UsuariosEN), contraseña);
                session.Delete (usuariosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in UsuariosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public UsuariosEN ReadOID (string contraseña)
{
        UsuariosEN usuariosEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuariosEN = (UsuariosEN)session.Get (typeof(UsuariosEN), contraseña);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in UsuariosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuariosEN;
}

public System.Collections.Generic.IList<UsuariosEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuariosEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuariosEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuariosEN>();
                else
                        result = session.CreateCriteria (typeof(UsuariosEN)).List<UsuariosEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in UsuariosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
