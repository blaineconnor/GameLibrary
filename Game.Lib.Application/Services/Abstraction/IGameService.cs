using Game.Lib.Application.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Application.Services.Abstraction
{
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetAllGamesAsync();

        Task<IEnumerable<GameDto>> GetGamesBySellerAsync(string seller);

        Task<IEnumerable<GameDto>> SearchGamesByNameAsync(string name);

        Task<IEnumerable<GameDto>> GetGamesByPriceRangeAsync(double minPrice, double maxPrice);
    }
}
