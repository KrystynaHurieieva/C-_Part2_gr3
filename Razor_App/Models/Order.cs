namespace Razor_App.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public List<Product> Products { get; set; }
    }
}
