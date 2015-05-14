
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
public partial class TratamientosCAD : BasicCAD, ITratamientosCAD
{
public TratamientosCAD() : base ()
{
}

public TratamientosCAD(ISession sessionAux) : base (sessionAux)
{
}



public TratamientosEN ReadOIDDefault (string id)
{
        TratamientosEN tratamientosEN = null;

        try
        {
                SessionInitializeTransaction ();
                tratamientosEN = (TratamientosEN)session.Get (typeof(TratamientosEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in TratamientosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tratamientosEN;
}


public string Nuevo_tratamiento (TratamientosEN tratamientos)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (tratamientos);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in TratamientosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tratamientos.Id;
}

public void Modify (TratamientosEN tratamientos)
{
        try
        {
                SessionInitializeTransaction ();
                TratamientosEN tratamientosEN = (TratamientosEN)session.Load (typeof(TratamientosEN), tratamientos.Id);

                tratamientosEN.Nombre = tratamientos.Nombre;


                tratamientosEN.Precio = tratamientos.Precio;


                tratamientosEN.Fecha_inicio = tratamientos.Fecha_inicio;


                tratamientosEN.Fecha_fin = tratamientos.Fecha_fin;

                session.Update (tratamientosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in TratamientosCAD.", ex);
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
                TratamientosEN tratamientosEN = (TratamientosEN)session.Load (typeof(TratamientosEN), id);
                session.Delete (tratamientosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in TratamientosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public TratamientosEN ReadOID (string id)
{
        TratamientosEN tratamientosEN = null;

        try
        {
                SessionInitializeTransaction ();
                tratamientosEN = (TratamientosEN)session.Get (typeof(TratamientosEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in TratamientosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tratamientosEN;
}

public System.Collections.Generic.IList<TratamientosEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TratamientosEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TratamientosEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TratamientosEN>();
                else
                        result = session.CreateCriteria (typeof(TratamientosEN)).List<TratamientosEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in TratamientosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> Dame_todos ()
{
        System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TratamientosEN self where FROM TratamientosEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TratamientosENdame_todosHQL");

                result = query.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in TratamientosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Add_animal (string p_Tratamientos_OID, string p_animales_OID)
{
        VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN tratamientosEN = null;
        try
        {
                SessionInitializeTransaction ();
                tratamientosEN = (TratamientosEN)session.Load (typeof(TratamientosEN), p_Tratamientos_OID);
                tratamientosEN.Animales = (VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN)session.Load (typeof(VeterinaryManagerGenNHibernate.EN.VeterinaryManager.AnimalesEN), p_animales_OID);

                tratamientosEN.Animales.Tratamientos.Add (tratamientosEN);



                session.Update (tratamientosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in TratamientosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> Dame_por_nombre (string p_nombre)
{
        System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TratamientosEN self where select tra FROM TratamientosEN tra where tra.Nombre=:p_nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TratamientosENdame_por_nombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.TratamientosEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in TratamientosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
