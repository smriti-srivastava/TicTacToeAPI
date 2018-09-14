﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToeAPI.RepositoryLayer;

namespace TicTacToeAPI.BusinessLayer
{
    public class AutherizeService
    {
        public static bool Autherize(string accessToken)
        {
            UserRepository repository = new UserRepository();
            List<User> users = repository.GetAll();
            return users.Contains(users.Find(user => user.AccessToken == accessToken));
        }
    }
}
