using BankManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagmentSystem.ServiceProvider
{
    public interface IUserService
    {
         User GetUserDetails(string id);//dont add acce

         User AuthenticateUser(string username,string password);

         string AddUserDetails(User entity);

         string UpdateUserDetails(string id, User user);
    }
}
