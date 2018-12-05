using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Core.ApplicationService;
using WebShop.Core.Entity;

namespace WebShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.ReadAllUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult<User> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater then 0");
            else return _userService.FindUserByID(id);

        }

        // POST: api/User
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return _userService.NewUser(user);
        }

        [HttpPut]
        public ActionResult<User> PutPassword([FromQuery] bool password, [FromBody] LoginInputModel login)
        {
            if (password)
            {
                User user = _userService.GetByUsername(login.Username);
                if(user == null)
                {
                    return NotFound();
                }
                _userService.SetPasswordInfo(user, login);
                _userService.UpdateUser(user);
                return user;
            }
            return BadRequest();
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public ActionResult<User> Put(int id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.Id)
            {
                return BadRequest();
            }

            return _userService.UpdateUser(user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<User> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var users = _userService.FindUserByID(id);
            if (users == null)
            {
                return NotFound();
            }

            _userService.DeleteUser(id);

            return Ok(users);
        }
    }
}
