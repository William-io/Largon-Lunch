namespace Largon_Lunch.Domain.StoreContext.Entities
{
    public class Product
    {
        public Product(
            string title,
            string description, 
            string image,
            string price, 
            string quantityOnHand)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantityOnHand;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string QuantityOnHand { get; set; }
    }
}
