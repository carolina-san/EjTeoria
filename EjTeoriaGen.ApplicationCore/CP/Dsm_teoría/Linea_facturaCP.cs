
using System;
using System.Text;
using System.Collections.Generic;
using EjTeoriaGen.ApplicationCore.Exceptions;
using EjTeoriaGen.ApplicationCore.EN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.CEN.Dsm_teoría;
using EjTeoriaGen.ApplicationCore.Utils;



namespace EjTeoriaGen.ApplicationCore.CP.Dsm_teoría
{
public partial class Linea_facturaCP : GenericBasicCP
{
public Linea_facturaCP(GenericSessionCP currentSession)
        : base (currentSession)
{
}

public Linea_facturaCP(GenericSessionCP currentSession, GenericUnitOfWorkUtils unitUtils)
        : base (currentSession, unitUtils)
{
}
}
}
