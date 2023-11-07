using LTRProject.Entities;
using NUnit.Framework;
using System.Collections.Generic;

namespace LTRProject.Tests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void NetTotalWithNullOrderItemsShouldReturnZero()
        {
            // Arrange
            var order = new Order();

            // Act
            decimal netTotal = order.NetTotal;

            // Assert
            Assert.AreEqual(0, netTotal);
        }

        [Test]
        public void NetTotalShouldReturnSumOfOrderItemNetTotals()
        {
            // Arrange
            var order = new Order
            {
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { NetPrice = 10, Quantity = 2 },
                    new OrderItem { NetPrice = 5, Quantity = 3 }
                }
            };

            // Act
            decimal total = order.NetTotal;

            // Assert
            Assert.AreEqual(35M, total);
        }

        [Test]
        public void TaxShouldReturnDifferenceBetweenTotalAndNetTotal()
        {
            // Arrange
            var order = new Order
            {
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { NetPrice = 10, Quantity = 2 },
                    new OrderItem { NetPrice = 5, Quantity = 3 }
                }
            };

            // Act
            decimal tax = order.Tax;

            // Assert
            Assert.AreEqual(5.95M, tax);
        }

        [Test]
        public void TotalWithNullOrderItemsShouldReturnZero()
        {
            // Arrange
            var order = new Order();

            // Act
            decimal total = order.Total;

            // Assert
            Assert.AreEqual(0, total);
        }

        [Test]
        public void TotalShouldReturnSumOfOrderItemTotals()
        {
            // Arrange
            var order = new Order
            {
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { NetPrice = 10, Quantity = 2 },
                    new OrderItem { NetPrice = 5, Quantity = 3 }
                }
            };

            // Act
            decimal total = order.Total;

            // Assert
            Assert.AreEqual(40.95M, total);
        }
    }
}
