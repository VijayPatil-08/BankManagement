using BankManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagmentSystem.Repository
{
    public interface IUserRepo
    {
         User GetUserDetails(string id);

         User AuthenticateUser(string username, string password);

        string AddUserDetails(User entity);

        string UpdateUserDetails(string id, User user);
    }
}
