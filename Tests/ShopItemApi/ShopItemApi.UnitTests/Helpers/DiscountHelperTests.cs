using NUnit.Framework;
using ShopItemApi.Helpers;

namespace ShopItemApi.UnitTests.Helpers
{
    [TestFixture]
    public class DiscountHelperTests
    {
        [Test]
        public void GetDiscountPrice_GivenValidPrice_AppliesDiscount()
        {
            var originalPrice = 1.0M;
            var discountedPrice = DiscountHelper.GetDiscountPrice(originalPrice);
            Assert.AreEqual(0.9M, discountedPrice);
        }
    }
}
