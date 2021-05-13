using Deposito.Business.Interfaces;
using Deposito.Domain.Models;
using Deposito.Services.Interfaces;
using System.Collections.Generic;

namespace Deposito.Services.Services
{
    public class ClienteServices : IClienteServices
    {
        protected readonly IClienteBusiness _business;

        public ClienteServices (IClienteBusiness business)
        {
            _business = business;
        }

        public IEnumerable<ClienteDomain> GetAll()
        {
            return _business.GetAll();
        }

        public ClienteDomain GetById(int id)
        {
            return _business.GetById(id);
        }

        public long Insert(ClienteDomain obj)
        {
            return _business.Insert(obj);
        }

        public long InsertMany(IEnumerable<ClienteDomain> obj)
        {
            return _business.InsertMany(obj);
        }

        public bool Remove(ClienteDomain obj)
        {
            return _business.Remove(obj);
        }

        public bool Update(ClienteDomain obj)
        {
            return _business.Update(obj);
        }
    }
}
