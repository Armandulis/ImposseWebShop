﻿using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.ApplicationService.Services;
using WebShop.Core.DomainService;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService
{
    public class ReviewService : IReviewService

    {
        readonly IReviewRepository _repo;

        public ReviewService(IReviewRepository repo) {
            _repo = repo;
        }

        public Review CreateReview(Review review)
        {
            return _repo.CreateReview(review);
        }

        public Review DeleteReview(int id)
        {
            return _repo.DeleteReview(id);
        }

        public IEnumerable<Review> GetAllReviews()
        {
           return _repo.GetAllReviews();
        }

        public Review GetReview(int id)
        {
            return _repo.GetReview(id);
        }

        public Review UpdateReview(Review review)
        {
            return _repo.UpdateReview(review);
        }
    }
}
