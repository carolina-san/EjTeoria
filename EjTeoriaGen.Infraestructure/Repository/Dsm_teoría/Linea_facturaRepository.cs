
using System;
using System.Text;
using EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.Exceptions;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.CP.Dsm_teoría;
using EjTeoriaGen.Infraestructure.EN.Dsm_teoría;


/*
 * Clase Linea_factura:
 *
 */

namespace EjTeoriaGen.Infraestructure.Repository.Dsm_teoría
{
public partial class Linea_facturaRepository : BasicRepository, ILinea_facturaRepository
{
public Linea_facturaRepository() : base ()
{
}


public Linea_facturaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public Linea_facturaEN ReadOIDDefault (int num_linea
                                       )
{
        Linea_facturaEN linea_facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                linea_facturaEN = (Linea_facturaEN)session.Get (typeof(Linea_facturaNH), num_linea);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return linea_facturaEN;
}

public System.Collections.Generic.IList<Linea_facturaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<Linea_facturaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(Linea_facturaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<Linea_facturaEN>();
                        else
                                result = session.CreateCriteria (typeof(Linea_facturaNH)).List<Linea_facturaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in Linea_facturaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (Linea_facturaEN linea_factura)
{
        try
        {
                SessionInitializeTransaction ();
                Linea_facturaNH linea_facturaNH = (Linea_facturaNH)session.Load (typeof(Linea_facturaNH), linea_factura.Num_linea);

                linea_facturaNH.Precio = linea_factura.Precio;



                session.Update (linea_facturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in Linea_facturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (Linea_facturaEN linea_factura)
{
        Linea_facturaNH linea_facturaNH = new Linea_facturaNH (linea_factura);

        try
        {
                SessionInitializeTransaction ();
                if (linea_factura.Reserva != null) {
                        // Argumento OID y no colección.
                        linea_facturaNH
                        .Reserva = (EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN)session.Load (typeof(EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN), linea_factura.Reserva.Id);

                        linea_facturaNH.Reserva.Linea_factura
                                = linea_facturaNH;
                }
                if (linea_factura.Factura != null) {
                        // Argumento OID y no colección.
                        linea_facturaNH
                        .Factura = (EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.FacturaEN)session.Load (typeof(EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.FacturaEN), linea_factura.Factura.Id);

                        linea_facturaNH.Factura.Linea_factura
                        .Add (linea_facturaNH);
                }

                session.Save (linea_facturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in Linea_facturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return linea_facturaNH.Num_linea;
}

//Sin e: DameOID
//Con e: Linea_facturaEN
public Linea_facturaEN DameOID (int num_linea
                                )
{
        Linea_facturaEN linea_facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                linea_facturaEN = (Linea_facturaEN)session.Get (typeof(Linea_facturaNH), num_linea);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return linea_facturaEN;
}

public System.Collections.Generic.IList<Linea_facturaEN> DameAll (int first, int size)
{
        System.Collections.Generic.IList<Linea_facturaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(Linea_facturaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<Linea_facturaEN>();
                else
                        result = session.CreateCriteria (typeof(Linea_facturaNH)).List<Linea_facturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in Linea_facturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
