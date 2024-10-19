
using System;
using System.Text;
using System.Collections.Generic;
using EjTeoriaGen.ApplicationCore.Exceptions;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;


/*PROTECTED REGION ID(usingEjTeoriaGen.ApplicationCore.CEN.Dsm_teoría_Coche_reservar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría
{
public partial class CocheCEN
{
public void Reservar (int p_oid)
{
        /*PROTECTED REGION ID(EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría_Coche_reservar) ENABLED START*/

        CocheEN en = _ICocheRepository.ReadOIDDefault (p_oid);

        if (en.Estado_coche == Enumerated.Dsm_teoría.Estado_cocheEnum.libre) {
                en.Estado_coche = Enumerated.Dsm_teoría.Estado_cocheEnum.alquilado;
                _ICocheRepository.Modificar (en);
        }
        else{
                throw new Exception ("El coche no está libre");
        }

        /*PROTECTED REGION END*/
}
}
}
