using Game.Lib.Api.Models;
using Game.Lib.Infrastructure.Steam.CustomTypes;
using Game.Lib.Infrastructure.Steam.Enumerations;
using Game.Lib.Infrastructure.Steam.Services.Abstraction;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Game.Lib.Api.Controllers
{
    [ApiController]
    [Route("steam")]
    public class SteamController : ControllerBase
    {
        private readonly ISteamService _steamService;

        public SteamController(ISteamService steamService)
        {
            _steamService = steamService;
        }


        [HttpPost(Name = "gameInfo")]
        public IEnumerable<Listing> GetByCulture([FromBody]GetGameInfoRequestModel request)
        {
            var result = _steamService.GetListings(request.Game, request.Culture);
            return result;
        }
    }
}