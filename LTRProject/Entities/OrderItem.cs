namespace LTRProject.Entities
{
    public class OrderItem
    {
        private const decimal tax = 0.17M;
        public decimal NetPrice { get; set; }
        public int Quantity { get; set; }
        public decimal NetTotal
        {
            get
            {
                return NetPrice * Quantity;
            }
        }
        public decimal Total
        {
            get
            {
                return NetTotal + (NetTotal * tax);
            }
        }
        public Order? Order { get; set; }
    }
}
