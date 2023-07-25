namespace ProductService.Models
{
     


    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
    }
}
