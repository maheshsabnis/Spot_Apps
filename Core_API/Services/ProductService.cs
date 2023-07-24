using Core_API.Database;
using Core_API.Models;

namespace Core_API.Services
{
    public class ProductService
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
