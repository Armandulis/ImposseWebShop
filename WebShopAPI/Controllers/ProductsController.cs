using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Core.ApplicationService;
using WebShop.Core.Entity;

namespace WebShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService service)
        {
            _productService = service;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetAllProducts();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public ActionResult<Product> PutProduct([FromRoute] int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.Id)
            {
                return BadRequest();
            }   

            return _productService.UpdateProduct(product);
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult<Product> PostProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return _productService.CreateProduct(product);

        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productService.DeleteProduct(id);

            return Ok(product);
        }

    }
}