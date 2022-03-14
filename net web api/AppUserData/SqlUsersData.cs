/*using FirstApp.AppUserData;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using net_web_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_web_api.AppUserData
{
    public class SqlUsersData : IUserData
    {
        private readonly UserContext _context;

        public SqlUsersData(UserContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<AppUser>>> AddUser(AppUser appUser)
        {
           *//* var users = GetUsers().Count();*//*
            await _context.Users.AddAsync(appUser);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync(); ;
        }

        public void DeleteUser(AppUser appUser)
        {
            throw new NotImplementedException();
        }

        public AppUser EditUser(AppUser appUser)
        {
            throw new NotImplementedException();
        }

        public AppUser GetUser(int id)
        {
            return _context.Users.Find(id);
        }

        public List<AppUser> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
*/