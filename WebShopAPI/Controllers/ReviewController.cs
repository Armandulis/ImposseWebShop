using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Core.ApplicationService.Services;
using WebShop.Core.Entity;

namespace WebShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {

        readonly IReviewService _reviewService;
        public ReviewController(IReviewService reviewService) {
            _reviewService = reviewService;
        }

        // GET: api/Review
        [HttpGet]
        public IEnumerable<Review> Get()
        {
            return _reviewService.GetAllReviews();
        }

        // GET: api/Review/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Review> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater then 0");
            else return _reviewService.GetReview(id);
        }

        // POST: api/Review
        [HttpPost]
        public ActionResult<Review> Post([FromBody] Review review)
        {
            if (review.Rating == null) return BadRequest("Review must have Rating");
            //if (review.Product == null) return BadRequest("Review must have Product");
            // if (review.User == null) return BadRequest("Review must have User");

            else return _reviewService.CreateReview(review);
        }

        // PUT: api/Review/5
        [HttpPut("{id}")]
        public ActionResult<Review> Put(int id, [FromBody] Review review)
        {

            return Ok(_reviewService.UpdateReview(review));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Review> Delete(int id)
        {
            var review = _reviewService.DeleteReview(id);
            if (review == null)
            {
                return StatusCode(404, "Did not find review with ID " + id);
            }

            return Ok($"Customer with Id: {id} is Deleted");

        }
    }
}
