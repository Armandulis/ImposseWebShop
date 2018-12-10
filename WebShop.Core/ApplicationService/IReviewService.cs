using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService
{
    public interface IReviewService
    {
        //  Crud

        //create
        Review CreateReview(Review review);

        //read
        Review GetReview(int id);
        List<Review> GetAllReviews();

        //update
        Review UpdateReview(Review review);

        //delete
        Review DeleteReview(int id);

        //Get reviews of a product
        List<Review> GetReviewsByProduct(int productId);

        //Get reviews by user
        List<Review> GetReviewsByUser(int userId);
    }
}
