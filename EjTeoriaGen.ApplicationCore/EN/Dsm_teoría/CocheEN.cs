
using System;
// Definición clase CocheEN
namespace EjTeoriaGen.ApplicationCore.EN.Dsm_teoría
{
public partial class CocheEN
{
/**
 *	Atributo num_licencia
 */
private int num_licencia;



/**
 *	Atributo categoria_coche
 */
private EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Categoria_cocheEnum categoria_coche;



/**
 *	Atributo estado_coche
 */
private EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Estado_cocheEnum estado_coche;



/**
 *	Atributo reserva
 */
private EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN reserva;






public virtual int Num_licencia {
        get { return num_licencia; } set { num_licencia = value;  }
}



public virtual EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Categoria_cocheEnum Categoria_coche {
        get { return categoria_coche; } set { categoria_coche = value;  }
}



public virtual EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Estado_cocheEnum Estado_coche {
        get { return estado_coche; } set { estado_coche = value;  }
}



public virtual EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN Reserva {
        get { return reserva; } set { reserva = value;  }
}





public CocheEN()
{
}



public CocheEN(int num_licencia, EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Categoria_cocheEnum categoria_coche, EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Estado_cocheEnum estado_coche, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN reserva
               )
{
        this.init (Num_licencia, categoria_coche, estado_coche, reserva);
}


public CocheEN(CocheEN coche)
{
        this.init (coche.Num_licencia, coche.Categoria_coche, coche.Estado_coche, coche.Reserva);
}

private void init (int num_licencia
                   , EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Categoria_cocheEnum categoria_coche, EjTeoriaGen.ApplicationCore.Enumerated.Dsm_teoría.Estado_cocheEnum estado_coche, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN reserva)
{
        this.Num_licencia = num_licencia;


        this.Categoria_coche = categoria_coche;

        this.Estado_coche = estado_coche;

        this.Reserva = reserva;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CocheEN t = obj as CocheEN;
        if (t == null)
                return false;
        if (Num_licencia.Equals (t.Num_licencia))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Num_licencia.GetHashCode ();
        return hash;
}
}
}
