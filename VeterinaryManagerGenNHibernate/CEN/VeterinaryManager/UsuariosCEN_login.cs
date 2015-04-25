
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
public bool Login (string p_contraseña, string p_nombre)
{
        /*PROTECTED REGION ID(VeterinaryManagerGenNHibernate.CEN.VeterinaryManager_Usuarios_login) ENABLED START*/

        bool resultado = false;
        UsuariosEN usuarioEN = null;

        try
        {
                if (p_contraseña != null && p_nombre != null) {
                        usuarioEN = _IUsuariosCAD.ReadOID (p_contraseña);
                        if (usuarioEN.Nombre == p_nombre) {
                                resultado = true;
                        }
                }
        }
        catch (Exception ex)
        {
                ex.Message.ToString ();
        }

        return resultado;
        /*PROTECTED REGION END*/
}
}
}
