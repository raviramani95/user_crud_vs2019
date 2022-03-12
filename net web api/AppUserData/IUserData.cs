﻿using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.AppUserData
{
    public interface IUserData
    {
        List<AppUser> GetUsers();

        AppUser GetUser(int id);

        AppUser AddUser(AppUser appUser);

        void DeleteUser(AppUser appUser);

        AppUser EditUser(AppUser appUser);
    }
}