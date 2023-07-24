using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        ProductService prdServ;

        public ProductController(ProductService s)
        {
            prdServ = s;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(prdServ.GetProducts());
        }

        [HttpPost]
        public IActionResult Post(Product c)
        {
            var result = prdServ.AddProduct(c);
            return Ok(result);
        }

    }
}
