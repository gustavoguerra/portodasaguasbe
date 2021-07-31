using Deposito.Business.Interfaces;
using Deposito.Domain;
using Deposito.Domain.Models;
using Deposito.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Business.Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        protected readonly IClienteRepository _repository;

        public ClienteBusiness(IClienteRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ClienteDomain> GetAll()
        {
            return _repository.GetAll();
        }

        public ClienteDomain GetById(int id)
        {
            return _repository.GetById(id);
        }

        public long Insert(ClienteDomain obj)
        {
            CheckedCliente(obj);

            return _repository.Insert(obj);
        }

        public long InsertMany(IEnumerable<ClienteDomain> obj)
        {
            return _repository.InsertMany(obj);
        }

        public bool Remove(ClienteDomain obj)
        {
            return _repository.Remove(obj);
        }

        public bool Update(ClienteDomain obj)
        {
            CheckedCliente(obj);
            return _repository.Update(obj);
        }

        private void CheckedCliente(ClienteDomain ClienteObj = null, IEnumerable<ClienteDomain> ListClientObj = null)
        {
            var listaCloente = new List<ClienteDomain>();

            if (ListClientObj != null)
            {
                 listaCloente = ListClientObj.ToList();
            }

            if(ClienteObj != null)
            {
                listaCloente.Add(ClienteObj);
            }

            foreach (var obj in listaCloente)
            {
                DomainException.When(string.IsNullOrEmpty(obj.ClienteNome), ErrorMessages.CLIENTENOME);
                DomainException.When(string.IsNullOrEmpty(obj.ClienteCep), ErrorMessages.CEP);
                DomainException.When(string.IsNullOrEmpty(obj.ClienteRua), ErrorMessages.LOGRADOURO);
                DomainException.When(string.IsNullOrEmpty(obj.ClienteNumero), ErrorMessages.NUMERO);
                DomainException.When(string.IsNullOrEmpty(obj.ClienteBairro), ErrorMessages.BAIRRO);
                DomainException.When(string.IsNullOrEmpty(obj.ClienteCidade), ErrorMessages.CIDADE);
                DomainException.When(string.IsNullOrEmpty(obj.ClienteEstado), ErrorMessages.ESTADO);
            }
        }
    }
}
