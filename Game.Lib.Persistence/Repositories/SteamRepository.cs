using Game.Lib.Domain.Entities;
using Game.Lib.Domain.Repositories;
using Game.Lib.Persistence.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SteamStoreQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Persistence.Repositories
{
    public class SteamRepository : IRepository<SteamGame>
    {
        private readonly GameLibContext gameLibContext;
        private SteamGame sGame;

        public SteamRepository(GameLibContext context)
        {
            gameLibContext = context;
        }

        public SteamGame Get(int id)
        {
            Query.Search(id.ToString());
            sGame = new SteamGame()
            {
                Id = id,
            };
            gameLibContext.Add(sGame);
            return sGame;
        }

        public SteamGame Get(string name)
        {
            Query.Search(name);
            sGame = new SteamGame()
            {
                Name = name,
            };
            gameLibContext.Add(sGame);
            return sGame;
        }

       
        public IEnumerable<SteamGame> GetAll()
        {
            throw new NotImplementedException();
        }


        #region IRepository Implement
        Task IRepository<SteamGame>.Add(SteamGame entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository<SteamGame>.AnyAsync(Expression<Func<SteamGame, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task IRepository<SteamGame>.Delete(SteamGame entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<SteamGame>.Delete(object id)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<SteamGame>> IRepository<SteamGame>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<SteamGame>> IRepository<SteamGame>.GetByFilterAsync(Expression<Func<SteamGame, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task<SteamGame> IRepository<SteamGame>.GetById(object id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<SteamGame>.Update(SteamGame entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
