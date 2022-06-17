using AutoMapper;
using Moq;
using NUnit.Framework;
using ShopItemApi.Mappings;
using ShopItemApi.Models;
using ShopItemApi.Repositories;
using ShopItemApi.Services;
using System.Threading.Tasks;

namespace ShopItemApi.UnitTests.Services
{
    [TestFixture]
    public class ShopItemServiceTests
    {
        [Test]
        public void Test2()
        {

        }

        [Test]
        public async Task Test()
        {
            ///aaa
            // Arrange
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            var mapper = config.CreateMapper();

            var shopItemRepository = new Mock<IShopItemRepository>();
            shopItemRepository
                .Setup(x => x.GetById(It.IsAny<int>()))
                .ReturnsAsync(new ShopItem()
                {
                    Id = 1,
                    Price = 1.0M
                });

            var shopItemService = new ShopItemService(shopItemRepository.Object, mapper);

            // Act
            var shopItem = await shopItemService.GetByIdWithDiscount(1);

            //Assert
            Assert.IsNotNull(shopItem);
            Assert.AreEqual(0.9, shopItem.Price);
        }
    }
}
