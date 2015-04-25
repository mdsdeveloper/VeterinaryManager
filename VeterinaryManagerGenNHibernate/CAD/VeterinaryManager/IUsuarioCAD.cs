
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string contraseña);

string Nuevo_usuario (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (string contraseña);


UsuarioEN ReadOID (string contraseña);


System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size);
}
}
