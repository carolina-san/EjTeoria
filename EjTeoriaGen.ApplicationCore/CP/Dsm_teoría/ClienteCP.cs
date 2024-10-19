
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
public partial class ClienteCP : GenericBasicCP
{
public ClienteCP(GenericSessionCP currentSession)
        : base (currentSession)
{
}

public ClienteCP(GenericSessionCP currentSession, GenericUnitOfWorkUtils unitUtils)
        : base (currentSession, unitUtils)
{
}
}
}
