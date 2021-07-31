using Deposito.Domain.Models;
using System.Collections.Generic;


namespace Deposito.Services.Interfaces
{
    public interface IProdutoServices
    {
        long Insert(ProdutoDomain obj);
        long InsertMany(IEnumerable<ProdutoDomain> obj);
        bool Remove(ProdutoDomain obj);
        IEnumerable<ProdutoDomain> GetAll();
        ProdutoDomain GetById(int id);
        bool Update(ProdutoDomain obj);
    }
}
