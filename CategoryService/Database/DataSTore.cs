using CategoryService.Models;

namespace CategoryService.Database
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

   
}
