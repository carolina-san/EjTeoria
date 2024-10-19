

using EjTeoriaGen.ApplicationCore.IRepository.Dsm_teoría;
using EjTeoriaGen.Infraestructure.Repository.Dsm_teoría;
using EjTeoriaGen.Infraestructure.CP;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjTeoriaGen.Infraestructure.Repository
{
public class UnitOfWorkRepository : GenericUnitOfWorkRepository
{
SessionCPNHibernate session;


public UnitOfWorkRepository(SessionCPNHibernate session)
{
        this.session = session;
}

public override IClienteRepository ClienteRepository {
        get
        {
                this.clienterepository = new ClienteRepository ();
                this.clienterepository.setSessionCP (session);
                return this.clienterepository;
        }
}

public override IReservaRepository ReservaRepository {
        get
        {
                this.reservarepository = new ReservaRepository ();
                this.reservarepository.setSessionCP (session);
                return this.reservarepository;
        }
}

public override ICocheRepository CocheRepository {
        get
        {
                this.cocherepository = new CocheRepository ();
                this.cocherepository.setSessionCP (session);
                return this.cocherepository;
        }
}

public override IFacturaRepository FacturaRepository {
        get
        {
                this.facturarepository = new FacturaRepository ();
                this.facturarepository.setSessionCP (session);
                return this.facturarepository;
        }
}

public override ILinea_facturaRepository Linea_facturaRepository {
        get
        {
                this.linea_facturarepository = new Linea_facturaRepository ();
                this.linea_facturarepository.setSessionCP (session);
                return this.linea_facturarepository;
        }
}
}
}

