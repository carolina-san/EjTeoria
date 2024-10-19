

using System;
using System.Text;
using System.Collections.Generic;

using EjTeoriaGen.ApplicationCore.Exceptions;

using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;


namespace EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría
{
/*
 *      Definition of the class CocheCEN
 *
 */
public partial class CocheCEN
{
private ICocheRepository _ICocheRepository;

public CocheCEN(ICocheRepository _ICocheRepository)
{
        this._ICocheRepository = _ICocheRepository;
}

public ICocheRepository get_ICocheRepository ()
{
        return this._ICocheRepository;
}

public int Crear (EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Categoria_cocheEnum p_categoria_coche, EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Estado_cocheEnum p_estado_coche)
{
        CocheEN cocheEN = null;
        int oid;

        //Initialized CocheEN
        cocheEN = new CocheEN ();
        cocheEN.Categoria_coche = p_categoria_coche;

        cocheEN.Estado_coche = p_estado_coche;



        oid = _ICocheRepository.Crear (cocheEN);
        return oid;
}

public void Borrar (int num_licencia
                    )
{
        _ICocheRepository.Borrar (num_licencia);
}

public void Asignar_reserva (int p_Coche_OID, int p_reserva_OID)
{
        //Call to CocheRepository

        _ICocheRepository.Asignar_reserva (p_Coche_OID, p_reserva_OID);
}
public void Desasignar_reserva (int p_Coche_OID, int p_reserva_OID)
{
        //Call to CocheRepository

        _ICocheRepository.Desasignar_reserva (p_Coche_OID, p_reserva_OID);
}
public void Modificar (int p_Coche_OID, EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Categoria_cocheEnum p_categoria_coche, EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Estado_cocheEnum p_estado_coche)
{
        CocheEN cocheEN = null;

        //Initialized CocheEN
        cocheEN = new CocheEN ();
        cocheEN.Num_licencia = p_Coche_OID;
        cocheEN.Categoria_coche = p_categoria_coche;
        cocheEN.Estado_coche = p_estado_coche;
        //Call to CocheRepository

        _ICocheRepository.Modificar (cocheEN);
}

public CocheEN DameOID (int num_licencia
                        )
{
        CocheEN cocheEN = null;

        cocheEN = _ICocheRepository.DameOID (num_licencia);
        return cocheEN;
}

public System.Collections.Generic.IList<CocheEN> DameAll (int first, int size)
{
        System.Collections.Generic.IList<CocheEN> list = null;

        list = _ICocheRepository.DameAll (first, size);
        return list;
}
}
}
