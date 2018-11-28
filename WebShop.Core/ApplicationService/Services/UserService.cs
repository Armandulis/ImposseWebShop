using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Core.DomainService;
using WebShop.Core.Entity;

namespace WebShop.Core.ApplicationService.Services
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepo;
     

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
            
        }

       

        public User DeleteUser(int id)
        {
            return _userRepo.UserRemove(id);
        }

        public User FindUserByID(int id)
        {
            var user = _userRepo.UserGet(id);
            return user;
        }

        public List<Review> FindOwnedReviews(int id)
        {
            return null;
        }

        public User NewUser(User user)
        {
            return _userRepo.UserAdd(user);
        }

        public List<User> ReadAllUsers()
        {
            return _userRepo.GetAll().ToList();
        }

        public User UpdateUser(User user)
        {
            return _userRepo.UserEdit(user);
        }
    }
}