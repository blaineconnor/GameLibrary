using Game.Lib.Infrastructure.Steam.Enumerations;

namespace Game.Lib.Api.Models
{
    public class GetGameInfoRequestModel
    {
        public string Game { get; set; }
        public Culture Culture { get; set; }
    }
}
