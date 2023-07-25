using ProductService.Models;
using ProductService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        ProductRepoService prdServ;

        public ProductController(ProductRepoService s)
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
