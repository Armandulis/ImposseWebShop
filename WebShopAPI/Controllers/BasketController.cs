using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Core.ApplicationService;
using WebShop.Core.Entity;
using WebShop.Infrastructure.Data;

namespace WebShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _service;
        private readonly WebShopContext _ctx;

        public BasketController(IBasketService basketService, WebShopContext context)
        {
            _service = basketService;
            _ctx = context;
        }

        // GET: api/Basket/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Basket> Get(int id)
        {
            return _service.GetBasket(id);
        }

        // POST: api/Basket
        [HttpPost]
        public void Post([FromBody] Basket basket)
        {
            _service.NewBasket(basket);
        }

        // PUT: api/Basket/5
        [HttpPut("{id}")]
        public void Put(int id, [FromQuery] bool clear, [FromBody] Product product)
        {
            if (clear)
            {
                _service.ClearBasket(id);
                return;
            }
            _service.AddToBasket(id, product);
        }

        // DELETE: api/Basket/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.DeleteBasket(id);
        }
    }
}
