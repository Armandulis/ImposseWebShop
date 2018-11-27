using System;
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

            ctx.SaveChanges();

        }

    }
}
