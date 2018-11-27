using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Infrastructure.Data
{
   public class WebShopContext : DbContext
    {
        public WebShopContext(DbContextOptions<WebShopContext> option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

    }
}
