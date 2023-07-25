using CategoryService.Models;
using CategoryService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CategoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        IRepoService<Category, int> catServ;

        public CategoryController(IRepoService<Category, int> catServ)
        {
            this.catServ = catServ;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var response = await catServ.GetAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await catServ.GetAsyc(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Category c)
        {
            var result = await catServ.CreateAsync(c);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Category c)
        {
            var result = catServ.UpdateAsync(id,c);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await catServ.DeleteAsync(id);
            return Ok(response);
        }

    }
}
