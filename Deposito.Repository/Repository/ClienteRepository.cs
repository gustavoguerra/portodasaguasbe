using Deposito.Domain.Models;
using Deposito.Repository.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Deposito.Repository.Repository
{
    public class ClienteRepository : Repository<ClienteDomain> , IClienteRepository
    {
        public ClienteRepository(IConfiguration config) : base(config)
        {

        }
    }
}
