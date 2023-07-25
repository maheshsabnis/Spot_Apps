using ProductService.Database;
using ProductService.Models;

namespace ProductService.Services
{
    public class ProductRepoService
    {
        Products prds = new Products();

        public IEnumerable<Product> GetProducts() 
        {
            return prds;
        }

        public IEnumerable<Product> AddProduct(Product p)
        {
            prds.Add(p);
            return prds;
        }
    }
}
