using Deposito.Domain;
using System.Collections.Generic;

namespace Deposito.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        long Insert(TEntity obj);
        long InsertMany(IEnumerable<TEntity> obj);
        bool Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        bool Update(TEntity obj);
    }
}
