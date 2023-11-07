namespace LTRProject.Entities
{
    public class Order
    {
        public decimal NetTotal
        {
            get
            {
                if (OrderItems == null)
                    return 0;
                decimal sum = 0;
                foreach (OrderItem orderItem in OrderItems)
                {
                    sum += orderItem.NetTotal;
                }
                return sum;
            }
        }
        public decimal Tax
        {
            get
            {
                return Total - NetTotal;
            }
        }
        public decimal Total
        {
            get
            {
                if (OrderItems == null)
                    return 0;
                decimal sum = 0;
                foreach (OrderItem orderItem in OrderItems)
                {
                    sum += orderItem.Total;
                }
                return sum;
            }
        }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
