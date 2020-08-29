namespace Largon_Lunch.Domain.StoreContext.Entities
{
    public class OrderItem
    {
        public OrderItem(string quantity, string price)
        {
            Quantity = quantity;
            Price = price;
        }

        public Product Product { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }

    }
}
