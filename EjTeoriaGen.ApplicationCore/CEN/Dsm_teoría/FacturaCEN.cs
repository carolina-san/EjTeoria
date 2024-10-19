

using System;
using System.Text;
using System.Collections.Generic;

using EjTeoriaGen.ApplicationCore.Exceptions;

using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;


namespace EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría
{
/*
 *      Definition of the class FacturaCEN
 *
 */
public partial class FacturaCEN
{
private IFacturaRepository _IFacturaRepository;

public FacturaCEN(IFacturaRepository _IFacturaRepository)
{
        this._IFacturaRepository = _IFacturaRepository;
}

public IFacturaRepository get_IFacturaRepository ()
{
        return this._IFacturaRepository;
}

public int Crear (Nullable<DateTime> p_fecha, bool p_es_pagada, bool p_es_anulada, float p_total, System.Collections.Generic.IList<EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN> p_linea_factura, string p_cliente)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Fecha = p_fecha;

        facturaEN.Es_pagada = p_es_pagada;

        facturaEN.Es_anulada = p_es_anulada;

        facturaEN.Total = p_total;

        facturaEN.Linea_factura = p_linea_factura;


        if (p_cliente != null) {
                // El argumento p_cliente -> Property cliente es oid = false
                // Lista de oids id
                facturaEN.Cliente = new EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN ();
                facturaEN.Cliente.DNI = p_cliente;
        }



        oid = _IFacturaRepository.Crear (facturaEN);
        return oid;
}

public void Modificar (int p_Factura_OID, Nullable<DateTime> p_fecha, bool p_es_pagada, bool p_es_anulada, float p_total)
{
        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_Factura_OID;
        facturaEN.Fecha = p_fecha;
        facturaEN.Es_pagada = p_es_pagada;
        facturaEN.Es_anulada = p_es_anulada;
        facturaEN.Total = p_total;
        //Call to FacturaRepository

        _IFacturaRepository.Modificar (facturaEN);
}

public FacturaEN DameOID (int id
                          )
{
        FacturaEN facturaEN = null;

        facturaEN = _IFacturaRepository.DameOID (id);
        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> DameAll (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> list = null;

        list = _IFacturaRepository.DameAll (first, size);
        return list;
}
}
}
