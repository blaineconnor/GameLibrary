using Game.Lib.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Domain.UnitofWork
{
    public interface IUnitofWork
    {
        IEpicRepository epicRepository { get; }
        ISteamRepository steamRepository { get; }
        bool CommitAsync();
        Task<IEnumerable<object>> GetAllGamesAsync();
    }
}
