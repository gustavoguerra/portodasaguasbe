using Deposito.Business.Interfaces;
using Deposito.Domain.Models;
using Deposito.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Services.Services
{
    public class ProdutoServices : IProdutoServices
    {
        private readonly IProdutoBusiness _business;
        public ProdutoServices(IProdutoBusiness business)
        {
            _business = business;
        }

        public IEnumerable<ProdutoDomain> GetAll()
        {
            return _business.GetAll();
        }

        public ProdutoDomain GetById(int id)
        {
            return _business.GetById(id);
        }

        public long Insert(ProdutoDomain obj)
        {
            return _business.Insert(obj);
        }

        public long InsertMany(IEnumerable<ProdutoDomain> obj)
        {
            return _business.InsertMany(obj);
        }

        public bool Remove(ProdutoDomain obj)
        {
            return _business.Remove(obj);
        }

        public bool Update(ProdutoDomain obj)
        {
            return _business.Update(obj);
        }
    }
}
