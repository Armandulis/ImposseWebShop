using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Core.DomainService;
using WebShop.Core.Entity;

namespace WebShop.Infrastructure.Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {

        readonly WebShopContext _ctx;

        public ReviewRepository(WebShopContext ctx) {
            _ctx = ctx;
        }

        public Review CreateReview(Review review)
        {
            var newReview = _ctx.Review.Add(review).Entity;
            _ctx.SaveChanges();
            return newReview;
        }

        public Review DeleteReview(int id)
        {
            var deleteReview = _ctx.Review.Remove(GetReview(id)).Entity;
            _ctx.SaveChanges();
            return deleteReview;
        }

        public IEnumerable<Review> GetAllReviews()
        {
            return _ctx.Review;
        }

        public Review GetReview(int id)
        {
            return _ctx.Review.FirstOrDefault(review => review.Id == id);
        }

        public Review UpdateReview(Review review)
        {
            var updatedReview = _ctx.Review.Update(review).Entity;
            _ctx.SaveChanges();
            return updatedReview;
        }
    }
}
