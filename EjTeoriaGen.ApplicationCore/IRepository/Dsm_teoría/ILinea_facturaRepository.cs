
using System;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.CP.Dsm_teoría;

namespace EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría
{
public partial interface ILinea_facturaRepository
{
void setSessionCP (GenericSessionCP session);

Linea_facturaEN ReadOIDDefault (int num_linea
                                );

void ModifyDefault (Linea_facturaEN linea_factura);

System.Collections.Generic.IList<Linea_facturaEN> ReadAllDefault (int first, int size);



int Crear (Linea_facturaEN linea_factura);

Linea_facturaEN DameOID (int num_linea
                         );


System.Collections.Generic.IList<Linea_facturaEN> DameAll (int first, int size);
}
}
