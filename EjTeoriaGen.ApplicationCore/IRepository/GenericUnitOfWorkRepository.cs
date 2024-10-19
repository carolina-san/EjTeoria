
using System;
using System.Collections.Generic;
using System.Text;

namespace EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría
{
public abstract class GenericUnitOfWorkRepository
{
protected IClienteRepository clienterepository;
protected IReservaRepository reservarepository;
protected ICocheRepository cocherepository;
protected IFacturaRepository facturarepository;
protected ILinea_facturaRepository linea_facturarepository;


public abstract IClienteRepository ClienteRepository {
        get;
}
public abstract IReservaRepository ReservaRepository {
        get;
}
public abstract ICocheRepository CocheRepository {
        get;
}
public abstract IFacturaRepository FacturaRepository {
        get;
}
public abstract ILinea_facturaRepository Linea_facturaRepository {
        get;
}
}
}
