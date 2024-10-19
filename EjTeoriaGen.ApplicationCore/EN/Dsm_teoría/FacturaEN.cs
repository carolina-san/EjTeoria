
using System;
// Definición clase FacturaEN
namespace EjTeoriaGen.ApplicationCore.EN.Dsm_teoría
{
public partial class FacturaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo es_pagada
 */
private bool es_pagada;



/**
 *	Atributo es_anulada
 */
private bool es_anulada;



/**
 *	Atributo total
 */
private float total;



/**
 *	Atributo linea_factura
 */
private System.Collections.Generic.IList<EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN> linea_factura;



/**
 *	Atributo cliente
 */
private EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN cliente;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual bool Es_pagada {
        get { return es_pagada; } set { es_pagada = value;  }
}



public virtual bool Es_anulada {
        get { return es_anulada; } set { es_anulada = value;  }
}



public virtual float Total {
        get { return total; } set { total = value;  }
}



public virtual System.Collections.Generic.IList<EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN> Linea_factura {
        get { return linea_factura; } set { linea_factura = value;  }
}



public virtual EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}





public FacturaEN()
{
        linea_factura = new System.Collections.Generic.List<EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN>();
}



public FacturaEN(int id, Nullable<DateTime> fecha, bool es_pagada, bool es_anulada, float total, System.Collections.Generic.IList<EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN> linea_factura, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN cliente
                 )
{
        this.init (Id, fecha, es_pagada, es_anulada, total, linea_factura, cliente);
}


public FacturaEN(FacturaEN factura)
{
        this.init (factura.Id, factura.Fecha, factura.Es_pagada, factura.Es_anulada, factura.Total, factura.Linea_factura, factura.Cliente);
}

private void init (int id
                   , Nullable<DateTime> fecha, bool es_pagada, bool es_anulada, float total, System.Collections.Generic.IList<EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.Linea_facturaEN> linea_factura, EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN cliente)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Es_pagada = es_pagada;

        this.Es_anulada = es_anulada;

        this.Total = total;

        this.Linea_factura = linea_factura;

        this.Cliente = cliente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
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
