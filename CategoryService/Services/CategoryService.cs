using CategoryService.Database;
using CategoryService.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryService.Services
{
    public class CategoryRepoService : IRepoService<Category, int>
    {

        private readonly EShoppingCodiContext _context;
        ResponseObject<Category> _response;
         
        public CategoryRepoService(EShoppingCodiContext ctx)
        {
            _context = ctx;
            _response = new ResponseObject<Category>();
        }

        async Task<ResponseObject<Category>> IRepoService<Category, int>.CreateAsync(Category entity)
        {
            var result = await _context.Categories.AddAsync(entity);
            await _context.SaveChangesAsync();
            _response.Record = result.Entity;
            return _response;
        }

        async Task<ResponseObject<Category>> IRepoService<Category, int>.DeleteAsync(int id)
        {
            var cat = await _context.Categories.FindAsync(id);
            if (cat != null)
            {
                _context.Categories.Remove(cat);
                await _context.SaveChangesAsync();
                _response.StatusMessage = "Delete";
                return _response;
            }
            _response.StatusMessage = "Not FOund";
            return _response;
        }

        async Task<ResponseObject<Category>> IRepoService<Category, int>.GetAsyc(int id)
        {
            _response.Record  = await _context.Categories.FindAsync(id);
            return _response;
        }

        async Task<ResponseObject<Category>> IRepoService<Category, int>.GetAsync()
        {
            _response.Records = await _context.Categories.ToListAsync();
            return _response;
        }

        async Task<ResponseObject<Category>> IRepoService<Category, int>.UpdateAsync(int id, Category entity)
        {
            var cat = await _context.Categories.FindAsync(id);
            if (cat != null)
            {
                cat.CategoryName = entity.CategoryName;
                cat.BasePrice = entity.BasePrice;
                await _context.SaveChangesAsync();
                _response.StatusMessage = "Updated";
                return _response;
            }
            _response.StatusMessage = "Not FOund";
            return _response;
        }
    }
}
