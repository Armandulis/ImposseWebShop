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
                isAdmin = true,
                Picture = "https://img.thedailybeast.com/image/upload/c_crop,d_placeholder_euli9k,h_1440,w_2560,x_0,y_0/dpr_2.0/c_limit,w_740/fl_lossy,q_auto/v1531451526/180712-Weill--The-Creator-of-Pepe-hero_uionjj"

            };

            var user2 = new User()
            {
                Firstname = "lars",
                Lastname = "the web master",
                Username = "User",
                PasswordHash = passwordHashA,
                PasswordSalt = passwordSaltA,
                isAdmin = true,
                Picture = "https://fsmedia.imgix.net/77/4f/7a/cf/6327/4cc2/a533/4fbb91a213ca/spongbob.jpeg?rect=0%2C47%2C750%2C375&dpr=2&auto=format%2Ccompress&w=650"

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
