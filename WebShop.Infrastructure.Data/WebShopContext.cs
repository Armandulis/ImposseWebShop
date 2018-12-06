using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Infrastructure.Data
{
    public class WebShopContext : DbContext
    {
        

        public WebShopContext(DbContextOptions<WebShopContext> option) : base(option)
        {

        }

        public WebShopContext(): base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasOne(r => r.User).WithMany(u => u.Reviews).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Review>().HasOne(r => r.Product).WithMany(p => p.Reviews).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Story>().HasOne(story => story.User).WithMany(user => user.Stories).OnDelete(DeleteBehavior.Cascade);
        }
        
        public DbSet<Review> Review { get; set; }
        public DbSet<Story> Story { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}