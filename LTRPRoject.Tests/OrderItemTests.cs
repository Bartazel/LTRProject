using LTRProject.Entities;
using NUnit.Framework;

namespace LTRProject.Tests
{
    [TestFixture]
    public class OrderItemTests
    {
        [Test]
        public void NetTotalShouldReturnProductOfNetPriceAndQuantity()
        {
            // Arrange
            var orderItem = new OrderItem
            {
                NetPrice = 10,
                Quantity = 3,
                Tax = 0.17M
            };

            // Act
            decimal netTotal = orderItem.NetTotal;

            // Assert
            Assert.AreEqual(30M, netTotal);
        }

        [Test]
        public void TotalShouldReturnTotalPriceIncludingTax()
        {
            // Arrange
            var orderItem = new OrderItem
            {
                NetPrice = 10,
                Quantity = 3,
                Tax = 0.17M
            };

            // Act
            decimal total = orderItem.Total;

            // Assert
            Assert.AreEqual(35.1M, total);
        }
    }
}
