using Game.Lib.Application.Models.DTOs;
using Game.Lib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Application.Interfaces
{
    public interface IMapper 
    {
        GameDto MapToDto(SteamGame entity);

        SteamGame MapToEntity(SteamGame dto);
        
        GameDto MapToDto(EpicGame entity);
        EpicGame MapToEntity(EpicGame dto);
    }
}
