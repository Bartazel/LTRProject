using LTRProject.Entities;
using LTRProject.Models;

namespace LTRProject
{
    public class CalculateOrder
    {
        public Order Calculate(
            List<OrderItemRequest> orderItemRequests,
            decimal tax)
        {
            List<OrderItem> orderItems = new List<OrderItem> ();
            Order order= new Order ();

            foreach (var orderItem in orderItemRequests) 
            {
                orderItems.Add(new OrderItem
                {
                    NetPrice = orderItem.NetPrice,
                    Quantity = orderItem.Quantity,
                    Tax = tax,
                    Order = order
                });
            }

            order.OrderItems = orderItems;

            return order;
        }
    }
}
