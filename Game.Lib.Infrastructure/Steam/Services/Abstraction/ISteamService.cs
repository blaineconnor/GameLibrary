using Game.Lib.Infrastructure.Steam.CustomTypes;
using Game.Lib.Infrastructure.Steam.Enumerations;

namespace Game.Lib.Infrastructure.Steam.Services.Abstraction
{
    public interface ISteamService
    {

        List<Listing> GetListings(string game, Culture culture);
    }
}
