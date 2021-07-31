using Deposito.Domain.Models;
using System.Collections.Generic;

namespace Deposito.Business.Interfaces
{
    public interface IProdutoBusiness
    {
        long Insert(ProdutoDomain obj);
        long InsertMany(IEnumerable<ProdutoDomain> obj);
        bool Remove(ProdutoDomain obj);
        IEnumerable<ProdutoDomain> GetAll();
        ProdutoDomain GetById(int id);
        bool Update(ProdutoDomain obj);
    }
}
