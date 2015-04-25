
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
public partial class ClientesCAD : BasicCAD, IClientesCAD
{
public ClientesCAD() : base ()
{
}

public ClientesCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClientesEN ReadOIDDefault (string dni)
{
        ClientesEN clientesEN = null;

        try
        {
                SessionInitializeTransaction ();
                clientesEN = (ClientesEN)session.Get (typeof(ClientesEN), dni);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clientesEN;
}


public string Nuevo_cliente (ClientesEN clientes)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (clientes);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clientes.Dni;
}

public void Modify (ClientesEN clientes)
{
        try
        {
                SessionInitializeTransaction ();
                ClientesEN clientesEN = (ClientesEN)session.Load (typeof(ClientesEN), clientes.Dni);

                clientesEN.Nombre = clientes.Nombre;


                clientesEN.Apellido = clientes.Apellido;


                clientesEN.Sexo = clientes.Sexo;


                clientesEN.Telefono = clientes.Telefono;


                clientesEN.Direccion = clientes.Direccion;

                session.Update (clientesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string dni)
{
        try
        {
                SessionInitializeTransaction ();
                ClientesEN clientesEN = (ClientesEN)session.Load (typeof(ClientesEN), dni);
                session.Delete (clientesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public ClientesEN ReadOID (string dni)
{
        ClientesEN clientesEN = null;

        try
        {
                SessionInitializeTransaction ();
                clientesEN = (ClientesEN)session.Get (typeof(ClientesEN), dni);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clientesEN;
}

public System.Collections.Generic.IList<ClientesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ClientesEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ClientesEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ClientesEN>();
                else
                        result = session.CreateCriteria (typeof(ClientesEN)).List<ClientesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN> Dame_por_nombre (string p_nombre)
{
        System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ClientesEN self where select cli FROM ClientesEN as cli where cli.Nombre =: p_nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ClientesENdame_por_nombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN> Dame_por_citas (Nullable<DateTime> p_fecha)
{
        System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ClientesEN self where select cli FROM ClientesEN as cli inner join cli.Citas as citas where citas.Fecha =:p_fecha";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ClientesENdame_por_citasHQL");
                query.SetParameter ("p_fecha", p_fecha);

                result = query.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClientesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClientesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
