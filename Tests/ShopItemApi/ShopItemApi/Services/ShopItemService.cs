using AutoMapper;
using ShopItemApi.Dtos;
using ShopItemApi.Helpers;
using ShopItemApi.Models;
using ShopItemApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopItemApi.Services
{
    public class ShopItemService
    {
        private readonly IShopItemRepository _shopItemRepository;
        private readonly IMapper _mapper;

        public ShopItemService(IShopItemRepository shopItemRepository, IMapper mapper)
        {
            _shopItemRepository = shopItemRepository;
            _mapper = mapper;
        }

        public async Task<List<ShopItemDto>> GetAll()
        {
            var entities = await _shopItemRepository.GetAll();

            //var dtos = entities.Select(e => new ShopItemDto
            //{
            //    Id = e.Id,
            //    Name = e.Name,
            //    LastName = e.LastName,
            //    Created = e.Created
            //}).ToList();

            List<ShopItemDto> dtos = _mapper.Map<List<ShopItemDto>>(entities);

            return dtos;
        }

        public async Task<ShopItemDto> GetById(int id)
        {
            var shopItem = await _shopItemRepository.GetById(id);



            var dto = _mapper.Map<ShopItemDto>(shopItem);

            return dto;
        }

        public async Task<ShopItemDto> GetByIdWithDiscount(int id)
        {
            var dto = await GetById(id);

            dto.Price = DiscountHelper.GetDiscountPrice(dto.Price);
            // apply 10% discount;

            return dto;
        }

        public async Task Create(CreateShopItemDto shopItem)
        {
            var entity = new ShopItem
            {
                Name = shopItem.Name,
                Price = shopItem.Price
            };

            await _shopItemRepository.Create(entity);
        }

        public async Task Remove(int id)
        {
            await _shopItemRepository.Remove(id);
        }
    }
}
