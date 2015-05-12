
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
public partial class AnimalesCAD : BasicCAD, IAnimalesCAD
{
public AnimalesCAD() : base ()
{
}

public AnimalesCAD(ISession sessionAux) : base (sessionAux)
{
}



public AnimalesEN ReadOIDDefault (string id)
{
        AnimalesEN animalesEN = null;

        try
        {
                SessionInitializeTransaction ();
                animalesEN = (AnimalesEN)session.Get (typeof(AnimalesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return animalesEN;
}


public string Nuevo_animal (AnimalesEN animales)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (animales);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return animales.Id;
}

public AnimalesEN ReadOID (string id)
{
        AnimalesEN animalesEN = null;

        try
        {
                SessionInitializeTransaction ();
                animalesEN = (AnimalesEN)session.Get (typeof(AnimalesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return animalesEN;
}

public void Modify (AnimalesEN animales)
{
        try
        {
                SessionInitializeTransaction ();
                AnimalesEN animalesEN = (AnimalesEN)session.Load (typeof(AnimalesEN), animales.Id);

                animalesEN.Nombre = animales.Nombre;


                animalesEN.Categoria = animales.Categoria;


                animalesEN.Raza = animales.Raza;


                animalesEN.Sexo = animales.Sexo;


                animalesEN.Color = animales.Color;


                animalesEN.Observaciones = animales.Observaciones;


                animalesEN.Edad = animales.Edad;

                session.Update (animalesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string id)
{
        try
        {
                SessionInitializeTransaction ();
                AnimalesEN animalesEN = (AnimalesEN)session.Load (typeof(AnimalesEN), id);
                session.Delete (animalesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> Dame_por_nombre (string p_nombre)
{
        System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AnimalesEN self where select an FROM AnimalesEN an where an.Nombre=:p_nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AnimalesENdame_por_nombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> Dame_por_raza (string p_raza)
{
        System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AnimalesEN self where select an FROM AnimalesEN an where an.Raza=:p_raza";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AnimalesENdame_por_razaHQL");
                query.SetParameter ("p_raza", p_raza);

                result = query.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<AnimalesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AnimalesEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AnimalesEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AnimalesEN>();
                else
                        result = session.CreateCriteria (typeof(AnimalesEN)).List<AnimalesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> Dame_todos ()
{
        System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AnimalesEN self where  FROM AnimalesEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AnimalesENdame_todosHQL");

                result = query.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Add_cliente (string p_Animales_OID, string p_clientes_OID)
{
        VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN animalesEN = null;
        try
        {
                SessionInitializeTransaction ();
                animalesEN = (AnimalesEN)session.Load (typeof(AnimalesEN), p_Animales_OID);
                animalesEN.Clientes = (VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN)session.Load (typeof(VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN), p_clientes_OID);

                animalesEN.Clientes.Animales.Add (animalesEN);



                session.Update (animalesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in AnimalesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
