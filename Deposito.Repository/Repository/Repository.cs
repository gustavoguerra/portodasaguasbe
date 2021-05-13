using Dapper.Contrib.Extensions;
using Deposito.Domain;
using Deposito.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Deposito.Repository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly IConfiguration _config;
        protected IDbConnection Conn => new SqlConnection(_config.GetConnectionString("SqlConnection"));

        public Repository(IConfiguration config)
        {
            _config = config;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Conn.GetAll<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            return Conn.Get<TEntity>(id);
        }

        public virtual long Insert(TEntity obj)
        {
            return Conn.Insert(obj);
        }

        public virtual long InsertMany(IEnumerable<TEntity> obj)
        {
           return Conn.Insert(obj);
        }

        public virtual bool Remove(TEntity obj)
        {
            return Conn.Delete(obj);
        }

        public virtual bool Update(TEntity obj)
        {
            return Conn.Update(obj);
        }
    }
}
