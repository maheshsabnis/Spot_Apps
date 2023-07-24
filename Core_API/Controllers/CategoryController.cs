using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        CategoryService catServ;

        public CategoryController(CategoryService s)
        {
            catServ = s;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(catServ.GetCategories());
        }

        [HttpPost]
        public IActionResult Post(Category c)
        {
            var result = catServ.AddCategor(c);
            return Ok(result);
        }

    }
}
