
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
 * Clase Coche:
 *
 */

namespace EjTeoriaGen.Infraestructure.Repository.Dsm_teoría
{
public partial class CocheRepository : BasicRepository, ICocheRepository
{
public CocheRepository() : base ()
{
}


public CocheRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public CocheEN ReadOIDDefault (int num_licencia
                               )
{
        CocheEN cocheEN = null;

        try
        {
                SessionInitializeTransaction ();
                cocheEN = (CocheEN)session.Get (typeof(CocheNH), num_licencia);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return cocheEN;
}

public System.Collections.Generic.IList<CocheEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CocheEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CocheNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<CocheEN>();
                        else
                                result = session.CreateCriteria (typeof(CocheNH)).List<CocheEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CocheEN coche)
{
        try
        {
                SessionInitializeTransaction ();
                CocheNH cocheNH = (CocheNH)session.Load (typeof(CocheNH), coche.Num_licencia);

                cocheNH.Categoria_coche = coche.Categoria_coche;


                cocheNH.Estado_coche = coche.Estado_coche;


                session.Update (cocheNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Crear (CocheEN coche)
{
        CocheNH cocheNH = new CocheNH (coche);

        try
        {
                SessionInitializeTransaction ();

                session.Save (cocheNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cocheNH.Num_licencia;
}

public void Borrar (int num_licencia
                    )
{
        try
        {
                SessionInitializeTransaction ();
                CocheNH cocheNH = (CocheNH)session.Load (typeof(CocheNH), num_licencia);
                session.Delete (cocheNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Asignar_reserva (int p_Coche_OID, int p_reserva_OID)
{
        EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.CocheEN cocheEN = null;
        try
        {
                SessionInitializeTransaction ();
                cocheEN = (CocheEN)session.Load (typeof(CocheNH), p_Coche_OID);
                cocheEN.Reserva = (EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN)session.Load (typeof(EjTeoriaGen.Infraestructure.EN.Dsm_teoría.ReservaNH), p_reserva_OID);

                cocheEN.Reserva.Coche = cocheEN;




                session.Update (cocheEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Desasignar_reserva (int p_Coche_OID, int p_reserva_OID)
{
        try
        {
                SessionInitializeTransaction ();
                EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.CocheEN cocheEN = null;
                cocheEN = (CocheEN)session.Load (typeof(CocheNH), p_Coche_OID);

                if (cocheEN.Reserva.Id == p_reserva_OID) {
                        cocheEN.Reserva = null;
                        EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN reservaEN = (EjTeoriaGen.ApplicationCore.EN.Dsm_teoría.ReservaEN)session.Load (typeof(EjTeoriaGen.Infraestructure.EN.Dsm_teoría.ReservaNH), p_reserva_OID);
                        reservaEN.Coche = null;
                }
                else
                        throw new ModelException ("The identifier " + p_reserva_OID + " in p_reserva_OID you are trying to unrelationer, doesn't exist in CocheEN");

                session.Update (cocheEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Modificar (CocheEN coche)
{
        try
        {
                SessionInitializeTransaction ();
                CocheNH cocheNH = (CocheNH)session.Load (typeof(CocheNH), coche.Num_licencia);

                cocheNH.Categoria_coche = coche.Categoria_coche;


                cocheNH.Estado_coche = coche.Estado_coche;

                session.Update (cocheNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
//Sin e: DameOID
//Con e: CocheEN
public CocheEN DameOID (int num_licencia
                        )
{
        CocheEN cocheEN = null;

        try
        {
                SessionInitializeTransaction ();
                cocheEN = (CocheEN)session.Get (typeof(CocheNH), num_licencia);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return cocheEN;
}

public System.Collections.Generic.IList<CocheEN> DameAll (int first, int size)
{
        System.Collections.Generic.IList<CocheEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CocheNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<CocheEN>();
                else
                        result = session.CreateCriteria (typeof(CocheNH)).List<CocheEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjTeoriaGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new EjTeoriaGen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
