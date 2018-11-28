using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Core.DomainService
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User UserGet(int id);
        User UserAdd(User entity);
        void UserEdit(User entity);
        void UserRemove(int id);
    }
}