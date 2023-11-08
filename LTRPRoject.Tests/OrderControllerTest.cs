using LTRProject.Models;
using LTRProject;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;

namespace LTRPRoject.Tests
{
    [TestFixture]
    public class OrderControllerTests
    {
        [Test]
        public void OrderReturnsOkObjectResult()
        {
            // Arrange
            var controller = new OrderController();
            var orderRequest = new OrderRequest(
                new List<OrderItemRequest>
                {
                    new OrderItemRequest(10.0M, 2),
                    new OrderItemRequest(5.0M, 3)
                },
                0.1m);

            // Act
            IActionResult result = controller.Order(orderRequest);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
        }
    }
}
