

using System;
using System.Text;
using System.Collections.Generic;

using EjTeoriaGen.ApplicationCore.Exceptions;

using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;


namespace EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría
{
/*
 *      Definition of the class Linea_facturaCEN
 *
 */
public partial class Linea_facturaCEN
{
private ILinea_facturaRepository _ILinea_facturaRepository;

public Linea_facturaCEN(ILinea_facturaRepository _ILinea_facturaRepository)
{
        this._ILinea_facturaRepository = _ILinea_facturaRepository;
}

public ILinea_facturaRepository get_ILinea_facturaRepository ()
{
        return this._ILinea_facturaRepository;
}

public int Crear (double p_precio, int p_reserva, int p_factura)
{
        Linea_facturaEN linea_facturaEN = null;
        int oid;

        //Initialized Linea_facturaEN
        linea_facturaEN = new Linea_facturaEN ();
        linea_facturaEN.Precio = p_precio;


        if (p_reserva != -1) {
                // El argumento p_reserva -> Property reserva es oid = false
                // Lista de oids num_linea
                linea_facturaEN.Reserva = new EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN ();
                linea_facturaEN.Reserva.Id = p_reserva;
        }


        if (p_factura != -1) {
                // El argumento p_factura -> Property factura es oid = false
                // Lista de oids num_linea
                linea_facturaEN.Factura = new EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.FacturaEN ();
                linea_facturaEN.Factura.Id = p_factura;
        }



        oid = _ILinea_facturaRepository.Crear (linea_facturaEN);
        return oid;
}

public Linea_facturaEN DameOID (int num_linea
                                )
{
        Linea_facturaEN linea_facturaEN = null;

        linea_facturaEN = _ILinea_facturaRepository.DameOID (num_linea);
        return linea_facturaEN;
}

public System.Collections.Generic.IList<Linea_facturaEN> DameAll (int first, int size)
{
        System.Collections.Generic.IList<Linea_facturaEN> list = null;

        list = _ILinea_facturaRepository.DameAll (first, size);
        return list;
}
}
}
