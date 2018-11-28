using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Infrastructure.Data
{
    public class WebShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public WebShopContext(DbContextOptions<WebShopContext> option) : base(option)
        {

        }

        public WebShopContext(): base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<User>().HasOne(p => p.PreviousOwner).WithMany(o => o.OwnedPets).OnDelete(DeleteBehavior.SetNull);
        }
        
        public DbSet<Review> Review { get; set; }
        public DbSet<Story> Story { get; set; }
        public DbSet<User> User { get; set; }

    }
}