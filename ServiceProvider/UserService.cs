using BankManagmentSystem.Models;
using BankManagmentSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagmentSystem.ServiceProvider
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(UserService));

        public UserService(IUserRepo Repository)
        {
            _userRepo = Repository;
        }


        public User GetUserDetails(string id)
        {
            _log4net.Info("Calling GetCustomer method of repository from service");
            return _userRepo.GetUserDetails(id);
        }

        public User AuthenticateUser(string username, string password)
        {
            _log4net.Info("Calling CheckCredentials method of repository from service");
            User user = _userRepo.AuthenticateUser(username, password);
            return user;
        }

       
        public string UpdateUserDetails(string id, User user)//use only one parameter
        {
            _log4net.Info("Calling Update method of repository from service");
            return _userRepo.UpdateUserDetails(id, user);
        }

        public string AddUserDetails(User entity)
        {
            _log4net.Info("Calling AddCustomer method of repository from service");
           
            return _userRepo.AddUserDetails(entity);

        }
    }
}
