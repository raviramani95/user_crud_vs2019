/*using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.AppUserData
{
    public class MockUserData : IUserData
    {
        private List<AppUser> users = new List<AppUser>()
        {
            new AppUser()
            {
                Id = 1,
                Username = "Ravi"
            },
            new AppUser()
            {
                Id = 2,
                Username = "Aushik"
            }
        };


        public AppUser AddUser(AppUser appUser)
        {
            *//*if (users.Contains(appUser)) return*//*
            this.users.Add(appUser);
            return this.GetUser(appUser.Id);
        }

        public void DeleteUser(AppUser appUser)
        {
            this.users.Remove(appUser);
        }

        public AppUser EditUser(AppUser appUser)
        {
            var user = this.GetUser(appUser.Id);
            user.Username = appUser.Username;

            return user;
        }

        public AppUser GetUser(int id)
        {

            return users.SingleOrDefault(x => x.Id == id);
        }

        public List<AppUser> GetUsers()
        {
            return users;
        }

    }
}
*/