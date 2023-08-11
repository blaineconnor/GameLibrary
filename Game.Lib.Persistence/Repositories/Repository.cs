using Game.Lib.Domain.Entities;
using Game.Lib.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Persistence.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        public Repository()
        {

        }       
        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public SteamGame Get(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        #region IRepository Implement

        Task IRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository<T>.AnyAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.Delete(object id)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<T>> IRepository<T>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<T>> IRepository<T>.GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.GetById(object id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
