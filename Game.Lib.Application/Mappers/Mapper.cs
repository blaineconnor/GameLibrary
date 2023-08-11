using Game.Lib.Application.Interfaces;
using Game.Lib.Application.Models.DTOs;
using Game.Lib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Lib.Application.Mappers
{
    public class Mapper : IMapper
    {
        public GameDto MapToDto(SteamGame entity)
        {
            var dto = new GameDto();

            dto.Id = entity.Id;
            dto.Name = entity.Name;
            dto.Price = entity.Price;
            dto.Discount = entity.Discount;
            dto.Publisher = entity.Publisher;
            dto.ImageLink = entity.ImageLink;

            return dto;
        }

        public SteamGame MapToEntity(SteamGame dto)
        {
            var entity = new SteamGame
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price,
                Discount = dto.Discount,
                Publisher = dto.Publisher,
                ImageLink = dto.ImageLink
            };

            return entity;
        }

        public GameDto MapToDto(EpicGame entity)
        {
            var dto = new GameDto();

            dto.Id = entity.Id;
            dto.Name = entity.Name;
            dto.Price = entity.Price;
            dto.Discount = entity.Discount;
            dto.Publisher = entity.Publisher;
            dto.ImageLink = entity.ImageLink;

            return dto;
        }

        public EpicGame MapToEntity(EpicGame dto)
        {
            var entity = new EpicGame
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price,
                Discount = dto.Discount,
                Publisher = dto.Publisher,
                ImageLink = dto.ImageLink
            };
            return entity;
        }
    }
}
