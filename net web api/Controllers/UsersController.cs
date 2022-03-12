using FirstApp.AppUserData;
using FirstApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserData _userData;

        public UsersController(IUserData userData)
        {
            _userData = userData;
        }

        [HttpGet]
       /* [Route("api/[controller]")]*/
        public IEnumerable<AppUser> GetUsers()
        {
            return _userData.GetUsers();
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userData.GetUser(id);

            if(user != null)
                return Ok(user);

            return BadRequest("user not exists");
        }

        [HttpPost]
        public IActionResult AddUser(AppUser appUser)
        {/*
            if (_userData.GetUsers().Contains(appUser))
            {
                return BadRequest("user alredy exists");
            }*/

            AppUser newUser = _userData.AddUser(appUser);
            return Ok(newUser);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var appUser = _userData.GetUser(id);

            if(appUser != null)
            {
                _userData.DeleteUser(appUser);
                return Ok($"user {appUser.Username} deleted");
            }

            return NotFound("user not exists");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, AppUser appUser)
        {
            var user = _userData.GetUser(id);
            if (user != null)
            {
                appUser.Id = user.Id;
                _userData.EditUser(appUser);
                return Ok(appUser);
            }

            return NotFound("user not found");
        }
        /*
                [HttpPost]
                public async Task<ActionResult<IEnumerable<AppUser>>> PostUser(AppUser user)
                {

                    await _context.Users.AddAsync(user);
                    await _context.SaveChangesAsync();
                    return await _context.Users.ToListAsync();

                }

                [HttpPut("{id}")]
                public async Task<ActionResult<AppUser>> PutUser(int id, AppUser user)
                {

                    var user_ = await _context.Users.FindAsync(id);
                    user_.Id = user.Id;
                    user_.UserName = user.UserName;

                    _context.Users.Update(user_);
                    await _context.SaveChangesAsync();
                    return await _context.Users.FindAsync(id);
                }

                [HttpDelete("{id}")]
                public async Task<ActionResult<IEnumerable<AppUser>>> DeleteUser(int id)
                {

                    var user = await _context.Users.FindAsync(id);

                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync();
                    return await _context.Users.ToListAsync();
                }*/
    }
}
