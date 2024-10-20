
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
 * Clase Factura:
 *
 */

namespace EjTeoriaGen.Infraestructure.Repository.Dsm_teoría
{
public partial class FacturaRepository : BasicRepository, IFacturaRepository
{
public FacturaRepository() : base ()
{
}


public FacturaRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public FacturaEN ReadOIDDefault (int id
                                 )
{
        FacturaEN facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                facturaEN = (FacturaEN)session.Get (typeof(FacturaNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(FacturaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<FacturaEN>();
                        else
                                result = session.CreateCriteria (typeof(FacturaNH)).List<FacturaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                FacturaNH facturaNH = (FacturaNH)session.Load (typeof(FacturaNH), factura.Id);

                facturaNH.Fecha = factura.Fecha;


                facturaNH.Es_pagada = factura.Es_pagada;


                facturaNH.Es_anulada = factura.Es_anulada;


                facturaNH.Total = factura.Total;



                session.Update (facturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (FacturaEN factura)
{
        FacturaNH facturaNH = new FacturaNH (factura);

        try
        {
                SessionInitializeTransaction ();
                if (factura.Cliente != null) {
                        // Argumento OID y no colección.
                        facturaNH
                        .Cliente = (EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN)session.Load (typeof(EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ClienteEN), factura.Cliente.DNI);

                        facturaNH.Cliente.Factura
                        .Add (facturaNH);
                }

                session.Save (facturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return facturaNH.Id;
}

public void Modificar (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                FacturaNH facturaNH = (FacturaNH)session.Load (typeof(FacturaNH), factura.Id);

                facturaNH.Fecha = factura.Fecha;


                facturaNH.Es_pagada = factura.Es_pagada;


                facturaNH.Es_anulada = factura.Es_anulada;


                facturaNH.Total = factura.Total;

                session.Update (facturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
//Sin e: DameOID
//Con e: FacturaEN
public FacturaEN DameOID (int id
                          )
{
        FacturaEN facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                facturaEN = (FacturaEN)session.Get (typeof(FacturaNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> DameAll (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(FacturaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<FacturaEN>();
                else
                        result = session.CreateCriteria (typeof(FacturaNH)).List<FacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
