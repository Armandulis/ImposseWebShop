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

            ctx.Story.Add(new Story() {
                Id = 1,
                Date = DateTime.Now,
                Text ="This is a Great Story",
                
            });

            ctx.SaveChanges();


        }

    }
}
