using Deposito.Domain.Models;
using System.Collections.Generic;

namespace Deposito.Business.Interfaces
{
    public interface IClienteBusiness
    {
        long Insert(ClienteDomain obj);
        long InsertMany(IEnumerable<ClienteDomain> obj);
        bool Remove(ClienteDomain obj);
        IEnumerable<ClienteDomain> GetAll();
        ClienteDomain GetById(int id);
        bool Update(ClienteDomain obj);
    }
}
