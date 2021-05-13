using Deposito.Domain.Models;
using System.Collections.Generic;

namespace Deposito.Services.Interfaces
{
    public interface IClienteServices
    {
        long Insert(ClienteDomain obj);
        long InsertMany(IEnumerable<ClienteDomain> obj);
        bool Remove(ClienteDomain obj);
        IEnumerable<ClienteDomain> GetAll();
        ClienteDomain GetById(int id);
        bool Update(ClienteDomain obj);
    }
}
