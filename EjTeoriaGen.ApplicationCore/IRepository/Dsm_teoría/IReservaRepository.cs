
using System;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.CP.Dsm_teoría;

namespace EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría
{
public partial interface IReservaRepository
{
void setSessionCP (GenericSessionCP session);

ReservaEN ReadOIDDefault (int id
                          );

void ModifyDefault (ReservaEN reserva);

System.Collections.Generic.IList<ReservaEN> ReadAllDefault (int first, int size);



int Crear (ReservaEN reserva);

void Borrar (int id
             );


ReservaEN DameOID (int id
                   );


System.Collections.Generic.IList<ReservaEN> DameAll (int first, int size);
}
}
