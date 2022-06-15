using AutoMapper;
using ShopItemApi.Dtos;
using ShopItemApi.Models;

namespace ShopItemApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ShopItem, ShopItemDto>().ReverseMap();
        }
    }
}
