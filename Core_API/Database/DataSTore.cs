using Core_API.Models;

namespace Core_API.Database
{
    public class Categories : List<Category>
    {
        public Categories()
        {
            Add(new Category() { CategoryId=1,CategoryName="C1"});
            Add(new Category() { CategoryId = 2, CategoryName = "C2" });
            Add(new Category() { CategoryId = 3, CategoryName = "C3" });
        }
    }

    public class Products : List<Product> 
    {
        public Products()
        {
            Add(new Product() { ProductId=101,ProductName="P1",Price=1000,CategoryId=1});
            Add(new Product() { ProductId = 102, ProductName = "P2", Price = 1000, CategoryId = 2 });
            Add(new Product() { ProductId = 103, ProductName = "P3", Price = 1000, CategoryId = 3 });
            Add(new Product() { ProductId = 104, ProductName = "P4", Price = 1000, CategoryId = 1 });
            Add(new Product() { ProductId = 105, ProductName = "P5", Price = 1000, CategoryId = 2 });
            Add(new Product() { ProductId = 106, ProductName = "P5", Price = 1000, CategoryId = 3 });
        }
    }
}
