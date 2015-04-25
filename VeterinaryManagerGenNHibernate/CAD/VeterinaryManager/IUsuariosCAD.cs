
using System;
using VeterinaryManagerGenNHibernate.EN.VeterinaryManager;

namespace VeterinaryManagerGenNHibernate.CAD.VeterinaryManager
{
public partial interface IUsuariosCAD
{
UsuariosEN ReadOIDDefault (string contraseña);

string Nuevo_usuario (UsuariosEN usuarios);

void Modify (UsuariosEN usuarios);


void Destroy (string contraseña);


UsuariosEN ReadOID (string contraseña);


System.Collections.Generic.IList<UsuariosEN> ReadAll (int first, int size);
}
}
