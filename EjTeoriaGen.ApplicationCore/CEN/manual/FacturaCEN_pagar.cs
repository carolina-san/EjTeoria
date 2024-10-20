
using System;
using System.Text;
using System.Collections.Generic;
using EjTeoriaGen.ApplicationCore.Exceptions;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;


/*PROTECTED REGION ID(usingEjTeoriaGen.ApplicationCore.CEN.Dsm_teoría_Factura_pagar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría
{
public partial class FacturaCEN
{
public void Pagar (int p_oid)
{
            /*PROTECTED REGION ID(EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría_Factura_pagar) ENABLED START*/

            // Write here your custom code...

            FacturaEN en = _IFacturaRepository.ReadOIDDefault(p_oid);

            if (en.Es_pagada == false)
            {
                en.Es_pagada = true;
                _IFacturaRepository.Modificar(en);
            }
            else
            {
                throw new Exception("La factura ya está pagada");
            }

            /*PROTECTED REGION END*/
        }
}
}
