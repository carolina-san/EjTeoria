
using System;
using System.Text;
using System.Collections.Generic;
using EjTeoriaGen.ApplicationCore.Exceptions;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;


/*PROTECTED REGION ID(usingEjTeoriaGen.ApplicationCore.CEN.Dsm_teoría_Factura_anular) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría
{
public partial class FacturaCEN
{
public void Anular (int p_Factura_OID)
{
        /*PROTECTED REGION ID(EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría_Factura_anular) ENABLED START*/
        FacturaEN en = _IFacturaRepository.ReadOIDDefault (p_Factura_OID);

        if (en.Es_anulada == false) {
                en.Es_anulada = true;
                _IFacturaRepository.Modificar (en);
            }
            else
            {
                throw new Exception("La factura ya está anulada");
            }


        /*PROTECTED REGION END*/
}
}
}
