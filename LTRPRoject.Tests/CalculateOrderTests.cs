using LTRProject.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LTRProject.Tests
{
    [TestFixture]
    public class CalculateOrderTests
    {
        [Test]
        public void CalculateSingleOrderItemCalculatesOrder()
        {
            // Arrange
            var calculator = new CalculateOrder();
            var orderItemRequests = new List<OrderItemRequest>
        {
            new OrderItemRequest(10.0M, 2)
        };
            decimal tax = 0.1m;

            // Act
            var result = calculator.Calculate(orderItemRequests, tax);
            var resultOrderItems = result.OrderItems?.ToList();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, resultOrderItems?.Count);
            Assert.AreEqual(2, resultOrderItems?[0].Quantity);
            Assert.AreEqual(10.0m, resultOrderItems?[0].NetPrice);
            Assert.AreEqual(0.1m, resultOrderItems?[0].Tax);
            Assert.AreEqual(result, resultOrderItems?[0].Order);
        }

        [Test]
        public void CalculateMultipleOrderItemsCalculatesOrder()
        {
            // Arrange
            var calculator = new CalculateOrder();
            var orderItemRequests = new List<OrderItemRequest>
        {
            new OrderItemRequest(10.0M, 2),
            new OrderItemRequest(5.0M, 3)
        };
            decimal tax = 0.1m;

            // Act
            var result = calculator.Calculate(orderItemRequests, tax);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.OrderItems?.Count);
            Assert.AreEqual(35.0M, result.NetTotal);
            Assert.AreEqual(3.5M, result.Tax);
            Assert.AreEqual(38.5M, result.Total);
        }
    }
}