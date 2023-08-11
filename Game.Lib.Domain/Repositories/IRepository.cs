﻿using Game.Lib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Domain.Repositories
{
    public interface IRepository<T> 
        where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        SteamGame Get(string name);

        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
        Task<T> GetById(object id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Delete(object id);
    }
}
