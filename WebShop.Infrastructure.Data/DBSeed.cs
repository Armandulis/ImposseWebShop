using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Infrastructure.Data
{
    public class DBSeed
    {
        public static void SeedDB(WebShopContext ctx)
        {   
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();


        }

    }
}
