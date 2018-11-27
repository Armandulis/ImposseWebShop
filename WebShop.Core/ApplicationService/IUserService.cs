using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService
{
    public interface IUserService
    {
        //CRUD
        User NewUser(User user);
        User DeleteUser(int id);
        List<User> ReadAllUsers();
        User FindUserByID(int id);
        User UpdateUser(User user);
       // List<Reviews> FindOwnedReviews(int id);
    }
}
