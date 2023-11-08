using Swashbuckle.AspNetCore.Annotations;

namespace LTRProject.Models
{
    public class OrderResponse
    {
        public OrderResponse(
            decimal netTotal,
            decimal tax,
            decimal total,
            IEnumerable<OrderItemResponse> orderItems)
        {
            NetTotal = netTotal;
            Tax = tax;
            Total = total;
            OrderItems = orderItems;
        }

        [SwaggerSchema(Description = "Net value of the order")]
        public decimal NetTotal { get; set; }
        [SwaggerSchema(Description = "Tax value of the order")]
        public decimal Tax { get; set; }
        [SwaggerSchema(Description = "Gross value of the order")]
        public decimal Total { get; set; }
        [SwaggerSchema(Description = "List of order items")]
        public IEnumerable<OrderItemResponse> OrderItems { get; set; }
    }

    public class OrderItemResponse
    {
        public OrderItemResponse(
            decimal netPrice,
            int quantity,
            decimal netTotal,
            decimal total)
        {
            NetPrice = netPrice;
            Quantity = quantity;
            NetTotal = netTotal;
            Total = total;
        }

        [SwaggerSchema(Description = "Net price of single merchandise")]
        public decimal NetPrice { get; set; }
        [SwaggerSchema(Description = "Quantity of merchandise")]
        public int Quantity { get; set; }
        [SwaggerSchema(Description = "Net value of the order")]
        public decimal NetTotal { get; set; }
        [SwaggerSchema(Description = "Gross value of the order")]
        public decimal Total { get; set; }
    }
}
