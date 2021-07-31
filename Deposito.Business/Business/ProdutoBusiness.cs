using Deposito.Business.Interfaces;
using Deposito.Domain;
using Deposito.Domain.Models;
using Deposito.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace Deposito.Business.Business
{
    public class ProdutoBusiness : IProdutoBusiness
    {
        protected readonly IProdutoRepository _repository;

        public ProdutoBusiness(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ProdutoDomain> GetAll()
        {
            return _repository.GetAll();
        }

        public ProdutoDomain GetById(int id)
        {
            return _repository.GetById(id);
        }

        public long Insert(ProdutoDomain obj)
        {
            CheckProduto(obj);
            return _repository.Insert(obj);
        }

        public long InsertMany(IEnumerable<ProdutoDomain> obj)
        {
            CheckProduto(null,obj);
            return _repository.InsertMany(obj);
        }

        public bool Remove(ProdutoDomain obj)
        {
            return _repository.Remove(obj);
        }

        public bool Update(ProdutoDomain obj)
        {
            CheckProduto(obj);
            return _repository.Update(obj);
        }
        private void CheckProduto(ProdutoDomain ClienteObj = null, IEnumerable<ProdutoDomain> ListClientObj = null)
        {
            var listaCloente = new List<ProdutoDomain>();

            if (ListClientObj != null)
            {
                listaCloente = ListClientObj.ToList();
            }

            if (ClienteObj != null)
            {
                listaCloente.Add(ClienteObj);
            }

            foreach (var obj in listaCloente)
            {
                DomainException.When(string.IsNullOrEmpty(obj.ProdutoNome), ErrorMessages.PRODUTONOME);
                DomainException.When(obj.ProdutoValor <= 0, ErrorMessages.PRODUTOVALOR);
            }
        }

    }
}
