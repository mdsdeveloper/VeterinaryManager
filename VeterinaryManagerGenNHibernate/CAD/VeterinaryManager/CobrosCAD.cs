
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
public partial class CobrosCAD : BasicCAD, ICobrosCAD
{
public CobrosCAD() : base ()
{
}

public CobrosCAD(ISession sessionAux) : base (sessionAux)
{
}



public CobrosEN ReadOIDDefault (int id)
{
        CobrosEN cobrosEN = null;

        try
        {
                SessionInitializeTransaction ();
                cobrosEN = (CobrosEN)session.Get (typeof(CobrosEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CobrosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cobrosEN;
}


public int Nuevo_cobro (CobrosEN cobros)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cobros);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CobrosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cobros.Id;
}

public void Modify (CobrosEN cobros)
{
        try
        {
                SessionInitializeTransaction ();
                CobrosEN cobrosEN = (CobrosEN)session.Load (typeof(CobrosEN), cobros.Id);

                cobrosEN.Descripcion = cobros.Descripcion;


                cobrosEN.Fecha = cobros.Fecha;


                cobrosEN.Precio = cobros.Precio;

                session.Update (cobrosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CobrosCAD.", ex);
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
                CobrosEN cobrosEN = (CobrosEN)session.Load (typeof(CobrosEN), id);
                session.Delete (cobrosEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in CobrosCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
