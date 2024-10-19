
using System;
// Definición clase Linea_facturaEN
namespace EjTeoriaGen.ApplicationCore.EN.Dsm_teoría
{
public partial class Linea_facturaEN
{
/**
 *	Atributo num_linea
 */
private int num_linea;



/**
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo reserva
 */
private EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN reserva;



/**
 *	Atributo factura
 */
private EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.FacturaEN factura;






public virtual int Num_linea {
        get { return num_linea; } set { num_linea = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN Reserva {
        get { return reserva; } set { reserva = value;  }
}



public virtual EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}





public Linea_facturaEN()
{
}



public Linea_facturaEN(int num_linea, double precio, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN reserva, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.FacturaEN factura
                       )
{
        this.init (Num_linea, precio, reserva, factura);
}


public Linea_facturaEN(Linea_facturaEN linea_factura)
{
        this.init (linea_factura.Num_linea, linea_factura.Precio, linea_factura.Reserva, linea_factura.Factura);
}

private void init (int num_linea
                   , double precio, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN reserva, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.FacturaEN factura)
{
        this.Num_linea = num_linea;


        this.Precio = precio;

        this.Reserva = reserva;

        this.Factura = factura;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Linea_facturaEN t = obj as Linea_facturaEN;
        if (t == null)
                return false;
        if (Num_linea.Equals (t.Num_linea))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Num_linea.GetHashCode ();
        return hash;
}
}
}
