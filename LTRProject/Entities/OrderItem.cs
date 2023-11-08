namespace LTRProject.Entities
{
    public class OrderItem
    {
        public decimal Tax { get; set; }
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
                return NetTotal + (NetTotal * Tax);
            }
        }
        public Order? Order { get; set; }
    }
}
