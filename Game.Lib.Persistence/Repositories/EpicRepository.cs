using EpicGamesStoreNET;
using Game.Lib.Domain.Entities;
using Game.Lib.Domain.Repositories;
using Game.Lib.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Persistence.Repositories
{
    public class EpicRepository : IRepository<EpicGame>
    {
        private readonly GameLibContext gameLibContext;
        private EpicGame sGame;

        public EpicRepository(GameLibContext context)
        {
            gameLibContext = context;
        }

        public EpicGame Get(int id)
        {
            Query.Search(id.ToString());
            sGame = new EpicGame()
            {
                Id = id,
            };
            gameLibContext.Add(sGame);
            return sGame;
        }

        public EpicGame Get(string name)
        {
            Query.Search(name);
            sGame = new EpicGame()
            {
                Name = name,
            };
            gameLibContext.Add(sGame);
            return sGame;
        }      

        public IEnumerable<EpicGame> GetAll()
        {
            throw new NotImplementedException();
        }

        #region IRepository Implement

        Task IRepository<EpicGame>.Add(EpicGame entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository<EpicGame>.AnyAsync(Expression<Func<EpicGame, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task IRepository<EpicGame>.Delete(EpicGame entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<EpicGame>.Delete(object id)
        {
            throw new NotImplementedException();
        }

        SteamGame IRepository<EpicGame>.Get(string name)
        {
            throw new NotImplementedException();
        }

        IEnumerable<EpicGame> IRepository<EpicGame>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<EpicGame>> IRepository<EpicGame>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<EpicGame>> IRepository<EpicGame>.GetByFilterAsync(Expression<Func<EpicGame, bool>> filter)
        {
            throw new NotImplementedException();
        }

        Task<EpicGame> IRepository<EpicGame>.GetById(object id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<EpicGame>.Update(EpicGame entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
