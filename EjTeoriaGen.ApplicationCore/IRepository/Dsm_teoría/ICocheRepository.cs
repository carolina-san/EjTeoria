
using System;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.CP.Dsm_teoría;

namespace EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría
{
public partial interface ICocheRepository
{
void setSessionCP (GenericSessionCP session);

CocheEN ReadOIDDefault (int num_licencia
                        );

void ModifyDefault (CocheEN coche);

System.Collections.Generic.IList<CocheEN> ReadAllDefault (int first, int size);



int Crear (CocheEN coche);

void Borrar (int num_licencia
             );


void Asignar_reserva (int p_Coche_OID, int p_reserva_OID);

void Desasignar_reserva (int p_Coche_OID, int p_reserva_OID);



void Modificar (CocheEN coche);


CocheEN DameOID (int num_licencia
                 );


System.Collections.Generic.IList<CocheEN> DameAll (int first, int size);
}
}
