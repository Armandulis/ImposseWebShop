﻿using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Infrastructure.Data
{
    public class DBSeed
    {
        public static void SeedDB(WebShopContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();


            ctx.Review.Add(new Review() {
                Id = 1,
                Comment = "Great Product",
                Rating = 5
            });

            ctx.Review.Add(new Review()
            {
                Id = 2,
                Comment = "fantastic Product",
                Rating = 5
            });

            ctx.Story.Add(new Story() {
                Id = 1,
                Date = DateTime.Now,
                Title = "Pls fcking work",
                Text ="This is a Great Story",
                
            });
            ctx.Story.Add(new Story()
            {
                Id = 2,
                Date = DateTime.Now,
                Title = "u did fcking work, right?",
                Text = "This is a Great jkwbdkaj wd",

            });

            ctx.Products.Add(new Product()
            {
                Id = 1,
                Name = "pls work wtf"
            });

            ctx.Products.Add(new Product()
            {
                Id = 2,
                Name = "a fcking shirt"
            });

            ctx.User.Add(new User() {
                Id =1,
                Firstname ="Generic name",
                Lastname = "Generic lastname"
            });
            ctx.User.Add(new User()
            {
                Id = 2,
                Firstname = "lars",
                Lastname = "the web master"
            });

            ctx.SaveChanges();
        }

    }
}
