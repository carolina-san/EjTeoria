
using System;
// Definición clase ReservaEN
namespace EjTeoriaGen.ApplicationCore.EN.Dsm_teoría
{
public partial class ReservaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo inicio
 */
private Nullable<DateTime> inicio;



/**
 *	Atributo final
 */
private Nullable<DateTime> final;



/**
 *	Atributo cliente
 */
private EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN cliente;



/**
 *	Atributo coche
 */
private EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.CocheEN coche;



/**
 *	Atributo linea_factura
 */
private EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN linea_factura;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Inicio {
        get { return inicio; } set { inicio = value;  }
}



public virtual Nullable<DateTime> Final {
        get { return final; } set { final = value;  }
}



public virtual EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}



public virtual EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.CocheEN Coche {
        get { return coche; } set { coche = value;  }
}



public virtual EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN Linea_factura {
        get { return linea_factura; } set { linea_factura = value;  }
}





public ReservaEN()
{
}



public ReservaEN(int id, Nullable<DateTime> inicio, Nullable<DateTime> final, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN cliente, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.CocheEN coche, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN linea_factura
                 )
{
        this.init (Id, inicio, final, cliente, coche, linea_factura);
}


public ReservaEN(ReservaEN reserva)
{
        this.init (reserva.Id, reserva.Inicio, reserva.Final, reserva.Cliente, reserva.Coche, reserva.Linea_factura);
}

private void init (int id
                   , Nullable<DateTime> inicio, Nullable<DateTime> final, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN cliente, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.CocheEN coche, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN linea_factura)
{
        this.Id = id;


        this.Inicio = inicio;

        this.Final = final;

        this.Cliente = cliente;

        this.Coche = coche;

        this.Linea_factura = linea_factura;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReservaEN t = obj as ReservaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
