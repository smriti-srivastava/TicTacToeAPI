using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TicTacToeAPI.RepositoryLayer;

namespace TicTacToeAPI.BusinessLayer
{
    public class UserService
    {
        UserRepository repository;
        public UserService()
        {
            repository = new UserRepository();
        }
        public string RegisterUser(User user)
        {
            user.AccessToken = AccessTokenGenerator.GenerateToken(user.EmailId);
            if (repository.Create(user))
            {
                return user.AccessToken;
            }
            return null;
        }
    }
}
