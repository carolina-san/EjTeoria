

using System;
using System.Text;
using System.Collections.Generic;

using EjTeoriaGen.ApplicationCore.Exceptions;

using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;


namespace EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría
{
/*
 *      Definition of the class ReservaCEN
 *
 */
public partial class ReservaCEN
{
private IReservaRepository _IReservaRepository;

public ReservaCEN(IReservaRepository _IReservaRepository)
{
        this._IReservaRepository = _IReservaRepository;
}

public IReservaRepository get_IReservaRepository ()
{
        return this._IReservaRepository;
}

public int Crear (Nullable<DateTime> p_inicio, Nullable<DateTime> p_final, string p_cliente)
{
        ReservaEN reservaEN = null;
        int oid;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.Inicio = p_inicio;

        reservaEN.Final = p_final;


        if (p_cliente != null) {
                // El argumento p_cliente -> Property cliente es oid = false
                // Lista de oids id
                reservaEN.Cliente = new EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN ();
                reservaEN.Cliente.DNI = p_cliente;
        }



        oid = _IReservaRepository.Crear (reservaEN);
        return oid;
}

public void Borrar (int id
                    )
{
        _IReservaRepository.Borrar (id);
}

public ReservaEN DameOID (int id
                          )
{
        ReservaEN reservaEN = null;

        reservaEN = _IReservaRepository.DameOID (id);
        return reservaEN;
}

public System.Collections.Generic.IList<ReservaEN> DameAll (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> list = null;

        list = _IReservaRepository.DameAll (first, size);
        return list;
}
}
}
