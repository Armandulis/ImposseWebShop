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
            // DELETES AND CREATES DATABASE
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();


            var password = "Password";
            // HASHES PASWORDS
            byte[] passwordHashA, passwordSaltA, passwordHashAdmin, passwordSaltAdmin;

            CreatePasswordHash(password, out passwordHashA, out passwordSaltA);
            CreatePasswordHash(password, out passwordHashAdmin, out passwordSaltAdmin);

            // CEATING USERS
            var user1 = new User()
            {
                Firstname = "Generic name",
                Lastname = "Generic lastname",
                Username = "Admin",
                PasswordHash = passwordHashAdmin,
                PasswordSalt = passwordSaltAdmin,
                isAdmin = true
            };

            var user2 = new User()
            {
                Firstname = "lars",
                Lastname = "the web master",
                Username = "User",
                PasswordHash = passwordHashA,
                PasswordSalt = passwordSaltA,
                isAdmin = true
            };

            ctx.User.Add(user1);
            ctx.User.Add(user2);

            //CREATING REVIEWS
            ctx.Review.Add(new Review() {
                Comment = "Great Product",
                Rating = 5,
                User = user1,
                Product = new Product() { Name = "Shirt", Color = "Blue", Gender = "Male", Price = 200 }
                
            });

            ctx.Review.Add(new Review()
            {
                Comment = "fantastic Product",
                Rating = 5,
                User = user2,
                Product = new Product() { Name = "Dress", Color = "Blue", Gender = "Female", Price = 1200 }
            });

            //CREATING STORIES
            ctx.Story.Add(new Story()
            {
                Date = DateTime.Now,
                Title = "Pls fcking work",
                Text ="This is a Great Story",
                User = user1
            });
            ctx.Story.Add(new Story()
            {
                Date = DateTime.Now,
                Title = "u did fcking work, right?",
                Text = "This is a Great jkwbdkaj wd",
                User = user1
            });
            ctx.Story.Add(new Story()
            {
                Date = DateTime.Now,
                Title = "BBC NEWS STORY",
                Text = "TRUMP BEATS OBAMA IN ANIME CAT GIRL FIGHT",
                User = user2

            });

            //CREATING PRODUCTS
            ctx.Products.Add(new Product()
            {
                Name = "pls work wtf"
            });

            ctx.Products.Add(new Product()
            {
                Name = "a fcking shirt"
            });


            //HASHING PASSWORDS FOR USER METHODS
            

            void CreatePasswordHash(string passwordToHash, out byte[] passwordHash, out byte[] passwordSalt)
            {
                using (var hmac = new System.Security.Cryptography.HMACSHA512())
                {
                    passwordSalt = hmac.Key;
                    passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(passwordToHash));
                }
            }

            ctx.SaveChanges();
        }

    }
}
