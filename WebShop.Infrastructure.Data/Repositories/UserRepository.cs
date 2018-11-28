﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Core.DomainService;
using WebShop.Core.Entity;

namespace WebShop.Infrastructure.Data.Repositories
{
   
   public class UserRepository : IUserRepository
    {
        readonly WebShopContext _ctx;

        public UserRepository(WebShopContext context)
        {
            _ctx = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _ctx.User.ToList();
        }

        public User UserGet(int id)
        {
            return _ctx.User.FirstOrDefault(b => b.Id == id);
        }

        public User UserAdd(User entity)
        {
         var user = _ctx.User.Add(entity).Entity;
            _ctx.SaveChanges();
            return user;
        }

        public void UserEdit(User entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void UserRemove(int id)
        {

            var item = _ctx.User.FirstOrDefault(b => b.Id == id);
            _ctx.User.Remove(item);
            _ctx.SaveChanges();
        }

    }
}