using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace LTRProject.Models
{
    public class OrderRequest
    {
        public OrderRequest(
            List<OrderItemRequest> orderItems,
            decimal tax) 
        {
            OrderItems = orderItems;
            Tax = tax;
        }

        [Required]
        [SwaggerSchema(Description = "List of order items")]
        public List<OrderItemRequest> OrderItems { get; set; }
        [Required]
        [SwaggerSchema(Description = "Tax imposed on merchandise")]
        public decimal Tax { get; set; }
    }

    public class OrderItemRequest
    {
        public OrderItemRequest(
            decimal netPrice,
            int quantity)
        {
            NetPrice = netPrice;
            Quantity = quantity;
        }

        [Required]
        [SwaggerSchema(Description = "Net price of single merchandise")]
        public decimal NetPrice { get; set; }
        [Required]
        [SwaggerSchema(Description = "Quantity of merchandise")]
        public int Quantity { get; set; }
    }
}
