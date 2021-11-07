using DortadimIdentityServer.API1.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DortadimIdentityServer.API1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [Authorize(Policy = "ReadProduct")]
        [HttpGet] //:api/product/GetProducts
        public IActionResult GetProducts()
        {
            var productList = new List<Product>()
            {
                new Product{Id=1,Name="kalem",Price=100,Stock=500},
                new Product{Id=2,Name="MEYVE",Price=500,Stock=400},
                new Product{Id=3,Name="SEBZE",Price=400,Stock=100},
                new Product{Id=4,Name="PARÇA",Price=200,Stock=600}
            };

            return Ok(productList);
        }

        [Authorize(Policy ="UpdateOrCreate")]
        public IActionResult UpdateProduct(int id)
        {
            return Ok($"id'si {id} olan product güncellenmiştir");
        }

        [Authorize(Policy = "UpdateOrCreate")]
        public IActionResult CreateProduct(Product product)
        {
            return Ok(product);
        }

    }
}
