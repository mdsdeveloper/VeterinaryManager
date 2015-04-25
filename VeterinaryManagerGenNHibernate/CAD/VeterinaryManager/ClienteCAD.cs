
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
public partial class ClienteCAD : BasicCAD, IClienteCAD
{
public ClienteCAD() : base ()
{
}

public ClienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClienteEN ReadOIDDefault (string dni)
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), dni);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}


public string New_ (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cliente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cliente.Dni;
}

public void Modify (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), cliente.Dni);

                clienteEN.Nombre = cliente.Nombre;


                clienteEN.Apellido = cliente.Apellido;


                clienteEN.Sexo = cliente.Sexo;


                clienteEN.Telefono = cliente.Telefono;


                clienteEN.Direccion = cliente.Direccion;

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
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
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), dni);
                session.Delete (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public ClienteEN ReadOID (string dni)
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), dni);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}

public System.Collections.Generic.IList<ClienteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ClienteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ClienteEN>();
                else
                        result = session.CreateCriteria (typeof(ClienteEN)).List<ClienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClienteEN> Dame_por_nombre (string p_nombre)
{
        System.Collections.Generic.IList<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClienteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ClienteEN self where select cli FROM ClienteEN as cli where cli.Nombre =: p_nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ClienteENdame_por_nombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<VeterinaryManagerGenNHibernate.EN.VeterinaryManager.ClienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is VeterinaryManagerGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new VeterinaryManagerGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
