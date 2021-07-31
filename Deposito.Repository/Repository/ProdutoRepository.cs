using Deposito.Domain.Models;
using Deposito.Repository.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Deposito.Repository.Repository
{
    public class ProdutoRepository : Repository<ProdutoDomain>, IProdutoRepository
    {
        public ProdutoRepository(IConfiguration config) : base(config)
        {

        }
    }
}
