using LTRProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LTRProject
{
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [SwaggerOperation(Summary = "Add an order", OperationId = nameof(Order))]
        [SwaggerResponse(StatusCodes.Status200OK, "Added order", typeof(OrderResponse), "application/json")]
        public OkObjectResult Order(
            [FromBody, SwaggerRequestBody("Order request payload", Required = true)] OrderRequest model)
        {
            var order = new CalculateOrder().Calculate(model.OrderItems, model.Tax);

            var response = new OrderResponse(
            order.NetTotal,
            order.Tax,
            order.Total,
            order.OrderItems.Select(x => new OrderItemResponse(
                x.NetPrice,
                x.Quantity,
                x.NetTotal,
                x.Total)));

            return Ok(response);
        }
    }
}
