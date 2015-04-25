
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
public partial class CitasCAD : BasicCAD, ICitasCAD
{
public CitasCAD() : base ()
{
}

public CitasCAD(ISession sessionAux) : base (sessionAux)
{
}



public CitasEN ReadOIDDefault (int id)
{
        CitasEN citasEN = null;

        try
        {
                SessionInitializeTransaction ();
                citasEN = (CitasEN)session.Get (typeof(CitasEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CitasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return citasEN;
}


public int Nueva_cita (CitasEN citas)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (citas);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CitasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return citas.Id;
}

public void Modify (CitasEN citas)
{
        try
        {
                SessionInitializeTransaction ();
                CitasEN citasEN = (CitasEN)session.Load (typeof(CitasEN), citas.Id);

                citasEN.Fecha = citas.Fecha;


                citasEN.Hora = citas.Hora;

                session.Update (citasEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CitasCAD.", ex);
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
                CitasEN citasEN = (CitasEN)session.Load (typeof(CitasEN), id);
                session.Delete (citasEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CitasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public CitasEN ReadOID (int id)
{
        CitasEN citasEN = null;

        try
        {
                SessionInitializeTransaction ();
                citasEN = (CitasEN)session.Get (typeof(CitasEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CitasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return citasEN;
}

public System.Collections.Generic.IList<CitasEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CitasEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CitasEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CitasEN>();
                else
                        result = session.CreateCriteria (typeof(CitasEN)).List<CitasEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CitasCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
