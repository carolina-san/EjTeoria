
using System;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.CP.Dsm_teoría;

namespace EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría
{
public partial interface IFacturaRepository
{
void setSessionCP (GenericSessionCP session);

FacturaEN ReadOIDDefault (int id
                          );

void ModifyDefault (FacturaEN factura);

System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size);



int Crear (FacturaEN factura);

void Modificar (FacturaEN factura);




FacturaEN DameOID (int id
                   );


System.Collections.Generic.IList<FacturaEN> DameAll (int first, int size);
}
}
