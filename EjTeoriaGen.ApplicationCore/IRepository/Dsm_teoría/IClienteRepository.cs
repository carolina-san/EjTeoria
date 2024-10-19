
using System;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.CP.Dsm_teoría;

namespace EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría
{
public partial interface IClienteRepository
{
void setSessionCP (GenericSessionCP session);

ClienteEN ReadOIDDefault (string DNI
                          );

void ModifyDefault (ClienteEN cliente);

System.Collections.Generic.IList<ClienteEN> ReadAllDefault (int first, int size);



string Crear (ClienteEN cliente);

void Modificar (ClienteEN cliente);


void Borrar (string DNI
             );



ClienteEN DameOID (string DNI
                   );


System.Collections.Generic.IList<ClienteEN> DameALL (int first, int size);
}
}
