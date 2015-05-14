
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
public partial class ServicioCAD : BasicCAD, IServicioCAD
{
public ServicioCAD() : base ()
{
}

public ServicioCAD(ISession sessionAux) : base (sessionAux)
{
}



public ServicioEN ReadOIDDefault (int id)
{
        ServicioEN servicioEN = null;

        try
        {
                SessionInitializeTransaction ();
                servicioEN = (ServicioEN)session.Get (typeof(ServicioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return servicioEN;
}


public int Nuevo_servicio (ServicioEN servicio)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (servicio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return servicio.Id;
}

public void Modify (ServicioEN servicio)
{
        try
        {
                SessionInitializeTransaction ();
                ServicioEN servicioEN = (ServicioEN)session.Load (typeof(ServicioEN), servicio.Id);

                servicioEN.Nombre = servicio.Nombre;


                servicioEN.Tipo = servicio.Tipo;


                servicioEN.Fecha = servicio.Fecha;

                session.Update (servicioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id)
{
        try
        {
                SessionInitializeTransaction ();
                ServicioEN servicioEN = (ServicioEN)session.Load (typeof(ServicioEN), id);
                session.Delete (servicioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public ServicioEN ReadOID (int id)
{
        ServicioEN servicioEN = null;

        try
        {
                SessionInitializeTransaction ();
                servicioEN = (ServicioEN)session.Get (typeof(ServicioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return servicioEN;
}

public System.Collections.Generic.IList<ServicioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ServicioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ServicioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ServicioEN>();
                else
                        result = session.CreateCriteria (typeof(ServicioEN)).List<ServicioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN> Dame_todos ()
{
        System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ServicioEN self where FROM ServicioEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ServicioENdame_todosHQL");

                result = query.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ServicioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ServicioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
