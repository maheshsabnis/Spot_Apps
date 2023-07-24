using Core_API.Database;
using Core_API.Models;

namespace Core_API.Services
{
    public class CategoryService
    {
        Categories cats = new Categories();

        public IEnumerable<Category> GetCategories() 
        {
            return cats;
        }

        public IEnumerable<Category> AddCategor(Category c)
        {
            cats.Add(c);
            return cats;
        }
    }
}
