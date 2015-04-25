
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
public partial class UsuarioCEN
{
public bool Login (string p_contraseña, string p_nombre)
{
        /*PROTECTED REGION ID(VeterinaryManagerGenNHibernate.CEN.VeterinaryManager_Usuario_login) ENABLED START*/

        bool resultado = false;
        UsuarioEN usuarioEN = null;

        try
        {
                if (p_contraseña != null && p_nombre != null) {
                        usuarioEN = _IUsuarioCAD.ReadOID (p_contraseña);
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
