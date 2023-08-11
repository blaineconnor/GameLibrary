using Game.Lib.Infrastructure.Steam.CustomTypes;
using Game.Lib.Infrastructure.Steam.Enumerations;

namespace Game.Lib.Infrastructure.Steam.Services.Abstraction
{
    public interface ICultureService
    {
        CultureValue GetCultureValue(Culture culture);
    }
}
